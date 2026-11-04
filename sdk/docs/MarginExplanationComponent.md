# Lusid.Sdk.Model.MarginExplanationComponent
One step in the working behind a margin figure: a value and, unless it is a leaf, the arithmetic over its  sub-components that gives it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifies the component within its explanation: its position in the tree as dot-separated indexes from the root, such as 0.1.3, the first index being the root&#39;s place among the explanation&#39;s components. | 
**Component** | **string** | A stable name for what the component is, such as PvInBase. A component whose rows the caller may not read is named Redacted. | 
**DisplayName** | **string** | A human-readable name for the component. | 
**Type** | **string** | How the component takes its value. One of DerivedProperty, PartialFormula, Variable or Literal. | 
**Value** | **decimal?** | The figure the engine used for the component, as it was computed. Null where the component has none or, for a redacted component, where the rows it stands in for do not share a unit and currency. | [optional] 
**Unit** | **string** | What the value measures. One of Currency, Percentage, Factor, Units or Years. Null where the value is unitless. | [optional] 
**Currency** | **string** | The currency of a Currency value when it is not the explanation&#39;s currency. | [optional] 
**DerivationFormula** | **string** | Plain arithmetic over the sub-components that gives the component&#39;s value. Null for a component with no sub-components. | [optional] 
**SubComponents** | [**List&lt;MarginExplanationComponent&gt;**](MarginExplanationComponent.md) | The components the derivation formula reads. Null for a component that cannot be broken down further. | [optional] 
**Redacted** | **bool?** | True for a component that stands in for the working of portfolios the caller may not read. The caller sees that those portfolios contributed and, when their rows share a unit and currency, their combined value, so that the parent still adds up to the figure; never which portfolios or holdings they were. Null otherwise. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string id = "id";
string component = "component";
string displayName = "displayName";
string type = "type";
string unit = "example unit";
string currency = "example currency";
string derivationFormula = "example derivationFormula";
List<MarginExplanationComponent> subComponents = new List<MarginExplanationComponent>();
bool? redacted = //"True";

MarginExplanationComponent marginExplanationComponentInstance = new MarginExplanationComponent(
    id: id,
    component: component,
    displayName: displayName,
    type: type,
    value: value,
    unit: unit,
    currency: currency,
    derivationFormula: derivationFormula,
    subComponents: subComponents,
    redacted: redacted);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
