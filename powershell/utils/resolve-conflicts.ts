import { VirtualProperties } from './schema';
import { VirtualParameters, VirtualParameter } from './command-operation';
import { selectName } from '@azure-tools/codegen';
import { values } from '@azure-tools/linq';

export function resolvePropertyNames(reservedNames: Iterable<string>, virtualProperties: VirtualProperties) {
  const usedNames = new Set(reservedNames);

  const allProps = values(virtualProperties.owned, virtualProperties.inherited, virtualProperties.inlined).toArray();

  for (const prop of allProps) {
    if (usedNames.has(prop.name)) {
      prop.name = selectName(prop.nameOptions, usedNames);
    } else {
      usedNames.add(prop.name);
    }
  }

}

export function resolveParameterNames(reservedNames: Iterable<string>, virtualParameters: VirtualParameters) {
  const usedNames = new Set(reservedNames);
  const collisions = new Set<VirtualParameter>();

  // we need to make sure we avoid name collisions. operation parameters get first crack.
  for (const each of values(virtualParameters.operation)) {
    if (usedNames.has(each.name)) {
      collisions.add(each);
    } else {
      usedNames.add(each.name);
    }
  }

  // handle operation parameters
  for (const each of collisions) {
    each.name = selectName(each.nameOptions, usedNames);
  }
  collisions.clear();

  // now do body parameters.
  for (const each of values(virtualParameters.body)) {
    if (usedNames.has(each.name)) {
      collisions.add(each);
    } else {
      usedNames.add(each.name);
    }
  }

  for (const each of collisions) {
    each.name = selectName(each.nameOptions, usedNames);
  }
}

export function allVirtualProperties(virtualProperties?: VirtualProperties) {
  return virtualProperties ? values(virtualProperties.owned, virtualProperties.inherited, virtualProperties.inlined).toArray() : [];
}

export function allVirtualParameters(virtualParameters?: VirtualParameters) {
  return virtualParameters ? values(virtualParameters.operation, virtualParameters.body).toArray() : [];
}