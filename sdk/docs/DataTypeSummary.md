# Lusid.Sdk.Model.DataTypeSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TypeValueRange** | **string** | Indicates the range of data acceptable by a data type. Available values: Open, Closed. | 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The display name of the data type. | 
**Description** | **string** | The description of the data type. | 
**ValueType** | **string** | The expected type of the values. Available values: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel, UnindexedText. | 
**AcceptableValues** | **List&lt;string&gt;** | The acceptable set of values for this data type. Only applies when the type value range is &#39;Closed&#39;; it is ignored on write and returned as null for &#39;Open&#39; data types. If reference data is supplied on a &#39;Closed&#39; data type and this field is omitted, the acceptable values are derived from the reference data values. | [optional] 
**UnitSchema** | **string** | The schema of the data type&#39;s units. Available values: NoUnits, Basic, Iso4217Currency. | [optional] 
**AcceptableUnits** | [**List&lt;IUnitDefinitionDto&gt;**](IUnitDefinitionDto.md) | The definitions of the acceptable units. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 

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
ModelVersion? varVersion = new ModelVersion();


DataTypeSummary dataTypeSummaryInstance = new DataTypeSummary(
    typeValueRange: typeValueRange,
    id: id,
    displayName: displayName,
    description: description,
    valueType: valueType,
    acceptableValues: acceptableValues,
    unitSchema: unitSchema,
    acceptableUnits: acceptableUnits,
    varVersion: varVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
