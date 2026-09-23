# Lusid.Sdk.Model.WithholdingTaxDatasetDefinitions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnomalyDataset** | [**WithholdingTaxDataset**](WithholdingTaxDataset.md) |  | 
**MainDataset** | [**WithholdingTaxDataset**](WithholdingTaxDataset.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

WithholdingTaxDataset anomalyDataset = new WithholdingTaxDataset();
WithholdingTaxDataset mainDataset = new WithholdingTaxDataset();

WithholdingTaxDatasetDefinitions withholdingTaxDatasetDefinitionsInstance = new WithholdingTaxDatasetDefinitions(
    anomalyDataset: anomalyDataset,
    mainDataset: mainDataset);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
