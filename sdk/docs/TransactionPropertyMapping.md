# Lusid.Sdk.Model.TransactionPropertyMapping

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyKey** | **string** | The key that uniquely identifies the property. It has the format {domain}/{scope}/{code} | 
**MapFrom** | **string** | The Property Key of the Property to map from | [optional] 
**SetTo** | **Object** | A pointer to the Property being mapped from | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string propertyKey = "propertyKey";
string mapFrom = "example mapFrom";

TransactionPropertyMapping transactionPropertyMappingInstance = new TransactionPropertyMapping(
    propertyKey: propertyKey,
    mapFrom: mapFrom,
    setTo: setTo);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
