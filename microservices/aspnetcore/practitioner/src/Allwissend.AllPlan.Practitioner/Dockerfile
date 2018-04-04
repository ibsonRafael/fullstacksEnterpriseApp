FROM microsoft/dotnet:1.0.3-sdk-projectjson

ENV DOTNET_CLI_TELEMETRY_OPTOUT 1

WORKDIR /app/Allwissend.AllPlan.Practitioner
COPY . /app/Allwissend.AllPlan.Practitioner

EXPOSE 5002/tcp

RUN ["dotnet", "restore"]
ENTRYPOINT ["dotnet", "run", "-p", "project.json", "web"]
