# Lusid.Sdk.Model.MarginLine
One holding's contribution to a margin call: its exposure, or its value as collateral.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | **string** | The run that produced the line. | 
**AgreementId** | [**ResourceId**](ResourceId.md) |  | 
**Item** | **string** | The margin item the line falls under. Filterable. | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**HoldingId** | **string** | The holding the line was valued from. | [optional] 
**CustodianAccountScope** | **string** | The scope of the custodian account the holding sits in, when it has one. | [optional] 
**CustodianAccountCode** | **string** | The code of the custodian account the holding sits in, when it has one. | [optional] 
**CustodianAccountName** | **string** | The name of the custodian account, when it has one. | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The identifiers of the instrument held. | 
**Units** | **decimal** | The units held. | 
**Pv** | **decimal?** | The present value of the holding in the agreement&#39;s base currency, when it contributes to exposure. | [optional] 
**VariationMargin** | **decimal?** | The holding&#39;s contribution to variation margin, when it contributes to exposure. | [optional] 
**CollateralValue** | **decimal?** | The holding&#39;s value as collateral after haircuts, when it is held as collateral. | [optional] 
**InitialMarginItem** | **string** | The initial-margin item the line falls under, when the holding matched one. Filterable. | [optional] 
**InitialMargin** | **decimal?** | The holding&#39;s share of its netting set&#39;s initial margin, before the threshold, when it contributes to it. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string runId = "runId";
ResourceId agreementId = new ResourceId();
string item = "item";
ResourceId? portfolioId = new ResourceId();

string holdingId = "example holdingId";
string custodianAccountScope = "example custodianAccountScope";
string custodianAccountCode = "example custodianAccountCode";
string custodianAccountName = "example custodianAccountName";
Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();decimal units = "units";

string initialMarginItem = "example initialMarginItem";

MarginLine marginLineInstance = new MarginLine(
    runId: runId,
    agreementId: agreementId,
    item: item,
    portfolioId: portfolioId,
    holdingId: holdingId,
    custodianAccountScope: custodianAccountScope,
    custodianAccountCode: custodianAccountCode,
    custodianAccountName: custodianAccountName,
    instrumentIdentifiers: instrumentIdentifiers,
    units: units,
    pv: pv,
    variationMargin: variationMargin,
    collateralValue: collateralValue,
    initialMarginItem: initialMarginItem,
    initialMargin: initialMargin);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
