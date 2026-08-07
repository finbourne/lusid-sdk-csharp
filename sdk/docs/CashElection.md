# Lusid.Sdk.Model.CashElection
Cash election for Events that result in a cash payment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElectionKey** | **string** | Unique key used to identify this election. | 
**ExchangeRate** | **decimal?** | The exchange rate if this is not the declared CashElection.  Defaults to 1 if Election is Declared. | [optional] 
**DividendRate** | **decimal?** | The payment rate for this CashElection. | [optional] 
**IsChosen** | **bool** | Has this election been chosen.  Only one Election may be Chosen per Event. | [optional] 
**IsDeclared** | **bool** | Is this the declared CashElection.  Only one Election may be Declared per Event. | [optional] 
**IsDefault** | **bool** | Is this election the default.  Only one Election may be Default per Event | [optional] 
**DividendCurrency** | **string** | The payment currency for this CashElection. | 
**PaymentDate** | **DateTimeOffset?** | Optional option-level payment date. When set, it takes precedence over the event-level payment date; when omitted, the event-level payment date applies. | [optional] 
**RateBreakdown** | [**List&lt;RateBreakdownComponent&gt;**](RateBreakdownComponent.md) | Optional tax-characterised payout lines for this election (CashDividendEvent only). When absent or empty, the election produces a single standard payment. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string electionKey = "electionKey";
bool isChosen = //"True";
bool isDeclared = //"True";
bool isDefault = //"True";
string dividendCurrency = "dividendCurrency";
List<RateBreakdownComponent> rateBreakdown = new List<RateBreakdownComponent>();

CashElection cashElectionInstance = new CashElection(
    electionKey: electionKey,
    exchangeRate: exchangeRate,
    dividendRate: dividendRate,
    isChosen: isChosen,
    isDeclared: isDeclared,
    isDefault: isDefault,
    dividendCurrency: dividendCurrency,
    paymentDate: paymentDate,
    rateBreakdown: rateBreakdown);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
