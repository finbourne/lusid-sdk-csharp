# Lusid.Sdk.Model.RelativeDateOffset
Defines a date offset which is relative to some anchor date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Days** | **int** | The number of days to add to the anchor date. | 
**BusinessDayConvention** | **string** | The adjustment type to apply to dates that fall upon a non-business day, e.g. modified following or following.    Supported string (enumeration) values are: [NoAdjustment, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, HalfMonthModifiedFollowing, Nearest]. | 
**DayType** | **string** | Indicates if consideration is given to whether a day is a good business day or not when calculating the offset date.    Supported string (enumeration) values are: [Business, Calendar].  Defaults to \&quot;Business\&quot; if not set. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

