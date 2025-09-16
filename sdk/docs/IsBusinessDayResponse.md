# Lusid.Sdk.Model.IsBusinessDayResponse
Whether or not a DateTimeOffset is a business DateTime

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestedDateTime** | **DateTimeOffset** |  | 
**IsBusinessDay** | **bool** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

bool isBusinessDay = //"True";

IsBusinessDayResponse isBusinessDayResponseInstance = new IsBusinessDayResponse(
    requestedDateTime: requestedDateTime,
    isBusinessDay: isBusinessDay);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
