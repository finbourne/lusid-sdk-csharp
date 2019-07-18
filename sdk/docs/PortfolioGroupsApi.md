# Lusid.Sdk.Api.PortfolioGroupsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPortfolioToGroup**](PortfolioGroupsApi.md#addportfoliotogroup) | **POST** /api/portfoliogroups/{scope}/{code}/portfolios | [EARLY ACCESS] Add portfolio to group
[**AddSubGroupToGroup**](PortfolioGroupsApi.md#addsubgrouptogroup) | **POST** /api/portfoliogroups/{scope}/{code}/subgroups | [EARLY ACCESS] Add group to group
[**CreatePortfolioGroup**](PortfolioGroupsApi.md#createportfoliogroup) | **POST** /api/portfoliogroups/{scope} | [EARLY ACCESS] Create group
[**DeletePortfolioFromGroup**](PortfolioGroupsApi.md#deleteportfoliofromgroup) | **DELETE** /api/portfoliogroups/{scope}/{code}/portfolios/{portfolioScope}/{portfolioCode} | [EARLY ACCESS] Remove portfolio from group
[**DeletePortfolioGroup**](PortfolioGroupsApi.md#deleteportfoliogroup) | **DELETE** /api/portfoliogroups/{scope}/{code} | [EARLY ACCESS] Delete group
[**DeleteSubGroupFromGroup**](PortfolioGroupsApi.md#deletesubgroupfromgroup) | **DELETE** /api/portfoliogroups/{scope}/{code}/subgroups/{subgroupScope}/{subgroupCode} | [EARLY ACCESS] Remove group from group
[**GetPortfolioGroup**](PortfolioGroupsApi.md#getportfoliogroup) | **GET** /api/portfoliogroups/{scope}/{code} | [EARLY ACCESS] Get portfolio group
[**GetPortfolioGroupCommands**](PortfolioGroupsApi.md#getportfoliogroupcommands) | **GET** /api/portfoliogroups/{scope}/{code}/commands | [EARLY ACCESS] Get commands
[**GetPortfolioGroupExpansion**](PortfolioGroupsApi.md#getportfoliogroupexpansion) | **GET** /api/portfoliogroups/{scope}/{code}/expansion | [EARLY ACCESS] Get a full expansion of a portfolio group
[**ListPortfolioGroups**](PortfolioGroupsApi.md#listportfoliogroups) | **GET** /api/portfoliogroups/{scope} | [EARLY ACCESS] List groups in scope
[**UpdatePortfolioGroup**](PortfolioGroupsApi.md#updateportfoliogroup) | **PUT** /api/portfoliogroups/{scope}/{code} | [EARLY ACCESS] Update group



## AddPortfolioToGroup

> PortfolioGroup AddPortfolioToGroup (string scope, string code, ResourceId portfolioId = null)

[EARLY ACCESS] Add portfolio to group

Adds a portfolio to a previously defined portfolio group

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class AddPortfolioToGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi();
            var scope = scope_example;  // string | The scope of the portfolio group to which a portfolio is being added
            var code = code_example;  // string | The code of the portfolio group to which a portfolio is being added
            var portfolioId = new ResourceId(); // ResourceId | The id of the portfolio (optional) 

            try
            {
                // [EARLY ACCESS] Add portfolio to group
                PortfolioGroup result = apiInstance.AddPortfolioToGroup(scope, code, portfolioId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.AddPortfolioToGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group to which a portfolio is being added | 
 **code** | **string**| The code of the portfolio group to which a portfolio is being added | 
 **portfolioId** | [**ResourceId**](ResourceId.md)| The id of the portfolio | [optional] 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AddSubGroupToGroup

> PortfolioGroup AddSubGroupToGroup (string scope, string code, ResourceId portfolioGroupId = null)

[EARLY ACCESS] Add group to group

Adds a portfolio group, as a sub-group, to an existing portfolio group

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class AddSubGroupToGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi();
            var scope = scope_example;  // string | The scope of the portfolio group to which a sub-group is being added
            var code = code_example;  // string | The code of the portfolio group to which a sub-group is being added
            var portfolioGroupId = new ResourceId(); // ResourceId | The id of the portfolio group being added as a sub-group (optional) 

            try
            {
                // [EARLY ACCESS] Add group to group
                PortfolioGroup result = apiInstance.AddSubGroupToGroup(scope, code, portfolioGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.AddSubGroupToGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group to which a sub-group is being added | 
 **code** | **string**| The code of the portfolio group to which a sub-group is being added | 
 **portfolioGroupId** | [**ResourceId**](ResourceId.md)| The id of the portfolio group being added as a sub-group | [optional] 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreatePortfolioGroup

> PortfolioGroup CreatePortfolioGroup (string scope, CreatePortfolioGroupRequest request = null)

[EARLY ACCESS] Create group

Create a new portfolio group.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreatePortfolioGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi();
            var scope = scope_example;  // string | The scope into which the portfolio group will be created
            var request = new CreatePortfolioGroupRequest(); // CreatePortfolioGroupRequest | The definition of the new portfolio group (optional) 

            try
            {
                // [EARLY ACCESS] Create group
                PortfolioGroup result = apiInstance.CreatePortfolioGroup(scope, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.CreatePortfolioGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope into which the portfolio group will be created | 
 **request** | [**CreatePortfolioGroupRequest**](CreatePortfolioGroupRequest.md)| The definition of the new portfolio group | [optional] 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePortfolioFromGroup

> PortfolioGroup DeletePortfolioFromGroup (string scope, string code, string portfolioScope, string portfolioCode)

[EARLY ACCESS] Remove portfolio from group

Removes a portfolio from a portfolio group

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePortfolioFromGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi();
            var scope = scope_example;  // string | The scope of the portfolio group
            var code = code_example;  // string | The code of the portfolio group
            var portfolioScope = portfolioScope_example;  // string | The scope of the portfolio being removed
            var portfolioCode = portfolioCode_example;  // string | The code of the portfolio being removed

            try
            {
                // [EARLY ACCESS] Remove portfolio from group
                PortfolioGroup result = apiInstance.DeletePortfolioFromGroup(scope, code, portfolioScope, portfolioCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.DeletePortfolioFromGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group | 
 **code** | **string**| The code of the portfolio group | 
 **portfolioScope** | **string**| The scope of the portfolio being removed | 
 **portfolioCode** | **string**| The code of the portfolio being removed | 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePortfolioGroup

> DeletedEntityResponse DeletePortfolioGroup (string scope, string code)

[EARLY ACCESS] Delete group

Deletes the definition of the specified portfolio group

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePortfolioGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi();
            var scope = scope_example;  // string | The scope of the portfolio group
            var code = code_example;  // string | The code of the portfolio group

            try
            {
                // [EARLY ACCESS] Delete group
                DeletedEntityResponse result = apiInstance.DeletePortfolioGroup(scope, code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.DeletePortfolioGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group | 
 **code** | **string**| The code of the portfolio group | 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSubGroupFromGroup

> PortfolioGroup DeleteSubGroupFromGroup (string scope, string code, string subgroupScope, string subgroupCode)

[EARLY ACCESS] Remove group from group

Remove a portfolio group (sub-group) from a parent portfolio group

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteSubGroupFromGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi();
            var scope = scope_example;  // string | The scope of the portfolio group
            var code = code_example;  // string | The code of the portfolio group
            var subgroupScope = subgroupScope_example;  // string | The scope of the sub-group being removed
            var subgroupCode = subgroupCode_example;  // string | The code of the sub-group being removed

            try
            {
                // [EARLY ACCESS] Remove group from group
                PortfolioGroup result = apiInstance.DeleteSubGroupFromGroup(scope, code, subgroupScope, subgroupCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.DeleteSubGroupFromGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group | 
 **code** | **string**| The code of the portfolio group | 
 **subgroupScope** | **string**| The scope of the sub-group being removed | 
 **subgroupCode** | **string**| The code of the sub-group being removed | 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPortfolioGroup

> PortfolioGroup GetPortfolioGroup (string scope, string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] Get portfolio group

Get the definition of the specified portfolio group

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi();
            var scope = scope_example;  // string | The scope of the portfolio group
            var code = code_example;  // string | The code of the portfolio group
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 

            try
            {
                // [EARLY ACCESS] Get portfolio group
                PortfolioGroup result = apiInstance.GetPortfolioGroup(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.GetPortfolioGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group | 
 **code** | **string**| The code of the portfolio group | 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPortfolioGroupCommands

> ResourceListOfProcessedCommand GetPortfolioGroupCommands (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

[EARLY ACCESS] Get commands

Gets all commands that modified a specific portfolio group

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioGroupCommandsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi();
            var scope = scope_example;  // string | The scope of the portfolio group
            var code = code_example;  // string | The code of the portfolio group
            var fromAsAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. Filters commands by those that were processed at or after this date and time (optional) 
            var toAsAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. Filters commands by those that were processed at or before this date and time (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // [EARLY ACCESS] Get commands
                ResourceListOfProcessedCommand result = apiInstance.GetPortfolioGroupCommands(scope, code, fromAsAt, toAsAt, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.GetPortfolioGroupCommands: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group | 
 **code** | **string**| The code of the portfolio group | 
 **fromAsAt** | **DateTimeOffset?**| Optional. Filters commands by those that were processed at or after this date and time | [optional] 
 **toAsAt** | **DateTimeOffset?**| Optional. Filters commands by those that were processed at or before this date and time | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ResourceListOfProcessedCommand**](ResourceListOfProcessedCommand.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPortfolioGroupExpansion

> ExpandedGroup GetPortfolioGroupExpansion (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyFilter = null)

[EARLY ACCESS] Get a full expansion of a portfolio group

Lists all portfolios in a group, and all sub groups. Portfolios are decorated with their properties.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioGroupExpansionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The effective date of the data (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var propertyFilter = new List<string>(); // List<string> | Optional. The restricted set of properties that should be returned (optional) 

            try
            {
                // [EARLY ACCESS] Get a full expansion of a portfolio group
                ExpandedGroup result = apiInstance.GetPortfolioGroupExpansion(scope, code, effectiveAt, asAt, propertyFilter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.GetPortfolioGroupExpansion: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio | 
 **code** | **string**| The code of the portfolio | 
 **effectiveAt** | **DateTimeOffset?**| Optional. The effective date of the data | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **propertyFilter** | [**List&lt;string&gt;**](string.md)| Optional. The restricted set of properties that should be returned | [optional] 

### Return type

[**ExpandedGroup**](ExpandedGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListPortfolioGroups

> ResourceListOfPortfolioGroup ListPortfolioGroups (string scope, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

[EARLY ACCESS] List groups in scope

Lists all portfolio groups in a specified scope

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListPortfolioGroupsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi();
            var scope = scope_example;  // string | The scope
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // [EARLY ACCESS] List groups in scope
                ResourceListOfPortfolioGroup result = apiInstance.ListPortfolioGroups(scope, asAt, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.ListPortfolioGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope | 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ResourceListOfPortfolioGroup**](ResourceListOfPortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePortfolioGroup

> PortfolioGroup UpdatePortfolioGroup (string scope, string code, UpdatePortfolioGroupRequest request = null)

[EARLY ACCESS] Update group

Update the definition of the specified existing portfolio group.    Not all elements within a portfolio group definition are modifiable after creation.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdatePortfolioGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi();
            var scope = scope_example;  // string | The scope of the portfolio group
            var code = code_example;  // string | The code of the portfolio group
            var request = new UpdatePortfolioGroupRequest(); // UpdatePortfolioGroupRequest | The updated definition of the portfolio group (optional) 

            try
            {
                // [EARLY ACCESS] Update group
                PortfolioGroup result = apiInstance.UpdatePortfolioGroup(scope, code, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.UpdatePortfolioGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group | 
 **code** | **string**| The code of the portfolio group | 
 **request** | [**UpdatePortfolioGroupRequest**](UpdatePortfolioGroupRequest.md)| The updated definition of the portfolio group | [optional] 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

