# Lusid.Sdk.Model.PackageSetRequest
A request to create or update multiple Packages.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Requests** | [**List&lt;PackageRequest&gt;**](PackageRequest.md) | A collection of PackageRequests. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<PackageRequest> requests = new List<PackageRequest>();

PackageSetRequest packageSetRequestInstance = new PackageSetRequest(
    requests: requests);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
