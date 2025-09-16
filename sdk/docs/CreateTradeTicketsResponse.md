# Lusid.Sdk.Model.CreateTradeTicketsResponse
Batch trade ticket creation response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**List&lt;LusidTradeTicket&gt;**](LusidTradeTicket.md) |  | 
**Failures** | [**List&lt;ErrorDetail&gt;**](ErrorDetail.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

List<LusidTradeTicket> values = new List<LusidTradeTicket>();
List<ErrorDetail> failures = new List<ErrorDetail>();

CreateTradeTicketsResponse createTradeTicketsResponseInstance = new CreateTradeTicketsResponse(
    values: values,
    failures: failures);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
