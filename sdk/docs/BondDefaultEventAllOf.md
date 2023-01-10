# Lusid.Sdk.Model.BondDefaultEventAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal** | Percentage or amount of each share held to be given to shareholders. | 
**CouponPaidDate** | **DateTimeOffset** | Date that the missed coupon is paid if payment is made within grace period. | 
**DefaultStatus** | **string** | The status of the bond default (i.e., technical or default)    Supported string (enumeration) values are: [Technical, Default]. | 
**DefaultType** | **string** | The type of the default. (coupon payment, principal payment, covenant ...)    Supported string (enumeration) values are: [CouponPayment, CouponAndPrincipalPayment, PrincipalPayment, Covenant, Bankruptcy, BuyBackOption]. | 
**GraceEndDate** | **DateTimeOffset** | Date the grace period for making coupon payment ends. | 
**PaymentDate** | **DateTimeOffset** | The date the coupon payment was missed. | 
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

