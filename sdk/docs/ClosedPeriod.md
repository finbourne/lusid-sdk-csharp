# Lusid.Sdk.Model.ClosedPeriod

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClosedPeriodId** | **string** | The unique Id of the Closed Period. The ClosedPeriodId, together with the Timeline Scope and Code, uniquely identifies a Closed Period | [optional] 
**DisplayName** | **string** | The name of the Closed Period. | [optional] 
**Description** | **string** | A description for the Closed Period. | [optional] 
**EffectiveStart** | **DateTimeOffset** | The effective start of the Closed Period | [optional] 
**EffectiveEnd** | **DateTimeOffset** | The effective end of the Closed Period | [optional] 
**AsAtClosed** | **DateTimeOffset** | The asAt closed datetime for the Closed Period | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The Closed Periods properties. These will be from the &#39;ClosedPeriod&#39; domain. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**PostCloseActivities** | [**List&lt;PostCloseActivity&gt;**](PostCloseActivity.md) | All the post close activities for the closed period. | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested asAt datetime. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

