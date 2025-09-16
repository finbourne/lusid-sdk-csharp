# Lusid.Sdk.Model.CalendarDate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** |  | [optional] 
**DateIdentifier** | **string** |  | 
**FromUtc** | **DateTimeOffset** |  | 
**ToUtc** | **DateTimeOffset** |  | 
**LocalDate** | **string** |  | 
**Timezone** | **string** |  | 
**Description** | **string** |  | 
**Type** | **string** |  | [optional] 
**Attributes** | [**DateAttributes**](DateAttributes.md) |  | [optional] 
**SourceData** | **Dictionary&lt;string, string&gt;** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
string dateIdentifier = "dateIdentifier";
string localDate = "localDate";
string timezone = "timezone";
string description = "description";
string type = "example type";
DateAttributes? attributes = new DateAttributes();

Dictionary<string, string> sourceData = new Dictionary<string, string>();

CalendarDate calendarDateInstance = new CalendarDate(
    href: href,
    dateIdentifier: dateIdentifier,
    fromUtc: fromUtc,
    toUtc: toUtc,
    localDate: localDate,
    timezone: timezone,
    description: description,
    type: type,
    attributes: attributes,
    sourceData: sourceData);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
