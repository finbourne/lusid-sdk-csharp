# Lusid.Sdk.Model.CreateDataTypeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope that the data type will be created in. | 
**Code** | **string** | The code of the data type. Together with the scope this uniquely defines the data type. | 
**TypeValueRange** | **string** | Indicates the range of data acceptable by a data type. The available values are: Open, Closed | 
**DisplayName** | **string** | The display name of the data type. | 
**Description** | **string** | The description of the data type. | 
**ValueType** | **string** | The expected type of the values. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel, UnindexedText | 
**AcceptableValues** | **List&lt;string&gt;** | The acceptable set of values for this data type. Only applies to &#39;open&#39; value type range. | [optional] 
**UnitSchema** | **string** | The schema of the data type&#39;s units. The available values are: NoUnits, Basic, Iso4217Currency | [optional] 
**AcceptableUnits** | [**List&lt;CreateUnitDefinition&gt;**](CreateUnitDefinition.md) | The definitions of the acceptable units. | [optional] 
**ReferenceData** | [**ReferenceData**](ReferenceData.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string typeValueRange = "typeValueRange";
string displayName = "displayName";
string description = "description";
string valueType = "valueType";
List<string> acceptableValues = new List<string>();
string unitSchema = "example unitSchema";
List<CreateUnitDefinition> acceptableUnits = new List<CreateUnitDefinition>();
ReferenceData? referenceData = new ReferenceData();


CreateDataTypeRequest createDataTypeRequestInstance = new CreateDataTypeRequest(
    scope: scope,
    code: code,
    typeValueRange: typeValueRange,
    displayName: displayName,
    description: description,
    valueType: valueType,
    acceptableValues: acceptableValues,
    unitSchema: unitSchema,
    acceptableUnits: acceptableUnits,
    referenceData: referenceData);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
