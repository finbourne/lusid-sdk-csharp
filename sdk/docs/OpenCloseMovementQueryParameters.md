# Lusid.Sdk.Model.OpenCloseMovementQueryParameters
The parameters of an open, close and movement report over a valuation point window.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Start** | [**DateOrDiaryEntry**](DateOrDiaryEntry.md) |  | [optional] 
**End** | [**DateOrDiaryEntry**](DateOrDiaryEntry.md) |  | 
**Variant** | **string** | Optional variant code. Only required when it is necessary to choose between scenarios with multiple estimates. | [optional] 
**SubHoldingKeysToKeep** | **List&lt;string&gt;** | The sub-holding keys to report separately, in the format {domain}/{scope}/{code}. Holdings of an instrument are consolidated to one row per holding type and currency across every other sub-holding key; with none kept every instrument is one row. | [optional] 
**InstrumentPropertyKeys** | **List&lt;string&gt;** | Property keys from the &#39;Instrument&#39; domain to decorate onto each row, in the format {domain}/{scope}/{code} e.g. &#39;Instrument/system/Name&#39;. | [optional] 
**OpeningMetrics** | **List&lt;string&gt;** | Valuation address keys to report at the opening of the window, e.g. &#39;Holding/Units&#39;, &#39;Quotes/Price&#39; or &#39;Valuation/PV&#39;. When holdings are consolidated a metric that scales with quantity is summed; any other is reported only when it is the same on every consolidated holding, and is otherwise null with a diagnostic in the row&#39;s errors. | [optional] 
**ClosingMetrics** | **List&lt;string&gt;** | Valuation address keys to report at the closing of the window, aggregated as the opening metrics are. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DateOrDiaryEntry? start = new DateOrDiaryEntry();

DateOrDiaryEntry end = new DateOrDiaryEntry();
string variant = "example variant";
List<string> subHoldingKeysToKeep = new List<string>();
List<string> instrumentPropertyKeys = new List<string>();
List<string> openingMetrics = new List<string>();
List<string> closingMetrics = new List<string>();

OpenCloseMovementQueryParameters openCloseMovementQueryParametersInstance = new OpenCloseMovementQueryParameters(
    start: start,
    end: end,
    variant: variant,
    subHoldingKeysToKeep: subHoldingKeysToKeep,
    instrumentPropertyKeys: instrumentPropertyKeys,
    openingMetrics: openingMetrics,
    closingMetrics: closingMetrics);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
