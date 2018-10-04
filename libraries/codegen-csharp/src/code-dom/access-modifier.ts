/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

export enum Access {
  Public = 'public',
  Internal = 'internal',
  Protected = 'protected',
  ProtectedInternal = 'protected internal',
  PrivateProtected = 'private protected',
  Private = 'private',
  Default = '',
}

export enum Modifier {
  None = '',
  Static = 'static',
  New = 'new ',
  ReadOnly = 'readonly',
  Volitile = 'volitile',
  Sealed = 'sealed',
  Override = 'override',
  Abstract = 'abstract',
  Extern = 'extern',
  Async = 'async',
  Virtual = 'virtual',
}

export type Static = Modifier.None | Modifier.Static;
export type New = Modifier.None | Modifier.New;
export type ReadOnly = Modifier.None | Modifier.ReadOnly;
export type Volitile = Modifier.None | Modifier.Volitile;
export type Async = Modifier.None | Modifier.Async;
export type Abstract = Modifier.None | Modifier.Abstract;
export type Sealed = Modifier.None | Modifier.Sealed;
export type Override = Modifier.None | Modifier.Override;
export type Extern = Modifier.None | Modifier.Extern;
export type Virtual = Modifier.None | Modifier.Virtual;

const order = [Access.Public, Access.Internal, Access.Protected, Access.ProtectedInternal, Access.PrivateProtected, Access.Private, Access.Default];

export function highestAccess(first: Access, second: Access): Access {
  const f = order.indexOf(first);
  const s = order.indexOf(second);
  return f < s ? order[f] : order[s];
}
export function lowestAccess(first: Access, second: Access): Access {
  const f = order.indexOf(first);
  const s = order.indexOf(second);
  return f > s ? order[f] : order[s];
}
