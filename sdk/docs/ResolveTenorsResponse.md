# Lusid.Sdk.Model.ResolveTenorsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDate** | **DateTimeOffset** |  | 
**SpotDate** | **DateTimeOffset** |  | 
**EomRuleApplied** | **bool** |  | 
**Dates** | **Dictionary&lt;string, DateTimeOffset&gt;** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

bool eomRuleApplied = //"True";
Dictionary<string, DateTimeOffset> dates = new Dictionary<string, DateTimeOffset>();

ResolveTenorsResponse resolveTenorsResponseInstance = new ResolveTenorsResponse(
    startDate: startDate,
    spotDate: spotDate,
    eomRuleApplied: eomRuleApplied,
    dates: dates);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
