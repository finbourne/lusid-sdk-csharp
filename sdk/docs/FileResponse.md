# Lusid.Sdk.Model.FileResponse
Allows a file (represented as a stream) to be returned from an Api call

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileStream** | **System.IO.Stream** |  | [optional] 
**ContentType** | **string** |  | [optional] 
**DownloadedFilename** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string contentType = "example contentType";
string downloadedFilename = "example downloadedFilename";

FileResponse fileResponseInstance = new FileResponse(
    fileStream: fileStream,
    contentType: contentType,
    downloadedFilename: downloadedFilename);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
