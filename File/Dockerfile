#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
COPY publish .
ENTRYPOINT ["dotnet", "File.dll"]

#dotnet publish File.csproj -c Release -o ./publish/
#docker build -t file-service .
#docker run -p 9000:8080 --name file-service file-service