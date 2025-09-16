# Lusid.Sdk.Model.ReferenceListRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Name** | **string** | The name of the reference list. | 
**Description** | **string** | The description of the reference list. | [optional] 
**Tags** | **List&lt;string&gt;** | The tags associated with the reference list. | [optional] 
**ReferenceList** | [**ReferenceList**](ReferenceList.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string name = "name";
string description = "example description";
List<string> tags = new List<string>();
ReferenceList referenceList = new ReferenceList();

ReferenceListRequest referenceListRequestInstance = new ReferenceListRequest(
    id: id,
    name: name,
    description: description,
    tags: tags,
    referenceList: referenceList);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
