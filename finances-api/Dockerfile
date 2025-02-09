FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["finances-api/finances-api.csproj", "finances-api/"]
RUN dotnet restore "finances-api/finances-api.csproj"
COPY . .
WORKDIR "/src/finances-api"
RUN dotnet build "finances-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "finances-api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "finances-api.dll"]
