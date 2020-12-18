
FROM mcr.microsoft.com/dotnet/core/aspnet:2.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build
WORKDIR /TaxaJuros-Softplan
COPY ["TaxaJuros-Softplan/TaxaJuros-Softplan.csproj", "src/api1/"]
RUN dotnet restore "src/api1/TaxaJuros-Softplan.csproj"
COPY . .
WORKDIR "/TaxaJuros-Softplan/src/api1"
RUN dotnet build "TaxaJuros-Softplan.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TaxaJuros-Softplan.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TaxaJuros-Softplan.dll"]