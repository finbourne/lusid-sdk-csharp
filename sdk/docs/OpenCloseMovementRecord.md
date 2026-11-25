# Lusid.Sdk.Model.OpenCloseMovementRecord
One row of the open, close and movement report: the net asset economic buckets at the opening and closing  of the window, the period's movements by economic bucket, and the requested valuation metrics and  instrument properties, per instrument or per kept sub-holding key.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**HoldingType** | **string** | The code for the type of the holding e.g. P, B, C, R, F etc. | [optional] 
**InstrumentScope** | **string** | The unique Lusid Instrument Id (LUID) of the instrument that the holding is in. | [optional] 
**InstrumentUid** | **string** | The unique Lusid Instrument Id (LUID) of the instrument that the holding is in. | [optional] 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The values of the sub-holding keys the request kept separate. Empty when the row is consolidated to the instrument. | [optional] 
**Currency** | **string** | The holding currency. | [optional] 
**Opening** | [**List&lt;EconomicBucketAmount&gt;**](EconomicBucketAmount.md) | The net asset economic buckets at the opening of the window, from the opening valuation. Empty when nothing was held. Amounts follow the journal entry line sign convention: a long position&#39;s balances are positive. Note that the A2B report&#39;s signs are the opposite for gains. | [optional] 
**Closing** | [**List&lt;EconomicBucketAmount&gt;**](EconomicBucketAmount.md) | The net asset economic buckets at the closing of the window, from the closing valuation. Empty when nothing is held. Signs as for the opening. | [optional] 
**Movements** | [**List&lt;EconomicBucketAmount&gt;**](EconomicBucketAmount.md) | The period&#39;s movements by economic bucket, component and variant, classified exactly as the journal entry lines classify them: the transaction lines of the window (cost flows in the NA buckets, carry, fees and realised gains in the PL buckets) plus the remeasurement of each net asset bucket between the two valuations, booked to its PL bucket. Signs follow the journal entry line convention, so income and gains are negative. The row reconciles as: closing &#x3D; opening + movements in NA buckets - movements in the remeasurement buckets (PL_UnrealPriceGL, PL_UnrealFXGL, PL_Accrued, PL_UnrealisedAmortised, PL_PIKAccrued, PL_DelayedCompensation); any residual is booked to PL_Rounding. | [optional] 
**OpeningMetrics** | **Dictionary&lt;string, decimal?&gt;** | The requested valuation metrics at the opening of the window, keyed by address key. Absent when nothing was held; null where the metric is unavailable or differs across the consolidated holdings. | [optional] 
**ClosingMetrics** | **Dictionary&lt;string, decimal?&gt;** | The requested valuation metrics at the closing of the window, keyed by address key, as the opening metrics. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The properties which have been requested to be decorated onto the holding. These will be from the &#39;Instrument&#39; domain. | [optional] 
**Errors** | [**List&lt;ResponseMetaData&gt;**](ResponseMetaData.md) | Any errors with the row are reported here, including metrics that could not be consolidated and reconciliation residuals beyond rounding. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? portfolioId = new ResourceId();

string holdingType = "example holdingType";
string instrumentScope = "example instrumentScope";
string instrumentUid = "example instrumentUid";
Dictionary<string, PerpetualProperty> subHoldingKeys = new Dictionary<string, PerpetualProperty>();
string currency = "example currency";
List<EconomicBucketAmount> opening = new List<EconomicBucketAmount>();
List<EconomicBucketAmount> closing = new List<EconomicBucketAmount>();
List<EconomicBucketAmount> movements = new List<EconomicBucketAmount>();
Dictionary<string, decimal?> openingMetrics = new Dictionary<string, decimal?>();
Dictionary<string, decimal?> closingMetrics = new Dictionary<string, decimal?>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
List<ResponseMetaData> errors = new List<ResponseMetaData>();

OpenCloseMovementRecord openCloseMovementRecordInstance = new OpenCloseMovementRecord(
    portfolioId: portfolioId,
    holdingType: holdingType,
    instrumentScope: instrumentScope,
    instrumentUid: instrumentUid,
    subHoldingKeys: subHoldingKeys,
    currency: currency,
    opening: opening,
    closing: closing,
    movements: movements,
    openingMetrics: openingMetrics,
    closingMetrics: closingMetrics,
    properties: properties,
    errors: errors);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
