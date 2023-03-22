# Lusid.Sdk.Model.FlowConventions
A flow convention defines the specification for generation of the date schedule for a leg or set of cashflows.  It determines the tenor of these and, how to map the unadjusted set of dates to dates which are 'good business  days'. For example, if an unadjusted date falls on a Saturday or a bank holiday, should it be rolled forward  or backward to obtain the adjusted date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **string** | Currency of the flow convention. | 
**PaymentFrequency** | **string** | When generating a multiperiod flow, or when the maturity of the flow is not given but the start date is,  the tenor is the time-step from the anchor-date to the nominal maturity of the flow prior to any adjustment. | 
**DayCountConvention** | **string** | when calculating the fraction of a year between two dates, what convention is used to represent the number of days in a year  and difference between them.  For more information on day counts, see [knowledge base article KA-01798](https://support.lusid.com/knowledgebase/article/KA-01798)                Supported string (enumeration) values are: [Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActualActual, ActAct, ActActIsda, ActActIsma, ActActIcma, OneOne, Act364, Act365F, Act365L, Act365_25, Act252, Bus252, NL360, NL365, ActActAFB, Act365Cad, ThirtyActIsda, Thirty365Isda, ThirtyEActIsda, ThirtyE360Isda, ThirtyE365Isda, ThirtyU360EOM]. | 
**RollConvention** | **string** | When generating a set of dates, what convention should be used for adjusting dates that coincide with a non-business day.    Supported string (enumeration) values are: [NoAdjustment, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, HalfMonthModifiedFollowing]. | 
**PaymentCalendars** | **List&lt;string&gt;** | An array of strings denoting holiday calendars that apply to generation of payment schedules. | 
**ResetCalendars** | **List&lt;string&gt;** | An array of strings denoting holiday calendars that apply to generation of reset schedules. | 
**SettleDays** | **int** | Number of Good Business Days between the trade date and the effective or settlement date of the instrument. | 
**ResetDays** | **int** | The number of Good Business Days between determination and payment of reset. | 
**LeapDaysIncluded** | **bool?** | If this flag is set to true, the 29th of February is included in the date schedule when the business roll convention is applied.  If this flag is set to false, the business roll convention ignores February 29 for date schedules, cash flow payments etc.  This flag defaults to true if not specified, i.e., leap days are included in a date schedule generation. | [optional] 
**AccrualDateAdjustment** | **string** | Indicates if the accrual dates are adjusted to the payment dates. The default value is &#39;Adjusted&#39;.    Supported string (enumeration) values are: [Adjusted, Unadjusted]. | [optional] 
**Scope** | **string** | The scope used when updating or inserting the convention. | [optional] 
**Code** | **string** | The code of the convention. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

