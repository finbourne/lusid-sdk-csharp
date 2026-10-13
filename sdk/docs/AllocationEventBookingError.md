# Lusid.Sdk.Model.AllocationEventBookingError
One posting a booking could not write.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The rule or write step that failed, for instance WriteFailed. | [optional] 
**Id** | **string** | The identifier of the posting that could not be written. | [optional] 
**Message** | **string** | What went wrong. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "example code";
string id = "example id";
string message = "example message";

AllocationEventBookingError allocationEventBookingErrorInstance = new AllocationEventBookingError(
    code: code,
    id: id,
    message: message);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
