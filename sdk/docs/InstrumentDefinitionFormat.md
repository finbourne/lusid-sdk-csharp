# Lusid.Sdk.Model.InstrumentDefinitionFormat
What is the provenance of an instrument. This defines who creates/owns it, what format it is in (e.g. a proprietary format or a common and known one)              and what the version of that is.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceSystem** | **string** | which source system does the format originate from | 
**Vendor** | **string** | An instrument will potentially have been created by any number of different organisations. Some will be understood completely (e.g. LUSID&#39;s), some won&#39;t.              The provenance of an instrument indicates who \&quot;owns\&quot; the associated format. | 
**VarVersion** | **string** | Version of the document. Would be preferable to avoid the need, but LUSID will not control other organisations&#39; trade formats. | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

