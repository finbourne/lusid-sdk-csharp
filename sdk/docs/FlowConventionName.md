# Lusid.Sdk.Model.FlowConventionName
Representation of an abstract definition of a flow convention set consisting of currency, tenor and an index name (arbitrary string but likely something like \"IBOR\").

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **string** | Currency of the flow convention name. | 
**IndexName** | **string** | The index, if present, that is required. e.g. \&quot;IBOR\&quot;, \&quot;OIS\&quot; or \&quot;SONIA\&quot;. | [optional] 
**Tenor** | **string** | Tenor for the convention name.    For more information on tenors, see [knowledge base article KA-02097](https://support.lusid.com/knowledgebase/article/KA-02097) | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

