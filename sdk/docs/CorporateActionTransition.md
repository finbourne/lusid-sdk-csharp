# Lusid.Sdk.Model.CorporateActionTransition
A 'transition' within a corporate action, representing a set of output movements paired to a single input position

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InputTransition** | [**CorporateActionTransitionComponent**](CorporateActionTransitionComponent.md) |  | [optional] 
**OutputTransitions** | [**List&lt;CorporateActionTransitionComponent&gt;**](CorporateActionTransitionComponent.md) | What will be generated relative to the input transition | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

CorporateActionTransitionComponent? inputTransition = new CorporateActionTransitionComponent();

List<CorporateActionTransitionComponent> outputTransitions = new List<CorporateActionTransitionComponent>();

CorporateActionTransition corporateActionTransitionInstance = new CorporateActionTransition(
    inputTransition: inputTransition,
    outputTransitions: outputTransitions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
