# Lusid.Sdk.Model.FundCashStatementLocalCurrency
A single row in the local-currency Fund Cash Statement report. Each row is a settled cash  movement with a running balance in local currency only; base-currency columns are out of  scope for this variant and are not returned.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupById** | **int** | The groupBy subHoldings and currency. | [optional] 
**SequenceNumber** | **int** | Sequence number determining the order of the cash flow records. | [optional] 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured on a transaction portfolio. | [optional] 
**SourceId** | **string** | The transaction ID that sourced this cash movement. | [optional] 
**CashStatementActionType** | **string** | The action type: Default, Reversal, TrueUp, SystemCorrection, Opening, or Closing. | [optional] 
**EntryType** | **string** | What drove the row: SystemGenerated (accounting-engine housekeeping such as a reversal/true-up around a backdated transaction) or UserEntered (a real cash movement booked by a user, e.g. a late trade or amendment). | [optional] 
**AccountingDate** | **DateTimeOffset** | The accounting date of the cash movement. | [optional] 
**ActivityDate** | **DateTimeOffset** | The activity date (trade/settlement date) of the cash movement. | [optional] 
**MovementName** | **string** | The movement type (e.g. Receivable_Cash_Trade, Payable_Cash_Trade). | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**InstructionType** | **string** | The settlement instruction type: Automatic, Instructed_Complete, Instructed - Cancel Automatic. | [optional] 
**DiaryEntryCode** | **string** | The diary entry code of the valuation point this row belongs to. | [optional] 
**OriginDiaryEntryCode** | **string** | For Reversal/TrueUp rows: the diary entry code of the period the original row belonged to. | [optional] 
**CashflowLocal** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**BalanceLocal** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The requested properties decorated onto the cash statement row. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, PerpetualProperty> subHoldingKeys = new Dictionary<string, PerpetualProperty>();
string sourceId = "example sourceId";
string cashStatementActionType = "example cashStatementActionType";
string entryType = "example entryType";
string movementName = "example movementName";
ResourceId? portfolioId = new ResourceId();

string instructionType = "example instructionType";
string diaryEntryCode = "example diaryEntryCode";
string originDiaryEntryCode = "example originDiaryEntryCode";
CurrencyAndAmount? cashflowLocal = new CurrencyAndAmount();

CurrencyAndAmount? balanceLocal = new CurrencyAndAmount();

Dictionary<string, Property> properties = new Dictionary<string, Property>();
List<Link> links = new List<Link>();

FundCashStatementLocalCurrency fundCashStatementLocalCurrencyInstance = new FundCashStatementLocalCurrency(
    groupById: groupById,
    sequenceNumber: sequenceNumber,
    subHoldingKeys: subHoldingKeys,
    sourceId: sourceId,
    cashStatementActionType: cashStatementActionType,
    entryType: entryType,
    accountingDate: accountingDate,
    activityDate: activityDate,
    movementName: movementName,
    portfolioId: portfolioId,
    instructionType: instructionType,
    diaryEntryCode: diaryEntryCode,
    originDiaryEntryCode: originDiaryEntryCode,
    cashflowLocal: cashflowLocal,
    balanceLocal: balanceLocal,
    properties: properties,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
