# Lusid.Sdk.Model.RevaluationProblem
A reason why a revaluation amount could not be populated.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | A machine-readable code identifying the type of problem (e.g. MissingFxRate, MissingBookedFxRate). | [optional] 
**Message** | **string** | A human-readable description of why the revaluation amount could not be populated. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "example code";
string message = "example message";

RevaluationProblem revaluationProblemInstance = new RevaluationProblem(
    code: code,
    message: message);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
