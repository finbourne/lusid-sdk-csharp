# Lusid.Sdk.Api.FundGroupsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetFundGroupTrialBalance**](FundGroupsApi.md#getfundgrouptrialbalance) | **POST** /api/fundgroups/{scope}/{code}/trialbalance/$query | [EARLY ACCESS] GetFundGroupTrialBalance: Get the Trial Balance for a group of Funds. |

<a id="getfundgrouptrialbalance"></a>
# **GetFundGroupTrialBalance**
> FundGroupTrialBalanceResponse GetFundGroupTrialBalance (string scope, string code, FundGroupTrialBalanceRequest fundGroupTrialBalanceRequest, DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null, List<string>? propertyKeys = null)

[EARLY ACCESS] GetFundGroupTrialBalance: Get the Trial Balance for a group of Funds.

Runs the Trial Balance once for every Fund in a fund group, where the group is a reference list of type  FundIdList or FilteredFundIdList identified by the scope and code. LUSID chooses the Valuation Point for  each Fund and NAV type from the run type, and each returned row carries the Fund, NAV type and Valuation Point  it came from. A Fund that could not be reported, because no Valuation Point matches the run type or the NAV type  is missing, is listed in fundResults alongside the rows. A Fund in a FundIdList that the caller is not entitled  to read is listed there too; a FilteredFundIdList only ever contains the Funds the caller can read.                Rows are ordered by Fund scope, then Fund code, then NAV type code, then as GetValuationPointTrialBalance orders  them, so the order is stable across pages.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundGroupsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundGroupsApi>();
            var scope = "scope_example";  // string | The scope of the reference list that defines the fund group.
            var code = "code_example";  // string | The code of the reference list that defines the fund group. Together with the scope this uniquely identifies the reference list.
            var fundGroupTrialBalanceRequest = new FundGroupTrialBalanceRequest(); // FundGroupTrialBalanceRequest | The run type, dates, NAV type and Trial Balance options.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Trial Balances and resolve the fund group.               Defaults to returning the latest version if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the rows by, using the same fields as GetValuationPointTrialBalance.               For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned rows to this number.               Defaults to 100 if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing rows.               This token is returned from the previous call.               If a pagination token is provided, the filter, request body and asAt fields               must not have changed since the original request. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Instrument', 'Transaction', 'Portfolio', 'Account', 'LegalEntity' or 'CustodianAccount'               domain to decorate onto each row's TrialBalance. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // FundGroupTrialBalanceResponse result = apiInstance.GetFundGroupTrialBalance(scope, code, fundGroupTrialBalanceRequest, asAt, filter, limit, page, propertyKeys, opts: opts);

                // [EARLY ACCESS] GetFundGroupTrialBalance: Get the Trial Balance for a group of Funds.
                FundGroupTrialBalanceResponse result = apiInstance.GetFundGroupTrialBalance(scope, code, fundGroupTrialBalanceRequest, asAt, filter, limit, page, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundGroupsApi.GetFundGroupTrialBalance: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```
#### Using the GetFundGroupTrialBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetFundGroupTrialBalance: Get the Trial Balance for a group of Funds.
    ApiResponse<FundGroupTrialBalanceResponse> response = apiInstance.GetFundGroupTrialBalanceWithHttpInfo(scope, code, fundGroupTrialBalanceRequest, asAt, filter, limit, page, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundGroupsApi.GetFundGroupTrialBalanceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the reference list that defines the fund group. |  |
| **code** | **string** | The code of the reference list that defines the fund group. Together with the scope this uniquely identifies the reference list. |  |
| **fundGroupTrialBalanceRequest** | [**FundGroupTrialBalanceRequest**](FundGroupTrialBalanceRequest.md) | The run type, dates, NAV type and Trial Balance options. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Trial Balances and resolve the fund group.               Defaults to returning the latest version if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the rows by, using the same fields as GetValuationPointTrialBalance.               For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned rows to this number.               Defaults to 100 if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing rows.               This token is returned from the previous call.               If a pagination token is provided, the filter, request body and asAt fields               must not have changed since the original request. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, &#39;Portfolio&#39;, &#39;Account&#39;, &#39;LegalEntity&#39; or &#39;CustodianAccount&#39;               domain to decorate onto each row&#39;s TrialBalance. | [optional]  |

### Return type

[**FundGroupTrialBalanceResponse**](FundGroupTrialBalanceResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Trial Balance rows of the Funds in the group, with the outcome for each Fund and NAV type. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

