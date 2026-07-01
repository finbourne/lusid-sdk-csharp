# Lusid.Sdk.Model.ResolveTenorsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDate** | **DateTimeOffset** |  | 
**Calendars** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | 
**SpotDays** | **int** |  | 
**Tenors** | **List&lt;string&gt;** |  | 
**BusinessDayConvention** | **string** | Available values: NoAdjustment, None, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, HalfMonthModifiedFollowing, Nearest, Invalid. | [optional] 
**EomRule** | **string** |  | [optional] 
**AsAt** | **DateTimeOffset?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ResourceId> calendars = new List<ResourceId>();
List<string> tenors = new List<string>();
string businessDayConvention = "example businessDayConvention";
string eomRule = "example eomRule";

ResolveTenorsRequest resolveTenorsRequestInstance = new ResolveTenorsRequest(
    startDate: startDate,
    calendars: calendars,
    spotDays: spotDays,
    tenors: tenors,
    businessDayConvention: businessDayConvention,
    eomRule: eomRule,
    asAt: asAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
