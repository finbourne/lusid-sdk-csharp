# Lusid.Sdk.Model.A2BBreakdown
A2B Breakdown - Shows the total, and each sub-element within an A2B Category

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Total** | **decimal** | The total value of all the components within this category. | [optional] 
**Currency** | **string** | The currency. Applies to the Total, as well as all the componenents. | [optional] 
**Components** | **Dictionary&lt;string, decimal&gt;** | The individual components that make up the category. For example, the Start category may have Cost, Unrealised gains and accrued interest components. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

