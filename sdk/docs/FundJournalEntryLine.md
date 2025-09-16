# Lusid.Sdk.Model.FundJournalEntryLine
A Journal Entry line entity specifically for fund valuation point lines.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountingDate** | **DateTimeOffset** | The Journal Entry Line accounting date. | 
**ActivityDate** | **DateTimeOffset** | The actual date of the activity. Differs from the accounting date when creating journals that would occur in a closed period. | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**InstrumentId** | **string** | To indicate the instrument of the transaction that the Journal Entry Line posted for, if applicable. | 
**InstrumentScope** | **string** | The scope in which the Journal Entry Line instrument is in. | 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding properties which are part of the AccountingKey. | [optional] 
**TaxLotId** | **string** | If the holding type is &#39;B&#39; (settled cash balance), this is 1. Otherwise, this is the ID of a tax lot if applicable, or the source ID of the original transaction if not. | [optional] 
**GeneralLedgerAccountCode** | **string** | The code of the account in the general ledger the Journal Entry was posted to. | 
**Local** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**Base** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**Units** | **decimal** | Units held for the Journal Entry Line. | 
**PostingModuleCode** | **string** | The code of the posting module where the posting rules derived the Journal Entry lines. | [optional] 
**PostingRule** | **string** | The rule generating the Journal Entry Line. | 
**AsAtDate** | **DateTimeOffset** | The corresponding input date and time of the Transaction generating the Journal Entry Line. | 
**ActivitiesDescription** | **string** | This would be the description of the business activities this Journal Entry Line is for. | [optional] 
**SourceType** | **string** | So far are 4 types: LusidTxn, LusidValuation, Manual and External. | 
**SourceId** | **string** | For the Lusid Source Type this will be the txn Id. For the rest will be what the user populates. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Abor. | [optional] 
**MovementName** | **string** | If the JE Line is generated from a transaction, the name of the side in the transaction type&#39;s movement. If from a valuation, this is &#39;MarkToMarket&#39;. | [optional] 
**HoldingType** | **string** | One of the LUSID holding types such as &#39;P&#39; for position or &#39;B&#39; for settled cash balance. | 
**EconomicBucket** | **string** | LUSID automatically categorises a JE Line into a broad economic bucket such as &#39;NA_Cost&#39; or &#39;PL_RealPriceGL&#39;. | 
**EconomicBucketComponent** | **string** | Sub bucket of the economic bucket. | [optional] 
**EconomicBucketVariant** | **string** | Categorisation of a Mark-to-market journal entry line into LongTerm or ShortTerm based on whether the ActivityDate is more than a year after the purchase trade date or not. | [optional] 
**Levels** | **List&lt;string&gt;** | Resolved data from the general ledger profile where the GeneralLedgerProfileCode is specified in the GetJournalEntryLines request body. | [optional] 
**SourceLevels** | **List&lt;string&gt;** | Source data from the general ledger profile where the GeneralLedgerProfileCode is specified in the GetJournalEntryLines request body. | [optional] 
**MovementSign** | **string** | Indicates if the Journal Entry Line corresponds to a Long or Short movement. | [optional] 
**HoldingSign** | **string** | Indicates if the Journal Entry Line is operating against a Long or Short holding. | [optional] 
**LedgerColumn** | **string** | Indicates if the Journal Entry Line is credit or debit. | [optional] 
**JournalEntryLineType** | **string** | Indicates the Journal Entry Line type | [optional] 
**ShareClassBreakdowns** | [**List&lt;JournalEntryLineShareClassBreakdown&gt;**](JournalEntryLineShareClassBreakdown.md) | Share Class breakdown data for this Journal Entry Line. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
string instrumentId = "instrumentId";
string instrumentScope = "instrumentScope";
Dictionary<string, PerpetualProperty> subHoldingKeys = new Dictionary<string, PerpetualProperty>();
string taxLotId = "example taxLotId";
string generalLedgerAccountCode = "generalLedgerAccountCode";
CurrencyAndAmount local = new CurrencyAndAmount();
CurrencyAndAmount base = new CurrencyAndAmount();decimal units = "units";

string postingModuleCode = "example postingModuleCode";
string postingRule = "postingRule";
string activitiesDescription = "example activitiesDescription";
string sourceType = "sourceType";
string sourceId = "sourceId";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
string movementName = "example movementName";
string holdingType = "holdingType";
string economicBucket = "economicBucket";
string economicBucketComponent = "example economicBucketComponent";
string economicBucketVariant = "example economicBucketVariant";
List<string> levels = new List<string>();
List<string> sourceLevels = new List<string>();
string movementSign = "example movementSign";
string holdingSign = "example holdingSign";
string ledgerColumn = "example ledgerColumn";
string journalEntryLineType = "example journalEntryLineType";
List<JournalEntryLineShareClassBreakdown> shareClassBreakdowns = new List<JournalEntryLineShareClassBreakdown>();
List<Link> links = new List<Link>();

FundJournalEntryLine fundJournalEntryLineInstance = new FundJournalEntryLine(
    accountingDate: accountingDate,
    activityDate: activityDate,
    portfolioId: portfolioId,
    instrumentId: instrumentId,
    instrumentScope: instrumentScope,
    subHoldingKeys: subHoldingKeys,
    taxLotId: taxLotId,
    generalLedgerAccountCode: generalLedgerAccountCode,
    local: local,
    base: base,
    units: units,
    postingModuleCode: postingModuleCode,
    postingRule: postingRule,
    asAtDate: asAtDate,
    activitiesDescription: activitiesDescription,
    sourceType: sourceType,
    sourceId: sourceId,
    properties: properties,
    movementName: movementName,
    holdingType: holdingType,
    economicBucket: economicBucket,
    economicBucketComponent: economicBucketComponent,
    economicBucketVariant: economicBucketVariant,
    levels: levels,
    sourceLevels: sourceLevels,
    movementSign: movementSign,
    holdingSign: holdingSign,
    ledgerColumn: ledgerColumn,
    journalEntryLineType: journalEntryLineType,
    shareClassBreakdowns: shareClassBreakdowns,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
