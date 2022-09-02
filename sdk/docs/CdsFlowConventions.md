# Lusid.Sdk.Model.CdsFlowConventions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RollFrequency** | **string** | The frequency at which the reference bonds are updated, this defaults to 6M, but can be 3M, exp for historically issued products | [optional] 
**Currency** | **string** | Currency of the flow convention. | 
**PaymentFrequency** | **string** | When generating a multiperiod flow, or when the maturity of the flow is not given but the start date is,  the tenor is the time-step from the anchor-date to the nominal maturity of the flow prior to any adjustment. | 
**DayCountConvention** | **string** | when calculating the fraction of a year between two dates, what convention is used to represent the number of days in a year  and difference between them.  For more information on day counts, see [knowledge base article KA-01798](https://support.lusid.com/knowledgebase/article/KA-01798)                Supported string (enumeration) values are: [Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActualActual, ActAct, ActActIsda, ActActIsma, ActActIcma, OneOne, Act364, Act365F, Act365L, Act365_25, Act252, Bus252, NL360, NL365, ActActAFB, Act365Cad, ThirtyActIsda, Thirty365Isda, ThirtyEActIsda, ThirtyE360Isda, ThirtyE365Isda, ThirtyU360EOM]. | 
**RollConvention** | **string** | When generating a set of dates, what convention should be used for adjusting dates that coincide with a non-business day.    Supported string (enumeration) values are: [NoAdjustment, None, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, EndOfMonth, EOM, EndOfMonthPrevious, EOMP, EndOfMonthFollowing, EOMF, HalfMonthModifiedFollowing]. | 
**PaymentCalendars** | **List&lt;string&gt;** | An array of strings denoting holiday calendars that apply to generation of payment schedules. | 
**ResetCalendars** | **List&lt;string&gt;** | An array of strings denoting holiday calendars that apply to generation of reset schedules. | 
**SettleDays** | **int** | Number of Good Business Days between the trade date and the effective or settlement date of the instrument. | 
**ResetDays** | **int** | The number of Good Business Days between determination and payment of reset. | 
**Scope** | **string** | The scope used when updating or inserting the convention. | [optional] 
**Code** | **string** | The code of the convention. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

