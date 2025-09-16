# Lusid.Sdk.Model.ElectionSpecification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElectionType** | **string** |  | 
**Cardinality** | **Dictionary&lt;string, string&gt;** |  | 
**ReferencedAs** | **List&lt;string&gt;** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string electionType = "electionType";
Dictionary<string, string> cardinality = new Dictionary<string, string>();
List<string> referencedAs = new List<string>();

ElectionSpecification electionSpecificationInstance = new ElectionSpecification(
    electionType: electionType,
    cardinality: cardinality,
    referencedAs: referencedAs);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
