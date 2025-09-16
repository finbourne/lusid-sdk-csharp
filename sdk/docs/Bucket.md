# Lusid.Sdk.Model.Bucket

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaxLotId** | **string** | The identifier of the tax lot this bucket is for. | [optional] 
**MovementName** | **string** | The name of the movement. | [optional] 
**HoldingType** | **string** | The type of the holding. | [optional] 
**EconomicBucket** | **string** | The economic bucket. | [optional] 
**EconomicBucketComponent** | **string** | The economic bucket component. | [optional] 
**EconomicBucketVariant** | **string** | The economic bucket component. | [optional] 
**HoldingSign** | **string** | The holding sign. | [optional] 
**Local** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Base** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Units** | **decimal** | The units. | [optional] 
**ActivityDate** | **DateTimeOffset** | The activity date of the bucket. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string taxLotId = "example taxLotId";
string movementName = "example movementName";
string holdingType = "example holdingType";
string economicBucket = "example economicBucket";
string economicBucketComponent = "example economicBucketComponent";
string economicBucketVariant = "example economicBucketVariant";
string holdingSign = "example holdingSign";
CurrencyAndAmount? local = new CurrencyAndAmount();

CurrencyAndAmount? base = new CurrencyAndAmount();
decimal? units = "example units";

Bucket bucketInstance = new Bucket(
    taxLotId: taxLotId,
    movementName: movementName,
    holdingType: holdingType,
    economicBucket: economicBucket,
    economicBucketComponent: economicBucketComponent,
    economicBucketVariant: economicBucketVariant,
    holdingSign: holdingSign,
    local: local,
    base: base,
    units: units,
    activityDate: activityDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
