# Lusid.Sdk.Api.PortfolioGroupsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPortfolioToGroup**](PortfolioGroupsApi.md#addportfoliotogroup) | **POST** /api/portfoliogroups/{scope}/{code}/portfolios | [EARLY ACCESS] AddPortfolioToGroup: Add portfolio to group
[**AddSubGroupToGroup**](PortfolioGroupsApi.md#addsubgrouptogroup) | **POST** /api/portfoliogroups/{scope}/{code}/subgroups | [EARLY ACCESS] AddSubGroupToGroup: Add sub group to group
[**BuildTransactionsForPortfolioGroup**](PortfolioGroupsApi.md#buildtransactionsforportfoliogroup) | **POST** /api/portfoliogroups/{scope}/{code}/transactions/$build | BuildTransactionsForPortfolioGroup: Build transactions for transaction portfolios in a portfolio group
[**CreatePortfolioGroup**](PortfolioGroupsApi.md#createportfoliogroup) | **POST** /api/portfoliogroups/{scope} | CreatePortfolioGroup: Create portfolio group
[**DeleteGroupProperties**](PortfolioGroupsApi.md#deletegroupproperties) | **POST** /api/portfoliogroups/{scope}/{code}/properties/$delete | [EARLY ACCESS] DeleteGroupProperties: Delete group properties
[**DeleteKeyFromPortfolioGroupAccessMetadata**](PortfolioGroupsApi.md#deletekeyfromportfoliogroupaccessmetadata) | **DELETE** /api/portfoliogroups/{scope}/{code}/metadata/{metadataKey} | [EARLY ACCESS] DeleteKeyFromPortfolioGroupAccessMetadata: Delete a Portfolio Group Access Metadata entry
[**DeletePortfolioFromGroup**](PortfolioGroupsApi.md#deleteportfoliofromgroup) | **DELETE** /api/portfoliogroups/{scope}/{code}/portfolios/{portfolioScope}/{portfolioCode} | [EARLY ACCESS] DeletePortfolioFromGroup: Delete portfolio from group
[**DeletePortfolioGroup**](PortfolioGroupsApi.md#deleteportfoliogroup) | **DELETE** /api/portfoliogroups/{scope}/{code} | [EARLY ACCESS] DeletePortfolioGroup: Delete portfolio group
[**DeleteSubGroupFromGroup**](PortfolioGroupsApi.md#deletesubgroupfromgroup) | **DELETE** /api/portfoliogroups/{scope}/{code}/subgroups/{subgroupScope}/{subgroupCode} | [EARLY ACCESS] DeleteSubGroupFromGroup: Delete sub group from group
[**GetA2BDataForPortfolioGroup**](PortfolioGroupsApi.md#geta2bdataforportfoliogroup) | **GET** /api/portfoliogroups/{scope}/{code}/a2b | [EARLY ACCESS] GetA2BDataForPortfolioGroup: Get A2B data for a Portfolio Group
[**GetGroupProperties**](PortfolioGroupsApi.md#getgroupproperties) | **GET** /api/portfoliogroups/{scope}/{code}/properties | [EARLY ACCESS] GetGroupProperties: Get group properties
[**GetHoldingsForPortfolioGroup**](PortfolioGroupsApi.md#getholdingsforportfoliogroup) | **GET** /api/portfoliogroups/{scope}/{code}/holdings | GetHoldingsForPortfolioGroup: Get holdings for transaction portfolios in portfolio group
[**GetPortfolioGroup**](PortfolioGroupsApi.md#getportfoliogroup) | **GET** /api/portfoliogroups/{scope}/{code} | GetPortfolioGroup: Get portfolio group
[**GetPortfolioGroupAccessMetadataByKey**](PortfolioGroupsApi.md#getportfoliogroupaccessmetadatabykey) | **GET** /api/portfoliogroups/{scope}/{code}/metadata/{metadataKey} | [EARLY ACCESS] GetPortfolioGroupAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Portfolio Group
[**GetPortfolioGroupCommands**](PortfolioGroupsApi.md#getportfoliogroupcommands) | **GET** /api/portfoliogroups/{scope}/{code}/commands | GetPortfolioGroupCommands: Get portfolio group commands
[**GetPortfolioGroupExpansion**](PortfolioGroupsApi.md#getportfoliogroupexpansion) | **GET** /api/portfoliogroups/{scope}/{code}/expansion | [EARLY ACCESS] GetPortfolioGroupExpansion: Get portfolio group expansion
[**GetPortfolioGroupMetadata**](PortfolioGroupsApi.md#getportfoliogroupmetadata) | **GET** /api/portfoliogroups/{scope}/{code}/metadata | [EARLY ACCESS] GetPortfolioGroupMetadata: Get Access Metadata rules for Portfolio Group
[**GetPortfolioGroupPropertyTimeSeries**](PortfolioGroupsApi.md#getportfoliogrouppropertytimeseries) | **GET** /api/portfoliogroups/{scope}/{code}/properties/time-series | [EARLY ACCESS] GetPortfolioGroupPropertyTimeSeries: Get the time series of a portfolio group property
[**GetPortfolioGroupRelationships**](PortfolioGroupsApi.md#getportfoliogrouprelationships) | **GET** /api/portfoliogroups/{scope}/{code}/relationships | [EARLY ACCESS] GetPortfolioGroupRelationships: Get Relationships for Portfolio Group
[**GetTransactionsForPortfolioGroup**](PortfolioGroupsApi.md#gettransactionsforportfoliogroup) | **GET** /api/portfoliogroups/{scope}/{code}/transactions | GetTransactionsForPortfolioGroup: Get transactions for transaction portfolios in a portfolio group
[**ListPortfolioGroups**](PortfolioGroupsApi.md#listportfoliogroups) | **GET** /api/portfoliogroups/{scope} | [EARLY ACCESS] ListPortfolioGroups: List portfolio groups
[**PatchPortfolioGroupAccessMetadata**](PortfolioGroupsApi.md#patchportfoliogroupaccessmetadata) | **PATCH** /api/portfoliogroups/{scope}/{code}/metadata | [EARLY ACCESS] PatchPortfolioGroupAccessMetadata: Patch Access Metadata rules for a Portfolio Group.
[**UpdatePortfolioGroup**](PortfolioGroupsApi.md#updateportfoliogroup) | **PUT** /api/portfoliogroups/{scope}/{code} | [EARLY ACCESS] UpdatePortfolioGroup: Update portfolio group
[**UpsertGroupProperties**](PortfolioGroupsApi.md#upsertgroupproperties) | **POST** /api/portfoliogroups/{scope}/{code}/properties/$upsert | [EARLY ACCESS] UpsertGroupProperties: Upsert group properties
[**UpsertPortfolioGroupAccessMetadata**](PortfolioGroupsApi.md#upsertportfoliogroupaccessmetadata) | **PUT** /api/portfoliogroups/{scope}/{code}/metadata/{metadataKey} | [EARLY ACCESS] UpsertPortfolioGroupAccessMetadata: Upsert a Portfolio Group Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.


<a name="addportfoliotogroup"></a>
# **AddPortfolioToGroup**
> PortfolioGroup AddPortfolioToGroup (string scope, string code, DateTimeOrCutLabel effectiveAt = null, ResourceId resourceId = null)

[EARLY ACCESS] AddPortfolioToGroup: Add portfolio to group

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
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the portfolio group to add a portfolio to.
            var code = code_example;  // string | The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label from which the portfolio will be added to the group. (optional) 
            var resourceId = new ResourceId(); // ResourceId | The resource identifier of the portfolio to add to the portfolio group. (optional) 

            try
            {
                // [EARLY ACCESS] AddPortfolioToGroup: Add portfolio to group
                PortfolioGroup result = apiInstance.AddPortfolioToGroup(scope, code, effectiveAt, resourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label from which the portfolio will be added to the group. | [optional] 
 **resourceId** | [**ResourceId**](ResourceId.md)| The resource identifier of the portfolio to add to the portfolio group. | [optional] 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The portfolio group containing the newly added portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addsubgrouptogroup"></a>
# **AddSubGroupToGroup**
> PortfolioGroup AddSubGroupToGroup (string scope, string code, DateTimeOrCutLabel effectiveAt = null, ResourceId resourceId = null)

[EARLY ACCESS] AddSubGroupToGroup: Add sub group to group

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
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the portfolio group to add a portfolio group to.
            var code = code_example;  // string | The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label from which the sub group will be added to the group. (optional) 
            var resourceId = new ResourceId(); // ResourceId | The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional) 

            try
            {
                // [EARLY ACCESS] AddSubGroupToGroup: Add sub group to group
                PortfolioGroup result = apiInstance.AddSubGroupToGroup(scope, code, effectiveAt, resourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label from which the sub group will be added to the group. | [optional] 
 **resourceId** | [**ResourceId**](ResourceId.md)| The resource identifier of the portfolio group to add to the portfolio group as a sub group. | [optional] 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The portfolio group containing the newly added portfolio group as a sub group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildtransactionsforportfoliogroup"></a>
# **BuildTransactionsForPortfolioGroup**
> VersionedResourceListOfOutputTransaction BuildTransactionsForPortfolioGroup (string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, int? limit = null, string page = null)

BuildTransactionsForPortfolioGroup: Build transactions for transaction portfolios in a portfolio group

Build transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class BuildTransactionsForPortfolioGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the portfolio group.
            var code = code_example;  // string | The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.
            var transactionQueryParameters = new TransactionQueryParameters(); // TransactionQueryParameters | The query queryParameters which control how the output transactions are built.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to build the transactions. Defaults to return the latest               version of each transaction if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.               For example, to filter on the Transaction Type, use \"type eq 'Buy'\"               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" or \"Transaction\" domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\" or               \"Transaction/strategy/quantsignal\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional) 

            try
            {
                // BuildTransactionsForPortfolioGroup: Build transactions for transaction portfolios in a portfolio group
                VersionedResourceListOfOutputTransaction result = apiInstance.BuildTransactionsForPortfolioGroup(scope, code, transactionQueryParameters, asAt, filter, propertyKeys, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.BuildTransactionsForPortfolioGroup: " + e.Message );
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
 **scope** | **string**| The scope of the portfolio group. | 
 **code** | **string**| The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group. | 
 **transactionQueryParameters** | [**TransactionQueryParameters**](TransactionQueryParameters.md)| The query queryParameters which control how the output transactions are built. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to build the transactions. Defaults to return the latest               version of each transaction if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing transactions from a previous call to BuildTransactions. | [optional] 

### Return type

[**VersionedResourceListOfOutputTransaction**](VersionedResourceListOfOutputTransaction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested transactions from transaction portfolios in the specified portfolio group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createportfoliogroup"></a>
# **CreatePortfolioGroup**
> PortfolioGroup CreatePortfolioGroup (string scope, CreatePortfolioGroupRequest createPortfolioGroupRequest = null)

CreatePortfolioGroup: Create portfolio group

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
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope that the portfolio group will be created in.
            var createPortfolioGroupRequest = new CreatePortfolioGroupRequest(); // CreatePortfolioGroupRequest | The definition and details of the portfolio group. (optional) 

            try
            {
                // CreatePortfolioGroup: Create portfolio group
                PortfolioGroup result = apiInstance.CreatePortfolioGroup(scope, createPortfolioGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **createPortfolioGroupRequest** | [**CreatePortfolioGroupRequest**](CreatePortfolioGroupRequest.md)| The definition and details of the portfolio group. | [optional] 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created portfolio group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroupproperties"></a>
# **DeleteGroupProperties**
> DeletedEntityResponse DeleteGroupProperties (string scope, string code, List<string> requestBody, DateTimeOrCutLabel effectiveAt = null)

[EARLY ACCESS] DeleteGroupProperties: Delete group properties

Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteGroupPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the group to delete properties from.
            var code = code_example;  // string | The code of the group to delete properties from. Together with the scope this uniquely identifies the group.
            var requestBody = new List<string>(); // List<string> | The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \"PortfolioGroup/Manager/Id\". Each property must be from the \"PortfolioGroup\" domain.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified 'effectiveAt' datetime. If the 'effectiveAt' is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional) 

            try
            {
                // [EARLY ACCESS] DeleteGroupProperties: Delete group properties
                DeletedEntityResponse result = apiInstance.DeleteGroupProperties(scope, code, requestBody, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.DeleteGroupProperties: " + e.Message );
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
 **scope** | **string**| The scope of the group to delete properties from. | 
 **code** | **string**| The code of the group to delete properties from. Together with the scope this uniquely identifies the group. | 
 **requestBody** | [**List&lt;string&gt;**](string.md)| The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. | [optional] 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the properties were deleted from the specified group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletekeyfromportfoliogroupaccessmetadata"></a>
# **DeleteKeyFromPortfolioGroupAccessMetadata**
> DeletedEntityResponse DeleteKeyFromPortfolioGroupAccessMetadata (string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] DeleteKeyFromPortfolioGroupAccessMetadata: Delete a Portfolio Group Access Metadata entry

Deletes the Portfolio Group Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteKeyFromPortfolioGroupAccessMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the Portfolio Group
            var code = code_example;  // string | The Portfolio Group code
            var metadataKey = metadataKey_example;  // string | Key of the Access Metadata entry to delete
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective date to delete at, if this is not supplied, it will delete all data found (optional) 
            var effectiveUntil = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' date of the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] DeleteKeyFromPortfolioGroupAccessMetadata: Delete a Portfolio Group Access Metadata entry
                DeletedEntityResponse result = apiInstance.DeleteKeyFromPortfolioGroupAccessMetadata(scope, code, metadataKey, effectiveAt, effectiveUntil);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.DeleteKeyFromPortfolioGroupAccessMetadata: " + e.Message );
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
 **scope** | **string**| The scope of the Portfolio Group | 
 **code** | **string**| The Portfolio Group code | 
 **metadataKey** | **string**| Key of the Access Metadata entry to delete | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective date to delete at, if this is not supplied, it will delete all data found | [optional] 
 **effectiveUntil** | **DateTimeOffset?**| The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata | [optional] 

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
| **200** | The has been deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteportfoliofromgroup"></a>
# **DeletePortfolioFromGroup**
> PortfolioGroup DeletePortfolioFromGroup (string scope, string code, string portfolioScope, string portfolioCode, DateTimeOrCutLabel effectiveAt = null)

[EARLY ACCESS] DeletePortfolioFromGroup: Delete portfolio from group

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
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the portfolio group to remove the portfolio from.
            var code = code_example;  // string | The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.
            var portfolioScope = portfolioScope_example;  // string | The scope of the portfolio being removed from the portfolio group.
            var portfolioCode = portfolioCode_example;  // string | The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label from which the portfolio will be removed from the portfolio group. (optional) 

            try
            {
                // [EARLY ACCESS] DeletePortfolioFromGroup: Delete portfolio from group
                PortfolioGroup result = apiInstance.DeletePortfolioFromGroup(scope, code, portfolioScope, portfolioCode, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label from which the portfolio will be removed from the portfolio group. | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteportfoliogroup"></a>
# **DeletePortfolioGroup**
> DeletedEntityResponse DeletePortfolioGroup (string scope, string code)

[EARLY ACCESS] DeletePortfolioGroup: Delete portfolio group

Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group's creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.

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
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the portfolio group to delete.
            var code = code_example;  // string | The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.

            try
            {
                // [EARLY ACCESS] DeletePortfolioGroup: Delete portfolio group
                DeletedEntityResponse result = apiInstance.DeletePortfolioGroup(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubgroupfromgroup"></a>
# **DeleteSubGroupFromGroup**
> PortfolioGroup DeleteSubGroupFromGroup (string scope, string code, string subgroupScope, string subgroupCode, DateTimeOrCutLabel effectiveAt = null)

[EARLY ACCESS] DeleteSubGroupFromGroup: Delete sub group from group

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
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the portfolio group to remove the sub group from.
            var code = code_example;  // string | The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.
            var subgroupScope = subgroupScope_example;  // string | The scope of the sub group to remove from the portfolio group.
            var subgroupCode = subgroupCode_example;  // string | The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label from which the sub group will be removed from the portfolio group. (optional) 

            try
            {
                // [EARLY ACCESS] DeleteSubGroupFromGroup: Delete sub group from group
                PortfolioGroup result = apiInstance.DeleteSubGroupFromGroup(scope, code, subgroupScope, subgroupCode, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label from which the sub group will be removed from the portfolio group. | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geta2bdataforportfoliogroup"></a>
# **GetA2BDataForPortfolioGroup**
> VersionedResourceListOfA2BDataRecord GetA2BDataForPortfolioGroup (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string recipeIdScope = null, string recipeIdCode = null, List<string> propertyKeys = null, string filter = null)

[EARLY ACCESS] GetA2BDataForPortfolioGroup: Get A2B data for a Portfolio Group

Get an A2B report for all Transaction Portfolios within the given portfolio group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetA2BDataForPortfolioGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the group to retrieve the A2B report for.
            var code = code_example;  // string | The code of the group to retrieve the A2B report for. Together with the scope this              uniquely identifies the portfolio group.
            var fromEffectiveAt = fromEffectiveAt_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.
            var toEffectiveAt = toEffectiveAt_example;  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional) 
            var recipeIdScope = recipeIdScope_example;  // string | The scope of the given recipeId (optional) 
            var recipeIdCode = recipeIdCode_example;  // string | The code of the given recipeId (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\". (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] GetA2BDataForPortfolioGroup: Get A2B data for a Portfolio Group
                VersionedResourceListOfA2BDataRecord result = apiInstance.GetA2BDataForPortfolioGroup(scope, code, fromEffectiveAt, toEffectiveAt, asAt, recipeIdScope, recipeIdCode, propertyKeys, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.GetA2BDataForPortfolioGroup: " + e.Message );
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
 **scope** | **string**| The scope of the group to retrieve the A2B report for. | 
 **code** | **string**| The code of the group to retrieve the A2B report for. Together with the scope this              uniquely identifies the portfolio group. | 
 **fromEffectiveAt** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. | 
 **toEffectiveAt** | **DateTimeOrCutLabel**| The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. | [optional] 
 **recipeIdScope** | **string**| The scope of the given recipeId | [optional] 
 **recipeIdCode** | **string**| The code of the given recipeId | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. | [optional] 
 **filter** | **string**| Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**VersionedResourceListOfA2BDataRecord**](VersionedResourceListOfA2BDataRecord.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested group A2B data |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupproperties"></a>
# **GetGroupProperties**
> PortfolioGroupProperties GetGroupProperties (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetGroupProperties: Get group properties

List all the properties of a single portfolio group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetGroupPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the group to list the properties for.
            var code = code_example;  // string | The code of the group to list the properties for. Together with the scope this uniquely identifies the group.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective date time or cut label at which to list the group's properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt date time at which to list the group's properties. Defaults to return the latest version of each property if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] GetGroupProperties: Get group properties
                PortfolioGroupProperties result = apiInstance.GetGroupProperties(scope, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.GetGroupProperties: " + e.Message );
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
 **scope** | **string**| The scope of the group to list the properties for. | 
 **code** | **string**| The code of the group to list the properties for. Together with the scope this uniquely identifies the group. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. | [optional] 

### Return type

[**PortfolioGroupProperties**](PortfolioGroupProperties.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The properties of the specified group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getholdingsforportfoliogroup"></a>
# **GetHoldingsForPortfolioGroup**
> VersionedResourceListOfPortfolioHolding GetHoldingsForPortfolioGroup (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, bool? byTaxlots = null)

GetHoldingsForPortfolioGroup: Get holdings for transaction portfolios in portfolio group

Get the holdings of transaction portfolios in specified portfolio group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetHoldingsForPortfolioGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the portfolio group.
            var code = code_example;  // string | The code of the portfolio group. Together with the scope this uniquely identifies              the portfolio group.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the holdings of transaction              portfolios in the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings of transaction portfolios in the portfolio group. Defaults              to return the latest version of the holdings if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\", \"Holding\" or \"Portfolio\" domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\" or \"Holding/system/Cost\". (optional) 
            var byTaxlots = true;  // bool? | Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional) 

            try
            {
                // GetHoldingsForPortfolioGroup: Get holdings for transaction portfolios in portfolio group
                VersionedResourceListOfPortfolioHolding result = apiInstance.GetHoldingsForPortfolioGroup(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.GetHoldingsForPortfolioGroup: " + e.Message );
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
 **scope** | **string**| The scope of the portfolio group. | 
 **code** | **string**| The code of the portfolio group. Together with the scope this uniquely identifies              the portfolio group. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the holdings of transaction              portfolios in the portfolio group. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the holdings of transaction portfolios in the portfolio group. Defaults              to return the latest version of the holdings if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot;, \&quot;Holding\&quot; or \&quot;Portfolio\&quot; domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. | [optional] 
 **byTaxlots** | **bool?**| Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. | [optional] 

### Return type

[**VersionedResourceListOfPortfolioHolding**](VersionedResourceListOfPortfolioHolding.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The holdings of transaction portfolios in a specific version of portfolio group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliogroup"></a>
# **GetPortfolioGroup**
> PortfolioGroup GetPortfolioGroup (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> relatedEntityPropertyKeys = null, List<string> relationshipDefinitionIds = null)

GetPortfolioGroup: Get portfolio group

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
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the portfolio group to retrieve the definition for.
            var code = code_example;  // string | The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional) 
            var relatedEntityPropertyKeys = new List<string>(); // List<string> | A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example 'Portfolio/Manager/Id'. (optional) 
            var relationshipDefinitionIds = new List<string>(); // List<string> | A list of relationship definitions that are used to decorate related entities              onto the portfolio group in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // GetPortfolioGroup: Get portfolio group
                PortfolioGroup result = apiInstance.GetPortfolioGroup(scope, code, effectiveAt, asAt, relatedEntityPropertyKeys, relationshipDefinitionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. | [optional] 
 **relatedEntityPropertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. | [optional] 
 **relationshipDefinitionIds** | [**List&lt;string&gt;**](string.md)| A list of relationship definitions that are used to decorate related entities              onto the portfolio group in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliogroupaccessmetadatabykey"></a>
# **GetPortfolioGroupAccessMetadataByKey**
> ICollection&lt;AccessMetadataValue&gt; GetPortfolioGroupAccessMetadataByKey (string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetPortfolioGroupAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Portfolio Group

Get a specific Portfolio Group access metadata by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioGroupAccessMetadataByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the Portfolio Group
            var code = code_example;  // string | The Portfolio Group code
            var metadataKey = metadataKey_example;  // string | Key of the metadata entry to retrieve
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effectiveAt datetime at which to retrieve the access metadata (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the access metadata (optional) 

            try
            {
                // [EARLY ACCESS] GetPortfolioGroupAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Portfolio Group
                ICollection<AccessMetadataValue> result = apiInstance.GetPortfolioGroupAccessMetadataByKey(scope, code, metadataKey, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.GetPortfolioGroupAccessMetadataByKey: " + e.Message );
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
 **scope** | **string**| The scope of the Portfolio Group | 
 **code** | **string**| The Portfolio Group code | 
 **metadataKey** | **string**| Key of the metadata entry to retrieve | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effectiveAt datetime at which to retrieve the access metadata | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the access metadata | [optional] 

### Return type

[**ICollection&lt;AccessMetadataValue&gt;**](AccessMetadataValue.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved Portfolio group access metadata filtered by metadataKey or any failure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliogroupcommands"></a>
# **GetPortfolioGroupCommands**
> ResourceListOfProcessedCommand GetPortfolioGroupCommands (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, string filter = null)

GetPortfolioGroupCommands: Get portfolio group commands

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
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the portfolio group to retrieve the commands for.
            var code = code_example;  // string | The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.
            var fromAsAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional) 
            var toAsAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.               For example, to filter on the User ID, use \"userId.id eq 'string'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // GetPortfolioGroupCommands: Get portfolio group commands
                ResourceListOfProcessedCommand result = apiInstance.GetPortfolioGroupCommands(scope, code, fromAsAt, toAsAt, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **filter** | **string**| Expression to filter the result set.               For example, to filter on the User ID, use \&quot;userId.id eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliogroupexpansion"></a>
# **GetPortfolioGroupExpansion**
> ExpandedGroup GetPortfolioGroupExpansion (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyFilter = null)

[EARLY ACCESS] GetPortfolioGroupExpansion: Get portfolio group expansion

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
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the portfolio group to expand.
            var code = code_example;  // string | The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional) 
            var propertyFilter = new List<string>(); // List<string> | The restricted list of property keys from the \"Portfolio\" domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \"Portfolio/Manager/Id\". (optional) 

            try
            {
                // [EARLY ACCESS] GetPortfolioGroupExpansion: Get portfolio group expansion
                ExpandedGroup result = apiInstance.GetPortfolioGroupExpansion(scope, code, effectiveAt, asAt, propertyFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. | [optional] 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliogroupmetadata"></a>
# **GetPortfolioGroupMetadata**
> Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt; GetPortfolioGroupMetadata (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetPortfolioGroupMetadata: Get Access Metadata rules for Portfolio Group

Pass the scope and Portfolio Group code parameters to retrieve the associated Access Metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioGroupMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the Portfolio Group
            var code = code_example;  // string | The Portfolio Group code
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effectiveAt datetime at which to retrieve the Access Metadata (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] GetPortfolioGroupMetadata: Get Access Metadata rules for Portfolio Group
                Dictionary<string, List<AccessMetadataValue>> result = apiInstance.GetPortfolioGroupMetadata(scope, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.GetPortfolioGroupMetadata: " + e.Message );
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
 **scope** | **string**| The scope of the Portfolio Group | 
 **code** | **string**| The Portfolio Group code | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effectiveAt datetime at which to retrieve the Access Metadata | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the Access Metadata | [optional] 

### Return type

**Dictionary<string, List<AccessMetadataValue>>**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The access metadata for the portfolio group or any failure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliogrouppropertytimeseries"></a>
# **GetPortfolioGroupPropertyTimeSeries**
> ResourceListOfPropertyInterval GetPortfolioGroupPropertyTimeSeries (string scope, string code, string propertyKey, string portfolioGroupEffectiveAt = null, DateTimeOffset? asAt = null, string filter = null, string page = null, int? limit = null)

[EARLY ACCESS] GetPortfolioGroupPropertyTimeSeries: Get the time series of a portfolio group property

List the complete time series of a portfolio group property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioGroupPropertyTimeSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the group.
            var code = code_example;  // string | The code of the group. Together with the scope this uniquely identifies              the portfolio group.
            var propertyKey = propertyKey_example;  // string | The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \"PortfolioGroup/Manager/Id\".              Each property must be from the \"PortfolioGroup\" domain.
            var portfolioGroupEffectiveAt = portfolioGroupEffectiveAt_example;  // string | The effective datetime used to resolve the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the portfolio group's property history. Defaults to return the current datetime if not supplied. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 

            try
            {
                // [EARLY ACCESS] GetPortfolioGroupPropertyTimeSeries: Get the time series of a portfolio group property
                ResourceListOfPropertyInterval result = apiInstance.GetPortfolioGroupPropertyTimeSeries(scope, code, propertyKey, portfolioGroupEffectiveAt, asAt, filter, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.GetPortfolioGroupPropertyTimeSeries: " + e.Message );
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
 **scope** | **string**| The scope of the group. | 
 **code** | **string**| The code of the group. Together with the scope this uniquely identifies              the portfolio group. | 
 **propertyKey** | **string**| The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;.              Each property must be from the \&quot;PortfolioGroup\&quot; domain. | 
 **portfolioGroupEffectiveAt** | **string**| The effective datetime used to resolve the portfolio group. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the portfolio group&#39;s property history. Defaults to return the current datetime if not supplied. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **page** | **string**| The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, and asAt fields              must not have changed since the original request. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. | [optional] 

### Return type

[**ResourceListOfPropertyInterval**](ResourceListOfPropertyInterval.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The time series of the property |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliogrouprelationships"></a>
# **GetPortfolioGroupRelationships**
> ResourceListOfRelationship GetPortfolioGroupRelationships (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> identifierTypes = null)

[EARLY ACCESS] GetPortfolioGroupRelationships: Get Relationships for Portfolio Group

Get relationships for the specified Portfolio Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioGroupRelationshipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the portfolio group.
            var code = code_example;  // string | The code of the portfolio group. Together with the scope this uniquely identifies              the portfolio group.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve relationship. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional) 
            var identifierTypes = new List<string>(); // List<string> | Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the 'Person' or 'LegalEntity' domains and have the format {domain}/{scope}/{code}, for example              'Person/CompanyDetails/Role'. An Empty array may be used to return all related Entities. (optional) 

            try
            {
                // [EARLY ACCESS] GetPortfolioGroupRelationships: Get Relationships for Portfolio Group
                ResourceListOfRelationship result = apiInstance.GetPortfolioGroupRelationships(scope, code, effectiveAt, asAt, filter, identifierTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.GetPortfolioGroupRelationships: " + e.Message );
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
 **scope** | **string**| The scope of the portfolio group. | 
 **code** | **string**| The code of the portfolio group. Together with the scope this uniquely identifies              the portfolio group. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve relationship. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. | [optional] 
 **filter** | **string**| Expression to filter relationships. Users should provide null or empty string for this field until further notice. | [optional] 
 **identifierTypes** | [**List&lt;string&gt;**](string.md)| Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. | [optional] 

### Return type

[**ResourceListOfRelationship**](ResourceListOfRelationship.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The relationships for the specific portfolio group. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionsforportfoliogroup"></a>
# **GetTransactionsForPortfolioGroup**
> VersionedResourceListOfTransaction GetTransactionsForPortfolioGroup (string scope, string code, DateTimeOrCutLabel fromTransactionDate = null, DateTimeOrCutLabel toTransactionDate = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, int? limit = null, string page = null, bool? showCancelledTransactions = null)

GetTransactionsForPortfolioGroup: Get transactions for transaction portfolios in a portfolio group

Get transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetTransactionsForPortfolioGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the portfolio group.
            var code = code_example;  // string | The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.
            var fromTransactionDate = fromTransactionDate_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the transactions.               There is no lower bound if this is not specified. (optional) 
            var toTransactionDate = toTransactionDate_example;  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the transactions. Defaults to return the latest version               of each transaction if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.               For example, to filter on the Transaction Type, use \"type eq 'Buy'\"               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\", \"Transaction\", \"LegalEntity\" or \"CustodianAccount\" domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\" or               \"Transaction/strategy/quantsignal\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional) 
            var showCancelledTransactions = true;  // bool? | Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional) 

            try
            {
                // GetTransactionsForPortfolioGroup: Get transactions for transaction portfolios in a portfolio group
                VersionedResourceListOfTransaction result = apiInstance.GetTransactionsForPortfolioGroup(scope, code, fromTransactionDate, toTransactionDate, asAt, filter, propertyKeys, limit, page, showCancelledTransactions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.GetTransactionsForPortfolioGroup: " + e.Message );
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
 **scope** | **string**| The scope of the portfolio group. | 
 **code** | **string**| The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group. | 
 **fromTransactionDate** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve the transactions.               There is no lower bound if this is not specified. | [optional] 
 **toTransactionDate** | **DateTimeOrCutLabel**| The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the transactions. Defaults to return the latest version               of each transaction if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot;, \&quot;Transaction\&quot;, \&quot;LegalEntity\&quot; or \&quot;CustodianAccount\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing transactions from a previous call to GetTransactions. | [optional] 
 **showCancelledTransactions** | **bool?**| Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. | [optional] 

### Return type

[**VersionedResourceListOfTransaction**](VersionedResourceListOfTransaction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested transactions from transaction portfolios in the specified portfolio group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listportfoliogroups"></a>
# **ListPortfolioGroups**
> ResourceListOfPortfolioGroup ListPortfolioGroups (string scope, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> relatedEntityPropertyKeys = null, List<string> relationshipDefinitionIds = null)

[EARLY ACCESS] ListPortfolioGroups: List portfolio groups

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
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope to list the portfolio groups in.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.              For example, to filter on the Display Name, use \"displayName eq 'string'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var relatedEntityPropertyKeys = new List<string>(); // List<string> | A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example 'Portfolio/Manager/Id'. (optional) 
            var relationshipDefinitionIds = new List<string>(); // List<string> | A list of relationship definitions that are used to decorate related entities              onto the portfolio groups in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // [EARLY ACCESS] ListPortfolioGroups: List portfolio groups
                ResourceListOfPortfolioGroup result = apiInstance.ListPortfolioGroups(scope, effectiveAt, asAt, filter, relatedEntityPropertyKeys, relationshipDefinitionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **relatedEntityPropertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. | [optional] 
 **relationshipDefinitionIds** | [**List&lt;string&gt;**](string.md)| A list of relationship definitions that are used to decorate related entities              onto the portfolio groups in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchportfoliogroupaccessmetadata"></a>
# **PatchPortfolioGroupAccessMetadata**
> Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt; PatchPortfolioGroupAccessMetadata (string scope, string code, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] PatchPortfolioGroupAccessMetadata: Patch Access Metadata rules for a Portfolio Group.

Patch Portfolio Group Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only 'add' is a supported operation on the patch document.    Currently only valid metadata keys are supported paths on the patch document.                The response will return any affected Portfolio Group Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class PatchPortfolioGroupAccessMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the Portfolio Group
            var code = code_example;  // string | The Portfolio Group code
            var accessMetadataOperation = new List<AccessMetadataOperation>(); // List<AccessMetadataOperation> | The Json patch document
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The date this rule will be effective from (optional) 
            var effectiveUntil = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' date of the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] PatchPortfolioGroupAccessMetadata: Patch Access Metadata rules for a Portfolio Group.
                Dictionary<string, List<AccessMetadataValue>> result = apiInstance.PatchPortfolioGroupAccessMetadata(scope, code, accessMetadataOperation, effectiveAt, effectiveUntil);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.PatchPortfolioGroupAccessMetadata: " + e.Message );
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
 **scope** | **string**| The scope of the Portfolio Group | 
 **code** | **string**| The Portfolio Group code | 
 **accessMetadataOperation** | [**List&lt;AccessMetadataOperation&gt;**](AccessMetadataOperation.md)| The Json patch document | 
 **effectiveAt** | **DateTimeOrCutLabel**| The date this rule will be effective from | [optional] 
 **effectiveUntil** | **DateTimeOffset?**| The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata | [optional] 

### Return type

**Dictionary<string, List<AccessMetadataValue>>**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully patched items. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateportfoliogroup"></a>
# **UpdatePortfolioGroup**
> PortfolioGroup UpdatePortfolioGroup (string scope, string code, DateTimeOrCutLabel effectiveAt = null, UpdatePortfolioGroupRequest updatePortfolioGroupRequest = null)

[EARLY ACCESS] UpdatePortfolioGroup: Update portfolio group

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
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the portfolio group to update the definition for.
            var code = code_example;  // string | The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to update the definition. (optional) 
            var updatePortfolioGroupRequest = new UpdatePortfolioGroupRequest(); // UpdatePortfolioGroupRequest | The updated portfolio group definition. (optional) 

            try
            {
                // [EARLY ACCESS] UpdatePortfolioGroup: Update portfolio group
                PortfolioGroup result = apiInstance.UpdatePortfolioGroup(scope, code, effectiveAt, updatePortfolioGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to update the definition. | [optional] 
 **updatePortfolioGroupRequest** | [**UpdatePortfolioGroupRequest**](UpdatePortfolioGroupRequest.md)| The updated portfolio group definition. | [optional] 

### Return type

[**PortfolioGroup**](PortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated definition of the portfolio group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertgroupproperties"></a>
# **UpsertGroupProperties**
> PortfolioGroupProperties UpsertGroupProperties (string scope, string code, Dictionary<string, Property> requestBody = null)

[EARLY ACCESS] UpsertGroupProperties: Upsert group properties

Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain 'PortfolioGroup'.                Upserting a property that exists for a group, with a null value, will delete the instance of the property for that group.                Properties have an <i>effectiveFrom</i> datetime for which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertGroupPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the group to update or insert the properties onto.
            var code = code_example;  // string | The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.
            var requestBody = new Dictionary<string, Property>(); // Dictionary<string, Property> | The properties to be updated or inserted onto the group. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \"PortfolioGroup/Manager/Id\". (optional) 

            try
            {
                // [EARLY ACCESS] UpsertGroupProperties: Upsert group properties
                PortfolioGroupProperties result = apiInstance.UpsertGroupProperties(scope, code, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.UpsertGroupProperties: " + e.Message );
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
 **scope** | **string**| The scope of the group to update or insert the properties onto. | 
 **code** | **string**| The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group. | 
 **requestBody** | [**Dictionary&lt;string, Property&gt;**](Property.md)| The properties to be updated or inserted onto the group. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. | [optional] 

### Return type

[**PortfolioGroupProperties**](PortfolioGroupProperties.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated or inserted properties |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertportfoliogroupaccessmetadata"></a>
# **UpsertPortfolioGroupAccessMetadata**
> ResourceListOfAccessMetadataValueOf UpsertPortfolioGroupAccessMetadata (string scope, string code, string metadataKey, UpsertPortfolioGroupAccessMetadataRequest upsertPortfolioGroupAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] UpsertPortfolioGroupAccessMetadata: Upsert a Portfolio Group Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.

Update or insert one Portfolio Group Access Metadata Entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Portfolio Group Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertPortfolioGroupAccessMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioGroupsApi(config);
            var scope = scope_example;  // string | The scope of the Portfolio Group
            var code = code_example;  // string | The Portfolio Group code
            var metadataKey = metadataKey_example;  // string | Key of the access metadata entry to upsert
            var upsertPortfolioGroupAccessMetadataRequest = new UpsertPortfolioGroupAccessMetadataRequest(); // UpsertPortfolioGroupAccessMetadataRequest | The Portfolio Group Access Metadata rule to upsert
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The date this rule will be effective from (optional) 
            var effectiveUntil = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' date of the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] UpsertPortfolioGroupAccessMetadata: Upsert a Portfolio Group Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
                ResourceListOfAccessMetadataValueOf result = apiInstance.UpsertPortfolioGroupAccessMetadata(scope, code, metadataKey, upsertPortfolioGroupAccessMetadataRequest, effectiveAt, effectiveUntil);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfolioGroupsApi.UpsertPortfolioGroupAccessMetadata: " + e.Message );
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
 **scope** | **string**| The scope of the Portfolio Group | 
 **code** | **string**| The Portfolio Group code | 
 **metadataKey** | **string**| Key of the access metadata entry to upsert | 
 **upsertPortfolioGroupAccessMetadataRequest** | [**UpsertPortfolioGroupAccessMetadataRequest**](UpsertPortfolioGroupAccessMetadataRequest.md)| The Portfolio Group Access Metadata rule to upsert | 
 **effectiveAt** | **DateTimeOrCutLabel**| The date this rule will be effective from | [optional] 
 **effectiveUntil** | **DateTimeOffset?**| The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata | [optional] 

### Return type

[**ResourceListOfAccessMetadataValueOf**](ResourceListOfAccessMetadataValueOf.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted item or any failure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

