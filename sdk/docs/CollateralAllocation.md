# Lusid.Sdk.Model.CollateralAllocation
Which of our assets to move for a margin call and why: every holding considered, with its rank or the constraint  that excluded it, and the lines chosen cheapest first, each carrying what a transaction moving it needs. Amounts  are in the agreement's base currency.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | **string** | The run the call belongs to. | 
**CallId** | **string** | The business key of the call within the run: agreement scope and code, item, margin type and direction joined with &#39;/&#39;. | 
**Direction** | **string** | Whether the collateral is delivered to the counterparty or recalled from it. One of Deliver or Recall. | 
**InventorySource** | **string** | Where the holdings were read from: RunStore for the proposal the run made, Live for a ranking against the holdings as they stand now. | 
**AsAt** | **DateTimeOffset** | The asAt the holdings and terms were read at. | 
**AgreementId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Item** | **string** | The margin item of the call. | [optional] 
**Counterparty** | [**CounterpartyIdentifier**](CounterpartyIdentifier.md) |  | [optional] 
**BusinessDate** | **DateTimeOffset?** | The business date of the call, which a transaction for a line trades on. | [optional] 
**Deadline** | **DateTimeOffset?** | When the movement must have settled under the agreement&#39;s cut label. Null when the agreement sets none. | [optional] 
**MarginAccount** | **string** | The code of the custodian account the item names for collateral we post, which a delivery moves assets into and a recall moves them out of. Null when the item names none. | [optional] 
**BaseCurrency** | **string** | The agreement&#39;s base currency, which every amount is in. | 
**RequiredAmount** | **decimal** | The collateral value to deliver, or for a recall the excess to take back. | 
**CoveredAmount** | **decimal** | The collateral value of the lines chosen: below the requirement when the inventory ran out, above it when a lot could not be split. | 
**CarryPerDay** | **decimal** | What the chosen lines cost the fund a day to leave locked up, in the base currency. | 
**AllCashCarryPerDay** | **decimal?** | What covering the whole call in base-currency cash would cost a day. Null when the cash rate is unavailable or for a recall. | [optional] 
**Candidates** | [**List&lt;CollateralAllocationCandidate&gt;**](CollateralAllocationCandidate.md) | Every holding considered, ranked ones first by rank, then the excluded with the constraint that excluded them. | 
**Allocation** | [**List&lt;CollateralAllocationLine&gt;**](CollateralAllocationLine.md) | The assets chosen, cheapest first, each with what a transaction moving it needs. | 

```csharp
using Lusid.Sdk.Model;
using System;

string runId = "runId";
string callId = "callId";
string direction = "direction";
string inventorySource = "inventorySource";
ResourceId? agreementId = new ResourceId();

string item = "example item";
CounterpartyIdentifier? counterparty = new CounterpartyIdentifier();

string marginAccount = "example marginAccount";
string baseCurrency = "baseCurrency";decimal requiredAmount = "requiredAmount";
decimal coveredAmount = "coveredAmount";
decimal carryPerDay = "carryPerDay";

List<CollateralAllocationCandidate> candidates = new List<CollateralAllocationCandidate>();
List<CollateralAllocationLine> allocation = new List<CollateralAllocationLine>();

CollateralAllocation collateralAllocationInstance = new CollateralAllocation(
    runId: runId,
    callId: callId,
    direction: direction,
    inventorySource: inventorySource,
    asAt: asAt,
    agreementId: agreementId,
    item: item,
    counterparty: counterparty,
    businessDate: businessDate,
    deadline: deadline,
    marginAccount: marginAccount,
    baseCurrency: baseCurrency,
    requiredAmount: requiredAmount,
    coveredAmount: coveredAmount,
    carryPerDay: carryPerDay,
    allCashCarryPerDay: allCashCarryPerDay,
    candidates: candidates,
    allocation: allocation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
