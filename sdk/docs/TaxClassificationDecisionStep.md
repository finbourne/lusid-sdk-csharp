# Lusid.Sdk.Model.TaxClassificationDecisionStep
One question the decision tree asked on the way to the leaf.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Order** | **int** | The position of the step in the decision trace, starting at 1. | 
**Rule** | **string** | The decision-tree rule the step evaluated. | 
**Question** | **string** | The question the rule asked of the inputs. | 
**Answer** | **string** | The answer the rule took. | 

```csharp
using Lusid.Sdk.Model;
using System;

string rule = "rule";
string question = "question";
string answer = "answer";

TaxClassificationDecisionStep taxClassificationDecisionStepInstance = new TaxClassificationDecisionStep(
    order: order,
    rule: rule,
    question: question,
    answer: answer);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
