# Lusid.Sdk.Model.RequestedChanges

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttributeCount** | **int** | Number of attributes staged change applies to | [optional] 
**AttributeNames** | **List&lt;string&gt;** | Names of the attributes the staged change applies to. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> attributeNames = new List<string>();

RequestedChanges requestedChangesInstance = new RequestedChanges(
    attributeCount: attributeCount,
    attributeNames: attributeNames);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
