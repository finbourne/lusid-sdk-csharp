# Lusid.Sdk.Model.ResourceRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeploymentScope** | **string** | The scope of the deployment this record is part of. | 
**DeploymentCode** | **string** | The code of the deployment this record is part of. | 
**ResourceId** | **string** | The unique identifier of the resource associated with this record. | 
**Format** | **string** | A semver format identifier for the resource record. | 
**ResourceType** | **string** | The type of resource associated with this record. | 
**ResourceState** | **Object** | The state of the resource associated with this record. | 
**Dependencies** | **List&lt;string&gt;** | A collection of resource identifiers that this resource depends on. | 
**TrackingState** | **Object** | The tracking state of the resource record. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for the resource record at the requested effective and asAt datetime. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string deploymentScope = "deploymentScope";
string deploymentCode = "deploymentCode";
string resourceId = "resourceId";
string format = "format";
string resourceType = "resourceType";
List<string> dependencies = new List<string>();
ModelVersion? varVersion = new ModelVersion();

string href = "example href";
List<Link> links = new List<Link>();

ResourceRecord resourceRecordInstance = new ResourceRecord(
    deploymentScope: deploymentScope,
    deploymentCode: deploymentCode,
    resourceId: resourceId,
    format: format,
    resourceType: resourceType,
    resourceState: resourceState,
    dependencies: dependencies,
    trackingState: trackingState,
    varVersion: varVersion,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
