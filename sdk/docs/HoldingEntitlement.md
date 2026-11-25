# Lusid.Sdk.Model.HoldingEntitlement
What one holding receives under a corporate action, in the client's own figures.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HoldingEntitlementId** | **string** | The unique identifier of the entitlement within the portfolio | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**HoldingId** | **long** | The id of the holding the entitlement is for, as the holdings endpoints report it | [optional] 
**InstrumentScope** | **string** | The scope of the holding&#39;s instrument | [optional] 
**InstrumentId** | **string** | The LUSID instrument identifier of the holding&#39;s instrument | [optional] 
**ExDate** | **DateTimeOffset** | The date the entitlement is booked at. Must be in UTC | [optional] 
**PaymentDate** | **DateTimeOffset** | The date the entitlement&#39;s transactions settle. Must be in UTC and not before the ex date | [optional] 
**AnnouncementDate** | **DateTimeOffset?** | The date the corporate action was announced. Optional; must be in UTC and not after the ex date | [optional] 
**RecordDate** | **DateTimeOffset?** | The date on which holders are recorded as entitled. Optional; must be in UTC and not after the payment date | [optional] 
**Description** | **string** | A description of the entitlement | [optional] 
**ParentUnitsRetained** | **decimal?** | The units of the parent holding that the holder keeps. The remainder of the holding leaves the parent. Cannot be given with ParentUnitsDelivered | [optional] 
**ParentUnitsDelivered** | **decimal?** | The units of the parent holding that leave it. The alternative to ParentUnitsRetained. Where neither is given, no units leave the parent | [optional] 
**ParentCostAdjustment** | **decimal?** | A signed adjustment to the parent holding&#39;s cost, apportioned across its tax lots. Used where cost moves with no child position and no cash | [optional] 
**ParentLotSelection** | **string** | How the parent&#39;s units leave its tax lots when they are realised. ProRata takes units from every lot in proportion to its units. PortfolioSalesRule takes them by the portfolio&#39;s accounting method. A departure at book value is always pro rata. The default is ProRata | [optional] 
**ChildLotTreatment** | **string** | The tax lots of a position that carries the parent&#39;s cost, from a CarryCost or ReceiveAndSell leg. RetainLots gives one lot for each parent lot, with that lot&#39;s purchase date. NewLot gives one lot with the ex date as its purchase date. The default is RetainLots. A ParentLotSelection of PortfolioSalesRule requires NewLot | [optional] 
**CapitalAdjustmentSpread** | **string** | How a return of capital and income reclassified as capital are spread across the parent&#39;s tax lots. ByCost spreads by each lot&#39;s cost, and ByUnits by each lot&#39;s units. The default is ByCost | [optional] 
**TransactionProperties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The transaction properties to set on every transaction the entitlement books, at most 100. Each must be in the Transaction domain. A value given here replaces the value the transaction template gives for the same property, and a leg&#39;s value replaces it on the transactions of that leg. A property that is a sub-holding key of the portfolio cannot be given | [optional] 
**Legs** | [**List&lt;EntitlementLeg&gt;**](EntitlementLeg.md) | The child positions and cash movements the corporate action produces for this holding, at most 100. May be empty where the entitlement only adjusts the parent&#39;s cost | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Href** | **string** | The uri for this version of this entitlement | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string holdingEntitlementId = "example holdingEntitlementId";
ResourceId? portfolioId = new ResourceId();

string instrumentScope = "example instrumentScope";
string instrumentId = "example instrumentId";
string description = "example description";
string parentLotSelection = "example parentLotSelection";
string childLotTreatment = "example childLotTreatment";
string capitalAdjustmentSpread = "example capitalAdjustmentSpread";
Dictionary<string, PerpetualProperty> transactionProperties = new Dictionary<string, PerpetualProperty>();
List<EntitlementLeg> legs = new List<EntitlementLeg>();
ModelVersion? varVersion = new ModelVersion();

string href = "example href";
List<Link> links = new List<Link>();

HoldingEntitlement holdingEntitlementInstance = new HoldingEntitlement(
    holdingEntitlementId: holdingEntitlementId,
    portfolioId: portfolioId,
    holdingId: holdingId,
    instrumentScope: instrumentScope,
    instrumentId: instrumentId,
    exDate: exDate,
    paymentDate: paymentDate,
    announcementDate: announcementDate,
    recordDate: recordDate,
    description: description,
    parentUnitsRetained: parentUnitsRetained,
    parentUnitsDelivered: parentUnitsDelivered,
    parentCostAdjustment: parentCostAdjustment,
    parentLotSelection: parentLotSelection,
    childLotTreatment: childLotTreatment,
    capitalAdjustmentSpread: capitalAdjustmentSpread,
    transactionProperties: transactionProperties,
    legs: legs,
    varVersion: varVersion,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
