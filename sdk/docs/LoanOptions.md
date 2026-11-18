# Lusid.Sdk.Model.LoanOptions
Options for loan facilities and their contracts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnhancedRounding** | **bool** | If true, loan facility figures are kept at full precision. A principal repayment that pays a contract down to  within its currency&#39;s smallest unit (for example, under a cent) repays it in full: the leftover below that  precision, the contract&#39;s remaining limit and the undrawn commitment are written off, so the position closes  rather than staying open with a fraction of a cent, and a term facility repaid to that precision has its  remaining units and limit booked out. A facility trade&#39;s share of each contract is also computed without  rounding dust. If false, these figures are calculated as before. Defaults to false. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool enhancedRounding = //"True";

LoanOptions loanOptionsInstance = new LoanOptions(
    enhancedRounding: enhancedRounding);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
