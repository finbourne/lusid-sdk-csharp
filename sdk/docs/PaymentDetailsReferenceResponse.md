# Lusid.Sdk.Model.PaymentDetailsReferenceResponse
Response representation of a Payment Details reference. Extends the request shape with  a system-populated relational dataset definition identifier.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RelationalDatasetDefinitionId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**SeriesScope** | **string** | The scope of the relational datapoint. May differ from the scope of the dataset definition. | 
**ApplicableEntity** | [**PaymentDetailsApplicableEntity**](PaymentDetailsApplicableEntity.md) |  | 
**SeriesIdentifiers** | [**PaymentDetailsSeriesIdentifiers**](PaymentDetailsSeriesIdentifiers.md) |  | 
**EffectiveDate** | **DateTimeOffset** | The effective date of the relational datapoint observation to retrieve. ISO 8601 datetime. | 
**AsAtDate** | **DateTimeOffset** | The as-at date of the relational datapoint observation to retrieve. ISO 8601 datetime. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? relationalDatasetDefinitionId = new ResourceId();

string seriesScope = "seriesScope";
PaymentDetailsApplicableEntity applicableEntity = new PaymentDetailsApplicableEntity();
PaymentDetailsSeriesIdentifiers seriesIdentifiers = new PaymentDetailsSeriesIdentifiers();

PaymentDetailsReferenceResponse paymentDetailsReferenceResponseInstance = new PaymentDetailsReferenceResponse(
    relationalDatasetDefinitionId: relationalDatasetDefinitionId,
    seriesScope: seriesScope,
    applicableEntity: applicableEntity,
    seriesIdentifiers: seriesIdentifiers,
    effectiveDate: effectiveDate,
    asAtDate: asAtDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
