# Lusid.Sdk.Model.StockSplitEventAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentDate** | **DateTimeOffset** | Date on which the stock split takes effect. | 
**ExDate** | **DateTimeOffset** | The first date on which the shares will trade at the post-split price. | 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 
**RecordDate** | **DateTimeOffset?** | Date you have to be the holder of record in order to receive the additional shares. | [optional] 
**AnnouncementDate** | **DateTimeOffset?** | Date the stock split was announced. | [optional] 
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

