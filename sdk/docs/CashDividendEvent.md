# Lusid.Sdk.Model.CashDividendEvent
A cash distribution paid out to shareholders.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent | 
**GrossAmount** | **decimal** | The before tax amount for each share held being paid out to shareholders. | 
**PaymentDate** | **DateTimeOffset** | The date the company pays out dividends to shareholders. | 
**RecordDate** | **DateTimeOffset** | Date you have to be the holder of record in order to participate in the tender. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

