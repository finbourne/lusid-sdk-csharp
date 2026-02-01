# Lusid.Sdk.Model.UpsertFundBookmarkRequest
A definition for the period you wish to close

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BookmarkCode** | **string** | Unique code for the Bookmark. | 
**DisplayName** | **string** | Identifiable Name assigned to the Bookmark. | 
**Description** | **string** | Description assigned to the Bookmark. | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective time of the Bookmark. | 
**QueryAsAt** | **DateTimeOffset?** | The query time of the Bookmark. Defaults to latest. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Bookmark. | [optional] 
**HoldingsAsAtOverride** | **DateTimeOffset?** | The optional AsAt Override to use for building holdings in the Bookmark. Defaults to Latest. | [optional] 
**ValuationsAsAtOverride** | **DateTimeOffset?** | The optional AsAt Override to use for performing valuations in the Bookmark. Defaults to Latest. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string bookmarkCode = "bookmarkCode";
string displayName = "displayName";
string description = "example description";
Dictionary<string, Property> properties = new Dictionary<string, Property>();

UpsertFundBookmarkRequest upsertFundBookmarkRequestInstance = new UpsertFundBookmarkRequest(
    bookmarkCode: bookmarkCode,
    displayName: displayName,
    description: description,
    effectiveAt: effectiveAt,
    queryAsAt: queryAsAt,
    properties: properties,
    holdingsAsAtOverride: holdingsAsAtOverride,
    valuationsAsAtOverride: valuationsAsAtOverride);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
