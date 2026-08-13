# Lusid.Sdk.Model.RecResultException
The exception lifecycle of a rec result. Present only for exception result types  (Break, PartialMatch, PartialCross); null for Match and Cross.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Whether the exception is Open or Closed. Available values: Open, Closed. | 
**ClosureType** | **string** | How the exception was closed. Non-null only when status is Closed. Available values: Cleared, Accepted, ForceMatched. | [optional] 
**AsAtClosed** | **DateTimeOffset?** | The asAt of the transaction that closed the exception. Non-null only when status is Closed. | [optional] 
**AsAtClosureInvalidated** | **DateTimeOffset?** | First-failure bookmark: the asAt at which a judgement closure&#39;s validity condition first failed against the latest run&#39;s data. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string status = "status";
string closureType = "example closureType";

RecResultException recResultExceptionInstance = new RecResultException(
    status: status,
    closureType: closureType,
    asAtClosed: asAtClosed,
    asAtClosureInvalidated: asAtClosureInvalidated);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
