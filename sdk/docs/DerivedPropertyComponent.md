# Lusid.Sdk.Model.DerivedPropertyComponent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Component** | **string** | The component of the formula which is being evaluated. | [optional] 
**Type** | **string** | The type of the formula component. This can be a Literal, Variable, DerivedProperty, or PartialFormula. | [optional] 
**Value** | [**PropertyValue**](PropertyValue.md) |  | [optional] 
**DerivationFormula** | **string** | The derivation formula of the component. This field will only be populated if the component is a derived property. | [optional] 
**SubComponents** | [**List&lt;DerivedPropertyComponent&gt;**](DerivedPropertyComponent.md) | Any sub-components of this formula. If this formula cannot be further decomposed, this collection will be null. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string component = "example component";
string type = "example type";
PropertyValue? value = new PropertyValue();

string derivationFormula = "example derivationFormula";
List<DerivedPropertyComponent> subComponents = new List<DerivedPropertyComponent>();
List<Link> links = new List<Link>();

DerivedPropertyComponent derivedPropertyComponentInstance = new DerivedPropertyComponent(
    component: component,
    type: type,
    value: value,
    derivationFormula: derivationFormula,
    subComponents: subComponents,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
