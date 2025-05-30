// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

import {
  Discriminator,
  Enum,
  EnumMember,
  getDiscriminator,
  getDoc,
  getEffectiveModelType,
  getFormat,
  getFriendlyName,
  getMaxLength,
  getMaxValue,
  getMinLength,
  getMinValue,
  getPattern,
  getProperty,
  getPropertyType,
  getSummary,
  isNeverType,
  isNumericType,
  isSecret,
  isStringType,
  isTemplateDeclaration,
  isUnknownType,
  Model,
  ModelProperty,
  Type,
  Union,
  isNullType,
  Scalar,
  UnionVariant,
  resolveEncodedName,
  StringLiteral,
  BooleanLiteral,
  NoTarget,
  NumericLiteral,
  Service,
  listServices,
  Program,
  getEncode,
  EncodeData,
  isRecordModelType,
  isArrayModelType,
  isType,
  getLifecycleVisibilityEnum,
  getVisibilityForClass,
} from "@typespec/compiler";
import { SdkContext, isReadOnly, getWireName } from "@azure-tools/typespec-client-generator-core";

import { reportDiagnostic } from "../lib.js";
import { AnySchema, SealedChoiceSchema, ChoiceSchema, ChoiceValue, SchemaType, ArraySchema, Schema, DictionarySchema, ObjectSchema, Discriminator as M4Discriminator, Property, StringSchema, NumberSchema, ConstantSchema, ConstantValue, BooleanSchema } from "@autorest/codemodel";
import {
  getHeaderFieldName,
  getPathParamName,
  getQueryParamName,
  isStatusCode,
  HttpOperation,
  createMetadataInfo,
  Visibility
} from "@typespec/http";
import { getPagedResult, isFixed, getUnionAsEnum } from "@azure-tools/typespec-azure-core";
import { extractPagedMetadataNested } from "./operationUtil.js";
import { pascalCase, deconstruct } from "@azure-tools/codegen";
import {
  getDefaultApiVersion,
  isApiVersion
} from "@azure-tools/typespec-client-generator-core";
// import { GetSchemaOptions, SdkContext } from "./interfaces.js";
import { getModelNamespaceName } from "./namespaceUtils.js";
import { get } from "http";
// import { KnownMediaType, hasMediaType } from "./mediaTypes.js";

export const BINARY_TYPE_UNION =
  "string | Uint8Array | ReadableStream<Uint8Array> | NodeJS.ReadableStream";

export const BINARY_AND_FILE_TYPE_UNION = `${BINARY_TYPE_UNION} | File`;
export const ANY_SCHEMA = 'any_schema';

export enum SchemaContext {
  /** Schema is used as an input to an operation. */
  Input = "input",
  /** Schema is used as an output from an operation. */
  Output = "output",
  /** Schema is used as an exception from an operation. */
  Exception = "exception"
}


export enum KnownMediaType {
  Json = "json",
  Xml = "xml",
  Form = "form",
  Binary = "binary",
  MultipartFormData = "multipart/form-data",
  Text = "text",
  Unknown = "unknown"
}
export interface GetSchemaOptions {
  // usage is used to determine the type name of the schema
  usage?: SchemaContext[];
  // default to false
  // when it is true and we would only generate a reference and not cover too many details
  needRef?: boolean;
  // relevant property which the type belongs to
  relevantProperty?: ModelProperty;
  // content types which would impact the schema
  mediaTypes?: KnownMediaType[];
  // if this type is taken as request body
  isRequestBody?: boolean;
  // if the parent type is taken as request body
  isParentRequestBody?: boolean;
}
// ToDo: binary support by xiaogang
// export function getBinaryType(usage: SchemaContext[]) {
//   return usage.includes(SchemaContext.Output)
//     ? "Uint8Array"
//     : BINARY_TYPE_UNION;
// }

// export function isByteOrByteUnion(dpgContext: SdkContext, type: Type) {
//   const schema = getSchemaForType(dpgContext, type);
//   return isBytesType(schema) || isBytesUnion(schema);
// }

function isBytesType(schema: any) {
  return (
    schema.type === "string" &&
    (schema.format === "bytes" || schema.format === "binary")
  );
}

// ToDo: by xiaogang
// function isBytesUnion(schema: any) {
//   if (!Array.isArray(schema.enum)) {
//     return false;
//   }
//   for (const ele of schema.enum) {
//     if (isBytesType(ele)) {
//       return true;
//     }
//   }
//   return false;
// }
// ToDo: for byte by xiaogang
// function refineByteType(schema: any) {
//   schema.typeName = getBinaryType([
//     SchemaContext.Input,
//     SchemaContext.Exception
//   ]);
//   schema.outputTypeName = getBinaryType([SchemaContext.Output]);
//   return schema;
// }

