export enum AccessModifier {
  Public = "public",
  Internal = "internal",
  Protected = "protected",
  ProtectedInternal = "protected internal",
  PrivateProtected = "private protected",
  Private = "private",
}

const order = [AccessModifier.Public, AccessModifier.Internal, AccessModifier.Protected, AccessModifier.ProtectedInternal, AccessModifier.PrivateProtected, AccessModifier.Private];

export function highestAccess(first: AccessModifier, second: AccessModifier): AccessModifier {
  const f = order.indexOf(first);
  const s = order.indexOf(second);
  return f < s ? order[f] : order[s];
}
export function lowestAccess(first: AccessModifier, second: AccessModifier): AccessModifier {
  const f = order.indexOf(first);
  const s = order.indexOf(second);
  return f > s ? order[f] : order[s];
}