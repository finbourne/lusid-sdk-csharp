# Lusid.Sdk.Api.TaxClassificationsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTaxClassification**](TaxClassificationsApi.md#gettaxclassification) | **GET** /api/tax/classifications/{scope}/{luid} | [EARLY ACCESS] GetTaxClassification: Get a tax classification. |
| [**GetTaxQualifyingInvestmentsHistory**](TaxClassificationsApi.md#gettaxqualifyinginvestmentshistory) | **GET** /api/tax/classifications/{scope}/{luid}/qualifyinginvestments | [EARLY ACCESS] GetTaxQualifyingInvestmentsHistory: Get the qualifying investments history of an instrument. |
| [**ListTaxClassificationExceptions**](TaxClassificationsApi.md#listtaxclassificationexceptions) | **GET** /api/tax/classifications/exceptions | [EARLY ACCESS] ListTaxClassificationExceptions: List tax classification exceptions. |
| [**ListTaxClassifications**](TaxClassificationsApi.md#listtaxclassifications) | **GET** /api/tax/classifications | [EARLY ACCESS] ListTaxClassifications: List tax classifications. |
| [**RemoveTaxTreatmentOverride**](TaxClassificationsApi.md#removetaxtreatmentoverride) | **DELETE** /api/tax/classifications/{scope}/{luid}/override | [EARLY ACCESS] RemoveTaxTreatmentOverride: Remove a tax treatment override. |
| [**UpsertTaxTreatmentOverride**](TaxClassificationsApi.md#upserttaxtreatmentoverride) | **POST** /api/tax/classifications/{scope}/{luid}/override | [EARLY ACCESS] UpsertTaxTreatmentOverride: Upsert a tax treatment override. |

<a id="gettaxclassification"></a>
# **GetTaxClassification**
> TaxClassificationDetail GetTaxClassification (string scope, string luid, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetTaxClassification: Get a tax classification.

Gets one instrument's tax classification together with the ordered decision trace that produced it and the  bitemporal history of every input and override field behind it.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaxClassificationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaxClassificationsApi>();
            var scope = "scope_example";  // string | The scope of the instrument.
            var luid = "luid_example";  // string | The LUSID instrument identifier of the instrument.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | Optional. The effective datetime or cut label at which to classify. Defaults to the current time. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The as-at datetime at which to read the classification inputs. Defaults to the latest. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // TaxClassificationDetail result = apiInstance.GetTaxClassification(scope, luid, effectiveAt, asAt, opts: opts);

                // [EARLY ACCESS] GetTaxClassification: Get a tax classification.
                TaxClassificationDetail result = apiInstance.GetTaxClassification(scope, luid, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaxClassificationsApi.GetTaxClassification: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaxClassificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetTaxClassification: Get a tax classification.
    ApiResponse<TaxClassificationDetail> response = apiInstance.GetTaxClassificationWithHttpInfo(scope, luid, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaxClassificationsApi.GetTaxClassificationWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the instrument. |  |
| **luid** | **string** | The LUSID instrument identifier of the instrument. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | Optional. The effective datetime or cut label at which to classify. Defaults to the current time. | [optional]  |
| **asAt** | **DateTimeOffset?** | Optional. The as-at datetime at which to read the classification inputs. Defaults to the latest. | [optional]  |

### Return type

[**TaxClassificationDetail**](TaxClassificationDetail.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The tax classification of the instrument with its decision trace and field history. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="gettaxqualifyinginvestmentshistory"></a>
# **GetTaxQualifyingInvestmentsHistory**
> QualifyingInvestmentsHistory GetTaxQualifyingInvestmentsHistory (string scope, string luid, DateTimeOffset? fromDate = null, DateTimeOffset? toDate = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetTaxQualifyingInvestmentsHistory: Get the qualifying investments history of an instrument.

Returns the daily qualifying investments (60 percent non-equity) test observations of a collective investment  scheme over the requested window, together with every crossing: a pair of consecutive observations on which  the test result flipped.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaxClassificationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaxClassificationsApi>();
            var scope = "scope_example";  // string | The scope of the instrument.
            var luid = "luid_example";  // string | The LUSID instrument identifier of the scheme.
            var fromDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The first date of the window, inclusive. Defaults to one year before the toDate. The window may span at most ten years. (optional) 
            var toDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The last date of the window, inclusive. Defaults to the asAt date. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The as-at datetime at which to read the observations. Defaults to the latest. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // QualifyingInvestmentsHistory result = apiInstance.GetTaxQualifyingInvestmentsHistory(scope, luid, fromDate, toDate, asAt, opts: opts);

                // [EARLY ACCESS] GetTaxQualifyingInvestmentsHistory: Get the qualifying investments history of an instrument.
                QualifyingInvestmentsHistory result = apiInstance.GetTaxQualifyingInvestmentsHistory(scope, luid, fromDate, toDate, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaxClassificationsApi.GetTaxQualifyingInvestmentsHistory: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaxQualifyingInvestmentsHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetTaxQualifyingInvestmentsHistory: Get the qualifying investments history of an instrument.
    ApiResponse<QualifyingInvestmentsHistory> response = apiInstance.GetTaxQualifyingInvestmentsHistoryWithHttpInfo(scope, luid, fromDate, toDate, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaxClassificationsApi.GetTaxQualifyingInvestmentsHistoryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the instrument. |  |
| **luid** | **string** | The LUSID instrument identifier of the scheme. |  |
| **fromDate** | **DateTimeOffset?** | Optional. The first date of the window, inclusive. Defaults to one year before the toDate. The window may span at most ten years. | [optional]  |
| **toDate** | **DateTimeOffset?** | Optional. The last date of the window, inclusive. Defaults to the asAt date. | [optional]  |
| **asAt** | **DateTimeOffset?** | Optional. The as-at datetime at which to read the observations. Defaults to the latest. | [optional]  |

### Return type

[**QualifyingInvestmentsHistory**](QualifyingInvestmentsHistory.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The qualifying investments observations and crossings of the instrument. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listtaxclassificationexceptions"></a>
# **ListTaxClassificationExceptions**
> ResourceListOfTaxClassificationExceptionRecord ListTaxClassificationExceptions (string scope, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] ListTaxClassificationExceptions: List tax classification exceptions.

Lists every instrument in the scope that could not be classified at the given time, with the kind of  exception (missing inputs, conflicting set-up, conflicting override, qualifying investments crossing) and a  message naming the fields involved.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaxClassificationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaxClassificationsApi>();
            var scope = "scope_example";  // string | The scope of the instruments.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | Optional. The effective datetime or cut label at which to classify. Defaults to the current time. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The as-at datetime at which to read the classification inputs. Defaults to the latest. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfTaxClassificationExceptionRecord result = apiInstance.ListTaxClassificationExceptions(scope, effectiveAt, asAt, opts: opts);

                // [EARLY ACCESS] ListTaxClassificationExceptions: List tax classification exceptions.
                ResourceListOfTaxClassificationExceptionRecord result = apiInstance.ListTaxClassificationExceptions(scope, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaxClassificationsApi.ListTaxClassificationExceptions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTaxClassificationExceptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListTaxClassificationExceptions: List tax classification exceptions.
    ApiResponse<ResourceListOfTaxClassificationExceptionRecord> response = apiInstance.ListTaxClassificationExceptionsWithHttpInfo(scope, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaxClassificationsApi.ListTaxClassificationExceptionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the instruments. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | Optional. The effective datetime or cut label at which to classify. Defaults to the current time. | [optional]  |
| **asAt** | **DateTimeOffset?** | Optional. The as-at datetime at which to read the classification inputs. Defaults to the latest. | [optional]  |

### Return type

[**ResourceListOfTaxClassificationExceptionRecord**](ResourceListOfTaxClassificationExceptionRecord.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The instruments that could not be classified and the reason for each. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listtaxclassifications"></a>
# **ListTaxClassifications**
> ResourceListOfTaxClassification ListTaxClassifications (string scope, string? treatment = null, string? status = null, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] ListTaxClassifications: List tax classifications.

Lists the tax classification of every instrument in the scope at the given effective and as-at time. Each  entry carries the treatment leaf the instrument resolved to, the treatment it implies, whether it was  system-derived or overridden, and the rule that fired. Narrow the list with the treatment and status filters.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaxClassificationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaxClassificationsApi>();
            var scope = "scope_example";  // string | The scope of the instruments to classify.
            var treatment = "treatment_example";  // string? | Optional. Only return instruments with this treatment. Available values: ChargeableGains, LoanRelationship, Excluded, Unclassified. (optional) 
            var status = "status_example";  // string? | Optional. Only return instruments with this classification status. Available values: Classified, Overridden, Rejected, Unclassified. (optional) 
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | Optional. The effective datetime or cut label at which to classify. Defaults to the current time. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The as-at datetime at which to read the classification inputs. Defaults to the latest. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfTaxClassification result = apiInstance.ListTaxClassifications(scope, treatment, status, effectiveAt, asAt, opts: opts);

                // [EARLY ACCESS] ListTaxClassifications: List tax classifications.
                ResourceListOfTaxClassification result = apiInstance.ListTaxClassifications(scope, treatment, status, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaxClassificationsApi.ListTaxClassifications: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTaxClassificationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListTaxClassifications: List tax classifications.
    ApiResponse<ResourceListOfTaxClassification> response = apiInstance.ListTaxClassificationsWithHttpInfo(scope, treatment, status, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaxClassificationsApi.ListTaxClassificationsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the instruments to classify. |  |
| **treatment** | **string?** | Optional. Only return instruments with this treatment. Available values: ChargeableGains, LoanRelationship, Excluded, Unclassified. | [optional]  |
| **status** | **string?** | Optional. Only return instruments with this classification status. Available values: Classified, Overridden, Rejected, Unclassified. | [optional]  |
| **effectiveAt** | **DateTimeOrCutLabel?** | Optional. The effective datetime or cut label at which to classify. Defaults to the current time. | [optional]  |
| **asAt** | **DateTimeOffset?** | Optional. The as-at datetime at which to read the classification inputs. Defaults to the latest. | [optional]  |

### Return type

[**ResourceListOfTaxClassification**](ResourceListOfTaxClassification.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The tax classifications of the instruments in the scope. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="removetaxtreatmentoverride"></a>
# **RemoveTaxTreatmentOverride**
> DeletedEntityResponse RemoveTaxTreatmentOverride (string scope, string luid, DateTimeOffset? effectiveAt = null)

[EARLY ACCESS] RemoveTaxTreatmentOverride: Remove a tax treatment override.

Removes the user override from the given effective date onward, returning the instrument to its  system-derived treatment leaf from that date.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaxClassificationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaxClassificationsApi>();
            var scope = "scope_example";  // string | The scope of the instrument.
            var luid = "luid_example";  // string | The LUSID instrument identifier of the instrument.
            var effectiveAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The effective datetime from which the override no longer applies. Defaults to the current time. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.RemoveTaxTreatmentOverride(scope, luid, effectiveAt, opts: opts);

                // [EARLY ACCESS] RemoveTaxTreatmentOverride: Remove a tax treatment override.
                DeletedEntityResponse result = apiInstance.RemoveTaxTreatmentOverride(scope, luid, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaxClassificationsApi.RemoveTaxTreatmentOverride: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveTaxTreatmentOverrideWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] RemoveTaxTreatmentOverride: Remove a tax treatment override.
    ApiResponse<DeletedEntityResponse> response = apiInstance.RemoveTaxTreatmentOverrideWithHttpInfo(scope, luid, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaxClassificationsApi.RemoveTaxTreatmentOverrideWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the instrument. |  |
| **luid** | **string** | The LUSID instrument identifier of the instrument. |  |
| **effectiveAt** | **DateTimeOffset?** | Optional. The effective datetime from which the override no longer applies. Defaults to the current time. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime from which the override was removed. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upserttaxtreatmentoverride"></a>
# **UpsertTaxTreatmentOverride**
> TaxClassification UpsertTaxTreatmentOverride (string scope, string luid, UpsertTaxTreatmentOverrideRequest upsertTaxTreatmentOverrideRequest)

[EARLY ACCESS] UpsertTaxTreatmentOverride: Upsert a tax treatment override.

Replaces the system-derived treatment leaf of the instrument with the given one from the request's effective  date onward. The response is the classification as it now stands at that effective date.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaxClassificationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaxClassificationsApi>();
            var scope = "scope_example";  // string | The scope of the instrument.
            var luid = "luid_example";  // string | The LUSID instrument identifier of the instrument.
            var upsertTaxTreatmentOverrideRequest = new UpsertTaxTreatmentOverrideRequest(); // UpsertTaxTreatmentOverrideRequest | The treatment leaf to apply and the effective date it applies from.

            try
            {
                // uncomment the below to set overrides at the request level
                // TaxClassification result = apiInstance.UpsertTaxTreatmentOverride(scope, luid, upsertTaxTreatmentOverrideRequest, opts: opts);

                // [EARLY ACCESS] UpsertTaxTreatmentOverride: Upsert a tax treatment override.
                TaxClassification result = apiInstance.UpsertTaxTreatmentOverride(scope, luid, upsertTaxTreatmentOverrideRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaxClassificationsApi.UpsertTaxTreatmentOverride: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertTaxTreatmentOverrideWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertTaxTreatmentOverride: Upsert a tax treatment override.
    ApiResponse<TaxClassification> response = apiInstance.UpsertTaxTreatmentOverrideWithHttpInfo(scope, luid, upsertTaxTreatmentOverrideRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaxClassificationsApi.UpsertTaxTreatmentOverrideWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the instrument. |  |
| **luid** | **string** | The LUSID instrument identifier of the instrument. |  |
| **upsertTaxTreatmentOverrideRequest** | [**UpsertTaxTreatmentOverrideRequest**](UpsertTaxTreatmentOverrideRequest.md) | The treatment leaf to apply and the effective date it applies from. |  |

### Return type

[**TaxClassification**](TaxClassification.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The classification of the instrument after the override was applied. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

