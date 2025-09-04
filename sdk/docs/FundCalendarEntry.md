# Lusid.Sdk.Model.FundCalendarEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The unique Code of the Calendar Entry. The Calendar Entry, together with the Fund Scope and Code, uniquely identifies a Fund Calendar Entry | 
**DisplayName** | **string** | The name of the Fund Calendar entry. | 
**Description** | **string** | A description for the Fund Calendar entry. | [optional] 
**NavTypeCode** | **string** | The navTypeCode of the Fund Calendar Entry. This is the code of the NAV type that this Calendar Entry is associated with. | 
**PreviousEntry** | [**PreviousFundCalendarEntry**](PreviousFundCalendarEntry.md) |  | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective at of the Calendar Entry. | [optional] 
**AsAt** | **DateTimeOffset** | The asAt datetime for the Calendar Entry. | 
**EntryType** | **string** | The type of the Fund Calendar Entry. Only &#39;ValuationPoint&#39; currently supported. The available values are: ValuationPointFundCalendarEntry, BookmarkFundCalendarEntry | 
**Status** | **string** | The status of the Fund Calendar Entry. Can be &#39;Estimate&#39;, &#39;Candidate&#39; or &#39;Final&#39;. | [optional] 
**ApplyClearDown** | **bool** | Set to true if that closed period shoould have the clear down applied. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The properties for the Calendar Entry. These will be from the &#39;ClosedPeriod&#39; domain. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested asAt datetime. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

