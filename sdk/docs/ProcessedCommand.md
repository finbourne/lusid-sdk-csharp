# Lusid.Sdk.Model.ProcessedCommand
The list of commands.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | The description of the command issued. | 
**Path** | **string** | The unique identifier for the command including the request id. | [optional] 
**UserId** | [**User**](User.md) |  | 
**ProcessedTime** | **DateTimeOffset** | The asAt datetime that the events published by the processing of this command were committed to LUSID. | 

```csharp
using Lusid.Sdk.Model;
using System;

string description = "description";
string path = "example path";
User userId = new User();

ProcessedCommand processedCommandInstance = new ProcessedCommand(
    description: description,
    path: path,
    userId: userId,
    processedTime: processedTime);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
