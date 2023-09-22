# Lusid.Sdk.Model.ExDividendConfiguration
Configure the ex-dividend periods for the instrument.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UseBusinessDays** | **bool** | Is the ex-dividend period counted in business days or calendar days.  Defaults to true if not set. | [optional] 
**ExDividendDays** | **int** | Number of days in the ex-dividend period.  If the settlement date falls in the ex-dividend period then the coupon paid is zero and the accrued interest is negative.  If set, this must be a non-negative number.  If not set, or set to 0, than there is no ex-dividend period. | 
**ReturnNegativeAccrued** | **bool** | Does the accrued interest go negative in the ex-dividend period, or does it go to zero.  Defaults to true if not set. | [optional] 
**ApplyThirty360PayDelay** | **bool** | Set this flag to true if the ex-dividend days represent a pay delay from the accrual end date in calendar  days under the 30/360 day count convention. The typical use case for this flag are Mortgage Backed Securities  with pay delay between 1 and 60 days, such as FreddieMac and FannieMae. If this flag is set, the useBusinessDays  setting will be ignored.  Defaults to false if not provided. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

