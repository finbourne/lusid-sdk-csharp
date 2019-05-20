#!/bin/bash 

set -e

if [[ (${#1} -eq 0) ]] ; then
    echo 
    echo "[ERROR] missing API key"
    echo
    exit 1
fi

if [[ (${#2} -eq 0) ]] ; then
    echo 
    echo "[ERROR] missing NuGet repo"
    echo
    exit 1
fi

nuget_api_key=$1
nuget_source=$2

sdk_version=$(cat lusid.json | jq -r '.info.version')

sed -i 's/<Version>.*<\/Version>/<Version>'$sdk_version'<\/Version>/g' sdk/Lusid.Sdk/Lusid.Sdk.csproj

echo "sdk_version=$sdk_version"

dotnet pack -c Release sdk/Lusid.Sdk/Lusid.Sdk.csproj
dotnet nuget push sdk/Lusid.Sdk/bin/Release/Lusid.Sdk.${sdk_version}.nupkg \
    --source $nuget_source \
    --api-key $nuget_api_key