# Lusid.Sdk.Model.InstrumentEventInstructionsResponse
The collection of successfully upserted instructions, the collection of those staged pending approval, and the collection of failures for those instructions that could not be upserted

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, InstrumentEventInstruction&gt;**](InstrumentEventInstruction.md) | The collection of successfully upserted instructions | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The collection of error information for instructions that could not be upserted | [optional] 
**Staged** | [**Dictionary&lt;string, InstrumentEventInstruction&gt;**](InstrumentEventInstruction.md) | The instructions that have been staged pending approval. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, InstrumentEventInstruction> values = new Dictionary<string, InstrumentEventInstruction>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
Dictionary<string, InstrumentEventInstruction> staged = new Dictionary<string, InstrumentEventInstruction>();

InstrumentEventInstructionsResponse instrumentEventInstructionsResponseInstance = new InstrumentEventInstructionsResponse(
    values: values,
    failed: failed,
    staged: staged);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
