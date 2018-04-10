FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln /app
COPY NuGet.Config /app
COPY ./src/IO.Swagger/ /app/src/IO.Swagger/
# COPY utils/*.csproj ./utils/
# COPY tests/*.csproj ./tests/
RUN dotnet restore

WORKDIR /app/src/IO.Swagger/
RUN dotnet build


# FROM build AS testrunner
# WORKDIR /app/tests
# ENTRYPOINT ["dotnet", "test", "--logger:trx"]

# FROM build AS test
# WORKDIR /app/tests
# RUN dotnet test



FROM build AS publish
WORKDIR /app/src/IO.Swagger/
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:2.1-runtime AS runtime
WORKDIR /app
COPY --from=publish /app/src/IO.Swagger/out ./
ENTRYPOINT ["dotnet", "IO.Swagger.dll"]
