# Lusid.Sdk.Model.UpsertCorporateActionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorporateActionCode** | **string** | The unique identifier of this corporate action | 
**Description** | **string** | The description of the corporate action. | [optional] 
**AnnouncementDate** | **DateTimeOffset** | The announcement date of the corporate action | 
**ExDate** | **DateTimeOffset** | The ex date of the corporate action | 
**RecordDate** | **DateTimeOffset** | The record date of the corporate action | 
**PaymentDate** | **DateTimeOffset** | The payment date of the corporate action | 
**Transitions** | [**List&lt;CorporateActionTransitionRequest&gt;**](CorporateActionTransitionRequest.md) | The transitions that result from this corporate action | 

```csharp
using Lusid.Sdk.Model;
using System;

string corporateActionCode = "corporateActionCode";
string description = "example description";
List<CorporateActionTransitionRequest> transitions = new List<CorporateActionTransitionRequest>();

UpsertCorporateActionRequest upsertCorporateActionRequestInstance = new UpsertCorporateActionRequest(
    corporateActionCode: corporateActionCode,
    description: description,
    announcementDate: announcementDate,
    exDate: exDate,
    recordDate: recordDate,
    paymentDate: paymentDate,
    transitions: transitions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
