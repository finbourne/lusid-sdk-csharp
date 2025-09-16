# Lusid.Sdk.Model.InstrumentModels
Supported pricing models for an instrument.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentId** | **string** | The unique LUSID Instrument Identifier (LUID) of the instrument. | [optional] 
**SupportedModels** | **List&lt;string&gt;** | The pricing models supported by the instrument e.g. &#39;Discounting&#39;. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentId = "example instrumentId";
List<string> supportedModels = new List<string>();
List<Link> links = new List<Link>();

InstrumentModels instrumentModelsInstance = new InstrumentModels(
    instrumentId: instrumentId,
    supportedModels: supportedModels,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
