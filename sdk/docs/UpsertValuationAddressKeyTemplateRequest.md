# Lusid.Sdk.Model.UpsertValuationAddressKeyTemplateRequest
The content of a Valuation Template. An upsert replaces the display name, description and metrics.  If isDefault is not specified, the template keeps its current default flag.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the Valuation Template. | 
**Description** | **string** | A description of the Valuation Template. | [optional] 
**Metrics** | [**List&lt;AggregateSpec&gt;**](AggregateSpec.md) | The metrics to calculate in a valuation that uses this template. Each metric is an address key, an operation and optional key options. Valuation Templates do not support returnAs. | 
**IsDefault** | **bool?** | Set to true to make this template the domain default. The previous default stops being the default. Set to false on the current default to use the system default again. If not specified, the template keeps its current value. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
List<AggregateSpec> metrics = new List<AggregateSpec>();
bool? isDefault = //"True";

UpsertValuationAddressKeyTemplateRequest upsertValuationAddressKeyTemplateRequestInstance = new UpsertValuationAddressKeyTemplateRequest(
    displayName: displayName,
    description: description,
    metrics: metrics,
    isDefault: isDefault);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
