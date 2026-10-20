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
**CalculationBase** | **string** | The calculation base for a Fee that is calculated using a percentage (TotalAnnualAccrualAmount and CalculationBase cannot both be present). An arithmetic expression (+, -, *, /, numeric literals) over data points from the valuation point being calculated and from the previous valuation point (via the \&quot;Previous.\&quot; prefix; these resolve to zero at a fund&#39;s first valuation point). All values are in the fund currency unless stated otherwise. When the Fee is a NonShareClassSpecific Fee (i.e: when ShareClasses contains no values), the available data points are: \&quot;GAV\&quot;, \&quot;NAVPreFees\&quot; (GAV adjusted for external fees, before any fee accruals), \&quot;Amount\&quot; (the previous valuation point&#39;s NAV), \&quot;Dealing[dealingFilterId]\&quot;, \&quot;BackOut[backOutFilterId]\&quot;, \&quot;PnL[pnlFilterId]\&quot;, \&quot;ExternalFees[externalFeeFilterId]\&quot;, \&quot;Fees[feeCode].Amount|TotalAccrual|PreviousTotalAccrual|CalculationBase\&quot;, \&quot;Properties[Fund/scope/code]\&quot; (numeric, non-derived fund properties), and under the \&quot;Previous.\&quot; prefix: \&quot;Previous.GAV\&quot;, \&quot;Previous.NAV\&quot;, \&quot;Previous.Dealing[id]\&quot;, \&quot;Previous.BackOut[id]\&quot;, \&quot;Previous.PnL[id]\&quot;, \&quot;Previous.ExternalFees[id]\&quot; and \&quot;Previous.Fees[feeCode].Amount|TotalAccrual|CalculationBase\&quot;. \&quot;GAV\&quot; is the gross asset value before any external fees, whereas \&quot;Previous.GAV\&quot; is the previous valuation point&#39;s reported GAV, which is after any external fees that apply to a PnL bucket; for a like-for-like period comparison use \&quot;NAVPreFees\&quot; against \&quot;Previous.NAV\&quot;. \&quot;ExternalFees[id]\&quot; is the sum of the fund level external fees (positive amounts) and the share class external fees (booked as negative movements) matching the filter. Each id must be one the fund configuration defines: a filter id, or on a fund configuration with bucket sets, a bucket id of the apportionment bucket set of the matching bucket type (BackOut is not available with bucket sets). For example: \&quot;10000.00\&quot;, \&quot;GAV\&quot;, \&quot;GAV - Fees[FeeCode1].Amount\&quot;, \&quot;Previous.NAV - Dealing[Redemptions] + Dealing[Subscriptions]\&quot;. When the Fee is a ShareClass Fee (i.e: when ShareClasses contains at least one value), the same data points are available for the share class under the \&quot;ShareClass.\&quot; prefix (e.g. \&quot;ShareClass.GAV\&quot;, \&quot;ShareClass.Previous.NAV\&quot;, \&quot;ShareClass.Fees[FeeCode1].Amount\&quot;), with \&quot;ShareClass.PreviousNAV\&quot; as the previous NAV, plus \&quot;ShareClass.DealingUnits[id]\&quot;, \&quot;ShareClass.CapitalRatio\&quot;, \&quot;ShareClass.Previous.SharesInIssue\&quot;, \&quot;ShareClass.Previous.UnitPrice\&quot;, and the share class currency data points \&quot;ShareClass.ShareClassCcyGAV\&quot;, \&quot;ShareClass.ShareClassCcyPreviousNAV\&quot;, \&quot;ShareClass.ShareClassCcyNAVPreFees\&quot;, \&quot;ShareClass.ShareClassCcyGAVPreManagementFees\&quot;, \&quot;ShareClass.ShareClassCcyPerformanceFeeGAV\&quot;, \&quot;ShareClass.ShareClassToFundFxRate\&quot;, \&quot;ShareClass.PreviousShareClassToFundFxRate\&quot;, \&quot;ShareClass.Previous.ShareClassCcyGAV\&quot; and \&quot;ShareClass.Previous.ShareClassCcyNAV\&quot;. The expression must evaluate to a fund currency amount, so convert any share class currency data point explicitly, e.g. \&quot;ShareClass.Previous.ShareClassCcyNAV * ShareClass.ShareClassToFundFxRate\&quot;. \&quot;ShareClass.ExternalFees[id]\&quot; and \&quot;ShareClass.Previous.ExternalFees[id]\&quot; are both the external fees booked to the share class itself. Two pre-defined bases control the order fees are calculated in: fees are calculated in three tiers, and a fee&#39;s tier is fixed by its calculation base at creation. \&quot;GAVPreManagementFees\&quot; (NAVPreFees less the accruals of all Ordinary tier fees) makes the fee a Management tier fee, calculated after all Ordinary fees. \&quot;PerformanceFeeGAV\&quot; (NAVPreFees less the accruals of all Ordinary and Management tier fees) makes the fee a Performance tier fee, calculated last. Any other base makes the fee an Ordinary tier fee. Fees in the same tier see the same pre-defined base value regardless of creation order, so each pre-defined base is the value of the fund after all external fees and all earlier tier fees have been applied, and a fee cannot reference the accrual of a fee in a later tier. The ShareClass forms (\&quot;ShareClass.GAVPreManagementFees\&quot;, \&quot;ShareClass.PerformanceFeeGAV\&quot;) use the share class NAVPreFees less that share class&#39;s earlier tier fee accruals, including its capital ratio share of fund level fees; their share class currency forms (\&quot;ShareClass.ShareClassCcyGAVPreManagementFees\&quot;, \&quot;ShareClass.ShareClassCcyPerformanceFeeGAV\&quot;) put the fee in the same tier. No floor is applied to any calculation base: a negative base produces a negative accrual. | [optional] 
**AccrualCurrency** | **string** | The accrual currency. | 
**Treatment** | **string** | The accrual period of the Fee. Available values: Daily, Monthly. | 
**TotalAnnualAccrualAmount** | **decimal?** | The total annual accrued amount for the Fee. (TotalAnnualAccrualAmount and CalculationBase cannot both be present) | [optional] 
**FeeRatePercentage** | **decimal?** | The annual rate applied to the CalculationBase for a &#39;FixedPercentage&#39; Fee, expressed as a multiplier rather than a percentage: 0.052 means 5.2% of the base per year. (Required when CalculationBase is present and not compatible with TotalAnnualAccrualAmount) | [optional] 
**PayableFrequency** | **string** | The payable frequency for the Fee. Available values: Annually, Quarterly, Monthly. | 
**BusinessDayConvention** | **string** | The business day convention to use for Fee calculations on weekends or holidays. Available values: None, P, Previous, F, Following. | 
**StartDate** | **DateTimeOffset** | The start date of the Fee. | 
**EndDate** | **DateTimeOffset** | The end date of the Fee. | [optional] 
**AnchorDate** | [**DayMonth**](DayMonth.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The Fee properties. These will be from the &#39;Fee&#39; domain. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ShareClasses** | **List&lt;string&gt;** | The short codes of the ShareClasses that the Fee should be applied to. Optional: if this is null or empty, then the Fee will be divided between all the ShareClasses of the Fund according to the capital ratio. | [optional] 
**NavTypeCode** | **string** | When provided runs against the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional] 
**FeeCalculationType** | **string** | How the Fee accrual amount is calculated. Supported values: &#39;FixedAnnual&#39; (a fixed annual amount, requires TotalAnnualAccrualAmount), &#39;FixedDaily&#39; (a fixed daily amount, requires DailyAccrualAmount), &#39;FixedPercentage&#39; (a fixed percentage of the CalculationBase, requires FeeRatePercentage), &#39;VariablePercentage&#39; (a percentage of the CalculationBase resolved from a rate source at each accrual date, requires VariablePercentageSource), &#39;Tiered&#39; (a single rate applied to the whole CalculationBase, chosen by the tier the base falls in, requires Tiers), &#39;Blended&#39; (each tier&#39;s rate applied to the portion of the CalculationBase within that tier, requires Tiers). Optional: when not provided it is inferred as &#39;FixedAnnual&#39; if TotalAnnualAccrualAmount is populated and &#39;FixedPercentage&#39; otherwise, so existing requests keep their behaviour; the new calculation types must be requested explicitly. Available values: FixedAnnual, FixedDaily, FixedPercentage, VariablePercentage, Tiered, Blended. | [optional] 
**DailyAccrualAmount** | **decimal?** | The fixed daily accrued amount for a &#39;FixedDaily&#39; Fee, in the fund currency. The amount accrues for each day of the accrual period with no annualisation or day-count proration; Treatment does not affect it. | [optional] 
**VariablePercentageSource** | **string** | The source of the rate for a &#39;VariablePercentage&#39; Fee, in the form \&quot;scope/provider/instrumentIdType/instrumentId\&quot; identifying a Rate quote series in the quote store. At each accrual date the most recent rate at or before that date is used; if no rate can be found the valuation point calculation fails. The quote&#39;s normalised value (its value divided by any scale factor) is applied like FeeRatePercentage, as a multiplier of the CalculationBase: a rate of 5.2% must normalise to 0.052. | [optional] 
**VariablePercentageSourceOffset** | **decimal?** | An optional adjustment added to the rate resolved from the VariablePercentageSource, expressed as a factor like FeeRatePercentage (e.g. 0.0025 adds 25 basis points). | [optional] 
**Tiers** | [**List&lt;FeeRateTier&gt;**](FeeRateTier.md) | The rate tiers for a &#39;Tiered&#39; or &#39;Blended&#39; Fee: between 2 and 10 tiers over the CalculationBase. Every tier except the last must have a Threshold, and thresholds must be positive and strictly increasing; a base equal to a Threshold falls in that tier, and the final tier covers the balance above the last threshold. A &#39;Tiered&#39; Fee applies the rate of the tier the whole base falls in; a &#39;Blended&#39; Fee applies each tier&#39;s rate to the portion of the base within that tier. | [optional] 
**FeeCap** | **decimal?** | An optional annual cap on the accrued fee for &#39;FixedPercentage&#39;, &#39;VariablePercentage&#39;, &#39;Tiered&#39; and &#39;Blended&#39; Fees, in the fund currency and assessed period-to-date. Each day accrues only up to the amount left under the cap for the current fee year, which runs from one AnchorDate to the next; once the cap is reached nothing further accrues until the next AnchorDate. | [optional] 
**FeeFloor** | **decimal?** | An optional annual floor on the calculated fee for &#39;FixedPercentage&#39;, &#39;VariablePercentage&#39;, &#39;Tiered&#39; and &#39;Blended&#39; Fees, in the fund currency. The annualised fee amount is raised to the floor before being prorated to each accrual day. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
string feeCode = "example feeCode";
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
ModelVersion? varVersion = new ModelVersion();

ResourceId? portfolioId = new ResourceId();

List<string> shareClasses = new List<string>();
string navTypeCode = "example navTypeCode";
string feeCalculationType = "example feeCalculationType";
string variablePercentageSource = "example variablePercentageSource";
List<FeeRateTier> tiers = new List<FeeRateTier>();
List<Link> links = new List<Link>();

Fee feeInstance = new Fee(
    href: href,
    feeCode: feeCode,
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
    varVersion: varVersion,
    portfolioId: portfolioId,
    shareClasses: shareClasses,
    navTypeCode: navTypeCode,
    feeCalculationType: feeCalculationType,
    dailyAccrualAmount: dailyAccrualAmount,
    variablePercentageSource: variablePercentageSource,
    variablePercentageSourceOffset: variablePercentageSourceOffset,
    tiers: tiers,
    feeCap: feeCap,
    feeFloor: feeFloor,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
