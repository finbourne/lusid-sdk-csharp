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
**Scenario** | [**ResourceId**](ResourceId.md) |  | [optional] 
**LineKey** | **string** | A key that identifies the line within its run, with which its explanation is asked for. A line valued under a scenario has a different key from the same holding in the base market. Null for a line stored before lines carried a key. | [optional] 
**ExplainAvailable** | **bool** | Whether the working behind the line&#39;s figures was stored, so that the line can be explained. One flag covers every figure of the line. | [optional] 
**InstrumentType** | **string** | LUSID&#39;s type for the instrument held, when the run read it. | [optional] 
**AssetClass** | **string** | The instrument&#39;s asset class, when the run read it. | [optional] 
**Currency** | **string** | The currency the holding is denominated in, when the run read it. | [optional] 
**MaturityDate** | **DateTimeOffset?** | The instrument&#39;s maturity, when it has one. | [optional] 
**Notional** | **decimal?** | The holding&#39;s notional in its own currency, when the instrument has one. | [optional] 
**GrossInitialMargin** | **decimal?** | The regulatory-grid charge on the holding before its netting set&#39;s net-to-gross scaling. Null under other methods. | [optional] 
**MovableTo** | **List&lt;string&gt;** | The initial-margin netting sets of other agreements in the run the holding could be re-booked into, as scope/code/item. Recorded for base-case trading lines under an initial-margin item; empty otherwise. | 

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
ResourceId? scenario = new ResourceId();

string lineKey = "example lineKey";
bool explainAvailable = //"True";
string instrumentType = "example instrumentType";
string assetClass = "example assetClass";
string currency = "example currency";
List<string> movableTo = new List<string>();

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
    initialMargin: initialMargin,
    scenario: scenario,
    lineKey: lineKey,
    explainAvailable: explainAvailable,
    instrumentType: instrumentType,
    assetClass: assetClass,
    currency: currency,
    maturityDate: maturityDate,
    notional: notional,
    grossInitialMargin: grossInitialMargin,
    movableTo: movableTo);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
