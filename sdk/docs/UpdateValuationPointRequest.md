# Lusid.Sdk.Model.UpdateValuationPointRequest
A definition for the period you wish to close

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ValuationPointCode** | **string** | Unique code for the Valuation Point. | 
**Variant** | **string** | Optional variant code. Only required when it is necessary to choose between scenarios with multiple estimates. | [optional] 
**Name** | **string** | Identifiable Name assigned to the Valuation Point. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the diary entry. | [optional] 
**ApplyClearDown** | **bool?** | Defaults to null. Set to true if you want the closed period to have the clear down applied. | [optional] 
**UpdateInclusionDateNavAdjustments** | **bool?** | Defaults to null. Set to true if you have the required licence and want the InclusionDate property values to be used to determine whether items should be automatically included in the post close activities. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string valuationPointCode = "valuationPointCode";
string variant = "example variant";
string name = "example name";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
bool? applyClearDown = //"True";
bool? updateInclusionDateNavAdjustments = //"True";

UpdateValuationPointRequest updateValuationPointRequestInstance = new UpdateValuationPointRequest(
    valuationPointCode: valuationPointCode,
    variant: variant,
    name: name,
    properties: properties,
    applyClearDown: applyClearDown,
    updateInclusionDateNavAdjustments: updateInclusionDateNavAdjustments);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