// export function enrichBinaryTypeInBody(schema: any) {
//   if (isBytesType(schema)) {
//     refineByteType(schema);
//   } else if (isBytesUnion(schema)) {
//     const inputType: string[] = [];
//     for (const item of schema.enum) {
//       if (isBytesType(item)) {
//         refineByteType(item);
//       }
//       // ignore the string type for input because we already have it in bytes union
//       if (getTypeName(item, [SchemaContext.Input]) !== "string") {
//         inputType.push(getTypeName(item, [SchemaContext.Input]));
//       }
//     }
//     // refine the input type
//     schema.typeName = inputType.join(" | ");
//   }
//   return schema;
// }
export let stringSchemaForEnum: StringSchema | undefined;
export let numberSchemaForEnum: NumberSchema | undefined;
export let constantSchemaForApiVersion: ConstantSchema | undefined;
export const schemaCache = new Map<Type|string, Schema>();
// Add this to the modelSet to avoid circular reference
export const modelSet = new Set<Type>();
// For the models that are delayed to be set, currently the only case is the model that is derived from the model with discriminator
export const delayedModelSet = new Set<Type>();
export function getSchemaForApiVersion(dpgContext: SdkContext, typeInput: Type) {
  if (constantSchemaForApiVersion) {
    return constantSchemaForApiVersion;
  }
  constantSchemaForApiVersion = new ConstantSchema("apiVersion", "The version of the API.");
  constantSchemaForApiVersion.valueType = getSchemaForType(dpgContext, typeInput);
  constantSchemaForApiVersion.value = new ConstantValue(getEnrichedDefaultApiVersion(dpgContext.program, dpgContext));
  return constantSchemaForApiVersion;
}
export function getSchemaForType(
  dpgContext: SdkContext,
  typeInput: Type,
  options?: GetSchemaOptions
): any {
  const program = dpgContext.program;
  const { usage } = options ?? {};
  const type = getEffectiveModelFromType(program, typeInput);
  if (schemaCache.has(type)) {
    return schemaCache.get(type);
  }
  const builtinType = getSchemaForLiteral(type);
  if (builtinType !== undefined) {
    // add in description elements for types derived from primitive types (SecureString, etc.)
    const doc = getDoc(program, type);
    if (doc) {
      builtinType.description = doc;
    }
    schemaCache.set(type, builtinType);
    return builtinType;
  }

  if (type.kind === "ModelProperty") {
    const typeSchema: Schema = getSchemaForType(dpgContext, type.type, options);
    if (isStringType(program, type.type) || isNumericType(program, type.type)) {
      // applyIntrinsicDecorators for string and numeric types
      // unlike m4, min/max length and pattern, secrets, etc. are not part of the schema
      let propertySchema = { ...typeSchema };
      propertySchema = applyIntrinsicDecorators(dpgContext, type, propertySchema);
      propertySchema.language.default.name = type.name;
      propertySchema.language.default.description = getDoc(program, type) || "";
      schemaCache.set(type, <Schema>propertySchema);
      return propertySchema;
    } else {
      return typeSchema;
    }
  }

  if (type.kind === "Model") {
    if (modelSet.has(type)) {
      return undefined;
    } else {
      modelSet.add(type);
    }
    const schema = getSchemaForModel(dpgContext, type, options) as any;
    if (isAnonymousObjectSchema(schema)) {
      if (Object.keys(schema.properties ?? {}).length === 0) {
        // Handle empty anonymous model as Record
        // schema.typeName =
        //   // schema.type === "object" ? SchemaType.Dictionary : SchemaType.Any;
        //   schema.type === "object" ? "Record<string, unknown>" : "unknown";
        // if (usage && usage.includes(SchemaContext.Output)) {
        //   schema.outputTypeName =
        //     schema.type === "object" ? "Record<string, any>" : "any";
        // }
        // by xiaogang, we only need on any schema for empty anonymous model
        if (schemaCache.has(ANY_SCHEMA)) {
          return schemaCache.get(ANY_SCHEMA);
        }
        schema.type = SchemaType.Any;
        schemaCache.set(ANY_SCHEMA, schema);
        return schema;
      } else {
        // Handle non-empty anonymous model as inline model
        if (usage && usage.includes(SchemaContext.Output)) {
          schema.outputTypeName = getModelInlineSigniture(schema, {
            usage: [SchemaContext.Output]
          });
        }
        schema.typeName = getModelInlineSigniture(schema, {
          usage: [SchemaContext.Input]
        });
        schema.type = "object";
      }
    } else if (
      !isArrayModelType(program, type) &&
      !isRecordModelType(program, type)
    ) {
      if (usage && usage.includes(SchemaContext.Output)) {
        schema.outputTypeName = `${schema.name}Output`;
      }
      schema.typeName = `${schema.language.default.name}`;
    }
    schema.usage = usage;
    schemaCache.set(type, schema);
    return schema;
  } else if (type.kind === "Union") {
    const schema = getSchemaForUnion(dpgContext, type, options);
    if (schema) {
      schemaCache.set(type, schema);
    }
    return schema;
  } else if (type.kind === "UnionVariant") {
    const schema = getSchemaForUnionVariant(dpgContext, type, options);
    schemaCache.set(type, schema);
    return schema;
  } else if (type.kind === "Enum") {
    const schema = getSchemaForEnum(dpgContext, type);
    schemaCache.set(type, schema);
    return schema;
  } else if (type.kind === "Scalar") {
    const schema = getSchemaForScalar(dpgContext, type, options);
    schemaCache.set(type, schema);
    return schema;
  } else if (type.kind === "EnumMember") {
    //ToDo: by xiaogang, need to confirm
    return getSchemaForEnumMember(program, type);
  }
  if (isUnknownType(type)) {
    // Unknown type, return any schema
    if (schemaCache.has(ANY_SCHEMA)) {
      return schemaCache.get(ANY_SCHEMA);
    }
    const returnType = new AnySchema("any");
    schemaCache.set(ANY_SCHEMA, returnType);
    return returnType;
  }
  if (isNeverType(type)) {
    return { type: "never" };
  }
  if (isNullType(type)) {
    return { type: "null" };
  }
  // reportDiagnostic(program, {
  //   code: "invalid-schema",
  //   format: { type: type.kind },
  //   target: type
  // });
  function addValidation(schema: Schema, type: ModelProperty) {
    if (isStringType(program, type.type)) {
      (<any>schema).minLength = getMinLength(program, type);
      (<any>schema).maxLength = getMaxLength(program, type);
      (<any>schema).pattern = getPattern(program, type);
    } else if (isNumericType(program, type.type)) {
      (<any>schema).minimum = getMinValue(program, type);
      (<any>schema).maximum = getMaxValue(program, type);
    }
  }
  return undefined;
}
export function getEffectiveModelFromType(program: Program, type: Type): Type {
  if (type.kind === "Model" && type.name === "") {
    const effective = getEffectiveModelType(program, type, isSchemaProperty);
    if (effective.name) {
      return effective;
    }
  }
  function isSchemaProperty(property: ModelProperty) {
    const headerInfo = getHeaderFieldName(program, property);
    const queryInfo = getQueryParamName(program, property);
    const pathInfo = getPathParamName(program, property);
    const statusCodeInfo = isStatusCode(program, property);
    return !(headerInfo || queryInfo || pathInfo || statusCodeInfo);
  }
  return type;
}
export function includeDerivedModel(
  model: Model,
  needRef: boolean = false
): boolean {
  return (
    !needRef &&
    !isTemplateDeclaration(model) &&
    (!model.templateMapper ||
      !model.templateMapper.args ||
      model.templateMapper.args?.length === 0 ||
      model.derivedModels.length > 0)
  );
}

function applyEncoding(
  dpgContext: SdkContext,
  typespecType: Scalar | ModelProperty,
  target: any = {}
) {
  const encodeData = getEncode(dpgContext.program, typespecType);
  if (encodeData) {
    const newTarget = { ...target };
    const newType = getSchemaForScalar(dpgContext, encodeData.type);
    newTarget["type"] = newType["type"];
    newTarget["typeName"] = newType["typeName"];
    newTarget["outputTypeName"] = newType["outputTypeName"];
    // If the target already has a format it takes priority. (e.g. int32)
    newTarget["format"] = mergeFormatAndEncoding(
      newTarget.format,
      encodeData.encoding || '',
      newType["format"]
    );
    return newTarget;
  }
  return target;
}

function mergeFormatAndEncoding(
  format: string | undefined,
  encoding: string,
  encodeAsFormat: string | undefined
): string {
  switch (format) {
    case undefined:
      return encodeAsFormat ?? encoding;
    case "date-time":
      return encoding;
    case "duration":
    default:
      return encodeAsFormat ?? encoding;
  }
}

