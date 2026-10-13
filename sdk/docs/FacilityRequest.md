# Lusid.Sdk.Model.FacilityRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the Facility, unique within the Fund. | 
**DisplayName** | **string** | The name of the Facility. | 
**Description** | **string** | A description for the Facility. | [optional] 
**Lender** | **string** | The name of the lender providing the Facility. | 
**Limit** | **decimal** | The committed limit of the Facility. Must be greater than zero. | 
**Currency** | **string** | The three-letter currency code in which the Facility is denominated. | 
**RateReference** | **string** | The reference rate the Facility interest is based on, for example SOFR. Optional. | [optional] 
**Margin** | **decimal** | The margin over the reference rate, expressed as a decimal. Must be zero or greater. | 
**CommitmentFeeRate** | **decimal** | The annual commitment fee rate charged on the undrawn balance, expressed as a decimal. Must be zero or greater. | 
**DayCountConvention** | **string** | The day count convention used to accrue interest. One of: Act360, Act365, Act365F, Thirty360. | 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "displayName";
string description = "example description";
string lender = "lender";decimal limit = "limit";

string currency = "currency";
string rateReference = "example rateReference";decimal margin = "margin";
decimal commitmentFeeRate = "commitmentFeeRate";

string dayCountConvention = "dayCountConvention";

FacilityRequest facilityRequestInstance = new FacilityRequest(
    code: code,
    displayName: displayName,
    description: description,
    lender: lender,
    limit: limit,
    currency: currency,
    rateReference: rateReference,
    margin: margin,
    commitmentFeeRate: commitmentFeeRate,
    dayCountConvention: dayCountConvention);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
