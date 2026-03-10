# Lusid.Sdk.Model.UpsertResourceRecordRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeploymentScope** | **string** |  | 
**DeploymentCode** | **string** |  | 
**ResourceId** | **string** |  | 
**Format** | **string** |  | 
**ResourceType** | **string** |  | 
**ResourceState** | **Object** |  | 
**Dependencies** | **List&lt;string&gt;** |  | 
**TrackingState** | **Object** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string deploymentScope = "deploymentScope";
string deploymentCode = "deploymentCode";
string resourceId = "resourceId";
string format = "format";
string resourceType = "resourceType";
List<string> dependencies = new List<string>();

UpsertResourceRecordRequest upsertResourceRecordRequestInstance = new UpsertResourceRecordRequest(
    deploymentScope: deploymentScope,
    deploymentCode: deploymentCode,
    resourceId: resourceId,
    format: format,
    resourceType: resourceType,
    resourceState: resourceState,
    dependencies: dependencies,
    trackingState: trackingState);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
