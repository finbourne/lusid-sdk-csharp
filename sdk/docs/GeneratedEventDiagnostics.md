# Lusid.Sdk.Model.GeneratedEventDiagnostics
Represents a set of diagnostics per generatedEvent, where applicable.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventId** | **string** |  | 
**Type** | **string** |  | 
**Detail** | **string** |  | 
**ErrorDetails** | **List&lt;string&gt;** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentEventId = "instrumentEventId";
string type = "type";
string detail = "detail";
List<string> errorDetails = new List<string>();

GeneratedEventDiagnostics generatedEventDiagnosticsInstance = new GeneratedEventDiagnostics(
    instrumentEventId: instrumentEventId,
    type: type,
    detail: detail,
    errorDetails: errorDetails);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
