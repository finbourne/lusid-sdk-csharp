# Lusid.Sdk.Model.CustomDataModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataModelSummary** | [**DataModelSummary**](DataModelSummary.md) |  | [optional] 
**Inherited** | [**CustomDataModelCriteria**](CustomDataModelCriteria.md) |  | [optional] 
**Incremental** | [**CustomDataModelCriteria**](CustomDataModelCriteria.md) |  | [optional] 
**Applied** | [**CustomDataModelCriteria**](CustomDataModelCriteria.md) |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DataModelSummary? dataModelSummary = new DataModelSummary();

CustomDataModelCriteria? inherited = new CustomDataModelCriteria();

CustomDataModelCriteria? incremental = new CustomDataModelCriteria();

CustomDataModelCriteria? applied = new CustomDataModelCriteria();

ModelVersion? varVersion = new ModelVersion();


CustomDataModel customDataModelInstance = new CustomDataModel(
    dataModelSummary: dataModelSummary,
    inherited: inherited,
    incremental: incremental,
    applied: applied,
    varVersion: varVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
