# Lusid.Sdk.Model.PaymentDetailsReference
A pointer to a Payment Details relational dataset series for a payor or payee entity.  No PII is stored here — bank account details are resolved at read time from the referenced series.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SeriesScope** | **string** | The scope of the relational datapoint. May differ from the scope of the dataset definition. | 
**ApplicableEntity** | [**PaymentDetailsApplicableEntity**](PaymentDetailsApplicableEntity.md) |  | 
**SeriesIdentifiers** | [**PaymentDetailsSeriesIdentifiers**](PaymentDetailsSeriesIdentifiers.md) |  | 
**EffectiveDate** | **DateTimeOffset** | The effective date of the relational datapoint observation to retrieve. ISO 8601 datetime. | 
**AsAtDate** | **DateTimeOffset** | The as-at date of the relational datapoint observation to retrieve. ISO 8601 datetime. | 

```csharp
using Lusid.Sdk.Model;
using System;

string seriesScope = "seriesScope";
PaymentDetailsApplicableEntity applicableEntity = new PaymentDetailsApplicableEntity();
PaymentDetailsSeriesIdentifiers seriesIdentifiers = new PaymentDetailsSeriesIdentifiers();

PaymentDetailsReference paymentDetailsReferenceInstance = new PaymentDetailsReference(
    seriesScope: seriesScope,
    applicableEntity: applicableEntity,
    seriesIdentifiers: seriesIdentifiers,
    effectiveDate: effectiveDate,
    asAtDate: asAtDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
