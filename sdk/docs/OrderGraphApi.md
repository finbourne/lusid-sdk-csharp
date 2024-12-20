# Lusid.Sdk.Api.OrderGraphApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListOrderGraphBlocks**](OrderGraphApi.md#listordergraphblocks) | **GET** /api/ordergraph/blocks | ListOrderGraphBlocks: Lists blocks that pass the filter provided, and builds a summary picture of the state of their associated order entities. |
| [**ListOrderGraphPlacementChildren**](OrderGraphApi.md#listordergraphplacementchildren) | **GET** /api/ordergraph/placementchildren/{scope}/{code} | [EARLY ACCESS] ListOrderGraphPlacementChildren: Lists all placements for the parent placement specified by the scope and code, and builds a summary picture of the state of their associated order entities. |
| [**ListOrderGraphPlacements**](OrderGraphApi.md#listordergraphplacements) | **GET** /api/ordergraph/placements | ListOrderGraphPlacements: Lists placements that pass the filter provided, and builds a summary picture of the state of their associated order entities. |

<a id="listordergraphblocks"></a>
# **ListOrderGraphBlocks**
> PagedResourceListOfOrderGraphBlock ListOrderGraphBlocks (DateTimeOffset? asAt = null, string? paginationToken = null, List<string>? sortBy = null, int? limit = null, string? filter = null, List<string>? propertyKeys = null, bool? useComplianceV2 = null)

ListOrderGraphBlocks: Lists blocks that pass the filter provided, and builds a summary picture of the state of their associated order entities.

Lists all blocks of orders, subject to the filter, along with the IDs of orders, placements, allocations and  executions in the block, the total quantities of each, and a simple text field describing the overall state.

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

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<OrderGraphApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<OrderGraphApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | See https://support.lusid.com/knowledgebase/article/KA-01832/ (optional) 
            var paginationToken = "paginationToken_example";  // string? | See https://support.lusid.com/knowledgebase/article/KA-01915/ (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 56;  // int? | See https://support.lusid.com/knowledgebase/article/KA-01915/ (optional) 
            var filter = "\"\"";  // string? | See https://support.lusid.com/knowledgebase/article/KA-01914/ (optional)  (default to "")
            var propertyKeys = new List<string>?(); // List<string>? | Must be block-level properties. See https://support.lusid.com/knowledgebase/article/KA-01855/ (optional) 
            var useComplianceV2 = false;  // bool? | Whether to use the V2 compliance engine when deriving compliance statuses for orders. (default: false) (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfOrderGraphBlock result = apiInstance.ListOrderGraphBlocks(asAt, paginationToken, sortBy, limit, filter, propertyKeys, useComplianceV2, opts: opts);

                // ListOrderGraphBlocks: Lists blocks that pass the filter provided, and builds a summary picture of the state of their associated order entities.
                PagedResourceListOfOrderGraphBlock result = apiInstance.ListOrderGraphBlocks(asAt, paginationToken, sortBy, limit, filter, propertyKeys, useComplianceV2);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling OrderGraphApi.ListOrderGraphBlocks: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListOrderGraphBlocksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListOrderGraphBlocks: Lists blocks that pass the filter provided, and builds a summary picture of the state of their associated order entities.
    ApiResponse<PagedResourceListOfOrderGraphBlock> response = apiInstance.ListOrderGraphBlocksWithHttpInfo(asAt, paginationToken, sortBy, limit, filter, propertyKeys, useComplianceV2);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling OrderGraphApi.ListOrderGraphBlocksWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | See https://support.lusid.com/knowledgebase/article/KA-01832/ | [optional]  |
| **paginationToken** | **string?** | See https://support.lusid.com/knowledgebase/article/KA-01915/ | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **limit** | **int?** | See https://support.lusid.com/knowledgebase/article/KA-01915/ | [optional]  |
| **filter** | **string?** | See https://support.lusid.com/knowledgebase/article/KA-01914/ | [optional] [default to &quot;&quot;] |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | Must be block-level properties. See https://support.lusid.com/knowledgebase/article/KA-01855/ | [optional]  |
| **useComplianceV2** | **bool?** | Whether to use the V2 compliance engine when deriving compliance statuses for orders. (default: false) | [optional] [default to false] |

### Return type

[**PagedResourceListOfOrderGraphBlock**](PagedResourceListOfOrderGraphBlock.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Blocks in scope. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listordergraphplacementchildren"></a>
# **ListOrderGraphPlacementChildren**
> PagedResourceListOfOrderGraphPlacement ListOrderGraphPlacementChildren (string scope, string code, DateTimeOffset? asAt = null, string? paginationToken = null, List<string>? sortBy = null, int? limit = null, List<string>? propertyKeys = null)

[EARLY ACCESS] ListOrderGraphPlacementChildren: Lists all placements for the parent placement specified by the scope and code, and builds a summary picture of the state of their associated order entities.

Lists all child order placements, for the specified parent placement, along with the IDs of the block and order that the  placement is for, each placement's quantity, the IDs of all allocations and executions in the placement  and the total quantities of those, and a simple text field describing the overall state of the placement.

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

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<OrderGraphApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<OrderGraphApi>();
            var scope = "scope_example";  // string | The parent placement's scope
            var code = "code_example";  // string | The parent placement's code
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | See https://support.lusid.com/knowledgebase/article/KA-01832/ (optional) 
            var paginationToken = "paginationToken_example";  // string? | See https://support.lusid.com/knowledgebase/article/KA-01915/ (optional) 
            var sortBy = new List<string>?(); // List<string>? | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. (optional) 
            var limit = 56;  // int? | See https://support.lusid.com/knowledgebase/article/KA-01915/ (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | Must be placement properties. See https://support.lusid.com/knowledgebase/article/KA-01855/ (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfOrderGraphPlacement result = apiInstance.ListOrderGraphPlacementChildren(scope, code, asAt, paginationToken, sortBy, limit, propertyKeys, opts: opts);

                // [EARLY ACCESS] ListOrderGraphPlacementChildren: Lists all placements for the parent placement specified by the scope and code, and builds a summary picture of the state of their associated order entities.
                PagedResourceListOfOrderGraphPlacement result = apiInstance.ListOrderGraphPlacementChildren(scope, code, asAt, paginationToken, sortBy, limit, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling OrderGraphApi.ListOrderGraphPlacementChildren: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListOrderGraphPlacementChildrenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListOrderGraphPlacementChildren: Lists all placements for the parent placement specified by the scope and code, and builds a summary picture of the state of their associated order entities.
    ApiResponse<PagedResourceListOfOrderGraphPlacement> response = apiInstance.ListOrderGraphPlacementChildrenWithHttpInfo(scope, code, asAt, paginationToken, sortBy, limit, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling OrderGraphApi.ListOrderGraphPlacementChildrenWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The parent placement&#39;s scope |  |
| **code** | **string** | The parent placement&#39;s code |  |
| **asAt** | **DateTimeOffset?** | See https://support.lusid.com/knowledgebase/article/KA-01832/ | [optional]  |
| **paginationToken** | **string?** | See https://support.lusid.com/knowledgebase/article/KA-01915/ | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. | [optional]  |
| **limit** | **int?** | See https://support.lusid.com/knowledgebase/article/KA-01915/ | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | Must be placement properties. See https://support.lusid.com/knowledgebase/article/KA-01855/ | [optional]  |

### Return type

[**PagedResourceListOfOrderGraphPlacement**](PagedResourceListOfOrderGraphPlacement.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List all child Placements for the specified Placement. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listordergraphplacements"></a>
# **ListOrderGraphPlacements**
> PagedResourceListOfOrderGraphPlacement ListOrderGraphPlacements (DateTimeOffset? asAt = null, string? paginationToken = null, List<string>? sortBy = null, int? limit = null, string? filter = null, List<string>? propertyKeys = null)

ListOrderGraphPlacements: Lists placements that pass the filter provided, and builds a summary picture of the state of their associated order entities.

Lists all order placements, subject to the filter, along with the IDs of the block and order that the  placement is for, each placement's quantity, the IDs of all allocations and executions in the placement  and the total quantities of those, and a simple text field describing the overall state of the placement.

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

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<OrderGraphApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<OrderGraphApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | See https://support.lusid.com/knowledgebase/article/KA-01832/ (optional) 
            var paginationToken = "paginationToken_example";  // string? | See https://support.lusid.com/knowledgebase/article/KA-01915/ (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 56;  // int? | See https://support.lusid.com/knowledgebase/article/KA-01915/ (optional) 
            var filter = "\"\"";  // string? | See https://support.lusid.com/knowledgebase/article/KA-01914/ (optional)  (default to "")
            var propertyKeys = new List<string>?(); // List<string>? | Must be placement properties. See https://support.lusid.com/knowledgebase/article/KA-01855/ (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfOrderGraphPlacement result = apiInstance.ListOrderGraphPlacements(asAt, paginationToken, sortBy, limit, filter, propertyKeys, opts: opts);

                // ListOrderGraphPlacements: Lists placements that pass the filter provided, and builds a summary picture of the state of their associated order entities.
                PagedResourceListOfOrderGraphPlacement result = apiInstance.ListOrderGraphPlacements(asAt, paginationToken, sortBy, limit, filter, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling OrderGraphApi.ListOrderGraphPlacements: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListOrderGraphPlacementsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListOrderGraphPlacements: Lists placements that pass the filter provided, and builds a summary picture of the state of their associated order entities.
    ApiResponse<PagedResourceListOfOrderGraphPlacement> response = apiInstance.ListOrderGraphPlacementsWithHttpInfo(asAt, paginationToken, sortBy, limit, filter, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling OrderGraphApi.ListOrderGraphPlacementsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | See https://support.lusid.com/knowledgebase/article/KA-01832/ | [optional]  |
| **paginationToken** | **string?** | See https://support.lusid.com/knowledgebase/article/KA-01915/ | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **limit** | **int?** | See https://support.lusid.com/knowledgebase/article/KA-01915/ | [optional]  |
| **filter** | **string?** | See https://support.lusid.com/knowledgebase/article/KA-01914/ | [optional] [default to &quot;&quot;] |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | Must be placement properties. See https://support.lusid.com/knowledgebase/article/KA-01855/ | [optional]  |

### Return type

[**PagedResourceListOfOrderGraphPlacement**](PagedResourceListOfOrderGraphPlacement.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Placements in scope. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

