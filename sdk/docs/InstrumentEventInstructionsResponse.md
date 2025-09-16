# Lusid.Sdk.Model.InstrumentEventInstructionsResponse
The collection of successfully upserted instructions, and the collection of failures for those instructions that could not be upserted

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, InstrumentEventInstruction&gt;**](InstrumentEventInstruction.md) | The collection of successfully upserted instructions | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The collection of error information for instructions that could not be upserted | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, InstrumentEventInstruction> values = new Dictionary<string, InstrumentEventInstruction>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();

InstrumentEventInstructionsResponse instrumentEventInstructionsResponseInstance = new InstrumentEventInstructionsResponse(
    values: values,
    failed: failed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
