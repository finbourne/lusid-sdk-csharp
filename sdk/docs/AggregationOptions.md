# Lusid.Sdk.Model.AggregationOptions
Options for controlling the default aspects and behaviour of the aggregation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UseAnsiLikeSyntax** | **bool** | Should the aggregation behave like ANSI Sql or MySql with respect to a conceptual request which is equivalent to \&quot;select a,sum(a) from results\&quot;;  ANSI Sql would report an error if a was not unique where MySql would simply view a,suma(a) as equivalent to firstof(a),sum(a). | [optional] 
**AllowPartialEntitlementSuccess** | **bool** | In the case of valuing a portfolio group where some, but not all entitlements fail, should the aggregation return the valuations  applied only to those portfolios where entitlements checks succeeded. | [optional] 
**ApplyIso4217Rounding** | **bool** | Various results that are units of currency might need to be rounded.  This will round according to the ISO4217 standard number of decimal places for a currency. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

