# Lusid.Sdk.Model.FeeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FeeType** | [**ResourceId**](ResourceId.md) |  | 
**Name** | **string** | The name of the Fee. | 
**Description** | **string** | A description for the Fee. | [optional] 
**Origin** | **string** | The origin or source of the Fee accrual. | [optional] 
**CalculationBase** | **string** | The calculation base for the Fee that is calculated using a percentage. (TotalAnnualAccrualAmount and CalculationBase cannot both be present) | [optional] 
**AccrualCurrency** | **string** | The accrual currency. | 
**Treatment** | **string** | The accrual period of the Fee; &#39;Monthly&#39; or &#39;Daily&#39;. | 
**TotalAnnualAccrualAmount** | **decimal?** | The total annual accrued amount for the Fee. (TotalAnnualAccrualAmount and CalculationBase cannot both be present) | [optional] 
**FeeRatePercentage** | **decimal?** | The fee rate percentage. (Required when CalculationBase is present and not compatible with TotalAnnualAccrualAmount) | [optional] 
**PayableFrequency** | **string** | The payable frequency for the Fee; &#39;Annually&#39;, &#39;Quarterly&#39; or &#39;Monthly&#39;. | 
**BusinessDayConvention** | **string** | The business day convention to use for Fee calculations on weekends. | 
**StartDate** | **DateTimeOffset** | The start date of the Fee. | 
**EndDate** | **DateTimeOffset?** | The end date of the Fee. | [optional] 
**AnchorDate** | [**DayMonth**](DayMonth.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The Fee properties. These will be from the &#39;Fee&#39; domain. | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

