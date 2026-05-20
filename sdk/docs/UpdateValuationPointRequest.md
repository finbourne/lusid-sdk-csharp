# Lusid.Sdk.Model.UpdateValuationPointRequest
A definition for the period you wish to close

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiaryEntryCode** | **string** | Unique code for the Valuation Point. | 
**DiaryEntryVariant** | **string** | Optional variant code. Only required when it is necessary to choose between scenarios with multiple estimates. | 
**Name** | **string** | Identifiable Name assigned to the Valuation Point. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the diary entry. | [optional] 
**ApplyClearDown** | **bool?** | Defaults to false. Set to true if you want that the closed period to have the clear down applied. | [optional] 
**UpdateInclusionDateNavAdjustments** | **bool?** | Defaults to false. Set to true if you have the required licence and want the InclusionDate property values to be used to determine whether items should be automatically included in the post close activities. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string diaryEntryCode = "diaryEntryCode";
string diaryEntryVariant = "diaryEntryVariant";
string name = "example name";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
bool? applyClearDown = //"True";
bool? updateInclusionDateNavAdjustments = //"True";

UpdateValuationPointRequest updateValuationPointRequestInstance = new UpdateValuationPointRequest(
    diaryEntryCode: diaryEntryCode,
    diaryEntryVariant: diaryEntryVariant,
    name: name,
    properties: properties,
    applyClearDown: applyClearDown,
    updateInclusionDateNavAdjustments: updateInclusionDateNavAdjustments);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
