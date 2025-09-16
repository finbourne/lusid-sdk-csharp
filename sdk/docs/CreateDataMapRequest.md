# Lusid.Sdk.Model.CreateDataMapRequest
Request to create a new data map

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**DataMapKey**](DataMapKey.md) |  | 
**Data** | [**DataMapping**](DataMapping.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DataMapKey id = new DataMapKey();
DataMapping? data = new DataMapping();


CreateDataMapRequest createDataMapRequestInstance = new CreateDataMapRequest(
    id: id,
    data: data);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
