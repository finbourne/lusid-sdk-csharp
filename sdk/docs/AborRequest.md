# Lusid.Sdk.Model.AborRequest
The request used to create an Abor.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code given for the Abor. | 
**DisplayName** | **string** | The name of the Abor. | 
**Description** | **string** | The description for the Abor. | [optional] 
**PortfolioIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The list with the portfolio ids which are part of the Abor. Note: These must all have the same base currency. | 
**AborConfigurationId** | [**ResourceId**](ResourceId.md) |  | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Abor. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "displayName";
string description = "example description";
List<PortfolioEntityId> portfolioIds = new List<PortfolioEntityId>();
ResourceId aborConfigurationId = new ResourceId();
Dictionary<string, Property> properties = new Dictionary<string, Property>();

AborRequest aborRequestInstance = new AborRequest(
    code: code,
    displayName: displayName,
    description: description,
    portfolioIds: portfolioIds,
    aborConfigurationId: aborConfigurationId,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
