# Lusid.Sdk.Model.MergerEventAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnnouncementDate** | **DateTimeOffset?** | The date the merger is announced. | [optional] 
**CashAndSecurityOfferElections** | [**List&lt;CashAndSecurityOfferElection&gt;**](CashAndSecurityOfferElection.md) | List of possible CashAndSecurityOfferElections for this merger event | [optional] 
**CashElections** | [**List&lt;CashOfferElection&gt;**](CashOfferElection.md) | List of possible CashOfferElections for this merger event | [optional] 
**ExDate** | **DateTimeOffset** | The first date on which the holder of record of the original shares has entitled ownership of the new shares. | 
**FractionalUnitsCashCurrency** | **string** | Optional. Used in calculating cash-in-lieu of fractional shares. | [optional] 
**FractionalUnitsCashPrice** | **decimal?** | Optional. Used in calculating cash-in-lieu of fractional shares. | [optional] 
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | 
**PaymentDate** | **DateTimeOffset** | Date on which the merger takes place. | 
**RecordDate** | **DateTimeOffset?** | Optional. Date you have to be the holder of record of the original shares in order to receive the new shares. | [optional] 
**SecurityElections** | [**List&lt;SecurityOfferElection&gt;**](SecurityOfferElection.md) | List of possible SecurityOfferElections for this merger event | [optional] 
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

