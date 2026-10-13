# Lusid.Sdk.Model.AllocationEventBookRequest
The request used to book a computed Allocation Event: the reference under which its shares are posted, and  whether to only show what would be posted.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BookingReference** | **string** | The reference under which the computed shares were posted, for instance a journal entry code. | 
**DryRun** | **bool** | Whether to only build and return the posting plan without writing anything. Defaults to false. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string bookingReference = "bookingReference";
bool dryRun = //"True";

AllocationEventBookRequest allocationEventBookRequestInstance = new AllocationEventBookRequest(
    bookingReference: bookingReference,
    dryRun: dryRun);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
