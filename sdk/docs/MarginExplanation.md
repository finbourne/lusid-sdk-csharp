# Lusid.Sdk.Model.MarginExplanation
How the margin figures of a call or a line were arrived at: the working behind each figure as a tree of components,  with the working of portfolios the caller may not read replaced by a redacted component.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The URI of this explanation. | [optional] 
**RunId** | **string** | The run whose figures are explained. | 
**AgreementId** | [**ResourceId**](ResourceId.md) |  | 
**Item** | **string** | The margin item of the call explained or, for a line, of the line. | [optional] 
**MarginType** | **string** | The margin type of the call explained. Null when a line is explained. | [optional] 
**Direction** | **string** | Who posts under the call explained: WePost, TheyPost or None. Null when a line is explained. | [optional] 
**LineKey** | **string** | The key of the line explained. Null when a call is explained. | [optional] 
**Currency** | **string** | The agreement&#39;s base currency, in which a component&#39;s value is expressed unless the component names another. | 
**Scenario** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Components** | [**List&lt;MarginExplanationComponent&gt;**](MarginExplanationComponent.md) | The working behind each figure explained, one root component per figure: for a call its required amount, named InitialMarginRequired, and for a line each figure asked for that the run explained, named VariationMargin or InitialMargin. | 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
string runId = "runId";
ResourceId agreementId = new ResourceId();
string item = "example item";
string marginType = "example marginType";
string direction = "example direction";
string lineKey = "example lineKey";
string currency = "currency";
ResourceId? scenario = new ResourceId();

List<MarginExplanationComponent> components = new List<MarginExplanationComponent>();

MarginExplanation marginExplanationInstance = new MarginExplanation(
    href: href,
    runId: runId,
    agreementId: agreementId,
    item: item,
    marginType: marginType,
    direction: direction,
    lineKey: lineKey,
    currency: currency,
    scenario: scenario,
    components: components);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
