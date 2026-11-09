# Lusid.Sdk.Model.TaxClassificationException
Why an instrument could not be classified, or a flip of the qualifying-investments test a reviewer must see.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kind** | **string** | MissingInputs, ConflictingSetup, ConflictingOverride or QualifyingInvestmentsCrossing. Available values: MissingInputs, ConflictingSetup, ConflictingOverride, QualifyingInvestmentsCrossing. | 
**Code** | **string** | The stable code of the exception, for filtering and routing. | 
**Message** | **string** | A description of why the instrument could not be classified or why the crossing was raised. | 

```csharp
using Lusid.Sdk.Model;
using System;

string kind = "kind";
string code = "code";
string message = "message";

TaxClassificationException taxClassificationExceptionInstance = new TaxClassificationException(
    kind: kind,
    code: code,
    message: message);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
