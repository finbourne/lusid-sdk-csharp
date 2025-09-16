# Lusid.Sdk.Model.CreditRating
Object describing a credit rating,  which assesses the stability and credit worthiness of a legal entity  and hence its likelihood of defaulting on its outstanding obligations (typically debt).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RatingSource** | **string** | The provider of the credit rating, which will typically be an agency such as Moody&#39;s or Standard and Poor. | 
**Rating** | **string** | The credit rating provided by the rating source. This would expected to be consistent with the rating scheme of that agency/source. | 

```csharp
using Lusid.Sdk.Model;
using System;

string ratingSource = "ratingSource";
string rating = "rating";

CreditRating creditRatingInstance = new CreditRating(
    ratingSource: ratingSource,
    rating: rating);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
