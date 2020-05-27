
![logo](src/.editoricon.png)

# Crystal Reports NuGets Packages for .NET Framework

[![Build status](https://ci.appveyor.com/api/projects/status/h2ydmki2dm7hs6wd?svg=true)](https://ci.appveyor.com/project/ennerperez/CrystalDecisions)
[![NuGet](http://img.shields.io/nuget/v/CrystalReports.Shared.svg)](https://www.nuget.org/packages/CrystalReports.Shared/)

---------------------------------------

See the [changelog](CHANGELOG.md) for changes.

## Information

These packages are not officially supported by SAP, nor are they final distributable, their purpose is to provide the developer with references to the Crystal Reports Runtime DLLs, for automated compilation environments where the installation of this component cannot be performed.

## Installers

- [CRforVS13SP27](https://akall.softwaredownloads.sap.com/?file=0020000000543482020&downloadId=972f4661-396c-48bd-87fa-bd73c706f351&v=001&u=D18155884555&path=002/2020/0000000006/000000054348/001/CRforVS13SP27_0-10010309.EXE)
- [CR13SP27MSI64](https://akall.softwaredownloads.sap.com/?file=0020000000543422020&downloadId=b694b602-eee8-4fc8-8a3e-9ac1240c8f0d&v=001&u=D79007728963&path=002/2020/0000000006/000000054342/001/CR13SP27MSI64_0-10010309.MSI)
- [CR13SP27MSI32](https://akall.softwaredownloads.sap.com/?file=0020000000543412020&downloadId=7d4cceca-6514-4cf8-94ec-c2069e3358c2&v=001&u=D14803498946&path=002/2020/0000000006/000000054341/001/CR13SP27MSI32_0-10010309.MSI)


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
  - CliendDoc
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

- [Implementing](#implementing)
- [Bugs and feature requests](#bugs-and-feature-requests)
- [Documentation](#documentation)
- [License](#license)

### Implementing

** Add the library to your project **

Add the [NuGet Package](https://www.nuget.org/packages/CrystalReports.Shared/). Right click on your project and click 'Manage NuGet Packages...'. Search for 'CrystalReports' and click on install. Once installed the library will be included in your project references. (Or install it through the package manager console: PM> Install-Package CrystalReports.Shared)

### Bugs and feature requests

Have a bug or a feature request? Please first search for existing and closed issues. If your problem or idea is not addressed yet, [please open a new issue](https://github.com/ennerperez/CrystalDecisions/issues/new).

### Documentation

No more documentation required for now.

### License

Code released under [The MIT License](LICENSE)