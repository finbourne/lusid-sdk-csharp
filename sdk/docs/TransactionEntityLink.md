# Lusid.Sdk.Model.TransactionEntityLink

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | Available values: Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, PortfolioGroup, Person, Order, Allocation, Calendar, LegalEntity, InvestorRecord, InvestmentAccount, Placement, Execution, Block, Participation, Package, OrderInstruction, CustomEntity, InstrumentEvent, Account, ChartOfAccounts, CustodianAccount, CheckDefinition, Abor, AborConfiguration, Fund, FundConfiguration, FundStructure, Fee, Reconciliation, PropertyDefinition, Compliance, DiaryEntry, Leg, DerivedValuation, Timeline, ClosedPeriod, TaskDefinition, Workflow, IdentifierDefinition, SettlementInstruction, TransactionFeeType, PaymentInstruction, Transfer, RecDefinition, RecResult, JournalEntry. | 
**EntityId** | **Dictionary&lt;string, string&gt;** |  | 
**RestrictEditing** | **bool** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "entityType";
Dictionary<string, string> entityId = new Dictionary<string, string>();
bool restrictEditing = //"True";

TransactionEntityLink transactionEntityLinkInstance = new TransactionEntityLink(
    entityType: entityType,
    entityId: entityId,
    restrictEditing: restrictEditing);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
