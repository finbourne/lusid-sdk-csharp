# Lusid.Sdk.Model.LegDefinition
Definition of the set of flow and index conventions along with other miscellaneous information required to generate an instrument leg.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConventionName** | [**FlowConventionName**](FlowConventionName.md) |  | [optional] 
**Conventions** | [**FlowConventions**](FlowConventions.md) |  | [optional] 
**IndexConvention** | [**IndexConvention**](IndexConvention.md) |  | [optional] 
**IndexConventionName** | [**FlowConventionName**](FlowConventionName.md) |  | [optional] 
**NotionalExchangeType** | **string** | what type of notional exchange does the leg have    Supported string (enumeration) values are: [None, Initial, Final, Both]. | 
**PayReceive** | **string** | Is the leg to be paid or received    Supported string (enumeration) values are: [Pay, Receive]. | 
**RateOrSpread** | **decimal** | Is there either a fixed rate (non-zero) or spread to be paid over the value of the leg. | 
**ResetConvention** | **string** | Control how resets are generated relative to swap payment convention(s).    Supported string (enumeration) values are: [InAdvance, InArrears]. | [optional] 
**StubType** | **string** | If a stub is required should it be at the front or back of the leg.    Supported string (enumeration) values are: [None, ShortFront, ShortBack, LongBack, LongFront, Both]. | 
**Compounding** | [**Compounding**](Compounding.md) |  | [optional] 
**Amortisation** | [**StepSchedule**](StepSchedule.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

