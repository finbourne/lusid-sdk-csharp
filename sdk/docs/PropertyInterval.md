# Lusid.Sdk.Model.PropertyInterval

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**PropertyValue**](PropertyValue.md) |  | 
**EffectiveRange** | [**DateRange**](DateRange.md) |  | 
**AsAtRange** | [**DateRange**](DateRange.md) |  | 
**Status** | **string** | Indicates whether the value is part of the prevailing effective date timeline for the requested asAt date, or whether it has been superseded by correctional activity | 

```csharp
using Lusid.Sdk.Model;
using System;

PropertyValue value = new PropertyValue();
DateRange effectiveRange = new DateRange();
DateRange asAtRange = new DateRange();
string status = "status";

PropertyInterval propertyIntervalInstance = new PropertyInterval(
    value: value,
    effectiveRange: effectiveRange,
    asAtRange: asAtRange,
    status: status);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
