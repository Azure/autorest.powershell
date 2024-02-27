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
  getVisibility,
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
  getProjectedName,
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
  isArrayModelType
} from "@typespec/compiler";
import { reportDiagnostic } from "../lib.js";
import {
  getHeaderFieldName,
  getPathParamName,
  getQueryParamName,
  isStatusCode,
  HttpOperation,
  createMetadataInfo,
  Visibility
} from "@typespec/http";
import { getPagedResult, isFixed } from "@azure-tools/typespec-azure-core";
import {
  getDefaultApiVersion,
  isApiVersion
} from "@azure-tools/typespec-client-generator-core";

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
  return services[0];
}