function getSchemaForScalar(
  dpgContext: SdkContext,
  scalar: Scalar,
  options?: GetSchemaOptions
) {
  let result = {} as any;
  const isStd = dpgContext.program.checker.isStdType(scalar);
  const {
    relevantProperty,
    isRequestBody,
    isParentRequestBody,
    mediaTypes: contentTypes
  } = options ?? {};
  if (isStd) {
    result = getSchemaForStdScalar(dpgContext, scalar, {
      relevantProperty
    });
  } else if (scalar.baseScalar) {
    result = getSchemaForScalar(dpgContext, scalar.baseScalar);
  }
  result.language = {};
  result.language.default = {};
  result.language.default.description = getDoc(dpgContext.program, scalar) || "";
  result.language.default.name = scalar.name;
  if (isBinaryAsRequestBody()) {
    // bytes in the body of application/octet-stream is the raw binary payload/file
    result.typeName = BINARY_TYPE_UNION;
    result.outputTypeName = "Uint8Array";
    return result;
  } else if (isFormDataBytesInRequestBody()) {
    // bytes inside a multipart part (for now) is assumed to be file
    result.typeName = BINARY_AND_FILE_TYPE_UNION;
    result.outputTypeName = "Uint8Array";
    return result;
  } else {
    // for other cases we would trust the @encode decorator if not present we would treat it as string
    const withDecorators = applyEncoding(
      dpgContext,
      scalar,
      result
        ? applyIntrinsicDecorators(dpgContext, scalar, result)
        : undefined
    );
    if (
      withDecorators.type === "string" &&
      withDecorators.format === "binary"
    ) {
      withDecorators.typeName = BINARY_TYPE_UNION;
      withDecorators.outputTypeName = "Uint8Array";
    }
    if (withDecorators.type === "string") {
      handleFormat(withDecorators);
    }
    return withDecorators;
  }

  function handleFormat(schema: any) {
    switch (schema.format) {
      case "uri":
        schema.type = SchemaType.Uri;
        break;
      case "date-time":
        schema.type = SchemaType.DateTime;
        break;
      case "base64url":
        schema.type = SchemaType.ByteArray;
        break;
    }
  }
  function isBinaryAsRequestBody() {
    return false;
    // ToDO: by xiaogang
    // return (
    //   hasMediaType(KnownMediaType.Binary, contentTypes) &&
    //   isRequestBody &&
    //   isBytesType(result)
    // );
  }

  function isFormDataBytesInRequestBody() {
    return false;
    // ToDo: by xiaogang
    // return (
    //   hasMediaType(KnownMediaType.MultipartFormData, contentTypes) &&
    //   isParentRequestBody &&
    //   isBytesType(result)
    // );
  }
}

function getChoiceValueForUnionVariant(
  dpgContext: SdkContext,
  variant: UnionVariant | EnumMember,
  value: string | number
): ChoiceValue {
  const enumType = new ChoiceValue(pascalCase(deconstruct(value.toString())), getDoc(dpgContext.program, variant) || "", value);
  return enumType;
}

function getSchemaForUnion(
  dpgContext: SdkContext,
  union: Union,
  options?: GetSchemaOptions
) {
  const nonNullOptions = [...union.variants.values()]
    .map((x) => x.type)
    .filter((t) => !isNullType(t));
  if (nonNullOptions.length === 0) {
    return {};
  }
  let schema = null;
  //Yabo: when union contains only one schema, return the schema, otherwise treat it as enum
  if (nonNullOptions.length === 1) {
    //Yabo: how to deal with x-nullable?
    const nullable = union.variants.size !== nonNullOptions.length;
    schema = getSchemaForType(dpgContext, nonNullOptions[0], options);
  } else {
    const values = [];
    const [asEnum, _] = getUnionAsEnum(union);
    if (asEnum) {
      schema = new SealedChoiceSchema(union.name || "", getDoc(dpgContext.program, union) || "");
      for (const [name, member] of asEnum.flattenedMembers.entries()) {
        values.push(getChoiceValueForUnionVariant(dpgContext, member.type, member.value));
      }
      schema.choices = values;
      // ToDo: by xiaogang, add support for other types of enum except string
      schema.choiceType = new StringSchema("enum", "string schema for enum");
    }
    //Yabo: if not able to flatten as enum, return empty
  }
  return schema;
}

function getSchemaForUnionVariant(
  dpgContext: SdkContext,
  variant: UnionVariant,
  options?: GetSchemaOptions
): Schema {
  const schema = new ConstantSchema(variant.name.toString(), getDoc(dpgContext.program, variant) || "");
  schema.valueType = getSchemaForType(dpgContext, variant.type, options);
  schema.value = new ConstantValue(variant.name.toString());
  return schema;
}

// An openapi "string" can be defined in several different ways in typespec
function isOasString(type: Type): boolean {
  if (type.kind === "String") {
    // A string literal
    return true;
  } else if (type.kind === "Model" && type.name === "string") {
    // string type
    return true;
  } else if (type.kind === "Union") {
    // A union where all variants are an OasString
    return [...type.variants.values()].every((o) => isOasString(o));
  } else if (type.kind === "UnionVariant") {
    // A union variant where the type is an OasString
    return isOasString(type.type);
  }
  return false;
}

function isStringLiteral(type: Type): boolean {
  return (
    type.kind === "String" ||
    (type.kind === "Union" && [...type.variants.values()].every((o) => isOasString(o))) ||
    (type.kind === "EnumMember" &&
      typeof (type.value ?? type.name) === "string") ||
    (type.kind === "UnionVariant" && type.type.kind === "String")
  );
}

// Return any string literal values for type
function getStringValues(type: Type): string[] {
  switch (type.kind) {
    case "String":
      return [type.value];
    case "Union":
      return [...type.variants.values()]
        .flatMap((x) => getStringValues(x.type))
        .filter((x) => x !== undefined);
    case "EnumMember":
      return typeof type.value !== "number" ? [type.value ?? type.name] : [];
    default:
      return [];
  }
}
function validateDiscriminator(
  program: Program,
  discriminator: Discriminator,
  derivedModels: readonly Model[]
): boolean {
  const { propertyName } = discriminator;
  const retVals = derivedModels.map((t) => {
    const prop = getProperty(t, propertyName);
    if (!prop) {
      reportDiagnostic(program, {
        code: "discriminator",
        messageId: "missing",
        target: t
      });
      return false;
    }
    let retval = true;
    if (
      !isOasString(prop.type) &&
      prop.type.kind !== "EnumMember" &&
      prop.type.kind !== "Enum"
    ) {
      reportDiagnostic(program, {
        code: "discriminator",
        messageId: "type",
        target: prop
      });
      retval = false;
    }
    if (prop.optional) {
      reportDiagnostic(program, {
        code: "discriminator",
        messageId: "required",
        target: prop
      });
      retval = false;
    }
    return retval;
  });
  // Map of discriminator value to the model in which it is declared
  const discriminatorValues = new Map<string, string>();
  for (const t of derivedModels) {
    // Get the discriminator property directly in the child model
    const prop = t.properties?.get(propertyName);
    // Issue warning diagnostic if discriminator property missing or is not a string literal
    if (!prop || !isStringLiteral(prop.type)) {
      reportDiagnostic(program, {
        code: "discriminator-value",
        messageId: "literal",
        target: prop || t
      });
    }
    if (prop) {
      const vals = getStringValues(prop.type);
      vals.forEach((val) => {
        if (discriminatorValues.has(val)) {
          reportDiagnostic(program, {
            code: "discriminator",
            messageId: "duplicate",
            format: {
              val: val,
              model1: discriminatorValues.get(val)!,
              model2: t.name
            },
            target: prop
          });
          retVals.push(false);
        } else {
          discriminatorValues.set(val, t.name);
        }
      });
    }
  }
  return retVals.every((v) => v);
}
/**
 * A "schema property" here is a property that is emitted to OpenAPI schema.
 *
 * Headers, parameters, status codes are not schema properties even they are
 * represented as properties in typespec.
 */
