# Lusid.Sdk.Model.AllocationEventBookingWarning
One validation rule a booking was allowed to proceed through under the map's policy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The rule that was allowed through, for instance OverCall. | [optional] 
**Detail** | **string** | What the rule found. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "example code";
string detail = "example detail";

AllocationEventBookingWarning allocationEventBookingWarningInstance = new AllocationEventBookingWarning(
    code: code,
    detail: detail);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
