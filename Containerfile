# .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Sets the working directory
WORKDIR /app

# Copy Projects
#COPY *.sln .
COPY src/CleanArchitecture.Web/CleanArchitecture.Web.csproj ./src/CleanArchitecture.Web/

# .NET Restore
RUN dotnet restore ./src/CleanArchitecture.Web/CleanArchitecture.Web.csproj

# Copy All Files
COPY src ./src

# .NET Build and Publish
RUN dotnet publish ./src/CleanArchitecture.Web/CleanArchitecture.Web.csproj -c Release -o /publish

# ASP.NET Core Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /publish ./

# Expose ports
EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "CleanArchitecture.Web.dll"]