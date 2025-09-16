# Lusid.Sdk.Model.CreateCalendarRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CalendarId** | [**ResourceId**](ResourceId.md) |  | 
**CalendarType** | **string** |  | 
**WeekendMask** | [**WeekendMask**](WeekendMask.md) |  | 
**SourceProvider** | **string** |  | 
**Properties** | [**List&lt;Property&gt;**](Property.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId calendarId = new ResourceId();
string calendarType = "calendarType";
WeekendMask weekendMask = new WeekendMask();
string sourceProvider = "sourceProvider";
List<Property> properties = new List<Property>();

CreateCalendarRequest createCalendarRequestInstance = new CreateCalendarRequest(
    calendarId: calendarId,
    calendarType: calendarType,
    weekendMask: weekendMask,
    sourceProvider: sourceProvider,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
