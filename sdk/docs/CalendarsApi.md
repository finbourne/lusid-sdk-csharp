# Lusid.Sdk.Api.CalendarsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddBusinessDaysToDate**](CalendarsApi.md#addbusinessdaystodate) | **POST** /api/calendars/businessday/{scope}/add | [EARLY ACCESS] AddBusinessDaysToDate: Adds the requested number of Business Days to the provided date. |
| [**AddDateToCalendar**](CalendarsApi.md#adddatetocalendar) | **PUT** /api/calendars/generic/{scope}/{code}/dates | AddDateToCalendar: Add a date to a calendar |
| [**CreateCalendar**](CalendarsApi.md#createcalendar) | **POST** /api/calendars/generic | [EARLY ACCESS] CreateCalendar: Create a calendar in its generic form |
| [**DeleteCalendar**](CalendarsApi.md#deletecalendar) | **DELETE** /api/calendars/generic/{scope}/{code} | [EARLY ACCESS] DeleteCalendar: Delete a calendar |
| [**DeleteDateFromCalendar**](CalendarsApi.md#deletedatefromcalendar) | **DELETE** /api/calendars/generic/{scope}/{code}/dates/{dateId} | [EARLY ACCESS] DeleteDateFromCalendar: Remove a date from a calendar |
| [**GenerateSchedule**](CalendarsApi.md#generateschedule) | **POST** /api/calendars/schedule/{scope} | [EARLY ACCESS] GenerateSchedule: Generate an ordered schedule of dates. |
| [**GetCalendar**](CalendarsApi.md#getcalendar) | **GET** /api/calendars/generic/{scope}/{code} | GetCalendar: Get a calendar in its generic form |
| [**GetDates**](CalendarsApi.md#getdates) | **GET** /api/calendars/generic/{scope}/{code}/dates | [EARLY ACCESS] GetDates: Get dates for a specific calendar |
| [**IsBusinessDateTime**](CalendarsApi.md#isbusinessdatetime) | **GET** /api/calendars/businessday/{scope}/{code} | [EARLY ACCESS] IsBusinessDateTime: Check whether a DateTime is a \&quot;Business DateTime\&quot; |
| [**ListCalendars**](CalendarsApi.md#listcalendars) | **GET** /api/calendars/generic | [EARLY ACCESS] ListCalendars: List Calendars |
| [**ListCalendarsInScope**](CalendarsApi.md#listcalendarsinscope) | **GET** /api/calendars/generic/{scope} | ListCalendarsInScope: List all calenders in a specified scope |
| [**UpdateCalendar**](CalendarsApi.md#updatecalendar) | **POST** /api/calendars/generic/{scope}/{code} | [EARLY ACCESS] UpdateCalendar: Update a calendar |

<a id="addbusinessdaystodate"></a>
# **AddBusinessDaysToDate**
> AddBusinessDaysToDateResponse AddBusinessDaysToDate (string scope, AddBusinessDaysToDateRequest addBusinessDaysToDateRequest)

[EARLY ACCESS] AddBusinessDaysToDate: Adds the requested number of Business Days to the provided date.

A Business day is defined as a point in time that:      * Does not represent a day in the calendar's weekend      * Does not represent a day in the calendar's list of holidays (e.g. Christmas Day in the UK)                 All dates specified must be UTC and the upper bound of a calendar is not inclusive                 e.g. From: 2020-12-24-00-00-00:       Adding 3 business days returns 2020-12-30, assuming Saturday and Sunday are weekends, and the 25th and 28th are holidays.       Adding -2 business days returns 2020-12-22 under the same assumptions.                If the provided number of days to add is zero, returns a failure.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CalendarsApi>();
            var scope = "scope_example";  // string | Scope within which to search for the calendars
            var addBusinessDaysToDateRequest = new AddBusinessDaysToDateRequest(); // AddBusinessDaysToDateRequest | Request Details: start date, number of days to add (which can be negative, but not zero), calendar codes and optionally an AsAt date for searching the calendar store

            try
            {
                // [EARLY ACCESS] AddBusinessDaysToDate: Adds the requested number of Business Days to the provided date.
                AddBusinessDaysToDateResponse result = apiInstance.AddBusinessDaysToDate(scope, addBusinessDaysToDateRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CalendarsApi.AddBusinessDaysToDate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddBusinessDaysToDateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] AddBusinessDaysToDate: Adds the requested number of Business Days to the provided date.
    ApiResponse<AddBusinessDaysToDateResponse> response = apiInstance.AddBusinessDaysToDateWithHttpInfo(scope, addBusinessDaysToDateRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CalendarsApi.AddBusinessDaysToDateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope within which to search for the calendars |  |
| **addBusinessDaysToDateRequest** | [**AddBusinessDaysToDateRequest**](AddBusinessDaysToDateRequest.md) | Request Details: start date, number of days to add (which can be negative, but not zero), calendar codes and optionally an AsAt date for searching the calendar store |  |

### Return type

[**AddBusinessDaysToDateResponse**](AddBusinessDaysToDateResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The business day that is a number of business days after the given date as determined by the given calendar codes |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="adddatetocalendar"></a>
# **AddDateToCalendar**
> CalendarDate AddDateToCalendar (string scope, string code, CreateDateRequest createDateRequest)

AddDateToCalendar: Add a date to a calendar

Add an event to the calendar. These Events can be a maximum of 24 hours and must be specified in UTC.  A local date will be calculated by the system and applied to the calendar before processing.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CalendarsApi>();
            var scope = "scope_example";  // string | Scope of the calendar
            var code = "code_example";  // string | Code of the calendar
            var createDateRequest = new CreateDateRequest(); // CreateDateRequest | Add date to calendar request

            try
            {
                // AddDateToCalendar: Add a date to a calendar
                CalendarDate result = apiInstance.AddDateToCalendar(scope, code, createDateRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CalendarsApi.AddDateToCalendar: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddDateToCalendarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // AddDateToCalendar: Add a date to a calendar
    ApiResponse<CalendarDate> response = apiInstance.AddDateToCalendarWithHttpInfo(scope, code, createDateRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CalendarsApi.AddDateToCalendarWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of the calendar |  |
| **code** | **string** | Code of the calendar |  |
| **createDateRequest** | [**CreateDateRequest**](CreateDateRequest.md) | Add date to calendar request |  |

### Return type

[**CalendarDate**](CalendarDate.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The created date |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createcalendar"></a>
# **CreateCalendar**
> Calendar CreateCalendar (CreateCalendarRequest createCalendarRequest)

[EARLY ACCESS] CreateCalendar: Create a calendar in its generic form

Create a calendar in a generic form which can be used to store date events.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CalendarsApi>();
            var createCalendarRequest = new CreateCalendarRequest(); // CreateCalendarRequest | A request to create the calendar

            try
            {
                // [EARLY ACCESS] CreateCalendar: Create a calendar in its generic form
                Calendar result = apiInstance.CreateCalendar(createCalendarRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CalendarsApi.CreateCalendar: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCalendarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateCalendar: Create a calendar in its generic form
    ApiResponse<Calendar> response = apiInstance.CreateCalendarWithHttpInfo(createCalendarRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CalendarsApi.CreateCalendarWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCalendarRequest** | [**CreateCalendarRequest**](CreateCalendarRequest.md) | A request to create the calendar |  |

### Return type

[**Calendar**](Calendar.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The created calendar |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletecalendar"></a>
# **DeleteCalendar**
> Calendar DeleteCalendar (string scope, string code)

[EARLY ACCESS] DeleteCalendar: Delete a calendar

Delete a calendar and all of its respective dates

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CalendarsApi>();
            var scope = "scope_example";  // string | Scope of the calendar
            var code = "code_example";  // string | Code of the calendar

            try
            {
                // [EARLY ACCESS] DeleteCalendar: Delete a calendar
                Calendar result = apiInstance.DeleteCalendar(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CalendarsApi.DeleteCalendar: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCalendarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteCalendar: Delete a calendar
    ApiResponse<Calendar> response = apiInstance.DeleteCalendarWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CalendarsApi.DeleteCalendarWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of the calendar |  |
| **code** | **string** | Code of the calendar |  |

### Return type

[**Calendar**](Calendar.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The deleted calendar |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletedatefromcalendar"></a>
# **DeleteDateFromCalendar**
> CalendarDate DeleteDateFromCalendar (string scope, string code, string dateId)

[EARLY ACCESS] DeleteDateFromCalendar: Remove a date from a calendar

Remove a date from a calendar.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CalendarsApi>();
            var scope = "scope_example";  // string | Scope of the calendar
            var code = "code_example";  // string | Code of the calendar
            var dateId = "dateId_example";  // string | Identifier of the date to be removed

            try
            {
                // [EARLY ACCESS] DeleteDateFromCalendar: Remove a date from a calendar
                CalendarDate result = apiInstance.DeleteDateFromCalendar(scope, code, dateId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CalendarsApi.DeleteDateFromCalendar: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDateFromCalendarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteDateFromCalendar: Remove a date from a calendar
    ApiResponse<CalendarDate> response = apiInstance.DeleteDateFromCalendarWithHttpInfo(scope, code, dateId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CalendarsApi.DeleteDateFromCalendarWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of the calendar |  |
| **code** | **string** | Code of the calendar |  |
| **dateId** | **string** | Identifier of the date to be removed |  |

### Return type

[**CalendarDate**](CalendarDate.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The deleted date |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="generateschedule"></a>
# **GenerateSchedule**
> List&lt;DateTimeOffset&gt; GenerateSchedule (string scope, ValuationSchedule valuationSchedule, DateTimeOffset? asAt = null)

[EARLY ACCESS] GenerateSchedule: Generate an ordered schedule of dates.

Returns an ordered array of dates. The dates will only fall on business  days as defined by the scope and calendar codes in the valuation schedule.                Valuations are made at a frequency defined by the valuation schedule's tenor, e.g. every day (\"1D\"),  every other week (\"2W\") etc. These dates will be adjusted onto business days as defined by the schedule's  rollConvention.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CalendarsApi>();
            var scope = "scope_example";  // string | Scope of the calendars to use
            var valuationSchedule = new ValuationSchedule(); // ValuationSchedule | The ValuationSchedule to generate schedule dates from
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional AsAt for searching the calendar store. Defaults to Latest. (optional) 

            try
            {
                // [EARLY ACCESS] GenerateSchedule: Generate an ordered schedule of dates.
                List<DateTimeOffset> result = apiInstance.GenerateSchedule(scope, valuationSchedule, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CalendarsApi.GenerateSchedule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerateScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GenerateSchedule: Generate an ordered schedule of dates.
    ApiResponse<List<DateTimeOffset>> response = apiInstance.GenerateScheduleWithHttpInfo(scope, valuationSchedule, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CalendarsApi.GenerateScheduleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of the calendars to use |  |
| **valuationSchedule** | [**ValuationSchedule**](ValuationSchedule.md) | The ValuationSchedule to generate schedule dates from |  |
| **asAt** | **DateTimeOffset?** | Optional AsAt for searching the calendar store. Defaults to Latest. | [optional]  |

### Return type

**List<DateTimeOffset>**

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of dates in chronological order. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcalendar"></a>
# **GetCalendar**
> Calendar GetCalendar (string scope, string code, List<string>? propertyKeys = null, DateTimeOffset? asAt = null)

GetCalendar: Get a calendar in its generic form

Retrieve a generic calendar by a specific ID at a point in AsAt time

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CalendarsApi>();
            var scope = "scope_example";  // string | Scope of the calendar identifier
            var code = "code_example";  // string | Code of the calendar identifier
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Calendar\" domain to decorate onto the calendar,               These take the format {domain}/{scope}/{code} e.g. \"Calendar/System/Name\". (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The AsAt datetime at which to retrieve the calendar (optional) 

            try
            {
                // GetCalendar: Get a calendar in its generic form
                Calendar result = apiInstance.GetCalendar(scope, code, propertyKeys, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CalendarsApi.GetCalendar: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCalendarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetCalendar: Get a calendar in its generic form
    ApiResponse<Calendar> response = apiInstance.GetCalendarWithHttpInfo(scope, code, propertyKeys, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CalendarsApi.GetCalendarWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of the calendar identifier |  |
| **code** | **string** | Code of the calendar identifier |  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Calendar\&quot; domain to decorate onto the calendar,               These take the format {domain}/{scope}/{code} e.g. \&quot;Calendar/System/Name\&quot;. | [optional]  |
| **asAt** | **DateTimeOffset?** | The AsAt datetime at which to retrieve the calendar | [optional]  |

### Return type

[**Calendar**](Calendar.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested calendar |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getdates"></a>
# **GetDates**
> ResourceListOfCalendarDate GetDates (string scope, string code, DateTimeOrCutLabel? fromEffectiveAt = null, DateTimeOrCutLabel? toEffectiveAt = null, DateTimeOffset? asAt = null, List<string>? idFilter = null)

[EARLY ACCESS] GetDates: Get dates for a specific calendar

Get dates from a specific calendar within a specific window of effective time, at a point in AsAt time.  Providing an id filter can further refine the results.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CalendarsApi>();
            var scope = "scope_example";  // string | Scope of the calendar
            var code = "code_example";  // string | Code of the calendar
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel? | Where the effective window of dates should begin from (optional) 
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel? | Where the effective window of dates should end (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | AsAt the dates should be retrieved at (optional) 
            var idFilter = new List<string>?(); // List<string>? | An additional filter that will filter dates based on their identifer (optional) 

            try
            {
                // [EARLY ACCESS] GetDates: Get dates for a specific calendar
                ResourceListOfCalendarDate result = apiInstance.GetDates(scope, code, fromEffectiveAt, toEffectiveAt, asAt, idFilter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CalendarsApi.GetDates: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetDates: Get dates for a specific calendar
    ApiResponse<ResourceListOfCalendarDate> response = apiInstance.GetDatesWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt, idFilter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CalendarsApi.GetDatesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of the calendar |  |
| **code** | **string** | Code of the calendar |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel?** | Where the effective window of dates should begin from | [optional]  |
| **toEffectiveAt** | **DateTimeOrCutLabel?** | Where the effective window of dates should end | [optional]  |
| **asAt** | **DateTimeOffset?** | AsAt the dates should be retrieved at | [optional]  |
| **idFilter** | [**List&lt;string&gt;?**](string.md) | An additional filter that will filter dates based on their identifer | [optional]  |

### Return type

[**ResourceListOfCalendarDate**](ResourceListOfCalendarDate.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested date |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="isbusinessdatetime"></a>
# **IsBusinessDateTime**
> IsBusinessDayResponse IsBusinessDateTime (DateTimeOffset dateTime, string scope, string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] IsBusinessDateTime: Check whether a DateTime is a \"Business DateTime\"

A Business DateTime is defined as a point in time that:      * Does not represent a day that overlaps with the calendars WeekendMask      * If the calendar is a \"Holiday Calendar\" Does not overlap with any dates in the calendar      * If the calendar is a \"TradingHours Calendar\" Does overlap with a date in the calendar                All dates specified must be UTC and the upper bound of a calendar is not inclusive   e.g. From: 2020-12-25-00-00-00        To: 2020-12-26-00-00-00  IsBusinessDay(2020-12-26-00-00-00) == false

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CalendarsApi>();
            var dateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset | DateTime to check - This DateTime must be UTC
            var scope = "scope_example";  // string | Scope of the calendar
            var code = "code_example";  // string | Code of the calendar
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | AsAt for the request (optional) 

            try
            {
                // [EARLY ACCESS] IsBusinessDateTime: Check whether a DateTime is a \"Business DateTime\"
                IsBusinessDayResponse result = apiInstance.IsBusinessDateTime(dateTime, scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CalendarsApi.IsBusinessDateTime: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the IsBusinessDateTimeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] IsBusinessDateTime: Check whether a DateTime is a \"Business DateTime\"
    ApiResponse<IsBusinessDayResponse> response = apiInstance.IsBusinessDateTimeWithHttpInfo(dateTime, scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CalendarsApi.IsBusinessDateTimeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dateTime** | **DateTimeOffset** | DateTime to check - This DateTime must be UTC |  |
| **scope** | **string** | Scope of the calendar |  |
| **code** | **string** | Code of the calendar |  |
| **asAt** | **DateTimeOffset?** | AsAt for the request | [optional]  |

### Return type

[**IsBusinessDayResponse**](IsBusinessDayResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Whether or not the requested DateTime is a BusinessDay or not |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcalendars"></a>
# **ListCalendars**
> PagedResourceListOfCalendar ListCalendars (DateTimeOffset? asAt = null, string? page = null, int? limit = null, List<string>? propertyKeys = null, string? filter = null)

[EARLY ACCESS] ListCalendars: List Calendars

List calendars at a point in AsAt time.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CalendarsApi>();
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The AsAt datetime at which to retrieve the calendars (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Calendar\" domain to decorate onto the calendar,               These take the format {domain}/{scope}/{code} e.g. \"Calendar/System/Name\". (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] ListCalendars: List Calendars
                PagedResourceListOfCalendar result = apiInstance.ListCalendars(asAt, page, limit, propertyKeys, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CalendarsApi.ListCalendars: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCalendarsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListCalendars: List Calendars
    ApiResponse<PagedResourceListOfCalendar> response = apiInstance.ListCalendarsWithHttpInfo(asAt, page, limit, propertyKeys, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CalendarsApi.ListCalendarsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The AsAt datetime at which to retrieve the calendars | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Calendar\&quot; domain to decorate onto the calendar,               These take the format {domain}/{scope}/{code} e.g. \&quot;Calendar/System/Name\&quot;. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfCalendar**](PagedResourceListOfCalendar.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List Calendars |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcalendarsinscope"></a>
# **ListCalendarsInScope**
> PagedResourceListOfCalendar ListCalendarsInScope (string scope, DateTimeOffset? asAt = null, string? page = null, int? limit = null, List<string>? propertyKeys = null, string? filter = null)

ListCalendarsInScope: List all calenders in a specified scope

List calendars in a Scope at a point in AsAt time.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CalendarsApi>();
            var scope = "scope_example";  // string | Scope of the calendars
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The AsAt datetime at which to retrieve the calendars (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Calendar\" domain to decorate onto the calendar,               These take the format {domain}/{scope}/{code} e.g. \"Calendar/System/Name\". (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // ListCalendarsInScope: List all calenders in a specified scope
                PagedResourceListOfCalendar result = apiInstance.ListCalendarsInScope(scope, asAt, page, limit, propertyKeys, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CalendarsApi.ListCalendarsInScope: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCalendarsInScopeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListCalendarsInScope: List all calenders in a specified scope
    ApiResponse<PagedResourceListOfCalendar> response = apiInstance.ListCalendarsInScopeWithHttpInfo(scope, asAt, page, limit, propertyKeys, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CalendarsApi.ListCalendarsInScopeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of the calendars |  |
| **asAt** | **DateTimeOffset?** | The AsAt datetime at which to retrieve the calendars | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Calendar\&quot; domain to decorate onto the calendar,               These take the format {domain}/{scope}/{code} e.g. \&quot;Calendar/System/Name\&quot;. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfCalendar**](PagedResourceListOfCalendar.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Calendars in the requested scope |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatecalendar"></a>
# **UpdateCalendar**
> Calendar UpdateCalendar (string scope, string code, UpdateCalendarRequest updateCalendarRequest)

[EARLY ACCESS] UpdateCalendar: Update a calendar

Update the calendars WeekendMask, SourceProvider or Properties

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CalendarsApi>();
            var scope = "scope_example";  // string | Scope of the request
            var code = "code_example";  // string | Code of the request
            var updateCalendarRequest = new UpdateCalendarRequest(); // UpdateCalendarRequest | The new state of the calendar

            try
            {
                // [EARLY ACCESS] UpdateCalendar: Update a calendar
                Calendar result = apiInstance.UpdateCalendar(scope, code, updateCalendarRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CalendarsApi.UpdateCalendar: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCalendarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateCalendar: Update a calendar
    ApiResponse<Calendar> response = apiInstance.UpdateCalendarWithHttpInfo(scope, code, updateCalendarRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CalendarsApi.UpdateCalendarWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of the request |  |
| **code** | **string** | Code of the request |  |
| **updateCalendarRequest** | [**UpdateCalendarRequest**](UpdateCalendarRequest.md) | The new state of the calendar |  |

### Return type

[**Calendar**](Calendar.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated calendar |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

