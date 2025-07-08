# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY *.sln .
COPY PokemonCardsAPI/*.csproj ./POKEMONCARDSAPI/
RUN dotnet restore

COPY . .
WORKDIR /app/POKEMONCARDSAPI
RUN dotnet publish -c Release -o /out

# Etapa de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /out .

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "PokemonCardsAPI.dll"]