function isSchemaProperty(program: Program, property: ModelProperty) {
  const headerInfo = getHeaderFieldName(program, property);
  const queryInfo = getQueryParamName(program, property);
  const pathInfo = getPathParamName(program, property);
  const statusCodeinfo = isStatusCode(program, property);
  return !(headerInfo || queryInfo || pathInfo || statusCodeinfo);
}

function getSdkVisibility(
  program: Program,
  type: ModelProperty
): Visibility[] | undefined {
  const lifecycle = getLifecycleVisibilityEnum(program);
  const visibility = getVisibilityForClass(program, type, lifecycle);
  if (visibility) {
    const result: Visibility[] = [];
    if (
      lifecycle.members.get("Read") &&
      visibility.has(lifecycle.members.get("Read")!)
    ) {
      result.push(Visibility.Read);
    }
    if (
      lifecycle.members.get("Create") &&
      visibility.has(lifecycle.members.get("Create")!)
    ) {
      result.push(Visibility.Create);
    }
    if (
      lifecycle.members.get("Update") &&
      visibility.has(lifecycle.members.get("Update")!)
    ) {
      result.push(Visibility.Update);
    }
    if (
      lifecycle.members.get("Delete") &&
      visibility.has(lifecycle.members.get("Delete")!)
    ) {
      result.push(Visibility.Delete);
    }
    if (
      lifecycle.members.get("Query") &&
      visibility.has(lifecycle.members.get("Query")!)
    ) {
      result.push(Visibility.Query);
    }
    return result;
  }
  return undefined;
}

