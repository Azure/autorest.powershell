import { resolvePath } from "@typespec/compiler";
import { createTestLibrary, TypeSpecTestLibrary } from "@typespec/compiler/testing";
import { fileURLToPath } from "url";

export const PowershellTsTestLibrary: TypeSpecTestLibrary = createTestLibrary({
  name: "powershell-ts",
  packageRoot: resolvePath(fileURLToPath(import.meta.url), "../../../../"),
});
