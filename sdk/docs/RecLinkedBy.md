# Lusid.Sdk.Model.RecLinkedBy
The item pairings a link between two rec results was established on, per side.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | [**List&lt;RecResultLinkKey&gt;**](RecResultLinkKey.md) | The pairings between the two results&#39; left-side items, one entry per pairing. May be empty. | 
**Right** | [**List&lt;RecResultLinkKey&gt;**](RecResultLinkKey.md) | The pairings between the two results&#39; right-side items, one entry per pairing. May be empty. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<RecResultLinkKey> left = new List<RecResultLinkKey>();
List<RecResultLinkKey> right = new List<RecResultLinkKey>();

RecLinkedBy recLinkedByInstance = new RecLinkedBy(
    left: left,
    right: right);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
