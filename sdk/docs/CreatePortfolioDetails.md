# Lusid.Sdk.Model.CreatePortfolioDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorporateActionSourceId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TaxLotSelectionCostBasis** | **string** | The cost figure that cost-referencing accounting methods evaluate when selecting tax lots for a disposal. This can be: Cost or AmortisedCost. If not supplied, the portfolio&#39;s current value is left unchanged; supply Default to reset it. Available values: Cost, AmortisedCost. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? corporateActionSourceId = new ResourceId();

string taxLotSelectionCostBasis = "example taxLotSelectionCostBasis";

CreatePortfolioDetails createPortfolioDetailsInstance = new CreatePortfolioDetails(
    corporateActionSourceId: corporateActionSourceId,
    taxLotSelectionCostBasis: taxLotSelectionCostBasis);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
