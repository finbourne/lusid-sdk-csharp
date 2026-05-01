# Lusid.Sdk.Model.CdsProtectionDetailSpecification
CDSs generally conform to fairly standard definitions, but can be tweaked in a number of different ways.  This class gathers a number of common features which may deviate. These will default to the market standard when  no overrides are provided.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Seniority** | **string** | The seniority level of the CDS. Default value: SUB. Available values: Unknown, SNR, SUB, JRSUBUT2, PREFT1, SECDOM, SNRFOR, SUBLT2. | [optional] [default to "SUB"]
**RestructuringType** | **string** | The restructuring clause. Default value: MM. Available values: Unknown, CR, MR, MM, XR, XR14, CR14, MR14, MM14. | [optional] [default to "MM"]
**ProtectStartDay** | **bool** | Does the protection leg pay out in the case of default on the start date. Defaults to true if not set. | [optional] [default to true]
**PayAccruedInterestOnDefault** | **bool** | Should accrued interest on the premium leg be paid if a credit event occurs. Defaults to true if not set. | [optional] [default to true]

```csharp
using Lusid.Sdk.Model;
using System;

string seniority = "example seniority";
string restructuringType = "example restructuringType";
bool protectStartDay = //"True";
bool payAccruedInterestOnDefault = //"True";

CdsProtectionDetailSpecification cdsProtectionDetailSpecificationInstance = new CdsProtectionDetailSpecification(
    seniority: seniority,
    restructuringType: restructuringType,
    protectStartDay: protectStartDay,
    payAccruedInterestOnDefault: payAccruedInterestOnDefault);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
