# Lusid.Sdk.Model.UpdateCalendarRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WeekendMask** | [**WeekendMask**](WeekendMask.md) |  | 
**SourceProvider** | **string** |  | 
**Properties** | [**List&lt;Property&gt;**](Property.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

WeekendMask weekendMask = new WeekendMask();
string sourceProvider = "sourceProvider";
List<Property> properties = new List<Property>();

UpdateCalendarRequest updateCalendarRequestInstance = new UpdateCalendarRequest(
    weekendMask: weekendMask,
    sourceProvider: sourceProvider,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
