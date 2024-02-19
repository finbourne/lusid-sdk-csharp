# Lusid.Sdk.Model.JournalEntryLine
A Journal Entry line entity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountingDate** | **DateTimeOffset** | The Journal Entry Line accounting date. | 
**ActivityDate** | **DateTimeOffset** | The actual date of the activity. Differs from the accounting date when creating journals that would occur in a closed period. | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**InstrumentId** | **string** | To indicate the instrument of the transaction that the Journal Entry Line posted for, if applicable. | 
**InstrumentScope** | **string** | The scope in which the Journal Entry Line instrument is in. | 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding properties which are part of the AccountingKey. | [optional] 
**TaxLotId** | **string** | The tax lot Id that the Journal Entry Line is impacting. | [optional] 
**GeneralLedgerAccountCode** | **string** | The code of the account in the general ledger the Journal Entry was posted to. | 
**Local** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**Base** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**PostingModuleCode** | **string** | The code of the posting module where the posting rules derived the Journal Entry lines. | [optional] 
**PostingRule** | **string** | The rule generating the Journal Entry Line. | 
**AsAtDate** | **DateTimeOffset** | The corresponding input date and time of the Transaction generating the Journal Entry Line. | 
**ActivitiesDescription** | **string** | This would be the description of the business activities this Journal Entry Line is for. | [optional] 
**SourceType** | **string** | So far are 4 types: LusidTxn, LusidValuation, Manual and External. | 
**SourceId** | **string** | For the Lusid Source Type this will be the txn Id. For the rest will be what the user populates. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Abor. | [optional] 
**MovementName** | **string** | The name of the movement. | [optional] 
**HoldingType** | **string** | Defines the broad category holding within the portfolio. | 
**EconomicBucket** | **string** | Raw Journal Entry Line details of the economic bucket for the Journal Entry Line. | 
**EconomicBucketComponent** | **string** | Sub bucket of the economic bucket. | [optional] 
**Levels** | **List&lt;string&gt;** | Resolved data from the general ledger profile where the GeneralLedgerProfileCode is specified in the GetJournalEntryLines request body. | [optional] 
**SourceLevels** | **List&lt;string&gt;** | Source data from the general ledger profile where the GeneralLedgerProfileCode is specified in the GetJournalEntryLines request body. | [optional] 
**MovementSign** | **string** | Indicates if the Journal Entry Line corresponds to a Long or Short movement. | [optional] 
**HoldingSign** | **string** | Indicates if the Journal Entry Line is operating against a Long or Short holding. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

