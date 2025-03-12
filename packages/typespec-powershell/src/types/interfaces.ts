export interface PSOptions extends Record<string, any> {
  packageDetails?: PackageDetails;
  title?: string;
}

export interface PackageDetails {
  name: string;
  scopeName?: string;
  nameWithoutScope?: string;
  description?: string;
  version?: string;
}