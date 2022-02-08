# Lusid.Sdk.Model.ReconciliationBreak
A reconciliation break

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentScope** | **string** | The scope in which the instrument lies. | 
**InstrumentUid** | **string** | Unique instrument identifier | 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Any other properties that comprise the Sub-Holding Key | 
**LeftUnits** | **decimal** | Units from the left hand side | 
**RightUnits** | **decimal** | Units from the right hand side | 
**DifferenceUnits** | **decimal** | Difference in units | 
**LeftCost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**RightCost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**DifferenceCost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**InstrumentProperties** | [**List&lt;Property&gt;**](Property.md) | Additional features relating to the instrument | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

