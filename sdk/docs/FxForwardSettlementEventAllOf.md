# Lusid.Sdk.Model.FxForwardSettlementEventAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaturityDate** | **DateTimeOffset** | Maturity date of the forward | 
**DomAmountPerUnit** | **decimal** | Amount per unit in the DomCcy (domestic currency) | 
**DomCcy** | **string** | The domestic currency of the forward | 
**FgnAmountPerUnit** | **decimal** | Amount per unit in the FgnCcy (foreign currency) | 
**FgnCcy** | **string** | The foreign currency of the forward. | 
**IsNdf** | **bool** | Is this settlement corresponding to a deliverable forward, or an NDF | 
**FixingDate** | **DateTimeOffset?** | Optional.  Required if the event is an NDF (i.e. if IsNdf &#x3D; true).  Date of the FxRate fixings. | [optional] 
**SettlementCcy** | **string** | Optional.  Required if the event is an NDF (i.e. if IsNdf &#x3D; true).  May be set to either DomCcy or FgnCcy, or a third currency. | [optional] 
**CashFlowPerUnit** | **decimal?** | Optional.  Required if the event is an NDF (i.e. if IsNdf &#x3D; true).  CashFlow per unit.  Paid in the SettlementCcy. | [optional] 
**DomesticToForeignRate** | **decimal?** | Domestic currency to foreign currency FX rate.  Not required, only used to override quotes. | [optional] 
**DomesticToSettlementRate** | **decimal?** | Domestic currency to settlement currency FX rate  Not required, only used to override quotes. | [optional] 
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

