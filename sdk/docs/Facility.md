# Lusid.Sdk.Model.Facility

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**FacilityCode** | **string** | The code of the Facility, unique within the Fund. | [optional] 
**DisplayName** | **string** | The name of the Facility. | 
**Description** | **string** | A description for the Facility. | [optional] 
**Lender** | **string** | The name of the lender providing the Facility. | 
**Limit** | **decimal** | The committed limit of the Facility. Must be greater than zero. | 
**Currency** | **string** | The three-letter currency code in which the Facility is denominated. | 
**RateReference** | **string** | The reference rate the Facility interest is based on, for example SOFR. Optional. | [optional] 
**Margin** | **decimal** | The margin over the reference rate, expressed as a decimal. Must be zero or greater. | 
**CommitmentFeeRate** | **decimal** | The annual commitment fee rate charged on the undrawn balance, expressed as a decimal. Must be zero or greater. | 
**DayCountConvention** | **string** | The day count convention used to accrue interest. One of: Act360, Act365, Act365F, Thirty360. | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
string facilityCode = "example facilityCode";
string displayName = "displayName";
string description = "example description";
string lender = "lender";decimal limit = "limit";

string currency = "currency";
string rateReference = "example rateReference";decimal margin = "margin";
decimal commitmentFeeRate = "commitmentFeeRate";

string dayCountConvention = "dayCountConvention";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

Facility facilityInstance = new Facility(
    href: href,
    facilityCode: facilityCode,
    displayName: displayName,
    description: description,
    lender: lender,
    limit: limit,
    currency: currency,
    rateReference: rateReference,
    margin: margin,
    commitmentFeeRate: commitmentFeeRate,
    dayCountConvention: dayCountConvention,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
