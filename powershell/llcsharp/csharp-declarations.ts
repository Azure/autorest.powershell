/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/


import { ClassType, Namespace, TypeDeclaration } from '@azure-tools/codegen-csharp';

const rest = new Namespace('Microsoft.Rest');

export const PropertyOriginAttribute: TypeDeclaration = new ClassType(rest, 'Origin');
export const ConstantAttribute: TypeDeclaration = new ClassType(rest, 'Constant');
export const DoNotFormatAttribute: TypeDeclaration = new ClassType(rest, 'DoNotFormat');
export const FormatTableAttribute: TypeDeclaration = new ClassType(rest, 'FormatTable');