# 概述

## ⚠️ 注意事项

本项目为原始项目的**分支版本（Fork）**，仅用于特定用途，**不会发布到 nuget.org**，**仅发布到 MyGet 私有源**。

因此，在安装和使用前，**必须配置 NuGet 源以包含对应的 MyGet 地址**。

项目可能包含功能增强、Bug 修复或其他适配性调整，建议通过 Git 提交记录或 CHANGELOG 查看具体变更内容。

## Nuget Packages

| 名称 | 描述 | 链接 |
| --- | --- | --- |
| [IdentityServer4](https://www.myget.org/feed/archertrister/package/nuget/IdentityServer4) | OpenID Connect and OAuth 2.0 Framework for ASP.NET Core | [访问](https://www.myget.org/feed/archertrister/package/nuget/IdentityServer4) |
| [IdentityServer4.AspNetIdentity](https://www.myget.org/feed/archertrister/package/nuget/IdentityServer4.AspNetIdentity) | ASP.NET Core Identity Integration for IdentityServer4 | [访问](https://www.myget.org/feed/archertrister/package/nuget/IdentityServer4.AspNetIdentity) |
| [IdentityServer4.EntityFramework](https://www.myget.org/feed/archertrister/package/nuget/IdentityServer4.EntityFramework) | EntityFramework persistence layer for IdentityServer4 | [访问](https://www.myget.org/feed/archertrister/package/nuget/IdentityServer4.EntityFramework) |
| [IdentityServer4.Storage](https://www.myget.org/feed/archertrister/package/nuget/IdentityServer4.Storage) | Storage interfaces and models for IdentityServer4 | [访问](https://www.myget.org/feed/archertrister/package/nuget/IdentityServer4.Storage) |
| [IdentityServer4.EntityFramework.Storage](https://www.myget.org/feed/archertrister/package/nuget/IdentityServer4.EntityFramework.Storage) | EntityFramework storage implementations for IdentityServer4 | [访问](https://www.myget.org/feed/archertrister/package/nuget/IdentityServer4.EntityFramework.Storage) |


---

## ✅ 使用方式

您可以通过以下任意一种方式使用本包：

---

### 方法一：在 `nuget.config` 中添加 MyGet 源

在项目目录下找到或创建 `nuget.config` 文件，并添加如下内容：

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="MyGet" value="https://www.myget.org/F/archertrister/api/v3/index.json" />
  </packageSources>
</configuration>
```

配置完成后，可直接使用以下命令安装包：

```bash
nuget install PackageName -Version x.x.x
```

或在项目中使用：

```bash
dotnet add package PackageName --version x.x.x
```

或在控制台使用：

```bash
PM> Install-Package PackageName -Version x.x.x
```

---

### 方法二：安装时直接指定源地址

如果不修改 `nuget.config`，也可以在安装包时通过 `-Source` 参数指定 MyGet 源地址：

```bash
nuget install PackageName -Version x.x.x -Source https://www.myget.org/F/archertrister/api/v3/index.json
```

或使用 `dotnet` 命令：

```bash
dotnet add package PackageName --version x.x.x --source https://www.myget.org/F/archertrister/api/v3/index.json
```

或使用 `Install-Package` 命令

```bash
PM> Install-Package PackageName -Version x.x.x -Source https://www.myget.org/F/archertrister/api/v3/index.json
```

---

## 📌 总结

- 本包只能从 MyGet 安装。
- 使用前必须配置 MyGet 源。
- 可选方式：
  - 修改 `nuget.config` 添加源。
  - 安装命令中使用 `-Source` 参数指定源地址。

请根据你的使用场景选择合适的方式。


# Security Vulnerability Found
IdentityServer4 contains a known Open Redirect vulnerability (CVE-2024-39694) that we do not intend to address in IdentityServer4. Please see [the security advisory](https://github.com/IdentityServer/IdentityServer4/security/advisories/GHSA-55p7-v223-x366) for more details and consider upgrading to [Duende.IdentityServer](www.duendesoftware.com) to receive updates.

# Important update
This project is not maintained anymore. This repo will be archived when .NET Core 3.1 end of support is reached (13th Dec 2022). All new development is happening in the new [Duende Software](https://github.com/duendesoftware) organization. 

See [here](https://duendesoftware.com/products/identityserver) for more details.

## About IdentityServer4
[<img align="right" width="100px" src="https://dotnetfoundation.org/img/logo_big.svg" />](https://dotnetfoundation.org/projects?searchquery=IdentityServer&type=project)

IdentityServer is a free, open source [OpenID Connect](http://openid.net/connect/) and [OAuth 2.0](https://tools.ietf.org/html/rfc6749) framework for ASP.NET Core.
Founded and maintained by [Dominick Baier](https://twitter.com/leastprivilege) and [Brock Allen](https://twitter.com/brocklallen), IdentityServer4 incorporates all the protocol implementations and extensibility points needed to integrate token-based authentication, single-sign-on and API access control in your applications.
IdentityServer4 is officially [certified](https://openid.net/certification/) by the [OpenID Foundation](https://openid.net) and thus spec-compliant and interoperable.
It is part of the [.NET Foundation](https://www.dotnetfoundation.org/), and operates under their [code of conduct](https://www.dotnetfoundation.org/code-of-conduct). It is licensed under [Apache 2](https://opensource.org/licenses/Apache-2.0) (an OSI approved license).

For project documentation, please visit [readthedocs](https://identityserver4.readthedocs.io).

## Branch structure
Active development happens on the main branch. This always contains the latest version. Each (pre-) release is tagged with the corresponding version. The [aspnetcore1](https://github.com/IdentityServer/IdentityServer4/tree/aspnetcore1) and [aspnetcore2](https://github.com/IdentityServer/IdentityServer4/tree/aspnetcore2) branches contain the latest versions of the older ASP.NET Core based versions.

## How to build

* [Install](https://www.microsoft.com/net/download/core#/current) the latest .NET Core 3.1 SDK
* Install Git
* Clone this repo
* Run `build.ps1` or `build.sh` in the root of the cloned repo

## Documentation
For project documentation, please visit [readthedocs](https://identityserver4.readthedocs.io).

See [here](http://docs.identityserver.io/en/aspnetcore1/) for the 1.x docs, and [here](http://docs.identityserver.io/en/aspnetcore2/) for the 2.x docs.

## Bug reports and feature requests
Please use the [issue tracker](https://github.com/IdentityServer/IdentityServer4/issues) for that. We only support the latest version for free. For older versions, you can get a commercial support agreement with us.

## Commercial and Community Support
If you need help with implementing IdentityServer4 or your security architecture in general, there are both free and commercial support options.
See [here](https://identityserver4.readthedocs.io/en/latest/intro/support.html) for more details.

## Sponsorship
If you are a fan of the project or a company that relies on IdentityServer, you might want to consider sponsoring.
This will help us devote more time to answering questions and doing feature development. If you are interested please head to our [Patreon](https://www.patreon.com/identityserver) page which has further details.

### Platinum Sponsors
[<img src="https://user-images.githubusercontent.com/1454075/62819413-39550c00-bb55-11e9-8f2f-a268c3552c71.png" width="200">](https://udelt.no)

[<img src="https://user-images.githubusercontent.com/1454075/66454740-fb973580-ea68-11e9-9993-6c1014881528.png" width="200">](https://github.com/dotnet-at-microsoft)

### Corporate Sponsors
[Ritter Insurance Marketing](https://www.ritterim.com)  
[ExtraNetUserManager](https://www.extranetusermanager.com/)  
[Knab](https://www.knab.nl/)

You can see a list of our current sponsors [here](https://github.com/IdentityServer/IdentityServer4/blob/main/SPONSORS.md) - and for companies we have some nice advertisement options as well.

## Acknowledgements
IdentityServer4 is built using the following great open source projects and free services:

* [ASP.NET Core](https://github.com/dotnet/aspnetcore)
* [Bullseye](https://github.com/adamralph/bullseye)
* [SimpleExec](https://github.com/adamralph/simple-exec)
* [MinVer](https://github.com/adamralph/minver)
* [Json.Net](http://www.newtonsoft.com/json)
* [XUnit](https://xunit.github.io/)
* [Fluent Assertions](http://www.fluentassertions.com/)
* [GitReleaseManager](https://github.com/GitTools/GitReleaseManager)

..and last but not least a big thanks to all our [contributors](https://github.com/IdentityServer/IdentityServer4/graphs/contributors)!
