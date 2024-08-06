# Lusid.Sdk.Model.CompositeDispersion
A list of Dispersion calculations for the given years.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveAt** | **DateTimeOffset** | The date for which dipsersion calculation has been done. This should be 31 Dec for each given year. | 
**DispersionCalculation** | **decimal?** | The result for the dispersion calculation on the given effectiveAt. | [optional] 
**Variance** | **decimal?** | The variance on the given effectiveAt. | [optional] 
**FirstQuartile** | **decimal?** | First Quartile (Q1) &#x3D;  (lower quartile) &#x3D; the middle of the bottom half of the returns. | [optional] 
**ThirdQuartile** | **decimal?** | Third Quartile (Q3) &#x3D;  (higher quartile) &#x3D; the middle of the top half of the returns. | [optional] 
**Range** | **decimal?** | Highest return - Lowest return. | [optional] 
**ConstituentsInScope** | [**List&lt;ResourceId&gt;**](ResourceId.md) | List containing Composite members which are part of the dispersion calcualtion. | [optional] 
**ConstituentsExcluded** | [**List&lt;ResourceId&gt;**](ResourceId.md) | List containing the Composite members which are not part of the dispersion calculation | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