function getSchemaForModel(
  dpgContext: SdkContext,
  model: Model,
  options?: GetSchemaOptions
) {
  const {
    usage,
    needRef,
    isRequestBody,
    mediaTypes: contentTypes
  } = options ?? {};
  if (isArrayModelType(dpgContext.program, model)) {
    return getSchemaForArrayModel(dpgContext, model, options);
  }

  const program = dpgContext.program;
  const overridedModelName =
    getFriendlyName(program, model) ?? getWireName(dpgContext, model);
  const fullNamespaceName =
    overridedModelName ??
    getModelNamespaceName(dpgContext, model.namespace!)
      .map((nsName) => {
        return pascalCase(deconstruct(nsName));
      })
      .join("") + model.name;
  // ToDo: need to confirm which one should be
  // let name = dpgContext.rlcOptions?.enableModelNamespace
  // ? fullNamespaceName
  // : model.name;
  let name = model.name;
  if (
    !overridedModelName &&
    model.templateMapper &&
    model.templateMapper.args &&
    model.templateMapper.args.length > 0 &&
    getPagedResult(program, model)
  ) {
    const templateTypes = model.templateMapper.args.filter((it) =>
      isType(it)
    ) as Type[];
    name =
      templateTypes
        .map((it) => {
          switch (it.kind) {
            case "Model":
              return it.name;
            case "String":
              return it.value;
            default:
              return "";
          }
        })
        .join("") + "List";
  }

  const modelSchema = new ObjectSchema(overridedModelName ?? name, getDoc(program, model) || "");
  // normalized the output name
  // modelSchema.name = normalizeName(
  //   modelSchema.name,
  //   NameType.Interface,
  //   true /** shouldGuard */
  // );
  // by xiaogang, skip ArmResourceBase
  if (model.baseModel && model.baseModel.name !== "ArmResourceBase") {
    modelSchema.parents = {
      all: [
        getSchemaForType(dpgContext, model.baseModel, {
          usage,
          needRef: true
        })
      ],
      immediate: [
        getSchemaForType(dpgContext, model.baseModel, {
          usage,
          needRef: true
        })
      ]
    };
  }
  modelSchema.language.default.name = pascalCase(deconstruct(modelSchema.language.default.name));
  if (isRecordModelType(program, model)) {
    return getSchemaForRecordModel(dpgContext, model, { usage });
  }
  // ToDo: by xiaogang
  // modelSchema.typeName = modelSchema.name;
  // if (usage && usage.includes(SchemaContext.Output)) {
  //   modelSchema.outputTypeName = modelSchema.name + "Output";
  // }

  // if (isAzureCoreErrorType(model)) {
  //   modelSchema.fromCore = true;
  // }

  if (getPagedResult(program, model)) {
    const paged = extractPagedMetadataNested(program, model);
    if (paged && paged.itemsProperty) {
      const items = paged.itemsProperty as unknown as Model;
      if (items && items.templateMapper && items.templateMapper.args) {
        const templateTypes = items.templateMapper.args.filter((it) =>
          isType(it)
        ) as Type[];
        const templateName = templateTypes
          ?.map((it) => {
            switch (it.kind) {
              case "Model":
                return it.name;
              case "String":
                return it.value;
              default:
                return "";
            }
          })
          .join("");
        // ToDo by xiaogang
        // if (
        //   paged.itemsProperty.name === "value" &&
        //   paged.nextLinkProperty?.name === "nextLink"
        // ) {
        //   modelSchema.alias = `Paged<${templateName}>`;
        //   modelSchema.outputAlias = `Paged<${templateName}Output>`;
        // }
      }
    }
  }
  modelSchema.properties = [];

  // getSchemaOrRef on all children to push them into components.schemas
  const discriminator = getDiscriminator(program, model);
  // should respect needRef for derived models unless there's a discriminator in base model
  const derivedModels = model.derivedModels.filter((dm) => {
    return includeDerivedModel(dm, discriminator ? false : needRef);
  });

  for (const child of derivedModels) {
    // Delay schema generation of those models to avoiding circular reference
    delayedModelSet.add(child);
    // const childSchema = getSchemaForType(dpgContext, child, {
    //   usage,
    //   needRef: true
    // });
    // for (const [name, prop] of child.properties) {
    //   if (name === discriminator?.propertyName) {
    //     const propSchema = getSchemaForType(dpgContext, prop.type, {
    //       usage,
    //       needRef: !isAnonymousModelType(prop.type),
    //       relevantProperty: prop
    //     });
    //     childSchema.discriminatorValue = propSchema.type.replace(/"/g, "");
    //     break;
    //   }
    // }
    // modelSchema.children?.all?.push(childSchema);
    // modelSchema.children?.immediate?.push(childSchema);
  }

  // Enable option `isPolyParent` and discriminator only when it has valid children
  if (
    discriminator &&
    derivedModels &&
    derivedModels.length > 0
  ) {
    if (!validateDiscriminator(program, discriminator, derivedModels)) {
      // appropriate diagnostic is generated in the validate function
      return {};
    }

    const { propertyName } = discriminator;
    modelSchema.discriminatorValue = propertyName;
    // ToDo: need to confirm whether still need this.
    // modelSchema.isPolyParent = true;
  }

  // applyExternalDocs(model, modelSchema);
  // by xiaogang, skip needRef
  // if (needRef) {
  //   return modelSchema;
  // }
  // by xiagang, seems no need to inherit a dictionary
  if (isRecordModelType(program, model)) {
    modelSchema.parents = {
      all: [getSchemaForRecordModel(dpgContext, model, { usage })],
      immediate: [getSchemaForRecordModel(dpgContext, model, { usage })]
    };
  }
  for (const [propName, prop] of model.properties) {
    const encodedName = resolveEncodedName(program, prop, "application/json");
    const restApiName = getWireName(dpgContext, prop);
    const name = encodedName ?? restApiName ?? propName;
    if (!isSchemaProperty(program, prop)) {
      continue;
    }

    const propSchema = getSchemaForType(dpgContext, prop, {
      usage,
      needRef: isAnonymousModelType(prop.type) ? false : true,
      relevantProperty: prop,
      isParentRequestBody: isRequestBody,
      isRequestBody: false,
      mediaTypes: contentTypes
    });

    let propertyDescription;
    if (propSchema) {
      propertyDescription = getFormattedPropertyDoc(
        program,
        prop,
        propSchema
      );
      propSchema.usage = usage;
      // Use the description from ModelProperty not derived from Model Type
      (<Schema>propSchema).language = (<Schema>propSchema).language || {};
      (<Schema>propSchema).language.default = (<Schema>propSchema).language.default || {};
      (<Schema>propSchema).language.default.description = (<Schema>propSchema).language.default.description || propertyDescription || "";
      (<Schema>propSchema).language.default.name = (<Schema>propSchema).language.default.name || name;
    }
    // ToDo: need to confirm there is no duplicated properties.
    const property = new Property(name, getDoc(program, prop) || "", propSchema || new ObjectSchema(name, ""));
    if (!prop.optional) {
      property.required = true;
    }
    const vis = getSdkVisibility(program, prop);
    if (vis) {
      if (vis.includes(Visibility.Read)) {
        if (vis.length === 1) {
          property.readOnly = true;
        }
      }
      if (vis.length > 0) {
        property.extensions = property.extensions || {};
        property.extensions['x-ms-mutability'] = vis.map(v => Visibility[v].toLowerCase());
      }
    }
    if (propSchema === undefined && prop.type.kind === "Model") {
      property.extensions = property.extensions || {};
      property.extensions['circle-ref'] = pascalCase(deconstruct(prop.type.name));
    }
    let isDiscriminatorInChild = false;
    if (modelSchema.parents && modelSchema.parents.all) {
      modelSchema.parents.all.forEach((parent) => {
        if (parent.type === "object" && (<ObjectSchema>parent).discriminator?.property.serializedName === propName) {
          isDiscriminatorInChild = true;
        }
      });
    }
    if (!isDiscriminatorInChild) {
      modelSchema.properties.push(property);
    } else {
      // If discriminator value is union variant, it will be constant type
      // Otherwise, it will be sealed choice type
      modelSchema.discriminatorValue = propSchema.type === 'constant' ? (<ConstantSchema>propSchema).value.value : (<SealedChoiceSchema>propSchema).choices[0].value.toString();
    }
    if (discriminator && propName === discriminator.propertyName) {
      property.isDiscriminator = true;
      modelSchema.discriminator = new M4Discriminator(property);
    }
    // if this property is a discriminator property, remove it to keep autorest validation happy
    //const { propertyName } = getDiscriminator(program, model) || {};
    // ToDo: by xiaoang, skip polymorphism for the time being.
    // if (
    //   propertyName &&
    //   name === `"${propertyName}"` &&
    //   modelSchema.discriminator
    // ) {
    //   modelSchema.discriminator.type = propSchema.typeName ?? propSchema.type;
    //   continue;
    // }

    // Apply decorators on the property to the type's schema
    // const newPropSchema = applyIntrinsicDecorators(program, prop, propSchema);
    // if (newPropSchema === undefined) {
    //   continue;
    // }
    // Use the description from ModelProperty not devired from Model Type
    // newPropSchema.description = propertyDescription;

    // Should the property be marked as readOnly?
    // const vis = getVisibility(program, prop);
    // if (vis && vis.includes("read")) {
    //   //const mutability = [];
    //   if (vis.includes("read")) {
    //     if (vis.length > 1) {
    //       // ToDo: by xiaogang, skip it since it is not required by autorest.powershell
    //       //mutability.push(SchemaContext.Output);
    //     } else {
    //       newPropSchema["readOnly"] = true;
    //     }
    //   }
    //   if (vis.includes("write") || vis.includes("create")) {
    //     // ToDo: by xiaogang
    //     //mutability.push(SchemaContext.Input);
    //   }

    //   // if (mutability.length > 0) {
    //   //   newPropSchema["usage"] = mutability;
    //   // }
    // }
    // ToDo: skip for the time being, we need to use newPropSchema finally.
    // modelSchema.properties = modelSchema.properties?.filter(p => p.language.default.name != name);
    // modelSchema.properties.push(newPropSchema);
  }
  // Add discriminator property if it is not already present
  if (discriminator && !modelSchema.discriminator) {
    const discriminatorProperty = new Property(discriminator.propertyName, `Discriminator property for ${modelSchema.language.default.name}.`, new StringSchema("string", ""));
    discriminatorProperty.isDiscriminator = true;
    discriminatorProperty.required = true;
    modelSchema.discriminator = new M4Discriminator(discriminatorProperty);
    modelSchema.properties.push(discriminatorProperty);
  }
  return modelSchema;
}
// Map an typespec type to an OA schema. Returns undefined when the resulting
// OA schema is just a regular object schema.
function getSchemaForLiteral(type: Type): any {
  // ToDo: by xiaogang, need to implement other kinds as String
  if (type.kind) {
    let schema;
    switch (type.kind) {
      case "Number":
        schema = new ConstantSchema("", "");
        schema.valueType = new NumberSchema("Constant", "Constant number", SchemaType.Number, 64);
        schema.value = new ConstantValue(type.value);
        return schema;
      case "String":
        // generate a sealed choice schema for string literals
        schema = new SealedChoiceSchema("", "");
        schema.choiceType = new StringSchema("Constant", "Constant string");
        schema.choices = [new ChoiceValue(type.value, "", type.value)];
        return schema;
      case "Boolean":
        schema = new ConstantSchema("", "");
        schema.valueType = new BooleanSchema("Constant", "Constant boolean");
        schema.value = new ConstantValue(type.value);
        return schema;
    }
  }
  if (type.kind === undefined) {
    if (typeof type === "string") {
      return { type: `"${type}"` };
    } else if (typeof type === "number" || typeof type === "boolean") {
      return { type: `${type}` };
    }
  }
  return undefined;
}
function applyIntrinsicDecorators(
  dpgContext: SdkContext,
  type: Scalar | ModelProperty,
  target: any
): any {
  const newTarget = { ...target };
  const docStr = getDoc(dpgContext.program, type);
  const isString = isStringType(dpgContext.program, getPropertyType(type));
  const isNumeric = isNumericType(dpgContext.program, getPropertyType(type));

  if (isString && !target?.documentation && docStr) {
    newTarget.description = docStr;
  }

  if (type.kind === "ModelProperty") {
    const wireName = getWireName(dpgContext, type);
    if (wireName) {
      newTarget.name = wireName;
    }
  }
  const summaryStr = getSummary(dpgContext.program, type);
  if (isString && !target.summary && summaryStr) {
    newTarget.summary = summaryStr;
  }

  const formatStr = getFormat(dpgContext.program, type);
  if (isString && !target.format && formatStr) {
    newTarget.format = formatStr;
  }

  const pattern = getPattern(dpgContext.program, type);
  if (isString && !target.pattern && pattern) {
    newTarget.pattern = pattern;
  }

  const minLength = getMinLength(dpgContext.program, type);
  if (isString && !target.minLength && minLength !== undefined) {
    newTarget.minLength = minLength;
  }

  const maxLength = getMaxLength(dpgContext.program, type);
  if (isString && !target.maxLength && maxLength !== undefined) {
    newTarget.maxLength = maxLength;
  }

  const minValue = getMinValue(dpgContext.program, type);
  if (isNumeric && !target.minimum && minValue !== undefined) {
    newTarget.minimum = minValue;
  }

  const maxValue = getMaxValue(dpgContext.program, type);
  if (isNumeric && !target.maximum && maxValue !== undefined) {
    newTarget.maximum = maxValue;
  }

  if (isSecret(dpgContext.program, type)) {
    newTarget.type = "credential";
    newTarget["extensions"] = newTarget["extensions"] || {};
    newTarget["extensions"]["x-ms-secret"] = true;
  }

  return newTarget;
}

