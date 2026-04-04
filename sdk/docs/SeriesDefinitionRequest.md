# Lusid.Sdk.Model.SeriesDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShareClassCode** | **string** | The code of the Share Class this Series belongs to. | 
**SeriesDefinitions** | [**List&lt;SeriesDefinition&gt;**](SeriesDefinition.md) | The definitions of the Series to add to the Share Class. | 

```csharp
using Lusid.Sdk.Model;
using System;

string shareClassCode = "shareClassCode";
List<SeriesDefinition> seriesDefinitions = new List<SeriesDefinition>();

SeriesDefinitionRequest seriesDefinitionRequestInstance = new SeriesDefinitionRequest(
    shareClassCode: shareClassCode,
    seriesDefinitions: seriesDefinitions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
