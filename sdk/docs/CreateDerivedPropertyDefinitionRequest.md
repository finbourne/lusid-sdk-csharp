# Lusid.Sdk.Model.CreateDerivedPropertyDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domain** | **string** | The domain that the property exists in. Not all available values are currently supported, please check the documentation: https://support.lusid.com/knowledgebase/article/KA-01719/. Available values: Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, PortfolioGroup, Person, Order, Allocation, Calendar, LegalEntity, InvestorRecord, InvestmentAccount, Placement, Execution, Block, Participation, Package, OrderInstruction, CustomEntity, InstrumentEvent, Account, ChartOfAccounts, CustodianAccount, CheckDefinition, Abor, AborConfiguration, Fund, FundConfiguration, Fee, Reconciliation, PropertyDefinition, Compliance, DiaryEntry, Leg, DerivedValuation, Timeline, ClosedPeriod, TaskDefinition, Workflow, IdentifierDefinition, SettlementInstruction, TransactionFeeType. | 
**Scope** | **string** | The scope that the property exists in. | 
**Code** | **string** | The code of the property. Together with the domain and scope this uniquely identifies the property. | 
**DisplayName** | **string** | The display name of the property. | 
**DataTypeId** | [**ResourceId**](ResourceId.md) |  | 
**PropertyDescription** | **string** | Describes the property | [optional] 
**DerivationFormula** | **string** | The rule that defines how data is composed for a derived property. | 
**IsFilterable** | **bool** | Bool indicating whether the values of this property are fitlerable, this is true for all non-derived property defintions.  For a derived definition this must be set true to enable filtering. | 
**ValueFormat** | **string** | The format in which values for this property definition should be represented. Available values: Text, Html. | [optional] 
**CustomEntityType** | **string** | The custom entity type that this derived property definition can be applied to. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string domain = "domain";
string scope = "scope";
string code = "code";
string displayName = "displayName";
ResourceId dataTypeId = new ResourceId();
string propertyDescription = "example propertyDescription";
string derivationFormula = "derivationFormula";
bool isFilterable = //"True";
string valueFormat = "example valueFormat";
string customEntityType = "example customEntityType";

CreateDerivedPropertyDefinitionRequest createDerivedPropertyDefinitionRequestInstance = new CreateDerivedPropertyDefinitionRequest(
    domain: domain,
    scope: scope,
    code: code,
    displayName: displayName,
    dataTypeId: dataTypeId,
    propertyDescription: propertyDescription,
    derivationFormula: derivationFormula,
    isFilterable: isFilterable,
    valueFormat: valueFormat,
    customEntityType: customEntityType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
