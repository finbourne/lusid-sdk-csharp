# Lusid.Sdk.Model.UnconfirmClosedPeriodRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteSubsequentPeriods** | **bool** | Whether to delete every Closed Period that comes after the requested Closed Period on the Timeline. When false (the default) only the latest confirmed Closed Period may be unconfirmed. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool deleteSubsequentPeriods = //"True";

UnconfirmClosedPeriodRequest unconfirmClosedPeriodRequestInstance = new UnconfirmClosedPeriodRequest(
    deleteSubsequentPeriods: deleteSubsequentPeriods);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
