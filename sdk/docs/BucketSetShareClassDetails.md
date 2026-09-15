# Lusid.Sdk.Model.BucketSetShareClassDetails
Identifying detail for the share class a bucket set node is for.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LusidInstrumentId** | **string** | LUSID&#39;s internal unique instrument identifier for the share class&#39; instrument. Absent where the instrument has not been resolved. | [optional] 
**InstrumentScope** | **string** | The scope in which the share class instrument lies. Absent where the instrument has not been resolved. | [optional] 
**ShortCode** | **string** | The unique code within the fund for the share class. | 
**DomCurrency** | **string** | The domestic currency declared for the share class. | [optional] 
**InstrumentActive** | **bool** | Whether the share class&#39; instrument is active. | 

```csharp
using Lusid.Sdk.Model;
using System;

string lusidInstrumentId = "example lusidInstrumentId";
string instrumentScope = "example instrumentScope";
string shortCode = "shortCode";
string domCurrency = "example domCurrency";
bool instrumentActive = //"True";

BucketSetShareClassDetails bucketSetShareClassDetailsInstance = new BucketSetShareClassDetails(
    lusidInstrumentId: lusidInstrumentId,
    instrumentScope: instrumentScope,
    shortCode: shortCode,
    domCurrency: domCurrency,
    instrumentActive: instrumentActive);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
