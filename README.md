# ASP.NET Core Clean Architecture

Prefer Microsoft's native support over third-party packages.

# Packages

- [Native DI](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-8.0) instead of [Autofac](https://github.com/autofac/Autofac)
- [Minimal APIs](https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-8.0) instead of [FastEndpoints](https://github.com/FastEndpoints/FastEndpoints)
- [System.Text.Json](https://www.nuget.org/packages/System.Text.Json) instead of [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)
- [PostgreSQL](https://github.com/npgsql/efcore.pg)
- [AutoMapper](https://github.com/AutoMapper/AutoMapper)
- [Microsoft.AspNetCore.OpenApi](https://www.nuget.org/packages/Microsoft.AspNetCore.OpenApi)
- [Swashbuckle.AspNetCore](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
- [MediatR](https://github.com/jbogard/MediatR)
- [FluentValidator](https://github.com/FluentValidation/FluentValidation)
- [StyleCopAnalyzers](https://github.com/DotNetAnalyzers/StyleCopAnalyzers)

# Packages for testing

- [xunit](https://github.com/xunit/xunit)
- [Moq](https://github.com/devlooped/moq) or [NSubstitute](https://github.com/nsubstitute/NSubstitute)
- [FluentAssertions](https://github.com/fluentassertions/fluentassertions)

# TODO Features

- [ ] [ASP.NET Core Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-8.0)
- [ ] [OpenIddict](https://github.com/openiddict/openiddict-core)
- [ ] [Rate limiting](https://learn.microsoft.com/en-us/aspnet/core/performance/rate-limit?view=aspnetcore-8.0)

# TODO DevOps

- [x] Github Actions
- [x] Podman `Containerfile`

# TODO Preparing

- [x] `global.json`: `dotnet new globaljson --sdk-version <version>`
- [x] `sln`: `dotnet new sln`
- [x] `.editorconfig`: `dotnet new editorconfig`
- [x] `.gitignore`: `dotnet new gitignore`
- [x] StyleCop: `stylecop.json`, `StyleCop.ruleset`
- [x] `.gitattributes`
- [x] `.vscode`
- [x] `.http`
- [x] `Directory.Build.props`
- [x] `Directory.Packages.props`