export interface PSOptions {
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