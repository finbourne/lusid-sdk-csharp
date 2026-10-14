# Lusid.Sdk.Model.FundNavTypeCodes
A fund resolved by a filtered fund list, with the NAV type codes matched by the list's hint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**NavTypeCodes** | **List&lt;string&gt;** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? fundId = new ResourceId();

List<string> navTypeCodes = new List<string>();

FundNavTypeCodes fundNavTypeCodesInstance = new FundNavTypeCodes(
    fundId: fundId,
    navTypeCodes: navTypeCodes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
