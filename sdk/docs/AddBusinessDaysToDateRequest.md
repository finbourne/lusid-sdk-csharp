# Lusid.Sdk.Model.AddBusinessDaysToDateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BusinessDayOffset** | **int** |  | 
**HolidayCodes** | **List&lt;string&gt;** |  | 
**StartDate** | **DateTimeOffset** |  | [optional] 
**AsAt** | **DateTimeOffset?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> holidayCodes = new List<string>();

AddBusinessDaysToDateRequest addBusinessDaysToDateRequestInstance = new AddBusinessDaysToDateRequest(
    businessDayOffset: businessDayOffset,
    holidayCodes: holidayCodes,
    startDate: startDate,
    asAt: asAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
