# Lusid.Sdk.Model.UpdateTimelineRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the Timeline. | 
**Description** | **string** | A description for the Timeline. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The Timelines properties. These will be from the &#39;Timeline&#39; domain. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
Dictionary<string, Property> properties = new Dictionary<string, Property>();

UpdateTimelineRequest updateTimelineRequestInstance = new UpdateTimelineRequest(
    displayName: displayName,
    description: description,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
