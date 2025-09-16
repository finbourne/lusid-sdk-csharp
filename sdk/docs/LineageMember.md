# Lusid.Sdk.Model.LineageMember

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **int** | Index to demonstrate position of lineage member in overall lineage | 
**Label** | **string** | Label of the step corresponding to this lineage member | 
**SubLabel** | **string** | SubLabel of the step corresponding to this lineage member | 
**InfoType** | **string** | Optional. Type of Information | [optional] 
**Information** | **string** | Optional. Information for the step corresponding to this lineage member, of type InfoType | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string label = "label";
string subLabel = "subLabel";
string infoType = "example infoType";
string information = "example information";

LineageMember lineageMemberInstance = new LineageMember(
    index: index,
    label: label,
    subLabel: subLabel,
    infoType: infoType,
    information: information);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
