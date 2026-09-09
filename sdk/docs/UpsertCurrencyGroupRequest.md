# Lusid.Sdk.Model.UpsertCurrencyGroupRequest
Request body for creating or updating a currency group.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the currency group. This uniquely identifies the currency group within the tenant. | 
**DisplayName** | **string** | The name of the currency group. | 
**Description** | **string** | A description for the currency group. | [optional] 
**MajorUnitCurrency** | **string** | The three-letter, case-sensitive currency code of the group&#39;s major unit, e.g. GBP for the sterling group. | 
**CirculationDomain** | **string** | The domain in which the group&#39;s currencies circulate, e.g. an ISO 3166 country code. | [optional] 
**MinorUnits** | [**List&lt;CurrencyGroupMinorUnit&gt;**](CurrencyGroupMinorUnit.md) | The minor unit currencies belonging to this currency group. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "displayName";
string description = "example description";
string majorUnitCurrency = "majorUnitCurrency";
string circulationDomain = "example circulationDomain";
List<CurrencyGroupMinorUnit> minorUnits = new List<CurrencyGroupMinorUnit>();

UpsertCurrencyGroupRequest upsertCurrencyGroupRequestInstance = new UpsertCurrencyGroupRequest(
    code: code,
    displayName: displayName,
    description: description,
    majorUnitCurrency: majorUnitCurrency,
    circulationDomain: circulationDomain,
    minorUnits: minorUnits);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
