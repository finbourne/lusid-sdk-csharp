# Lusid.Sdk.Model.GroupReconciliationResultStatuses

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountNew** | **int** | The number of comparison results of resultStatus \&quot;New\&quot; with this instanceId and reconciliationType | 
**LinkNew** | [**Link**](Link.md) |  | 
**CountConfirmed** | **int** | The number of comparison results of resultStatus \&quot;Confirmed\&quot; with this instanceId and reconciliationType | 
**LinkConfirmed** | [**Link**](Link.md) |  | 
**CountChanged** | **int** | The number of comparison results of resultStatus \&quot;Changed\&quot; with this instanceId and reconciliationType | 
**LinkChanged** | [**Link**](Link.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

Link linkNew = new Link();
Link linkConfirmed = new Link();
Link linkChanged = new Link();

GroupReconciliationResultStatuses groupReconciliationResultStatusesInstance = new GroupReconciliationResultStatuses(
    countNew: countNew,
    linkNew: linkNew,
    countConfirmed: countConfirmed,
    linkConfirmed: linkConfirmed,
    countChanged: countChanged,
    linkChanged: linkChanged);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
