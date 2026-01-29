# Lusid.Sdk.Model.UpsertValuationPointRequest
A definition for the period you wish to close

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiaryEntryCode** | **string** | Unique code for the Valuation Point. | 
**DiaryEntryVariant** | **string** | Optional variant code. Only required when it is necessary to choose between scenarios with multiple estimates. | [optional] 
**Name** | **string** | Identifiable Name assigned to the Valuation Point. | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective time of the diary entry. | 
**QueryAsAt** | **DateTimeOffset?** | The query time of the diary entry. Defaults to latest. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the diary entry. | [optional] 
**ApplyClearDown** | **bool** | Defaults to false. Set to true if you want that the closed period to have the clear down applied. | [optional] 
**HoldingsAsAtOverride** | **DateTimeOffset?** | The optional AsAt Override to use for building holdings in the Valuation Point. Defaults to Latest. | [optional] 
**ValuationsAsAtOverride** | **DateTimeOffset?** | The optional AsAt Override to use for performing valuations in the Valuation Point. Defaults to Latest. | [optional] 
**UpdateInclusionDateNavAdjustments** | **bool** | Defaults to false. Set to true if you have the required licence and want the InclusionDate property values to be used to determine whether items should be automatically included in the post close activities. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string diaryEntryCode = "diaryEntryCode";
string diaryEntryVariant = "example diaryEntryVariant";
string name = "example name";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
bool applyClearDown = //"True";
bool updateInclusionDateNavAdjustments = //"True";

UpsertValuationPointRequest upsertValuationPointRequestInstance = new UpsertValuationPointRequest(
    diaryEntryCode: diaryEntryCode,
    diaryEntryVariant: diaryEntryVariant,
    name: name,
    effectiveAt: effectiveAt,
    queryAsAt: queryAsAt,
    properties: properties,
    applyClearDown: applyClearDown,
    holdingsAsAtOverride: holdingsAsAtOverride,
    valuationsAsAtOverride: valuationsAsAtOverride,
    updateInclusionDateNavAdjustments: updateInclusionDateNavAdjustments);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
