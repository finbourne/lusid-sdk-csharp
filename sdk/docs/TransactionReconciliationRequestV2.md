# Lusid.Sdk.Model.TransactionReconciliationRequestV2
Specification for the reconciliation request. Left and Right hand sides are constructed. Each consists of transactions from a portfolio  The results of this can then be compared to each other.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | [**AggregatedTransactionsRequest**](AggregatedTransactionsRequest.md) |  | 
**Right** | [**AggregatedTransactionsRequest**](AggregatedTransactionsRequest.md) |  | 
**LeftToRightMapping** | [**List&lt;ReconciliationLeftRightAddressKeyPair&gt;**](ReconciliationLeftRightAddressKeyPair.md) | The mapping from property keys requested by left aggregation to property keys on right hand side | [optional] 
**ComparisonRules** | [**List&lt;ReconciliationRule&gt;**](ReconciliationRule.md) | The set of rules to be used in comparing values. These are the rules that determine what constitutes a match.  The simplest is obviously an exact one-for-one comparison, but tolerances on numerical or date time values and  case-insensitive string comparison are supported amongst other types. | [optional] 
**PreserveKeys** | **List&lt;string&gt;** | List of keys to preserve (from rhs) in the diff. Used in conjunction with filtering/grouping.  If two values are equal, for a given key then the value is elided from the results. Setting it here  will preserve it (takes the values from the RHS and puts it into the line by line results). | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

AggregatedTransactionsRequest left = new AggregatedTransactionsRequest();
AggregatedTransactionsRequest right = new AggregatedTransactionsRequest();
List<ReconciliationLeftRightAddressKeyPair> leftToRightMapping = new List<ReconciliationLeftRightAddressKeyPair>();
List<ReconciliationRule> comparisonRules = new List<ReconciliationRule>();
List<string> preserveKeys = new List<string>();

TransactionReconciliationRequestV2 transactionReconciliationRequestV2Instance = new TransactionReconciliationRequestV2(
    left: left,
    right: right,
    leftToRightMapping: leftToRightMapping,
    comparisonRules: comparisonRules,
    preserveKeys: preserveKeys);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
