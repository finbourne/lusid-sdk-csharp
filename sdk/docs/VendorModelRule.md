# Lusid.Sdk.Model.VendorModelRule
A rule that identifies the set of preferences to be used for a given library, model and instrument type.  There can be many such rules, though only the first found for a given combination would be used.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Supplier** | **string** | The vendor library supplier | 
**ModelName** | **string** | The vendor library model name | 
**InstrumentType** | **string** | The vendor library instrument type | 
**Parameters** | **string** | The set of opaque model parameters, provided as a Json object, that is a string object which will internally be converted to a dictionary of string to object.  Note that this is not intended as the final form of this object. It will be replaced with a more structured object as the set of parameters that are possible is  better understood. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

