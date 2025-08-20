# Lusid.Sdk.Model.CdsProtectionDetailSpecification
CDSs generally conform to fairly standard definitions, but can be tweaked in a number of different ways. This class gathers a number of common features which may deviate. These will default to the market standard when no overrides are provided.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Seniority** | **string** | The seniority level of the CDS. Supported string (enumeration) values are: [SNR, SUB, JRSUBUT2, PREFT1, SECDOM, SNRFOR, SUBLT2]. Defaults to \&quot;SUB\&quot; if not set. | [optional] [default to "SUB"]
**RestructuringType** | **string** | The restructuring clause. Supported string (enumeration) values are: [CR, MR, MM, XR]. Defaults to \&quot;MM\&quot; if not set. | [optional] [default to "MM"]
**ProtectStartDay** | **bool** | Does the protection leg pay out in the case of default on the start date. Defaults to true if not set. | [optional] [default to true]
**PayAccruedInterestOnDefault** | **bool** | Should accrued interest on the premium leg be paid if a credit event occurs. Defaults to true if not set. | [optional] [default to true]

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

