# Lusid.Sdk.Model.DataType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TypeValueRange** | **string** | The available values are: Open, Closed | 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** |  | 
**Description** | **string** |  | 
**ValueType** | **string** | The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel, UnindexedText | 
**AcceptableValues** | **List&lt;string&gt;** |  | [optional] 
**UnitSchema** | **string** | The available values are: NoUnits, Basic, Iso4217Currency | [optional] 
**AcceptableUnits** | [**List&lt;IUnitDefinitionDto&gt;**](IUnitDefinitionDto.md) |  | [optional] 
**ReferenceData** | [**ReferenceData**](ReferenceData.md) |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**StagedModifications** | [**StagedModificationsInfo**](StagedModificationsInfo.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string typeValueRange = "typeValueRange";
ResourceId id = new ResourceId();
string displayName = "displayName";
string description = "description";
string valueType = "valueType";
List<string> acceptableValues = new List<string>();
string unitSchema = "example unitSchema";
List<IUnitDefinitionDto> acceptableUnits = new List<IUnitDefinitionDto>();
ReferenceData? referenceData = new ReferenceData();

ModelVersion? varVersion = new ModelVersion();

string href = "example href";
StagedModificationsInfo? stagedModifications = new StagedModificationsInfo();

List<Link> links = new List<Link>();

DataType dataTypeInstance = new DataType(
    typeValueRange: typeValueRange,
    id: id,
    displayName: displayName,
    description: description,
    valueType: valueType,
    acceptableValues: acceptableValues,
    unitSchema: unitSchema,
    acceptableUnits: acceptableUnits,
    referenceData: referenceData,
    varVersion: varVersion,
    href: href,
    stagedModifications: stagedModifications,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
