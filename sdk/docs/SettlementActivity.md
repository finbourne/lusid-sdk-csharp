# Lusid.Sdk.Model.SettlementActivity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivityId** | **string** | A unique identifier for the settlement activity row, composed from the portfolio, activity type and the underlying transaction or settlement instruction. | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**ActivityType** | **string** | The type of settlement activity: Expected for outstanding units that are due or overdue, or Settled for units that have settled. Available values: Expected, Settled. | 
**ActivityBasis** | **string** | The basis on which the settlement activity arose: Inferred for outstanding units, Automatic for units settled per the portfolio&#39;s settlement configuration, or Instruction for units settled by a settlement instruction. Available values: Inferred, Automatic, Instruction. | 
**ActivityDate** | **DateTimeOffset** | The date of the settlement activity. For Expected activity this is the query&#39;s end activity date; for Automatic settlement it is the contractual settlement date; for Instruction settlement it is the instruction&#39;s actual settlement date. | 
**SettlementCategory** | **string** | The settlement category of the underlying movements. Available values: StockSettlement, CashSettlement, DeferredCashReceipt, NotApplicable. | 
**TransactionId** | **string** | The identifier of the transaction that gave rise to this settlement activity. Always populated for Expected and Settled activity. | [optional] 
**SettlementInstructionId** | **string** | The identifier of the settlement instruction that settled the activity. Populated only for Instruction settlement; null for Inferred and Automatic activity. | [optional] 
**HoldingIds** | **List&lt;long&gt;** | The identifiers of the holdings whose movements contributed to this settlement activity. | [optional] 
**LusidInstrumentId** | **string** | The LUSID instrument identifier (LUID) of the instrument being settled. | 
**InstrumentScope** | **string** | The scope in which the instrument is defined. | 
**ContractualSettlementDate** | **DateTimeOffset** | The contractual settlement date of the underlying movements. | 
**CustodianAccountId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**CustodianAccountNumber** | **string** | The account number of the associated custodian account, if any. | [optional] 
**CustodianAccountName** | **string** | The name of the associated custodian account, if any. | [optional] 
**Units** | **decimal** | The signed number of units settled or expected to settle for this activity. | 
**Direction** | **string** | The direction of the settlement from the portfolio&#39;s perspective. Available values: Debit, Credit. | 
**DaysOverdue** | **decimal?** | The number of days the activity is overdue, calculated as the activity date minus the contractual settlement date. Zero for settled activity. | [optional] 
**Transaction** | [**OutputTransaction**](OutputTransaction.md) |  | [optional] 
**SettlementInstruction** | [**TransactionSettlementInstruction**](TransactionSettlementInstruction.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string activityId = "activityId";
ResourceId portfolioId = new ResourceId();
string activityType = "activityType";
string activityBasis = "activityBasis";
string settlementCategory = "settlementCategory";
string transactionId = "example transactionId";
string settlementInstructionId = "example settlementInstructionId";
List<long> holdingIds = new List<long>();
string lusidInstrumentId = "lusidInstrumentId";
string instrumentScope = "instrumentScope";
ResourceId? custodianAccountId = new ResourceId();

string custodianAccountNumber = "example custodianAccountNumber";
string custodianAccountName = "example custodianAccountName";decimal units = "units";

string direction = "direction";
OutputTransaction? transaction = new OutputTransaction();

TransactionSettlementInstruction? settlementInstruction = new TransactionSettlementInstruction();


SettlementActivity settlementActivityInstance = new SettlementActivity(
    activityId: activityId,
    portfolioId: portfolioId,
    activityType: activityType,
    activityBasis: activityBasis,
    activityDate: activityDate,
    settlementCategory: settlementCategory,
    transactionId: transactionId,
    settlementInstructionId: settlementInstructionId,
    holdingIds: holdingIds,
    lusidInstrumentId: lusidInstrumentId,
    instrumentScope: instrumentScope,
    contractualSettlementDate: contractualSettlementDate,
    custodianAccountId: custodianAccountId,
    custodianAccountNumber: custodianAccountNumber,
    custodianAccountName: custodianAccountName,
    units: units,
    direction: direction,
    daysOverdue: daysOverdue,
    transaction: transaction,
    settlementInstruction: settlementInstruction);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
