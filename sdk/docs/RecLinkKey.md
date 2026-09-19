# Lusid.Sdk.Model.RecLinkKey
One item key that established a link between two rec results: the key name and the identifier value both  results' items carried for it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key name: holdingId or transactionId. | 
**Value** | **string** | The identifier value both results&#39; items carried under the key. | 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";
string value = "value";

RecLinkKey recLinkKeyInstance = new RecLinkKey(
    key: key,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
