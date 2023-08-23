# Lusid.Sdk.Model.ComplianceRuleResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleId** | **string** | The unique identifierof a compliance rule | 
**RuleName** | **string** | The User-given name of the rule | 
**RuleDescription** | **string** | The User-given description of the rule | 
**Portfolio** | [**ResourceId**](ResourceId.md) |  | 
**Passed** | **bool** | The result of an individual compliance run, true if passed | 
**ResultValue** | **decimal** | The calculation result that was used to confirm a pass/fail | 
**RuleInformationMatch** | **string** | The value matched by the rule | 
**RuleInformationKey** | **string** | The property key matched by the rule | 
**RuleLowerLimit** | **decimal** | The lower limit of the rule | 
**RuleUpperLimit** | **decimal** | The upper limit of the rule | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

