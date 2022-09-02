# Lusid.Sdk.Model.Compounding
The compounding settings used on interest rate.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CalculationShiftMethod** | **string** | Defines which resets and day counts are used for the rate calculation    Supported string (enumeration) values are: [Lookback, NoShift, ObservationPeriodShift, Lockout]. | [optional] 
**CompoundingMethod** | **string** | If the interest rate is simple or compounded.    Supported string (enumeration) values are: [Average, Compounded]. | 
**ResetFrequency** | **string** | The interest payment frequency. | 
**Shift** | **int** | Defines the number of days to lockout or shift observation period by - should be a non-negative integer | [optional] 
**SpreadCompoundingMethod** | **string** | Defines how the computed leg spread is applied to compounded rate.  It applies only when CompoundingMethod &#x3D; â€˜Compoundedâ€˜.    Supported string (enumeration) values are: [Straight, IsdaCompounding, NoCompounding, SpreadExclusive, IsdaFlatCompounding, Flat, None]. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

