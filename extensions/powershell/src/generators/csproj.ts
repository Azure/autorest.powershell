import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from '../project';

export async function generateCsproj(service: Host, project: Project) {
  // write out the csproj file if it's not there.
  if (!await service.ReadFile(project.csproj)) {
    service.WriteFile(project.csproj, `<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <LangVersion>7.1</LangVersion>
    <TargetFramework>netstandard2.0</TargetFramework>
    <OutputType>Library</OutputType>
    <AssemblyName>${project.dllName}</AssemblyName>
    <RootNamespace>${project.projectNamespace}</RootNamespace>
    <CopyLocalLockFileAssemblies>true</CopyLocalLockFileAssemblies>
    <AppendTargetFrameworkToOutputPath>false</AppendTargetFrameworkToOutputPath>
    <OutputPath>${project.binFolder}</OutputPath>
    <PublishDir>$(OutputPath)</PublishDir>
    <!-- Some methods are marked async and don't have an await in them -->
    <NoWarn>1998</NoWarn>
    <GenerateAssemblyInfo>false</GenerateAssemblyInfo>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
    <WarningsAsErrors />
  </PropertyGroup>

  <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Debug|AnyCPU'">
    <DelaySign>false</DelaySign>
    <DefineConstants>TRACE;DEBUG;NETSTANDARD</DefineConstants>
  </PropertyGroup>

  <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Release|AnyCPU'">
    <SignAssembly>true</SignAssembly>
    <DelaySign>true</DelaySign>
    <AssemblyOriginatorKeyFile>MSSharedLibKey.snk</AssemblyOriginatorKeyFile>
    <DefineConstants>TRACE;RELEASE;NETSTANDARD;SIGN</DefineConstants>
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