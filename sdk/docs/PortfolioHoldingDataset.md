# Lusid.Sdk.Model.PortfolioHoldingDataset
Contains the run-time parameters that are appropriate for check definitions  with datasetSchema.type = \"PortfolioContents\"

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAt** | **DateTimeOffset?** | The asAt date to fetch the data. Nullable. Defaults to latest. | [optional] 
**EffectiveAt** | **DateTimeOffset?** | The effectiveAt date to fetch the data. Nullable. Defaults to latest. | [optional] 
**PortfolioScope** | **string** | The scope of the portfolios whose holdings to check. Nullable. Every scope is checked if not provided. | [optional] 
**PortfolioSelectorAttribute** | **string** | An attribute (field name or propertyKey) to use to narrow down the portfolios whose holdings are checked. | [optional] 
**PortfolioSelectorValue** | **string** | The value of the above attribute used to narrow down the portfolios. | [optional] 
**HoldingSelectorAttribute** | **string** | An attribute (field name, propertyKey or sub-holding key) to use to narrow down the holdings checked  within those portfolios. | [optional] 
**HoldingSelectorValue** | **string** | The value of the above attribute used to narrow down the holdings. | [optional] 
**ByTaxlots** | **bool** | Whether to expand holdings to their underlying tax lots. Defaults to false. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string portfolioScope = "example portfolioScope";
string portfolioSelectorAttribute = "example portfolioSelectorAttribute";
string portfolioSelectorValue = "example portfolioSelectorValue";
string holdingSelectorAttribute = "example holdingSelectorAttribute";
string holdingSelectorValue = "example holdingSelectorValue";
bool byTaxlots = //"True";

PortfolioHoldingDataset portfolioHoldingDatasetInstance = new PortfolioHoldingDataset(
    asAt: asAt,
    effectiveAt: effectiveAt,
    portfolioScope: portfolioScope,
    portfolioSelectorAttribute: portfolioSelectorAttribute,
    portfolioSelectorValue: portfolioSelectorValue,
    holdingSelectorAttribute: holdingSelectorAttribute,
    holdingSelectorValue: holdingSelectorValue,
    byTaxlots: byTaxlots);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
