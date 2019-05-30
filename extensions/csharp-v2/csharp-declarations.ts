/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/


import { ClassType, Namespace, TypeDeclaration } from '@microsoft.azure/codegen-csharp';

const rest = new Namespace(`Microsoft.Rest`);

export const PropertyOriginAttribute: TypeDeclaration = new ClassType(rest, `Origin`);