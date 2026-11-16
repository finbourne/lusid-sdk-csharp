# Lusid.Sdk.Model.SideDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Side** | **string** | A unique label identifying the side definition. | 
**Security** | **string** | The field or property key defining the side&#39;s security, or instrument. | 
**Currency** | **string** | The field or property key defining the side&#39;s currency. | 
**Rate** | **string** | The field or property key defining the side&#39;s rate. | 
**Units** | **string** | The value, field or property key defining the side&#39;s units. | 
**Amount** | **string** | The value, field or property key defining the side&#39;s amount | 
**NotionalAmount** | **string** | The value, field or property key defining the side&#39;s notional amount | [optional] 
**CurrentFace** | **string** | The value, field or property key defining the side&#39;s current face / outstanding notional. | [optional] 
**Scope** | **string** | The scope in which the side definition exists. | [optional] 
**Metadata** | **Dictionary&lt;string, List&lt;ResponseMetaData&gt;&gt;** | Contains warnings related to the side definition, such as a stored copy of a platform side that differs from the platform&#39;s current definition. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string side = "side";
string security = "security";
string currency = "currency";
string rate = "rate";
string units = "units";
string amount = "amount";
string notionalAmount = "example notionalAmount";
string currentFace = "example currentFace";
string scope = "example scope";
Dictionary<string, List<ResponseMetaData>> metadata = new Dictionary<string, List<ResponseMetaData>>();
List<Link> links = new List<Link>();

SideDefinition sideDefinitionInstance = new SideDefinition(
    side: side,
    security: security,
    currency: currency,
    rate: rate,
    units: units,
    amount: amount,
    notionalAmount: notionalAmount,
    currentFace: currentFace,
    scope: scope,
    metadata: metadata,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
