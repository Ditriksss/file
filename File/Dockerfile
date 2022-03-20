FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet nuget add source http://host.docker.internal:8111/httpAuth/app/nuget/feed/_Root/LocalNugetServer/v3/index.json --name TeamCity --username admin --password eyJ0eXAiOiAiVENWMiJ9.RjJKX2diYi1aV3FZVXdLZW15WXlNeTY4TFFz.ZWI2MzFhYTktN2UwMy00ZWYyLWE1MjUtODNlYTYwMzk0Mzlk --store-password-in-clear-text
RUN dotnet restore
# Build and publish a release

RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "File.dll"]