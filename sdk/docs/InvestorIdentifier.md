# Lusid.Sdk.Model.InvestorIdentifier
Identification of an Investor on the LUSID API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorType** | **string** | The type of the investor of the Investor Record. Can be either a Person or a LegalEntity | 
**Identifiers** | **Dictionary&lt;string, string&gt;** | Single identifier that should target the desired person or legal entity | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorType = "investorType";
Dictionary<string, string> identifiers = new Dictionary<string, string>();

InvestorIdentifier investorIdentifierInstance = new InvestorIdentifier(
    investorType: investorType,
    identifiers: identifiers);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
