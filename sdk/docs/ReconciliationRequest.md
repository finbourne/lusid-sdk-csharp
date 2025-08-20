# Lusid.Sdk.Model.ReconciliationRequest
Specification for the reconciliation request. Left and Right hand sides are constructed. Each consists of a valuation of a portfolio using an aggregation request. The results of this can then be compared to each other. The difference, which is effectively a risk based difference allows comparison of the effects of changing a recipe, valuation date, or (though it may or may not make logical sense) a portfolio. For instance, one might look at the difference in risk caused by the addition of transaction to a portfolio, or through changing the valuation methodology or system.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | [**ValuationRequest**](ValuationRequest.md) |  | 
**Right** | [**ValuationRequest**](ValuationRequest.md) |  | 
**LeftToRightMapping** | [**List&lt;ReconciliationLeftRightAddressKeyPair&gt;**](ReconciliationLeftRightAddressKeyPair.md) | The mapping from property keys requested by left aggregation to property keys on right hand side | [optional] 
**ComparisonRules** | [**List&lt;ReconciliationRule&gt;**](ReconciliationRule.md) | The set of rules to be used in comparing values. These are the rules that determine what constitutes a match. The simplest is obviously an exact one-for-one comparison, but tolerances on numerical or date time values and case-insensitive string comparison are supported amongst other types. | [optional] 
**PreserveKeys** | **List&lt;string&gt;** | List of keys to preserve (from rhs) in the diff. Used in conjunction with filtering/grouping. If two values are equal, for a given key then the value is elided from the results. Setting it here will preserve it (takes the values from the RHS and puts it into the line by line results). | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

