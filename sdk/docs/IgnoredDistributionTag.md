# Lusid.Sdk.Model.IgnoredDistributionTag
A distribution character tag the run did not pool by, on one account's lines.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GlCode** | **string** | The general ledger account of the tagged lines. | 
**LineCount** | **int** | How many of the account&#39;s lines carried the ignored tag. | 
**Amount** | **decimal** | The journal amount of the tagged lines, debits positive. | 
**Reason** | **string** | Why the tag was ignored. Available values: NotPnlLine (the tagged line is not a profit and loss line, such as the cash leg of a tagged journal), CapabilityForbidden (the fund&#39;s DistributionCharacterSource capability is Forbidden, so characters come from buckets alone). | 

```csharp
using Lusid.Sdk.Model;
using System;

string glCode = "glCode";decimal amount = "amount";

string reason = "reason";

IgnoredDistributionTag ignoredDistributionTagInstance = new IgnoredDistributionTag(
    glCode: glCode,
    lineCount: lineCount,
    amount: amount,
    reason: reason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
