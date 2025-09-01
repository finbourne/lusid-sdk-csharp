# Lusid.Sdk.Model.Barrier
Barrier class for exotic FxOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Direction** | **string** | Supported string (enumeration) values are: [Down, Up]. | 
**Level** | **decimal** | Trigger level, which the underlying should (or should not) cross/touch. | 
**Monitoring** | **string** | Supported string (enumeration) values are: [European, Bermudan, American].  Defaults to \&quot;European\&quot; if not set. | [optional] 
**Type** | **string** | Supported string (enumeration) values are: [Knockin, Knockout]. | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

