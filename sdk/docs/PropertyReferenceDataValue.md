# Lusid.Sdk.Model.PropertyReferenceDataValue
The ReferenceData relevant to the property. The ReferenceData is taken from the DataType on the PropertyDefinition that defines the Property.  Only ReferenceData where the ReferenceData value matches the Property value is included.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StringValue** | **string** |  | [optional] 
**NumericValue** | **decimal?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string stringValue = "example stringValue";

PropertyReferenceDataValue propertyReferenceDataValueInstance = new PropertyReferenceDataValue(
    stringValue: stringValue,
    numericValue: numericValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