function getSchemaForEnumMember(program: Program, e: EnumMember) {
  const value = e.value ?? e.name;
  //const type = enumMemberType(e) === "string" ? `"${value}"` : `${value}`;
  const enumType = new ChoiceValue(pascalCase(deconstruct(value.toString())), getDoc(program, e) || "", value);
  return enumType;
}

function getSchemaForEnum(dpgContext: SdkContext, e: Enum) {
  const values = [];
  const type = enumMemberType(e.members.values().next().value);
  for (const option of e.members.values()) {
    if (type !== enumMemberType(option)) {
      reportDiagnostic(dpgContext.program, {
        code: "union-unsupported",
        target: e
      });
      continue;
    }

    values.push(getSchemaForType(dpgContext, option));
  }

  // if (values.length > 0) {
  //   schema.choices = values;
  //   // schema.type = values
  //   //   .map((item) => `${getTypeName(item, [SchemaContext.Input]) ?? item}`)
  //   //   .join(" | ");
  //   // if (!isFixed(dpgContext.program, e)) {
  //     //   schema.name = "string";
  //     //   schema.typeName = "string";
  //     // };
  //   }

  if (type === "string") {
    const schema = new SealedChoiceSchema(e.name, getDoc(dpgContext.program, e) || "");
    if (values.length > 0) {
      schema.choices = values;
    }
    if (stringSchemaForEnum === undefined) {
      stringSchemaForEnum = new StringSchema("enum", "string schema for enum");
    }
    schema.choiceType = stringSchemaForEnum;
    return schema;
  } else {
    const schema = new SealedChoiceSchema<NumberSchema>(e.name, getDoc(dpgContext.program, e) || "");
    if (values.length > 0) {
      schema.choices = values;
    }
    if (numberSchemaForEnum === undefined) {
      numberSchemaForEnum = new NumberSchema("enum", "number schema for enum", SchemaType.Number, 64);
    }
    schema.choiceType = numberSchemaForEnum;
    return schema;
  }
}

function enumMemberType(member: EnumMember | undefined) {
  if (typeof member?.value === "number") {
    return "number";
  }
  return "string";
}
/**
 * Map TypeSpec intrinsic models to open api definitions
 */
function getSchemaForArrayModel(
  dpgContext: SdkContext,
  type: Model,
  options?: GetSchemaOptions
) {
  const { program } = dpgContext;
  const { indexer } = type;
  const {
    usage,
    isParentRequestBody,
    mediaTypes: contentTypes
  } = options ?? {};
  let schema: any = {};
  if (!indexer) {
    return schema;
  }
  if (isArrayModelType(program, type)) {
    // schema = {
    //   type: "array",
    //   elementType: getSchemaForType(dpgContext, indexer.value!, {
    //     usage,
    //     isRequestBody: false,
    //     mediaTypes: contentTypes,
    //     // special handling for array in formdata
    //     // isParentRequestBody: hasMediaType(
    //     //   KnownMediaType.MultipartFormData,
    //     //   contentTypes
    //     // )
    //     //   ? isParentRequestBody
    //     //   : false,
    //     needRef: !isAnonymousModelType(indexer.value!)
    //   }),
    //   description: getDoc(program, type)
    // };
    schema = new ArraySchema("", "", getSchemaForType(dpgContext, indexer.value!));
    // circle reference, resolve it later
    if (!getSchemaForType(dpgContext, indexer.value!)) {
      schema.delayType = indexer.value!;
    }
    if (
      !program.checker.isStdType(indexer.value) &&
      !isUnknownType(indexer.value!) &&
      indexer.value?.kind &&
      schema.items?.name &&
      !schema.items.enum
    ) {
      schema.typeName = `Array<${schema.items.name}>`;
      if (usage && usage.includes(SchemaContext.Output)) {
        schema.outputTypeName = `Array<${schema.items.name}Output>`;
      }
    } else {
      if (schema.items?.typeName) {
        if (schema.items.type === "dictionary") {
          schema.typeName = `${schema.items.typeName}[]`;
        } else if (schema.items.type === "union") {
          schema.typeName = `(${schema.items.typeName})[]`;
        } else if (
          schema.items.typeName.includes(BINARY_TYPE_UNION) &&
          schema.items.type === "string"
        ) {
          schema.typeName = `(${schema.items.typeName})[]`;
          if (usage && usage.includes(SchemaContext.Output)) {
            schema.outputTypeName = `(${schema.items.outputTypeName})[]`;
          }
        } else if (isAnonymousObjectSchema(schema.items)) {
          schema.typeName = `${schema.items.typeName}[]`;
          if (usage && usage.includes(SchemaContext.Output)) {
            schema.outputTypeName = `${schema.items.outputTypeName}[]`;
          }
        } else {
          schema.typeName = schema.items.typeName
            .split("|")
            .map((typeName: string) => {
              return `${typeName}[]`;
            })
            .join(" | ");
          if (
            schema.items.outputTypeName &&
            usage &&
            usage.includes(SchemaContext.Output)
          ) {
            schema.outputTypeName = schema.items.outputTypeName
              .split("|")
              .map((typeName: string) => {
                return `${typeName}[]`;
              })
              .join(" | ");
          }
        }
      } else if ((schema.items?.type || []).includes("|")) {
        schema.typeName = `(${schema.items.type})[]`;
      } else {
        schema.typeName = `${schema.items?.type}[]`;
      }
    }
    schema.usage = usage;
    return schema;
  }
}

