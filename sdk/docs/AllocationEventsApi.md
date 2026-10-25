# Lusid.Sdk.Api.AllocationEventsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BookAllocationEvent**](AllocationEventsApi.md#bookallocationevent) | **POST** /api/allocationevents/{scope}/{code}/book | [EXPERIMENTAL] BookAllocationEvent: Book an Allocation Event. |
| [**CreateAllocationEvent**](AllocationEventsApi.md#createallocationevent) | **POST** /api/allocationevents/{scope} | [EXPERIMENTAL] CreateAllocationEvent: Create an Allocation Event. |
| [**DeleteAllocationEvent**](AllocationEventsApi.md#deleteallocationevent) | **DELETE** /api/allocationevents/{scope}/{code} | [EXPERIMENTAL] DeleteAllocationEvent: Delete an Allocation Event. |
| [**GetAllocationEvent**](AllocationEventsApi.md#getallocationevent) | **GET** /api/allocationevents/{scope}/{code} | [EXPERIMENTAL] GetAllocationEvent: Get an Allocation Event. |
| [**GetAllocationEventNotices**](AllocationEventsApi.md#getallocationeventnotices) | **GET** /api/allocationevents/{scope}/{code}/notices | [EARLY ACCESS] GetAllocationEventNotices: [EARLY ACCESS] GetAllocationEventNotices: Get the notices an allocation event issues to its partners. |
| [**GetAllocationEventReceivables**](AllocationEventsApi.md#getallocationeventreceivables) | **GET** /api/allocationevents/{scope}/{code}/receivables | [EXPERIMENTAL] GetAllocationEventReceivables: Get the receivables of an Allocation Event. |
| [**ListAllocationEvents**](AllocationEventsApi.md#listallocationevents) | **GET** /api/allocationevents | [EXPERIMENTAL] ListAllocationEvents: List Allocation Events. |
| [**ListAllocationPaymentHolds**](AllocationEventsApi.md#listallocationpaymentholds) | **GET** /api/allocationevents/{scope}/{code}/allocations/{investorRecordId}/holds | [EARLY ACCESS] ListAllocationPaymentHolds: [EARLY ACCESS] ListAllocationPaymentHolds: List the holds placed on a partner&#39;s payment. |
| [**PlanAllocationEventBooking**](AllocationEventsApi.md#planallocationeventbooking) | **POST** /api/allocationevents/{scope}/{code}/plan | [EXPERIMENTAL] PlanAllocationEventBooking: Plan the booking of an Allocation Event. |
| [**PutAllocationPaymentHold**](AllocationEventsApi.md#putallocationpaymenthold) | **PUT** /api/allocationevents/{scope}/{code}/allocations/{investorRecordId}/hold | [EARLY ACCESS] PutAllocationPaymentHold: [EARLY ACCESS] PutAllocationPaymentHold: Place, move or release a hold on a partner&#39;s payment. |
| [**ReallocateAllocationEvent**](AllocationEventsApi.md#reallocateallocationevent) | **POST** /api/allocationevents/{scope}/{code}/reallocate | [EXPERIMENTAL] ReallocateAllocationEvent: Reallocate an Allocation Event. |
| [**ReceiveAllocationEvent**](AllocationEventsApi.md#receiveallocationevent) | **POST** /api/allocationevents/{scope}/{code}/receipts | [EXPERIMENTAL] ReceiveAllocationEvent: Record a receipt against an Allocation Event. |
| [**ReverseAllocationEvent**](AllocationEventsApi.md#reverseallocationevent) | **POST** /api/allocationevents/{scope}/{code}/reverse | [EXPERIMENTAL] ReverseAllocationEvent: Reverse an Allocation Event. |
| [**UnbookAllocationEvent**](AllocationEventsApi.md#unbookallocationevent) | **POST** /api/allocationevents/{scope}/{code}/unbook | [EXPERIMENTAL] UnbookAllocationEvent: Unbook an Allocation Event. |
| [**UpsertAllocationEvent**](AllocationEventsApi.md#upsertallocationevent) | **PUT** /api/allocationevents/{scope}/{code} | [EXPERIMENTAL] UpsertAllocationEvent: Upsert an Allocation Event. |

<a id="bookallocationevent"></a>
# **BookAllocationEvent**
> AllocationEvent BookAllocationEvent (string scope, string code, AllocationEventBookRequest allocationEventBookRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] BookAllocationEvent: Book an Allocation Event.

Freeze a computed Allocation Event under a booking reference, from an effective datetime. Once booked the  event can no longer be replaced or reallocated. Booking again under the same reference returns the event  unchanged; booking under a different reference is refused.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var allocationEventBookRequest = new AllocationEventBookRequest(); // AllocationEventBookRequest | The booking reference to freeze the event under.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to read the Allocation Event to book. The booking is recorded on the version in force at that time, from that version's own effective date. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationEvent result = apiInstance.BookAllocationEvent(scope, code, allocationEventBookRequest, effectiveAt, opts: opts);

                // [EXPERIMENTAL] BookAllocationEvent: Book an Allocation Event.
                AllocationEvent result = apiInstance.BookAllocationEvent(scope, code, allocationEventBookRequest, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.BookAllocationEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the BookAllocationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] BookAllocationEvent: Book an Allocation Event.
    ApiResponse<AllocationEvent> response = apiInstance.BookAllocationEventWithHttpInfo(scope, code, allocationEventBookRequest, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.BookAllocationEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **allocationEventBookRequest** | [**AllocationEventBookRequest**](AllocationEventBookRequest.md) | The booking reference to freeze the event under. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to read the Allocation Event to book. The booking is recorded on the version in force at that time, from that version&#39;s own effective date. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**AllocationEvent**](AllocationEvent.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The booked Allocation Event. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createallocationevent"></a>
# **CreateAllocationEvent**
> AllocationEvent CreateAllocationEvent (string scope, AllocationEventRequest allocationEventRequest)

[EXPERIMENTAL] CreateAllocationEvent: Create an Allocation Event.

Raise a new Allocation Event. The scope is provided in the route and the code in the request body. The event  names the Allocation Map it is shared by, the kind of event, the amount and the date. Its per-investor shares  are computed on creation from the map as it stood on the event date, so the response comes back Computed.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var allocationEventRequest = new AllocationEventRequest(); // AllocationEventRequest | The definition of the Allocation Event.

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationEvent result = apiInstance.CreateAllocationEvent(scope, allocationEventRequest, opts: opts);

                // [EXPERIMENTAL] CreateAllocationEvent: Create an Allocation Event.
                AllocationEvent result = apiInstance.CreateAllocationEvent(scope, allocationEventRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.CreateAllocationEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAllocationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateAllocationEvent: Create an Allocation Event.
    ApiResponse<AllocationEvent> response = apiInstance.CreateAllocationEventWithHttpInfo(scope, allocationEventRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.CreateAllocationEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **allocationEventRequest** | [**AllocationEventRequest**](AllocationEventRequest.md) | The definition of the Allocation Event. |  |

### Return type

[**AllocationEvent**](AllocationEvent.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Allocation Event. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteallocationevent"></a>
# **DeleteAllocationEvent**
> DeletedEntityResponse DeleteAllocationEvent (string scope, string code, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] DeleteAllocationEvent: Delete an Allocation Event.

Delete an Allocation Event. Given an effective datetime, the Allocation Event is deleted from that datetime  and remains retrievable at earlier effective datetimes. Given none, an Allocation Event that was created  without an effective datetime is removed from the beginning of time, so that its code can be reused;  this includes an event first created without an effective datetime and later upserted with dated versions,  whose dated versions are removed with it. Otherwise it is deleted from the current LUSID system datetime.  Only an Allocation Event that has not been booked can be deleted.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label from which to delete the Allocation Event. If not specified, an Allocation Event created without an effective datetime is removed from the beginning of time, dated versions upserted since included; any other is deleted from the current LUSID system datetime. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteAllocationEvent(scope, code, effectiveAt, opts: opts);

                // [EXPERIMENTAL] DeleteAllocationEvent: Delete an Allocation Event.
                DeletedEntityResponse result = apiInstance.DeleteAllocationEvent(scope, code, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.DeleteAllocationEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAllocationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteAllocationEvent: Delete an Allocation Event.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteAllocationEventWithHttpInfo(scope, code, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.DeleteAllocationEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label from which to delete the Allocation Event. If not specified, an Allocation Event created without an effective datetime is removed from the beginning of time, dated versions upserted since included; any other is deleted from the current LUSID system datetime. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Allocation Event was deleted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getallocationevent"></a>
# **GetAllocationEvent**
> AllocationEvent GetAllocationEvent (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetAllocationEvent: Get an Allocation Event.

Retrieve a particular Allocation Event at an effective and asAt datetime, including its computed  per-investor shares and, once booked, its booking reference.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Allocation Event. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Allocation Event. Defaults to returning the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationEvent result = apiInstance.GetAllocationEvent(scope, code, effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] GetAllocationEvent: Get an Allocation Event.
                AllocationEvent result = apiInstance.GetAllocationEvent(scope, code, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.GetAllocationEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllocationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetAllocationEvent: Get an Allocation Event.
    ApiResponse<AllocationEvent> response = apiInstance.GetAllocationEventWithHttpInfo(scope, code, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.GetAllocationEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Allocation Event. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Allocation Event. Defaults to returning the latest version if not specified. | [optional]  |

### Return type

[**AllocationEvent**](AllocationEvent.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Allocation Event. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getallocationeventnotices"></a>
# **GetAllocationEventNotices**
> ResourceListOfAllocationEventNotice GetAllocationEventNotices (string scope, string code, string? investorRecordId = null, bool? includeZero = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetAllocationEventNotices: [EARLY ACCESS] GetAllocationEventNotices: Get the notices an allocation event issues to its partners.

One notice per partner allocation, listing the ILPA transaction lines, the net amount due, the partner's  unfunded commitment reconciliation across the event and their cumulative position alongside the general  partner's. Notices carry a DRAFT watermark until the event is booked.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var investorRecordId = "investorRecordId_example";  // string? | Restrict the notices to this partner's investor record. (optional) 
            var includeZero = false;  // bool? | Whether to include notices whose every line is zero. Defaults to false. (optional)  (default to false)
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to read the event. Defaults to returning the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfAllocationEventNotice result = apiInstance.GetAllocationEventNotices(scope, code, investorRecordId, includeZero, asAt, opts: opts);

                // [EARLY ACCESS] GetAllocationEventNotices: [EARLY ACCESS] GetAllocationEventNotices: Get the notices an allocation event issues to its partners.
                ResourceListOfAllocationEventNotice result = apiInstance.GetAllocationEventNotices(scope, code, investorRecordId, includeZero, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.GetAllocationEventNotices: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllocationEventNoticesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetAllocationEventNotices: [EARLY ACCESS] GetAllocationEventNotices: Get the notices an allocation event issues to its partners.
    ApiResponse<ResourceListOfAllocationEventNotice> response = apiInstance.GetAllocationEventNoticesWithHttpInfo(scope, code, investorRecordId, includeZero, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.GetAllocationEventNoticesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **investorRecordId** | **string?** | Restrict the notices to this partner&#39;s investor record. | [optional]  |
| **includeZero** | **bool?** | Whether to include notices whose every line is zero. Defaults to false. | [optional] [default to false] |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to read the event. Defaults to returning the latest version if not specified. | [optional]  |

### Return type

[**ResourceListOfAllocationEventNotice**](ResourceListOfAllocationEventNotice.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The notices the allocation event issues. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getallocationeventreceivables"></a>
# **GetAllocationEventReceivables**
> AllocationReceivablesAgeing GetAllocationEventReceivables (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetAllocationEventReceivables: Get the receivables of an Allocation Event.

What each investor still owes on a booked capital call as of the effective datetime, with how many days past  due it is and the ageing bucket that puts it in.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label as of which to age the receivables. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to read the Allocation Event. Defaults to returning the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationReceivablesAgeing result = apiInstance.GetAllocationEventReceivables(scope, code, effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] GetAllocationEventReceivables: Get the receivables of an Allocation Event.
                AllocationReceivablesAgeing result = apiInstance.GetAllocationEventReceivables(scope, code, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.GetAllocationEventReceivables: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllocationEventReceivablesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetAllocationEventReceivables: Get the receivables of an Allocation Event.
    ApiResponse<AllocationReceivablesAgeing> response = apiInstance.GetAllocationEventReceivablesWithHttpInfo(scope, code, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.GetAllocationEventReceivablesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label as of which to age the receivables. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to read the Allocation Event. Defaults to returning the latest version if not specified. | [optional]  |

### Return type

[**AllocationReceivablesAgeing**](AllocationReceivablesAgeing.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The aged receivables of the Allocation Event. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listallocationevents"></a>
# **ListAllocationEvents**
> PagedResourceListOfAllocationEvent ListAllocationEvents (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EXPERIMENTAL] ListAllocationEvents: List Allocation Events.

List all the Allocation Events matching a particular criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the Allocation Events. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Allocation Events. Defaults to returning the latest version of each Allocation Event if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Allocation Events; this value is returned from the previous call.              If a pagination token is provided, the filter, effectiveAt and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. For example, to filter on the Allocation Event status, specify \"status eq 'Booked'\".              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfAllocationEvent result = apiInstance.ListAllocationEvents(effectiveAt, asAt, page, limit, filter, sortBy, opts: opts);

                // [EXPERIMENTAL] ListAllocationEvents: List Allocation Events.
                PagedResourceListOfAllocationEvent result = apiInstance.ListAllocationEvents(effectiveAt, asAt, page, limit, filter, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.ListAllocationEvents: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllocationEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListAllocationEvents: List Allocation Events.
    ApiResponse<PagedResourceListOfAllocationEvent> response = apiInstance.ListAllocationEventsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.ListAllocationEventsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the Allocation Events. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Allocation Events. Defaults to returning the latest version of each Allocation Event if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Allocation Events; this value is returned from the previous call.              If a pagination token is provided, the filter, effectiveAt and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. For example, to filter on the Allocation Event status, specify \&quot;status eq &#39;Booked&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |

### Return type

[**PagedResourceListOfAllocationEvent**](PagedResourceListOfAllocationEvent.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Allocation Events. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listallocationpaymentholds"></a>
# **ListAllocationPaymentHolds**
> ResourceListOfAllocationPaymentHold ListAllocationPaymentHolds (string scope, string code, string investorRecordId)

[EARLY ACCESS] ListAllocationPaymentHolds: [EARLY ACCESS] ListAllocationPaymentHolds: List the holds placed on a partner's payment.

Every hold placed on the partner's payment against the event, newest first, including released ones.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var investorRecordId = "investorRecordId_example";  // string | The investor record of the partner whose holds are listed.

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfAllocationPaymentHold result = apiInstance.ListAllocationPaymentHolds(scope, code, investorRecordId, opts: opts);

                // [EARLY ACCESS] ListAllocationPaymentHolds: [EARLY ACCESS] ListAllocationPaymentHolds: List the holds placed on a partner's payment.
                ResourceListOfAllocationPaymentHold result = apiInstance.ListAllocationPaymentHolds(scope, code, investorRecordId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.ListAllocationPaymentHolds: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllocationPaymentHoldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListAllocationPaymentHolds: [EARLY ACCESS] ListAllocationPaymentHolds: List the holds placed on a partner's payment.
    ApiResponse<ResourceListOfAllocationPaymentHold> response = apiInstance.ListAllocationPaymentHoldsWithHttpInfo(scope, code, investorRecordId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.ListAllocationPaymentHoldsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **investorRecordId** | **string** | The investor record of the partner whose holds are listed. |  |

### Return type

[**ResourceListOfAllocationPaymentHold**](ResourceListOfAllocationPaymentHold.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The holds placed on the partner&#39;s payment. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="planallocationeventbooking"></a>
# **PlanAllocationEventBooking**
> AllocationPostingPlan PlanAllocationEventBooking (string scope, string code, AllocationEventBookRequest allocationEventBookRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] PlanAllocationEventBooking: Plan the booking of an Allocation Event.

Show everything booking a computed Allocation Event under a booking reference would write, validated as the  booking itself would be, without writing any of it: the investors' lines, the roll-ups above them through the  fund structure and the fund-side transactions. A booking that would be refused fails here with every problem  listed; warnings the map's policy lets through come back on the plan.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var allocationEventBookRequest = new AllocationEventBookRequest(); // AllocationEventBookRequest | The booking reference the plan is drawn up under.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to plan the booking. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationPostingPlan result = apiInstance.PlanAllocationEventBooking(scope, code, allocationEventBookRequest, effectiveAt, opts: opts);

                // [EXPERIMENTAL] PlanAllocationEventBooking: Plan the booking of an Allocation Event.
                AllocationPostingPlan result = apiInstance.PlanAllocationEventBooking(scope, code, allocationEventBookRequest, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.PlanAllocationEventBooking: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlanAllocationEventBookingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PlanAllocationEventBooking: Plan the booking of an Allocation Event.
    ApiResponse<AllocationPostingPlan> response = apiInstance.PlanAllocationEventBookingWithHttpInfo(scope, code, allocationEventBookRequest, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.PlanAllocationEventBookingWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **allocationEventBookRequest** | [**AllocationEventBookRequest**](AllocationEventBookRequest.md) | The booking reference the plan is drawn up under. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to plan the booking. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**AllocationPostingPlan**](AllocationPostingPlan.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The postings the booking would write. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putallocationpaymenthold"></a>
# **PutAllocationPaymentHold**
> AllocationPaymentHold PutAllocationPaymentHold (string scope, string code, string investorRecordId, AllocationPaymentHoldRequest allocationPaymentHoldRequest)

[EARLY ACCESS] PutAllocationPaymentHold: [EARLY ACCESS] PutAllocationPaymentHold: Place, move or release a hold on a partner's payment.

A Blocked or Escrow hold stops the partner's allocation being received against the event until it is  Released. A hold may only be released by a user other than the one who placed it.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var investorRecordId = "investorRecordId_example";  // string | The investor record of the partner whose payment is held.
            var allocationPaymentHoldRequest = new AllocationPaymentHoldRequest(); // AllocationPaymentHoldRequest | The hold to record: its status, and optionally a reason and an external reference.

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationPaymentHold result = apiInstance.PutAllocationPaymentHold(scope, code, investorRecordId, allocationPaymentHoldRequest, opts: opts);

                // [EARLY ACCESS] PutAllocationPaymentHold: [EARLY ACCESS] PutAllocationPaymentHold: Place, move or release a hold on a partner's payment.
                AllocationPaymentHold result = apiInstance.PutAllocationPaymentHold(scope, code, investorRecordId, allocationPaymentHoldRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.PutAllocationPaymentHold: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutAllocationPaymentHoldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] PutAllocationPaymentHold: [EARLY ACCESS] PutAllocationPaymentHold: Place, move or release a hold on a partner's payment.
    ApiResponse<AllocationPaymentHold> response = apiInstance.PutAllocationPaymentHoldWithHttpInfo(scope, code, investorRecordId, allocationPaymentHoldRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.PutAllocationPaymentHoldWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **investorRecordId** | **string** | The investor record of the partner whose payment is held. |  |
| **allocationPaymentHoldRequest** | [**AllocationPaymentHoldRequest**](AllocationPaymentHoldRequest.md) | The hold to record: its status, and optionally a reason and an external reference. |  |

### Return type

[**AllocationPaymentHold**](AllocationPaymentHold.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The hold as recorded. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="reallocateallocationevent"></a>
# **ReallocateAllocationEvent**
> AllocationEvent ReallocateAllocationEvent (string scope, string code, AllocationEventReallocateRequest allocationEventReallocateRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] ReallocateAllocationEvent: Reallocate an Allocation Event.

Recompute the per-investor shares of an unbooked Allocation Event against its map, from an effective  datetime, recording the reason. Any basis values supplied replace those used before. A booked Allocation  Event cannot be reallocated.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var allocationEventReallocateRequest = new AllocationEventReallocateRequest(); // AllocationEventReallocateRequest | The reason for the reallocation and any basis values to use.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label from which the reallocation applies. If not specified, the version in force now is recomputed in place from its own effective date. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationEvent result = apiInstance.ReallocateAllocationEvent(scope, code, allocationEventReallocateRequest, effectiveAt, opts: opts);

                // [EXPERIMENTAL] ReallocateAllocationEvent: Reallocate an Allocation Event.
                AllocationEvent result = apiInstance.ReallocateAllocationEvent(scope, code, allocationEventReallocateRequest, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.ReallocateAllocationEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReallocateAllocationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ReallocateAllocationEvent: Reallocate an Allocation Event.
    ApiResponse<AllocationEvent> response = apiInstance.ReallocateAllocationEventWithHttpInfo(scope, code, allocationEventReallocateRequest, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.ReallocateAllocationEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **allocationEventReallocateRequest** | [**AllocationEventReallocateRequest**](AllocationEventReallocateRequest.md) | The reason for the reallocation and any basis values to use. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label from which the reallocation applies. If not specified, the version in force now is recomputed in place from its own effective date. | [optional]  |

### Return type

[**AllocationEvent**](AllocationEvent.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The reallocated Allocation Event. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="receiveallocationevent"></a>
# **ReceiveAllocationEvent**
> AllocationEvent ReceiveAllocationEvent (string scope, string code, AllocationEventReceiptRequest allocationEventReceiptRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] ReceiveAllocationEvent: Record a receipt against an Allocation Event.

Record cash received from an investor against a booked capital call. The receipt is applied to what the  investor owes on the call; anything over is recorded as a refund payable, so the outstanding amount never  goes negative. A bank charge is borne by the partner or the fund as the map's policy says, and a receipt in  another currency is converted at the rate given.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var allocationEventReceiptRequest = new AllocationEventReceiptRequest(); // AllocationEventReceiptRequest | The investor, amount and date of the receipt.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to read the Allocation Event receiving cash. The receipt is recorded on the version in force at that time, from that version's own effective date; the receipt postings are dated by the request. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationEvent result = apiInstance.ReceiveAllocationEvent(scope, code, allocationEventReceiptRequest, effectiveAt, opts: opts);

                // [EXPERIMENTAL] ReceiveAllocationEvent: Record a receipt against an Allocation Event.
                AllocationEvent result = apiInstance.ReceiveAllocationEvent(scope, code, allocationEventReceiptRequest, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.ReceiveAllocationEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReceiveAllocationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ReceiveAllocationEvent: Record a receipt against an Allocation Event.
    ApiResponse<AllocationEvent> response = apiInstance.ReceiveAllocationEventWithHttpInfo(scope, code, allocationEventReceiptRequest, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.ReceiveAllocationEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **allocationEventReceiptRequest** | [**AllocationEventReceiptRequest**](AllocationEventReceiptRequest.md) | The investor, amount and date of the receipt. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to read the Allocation Event receiving cash. The receipt is recorded on the version in force at that time, from that version&#39;s own effective date; the receipt postings are dated by the request. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**AllocationEvent**](AllocationEvent.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Allocation Event with the receipt recorded. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="reverseallocationevent"></a>
# **ReverseAllocationEvent**
> AllocationEvent ReverseAllocationEvent (string scope, string code, AllocationEventReverseRequest allocationEventReverseRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] ReverseAllocationEvent: Reverse an Allocation Event.

Reverse a booked Allocation Event: every posting the booking wrote is mirrored under the reversal reference and  the event is left Reversed. A reversal falling in a closed period posts in the current period unless it is  marked backdated. A reversal cannot itself be reversed; raise a new event naming the reversed one in its  replaces field to put corrected shares in the books.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var allocationEventReverseRequest = new AllocationEventReverseRequest(); // AllocationEventReverseRequest | The reason for the reversal and, optionally, when it should take effect.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to read the Allocation Event to reverse. The reversed status is recorded on the version in force at that time, from that version's own effective date; the mirror postings are dated by the request. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationEvent result = apiInstance.ReverseAllocationEvent(scope, code, allocationEventReverseRequest, effectiveAt, opts: opts);

                // [EXPERIMENTAL] ReverseAllocationEvent: Reverse an Allocation Event.
                AllocationEvent result = apiInstance.ReverseAllocationEvent(scope, code, allocationEventReverseRequest, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.ReverseAllocationEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReverseAllocationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ReverseAllocationEvent: Reverse an Allocation Event.
    ApiResponse<AllocationEvent> response = apiInstance.ReverseAllocationEventWithHttpInfo(scope, code, allocationEventReverseRequest, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.ReverseAllocationEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **allocationEventReverseRequest** | [**AllocationEventReverseRequest**](AllocationEventReverseRequest.md) | The reason for the reversal and, optionally, when it should take effect. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to read the Allocation Event to reverse. The reversed status is recorded on the version in force at that time, from that version&#39;s own effective date; the mirror postings are dated by the request. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**AllocationEvent**](AllocationEvent.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The reversed Allocation Event. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="unbookallocationevent"></a>
# **UnbookAllocationEvent**
> AllocationEvent UnbookAllocationEvent (string scope, string code, AllocationEventUnbookRequest allocationEventUnbookRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] UnbookAllocationEvent: Unbook an Allocation Event.

Take an Allocation Event whose booking stopped half way back to Computed, cancelling every posting the  booking wrote, and record why. Only an event in the Booking status can be unbooked: one that is Booked is  reversed instead.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var allocationEventUnbookRequest = new AllocationEventUnbookRequest(); // AllocationEventUnbookRequest | The reason the booking is being taken back.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to read the Allocation Event to unbook. The unbooking is recorded on the version in force at that time, from that version's own effective date. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationEvent result = apiInstance.UnbookAllocationEvent(scope, code, allocationEventUnbookRequest, effectiveAt, opts: opts);

                // [EXPERIMENTAL] UnbookAllocationEvent: Unbook an Allocation Event.
                AllocationEvent result = apiInstance.UnbookAllocationEvent(scope, code, allocationEventUnbookRequest, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.UnbookAllocationEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnbookAllocationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UnbookAllocationEvent: Unbook an Allocation Event.
    ApiResponse<AllocationEvent> response = apiInstance.UnbookAllocationEventWithHttpInfo(scope, code, allocationEventUnbookRequest, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.UnbookAllocationEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **allocationEventUnbookRequest** | [**AllocationEventUnbookRequest**](AllocationEventUnbookRequest.md) | The reason the booking is being taken back. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to read the Allocation Event to unbook. The unbooking is recorded on the version in force at that time, from that version&#39;s own effective date. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**AllocationEvent**](AllocationEvent.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Allocation Event, back at Computed. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertallocationevent"></a>
# **UpsertAllocationEvent**
> AllocationEvent UpsertAllocationEvent (string scope, string code, AllocationEventRequest allocationEventRequest)

[EXPERIMENTAL] UpsertAllocationEvent: Upsert an Allocation Event.

Update or insert an Allocation Event. If the Allocation Event does not exist it is created, otherwise it is  replaced and its shares recomputed. The code in the request body must match the code in the route. A booked  Allocation Event is frozen and cannot be replaced.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var allocationEventRequest = new AllocationEventRequest(); // AllocationEventRequest | The definition of the Allocation Event.

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationEvent result = apiInstance.UpsertAllocationEvent(scope, code, allocationEventRequest, opts: opts);

                // [EXPERIMENTAL] UpsertAllocationEvent: Upsert an Allocation Event.
                AllocationEvent result = apiInstance.UpsertAllocationEvent(scope, code, allocationEventRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.UpsertAllocationEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertAllocationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertAllocationEvent: Upsert an Allocation Event.
    ApiResponse<AllocationEvent> response = apiInstance.UpsertAllocationEventWithHttpInfo(scope, code, allocationEventRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.UpsertAllocationEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **allocationEventRequest** | [**AllocationEventRequest**](AllocationEventRequest.md) | The definition of the Allocation Event. |  |

### Return type

[**AllocationEvent**](AllocationEvent.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The upserted Allocation Event. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

