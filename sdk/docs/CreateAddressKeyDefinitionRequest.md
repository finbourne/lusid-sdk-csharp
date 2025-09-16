# Lusid.Sdk.Model.CreateAddressKeyDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressKey** | **string** | The address key of the address key definition. | 
**Type** | **string** | The type of the address key definition | 

```csharp
using Lusid.Sdk.Model;
using System;

string addressKey = "addressKey";
string type = "type";

CreateAddressKeyDefinitionRequest createAddressKeyDefinitionRequestInstance = new CreateAddressKeyDefinitionRequest(
    addressKey: addressKey,
    type: type);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