function getSchemaForRecordModel(
  dpgContext: SdkContext,
  type: Model,
  options?: GetSchemaOptions
) {
  const { program } = dpgContext;
  const { indexer } = type;
  const { usage } = options ?? {};
  let schema: any = {};
  if (!indexer) {
    return schema;
  }
  if (isRecordModelType(program, type)) {
    const valueType = getSchemaForType(dpgContext, indexer?.value, {
      usage,
      needRef: !isAnonymousModelType(indexer.value)
    });
    schema = {
      type: "dictionary",
      elementType: valueType,
      description: getDoc(program, type)
    };
    if (
      !program.checker.isStdType(indexer.value) &&
      !isUnknownType(indexer.value!) &&
      !isUnionType(indexer.value!)
    ) {
      schema.typeName = `Record<string, ${valueType.typeName}>`;
      schema.valueTypeName = valueType.name;
      if (usage && usage.includes(SchemaContext.Output)) {
        schema.outputTypeName = `Record<string, ${valueType.outputTypeName}>`;
        schema.outputValueTypeName = `${valueType.outputTypeName}`;
      }
    } else if (isUnknownType(indexer.value!)) {
      schema.typeName = `Record<string, ${valueType.typeName ?? valueType.type
        }>`;
      if (usage && usage.includes(SchemaContext.Output)) {
        schema.outputTypeName = `Record<string, ${valueType.outputTypeName ?? valueType.type
          }>`;
      }
    } else {
      schema.typeName = `Record<string, ${getTypeName(valueType, [
        SchemaContext.Input
      ])}>`;
      schema.outputTypeName = `Record<string, ${getTypeName(valueType, [
        SchemaContext.Output
      ])}>`;
    }
    schema.usage = usage;
    return schema;
  }
}

function isUnionType(type: Type) {
  return type.kind === "Union";
}

function getSchemaForStdScalar(
  dpgContext: SdkContext,
  type: Scalar,
  options?: GetSchemaOptions
) {
  const { relevantProperty } = options ?? {};
  if (!dpgContext.program.checker.isStdType(type)) {
    return undefined;
  }

  /**
   * lookup for @encode decorator
   *  if absent use typespec type (or default way of serializing that type)
   *  if present respect type provided in @encode
   */
  let format = undefined;
  if (relevantProperty) {
    const encodeData = getEncode(dpgContext.program, relevantProperty);
    if (encodeData && isEncodeTypeEffective(type, encodeData)) {
      type = encodeData.type;
      format = encodeData.encoding;
    }
  }
  const name = type.name;
  const description = getSummary(dpgContext.program, type);
  switch (name) {
    case "bytes":
      return { type: "string", format: "bytes", description };
    case "integer":
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "integer"
      });
    case "int8":
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "integer",
        precision: 8
      });
    case "int16":
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "integer",
        precision: 16
      });
    case "int32":
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "integer",
        precision: 32
      });
    case "int64":
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "integer",
        precision: 64
      });
    case "safeint":
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "integer",
        format: "safeint"
      });
    // ToDo: by xiaogang, need handle the following number types
    case "uint8":
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "number",
        format: "uint8"
      });
    case "uint16":
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "number",
        format: "uint16"
      });
    case "uint32":
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "number",
        format: "uint32"
      });
    case "uint64":
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "number",
        format: "uint64"
      });
    case "float64":
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "number",
        precision: 64
      });
    case "float32":
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "number",
        precision: 32
      });
    case "float":
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "number",
        precision: 32
      });
    case "decimal":
      reportDiagnostic(dpgContext.program, {
        code: "decimal-to-number",
        format: {
          propertyName: relevantProperty?.name ?? ""
        },
        target: relevantProperty ?? type
      });
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "number",
        format: "decimal",
        description: "decimal"
      });
    case "decimal128":
      reportDiagnostic(dpgContext.program, {
        code: "decimal-to-number",
        format: {
          propertyName: relevantProperty?.name ?? ""
        },
        target: relevantProperty ?? type
      });
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "number",
        format: "decimal128",
        description: "decimal128"
      });
    case "string":
      if (format === "binary") {
        return {
          type: "string",
          format: "binary",
          description,
          typeName: BINARY_TYPE_UNION,
          outputTypeName: "Uint8Array"
        };
      }
      return applyIntrinsicDecorators(dpgContext, type, {
        type: "string",
        format
      });
    case "boolean":
      return { type: "boolean", description };
    case "plainDate":
      return {
        type: "string",
        format: "date-time",
        description,
        typeName: "Date | string",
        outputTypeName: "string"
      };
    case "utcDateTime":
      return {
        type: "string",
        format: "date-time",
        description,
        typeName: "Date | string",
        outputTypeName: "string"
      };
    case "offsetDateTime":
      return {
        type: "string",
        format: "date-time",
        description,
        typeName: "string",
        outputTypeName: "string"
      };
    case "plainTime":
      return {
        type: "string",
        format: "time",
        description,
        typeName: "Date | string",
        outputTypeName: "string"
      };
    case "duration":
      return { type: "string", format, description };
    case "url":
      return { type: "string", format: "uri" };
  }
}

function isEncodeTypeEffective(
  type: Scalar,
  encodeData: EncodeData | undefined
) {
  if (!encodeData) {
    return false;
  }
  const datetimeTypes = [
    "plaindate",
    "utcdatetime",
    "offsetdatetime",
    "plaintime"
  ];
  if (
    datetimeTypes.includes(type.name.toLowerCase()) &&
    encodeData.type.name === "string"
  ) {
    return false;
  }
  return true;
}

export function getTypeName(schema: Schema, usage?: string[]): string {
  // TODO: Handle more cases
  return getPriorityName(schema, usage) ?? schema.type ?? "any";
}

export function getSerializeTypeName(
  program: Program,
  schema: Schema,
  usage?: string[]
): string {
  const typeName = getTypeName(schema, usage);
  const formattedName = (typeName).replace(
    "Date | string",
    "string"
  );
  const canSerialize = schema.type === SchemaType.SealedChoice
    ? isSerializable((<SealedChoiceSchema>schema).choiceType)
    : isSerializable(schema);
  if (canSerialize) {
    return formattedName;
  }
  reportDiagnostic(program, {
    code: "unable-serialized-type",
    format: { type: typeName },
    target: NoTarget
  });
  return "string";
  function isSerializable(type: any) {
    return (
      ["string", "number", "boolean", "constant"].includes(type.type)
    );
  }
}

export function getImportedModelName(
  schema: Schema,
  usage?: string[]
): string[] {
  switch (schema.type) {
    case "array": {
      const ret = new Set<string>();
      [(schema as ArraySchema).elementType]
        .filter((i?: Schema) => !!i && i.type === "object")
        .forEach((i?: Schema) =>
          getImportedModelName(i!, usage).forEach((it) => ret.add(it))
        );
      return [...ret];
    }
    case "object": {
      if (isAnonymousObjectSchema(schema)) {
        const ret = new Set<string>();
        const properties = (schema as ObjectSchema).properties ?? [];
        for (const property of properties) {
          // ToDo: need to check the if clause by xiaogang
          // if (!properties[name]) {
          //   continue;
          // }
          getImportedModelName(property.schema, usage).forEach((it) =>
            ret.add(it)
          );
        }
        return [...ret];
      }
      return getPriorityName(schema, usage)
        ? [getPriorityName(schema, usage)]
        : [];
    }
    case "dictionary": {
      const ret = new Set<string>();
      [(schema as DictionarySchema).elementType]
        .filter((i?: Schema) => !!i && i.type === "object")
        .forEach((i?: Schema) =>
          getImportedModelName(i!, usage).forEach((it) => ret.add(it))
        );

      return [...ret];
    }
    // ToDo: skip union for the time being by xiaogang
    // case "union": {
    //   const ret = new Set<string>();
    //   ((schema as Schema).enum ?? [])
    //     .filter((i?: Schema) => !!i && i.type === "object")
    //     .forEach((i?: Schema) =>
    //       getImportedModelName(i!, usage).forEach((it) => ret.add(it))
    //     );

    //   return [...ret];
    // }
    default:
      return [];
  }
}

