# Lusid.Sdk.Model.InlineValuationsReconciliationRequest
Specification for the reconciliation request. Left and Right hand sides are constructed. Each consists of a valuation of a inline set of instruments  using an inline aggregation request. The results of this can then be compared to each other. The difference, which is effectively a risk based  difference allows comparison of the effects of changing a recipe, valuation date, or (though it may or may not make logical sense) a set of instruments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | [**InlineValuationRequest**](InlineValuationRequest.md) |  | 
**Right** | [**InlineValuationRequest**](InlineValuationRequest.md) |  | 
**LeftToRightMapping** | [**List&lt;ReconciliationLeftRightAddressKeyPair&gt;**](ReconciliationLeftRightAddressKeyPair.md) | The mapping from property keys requested by left aggregation to property keys on right hand side | [optional] 
**PreserveKeys** | **List&lt;string&gt;** | List of keys to preserve (from rhs) in the diff. Used in conjunction with filtering/grouping | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

