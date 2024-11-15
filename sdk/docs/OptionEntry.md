# Lusid.Sdk.Model.OptionEntry
Strike price against par and associated date for a bond call.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Strike** | **decimal** | The strike on this date | 
**Date** | **DateTimeOffset** | The date at which the option can be actioned at this strike | 
**EndDate** | **DateTimeOffset?** | If American exercise, this is the end of the exercise period.  Optional field. Defaults to the Date field if not set. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

