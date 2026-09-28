# Lusid.Sdk.Model.FundStructureEdge
A link from one member of a Fund Structure to another, and how that link is held.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | **string** | The node code of the member that holds the link: the investor or the owner. | 
**To** | [**FundStructureEdgeTarget**](FundStructureEdgeTarget.md) |  | 
**LinkageType** | **string** | How the link is held. DedicatedShareClass (the default) means the source invests into a share class of the target; DirectEquityInstrument, GPInterest, LPInterest and CarryInterest mean the source holds that interest in the target through the instrument in viaInstrumentId. Available values: DedicatedShareClass, DirectEquityInstrument, GPInterest, LPInterest, CarryInterest. | [optional] 
**ViaInstrumentId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string from = "from";
FundStructureEdgeTarget to = new FundStructureEdgeTarget();
string linkageType = "example linkageType";
ResourceId? viaInstrumentId = new ResourceId();


FundStructureEdge fundStructureEdgeInstance = new FundStructureEdge(
    from: from,
    to: to,
    linkageType: linkageType,
    viaInstrumentId: viaInstrumentId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
