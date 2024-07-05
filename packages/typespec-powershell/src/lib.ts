import { createTypeSpecLibrary } from "@typespec/compiler";

export const $lib = createTypeSpecLibrary({
  name: "powershell-ts",
  diagnostics: {},
});

export const { reportDiagnostic, createDiagnostic } = $lib;
