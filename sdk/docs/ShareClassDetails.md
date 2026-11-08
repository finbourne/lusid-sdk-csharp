# Lusid.Sdk.Model.ShareClassDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LusidInstrumentId** | **string** | LUSID&#39;s internal unique instrument identifier, resolved from the share class&#39; instrument identifiers. Absent where no instrument was resolved for the share class: a fund defined with inline share classes resolves none, whether or not it created their instruments. | [optional] 
**InstrumentScope** | **string** | The scope in which the share class instrument lies, or the fund&#39;s instrument scope where no instrument was resolved for the share class. | [optional] 
**ShortCode** | **string** | The unique code within the fund for the share class instrument. | [optional] 
**DomCurrency** | **string** | The domestic currency of the share class instrument | [optional] 
**InstrumentActive** | **bool** | If the instrument of the share class is active. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string lusidInstrumentId = "example lusidInstrumentId";
string instrumentScope = "example instrumentScope";
string shortCode = "example shortCode";
string domCurrency = "example domCurrency";
bool instrumentActive = //"True";

ShareClassDetails shareClassDetailsInstance = new ShareClassDetails(
    lusidInstrumentId: lusidInstrumentId,
    instrumentScope: instrumentScope,
    shortCode: shortCode,
    domCurrency: domCurrency,
    instrumentActive: instrumentActive);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
