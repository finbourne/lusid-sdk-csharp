# Lusid.Sdk.Model.ExternalRecType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name for this external reconciliation describing source data. | 
**Temporality** | **string** | How the reconciliation reads its data: PointInTime (the latest state as at the instance&#39;s effectiveAt, the default) or Activity (everything effective across the instance&#39;s activity window). Available values: PointInTime, Activity. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "name";
string temporality = "example temporality";

ExternalRecType externalRecTypeInstance = new ExternalRecType(
    name: name,
    temporality: temporality);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
