#!/usr/bin/env bash
#
# Generated by: https://github.com/swagger-api/swagger-codegen.git
#

dotnet restore src/Allwissend.AllPlan.Auth/ && \
    dotnet build src/Allwissend.AllPlan.Auth/ && \
    echo "Now, run the following to start the project: dotnet run -p src/Allwissend.AllPlan.Auth/Allwissend.AllPlan.Auth.csproj --launch-profile web"