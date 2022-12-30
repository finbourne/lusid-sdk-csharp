# Lusid.Sdk.Model.ReconcileStringRule
Comparison of string values

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleType** | **string** | The available values are: ReconcileNumericRule, ReconcileDateTimeRule, ReconcileStringRule, ReconcileExact | 
**ComparisonType** | **string** | The available values are: Exact, Contains, CaseInsensitive, ContainsAnyCase, IsOneOf | 
**OneOfCandidates** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | For cases of \&quot;IsOneOf\&quot; a set is required to match values against.  Fuzzy matching of strings against one of a set. There can be cases where systems \&quot;A\&quot; and \&quot;B\&quot; might use different terms for the same logical entity. A common case would be  comparison of something like a day count fraction where some convention like the \&quot;actual 365\&quot; convention might be represented as one of [\&quot;A365\&quot;, \&quot;Act365\&quot;, \&quot;Actual365\&quot;] or similar.  This is to allow this kind of fuzzy matching of values. Note that as this is exhaustive comparison across sets it will be slow and should therefore be used sparingly. | [optional] 
**AppliesTo** | [**AggregateSpec**](AggregateSpec.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

