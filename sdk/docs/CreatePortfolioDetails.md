# Lusid.Sdk.Model.CreatePortfolioDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorporateActionSourceId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TaxLotSelectionCostBasis** | **string** | The cost figure that cost-referencing accounting methods evaluate when selecting tax lots for a disposal. This can be: Cost or AmortisedCost. If not supplied, the portfolio&#39;s current value is left unchanged; supply Default to reset it. A reset or never-configured basis reads back as absent. Available values: Default, Cost, AmortisedCost. | [optional] 
**FractionalUnitsTrueUpConfiguration** | [**FractionalUnitsTrueUpConfiguration**](FractionalUnitsTrueUpConfiguration.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? corporateActionSourceId = new ResourceId();

string taxLotSelectionCostBasis = "example taxLotSelectionCostBasis";
FractionalUnitsTrueUpConfiguration? fractionalUnitsTrueUpConfiguration = new FractionalUnitsTrueUpConfiguration();


CreatePortfolioDetails createPortfolioDetailsInstance = new CreatePortfolioDetails(
    corporateActionSourceId: corporateActionSourceId,
    taxLotSelectionCostBasis: taxLotSelectionCostBasis,
    fractionalUnitsTrueUpConfiguration: fractionalUnitsTrueUpConfiguration);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
