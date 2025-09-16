# Lusid.Sdk.Model.PortfolioHolding
A list of holdings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentScope** | **string** | The scope in which the holding&#39;s instrument is in. | [optional] 
**InstrumentUid** | **string** | The unique Lusid Instrument Id (LUID) of the instrument that the holding is in. | 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured on a transaction portfolio. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The properties which have been requested to be decorated onto the holding. These will be from the &#39;Instrument&#39; or &#39;Holding&#39; domain. | [optional] 
**HoldingType** | **string** | The code for the type of the holding e.g. P, B, C, R, F etc. | 
**Units** | **decimal** | The total number of units of the holding. | 
**SettledUnits** | **decimal** | The total number of settled units of the holding. | 
**Cost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**CostPortfolioCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**Transaction** | [**Transaction**](Transaction.md) |  | [optional] 
**Currency** | **string** | The holding currency. | [optional] 
**HoldingTypeName** | **string** | The decoded type of the holding e.g. Position, Balance, CashCommitment, Receivable, ForwardFX etc. | [optional] 
**HoldingId** | **long?** | A single identifier for the holding within the portfolio. The holdingId is constructed from the LusidInstrumentId, sub-holding keys and currrency and is unique within the portfolio. | [optional] 
**NotionalCost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**AmortisedCost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**AmortisedCostPortfolioCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**VariationMargin** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**VariationMarginPortfolioCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**SettlementSchedule** | [**List&lt;SettlementSchedule&gt;**](SettlementSchedule.md) | Where no. of days ahead has been specified, future dated settlements will be captured here. | [optional] 
**CurrentFace** | **decimal?** | Current face value of the holding. | [optional] 
**CustodianAccountId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**UnsettledUnits** | **decimal** | The number of unsettled units for the holding. | [optional] 
**OverdueUnits** | **decimal** | The number of unsettled units for the holding that are beyond their contractual settlement date. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentScope = "example instrumentScope";
string instrumentUid = "instrumentUid";
Dictionary<string, PerpetualProperty> subHoldingKeys = new Dictionary<string, PerpetualProperty>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
string holdingType = "holdingType";decimal units = "units";
decimal settledUnits = "settledUnits";

CurrencyAndAmount cost = new CurrencyAndAmount();
CurrencyAndAmount costPortfolioCcy = new CurrencyAndAmount();
Transaction? transaction = new Transaction();

string currency = "example currency";
string holdingTypeName = "example holdingTypeName";
CurrencyAndAmount? notionalCost = new CurrencyAndAmount();

CurrencyAndAmount? amortisedCost = new CurrencyAndAmount();

CurrencyAndAmount? amortisedCostPortfolioCcy = new CurrencyAndAmount();

CurrencyAndAmount? variationMargin = new CurrencyAndAmount();

CurrencyAndAmount? variationMarginPortfolioCcy = new CurrencyAndAmount();

List<SettlementSchedule> settlementSchedule = new List<SettlementSchedule>();
ResourceId? custodianAccountId = new ResourceId();
decimal? unsettledUnits = "example unsettledUnits";decimal? overdueUnits = "example overdueUnits";

PortfolioHolding portfolioHoldingInstance = new PortfolioHolding(
    instrumentScope: instrumentScope,
    instrumentUid: instrumentUid,
    subHoldingKeys: subHoldingKeys,
    properties: properties,
    holdingType: holdingType,
    units: units,
    settledUnits: settledUnits,
    cost: cost,
    costPortfolioCcy: costPortfolioCcy,
    transaction: transaction,
    currency: currency,
    holdingTypeName: holdingTypeName,
    holdingId: holdingId,
    notionalCost: notionalCost,
    amortisedCost: amortisedCost,
    amortisedCostPortfolioCcy: amortisedCostPortfolioCcy,
    variationMargin: variationMargin,
    variationMarginPortfolioCcy: variationMarginPortfolioCcy,
    settlementSchedule: settlementSchedule,
    currentFace: currentFace,
    custodianAccountId: custodianAccountId,
    unsettledUnits: unsettledUnits,
    overdueUnits: overdueUnits);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
