# Lusid.Sdk.Model.StructuredResultDataResult
Represents structured result data document and row details for a data quality check result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The type of the entity, e.g. \&quot;SrsRow\&quot;. | [optional] 
**AsAt** | **DateTimeOffset** | The as-at timestamp the document was read at | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective-at timestamp the document was read at | [optional] 
**DocumentEffectiveAt** | **DateTimeOffset** | The effective date of the upload the row was read from: the latest upload at or before effectiveAt | [optional] 
**Scope** | **string** | The scope of the document | [optional] 
**Code** | **string** | The code of the document | [optional] 
**Source** | **string** | The platform or vendor that provided the document | [optional] 
**ResultType** | **string** | The document&#39;s result type | [optional] 
**RowIdentifiers** | **Dictionary&lt;string, string&gt;** | The row&#39;s identifier columns, keyed by address key. Populated when entityType is \&quot;SrsRow\&quot;. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "example entityType";
string scope = "example scope";
string code = "example code";
string source = "example source";
string resultType = "example resultType";
Dictionary<string, string> rowIdentifiers = new Dictionary<string, string>();

StructuredResultDataResult structuredResultDataResultInstance = new StructuredResultDataResult(
    entityType: entityType,
    asAt: asAt,
    effectiveAt: effectiveAt,
    documentEffectiveAt: documentEffectiveAt,
    scope: scope,
    code: code,
    source: source,
    resultType: resultType,
    rowIdentifiers: rowIdentifiers);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
