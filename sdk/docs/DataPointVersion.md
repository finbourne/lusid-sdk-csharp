# Lusid.Sdk.Model.DataPointVersion
The version metadata for DataPoints.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAtCreated** | **DateTimeOffset?** | The asAt datetime at which the entity was first created in LUSID. | [optional] 
**UserIdCreated** | **string** | The unique id of the user who created the entity. | [optional] 
**RequestIdCreated** | **string** | The unique request id of the command that created the entity. | [optional] 
**AsAtModified** | **DateTimeOffset?** | The asAt datetime at which the entity (including its properties) was last updated in LUSID. | [optional] 
**UserIdModified** | **string** | The unique id of the user who last updated the entity (including its properties) in LUSID. | [optional] 
**RequestIdModified** | **string** | The unique request id of the command that last updated the entity (including its properties) in LUSID. | [optional] 
**AsAtVersionNumber** | **int?** | The integer version number for the entity (the entity was created at version 1) | [optional] 
**EntityUniqueId** | **string** | The unique id of the entity | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string userIdCreated = "example userIdCreated";
string requestIdCreated = "example requestIdCreated";
string userIdModified = "example userIdModified";
string requestIdModified = "example requestIdModified";
string entityUniqueId = "example entityUniqueId";

DataPointVersion dataPointVersionInstance = new DataPointVersion(
    asAtCreated: asAtCreated,
    userIdCreated: userIdCreated,
    requestIdCreated: requestIdCreated,
    asAtModified: asAtModified,
    userIdModified: userIdModified,
    requestIdModified: requestIdModified,
    asAtVersionNumber: asAtVersionNumber,
    entityUniqueId: entityUniqueId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
