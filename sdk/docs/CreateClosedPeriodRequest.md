# Lusid.Sdk.Model.CreateClosedPeriodRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClosedPeriodId** | **string** | The unique Id of the Closed Period. The ClosedPeriodId, together with the Timeline Scope and Code, uniquely identifies a Closed Period | 
**EffectiveEnd** | **DateTimeOffset** | The effective end of the Closed Period | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The Closed Periods properties. These will be from the &#39;ClosedPeriod&#39; domain. | [optional] 
**AsAtClosed** | **DateTimeOffset?** | The asAt closed datetime for the Closed Period | [optional] 
**DisplayName** | **string** | The name of the Closed Period. | [optional] 
**Description** | **string** | A description for the Closed Period. | [optional] 
**HoldingsAsAtClosedOverride** | **DateTimeOffset?** | The optional AsAtClosed Override to use for building holdings in the Closed Period.If not specified, the AsAtClosed on the Closed Period will be used. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string closedPeriodId = "closedPeriodId";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
string displayName = "example displayName";
string description = "example description";

CreateClosedPeriodRequest createClosedPeriodRequestInstance = new CreateClosedPeriodRequest(
    closedPeriodId: closedPeriodId,
    effectiveEnd: effectiveEnd,
    properties: properties,
    asAtClosed: asAtClosed,
    displayName: displayName,
    description: description,
    holdingsAsAtClosedOverride: holdingsAsAtClosedOverride);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
