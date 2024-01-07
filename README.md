# ASP.NET Core Clean Architecture

Prefer Microsoft's native support over third-party packages.

# Packages

- [x] [Native DI](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-8.0) instead of [Autofac](https://github.com/autofac/Autofac)
- [x] [Minimal APIs](https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-8.0) instead of [FastEndpoints](https://github.com/FastEndpoints/FastEndpoints)
- [x] [System.Text.Json](https://www.nuget.org/packages/System.Text.Json) instead of [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)
- [x] [Microsoft.AspNetCore.OpenApi](https://www.nuget.org/packages/Microsoft.AspNetCore.OpenApi)
- [x] [Swashbuckle.AspNetCore](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
- [x] [MediatR](https://github.com/jbogard/MediatR)
- [x] [FluentValidator](https://github.com/FluentValidation/FluentValidation)
- [x] [StyleCopAnalyzers](https://github.com/DotNetAnalyzers/StyleCopAnalyzers)
- [x] [SQLite](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite)
- [PostgreSQL](https://github.com/npgsql/efcore.pg)
- [AutoMapper](https://github.com/AutoMapper/AutoMapper)

# Packages for testing

- [xunit](https://github.com/xunit/xunit)
- [Moq](https://github.com/devlooped/moq) or [NSubstitute](https://github.com/nsubstitute/NSubstitute)
- [FluentAssertions](https://github.com/fluentassertions/fluentassertions)

# TODO Features

- [ ] [ASP.NET Core Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-8.0)
- [ ] [OpenIddict](https://github.com/openiddict/openiddict-core)
- [x] [Rate limiting](https://learn.microsoft.com/en-us/aspnet/core/performance/rate-limit?view=aspnetcore-8.0)

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
- [x] `License`

# Migration

```bash
cd src/CleanArchitecture.Web

dotnet ef migrations add InitialCreate -c AppDbContext -p ../CleanArchitecture.Infrastructure/CleanArchitecture.Infrastructure.csproj -s CleanArchitecture.Web.csproj -o Data/Migrations

dotnet ef database update InitialCreate

# Clean up
dotnet ef database drop --force
```

# References

- https://github.com/ardalis/CleanArchitecture