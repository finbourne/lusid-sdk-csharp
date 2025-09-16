# Lusid.Sdk.Model.CreateSequenceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the sequence definition to create | 
**Increment** | **long?** | The value to increment between each value in the sequence | [optional] 
**MinValue** | **long?** | The minimum value of the sequence | [optional] 
**MaxValue** | **long?** | The maximum value of the sequence | [optional] 
**Start** | **long?** | The start value of the sequence | [optional] 
**Cycle** | **bool** | Set to true to start the sequence over again when it reaches the end. Defaults to false if not provided. | [optional] 
**Pattern** | **string** | The pattern to be used to generate next values in the sequence. Defaults to null if not provided. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
bool cycle = //"True";
string pattern = "example pattern";

CreateSequenceRequest createSequenceRequestInstance = new CreateSequenceRequest(
    code: code,
    increment: increment,
    minValue: minValue,
    maxValue: maxValue,
    start: start,
    cycle: cycle,
    pattern: pattern);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
