# Lusid.Sdk.Model.MarginRunRequest
A request to value collateral agreements for a business date and publish their margin calls.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The business date, datetime or cut label to value the agreements at. | 
**AsAt** | **DateTimeOffset?** | The asAt datetime to read agreements, portfolios and market data at. Defaults to the current LUSID system datetime if not specified. | [optional] 
**AgreementFilter** | **string** | An expression selecting the collateral agreements to run, in the same syntax as listing collateral agreements. Every agreement the caller may calculate margin for is run if not specified. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DateTimeOrCutLabel effectiveAt = "effectiveAt";
string agreementFilter = "example agreementFilter";

MarginRunRequest marginRunRequestInstance = new MarginRunRequest(
    effectiveAt: effectiveAt,
    asAt: asAt,
    agreementFilter: agreementFilter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
