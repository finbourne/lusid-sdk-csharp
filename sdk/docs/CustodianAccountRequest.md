# Lusid.Sdk.Model.CustodianAccountRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The Scope assigned to the Custodian Account, where left blank the parent Portfolio Scope will be used | [optional] 
**Code** | **string** | Unique Code representing the Custodian Account | 
**Status** | **string** | The Account status. Available values: Active, Inactive, Deleted. | [optional] 
**AccountNumber** | **string** | The Custodian Account Number | 
**AccountName** | **string** | The identifiable name given to the Custodian Account | 
**AccountingMethod** | **string** | The Accounting method to be used. Available values: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst, ProRateByUnits, ProRateByCost, ProRateByCostPortfolioCurrency, IntraDayThenFirstInFirstOut, LongTermHighestCostFirst, LongTermHighestCostFirstPortfolioCurrency, HighestCostFirstPortfolioCurrency, LowestCostFirstPortfolioCurrency, MaximumLossMinimumGain, MaximumLossMinimumGainPortfolioCurrency. | 
**Currency** | **string** | The Currency for the Account | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Set of unique Custodian Account properties and associated values to store with the Custodian Account. Each property must be from the &#39;CustodianAccount&#39; domain. | [optional] 
**CustodianIdentifier** | [**TypedResourceId**](TypedResourceId.md) |  | 
**AccountType** | **string** | The type of the Custodian Account. This is a free-text field that accepts any value. Optional, with no default. | [optional] 
**TaxLotSelectionCostBasis** | **string** | The cost figure that cost-referencing accounting methods evaluate when selecting tax lots for disposals from this account. This can be: Cost or AmortisedCost. If not specified or reset with Default, resolution falls through to the transaction type and then the portfolio&#39;s default. Available values: Default, Cost, AmortisedCost. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "example scope";
string code = "code";
string status = "example status";
string accountNumber = "accountNumber";
string accountName = "accountName";
string accountingMethod = "accountingMethod";
string currency = "currency";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
TypedResourceId custodianIdentifier = new TypedResourceId();
string accountType = "example accountType";
string taxLotSelectionCostBasis = "example taxLotSelectionCostBasis";

CustodianAccountRequest custodianAccountRequestInstance = new CustodianAccountRequest(
    scope: scope,
    code: code,
    status: status,
    accountNumber: accountNumber,
    accountName: accountName,
    accountingMethod: accountingMethod,
    currency: currency,
    properties: properties,
    custodianIdentifier: custodianIdentifier,
    accountType: accountType,
    taxLotSelectionCostBasis: taxLotSelectionCostBasis);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
