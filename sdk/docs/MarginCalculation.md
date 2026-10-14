# Lusid.Sdk.Model.MarginCalculation
How the margin requirement for an item is calculated. The method field selects the method and the  remaining fields are the ones that method uses.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Method** | **string** | The calculation method. One of NetMtm, Ccp, GmraExposure, GmslaRcv, HouseRules, Simm, RegulatoryGrid or CcpIngested. Available values: NetMtm, Ccp, GmraExposure, GmslaRcv, HouseRules, Simm, RegulatoryGrid, CcpIngested. | 
**ExposureMethod** | **string** | For GmraExposure, the exposure method. One of Gmra2011A or Gmra2011B. Available values: Gmra2011A, Gmra2011B. | [optional] 
**RepricingPermitted** | **bool?** | For GmraExposure, whether repricing is permitted. | [optional] 
**MarginPercentage** | **decimal?** | For GmslaRcv, the margin percentage applied to the loan value. | [optional] 
**LendingFeeBps** | **int?** | For GmslaRcv, the lending fee in basis points. | [optional] 
**CreditLine** | **decimal?** | For HouseRules, the credit line extended to the counterparty. | [optional] 
**ThresholdAllocation** | [**ThresholdAllocation**](ThresholdAllocation.md) |  | [optional] 
**Ccp** | **string** | For CcpIngested, the name of the central counterparty. | [optional] 
**FcmAddOn** | **decimal?** | For CcpIngested, the add-on charged by the futures commission merchant. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string method = "method";
string exposureMethod = "example exposureMethod";
bool? repricingPermitted = //"True";
ThresholdAllocation? thresholdAllocation = new ThresholdAllocation();

string ccp = "example ccp";

MarginCalculation marginCalculationInstance = new MarginCalculation(
    method: method,
    exposureMethod: exposureMethod,
    repricingPermitted: repricingPermitted,
    marginPercentage: marginPercentage,
    lendingFeeBps: lendingFeeBps,
    creditLine: creditLine,
    thresholdAllocation: thresholdAllocation,
    ccp: ccp,
    fcmAddOn: fcmAddOn);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
