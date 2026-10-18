# Lusid.Sdk.Model.MarginCallKey
The parts that identify a margin call: its run and the call's business key.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | **string** | The run the call belongs to. | 
**AgreementScope** | **string** | The scope of the call&#39;s collateral agreement. | 
**AgreementCode** | **string** | The code of the call&#39;s collateral agreement. | 
**Item** | **string** | The margin item of the call. | 
**MarginType** | **string** | The margin type of the call. Currently VariationMargin. | 
**Direction** | **string** | Who posts under the call: WePost, TheyPost or None. | 

```csharp
using Lusid.Sdk.Model;
using System;

string runId = "runId";
string agreementScope = "agreementScope";
string agreementCode = "agreementCode";
string item = "item";
string marginType = "marginType";
string direction = "direction";

MarginCallKey marginCallKeyInstance = new MarginCallKey(
    runId: runId,
    agreementScope: agreementScope,
    agreementCode: agreementCode,
    item: item,
    marginType: marginType,
    direction: direction);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
