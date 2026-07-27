# Lusid.Sdk.Model.TypedResourceId
Represents the user-defined identifier for a Legal Entity.  Users can define their own, scoped identifiers for Legal Entities using identifier properties.  For example,  when used to identify a Legal Entity, the identifier defined by LegalEntity/myScope/1234ABC0000000000063 would be represented as   {     \"idTypeScope\": \"myScope\",     \"idTypeCode\": \"1234ABC0000000000063\",     \"code\": \"ACME_CO\"   }

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdTypeScope** | **string** | The scope of the identifier&#39;s (property) definition. | 
**IdTypeCode** | **string** | The code of identifier&#39;s (property) definition. This describes what the identifier represents.  For a Legal Entity, this might be a registeredCompanyNumber or LEI. | 
**Code** | **string** | The value of the user-defined identifier in respect of the entity. | 

```csharp
using Lusid.Sdk.Model;
using System;

string idTypeScope = "idTypeScope";
string idTypeCode = "idTypeCode";
string code = "code";

TypedResourceId typedResourceIdInstance = new TypedResourceId(
    idTypeScope: idTypeScope,
    idTypeCode: idTypeCode,
    code: code);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
