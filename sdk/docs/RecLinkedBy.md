# Lusid.Sdk.Model.RecLinkedBy
The item keys a link between two rec results was established on, per side.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | [**List&lt;RecLinkKey&gt;**](RecLinkKey.md) | The keys shared by the two results&#39; left-side items. May be empty. | 
**Right** | [**List&lt;RecLinkKey&gt;**](RecLinkKey.md) | The keys shared by the two results&#39; right-side items. May be empty. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<RecLinkKey> left = new List<RecLinkKey>();
List<RecLinkKey> right = new List<RecLinkKey>();

RecLinkedBy recLinkedByInstance = new RecLinkedBy(
    left: left,
    right: right);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
