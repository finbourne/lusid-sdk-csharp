# Lusid.Sdk.Model.FundTaxScopeExclusions
What the UK chargeable-gains figures leave out of the pooled computation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentTypes** | **List&lt;string&gt;** | Instrument types that stay on the portfolio&#39;s ordinary accounting method rather than being pooled, by name. | 
**LeafOutcomes** | **List&lt;string&gt;** | Disposal-leg outcomes the configured regime options disapply. Empty under the standard options. | 
**AppliedInFigures** | **bool** | Whether the engine enforces these exclusions when building the pooled lots and gains. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> instrumentTypes = new List<string>();
List<string> leafOutcomes = new List<string>();
bool appliedInFigures = //"True";

FundTaxScopeExclusions fundTaxScopeExclusionsInstance = new FundTaxScopeExclusions(
    instrumentTypes: instrumentTypes,
    leafOutcomes: leafOutcomes,
    appliedInFigures: appliedInFigures);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
