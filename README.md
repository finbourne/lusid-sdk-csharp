# LUSID<sup>®</sup> C# SDK

This is the C# SDK for [LUSID by FINBOURNE](https://www.finbourne.com/lusid-technology), a bi-temporal investment management data platform with portfolio accounting capabilities. To use it you'll need a LUSID account. [Sign up for free at lusid.com](https://www.lusid.com/app/signup)

![LUSID_by_Finbourne](https://content.finbourne.com/LUSID_repo.png)

## Installation

The NuGet package for the LUSID SDK can installed from https://www.nuget.org/packages/Lusid.Sdk using the following:

```
$ dotnet add package Lusid.Sdk 
```

We publish two versions of the C# SDK:

* **lusid-sdk-csharp (this one) - supports `Production` and `Early Access` API endpoints**
* [lusid-sdk-csharp-preview](https://github.com/finbourne/lusid-sdk-csharp-preview) - supports `Production`, `Early Access`, `Beta` and `Experimental` API endpoints.

For more details on API endpoint categories, see [What is the LUSID feature release lifecycle?](https://support.lusid.com/knowledgebase/article/KA-01786/en-us).
To find out which category an API endpoint falls into, see [LUSID API Documentation](https://www.lusid.com/api/swagger/index.html).



## Documentation

For further documentation on building the SDK, running the tutorials and using the SDK please see the [wiki](https://github.com/finbourne/lusid-sdk-csharp/wiki).

Documentation for namespaces, interfaces, classes, functions and other members of the 
SDK is [available to view online](https://lusid-sdk-csharp.readthedocs.io/en/latest/).

## Build Status 

| branch | status |
| --- | --- |
| `master` |  ![Nuget](https://img.shields.io/nuget/v/Lusid.Sdk?color=blue) ![run-sdk-tests](https://github.com/finbourne/lusid-sdk-csharp/workflows/run-sdk-tests/badge.svg?branch=master)|
| `develop` | ![run-sdk-tests](https://github.com/finbourne/lusid-sdk-csharp/workflows/run-sdk-tests/badge.svg?branch=develop) |
