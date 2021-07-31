
![logo](src/.editoricon.png)

# Crystal Reports NuGets Packages for .NET Framework

[![Build status](https://ci.appveyor.com/api/projects/status/h2ydmki2dm7hs6wd?svg=true)](https://ci.appveyor.com/project/ennerperez/CrystalDecisions)
[![NuGet](http://img.shields.io/nuget/v/CrystalReports.Shared.svg)](https://www.nuget.org/packages/CrystalReports.Shared/)

---------------------------------------

See the [changelog](CHANGELOG.md) for changes.

## Information

These packages are not officially supported by SAP, nor are they final distributable, their purpose is to provide the developer with references to the Crystal Reports Runtime DLLs, for automated compilation environments where the installation of this component cannot be performed.

## Installers

[How to download and Install Crystal Report Runtime](https://www.tektutorialshub.com/crystal-reports/how-to-download-and-install-crystal-report-runtime/)

- [CRforVS13SP30](https://akall.softwaredownloads.sap.com/?file=0020000000195612021&downloadId=bc0a55ce-e36b-4e7b-8992-ec1a65b116e8&v=1&u=D10632577458&path=002/2021/0000000002/000000019561/001/CRforVS13SP30_0-10010309.EXE)
- [CR13SP30MSI64](https://akall.softwaredownloads.sap.com/?file=0020000000195602021&downloadId=46f60844-0ae6-47a2-912b-f547efef34eb&v=1&u=D58379955487&path=002/2021/0000000002/000000019560/001/CR13SP30MSI64_0-10010309.MSI)
- [CR13SP30MSI32](https://akall.softwaredownloads.sap.com/?file=0020000000195592021&downloadId=015059b0-4c87-4eff-a721-bd5c9c7aee29&v=1&u=D67824045738&path=002/2021/0000000002/000000019559/001/CR13SP30MSI32_0-10010309.MSI)

## Versions

- [13.0.4000.0](VERSION)

## Featuring

- CrystalReports
  - Engine
  - TemplateEngine
  - ReportSource
  - Shared
  - Web
  - Windows.Forms
  - WPF.ViewerShared
  - WPF.Viewer
- ReportAppServer
  - Enterprise Viewing ReportSource
  - ClientDoc
  - CommLayer
  - CommonControls
  - CommonObjectModel
  - Controllers
  - CubeDefModel
  - DataDefModel
  - DataSetConversion
  - ObjectFactory
  - Prompting
  - ReportDefModel
  - XmlSerialize

## Table of contents

- [Crystal Reports NuGets Packages for .NET Framework](#crystal-reports-nugets-packages-for-net-framework)
  - [Information](#information)
  - [Installers](#installers)
  - [Versions](#versions)
  - [Featuring](#featuring)
  - [Table of contents](#table-of-contents)
    - [Implementing](#implementing)
    - [Bugs and feature requests](#bugs-and-feature-requests)
    - [Documentation](#documentation)
    - [License](#license)

### Implementing

**Add the library to your project**

Add the [NuGet Package](https://www.nuget.org/packages/CrystalReports.Shared/). Right click on your project and click 'Manage NuGet Packages...'. Search for 'CrystalReports' and click on install. Once installed the library will be included in your project references. (Or install it through the package manager console: PM> Install-Package CrystalReports.Shared)

### Bugs and feature requests

Have a bug or a feature request? Please first search for existing and closed issues. If your problem or idea is not addressed yet, [please open a new issue](https://github.com/ennerperez/CrystalDecisions/issues/new).

### Documentation

No more documentation required for now.

### License

Code released under [The MIT License](LICENSE)
