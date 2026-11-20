# Lusid.Sdk.Model.RegistryLine
A line of a portfolio's registry: a partner register line with the fields of a holding row and its capital  balances. Registry lines are never holdings, so a line here is absent from the portfolio's holdings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**InstrumentScope** | **string** | The scope in which the line&#39;s capital-interest instrument is in. | [optional] 
**InstrumentUid** | **string** | The unique Lusid Instrument Id (LUID) of the capital-interest instrument of the line. | 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured on a transaction portfolio. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The properties which have been requested to be decorated onto the line. These will be from the &#39;Instrument&#39; or &#39;Holding&#39; domain; the capital balances are available as &#39;Holding/system&#39; properties when requested by key. | [optional] 
**HoldingType** | **string** | The code for the type of the holding e.g. P, B, C, R, F etc. | 
**HoldingTypeName** | **string** | The decoded type of the holding e.g. Position, Balance, CashCommitment, Receivable, ForwardFX etc. | [optional] 
**Units** | **decimal** | The number of units of the line, one per open line. | 
**SettledUnits** | **decimal** | The number of settled units of the line. | 
**Cost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**CostPortfolioCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**Currency** | **string** | The commitment currency of the line. | [optional] 
**HoldingId** | **long?** | A single identifier for the line within the portfolio, constructed from the LusidInstrumentId, sub-holding keys and currency. | [optional] 
**InvestorRecordId** | **string** | The identifier of the investor record the line belongs to, as the register shows it. | 
**CommitmentLineId** | **string** | The identifier of the commitment (register) line, as its capital-interest instrument declares it. | 
**Committed** | **decimal** | The committed capital, in the commitment currency. | 
**UncalledCommitment** | **decimal** | The commitment not yet called, in the commitment currency. | 
**PaidIn** | **decimal** | The capital paid in, in the commitment currency. | 
**Returned** | **decimal** | The capital returned, in the commitment currency. | 
**Recallable** | **decimal** | The returned capital that may be recalled, in the commitment currency. | 
**Unfunded** | **decimal** | The unfunded commitment: the uncalled commitment plus the recallable capital, in the commitment currency. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
string instrumentScope = "example instrumentScope";
string instrumentUid = "instrumentUid";
Dictionary<string, PerpetualProperty> subHoldingKeys = new Dictionary<string, PerpetualProperty>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
string holdingType = "holdingType";
string holdingTypeName = "example holdingTypeName";decimal units = "units";
decimal settledUnits = "settledUnits";

CurrencyAndAmount cost = new CurrencyAndAmount();
CurrencyAndAmount costPortfolioCcy = new CurrencyAndAmount();
string currency = "example currency";
string investorRecordId = "investorRecordId";
string commitmentLineId = "commitmentLineId";decimal committed = "committed";
decimal uncalledCommitment = "uncalledCommitment";
decimal paidIn = "paidIn";
decimal returned = "returned";
decimal recallable = "recallable";
decimal unfunded = "unfunded";


RegistryLine registryLineInstance = new RegistryLine(
    portfolioId: portfolioId,
    instrumentScope: instrumentScope,
    instrumentUid: instrumentUid,
    subHoldingKeys: subHoldingKeys,
    properties: properties,
    holdingType: holdingType,
    holdingTypeName: holdingTypeName,
    units: units,
    settledUnits: settledUnits,
    cost: cost,
    costPortfolioCcy: costPortfolioCcy,
    currency: currency,
    holdingId: holdingId,
    investorRecordId: investorRecordId,
    commitmentLineId: commitmentLineId,
    committed: committed,
    uncalledCommitment: uncalledCommitment,
    paidIn: paidIn,
    returned: returned,
    recallable: recallable,
    unfunded: unfunded);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
