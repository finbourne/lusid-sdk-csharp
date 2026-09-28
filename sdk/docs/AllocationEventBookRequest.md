# Lusid.Sdk.Model.AllocationEventBookRequest
The request used to book a computed Allocation Event: the reference under which its shares were posted.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BookingReference** | **string** | The reference under which the computed shares were posted, for instance a journal entry code. | 

```csharp
using Lusid.Sdk.Model;
using System;

string bookingReference = "bookingReference";

AllocationEventBookRequest allocationEventBookRequestInstance = new AllocationEventBookRequest(
    bookingReference: bookingReference);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
