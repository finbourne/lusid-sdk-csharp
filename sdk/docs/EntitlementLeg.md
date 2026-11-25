# Lusid.Sdk.Model.EntitlementLeg
One child position or cash movement produced by a holding entitlement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LegId** | **string** | The identifier of this leg, unique within the entitlement and included in the identifiers of the transactions it produces | [optional] 
**InstrumentScope** | **string** | The scope of the instrument this leg receives. Given together with the instrument identifier | [optional] 
**InstrumentId** | **string** | The LUSID instrument identifier of the instrument this leg receives. Required for CarryCost, ReceiveAndSell, ReceiveInterestInKind and ReceiveDividendInKind, optional for RealiseAtAmount where its absence settles the proceeds to cash, and absent for every treatment that produces no position | [optional] 
**Units** | **decimal?** | The units this leg receives. Required where the leg names an instrument and absent where it does not | [optional] 
**CostFraction** | **decimal?** | The share of the parent&#39;s pre-event cost that this leg takes, from 0 to 1. Required for CarryCost and ReceiveAndSell and absent otherwise. The fractions across all legs must not sum to more than 1 | [optional] 
**CashPaid** | **decimal?** | The cash the holder pays to receive this leg. It adds to the leg&#39;s cost and is neither income nor expense. Must not be negative | [optional] 
**Price** | **decimal?** | The stated price of this leg. Must not be negative for RealiseAtAmount and ReceiveAndSell | [optional] 
**Amount** | **decimal?** | The stated amount of this leg. Required unless the treatment is CarryCost. For RealiseCash it is the signed cash moved; for ReceiveInterestInKind, ReceiveDividendInKind and for every other treatment that produces no position it must be positive. For RealiseAtAmount and ReceiveAndSell it must not be negative | [optional] 
**SettlementCurrency** | **string** | The currency of this leg&#39;s cash movement. Defaults to the currency of the holding, and must be that currency where given. The RealiseAtAmount legs of an entitlement must all settle in one currency | [optional] 
**Treatment** | **string** | How this leg is booked: CarryCost, RealiseAtAmount, ReceiveAndSell, RealiseCash, ExpenseCash, ReturnOfCapital, ReceiveDividendIncome, ReceiveInterestIncome, ReceiveOtherIncome, PayWithholdingTax, PayFee, ReceiveInterestInKind, ReclassifyIncomeAsCapital or ReceiveDividendInKind | [optional] 
**TransactionProperties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The transaction properties to set on every transaction this leg books, at most 100. Each must be in the Transaction domain. A value given here replaces the value the entitlement gives for the same property on this leg&#39;s transactions, and the value the transaction template gives | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string legId = "example legId";
string instrumentScope = "example instrumentScope";
string instrumentId = "example instrumentId";
string settlementCurrency = "example settlementCurrency";
string treatment = "example treatment";
Dictionary<string, PerpetualProperty> transactionProperties = new Dictionary<string, PerpetualProperty>();

EntitlementLeg entitlementLegInstance = new EntitlementLeg(
    legId: legId,
    instrumentScope: instrumentScope,
    instrumentId: instrumentId,
    units: units,
    costFraction: costFraction,
    cashPaid: cashPaid,
    price: price,
    amount: amount,
    settlementCurrency: settlementCurrency,
    treatment: treatment,
    transactionProperties: transactionProperties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
