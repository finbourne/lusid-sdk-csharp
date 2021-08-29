# Lusid.Sdk.Model.CounterpartyRiskInformation
In the event that the legal entity is a counterparty to an OTC transaction  (as signatory to a counterparty agreement such as an ISDA 2002 Master Agreement),  this information would be needed for calculations  such as Credit-Valuation-Adjustments and Debit-Valuation-Adjustments (CVA, DVA, XVA etc).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountryOfRisk** | **string** | The country to which one would naturally ascribe risk, typically the legal entity&#39;s country of registration. This can be used to infer funding currency and related market data in the absence of a specific preference. | 
**CreditRatings** | [**List&lt;CreditRating&gt;**](CreditRating.md) |  | 
**IndustryClassifiers** | [**List&lt;IndustryClassifier&gt;**](IndustryClassifier.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