function getPriorityName(schema: Schema, usage?: string[]): string {
  // ToDO need to figure out comment out code by xiaogang
  // return usage &&
  //   usage.includes(SchemaContext.Input) &&
  //   !usage.includes(SchemaContext.Output)
  //   ? schema.typeName ?? schema.name
  //   : schema.outputTypeName ?? schema.typeName ?? schema.name;
  return schema.language?.default.name ?? "need-to-be-implemented";
}

function getEnumStringDescription(type: any) {
  if (type.name === "string" && type.enum && type.enum.length > 0) {
    return `Possible values: ${type.enum
      .map((e: Schema) => {
        return e.type;
      })
      .join(", ")}`;
  }
  return undefined;
}

function getBinaryDescripton(type: any) {
  if (type?.typeName?.includes(BINARY_TYPE_UNION)) {
    if (type?.typeName?.includes(BINARY_AND_FILE_TYPE_UNION)) {
      return `NOTE: The following type 'File' is part of WebAPI and available since Node 20. If your Node version is lower than Node 20.
You could leverage our helpers 'createFile' or 'createFileFromStream' to create a File object. They could help you specify filename, type, and others.`;
    }
    return `Value may contain any sequence of octets`;
  }
  return undefined;
}

function getDecimalDescription(type: any) {
  if (
    (type.format === "decimal" || type.format === "decimal128") &&
    type.type === "number"
  ) {
    return `NOTE: This property is represented as a 'number' in JavaScript, but it corresponds to a 'decimal' type in other languages.
Due to the inherent limitations of floating-point arithmetic in JavaScript, precision issues may arise when performing arithmetic operations.
If your application requires high precision for arithmetic operations or when round-tripping data back to other languages, consider using a library like decimal.js, which provides an arbitrary-precision Decimal type.
For simpler cases, where you need to control the number of decimal places for display purposes, you can use the 'toFixed()' method. However, be aware that 'toFixed()' returns a string and may not be suitable for all arithmetic precision requirements.
Always be cautious with direct arithmetic operations and consider implementing appropriate rounding strategies to maintain accuracy.
   `;
  }
  return undefined;
}

export function getFormattedPropertyDoc(
  program: Program,
  type: ModelProperty | Type,
  schemaType: any,
  sperator: string = "\n\n"
) {
  const propertyDoc = getDoc(program, type);
  const enhancedDocFromType =
    getEnumStringDescription(schemaType) ??
    getDecimalDescription(schemaType) ??
    getBinaryDescripton(schemaType);
  if (propertyDoc && enhancedDocFromType) {
    return `${propertyDoc}${sperator}${enhancedDocFromType}`;
  }
  return propertyDoc ?? enhancedDocFromType;
}

export function getBodyType(
  program: Program,
  route: HttpOperation
): Type | undefined {
  const bodyModel = route.parameters.body?.type;
  if (bodyModel) {
    const metadataInfo = createMetadataInfo(program);
    const payloadType = metadataInfo.getEffectivePayloadType(
      bodyModel,
      Visibility.All
    );
    return payloadType;
  }
  return bodyModel;
}

export function getDefaultService(program: Program): Service | undefined {
  const services = listServices(program);
  if (!services || services.length === 0) {
    reportDiagnostic(program, {
      code: "no-service-defined",
      target: NoTarget
    });
  }
  if (services.length > 1) {
    reportDiagnostic(program, {
      code: "more-than-one-service",
      target: NoTarget
    });
  }
  return services[services.length - 1];
}

/**
 * Get the default api-version both from versioned and service decorator
 * TODO: remember to switch to TCGC once the fix is done
 * @param program
 * @param dpgContext
 * @returns default api-version value
 */
export function getEnrichedDefaultApiVersion(
  program: Program,
  dpgContext: SdkContext
): string | undefined {
  const serviceNamespace = getDefaultService(program);
  if (!serviceNamespace) {
    return;
  }

  const defaultVersion = getDefaultApiVersion(
    dpgContext,
    serviceNamespace!.type
  );
  if (defaultVersion) {
    return defaultVersion.value;
  }
}

export function trimUsage(model: any) {
  if (typeof model !== "object") {
    return model;
  }
  const tmpModel = Object.assign({}, model);
  const tmpModelKeys = Object.keys(tmpModel).filter((item) => {
    return item !== "usage";
  });
  const ordered = tmpModelKeys.sort().reduce((obj, key) => {
    (obj as any)[key] = trimUsage(tmpModel[key]);
    return obj;
  }, {});
  return ordered;
}

export function isAzureCoreErrorType(t?: Type): boolean {
  if (
    t?.kind !== "Model" ||
    !["error", "errorresponse", "innererror"].includes(t.name.toLowerCase())
  )
    return false;
  const namespaces = ".Azure.Core.Foundations".split(".");
  while (
    namespaces.length > 0 &&
    (t?.kind === "Model" || t?.kind === "Namespace") &&
    t.namespace?.name === namespaces.pop()
  ) {
    t = t.namespace;
  }
  return namespaces.length == 0;
}

// Check if the schema is an anonymous object
export function isAnonymousObjectSchema(schema: Schema) {
  return ((schema.language?.default.name || "") === "") && schema.type === "object";
}

// Check if the type is an anonymous model
export function isAnonymousModelType(type: Type) {
  if (type.kind === "Model") {
    return type.name === "";
  }
  return false;
}

/**
 * Get the inline signiture of the model
 * @param schema object schema detail
 * @param options other optional parameters
 * @returns
 */
export function getModelInlineSigniture(
  schema: ObjectSchema,
  options: { importedModels?: Set<string>; usage?: string[] } = {}
) {
  let schemaSignature = `{`;
  for (const propType of schema.properties || []) {
    //const propType = schema.properties[propName]!;
    const propTypeName = getTypeName(propType.schema, options.usage);
    if (!propType.schema || !propTypeName) {
      continue;
    }
    if (options.importedModels) {
      const importNames = getImportedModelName(propType.schema);
      if (importNames) {
        importNames!.forEach(
          options.importedModels.add,
          options.importedModels
        );
      }
    }
    const isOptional = propType.required ? "" : "?";
    schemaSignature += `${propType.language.default.name}${isOptional}: ${propTypeName};`;
  }

  schemaSignature += `}`;
  return schemaSignature;
}


