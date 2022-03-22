/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Variable } from '@azure-tools/codegen-csharp';
import { CredentialSchema } from '@autorest/codemodel';
import { String } from './string';
import { KnownMediaType } from '@azure-tools/codemodel-v3';
import { camelCase, deconstruct } from '@azure-tools/codegen';
import { Expression, ExpressionOrLiteral, toExpression, valueOf } from '@azure-tools/codegen-csharp';
import { OneOrMoreStatements } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { popTempVar, pushTempVar } from './primitive';

// Currently we assume password could only appear in the request body in json format
export class Password extends String {
  constructor(schema: CredentialSchema, isRequired: boolean) {
    super(schema, isRequired);
  }

  get convertObjectMethod() {
    return '(object ss) => (System.Security.SecureString)ss';
  }

  get declaration(): string {
    return 'System.Security.SecureString';
  }
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {
    switch (mediaType) {
      case KnownMediaType.Json: {
        // container should be a JsonObject
        const tmpVar = `__${camelCase(['json', ...deconstruct(serializedName)])}`;
        return toExpression(`If( ${valueOf(container)}?.PropertyT<${ClientRuntime.JsonString}>("${serializedName}"), out var ${tmpVar}) ? new System.Net.NetworkCredential("",(string)${tmpVar}).SecurePassword : ${defaultValue}`);
      }
    }
    return toExpression(`${defaultValue} /* deserializeFromContainerMember doesn't support '${mediaType}' ${__filename}*/`);
  }

  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression {
    try {
      const tmp = pushTempVar();
      switch (mediaType) {
        case KnownMediaType.Json:
          // node should be a JsonString
          return toExpression(`${node} is ${ClientRuntime.JsonString} ${tmp} ? (${this.declaration})(${tmp}.ToString()) : ${defaultValue}`);
      }
    } finally {
      popTempVar();
    }
    return toExpression(`null /* deserializeFromContainer doesn't support '${mediaType}' ${__filename}*/`);
  }
  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral, mode: Expression): Expression {
    return toExpression(`null /* serializeToContent doesn't support '${mediaType}' ${__filename}*/`);
  }

  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string, mode: Expression): Expression {
    switch (mediaType) {
      case KnownMediaType.Json:
        return toExpression(`null != (((object)${value})?.ToString()) ? (${ClientRuntime.JsonNode}) new ${ClientRuntime.JsonString}(System.Runtime.InteropServices.Marshal.PtrToStringBSTR(System.Runtime.InteropServices.Marshal.SecureStringToBSTR(${value}))) : null`);
    }
    return toExpression(`null /* serializeToNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {

    switch (mediaType) {
      case KnownMediaType.Json: {
        return this.deserializeFromNode(mediaType, ClientRuntime.JsonNode.Parse(content), defaultValue);
      }
    }
    return toExpression(`null /* deserializeFromString doesn't support '${mediaType}' ${__filename}`);
  }

  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    switch (mediaType) {
      case KnownMediaType.Json:
        return toExpression(`${content}.Content.ReadAsStringAsync().ContinueWith( body => ${this.deserializeFromString(mediaType, 'body.Result', defaultValue)})`);

    }
    return toExpression(`null /* deserializeFromResponse doesn't support '${mediaType}' ${__filename}*/`);
  }

  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {
    switch (mediaType) {
      case KnownMediaType.Json:
        return `AddIf( ${this.serializeToNode(mediaType, value, serializedName, mode)}, "${serializedName}" ,${container}.Add );`;
    }
    return (`/* serializeToContainerMember doesn't support '${mediaType}' ${__filename}*/`);
  }
  // Override the validateValue function for the parent and do not validate password 
  validateValue(eventListener: Variable, property: Variable): string {
    return ``
  }
}