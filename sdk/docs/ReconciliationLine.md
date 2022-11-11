# Lusid.Sdk.Model.ReconciliationLine
In evaluating a left and right hand side holding or valuation set, two data records result. These are then compared based on a set of  rules. This results in either a match or failure to match. If there is a match both left and right will be present, otherwise one will not.  A difference will be present if a match was calculated.  The options used in comparison may result in elision of results where an exact or tolerable match is made.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | **Dictionary&lt;string, Object&gt;** | Left hand side of the comparison | [optional] 
**Right** | **Dictionary&lt;string, Object&gt;** | Right hand side of the comparison | [optional] 
**Difference** | **Dictionary&lt;string, Object&gt;** | Difference between LHS and RHS of comparison | [optional] 
**ResultComparison** | **Dictionary&lt;string, Object&gt;** | The logical or semantic description of the difference, e.g. \&quot;Matches\&quot; or \&quot;MatchesWithTolerance\&quot; or \&quot;Failed\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

