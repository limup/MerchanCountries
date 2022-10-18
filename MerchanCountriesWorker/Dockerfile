# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY .. ./
RUN cd MerchanCountries/MerchanCountriesWorker \
    && dotnet restore \
    && dotnet build -c release MerchanCountriesWorker.Console/MerchanCountriesWorker.Console.csproj --no-restore \
    && dotnet publish -c release MerchanCountriesWorker.Console/MerchanCountriesWorker.Console.csproj --no-build -o /app


# final stage/image
FROM mcr.microsoft.com/dotnet/runtime:7.0

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "MerchanCountriesWorker.Console.dll"]