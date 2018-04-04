FROM microsoft/dotnet:1.0.3-sdk-projectjson

ENV DOTNET_CLI_TELEMETRY_OPTOUT 1

WORKDIR /app/Allwissend.AllPlan.Practitioner
COPY . /app/Allwissend.AllPlan.Practitioner

EXPOSE 5002/tcp

RUN ["dotnet", "restore"]
ENTRYPOINT ["dotnet", "run", "-p", "project.json", "web"]

################################################################################
# https://github.com/dotnet/dotnet-docker/blob/master/samples/dotnetapp/Dockerfile
# https://github.com/dotnet/dotnet-docker/blob/master/samples/aspnetapp/Dockerfile

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
