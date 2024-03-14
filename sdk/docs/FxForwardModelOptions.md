# Lusid.Sdk.Model.FxForwardModelOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelOptionsType** | **string** | The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions | 
**ForwardRateObservableType** | **string** | The available values are: ForwardPoints, ForwardRate, RatesCurve, FxForwardCurve, Invalid | 
**DiscountingMethod** | **string** | The available values are: Standard, ConstantTimeValueOfMoney, Invalid | 
**ConvertToReportCcy** | **bool** | Convert all FX flows to the report currency  By setting this all FX forwards will be priced using Forward Curves that have Report Currency as the base. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

