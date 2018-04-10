FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln /app
COPY NuGet.Config /app
COPY ./src/Allwissend.AllPlan.Practitioner/ /app/src/Allwissend.AllPlan.Practitioner/
RUN dotnet restore

WORKDIR /app/src/Allwissend.AllPlan.Practitioner/
RUN dotnet build

FROM build AS publish
WORKDIR /app/src/Allwissend.AllPlan.Practitioner/
RUN dotnet publish -c Release -o out -r linux-x64

FROM microsoft/dotnet:2.1-runtime AS runtime
RUN curl https://dist.asp.net/runtimestore/2.0.0/linux-x64/aspnetcore.runtimestore.tar.gz | tar xz -C /usr/share/dotnet
WORKDIR /app
COPY --from=publish /app/src/Allwissend.AllPlan.Practitioner/out ./
ENTRYPOINT ["dotnet", "Allwissend.AllPlan.Practitioner.dll"]
