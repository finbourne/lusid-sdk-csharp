# Lusid.Sdk.Model.UpsertCreditSupportAnnexRequest
Credit Support Annex information. The interaction in terms of margining requirements between a set of trades for a given counterparty.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreditSupportAnnex** | [**CreditSupportAnnex**](CreditSupportAnnex.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

CreditSupportAnnex? creditSupportAnnex = new CreditSupportAnnex();


UpsertCreditSupportAnnexRequest upsertCreditSupportAnnexRequestInstance = new UpsertCreditSupportAnnexRequest(
    creditSupportAnnex: creditSupportAnnex);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
