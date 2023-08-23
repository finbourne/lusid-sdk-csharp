# Lusid.Sdk.Model.JELines
An JELines entity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountingDate** | **DateTimeOffset** | The JELines accounting date. | 
**ActivityDate** | **DateTimeOffset** | The actual date of the activity. Differs from the accounting date when creating journals that would occur in a closed period. | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**InstrumentId** | **string** | To indicate the instrument of the transaction that the JE line posted for, if applicable. | 
**InstrumentScope** | **string** | The scope in which the JELines instrument is in. | 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding properties which are part of the AccountingKey. | [optional] 
**TaxLotId** | **string** | The tax lot Id that JE line is impacting. | 
**GlCode** | **string** | Code of general ledger the JE lines posting to. | 
**Local** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**Base** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**PostingModuleId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**PostingRule** | **string** | The rule generating the JELinse. | 
**AsAtDate** | **DateTimeOffset** | The corresponding input date and time of the Transaction generating the JELine. | 
**ActivitiesDescription** | **string** | This would be the description of the business activities where these JE lines are posting for. | [optional] 
**SourceType** | **string** | So far are 4 types: LusidTxn, LusidValuation, Manual and External. | 
**SourceId** | **string** | For the Lusid Source Type this will be the txn Id. For the rest will be what the user populates. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Properties to add to the Abor. | [optional] 
**MovementName** | **string** | The name of the movement. | 
**HoldingType** | **string** | Defines the broad category holding within the portfolio. | 
**EconomicBucket** | **string** | Raw JE Line details of the economic bucket for the JE Line. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

