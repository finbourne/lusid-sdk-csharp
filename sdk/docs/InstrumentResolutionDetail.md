# Lusid.Sdk.Model.InstrumentResolutionDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | Unique instrument identifiers | 
**LusidInstrumentId** | **string** | LUSID&#39;s internal unique instrument identifier, resolved from the instrument identifiers | [optional] [readonly] 
**InstrumentScope** | **string** | The scope in which the instrument lies. | [optional] [readonly] 
**LaunchPrice** | **decimal?** | The launch price set when a shareclass is added to the fund. Defaults to 1. | [optional] 
**LaunchDate** | **DateTimeOffset?** | The launch date set when a shareclass is added to the fund. Defaults to Fund Inception Date. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
string lusidInstrumentId = "example lusidInstrumentId";
string instrumentScope = "example instrumentScope";

InstrumentResolutionDetail instrumentResolutionDetailInstance = new InstrumentResolutionDetail(
    instrumentIdentifiers: instrumentIdentifiers,
    lusidInstrumentId: lusidInstrumentId,
    instrumentScope: instrumentScope,
    launchPrice: launchPrice,
    launchDate: launchDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
