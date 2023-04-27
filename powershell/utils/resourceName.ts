import { EnglishPluralizationService } from '@azure-tools/codegen';

const pluralizationService = new EnglishPluralizationService();
pluralizationService.addWord('Database', 'Databases');
pluralizationService.addWord('database', 'databases');
pluralizationService.addWord('Premise', 'Premises');
pluralizationService.addWord('premise', 'premises');

//for sliced path: "/parentName/{name}/chileName", the second splited element is the parent name, and the fourth element is the child name 
function slicePath(path: string, name: string, index: number) {
  return path.slice(path.search(new RegExp(`/[^/]*/{${name}}`))).split('/')[index];
}

function get(path: string | undefined, name: string, singularize = false, index: number) {
  const resourceName = path ? slicePath(path, name, index) : undefined;
  return resourceName && !isResourceNameVariable(resourceName) ? (singularize ? pluralizationService.singularize(resourceName) : resourceName) : undefined;
}

export function getResourceNameFromPath(path: string | undefined, name: string, singularize = false) {
  return get(path, name, singularize, 1);
}

export function getChildResourceNameFromPath(path: string, parent: string, singularize = false) {
  return get(path, parent, singularize, 3);
}

function isResourceNameVariable(name: string) {
  return /^{.*}$/g.test(name);
}