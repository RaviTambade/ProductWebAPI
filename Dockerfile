# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./

RUN dotnet restore

# copy everything else and build app

COPY . ./

RUN dotnet publish -c release -o out

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
EXPOSE 5002
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "ProductWebAPI.dll"]