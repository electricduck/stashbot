FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine3.11 AS build-env
WORKDIR /app
COPY ./src/GearstashBot/*.csproj ./
RUN dotnet restore
COPY ./src/GearstashBot ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-alpine3.11
RUN apk add --no-cache python3 py3-pip
WORKDIR /app
COPY --from=build-env /app/out .
VOLUME /app/config

ENTRYPOINT ["dotnet", "GearstashBot.dll"]
