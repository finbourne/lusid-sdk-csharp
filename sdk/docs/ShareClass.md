# Lusid.Sdk.Model.ShareClass

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The unique code for the Share Class. Must be unique within the Fund. | 
**Name** | **string** | The display name of the Share Class. | 
**Description** | **string** | An optional description for the Share Class. | [optional] 
**ShareClassShortCode** | **string** | A short code that uniquely identifies the share class within the Fund. | 
**LaunchPrice** | **decimal?** | The launch price set when a shareclass is added to the fund. Defaults to 1. | [optional] 
**LaunchDate** | **DateTimeOffset?** | The launch date set when a shareclass is added to the fund. Defaults to Fund Inception Date. | [optional] 
**ApportionmentFactor** | **decimal?** | The weighting factor used for apportionment across this share class. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | An optional set of properties to attach to the auto-created Instrument. Only applied when createInstrument is true. | [optional] 
**FundShareClassType** | **string** | The Type of Share Class. Supported values are: Unitised / Non-Unitised / Series / Private Equity / Partnership. | 
**DistributionType** | **string** | The type of distribution the ShareClass will calculate. Supported values are: Income, Accumulation. | 
**DomCcy** | **string** | The domestic currency of the ShareClass instrument. | 
**TradingConventions** | [**TradingConventions**](TradingConventions.md) |  | [optional] 
**UnitsPrecision** | **int?** | Decimal places for the share class units. | [optional] 
**PricePrecision** | **int?** | Decimal places for the share class price. | [optional] 
**RoundingConventions** | [**List&lt;SimpleRoundingConvention&gt;**](SimpleRoundingConvention.md) | Rounding conventions used for the ShareClass quotes. | [optional] 
**RoundingConventionsUnits** | [**List&lt;SimpleRoundingConvention&gt;**](SimpleRoundingConvention.md) | Rounding conventions used for the ShareClass units. | [optional] 
**TimeZoneConventions** | [**TimeZoneConventions**](TimeZoneConventions.md) |  | [optional] 
**DistributionPaymentType** | **string** | The tax treatment applied to distributions. Supported values are: Gross, Net. | [optional] 
**Hedging** | **string** | Indicates whether the ShareClass applies currency hedging. Supported values are: Invalid, None, ApplyHedging. | 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string name = "name";
string description = "example description";
string shareClassShortCode = "shareClassShortCode";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
string fundShareClassType = "fundShareClassType";
string distributionType = "distributionType";
string domCcy = "domCcy";
TradingConventions? tradingConventions = new TradingConventions();

List<SimpleRoundingConvention> roundingConventions = new List<SimpleRoundingConvention>();
List<SimpleRoundingConvention> roundingConventionsUnits = new List<SimpleRoundingConvention>();
TimeZoneConventions? timeZoneConventions = new TimeZoneConventions();

string distributionPaymentType = "example distributionPaymentType";
string hedging = "hedging";

ShareClass shareClassInstance = new ShareClass(
    code: code,
    name: name,
    description: description,
    shareClassShortCode: shareClassShortCode,
    launchPrice: launchPrice,
    launchDate: launchDate,
    apportionmentFactor: apportionmentFactor,
    properties: properties,
    fundShareClassType: fundShareClassType,
    distributionType: distributionType,
    domCcy: domCcy,
    tradingConventions: tradingConventions,
    unitsPrecision: unitsPrecision,
    pricePrecision: pricePrecision,
    roundingConventions: roundingConventions,
    roundingConventionsUnits: roundingConventionsUnits,
    timeZoneConventions: timeZoneConventions,
    distributionPaymentType: distributionPaymentType,
    hedging: hedging);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
