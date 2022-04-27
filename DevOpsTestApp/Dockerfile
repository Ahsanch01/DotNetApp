 FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
 WORKDIR /app
 EXPOSE 80
 FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
 WORKDIR /src
 COPY ["DevOpsTestApp.csproj", ""]
 RUN dotnet restore "./DevOpsTestApp.csproj"
 COPY . .
 WORKDIR "/src/."
 RUN dotnet build "DevOpsTestApp.csproj" -c Release -o /app/build
 FROM build AS publish
 RUN dotnet publish "DevOpsTestApp.csproj" -c Release -o /app/publish
 FROM base AS final
 WORKDIR /app
 COPY --from=publish /app/publish .
 ENTRYPOINT ["dotnet", "DevOpsTestApp.dll"]
