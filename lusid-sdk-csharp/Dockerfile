FROM microsoft/dotnet:2.0-sdk

RUN mkdir -p /usr/src
WORKDIR /usr/src

COPY LusidSdk.sln /usr/src/
COPY LusidSdk/LusidSdk.csproj /usr/src/LusidSdk/
COPY LusidSdk.Tests/LusidSdk.Tests.csproj /usr/src/LusidSdk.Tests/
RUN dotnet restore LusidSdk

ENV FBN_LUSID_API_URL ${FBN_LUSID_API_URL}

# ENTRYPOINT [ "/bin/bash" ]
ENTRYPOINT dotnet test -v n LusidSdk.Tests