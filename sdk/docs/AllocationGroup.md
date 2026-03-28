# Lusid.Sdk.Model.AllocationGroup

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Classes** | [**List&lt;AllocationGroupClass&gt;**](AllocationGroupClass.md) | An optional list of share classes that belong to this group. Each entry must reference a ShareClass already present on the Fund. You can provide this or the Formula, but not both. | [optional] 
**Code** | **string** | The unique code for the Allocation Group. Must be unique within the Fund. | 
**Name** | **string** | The display name of the Allocation Group. | 
**Description** | **string** | An optional description for the Allocation Group. | [optional] 
**ShareClassShortCode** | **string** | The short code that identifies the Allocation Group. | 
**ApportionmentMethodProperty** | [**ApportionmentMethodProperty**](ApportionmentMethodProperty.md) |  | [optional] 
**Formula** | **string** | An optional filter expression used to define which classes belong to this group, based on fund grouping criteria. You can provide this or the Classes, but not both. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<AllocationGroupClass> classes = new List<AllocationGroupClass>();
string code = "code";
string name = "name";
string description = "example description";
string shareClassShortCode = "shareClassShortCode";
ApportionmentMethodProperty? apportionmentMethodProperty = new ApportionmentMethodProperty();

string formula = "example formula";

AllocationGroup allocationGroupInstance = new AllocationGroup(
    classes: classes,
    code: code,
    name: name,
    description: description,
    shareClassShortCode: shareClassShortCode,
    apportionmentMethodProperty: apportionmentMethodProperty,
    formula: formula);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
