# Lusid.Sdk.Model.CompositeBreakdownRequest
The request used in the GetCompositeBreakdown.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReturnIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The Scope and code of the returns. | [optional] 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**CompositeMethod** | **string** | The method used to calculate the Portfolio performance: Equal/Asset. | [optional] 
**Period** | **string** | The type of the returns used to calculate the aggregation result: Daily/Monthly. | [optional] 
**HolidayCalendars** | **List&lt;string&gt;** | The holiday calendar(s) that should be used in determining the date schedule. Holiday calendar(s) are supplied by their codes, for example, &#39;CoppClark&#39;. Note that when the calendars are not available (e.g. when the user has insufficient permissions), a recipe setting will be used to determine whether the whole batch should then fail or whether the calendar not being available should simply be ignored. | [optional] 
**Currency** | **string** | Optional - either a string or a property. If provided, the results will be converted to the specified currency | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ResourceId> returnIds = new List<ResourceId>();
ResourceId? recipeId = new ResourceId();

string compositeMethod = "example compositeMethod";
string period = "example period";
List<string> holidayCalendars = new List<string>();
string currency = "example currency";

CompositeBreakdownRequest compositeBreakdownRequestInstance = new CompositeBreakdownRequest(
    returnIds: returnIds,
    recipeId: recipeId,
    compositeMethod: compositeMethod,
    period: period,
    holidayCalendars: holidayCalendars,
    currency: currency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
