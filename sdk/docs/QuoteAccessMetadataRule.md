# Lusid.Sdk.Model.QuoteAccessMetadataRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**QuoteAccessMetadataRuleId**](QuoteAccessMetadataRuleId.md) |  | 
**Metadata** | **Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;** | The access control metadata to assign to quotes that match the identifier | 

```csharp
using Lusid.Sdk.Model;
using System;

QuoteAccessMetadataRuleId id = new QuoteAccessMetadataRuleId();
Dictionary<string, List<AccessMetadataValue>> metadata = new Dictionary<string, List<AccessMetadataValue>>();

QuoteAccessMetadataRule quoteAccessMetadataRuleInstance = new QuoteAccessMetadataRule(
    id: id,
    metadata: metadata);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
