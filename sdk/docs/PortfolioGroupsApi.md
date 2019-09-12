# Lusid.Sdk.Api.PortfolioGroupsApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPortfolioToGroup**](PortfolioGroupsApi.md#addportfoliotogroup) | **POST** /api/portfoliogroups/{scope}/{code}/portfolios | [EARLY ACCESS] Add portfolio to group
[**AddSubGroupToGroup**](PortfolioGroupsApi.md#addsubgrouptogroup) | **POST** /api/portfoliogroups/{scope}/{code}/subgroups | [EARLY ACCESS] Add sub group to group
[**CreatePortfolioGroup**](PortfolioGroupsApi.md#createportfoliogroup) | **POST** /api/portfoliogroups/{scope} | [EARLY ACCESS] Create portfolio group
[**DeletePortfolioFromGroup**](PortfolioGroupsApi.md#deleteportfoliofromgroup) | **DELETE** /api/portfoliogroups/{scope}/{code}/portfolios/{portfolioScope}/{portfolioCode} | [EARLY ACCESS] Delete portfolio from group
[**DeletePortfolioGroup**](PortfolioGroupsApi.md#deleteportfoliogroup) | **DELETE** /api/portfoliogroups/{scope}/{code} | [EARLY ACCESS] Delete portfolio group
[**DeleteSubGroupFromGroup**](PortfolioGroupsApi.md#deletesubgroupfromgroup) | **DELETE** /api/portfoliogroups/{scope}/{code}/subgroups/{subgroupScope}/{subgroupCode} | [EARLY ACCESS] Delete sub group from group
[**GetPortfolioGroup**](PortfolioGroupsApi.md#getportfoliogroup) | **GET** /api/portfoliogroups/{scope}/{code} | [EARLY ACCESS] Get portfolio group
[**GetPortfolioGroupCommands**](PortfolioGroupsApi.md#getportfoliogroupcommands) | **GET** /api/portfoliogroups/{scope}/{code}/commands | [EARLY ACCESS] Get portfolio group commands
[**GetPortfolioGroupExpansion**](PortfolioGroupsApi.md#getportfoliogroupexpansion) | **GET** /api/portfoliogroups/{scope}/{code}/expansion | [EARLY ACCESS] Get portfolio group expansion
[**ListPortfolioGroups**](PortfolioGroupsApi.md#listportfoliogroups) | **GET** /api/portfoliogroups/{scope} | [EARLY ACCESS] List portfolio groups
[**UpdatePortfolioGroup**](PortfolioGroupsApi.md#updateportfoliogroup) | **PUT** /api/portfoliogroups/{scope}/{code} | [EARLY ACCESS] Update portfolio group



## AddPortfolioToGroup

> PortfolioGroup AddPortfolioToGroup (string scope, string code, ResourceId portfolioId = null)

[EARLY ACCESS] Add portfolio to group

Add a single portfolio to a portfolio group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class AddPortfolioToGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio group to add a portfolio to.
            var code = code_example;  // string | The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.
            var portfolioId = new ResourceId(); // ResourceId | The resource identifier of the portfolio to add to the portfolio group. (optional) 

            try
            {
                // [EARLY ACCESS] Add portfolio to group
                PortfolioGroup result = apiInstance.AddPortfolioToGroup(scope, code, portfolioId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.AddPortfolioToGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group to add a portfolio to. | 
 **code** | **string**| The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group. | 
 **portfolioId** | [**ResourceId**](ResourceId.md)| The resource identifier of the portfolio to add to the portfolio group. | [optional] 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The portfolio group containing the newly added portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AddSubGroupToGroup

> PortfolioGroup AddSubGroupToGroup (string scope, string code, ResourceId portfolioGroupId = null)

[EARLY ACCESS] Add sub group to group

Add a portfolio group to a portfolio group as a sub group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class AddSubGroupToGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio group to add a portfolio group to.
            var code = code_example;  // string | The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.
            var portfolioGroupId = new ResourceId(); // ResourceId | The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional) 

            try
            {
                // [EARLY ACCESS] Add sub group to group
                PortfolioGroup result = apiInstance.AddSubGroupToGroup(scope, code, portfolioGroupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.AddSubGroupToGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group to add a portfolio group to. | 
 **code** | **string**| The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group. | 
 **portfolioGroupId** | [**ResourceId**](ResourceId.md)| The resource identifier of the portfolio group to add to the portfolio group as a sub group. | [optional] 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The portfolio group containing the newly added portfolio group as a sub group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreatePortfolioGroup

> PortfolioGroup CreatePortfolioGroup (string scope, CreatePortfolioGroupRequest request = null)

[EARLY ACCESS] Create portfolio group

Create a portfolio group in a specific scope.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreatePortfolioGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(Configuration.Default);
            var scope = scope_example;  // string | The scope that the portfolio group will be created in.
            var request = new CreatePortfolioGroupRequest(); // CreatePortfolioGroupRequest | The definition and details of the portfolio group. (optional) 

            try
            {
                // [EARLY ACCESS] Create portfolio group
                PortfolioGroup result = apiInstance.CreatePortfolioGroup(scope, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.CreatePortfolioGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that the portfolio group will be created in. | 
 **request** | [**CreatePortfolioGroupRequest**](CreatePortfolioGroupRequest.md)| The definition and details of the portfolio group. | [optional] 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created portfolio group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePortfolioFromGroup

> PortfolioGroup DeletePortfolioFromGroup (string scope, string code, string portfolioScope, string portfolioCode)

[EARLY ACCESS] Delete portfolio from group

Remove a single portfolio from a portfolio group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePortfolioFromGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio group to remove the portfolio from.
            var code = code_example;  // string | The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.
            var portfolioScope = portfolioScope_example;  // string | The scope of the portfolio being removed from the portfolio group.
            var portfolioCode = portfolioCode_example;  // string | The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.

            try
            {
                // [EARLY ACCESS] Delete portfolio from group
                PortfolioGroup result = apiInstance.DeletePortfolioFromGroup(scope, code, portfolioScope, portfolioCode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.DeletePortfolioFromGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group to remove the portfolio from. | 
 **code** | **string**| The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group. | 
 **portfolioScope** | **string**| The scope of the portfolio being removed from the portfolio group. | 
 **portfolioCode** | **string**| The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove. | 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The portfolio group with the portfolio removed from the group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePortfolioGroup

> DeletedEntityResponse DeletePortfolioGroup (string scope, string code)

[EARLY ACCESS] Delete portfolio group

Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted however they will no longer be grouped together by this portfolio group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePortfolioGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio group to delete.
            var code = code_example;  // string | The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.

            try
            {
                // [EARLY ACCESS] Delete portfolio group
                DeletedEntityResponse result = apiInstance.DeletePortfolioGroup(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.DeletePortfolioGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group to delete. | 
 **code** | **string**| The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete. | 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the portfolio group was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSubGroupFromGroup

> PortfolioGroup DeleteSubGroupFromGroup (string scope, string code, string subgroupScope, string subgroupCode)

[EARLY ACCESS] Delete sub group from group

Remove a single portfolio group (sub group) from a portfolio group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteSubGroupFromGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio group to remove the sub group from.
            var code = code_example;  // string | The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.
            var subgroupScope = subgroupScope_example;  // string | The scope of the sub group to remove from the portfolio group.
            var subgroupCode = subgroupCode_example;  // string | The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.

            try
            {
                // [EARLY ACCESS] Delete sub group from group
                PortfolioGroup result = apiInstance.DeleteSubGroupFromGroup(scope, code, subgroupScope, subgroupCode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.DeleteSubGroupFromGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group to remove the sub group from. | 
 **code** | **string**| The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group. | 
 **subgroupScope** | **string**| The scope of the sub group to remove from the portfolio group. | 
 **subgroupCode** | **string**| The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group. | 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The portfolio group with the sub group removed from the group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPortfolioGroup

> PortfolioGroup GetPortfolioGroup (string scope, string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] Get portfolio group

Retrieve the definition of a single portfolio group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio group to retrieve the definition for.
            var code = code_example;  // string | The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] Get portfolio group
                PortfolioGroup result = apiInstance.GetPortfolioGroup(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.GetPortfolioGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group to retrieve the definition for. | 
 **code** | **string**| The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. | [optional] 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio group definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPortfolioGroupCommands

> ResourceListOfProcessedCommand GetPortfolioGroupCommands (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, string filter = null)

[EARLY ACCESS] Get portfolio group commands

Gets all the commands that modified a single portfolio group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioGroupCommandsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio group to retrieve the commands for.
            var code = code_example;  // string | The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.
            var fromAsAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional) 
            var toAsAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] Get portfolio group commands
                ResourceListOfProcessedCommand result = apiInstance.GetPortfolioGroupCommands(scope, code, fromAsAt, toAsAt, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.GetPortfolioGroupCommands: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group to retrieve the commands for. | 
 **code** | **string**| The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group. | 
 **fromAsAt** | **DateTimeOffset?**| The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. | [optional] 
 **toAsAt** | **DateTimeOffset?**| The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**ResourceListOfProcessedCommand**](ResourceListOfProcessedCommand.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The commands that modified the specified portfolio group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPortfolioGroupExpansion

> ExpandedGroup GetPortfolioGroupExpansion (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyFilter = null)

[EARLY ACCESS] Get portfolio group expansion

List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioGroupExpansionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio group to expand.
            var code = code_example;  // string | The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional) 
            var propertyFilter = new List<string>(); // List<string> | The restricted list of property keys from the \"Portfolio\" domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \"Portfolio/Manager/Id\". (optional) 

            try
            {
                // [EARLY ACCESS] Get portfolio group expansion
                ExpandedGroup result = apiInstance.GetPortfolioGroupExpansion(scope, code, effectiveAt, asAt, propertyFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.GetPortfolioGroupExpansion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group to expand. | 
 **code** | **string**| The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand. | 
 **effectiveAt** | **DateTimeOffset?**| The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. | [optional] 
 **propertyFilter** | [**List&lt;string&gt;**](string.md)| The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. | [optional] 

### Return type

[**ExpandedGroup**](ExpandedGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The expanded portfolio group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListPortfolioGroups

> ResourceListOfPortfolioGroup ListPortfolioGroups (string scope, DateTimeOffset? asAt = null, string filter = null)

[EARLY ACCESS] List portfolio groups

List all the portfolio groups in a single scope.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListPortfolioGroupsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(Configuration.Default);
            var scope = scope_example;  // string | The scope to list the portfolio groups in.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] List portfolio groups
                ResourceListOfPortfolioGroup result = apiInstance.ListPortfolioGroups(scope, asAt, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.ListPortfolioGroups: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope to list the portfolio groups in. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**ResourceListOfPortfolioGroup**](ResourceListOfPortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The portfolio groups in the specified scope |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePortfolioGroup

> PortfolioGroup UpdatePortfolioGroup (string scope, string code, UpdatePortfolioGroupRequest request = null)

[EARLY ACCESS] Update portfolio group

Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdatePortfolioGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio group to update the definition for.
            var code = code_example;  // string | The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.
            var request = new UpdatePortfolioGroupRequest(); // UpdatePortfolioGroupRequest | The updated portfolio group definition. (optional) 

            try
            {
                // [EARLY ACCESS] Update portfolio group
                PortfolioGroup result = apiInstance.UpdatePortfolioGroup(scope, code, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.UpdatePortfolioGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group to update the definition for. | 
 **code** | **string**| The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group. | 
 **request** | [**UpdatePortfolioGroupRequest**](UpdatePortfolioGroupRequest.md)| The updated portfolio group definition. | [optional] 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The updated definition of the portfolio group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

