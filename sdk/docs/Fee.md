# Lusid.Sdk.Model.Fee

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**FeeCode** | **string** | The code of the Fee. | [optional] 
**FeeTypeId** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the Fee. | 
**Description** | **string** | A description for the Fee. | [optional] 
**Origin** | **string** | The origin or source of the Fee accrual. | [optional] 
**CalculationBase** | **string** | The calculation base for the Fee that is calculated using a percentage. (TotalAnnualAccrualAmount and CalculationBase cannot both be present) | [optional] 
**AccrualCurrency** | **string** | The accrual currency. | 
**Treatment** | **string** | The accrual period of the Fee; &#39;Monthly&#39; or &#39;Daily&#39;. | 
**TotalAnnualAccrualAmount** | **decimal?** | The total annual accrued amount for the Fee. (TotalAnnualAccrualAmount and CalculationBase cannot both be present) | [optional] 
**FeeRatePercentage** | **decimal?** | The fee rate percentage. (Required when CalculationBase is present and not compatible with TotalAnnualAccrualAmount) | [optional] 
**PayableFrequency** | **string** | The payable frequency for the Fee; &#39;Annually&#39;, &#39;Quarterly&#39; or &#39;Monthly&#39;. | 
**BusinessDayConvention** | **string** | The business day convention to use for Fee calculations on weekends or holidays. Supported string values are: [Previous, P, Following, F, None]. | 
**StartDate** | **DateTimeOffset** | The start date of the Fee. | 
**EndDate** | **DateTimeOffset** | The end date of the Fee. | [optional] 
**AnchorDate** | [**DayMonth**](DayMonth.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The Fee properties. These will be from the &#39;Fee&#39; domain. | [optional] 
**_Version** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

