# Lusid.Sdk.Model.PartnerAllocationPoolSources
The amount reaching a pool by each route: its bucket's lines, lines tagged with its character and lines allocated  directly to one partner.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bucket** | **decimal** | The amount reaching the pool from the lines its bucket&#39;s rule placed. | 
**LineTag** | **decimal** | The amount reaching the pool from lines tagged with its character. | 
**Direct** | **decimal** | The amount reaching the pool from lines allocated directly to one partner. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal bucket = "bucket";
decimal lineTag = "lineTag";
decimal direct = "direct";


PartnerAllocationPoolSources partnerAllocationPoolSourcesInstance = new PartnerAllocationPoolSources(
    bucket: bucket,
    lineTag: lineTag,
    direct: direct);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
