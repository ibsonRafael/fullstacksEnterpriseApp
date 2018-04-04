FROM microsoft/dotnet:1.0.3-sdk-projectjson

ENV DOTNET_CLI_TELEMETRY_OPTOUT 1

WORKDIR /app/IO.Swagger
COPY . /app/IO.Swagger

EXPOSE 5001/tcp

RUN ["dotnet", "restore"]
ENTRYPOINT ["dotnet", "run", "-p", "project.json", "web"]

################################################################################

FROM microsoft/dotnet:2.0-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY aspnetapp/*.csproj ./aspnetapp/
RUN dotnet restore

# copy everything else and build app
COPY aspnetapp/. ./aspnetapp/
WORKDIR /app/aspnetapp
RUN dotnet publish -o out /p:PublishWithAspNetCoreTargetManifest="false"


FROM microsoft/dotnet:2.0-runtime AS runtime
ENV ASPNETCORE_URLS http://+:80
WORKDIR /app
COPY --from=build /app/aspnetapp/out ./
ENTRYPOINT ["dotnet", "aspnetapp.dll"]
