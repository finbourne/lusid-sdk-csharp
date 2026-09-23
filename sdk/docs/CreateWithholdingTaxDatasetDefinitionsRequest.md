# Lusid.Sdk.Model.CreateWithholdingTaxDatasetDefinitionsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnomalyDataset** | [**CreateWithholdingTaxDataset**](CreateWithholdingTaxDataset.md) |  | 
**MainDataset** | [**CreateWithholdingTaxDataset**](CreateWithholdingTaxDataset.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

CreateWithholdingTaxDataset anomalyDataset = new CreateWithholdingTaxDataset();
CreateWithholdingTaxDataset mainDataset = new CreateWithholdingTaxDataset();

CreateWithholdingTaxDatasetDefinitionsRequest createWithholdingTaxDatasetDefinitionsRequestInstance = new CreateWithholdingTaxDatasetDefinitionsRequest(
    anomalyDataset: anomalyDataset,
    mainDataset: mainDataset);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
