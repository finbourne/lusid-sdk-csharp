# Lusid.Sdk.Model.FeeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the Fee. | 
**FeeTypeId** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the Fee. | 
**Description** | **string** | A description for the Fee. | [optional] 
**Origin** | **string** | The origin or source of the Fee accrual. | [optional] 
**CalculationBase** | **string** | The calculation base for a Fee that is calculated using a percentage (TotalAnnualAccrualAmount and CalculationBase cannot both be present). When the Fee is a ShareClass Fee (i.e: when ShareClasses contains at least one value), each of the following would be a valid CalculationBase: \&quot;10000.00\&quot;, \&quot;ShareClass.GAV\&quot;, \&quot;ShareClass.GAV - ShareClass.Fees[ShareClassFeeCode1].Amount\&quot;, \&quot;ShareClass.Fees[ShareClassFeeCode1].CalculationBase\&quot;. When the Fee is a NonShareClassSpecific Fee (i.e: when ShareClasses contains no values), each of the following would be a valid CalculationBase: \&quot;10000.00\&quot;, \&quot;GAV\&quot;, \&quot;GAV - Fees[NonClassSpecificFeeCode1].Amount\&quot;, \&quot;Fees[NonClassSpecificFeeCode1].CalculationBase\&quot;.  | [optional] 
**AccrualCurrency** | **string** | The accrual currency. | 
**Treatment** | **string** | The accrual period of the Fee; &#39;Monthly&#39; or &#39;Daily&#39;. | 
**TotalAnnualAccrualAmount** | **decimal?** | The total annual accrued amount for the Fee. (TotalAnnualAccrualAmount and CalculationBase cannot both be present) | [optional] 
**FeeRatePercentage** | **decimal?** | The fee rate percentage. (Required when CalculationBase is present and not compatible with TotalAnnualAccrualAmount) | [optional] 
**PayableFrequency** | **string** | The payable frequency for the Fee; &#39;Annually&#39;, &#39;Quarterly&#39; or &#39;Monthly&#39;. | 
**BusinessDayConvention** | **string** | The business day convention to use for Fee calculations on weekends or holidays. Supported string values are: [Previous, P, Following, F, None]. | 
**StartDate** | **DateTimeOffset** | The start date of the Fee. | 
**EndDate** | **DateTimeOffset?** | The end date of the Fee. | [optional] 
**AnchorDate** | [**DayMonth**](DayMonth.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The Fee properties. These will be from the &#39;Fee&#39; domain. | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ShareClasses** | **List&lt;string&gt;** | The short codes of the ShareClasses that the Fee should be applied to. Optional: if this is null or empty, then the Fee will be divided between all the ShareClasses of the Fund according to the capital ratio. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
ResourceId feeTypeId = new ResourceId();
string displayName = "displayName";
string description = "example description";
string origin = "example origin";
string calculationBase = "example calculationBase";
string accrualCurrency = "accrualCurrency";
string treatment = "treatment";
string payableFrequency = "payableFrequency";
string businessDayConvention = "businessDayConvention";
DayMonth? anchorDate = new DayMonth();

Dictionary<string, Property> properties = new Dictionary<string, Property>();
ResourceId? portfolioId = new ResourceId();

List<string> shareClasses = new List<string>();

FeeRequest feeRequestInstance = new FeeRequest(
    code: code,
    feeTypeId: feeTypeId,
    displayName: displayName,
    description: description,
    origin: origin,
    calculationBase: calculationBase,
    accrualCurrency: accrualCurrency,
    treatment: treatment,
    totalAnnualAccrualAmount: totalAnnualAccrualAmount,
    feeRatePercentage: feeRatePercentage,
    payableFrequency: payableFrequency,
    businessDayConvention: businessDayConvention,
    startDate: startDate,
    endDate: endDate,
    anchorDate: anchorDate,
    properties: properties,
    portfolioId: portfolioId,
    shareClasses: shareClasses);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
