# Lusid.Sdk.Model.HoldingContext
Holding context node.  Contains settings that control how LUSID handles holdings within portfolios.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaxLotLevelHoldings** | **bool** | Whether or not to expand the holdings to return the underlying tax-lots. Defaults to True. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool taxLotLevelHoldings = //"True";

HoldingContext holdingContextInstance = new HoldingContext(
    taxLotLevelHoldings: taxLotLevelHoldings);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
