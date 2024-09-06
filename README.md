![LUSID_by_Finbourne](./resources/Finbourne_Logo_Teal.svg)

# C# SDK for the LUSID API

## Contents

- [Summary](#summary)
- [Versions](#versions)
- [Requirements](#requirements)
- [Installation](#installation)
- [Getting Started](#getting-started)
    * [Environment variables](#environment-variables)
    * [Secrets file](#secrets-file)
    * [Example](#example)
- [Endpoints and models](#endpoints-and-models)

## Summary

This is the C# SDK for the LUSID API, part of the [LUSID by FINBOURNE](https://www.finbourne.com/lusid-technology) platform. To use it you'll need a LUSID account - [sign up for free at lusid.com](https://www.lusid.com/app/signup).

LUSID is a bi-temporal investment management data platform with portfolio accounting capabilities - see https://support.lusid.com/knowledgebase/ to learn more.

For more details on other applications in the LUSID platform, see [Understanding all the applications in the LUSID platform](https://support.lusid.com/knowledgebase/article/KA-01787).

This sdk supports `Production`, `Early Access`, `Beta` and `Experimental` API endpoints. For more details on API endpoint categories, see [What is the LUSID feature release lifecycle](https://support.lusid.com/knowledgebase/article/KA-01786). To find out which category an API endpoint falls into, see the [swagger page](https://www.lusid.com/api/swagger/index.html).

This code is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project.

## Versions

- API version: 0.11.6833
- SDK version: 2.0.0

## Requirements

- net6.0+

## Installation

The NuGet package for the LUSID API SDK can installed from https://www.nuget.org/packages/Lusid.Sdk using the following

```
$ dotnet add package Lusid.Sdk
```

## Getting Started

You'll need to provide some configuration to connect to the LUSID API - see the articles about [short-lived access tokens](https://support.lusid.com/knowledgebase/article/KA-01654) and a [long-lived Personal Access Token](https://support.lusid.com/knowledgebase/article/KA-01774). This configuration can be provided using a secrets file or environment variables. 

### Environment variables

Required for a short-lived access token
``` 
FBN_TOKEN_URL
FBN_LUSID_URL
FBN_USERNAME
FBN_PASSWORD
FBN_CLIENT_ID
FBN_CLIENT_SECRET
```

Required for a long-lived access token
``` 
FBN_LUSID_URL
FBN_ACCESS_TOKEN
```

You can send your requests to the LUSID API via a proxy, by setting `FBN_PROXY_ADDRESS`. If your proxy has basic auth enabled, you must also set `FBN_PROXY_USERNAME` and `FBN_PROXY_PASSWORD`.

### Secrets file

The secrets file must be in the current working directory.

Required for a short-lived access token
```json
{
    "api":
    {
        "tokenUrl":"<your-token-url>",
        "lusidUrl":"https://<your-domain>.lusid.com/api",
        "username":"<your-username>",
        "password":"<your-password>",
        "clientId":"<your-client-id>",
        "clientSecret":"<your-client-secret>",
    }
}
```

Required for a long-lived access token
```json
{
    "api":
    {
        "lusidUrl":"https://<your-domain>.lusid.com/api",
        "accessToken":"<your-access-token>"
    }
}
```

You can send your requests to the LUSID API via a proxy, by adding a proxy section. If your proxy has basic auth enabled, you must also supply a `username` and `password` in this section.

```json
{
    "api":
    {
        "lusidUrl":"https://<your-domain>.lusid.com/api",
        "accessToken":"<your-access-token>"
    },
    "proxy":
    {
        "address":"<your-proxy-address>",
        "username":"<your-proxy-username>",
        "password":"<your-proxy-password>"
    }
}
```

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AborApi>();
            var scope = "scope_example";  // string | The scope of the Abor.
            var code = "code_example";  // string | The code of the Abor.
            var diaryEntryCode = "diaryEntryCode_example";  // string | Diary entry code
            var diaryEntryRequest = new DiaryEntryRequest(); // DiaryEntryRequest | The diary entry to add.

            try
            {
                // [EXPERIMENTAL] AddDiaryEntry: Add a diary entry to the specified Abor.
                DiaryEntry result = apiInstance.AddDiaryEntry(scope, code, diaryEntryCode, diaryEntryRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AborApi.AddDiaryEntry: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```


## Endpoints and models

- See [Documentation for API Endpoints](sdk/README.md#documentation-for-api-endpoints) for a description of each endpoint
- See [Documentation for Models](sdk/README.md#documentation-for-models) for descriptions of the models used

