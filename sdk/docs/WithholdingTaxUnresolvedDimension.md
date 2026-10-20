# Lusid.Sdk.Model.WithholdingTaxUnresolvedDimension

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReadFrom** | **List&lt;string&gt;** | What booking reads the dimension from: Transaction, Portfolio or Fund. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> readFrom = new List<string>();

WithholdingTaxUnresolvedDimension withholdingTaxUnresolvedDimensionInstance = new WithholdingTaxUnresolvedDimension(
    readFrom: readFrom);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
