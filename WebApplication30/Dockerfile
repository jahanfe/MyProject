FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["WebApplication30/WebApplication30.csproj", "WebApplication30/"]
RUN dotnet restore "WebApplication30/WebApplication30.csproj"
COPY . .
WORKDIR "/src/WebApplication30"
RUN dotnet build "WebApplication30.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApplication30.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication30.dll"]
