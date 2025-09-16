# Lusid.Sdk.Model.CorporateActionTransitionRequest
A 'transition' within a corporate action, representing a set of output movements paired to a single input position

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InputTransition** | [**CorporateActionTransitionComponentRequest**](CorporateActionTransitionComponentRequest.md) |  | [optional] 
**OutputTransitions** | [**List&lt;CorporateActionTransitionComponentRequest&gt;**](CorporateActionTransitionComponentRequest.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

CorporateActionTransitionComponentRequest? inputTransition = new CorporateActionTransitionComponentRequest();

List<CorporateActionTransitionComponentRequest> outputTransitions = new List<CorporateActionTransitionComponentRequest>();

CorporateActionTransitionRequest corporateActionTransitionRequestInstance = new CorporateActionTransitionRequest(
    inputTransition: inputTransition,
    outputTransitions: outputTransitions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
