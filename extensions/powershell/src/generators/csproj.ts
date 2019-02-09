import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from '../project';

export async function generateCsproj(service: Host, project: Project) {
  // write out the csproj file if it's not there.
  if (!await service.ReadFile(project.csproj)) {
    service.WriteFile(project.csproj, `<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <LangVersion>7.1</LangVersion>
    <OutputType>Library</OutputType>
     <TargetFramework>netstandard2.0</TargetFramework>
    <nowarn>1998</nowarn> <!-- some methods are marked async that don't have an await in them.-->
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="PowerShellStandard.Library" Version="5.1.0" />
    <PackageReference Include="Microsoft.CSharp" Version="4.4.1" />
    <PackageReference Include="System.Text.Encodings.Web" Version="4.3.0" />
  </ItemGroup>
</Project>
`, undefined, 'source-file-csharp');
  }
}