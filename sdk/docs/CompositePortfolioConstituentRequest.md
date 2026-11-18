# Lusid.Sdk.Model.CompositePortfolioConstituentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**FromDate** | **DateTimeOffset?** | The effective date from which the constituent contributes to the composite portfolio. Defaults to the constituent&#39;s creation date, and must not be later than it, because a constituent contributes its whole history. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();

CompositePortfolioConstituentRequest compositePortfolioConstituentRequestInstance = new CompositePortfolioConstituentRequest(
    portfolioId: portfolioId,
    fromDate: fromDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
