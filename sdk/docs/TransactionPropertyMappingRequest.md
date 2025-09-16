# Lusid.Sdk.Model.TransactionPropertyMappingRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyKey** | **string** | Uniquely identifies the property definition and consists of a Domain, Scope and Code. | 
**MapFrom** | **string** | The Property Key of the Property to map from. | [optional] 
**SetTo** | **Object** | A pointer to the Property being mapped from. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string propertyKey = "propertyKey";
string mapFrom = "example mapFrom";

TransactionPropertyMappingRequest transactionPropertyMappingRequestInstance = new TransactionPropertyMappingRequest(
    propertyKey: propertyKey,
    mapFrom: mapFrom,
    setTo: setTo);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
