# Lusid.Sdk.Model.PortfolioReconciliationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**EffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The effective date of the portfolio | 
**AsAt** | **DateTimeOffset?** | Optional. The AsAt date of the portfolio | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
DateTimeOrCutLabel effectiveAt = "effectiveAt";

PortfolioReconciliationRequest portfolioReconciliationRequestInstance = new PortfolioReconciliationRequest(
    portfolioId: portfolioId,
    effectiveAt: effectiveAt,
    asAt: asAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
