#!/bin/bash 

set -e

if [[ (${#1} -eq 0) ]] ; then
    echo 
    echo "[ERROR] missing API key"
    echo
    exit 1
fi

NUGET_API_KEY=$1
sdk_version=$(cat lusid.json | jq -r '.info.version')-alpha

sed -i 's/<Version>.*<\/Version>/<Version>'$sdk_version'<\/Version>/g' sdk/LusidSdk/LusidSdk.csproj

echo "sdk_version=$sdk_version"

dotnet pack -c Release sdk/LusidSdk/LusidSdk.csproj
dotnet nuget push sdk/LusidSdk/bin/Release/LusidSdk.${sdk_version}.nupkg \
    --source https://nexus.finbourne.com/repository/nuget-hosted \
    --api-key $NUGET_API_KEY \
    