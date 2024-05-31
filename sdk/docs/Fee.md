# Lusid.Sdk.Model.Fee

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**FeeCode** | **string** | The code of the Fee. | [optional] 
**FeeType** | [**ResourceId**](ResourceId.md) |  | 
**Name** | **string** | The name of the Fee. | 
**Description** | **string** | A description for the Fee. | [optional] 
**Origin** | **string** | The origin or source of the Fee accrual. | [optional] 
**CalculationBase** | **string** | The calculation base for the Fee that is calculated using a percentage. | [optional] 
**AccrualCurrency** | **string** | The accrual currency. | 
**Treatment** | **string** | The accrual period of the Fee; &#39;Monthly&#39; or &#39;Daily&#39;. | 
**TotalAnnualAccrualAmount** | **decimal?** | The total accrued amount for the Fee. | [optional] 
**FeeRatePercentage** | **decimal?** | The fee rate percentage. | [optional] 
**MonthlyAccrual** | **decimal?** | The monthly accrual amount. | [optional] 
**DailyAccrual** | **decimal?** | The daily accrual amount. | [optional] 
**PayableFrequency** | **string** | The payable frequency for the Fee; &#39;Annually&#39;, &#39;Quarterly&#39; or &#39;Monthly&#39;. | 
**BusinessDayConvention** | **string** | The business day convention to use for Fee calculations on weekends. | 
**StartDate** | **DateTimeOffset** | The start date of the Fee. | 
**EndDate** | **DateTimeOffset** | The end date of the Fee. | [optional] 
**AnchorDate** | [**DayMonth**](DayMonth.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The Fee properties. These will be from the &#39;Fee&#39; domain. | [optional] 
**_Version** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

