# Lusid.Sdk.Model.InstrumentPaymentDiaryRow
An individual row containing details of a single cashflow in the diary.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quantity** | **decimal** | The quantity (amount) that will be paid. Note that this can be empty if the payment is in the future and a model is used that cannot estimate it. | [optional] 
**Currency** | **string** | The payment currency of the cash flow. | [optional] 
**PaymentDate** | **DateTimeOffset** | The date at which the given cash flow is due to be paid. | [optional] 
**PayOrReceive** | **string** | Does the cash flow belong to the Pay or Receive leg. | [optional] 
**AccrualStart** | **DateTimeOffset** | The date on which accruals start for this cashflow. | [optional] 
**AccrualEnd** | **DateTimeOffset** | The date on which accruals end for this cashflow. | [optional] 
**CashFlowType** | **string** | The type of cashflow. | [optional] 
**IsCashFlowDetermined** | **bool** | Is the cashflow determined as of the effective date time. | [optional] 
**IsCashFlowHistoric** | **bool** | Has the cashflow been paid, i.e. has it become a historic cashflow, as of the date and time pointed to be effectiveAt. | [optional] 
**DiscountFactor** | **decimal** | Weighting factor to discount cashflow to the present value. | [optional] 
**DiscountedExpectedCashFlowAmount** | **decimal** | The expected cashflow amount taking into account the discount factor. | [optional] 
**DayCountFraction** | **decimal?** | The day count fraction, if appropriate. | [optional] 
**ForwardRate** | **decimal?** | Forward rate for cash flow if appropriate. (as in for a rates fixed or floating leg) | [optional] 
**ResetRate** | **decimal?** | The value of the reset, if any. | [optional] 
**Spread** | **decimal?** | The spread that exists on the payoff. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

