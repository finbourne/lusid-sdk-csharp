# Lusid.Sdk.Model.StagedModification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique Id for the staged modification | [optional] 
**AsAtStaged** | **DateTimeOffset** | Time at which the modification was staged. | [optional] 
**UserIdStaged** | **string** | Id of the user who created the stage modification request. | [optional] 
**RequestedIdStaged** | **string** | The Request Id that initiated this staged modification. | [optional] 
**RequestReason** | **string** | The Request Reason from the context that initiated this staged modification. | [optional] 
**Action** | **string** | Type of action of the staged modification, either create, update or delete. | [optional] 
**StagingRule** | [**StagedModificationStagingRule**](StagedModificationStagingRule.md) |  | [optional] 
**Decisions** | [**List&lt;StagedModificationDecision&gt;**](StagedModificationDecision.md) | Object containing information relating to the decision on the staged modification. | [optional] 
**DecisionsCount** | **int** | Number of decisions made. | [optional] 
**Status** | **string** | The status of the staged modification. | [optional] 
**AsAtClosed** | **DateTimeOffset?** | Time at which the modification was closed by either rejection or approval. | [optional] 
**EntityType** | **string** | The type of the entity that the staged modification applies to. | [optional] 
**Scope** | **string** | The scope of the entity that this staged modification applies to. | [optional] 
**EntityUniqueId** | **string** | The unique Id of the entity the staged modification applies to. | [optional] 
**RequestedChanges** | [**RequestedChanges**](RequestedChanges.md) |  | [optional] 
**EntityHrefs** | [**StagedModificationsEntityHrefs**](StagedModificationsEntityHrefs.md) |  | [optional] 
**DisplayName** | **string** | The display name of the entity the staged modification applies to. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

