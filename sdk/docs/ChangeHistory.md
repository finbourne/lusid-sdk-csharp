# Lusid.Sdk.Model.ChangeHistory
A group of changes made by the same person at the same time.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **string** | The unique identifier of the user that made the change. | 
**ModifiedAsAt** | **DateTimeOffset** | The date/time of the change. | 
**RequestId** | **string** | The unique identifier of the request that the changes were part of. | 
**Action** | **string** | The action performed on the transaction, either created, updated, or deleted. The available values are: Create, Update, Delete | 
**Changes** | [**List&lt;ChangeItem&gt;**](ChangeItem.md) | The collection of changes that were made. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string userId = "userId";
string requestId = "requestId";
string action = "action";
List<ChangeItem> changes = new List<ChangeItem>();
List<Link> links = new List<Link>();

ChangeHistory changeHistoryInstance = new ChangeHistory(
    userId: userId,
    modifiedAsAt: modifiedAsAt,
    requestId: requestId,
    action: action,
    changes: changes,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
