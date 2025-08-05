# Lusid.Sdk.Model.DataModelSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the Custom Data Model. | 
**Description** | **string** | A description for the Custom Data Model. | 
**EntityType** | **string** | The entity type that the Custom Data Model binds to. | 
**Type** | **string** | Either Root or Leaf or Intermediate. | 
**Precedence** | **int** | Where in the hierarchy this model sits. | 
**Parent** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Children** | [**List&lt;DataModelSummary&gt;**](DataModelSummary.md) | Child Custom Data Models that will inherit from this data model. | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

