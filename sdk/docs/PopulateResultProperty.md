# Lusid.Sdk.Model.PopulateResultProperty

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyKey** | **string** | The property the formula populates. Must be an existing, single-valued property in the RecResult domain, and may appear only once. | 
**Formula** | **string** | The formula whose value populates the property; a null value means the property has no value. | 
**OverwriteManualEditsOnReRun** | **bool?** | Whether a value edited since the property was last populated is replaced. Defaults to false, so manual edits are kept. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string propertyKey = "propertyKey";
string formula = "formula";
bool? overwriteManualEditsOnReRun = //"True";

PopulateResultProperty populateResultPropertyInstance = new PopulateResultProperty(
    propertyKey: propertyKey,
    formula: formula,
    overwriteManualEditsOnReRun: overwriteManualEditsOnReRun);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
