# Lusid.Sdk.Model.DiaryEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**AborId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**DiaryEntryCode** | **string** | The code of the diary entry. | [optional] 
**Type** | **string** | The type of the diary entry. | 
**Name** | **string** | The name of the diary entry. | [optional] 
**Status** | **string** | The status of the diary entry. Statuses are constrained and defaulted by &#39;Type&#39; specified.   Type &#39;Other&#39; defaults to &#39;Undefined&#39; and supports &#39;Undefined&#39;, &#39;Estimate&#39;, &#39;Candidate&#39;, and &#39;Final&#39;.  Type &#39;PeriodBoundary&#39; defaults to &#39;Estimate&#39; when closing a period, and supports &#39;Estimate&#39; and &#39;Final&#39; for closing periods and &#39;Final&#39; for locking periods.  Type &#39;ValuationPoint&#39; defaults to &#39;Estimate&#39; when upserting a diary entry, moves to &#39;Candidate&#39; or &#39;Final&#39; when a ValuationPoint is accepted, and &#39;Final&#39; when it is finalised. | 
**EffectiveAt** | **DateTimeOffset** | The effective time of the diary entry. | 
**QueryAsAt** | **DateTimeOffset** | The query time of the diary entry. Defaults to latest. | [optional] 
**PreviousEntryTime** | **DateTimeOffset** | The entry time of the previous diary entry. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the diary entry. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

