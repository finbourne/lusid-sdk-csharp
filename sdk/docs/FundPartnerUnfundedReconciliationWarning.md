# Lusid.Sdk.Model.FundPartnerUnfundedReconciliationWarning
A soft warning on an unfunded commitment statement: the statement is still produced, with a caveat.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The warning. PeriodStartsBeforeAdmission: the period opens before the partner was admitted, so the opening balances are zero and the admission commitment is counted as a commitment change. | 
**AdmittedOn** | **DateTimeOffset?** | For PeriodStartsBeforeAdmission, the date the partner was admitted to the fund. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";

FundPartnerUnfundedReconciliationWarning fundPartnerUnfundedReconciliationWarningInstance = new FundPartnerUnfundedReconciliationWarning(
    code: code,
    admittedOn: admittedOn);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
