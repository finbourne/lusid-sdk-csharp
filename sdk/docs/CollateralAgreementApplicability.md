# Lusid.Sdk.Model.CollateralAgreementApplicability
The portfolios a collateral agreement currently covers, according to its applicability filter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**ApplicabilityFilter** | **string** | The applicability filter that was evaluated. Only its clauses on portfolio fields are applied to select the portfolios returned. | 
**Portfolios** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The portfolios matching the applicability filter, up to the requested limit. | 
**HasMorePortfolios** | **bool** | Whether more portfolios match the filter than were returned. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string applicabilityFilter = "applicabilityFilter";
List<ResourceId> portfolios = new List<ResourceId>();
bool hasMorePortfolios = //"True";

CollateralAgreementApplicability collateralAgreementApplicabilityInstance = new CollateralAgreementApplicability(
    id: id,
    applicabilityFilter: applicabilityFilter,
    portfolios: portfolios,
    hasMorePortfolios: hasMorePortfolios);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
