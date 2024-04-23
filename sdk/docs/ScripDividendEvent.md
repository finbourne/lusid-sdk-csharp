# Lusid.Sdk.Model.ScripDividendEvent
A scrip dividend issued to shareholders.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent | 
**AnnouncementDate** | **DateTimeOffset?** | Date on which the dividend was announced / declared. | [optional] 
**ExDate** | **DateTimeOffset** | The first business day on which the dividend is not owed to the buying party.  Typically this is T-1 from the RecordDate. | 
**RecordDate** | **DateTimeOffset?** | Date you have to be the holder of record in order to participate in the tender. | [optional] 
**PaymentDate** | **DateTimeOffset** | The date the company pays out dividends to shareholders. | 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

