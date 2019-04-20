FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
COPY ./app
EXPOSE 80
ENTRYPOINT ["dotnet", "AspNetCore.dll"]
