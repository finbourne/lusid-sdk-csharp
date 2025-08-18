# Lusid.Sdk.Model.UpsertFundBookmarkRequest
A definition for the period you wish to close

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BookmarkCode** | **string** | Unique code for the Bookmark. | 
**DisplayName** | **string** | Identifiable Name assigned to the Bookmark. | 
**Description** | **string** | Description assigned to the Bookmark. | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective time of the diary entry. | 
**QueryAsAt** | **DateTimeOffset?** | The query time of the diary entry. Defaults to latest. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the diary entry. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

