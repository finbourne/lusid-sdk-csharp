/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-10\">-10</a>|Server Configuration Error|  | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"102\">102</a>|Version Not Found|  | | <a name=\"103\">103</a>|Api Rate Limit Violation|  | | <a name=\"104\">104</a>|Instrument Not Found|  | | <a name=\"105\">105</a>|Property Not Found|  | | <a name=\"106\">106</a>|Portfolio Recursion Depth|  | | <a name=\"108\">108</a>|Group Not Found|  | | <a name=\"109\">109</a>|Portfolio Not Found|  | | <a name=\"110\">110</a>|Property Schema Not Found|  | | <a name=\"111\">111</a>|Portfolio Ancestry Not Found|  | | <a name=\"112\">112</a>|Portfolio With Id Already Exists|  | | <a name=\"113\">113</a>|Orphaned Portfolio|  | | <a name=\"119\">119</a>|Missing Base Claims|  | | <a name=\"121\">121</a>|Property Not Defined|  | | <a name=\"122\">122</a>|Cannot Delete System Property|  | | <a name=\"123\">123</a>|Cannot Modify Immutable Property Field|  | | <a name=\"124\">124</a>|Property Already Exists|  | | <a name=\"125\">125</a>|Invalid Property Life Time|  | | <a name=\"126\">126</a>|Property Constraint Style Excludes Properties|  | | <a name=\"127\">127</a>|Cannot Modify Default Data Type|  | | <a name=\"128\">128</a>|Group Already Exists|  | | <a name=\"129\">129</a>|No Such Data Type|  | | <a name=\"130\">130</a>|Undefined Value For Data Type|  | | <a name=\"131\">131</a>|Unsupported Value Type Defined On Data Type|  | | <a name=\"132\">132</a>|Validation Error|  | | <a name=\"133\">133</a>|Loop Detected In Group Hierarchy|  | | <a name=\"134\">134</a>|Undefined Acceptable Values|  | | <a name=\"135\">135</a>|Sub Group Already Exists|  | | <a name=\"138\">138</a>|Price Source Not Found|  | | <a name=\"139\">139</a>|Analytic Store Not Found|  | | <a name=\"141\">141</a>|Analytic Store Already Exists|  | | <a name=\"143\">143</a>|Client Instrument Already Exists|  | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"147\">147</a>|Results Not Found|  | | <a name=\"148\">148</a>|Order Field Not In Result Set|  | | <a name=\"149\">149</a>|Operation Failed|  | | <a name=\"150\">150</a>|Elastic Search Error|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"153\">153</a>|Command Processing Failure|  | | <a name=\"154\">154</a>|Entity State Construction Failure|  | | <a name=\"155\">155</a>|Entity Timeline Does Not Exist|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"158\">158</a>|Event Publish Unknown|  | | <a name=\"159\">159</a>|Event Query Failure|  | | <a name=\"160\">160</a>|Blob Did Not Exist|  | | <a name=\"162\">162</a>|Sub System Request Failure|  | | <a name=\"163\">163</a>|Sub System Configuration Failure|  | | <a name=\"165\">165</a>|Failed To Delete|  | | <a name=\"166\">166</a>|Upsert Client Instrument Failure|  | | <a name=\"167\">167</a>|Illegal As At Interval|  | | <a name=\"168\">168</a>|Illegal Bitemporal Query|  | | <a name=\"169\">169</a>|Invalid Alternate Id|  | | <a name=\"170\">170</a>|Cannot Add Source Portfolio Property Explicitly|  | | <a name=\"171\">171</a>|Entity Already Exists In Group|  | | <a name=\"173\">173</a>|Entity With Id Already Exists|  | | <a name=\"174\">174</a>|Derived Portfolio Details Do Not Exist|  | | <a name=\"175\">175</a>|Entity Not In Group|  | | <a name=\"176\">176</a>|Portfolio With Name Already Exists|  | | <a name=\"177\">177</a>|Invalid Transactions|  | | <a name=\"178\">178</a>|Reference Portfolio Not Found|  | | <a name=\"179\">179</a>|Duplicate Id|  | | <a name=\"180\">180</a>|Command Retrieval Failure|  | | <a name=\"181\">181</a>|Data Filter Application Failure|  | | <a name=\"182\">182</a>|Search Failed|  | | <a name=\"183\">183</a>|Movements Engine Configuration Key Failure|  | | <a name=\"184\">184</a>|Fx Rate Source Not Found|  | | <a name=\"185\">185</a>|Accrual Source Not Found|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"188\">188</a>|Invalid Request Headers|  | | <a name=\"189\">189</a>|Price Not Found|  | | <a name=\"190\">190</a>|Invalid Sub Holding Keys Provided|  | | <a name=\"191\">191</a>|Duplicate Sub Holding Keys Provided|  | | <a name=\"192\">192</a>|Cut Definition Not Found|  | | <a name=\"193\">193</a>|Cut Definition Invalid|  | | <a name=\"194\">194</a>|Time Variant Property Deletion Date Unspecified|  | | <a name=\"195\">195</a>|Perpetual Property Deletion Date Specified|  | | <a name=\"196\">196</a>|Time Variant Property Upsert Date Unspecified|  | | <a name=\"197\">197</a>|Perpetual Property Upsert Date Specified|  | | <a name=\"200\">200</a>|Invalid Unit For Data Type|  | | <a name=\"201\">201</a>|Invalid Type For Data Type|  | | <a name=\"202\">202</a>|Invalid Value For Data Type|  | | <a name=\"203\">203</a>|Unit Not Defined For Data Type|  | | <a name=\"204\">204</a>|Units Not Supported On Data Type|  | | <a name=\"205\">205</a>|Cannot Specify Units On Data Type|  | | <a name=\"206\">206</a>|Unit Schema Inconsistent With Data Type|  | | <a name=\"207\">207</a>|Unit Definition Not Specified|  | | <a name=\"208\">208</a>|Duplicate Unit Definitions Specified|  | | <a name=\"209\">209</a>|Invalid Units Definition|  | | <a name=\"210\">210</a>|Invalid Instrument Identifier Unit|  | | <a name=\"211\">211</a>|Holdings Adjustment Does Not Exist|  | | <a name=\"212\">212</a>|Could Not Build Excel Url|  | | <a name=\"213\">213</a>|Could Not Get Excel Version|  | | <a name=\"214\">214</a>|Instrument By Code Not Found|  | | <a name=\"215\">215</a>|Entity Schema Does Not Exist|  | | <a name=\"216\">216</a>|Feature Not Supported On Portfolio Type|  | | <a name=\"217\">217</a>|Quote Not Found|  | | <a name=\"218\">218</a>|Invalid Quote Identifier|  | | <a name=\"219\">219</a>|Invalid Metric For Data Type|  | | <a name=\"220\">220</a>|Invalid Instrument Definition|  | | <a name=\"221\">221</a>|Instrument Upsert Failure|  | | <a name=\"222\">222</a>|Reference Portfolio Request Not Supported|  | | <a name=\"223\">223</a>|Transaction Portfolio Request Not Supported|  | | <a name=\"224\">224</a>|Invalid Property Value Assignment|  | | <a name=\"230\">230</a>|Transaction Type Not Found|  | | <a name=\"231\">231</a>|Transaction Type Duplication|  | | <a name=\"232\">232</a>|Portfolio Does Not Exist At Given Date|  | | <a name=\"233\">233</a>|Query Parser Failure|  | | <a name=\"234\">234</a>|Duplicate Constituent|  | | <a name=\"235\">235</a>|Unresolved Instrument Constituent|  | | <a name=\"236\">236</a>|Unresolved Instrument In Transition|  | | <a name=\"237\">237</a>|Missing Side Definitions|  | | <a name=\"299\">299</a>|Invalid Recipe|  | | <a name=\"300\">300</a>|Missing Recipe|  | | <a name=\"301\">301</a>|Dependencies|  | | <a name=\"304\">304</a>|Portfolio Preprocess Failure|  | | <a name=\"310\">310</a>|Valuation Engine Failure|  | | <a name=\"311\">311</a>|Task Factory Failure|  | | <a name=\"312\">312</a>|Task Evaluation Failure|  | | <a name=\"313\">313</a>|Task Generation Failure|  | | <a name=\"314\">314</a>|Engine Configuration Failure|  | | <a name=\"315\">315</a>|Model Specification Failure|  | | <a name=\"320\">320</a>|Market Data Key Failure|  | | <a name=\"321\">321</a>|Market Resolver Failure|  | | <a name=\"322\">322</a>|Market Data Failure|  | | <a name=\"330\">330</a>|Curve Failure|  | | <a name=\"331\">331</a>|Volatility Surface Failure|  | | <a name=\"332\">332</a>|Volatility Cube Failure|  | | <a name=\"350\">350</a>|Instrument Failure|  | | <a name=\"351\">351</a>|Cash Flows Failure|  | | <a name=\"352\">352</a>|Reference Data Failure|  | | <a name=\"360\">360</a>|Aggregation Failure|  | | <a name=\"361\">361</a>|Aggregation Measure Failure|  | | <a name=\"370\">370</a>|Result Retrieval Failure|  | | <a name=\"371\">371</a>|Result Processing Failure|  | | <a name=\"372\">372</a>|Vendor Result Processing Failure|  | | <a name=\"373\">373</a>|Vendor Result Mapping Failure|  | | <a name=\"374\">374</a>|Vendor Library Unauthorised|  | | <a name=\"375\">375</a>|Vendor Connectivity Error|  | | <a name=\"376\">376</a>|Vendor Interface Error|  | | <a name=\"377\">377</a>|Vendor Pricing Failure|  | | <a name=\"378\">378</a>|Vendor Translation Failure|  | | <a name=\"379\">379</a>|Vendor Key Mapping Failure|  | | <a name=\"380\">380</a>|Vendor Reflection Failure|  | | <a name=\"381\">381</a>|Vendor Process Failure|  | | <a name=\"382\">382</a>|Vendor System Failure|  | | <a name=\"390\">390</a>|Attempt To Upsert Duplicate Quotes|  | | <a name=\"391\">391</a>|Corporate Action Source Does Not Exist|  | | <a name=\"392\">392</a>|Corporate Action Source Already Exists|  | | <a name=\"393\">393</a>|Instrument Identifier Already In Use|  | | <a name=\"394\">394</a>|Properties Not Found|  | | <a name=\"395\">395</a>|Batch Operation Aborted|  | | <a name=\"400\">400</a>|Invalid Iso4217 Currency Code|  | | <a name=\"401\">401</a>|Cannot Assign Instrument Identifier To Currency|  | | <a name=\"402\">402</a>|Cannot Assign Currency Identifier To Non Currency|  | | <a name=\"403\">403</a>|Currency Instrument Cannot Be Deleted|  | | <a name=\"404\">404</a>|Currency Instrument Cannot Have Economic Definition|  | | <a name=\"405\">405</a>|Currency Instrument Cannot Have Lookthrough Portfolio|  | | <a name=\"406\">406</a>|Cannot Create Currency Instrument With Multiple Identifiers|  | | <a name=\"407\">407</a>|Specified Currency Is Undefined|  | | <a name=\"410\">410</a>|Index Does Not Exist|  | | <a name=\"411\">411</a>|Sort Field Does Not Exist|  | | <a name=\"413\">413</a>|Negative Pagination Parameters|  | | <a name=\"414\">414</a>|Invalid Search Syntax|  | | <a name=\"415\">415</a>|Filter Execution Timeout|  | | <a name=\"420\">420</a>|Side Definition Inconsistent|  | | <a name=\"450\">450</a>|Invalid Quote Access Metadata Rule|  | | <a name=\"451\">451</a>|Access Metadata Not Found|  | | <a name=\"452\">452</a>|Invalid Access Metadata Identifier|  | | <a name=\"460\">460</a>|Standard Resource Not Found|  | | <a name=\"461\">461</a>|Standard Resource Conflict|  | | <a name=\"462\">462</a>|Calendar Not Found|  | | <a name=\"463\">463</a>|Date In A Calendar Not Found|  | | <a name=\"464\">464</a>|Invalid Date Source Data|  | | <a name=\"465\">465</a>|Invalid Timezone|  | | <a name=\"601\">601</a>|Person Identifier Already In Use|  | | <a name=\"602\">602</a>|Person Not Found|  | | <a name=\"603\">603</a>|Cannot Set Identifier|  | | <a name=\"617\">617</a>|Invalid Recipe Specification In Request|  | | <a name=\"618\">618</a>|Inline Recipe Deserialisation Failure|  | | <a name=\"619\">619</a>|Identifier Types Not Set For Entity|  | | <a name=\"620\">620</a>|Cannot Delete All Client Defined Identifiers|  | | <a name=\"650\">650</a>|The Order requested was not found.|  | | <a name=\"654\">654</a>|The Allocation requested was not found.|  | | <a name=\"655\">655</a>|Cannot build the fx forward target with the given holdings.|  | | <a name=\"656\">656</a>|Group does not contain expected entities.|  | | <a name=\"665\">665</a>|Destination directory not found|  | | <a name=\"667\">667</a>|Relation definition already exists|  | | <a name=\"672\">672</a>|Could not retrieve file contents|  | | <a name=\"673\">673</a>|Missing entitlements for entities in Group|  | | <a name=\"674\">674</a>|Next Best Action not found|  | | <a name=\"676\">676</a>|Relation definition not defined|  | | <a name=\"677\">677</a>|Invalid entity identifier for relation|  | | <a name=\"681\">681</a>|Sorting by specified field not supported|One or more of the provided fields to order by were either invalid or not supported. | | <a name=\"682\">682</a>|Too many fields to sort by|The number of fields to sort the data by exceeds the number allowed by the endpoint | | <a name=\"684\">684</a>|Sequence Not Found|  | | <a name=\"685\">685</a>|Sequence Already Exists|  | | <a name=\"686\">686</a>|Non-cycling sequence has been exhausted|  | | <a name=\"687\">687</a>|Legal Entity Identifier Already In Use|  | | <a name=\"688\">688</a>|Legal Entity Not Found|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"690\">690</a>|Property Type Is Not Supported|  | | <a name=\"691\">691</a>|Multiple Tax-lots For Currency Type Is Not Supported|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"693\">693</a>|Entity type is not supported for Relationship|  | | <a name=\"694\">694</a>|Relationship Validation Failure|  | | <a name=\"695\">695</a>|Relationship Not Found|  | | <a name=\"697\">697</a>|Derived Property Formula No Longer Valid|  | | <a name=\"698\">698</a>|Story is not available|  | | <a name=\"703\">703</a>|Corporate Action Does Not Exist|  | | <a name=\"720\">720</a>|The provided sort and filter combination is not valid|  | | <a name=\"721\">721</a>|A2B generation failed|  | | <a name=\"722\">722</a>|Aggregated Return Calculation Failure|  | | <a name=\"723\">723</a>|Custom Entity Definition Identifier Already In Use|  | | <a name=\"724\">724</a>|Custom Entity Definition Not Found|  | | <a name=\"725\">725</a>|The Placement requested was not found.|  | | <a name=\"726\">726</a>|The Execution requested was not found.|  | | <a name=\"727\">727</a>|The Block requested was not found.|  | | <a name=\"728\">728</a>|The Participation requested was not found.|  | | <a name=\"729\">729</a>|The Package requested was not found.|  | | <a name=\"730\">730</a>|The OrderInstruction requested was not found.|  | | <a name=\"732\">732</a>|Custom Entity not found.|  | | <a name=\"733\">733</a>|Custom Entity Identifier already in use.|  | | <a name=\"735\">735</a>|Calculation Failed.|  | | <a name=\"736\">736</a>|An expected key on HttpResponse is missing.|  | | <a name=\"737\">737</a>|A required fee detail is missing.|  | | <a name=\"738\">738</a>|Zero rows were returned from Luminesce|  | | <a name=\"739\">739</a>|Provided Weekend Mask was invalid|  | | <a name=\"742\">742</a>|Custom Entity fields do not match the definition|  | | <a name=\"746\">746</a>|The provided sequence is not valid.|  | | <a name=\"751\">751</a>|The type of the Custom Entity is different than the type provided in the definition.|  | | <a name=\"752\">752</a>|Luminesce process returned an error.|  | | <a name=\"753\">753</a>|File name or content incompatible with operation.|  | | <a name=\"755\">755</a>|Schema of response from Drive is not as expected.|  | | <a name=\"757\">757</a>|Schema of response from Luminesce is not as expected.|  | | <a name=\"758\">758</a>|Luminesce timed out.|  | | <a name=\"763\">763</a>|Invalid Lusid Entity Identifier Unit|  | | <a name=\"768\">768</a>|Fee rule not found.|  | | <a name=\"769\">769</a>|Cannot update the base currency of a portfolio with transactions loaded|  | | <a name=\"771\">771</a>|Transaction configuration source not found|  | | <a name=\"774\">774</a>|Compliance rule not found.|  | | <a name=\"775\">775</a>|Fund accounting document cannot be processed.|  | | <a name=\"778\">778</a>|Unable to look up FX rate from trade ccy to portfolio ccy for some of the trades.|  | | <a name=\"782\">782</a>|The Property definition dataType is not matching the derivation formula dataType|  | | <a name=\"783\">783</a>|The Property definition domain is not supported for derived properties|  | | <a name=\"788\">788</a>|Compliance run not found failure.|  | | <a name=\"790\">790</a>|Custom Entity has missing or invalid identifiers|  | | <a name=\"791\">791</a>|Custom Entity definition already exists|  | | <a name=\"792\">792</a>|Compliance PropertyKey is missing.|  | | <a name=\"793\">793</a>|Compliance Criteria Value for matching is missing.|  | | <a name=\"795\">795</a>|Cannot delete identifier definition|  | | <a name=\"796\">796</a>|Tax rule set not found.|  | | <a name=\"797\">797</a>|Multiple rule sets for the same property key are applicable.|  | | <a name=\"800\">800</a>|Can not upsert an instrument event of this type.|  | | <a name=\"801\">801</a>|The instrument event does not exist.|  | | <a name=\"802\">802</a>|The Instrument event is missing salient information.|  | | <a name=\"803\">803</a>|The Instrument event could not be processed.|  | | <a name=\"804\">804</a>|Some data requested does not follow the order graph assumptions.|  | | <a name=\"811\">811</a>|A price could not be found for an order.|  | | <a name=\"812\">812</a>|A price could not be found for an allocation.|  | 
 *
 * The version of the OpenAPI document: 0.11.4820
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Lusid.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataTypesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EARLY ACCESS] CreateDataType: Create data type definition
        /// </summary>
        /// <remarks>
        /// Create a new data type definition    Data types cannot be created in either the \&quot;default\&quot; or \&quot;system\&quot; scopes.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDataTypeRequest">The definition of the new data type (optional)</param>
        /// <returns>DataType</returns>
        DataType CreateDataType(CreateDataTypeRequest createDataTypeRequest = default(CreateDataTypeRequest));

        /// <summary>
        /// [EARLY ACCESS] CreateDataType: Create data type definition
        /// </summary>
        /// <remarks>
        /// Create a new data type definition    Data types cannot be created in either the \&quot;default\&quot; or \&quot;system\&quot; scopes.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDataTypeRequest">The definition of the new data type (optional)</param>
        /// <returns>ApiResponse of DataType</returns>
        ApiResponse<DataType> CreateDataTypeWithHttpInfo(CreateDataTypeRequest createDataTypeRequest = default(CreateDataTypeRequest));
        /// <summary>
        /// GetDataType: Get data type definition
        /// </summary>
        /// <remarks>
        /// Get the definition of a specified data type
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the data type definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <returns>DataType</returns>
        DataType GetDataType(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// GetDataType: Get data type definition
        /// </summary>
        /// <remarks>
        /// Get the definition of a specified data type
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the data type definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <returns>ApiResponse of DataType</returns>
        ApiResponse<DataType> GetDataTypeWithHttpInfo(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] GetUnitsFromDataType: Get units from data type
        /// </summary>
        /// <remarks>
        /// Get the definitions of the specified units associated bound to a specific data type
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="units">One or more unit identifiers for which the definition is being requested (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Schema, use \&quot;schema eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="asAt">Optional. The as at of the requested data type (optional)</param>
        /// <returns>ResourceListOfIUnitDefinitionDto</returns>
        ResourceListOfIUnitDefinitionDto GetUnitsFromDataType(string scope, string code, List<string> units = default(List<string>), string filter = default(string), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] GetUnitsFromDataType: Get units from data type
        /// </summary>
        /// <remarks>
        /// Get the definitions of the specified units associated bound to a specific data type
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="units">One or more unit identifiers for which the definition is being requested (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Schema, use \&quot;schema eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="asAt">Optional. The as at of the requested data type (optional)</param>
        /// <returns>ApiResponse of ResourceListOfIUnitDefinitionDto</returns>
        ApiResponse<ResourceListOfIUnitDefinitionDto> GetUnitsFromDataTypeWithHttpInfo(string scope, string code, List<string> units = default(List<string>), string filter = default(string), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] ListDataTypeSummaries: List all data type summaries, without the reference data
        /// </summary>
        /// <remarks>
        /// List all data type summaries
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the data type summaries. Defaults to returning the latest version               of each summary if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing data type summaries. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.                For example, to filter on the Scope, use \&quot;id.scope eq &#39;myscope&#39;\&quot;, to filter on Schema, use \&quot;schema eq &#39;string&#39;\&quot;,               to filter on AcceptableValues use \&quot;acceptableValues any (~ eq &#39;value&#39;)\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="sortBy">Sort the results by these fields. Use use the &#39;-&#39; sign to denote descending allocation e.g. -MyFieldName. (optional)</param>
        /// <returns>PagedResourceListOfDataTypeSummary</returns>
        PagedResourceListOfDataTypeSummary ListDataTypeSummaries(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> sortBy = default(List<string>));

        /// <summary>
        /// [EARLY ACCESS] ListDataTypeSummaries: List all data type summaries, without the reference data
        /// </summary>
        /// <remarks>
        /// List all data type summaries
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the data type summaries. Defaults to returning the latest version               of each summary if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing data type summaries. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.                For example, to filter on the Scope, use \&quot;id.scope eq &#39;myscope&#39;\&quot;, to filter on Schema, use \&quot;schema eq &#39;string&#39;\&quot;,               to filter on AcceptableValues use \&quot;acceptableValues any (~ eq &#39;value&#39;)\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="sortBy">Sort the results by these fields. Use use the &#39;-&#39; sign to denote descending allocation e.g. -MyFieldName. (optional)</param>
        /// <returns>ApiResponse of PagedResourceListOfDataTypeSummary</returns>
        ApiResponse<PagedResourceListOfDataTypeSummary> ListDataTypeSummariesWithHttpInfo(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> sortBy = default(List<string>));
        /// <summary>
        /// ListDataTypes: List data types
        /// </summary>
        /// <remarks>
        /// List all data types in a specified scope
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The requested scope of the data types</param>
        /// <param name="asAt">The as at of the requested data types (optional)</param>
        /// <param name="includeSystem">Whether to additionally include those data types in the \&quot;system\&quot; scope (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ResourceListOfDataType</returns>
        ResourceListOfDataType ListDataTypes(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), bool? includeSystem = default(bool?), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string));

        /// <summary>
        /// ListDataTypes: List data types
        /// </summary>
        /// <remarks>
        /// List all data types in a specified scope
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The requested scope of the data types</param>
        /// <param name="asAt">The as at of the requested data types (optional)</param>
        /// <param name="includeSystem">Whether to additionally include those data types in the \&quot;system\&quot; scope (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfDataType</returns>
        ApiResponse<ResourceListOfDataType> ListDataTypesWithHttpInfo(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), bool? includeSystem = default(bool?), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string));
        /// <summary>
        /// [EARLY ACCESS] UpdateDataType: Update data type definition
        /// </summary>
        /// <remarks>
        /// Update the definition of the specified existing data type    Not all elements within a data type definition are modifiable due to the potential implications for data  already stored against the types
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="updateDataTypeRequest">The updated definition of the data type</param>
        /// <returns>DataType</returns>
        DataType UpdateDataType(string scope, string code, UpdateDataTypeRequest updateDataTypeRequest);

        /// <summary>
        /// [EARLY ACCESS] UpdateDataType: Update data type definition
        /// </summary>
        /// <remarks>
        /// Update the definition of the specified existing data type    Not all elements within a data type definition are modifiable due to the potential implications for data  already stored against the types
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="updateDataTypeRequest">The updated definition of the data type</param>
        /// <returns>ApiResponse of DataType</returns>
        ApiResponse<DataType> UpdateDataTypeWithHttpInfo(string scope, string code, UpdateDataTypeRequest updateDataTypeRequest);
        /// <summary>
        /// [EARLY ACCESS] UpdateReferenceValues: Update reference data on a data type
        /// </summary>
        /// <remarks>
        /// Replaces the whole set of reference values
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="fieldValue">The updated reference values</param>
        /// <returns>DataType</returns>
        DataType UpdateReferenceValues(string scope, string code, List<FieldValue> fieldValue);

        /// <summary>
        /// [EARLY ACCESS] UpdateReferenceValues: Update reference data on a data type
        /// </summary>
        /// <remarks>
        /// Replaces the whole set of reference values
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="fieldValue">The updated reference values</param>
        /// <returns>ApiResponse of DataType</returns>
        ApiResponse<DataType> UpdateReferenceValuesWithHttpInfo(string scope, string code, List<FieldValue> fieldValue);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataTypesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] CreateDataType: Create data type definition
        /// </summary>
        /// <remarks>
        /// Create a new data type definition    Data types cannot be created in either the \&quot;default\&quot; or \&quot;system\&quot; scopes.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDataTypeRequest">The definition of the new data type (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataType</returns>
        System.Threading.Tasks.Task<DataType> CreateDataTypeAsync(CreateDataTypeRequest createDataTypeRequest = default(CreateDataTypeRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] CreateDataType: Create data type definition
        /// </summary>
        /// <remarks>
        /// Create a new data type definition    Data types cannot be created in either the \&quot;default\&quot; or \&quot;system\&quot; scopes.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDataTypeRequest">The definition of the new data type (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DataType)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataType>> CreateDataTypeWithHttpInfoAsync(CreateDataTypeRequest createDataTypeRequest = default(CreateDataTypeRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetDataType: Get data type definition
        /// </summary>
        /// <remarks>
        /// Get the definition of a specified data type
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the data type definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataType</returns>
        System.Threading.Tasks.Task<DataType> GetDataTypeAsync(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetDataType: Get data type definition
        /// </summary>
        /// <remarks>
        /// Get the definition of a specified data type
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the data type definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DataType)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataType>> GetDataTypeWithHttpInfoAsync(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetUnitsFromDataType: Get units from data type
        /// </summary>
        /// <remarks>
        /// Get the definitions of the specified units associated bound to a specific data type
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="units">One or more unit identifiers for which the definition is being requested (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Schema, use \&quot;schema eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="asAt">Optional. The as at of the requested data type (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfIUnitDefinitionDto</returns>
        System.Threading.Tasks.Task<ResourceListOfIUnitDefinitionDto> GetUnitsFromDataTypeAsync(string scope, string code, List<string> units = default(List<string>), string filter = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetUnitsFromDataType: Get units from data type
        /// </summary>
        /// <remarks>
        /// Get the definitions of the specified units associated bound to a specific data type
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="units">One or more unit identifiers for which the definition is being requested (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Schema, use \&quot;schema eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="asAt">Optional. The as at of the requested data type (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfIUnitDefinitionDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfIUnitDefinitionDto>> GetUnitsFromDataTypeWithHttpInfoAsync(string scope, string code, List<string> units = default(List<string>), string filter = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] ListDataTypeSummaries: List all data type summaries, without the reference data
        /// </summary>
        /// <remarks>
        /// List all data type summaries
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the data type summaries. Defaults to returning the latest version               of each summary if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing data type summaries. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.                For example, to filter on the Scope, use \&quot;id.scope eq &#39;myscope&#39;\&quot;, to filter on Schema, use \&quot;schema eq &#39;string&#39;\&quot;,               to filter on AcceptableValues use \&quot;acceptableValues any (~ eq &#39;value&#39;)\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="sortBy">Sort the results by these fields. Use use the &#39;-&#39; sign to denote descending allocation e.g. -MyFieldName. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PagedResourceListOfDataTypeSummary</returns>
        System.Threading.Tasks.Task<PagedResourceListOfDataTypeSummary> ListDataTypeSummariesAsync(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> sortBy = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] ListDataTypeSummaries: List all data type summaries, without the reference data
        /// </summary>
        /// <remarks>
        /// List all data type summaries
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the data type summaries. Defaults to returning the latest version               of each summary if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing data type summaries. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.                For example, to filter on the Scope, use \&quot;id.scope eq &#39;myscope&#39;\&quot;, to filter on Schema, use \&quot;schema eq &#39;string&#39;\&quot;,               to filter on AcceptableValues use \&quot;acceptableValues any (~ eq &#39;value&#39;)\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="sortBy">Sort the results by these fields. Use use the &#39;-&#39; sign to denote descending allocation e.g. -MyFieldName. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PagedResourceListOfDataTypeSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagedResourceListOfDataTypeSummary>> ListDataTypeSummariesWithHttpInfoAsync(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> sortBy = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// ListDataTypes: List data types
        /// </summary>
        /// <remarks>
        /// List all data types in a specified scope
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The requested scope of the data types</param>
        /// <param name="asAt">The as at of the requested data types (optional)</param>
        /// <param name="includeSystem">Whether to additionally include those data types in the \&quot;system\&quot; scope (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfDataType</returns>
        System.Threading.Tasks.Task<ResourceListOfDataType> ListDataTypesAsync(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), bool? includeSystem = default(bool?), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// ListDataTypes: List data types
        /// </summary>
        /// <remarks>
        /// List all data types in a specified scope
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The requested scope of the data types</param>
        /// <param name="asAt">The as at of the requested data types (optional)</param>
        /// <param name="includeSystem">Whether to additionally include those data types in the \&quot;system\&quot; scope (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfDataType)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfDataType>> ListDataTypesWithHttpInfoAsync(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), bool? includeSystem = default(bool?), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] UpdateDataType: Update data type definition
        /// </summary>
        /// <remarks>
        /// Update the definition of the specified existing data type    Not all elements within a data type definition are modifiable due to the potential implications for data  already stored against the types
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="updateDataTypeRequest">The updated definition of the data type</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataType</returns>
        System.Threading.Tasks.Task<DataType> UpdateDataTypeAsync(string scope, string code, UpdateDataTypeRequest updateDataTypeRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] UpdateDataType: Update data type definition
        /// </summary>
        /// <remarks>
        /// Update the definition of the specified existing data type    Not all elements within a data type definition are modifiable due to the potential implications for data  already stored against the types
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="updateDataTypeRequest">The updated definition of the data type</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DataType)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataType>> UpdateDataTypeWithHttpInfoAsync(string scope, string code, UpdateDataTypeRequest updateDataTypeRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] UpdateReferenceValues: Update reference data on a data type
        /// </summary>
        /// <remarks>
        /// Replaces the whole set of reference values
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="fieldValue">The updated reference values</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataType</returns>
        System.Threading.Tasks.Task<DataType> UpdateReferenceValuesAsync(string scope, string code, List<FieldValue> fieldValue, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] UpdateReferenceValues: Update reference data on a data type
        /// </summary>
        /// <remarks>
        /// Replaces the whole set of reference values
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="fieldValue">The updated reference values</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DataType)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataType>> UpdateReferenceValuesWithHttpInfoAsync(string scope, string code, List<FieldValue> fieldValue, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataTypesApi : IDataTypesApiSync, IDataTypesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DataTypesApi : IDataTypesApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataTypesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataTypesApi(String basePath)
        {
            this.Configuration = Lusid.Sdk.Client.Configuration.MergeConfigurations(
                Lusid.Sdk.Client.GlobalConfiguration.Instance,
                new Lusid.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DataTypesApi(Lusid.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DataTypesApi(Lusid.Sdk.Client.ISynchronousClient client, Lusid.Sdk.Client.IAsynchronousClient asyncClient, Lusid.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Lusid.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Lusid.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Lusid.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Lusid.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// [EARLY ACCESS] CreateDataType: Create data type definition Create a new data type definition    Data types cannot be created in either the \&quot;default\&quot; or \&quot;system\&quot; scopes.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDataTypeRequest">The definition of the new data type (optional)</param>
        /// <returns>DataType</returns>
        public DataType CreateDataType(CreateDataTypeRequest createDataTypeRequest = default(CreateDataTypeRequest))
        {
            Lusid.Sdk.Client.ApiResponse<DataType> localVarResponse = CreateDataTypeWithHttpInfo(createDataTypeRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] CreateDataType: Create data type definition Create a new data type definition    Data types cannot be created in either the \&quot;default\&quot; or \&quot;system\&quot; scopes.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDataTypeRequest">The definition of the new data type (optional)</param>
        /// <returns>ApiResponse of DataType</returns>
        public Lusid.Sdk.Client.ApiResponse<DataType> CreateDataTypeWithHttpInfo(CreateDataTypeRequest createDataTypeRequest = default(CreateDataTypeRequest))
        {
            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createDataTypeRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4820");

            // make the HTTP request
            var localVarResponse = this.Client.Post<DataType>("/api/datatypes", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateDataType", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] CreateDataType: Create data type definition Create a new data type definition    Data types cannot be created in either the \&quot;default\&quot; or \&quot;system\&quot; scopes.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDataTypeRequest">The definition of the new data type (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataType</returns>
        public async System.Threading.Tasks.Task<DataType> CreateDataTypeAsync(CreateDataTypeRequest createDataTypeRequest = default(CreateDataTypeRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DataType> localVarResponse = await CreateDataTypeWithHttpInfoAsync(createDataTypeRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] CreateDataType: Create data type definition Create a new data type definition    Data types cannot be created in either the \&quot;default\&quot; or \&quot;system\&quot; scopes.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDataTypeRequest">The definition of the new data type (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DataType)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DataType>> CreateDataTypeWithHttpInfoAsync(CreateDataTypeRequest createDataTypeRequest = default(CreateDataTypeRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createDataTypeRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4820");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<DataType>("/api/datatypes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateDataType", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetDataType: Get data type definition Get the definition of a specified data type
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the data type definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <returns>DataType</returns>
        public DataType GetDataType(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<DataType> localVarResponse = GetDataTypeWithHttpInfo(scope, code, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetDataType: Get data type definition Get the definition of a specified data type
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the data type definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <returns>ApiResponse of DataType</returns>
        public Lusid.Sdk.Client.ApiResponse<DataType> GetDataTypeWithHttpInfo(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling DataTypesApi->GetDataType");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling DataTypesApi->GetDataType");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4820");

            // make the HTTP request
            var localVarResponse = this.Client.Get<DataType>("/api/datatypes/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDataType", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetDataType: Get data type definition Get the definition of a specified data type
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the data type definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataType</returns>
        public async System.Threading.Tasks.Task<DataType> GetDataTypeAsync(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DataType> localVarResponse = await GetDataTypeWithHttpInfoAsync(scope, code, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetDataType: Get data type definition Get the definition of a specified data type
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the data type definition. Defaults to              return the latest version of the instrument definition if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DataType)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DataType>> GetDataTypeWithHttpInfoAsync(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling DataTypesApi->GetDataType");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling DataTypesApi->GetDataType");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4820");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<DataType>("/api/datatypes/{scope}/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDataType", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetUnitsFromDataType: Get units from data type Get the definitions of the specified units associated bound to a specific data type
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="units">One or more unit identifiers for which the definition is being requested (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Schema, use \&quot;schema eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="asAt">Optional. The as at of the requested data type (optional)</param>
        /// <returns>ResourceListOfIUnitDefinitionDto</returns>
        public ResourceListOfIUnitDefinitionDto GetUnitsFromDataType(string scope, string code, List<string> units = default(List<string>), string filter = default(string), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfIUnitDefinitionDto> localVarResponse = GetUnitsFromDataTypeWithHttpInfo(scope, code, units, filter, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetUnitsFromDataType: Get units from data type Get the definitions of the specified units associated bound to a specific data type
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="units">One or more unit identifiers for which the definition is being requested (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Schema, use \&quot;schema eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="asAt">Optional. The as at of the requested data type (optional)</param>
        /// <returns>ApiResponse of ResourceListOfIUnitDefinitionDto</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfIUnitDefinitionDto> GetUnitsFromDataTypeWithHttpInfo(string scope, string code, List<string> units = default(List<string>), string filter = default(string), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling DataTypesApi->GetUnitsFromDataType");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling DataTypesApi->GetUnitsFromDataType");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (units != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "units", units));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4820");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfIUnitDefinitionDto>("/api/datatypes/{scope}/{code}/units", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUnitsFromDataType", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetUnitsFromDataType: Get units from data type Get the definitions of the specified units associated bound to a specific data type
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="units">One or more unit identifiers for which the definition is being requested (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Schema, use \&quot;schema eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="asAt">Optional. The as at of the requested data type (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfIUnitDefinitionDto</returns>
        public async System.Threading.Tasks.Task<ResourceListOfIUnitDefinitionDto> GetUnitsFromDataTypeAsync(string scope, string code, List<string> units = default(List<string>), string filter = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfIUnitDefinitionDto> localVarResponse = await GetUnitsFromDataTypeWithHttpInfoAsync(scope, code, units, filter, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetUnitsFromDataType: Get units from data type Get the definitions of the specified units associated bound to a specific data type
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="units">One or more unit identifiers for which the definition is being requested (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Schema, use \&quot;schema eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="asAt">Optional. The as at of the requested data type (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfIUnitDefinitionDto)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfIUnitDefinitionDto>> GetUnitsFromDataTypeWithHttpInfoAsync(string scope, string code, List<string> units = default(List<string>), string filter = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling DataTypesApi->GetUnitsFromDataType");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling DataTypesApi->GetUnitsFromDataType");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (units != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "units", units));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4820");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfIUnitDefinitionDto>("/api/datatypes/{scope}/{code}/units", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUnitsFromDataType", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListDataTypeSummaries: List all data type summaries, without the reference data List all data type summaries
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the data type summaries. Defaults to returning the latest version               of each summary if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing data type summaries. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.                For example, to filter on the Scope, use \&quot;id.scope eq &#39;myscope&#39;\&quot;, to filter on Schema, use \&quot;schema eq &#39;string&#39;\&quot;,               to filter on AcceptableValues use \&quot;acceptableValues any (~ eq &#39;value&#39;)\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="sortBy">Sort the results by these fields. Use use the &#39;-&#39; sign to denote descending allocation e.g. -MyFieldName. (optional)</param>
        /// <returns>PagedResourceListOfDataTypeSummary</returns>
        public PagedResourceListOfDataTypeSummary ListDataTypeSummaries(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> sortBy = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<PagedResourceListOfDataTypeSummary> localVarResponse = ListDataTypeSummariesWithHttpInfo(asAt, page, start, limit, filter, sortBy);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListDataTypeSummaries: List all data type summaries, without the reference data List all data type summaries
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the data type summaries. Defaults to returning the latest version               of each summary if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing data type summaries. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.                For example, to filter on the Scope, use \&quot;id.scope eq &#39;myscope&#39;\&quot;, to filter on Schema, use \&quot;schema eq &#39;string&#39;\&quot;,               to filter on AcceptableValues use \&quot;acceptableValues any (~ eq &#39;value&#39;)\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="sortBy">Sort the results by these fields. Use use the &#39;-&#39; sign to denote descending allocation e.g. -MyFieldName. (optional)</param>
        /// <returns>ApiResponse of PagedResourceListOfDataTypeSummary</returns>
        public Lusid.Sdk.Client.ApiResponse<PagedResourceListOfDataTypeSummary> ListDataTypeSummariesWithHttpInfo(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> sortBy = default(List<string>))
        {
            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "start", start));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "sortBy", sortBy));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4820");

            // make the HTTP request
            var localVarResponse = this.Client.Get<PagedResourceListOfDataTypeSummary>("/api/datatypes", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListDataTypeSummaries", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListDataTypeSummaries: List all data type summaries, without the reference data List all data type summaries
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the data type summaries. Defaults to returning the latest version               of each summary if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing data type summaries. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.                For example, to filter on the Scope, use \&quot;id.scope eq &#39;myscope&#39;\&quot;, to filter on Schema, use \&quot;schema eq &#39;string&#39;\&quot;,               to filter on AcceptableValues use \&quot;acceptableValues any (~ eq &#39;value&#39;)\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="sortBy">Sort the results by these fields. Use use the &#39;-&#39; sign to denote descending allocation e.g. -MyFieldName. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PagedResourceListOfDataTypeSummary</returns>
        public async System.Threading.Tasks.Task<PagedResourceListOfDataTypeSummary> ListDataTypeSummariesAsync(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> sortBy = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PagedResourceListOfDataTypeSummary> localVarResponse = await ListDataTypeSummariesWithHttpInfoAsync(asAt, page, start, limit, filter, sortBy, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListDataTypeSummaries: List all data type summaries, without the reference data List all data type summaries
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list the data type summaries. Defaults to returning the latest version               of each summary if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing data type summaries. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.                For example, to filter on the Scope, use \&quot;id.scope eq &#39;myscope&#39;\&quot;, to filter on Schema, use \&quot;schema eq &#39;string&#39;\&quot;,               to filter on AcceptableValues use \&quot;acceptableValues any (~ eq &#39;value&#39;)\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="sortBy">Sort the results by these fields. Use use the &#39;-&#39; sign to denote descending allocation e.g. -MyFieldName. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PagedResourceListOfDataTypeSummary)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PagedResourceListOfDataTypeSummary>> ListDataTypeSummariesWithHttpInfoAsync(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> sortBy = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "start", start));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "sortBy", sortBy));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4820");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PagedResourceListOfDataTypeSummary>("/api/datatypes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListDataTypeSummaries", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// ListDataTypes: List data types List all data types in a specified scope
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The requested scope of the data types</param>
        /// <param name="asAt">The as at of the requested data types (optional)</param>
        /// <param name="includeSystem">Whether to additionally include those data types in the \&quot;system\&quot; scope (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ResourceListOfDataType</returns>
        public ResourceListOfDataType ListDataTypes(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), bool? includeSystem = default(bool?), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfDataType> localVarResponse = ListDataTypesWithHttpInfo(scope, asAt, includeSystem, sortBy, start, limit, filter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ListDataTypes: List data types List all data types in a specified scope
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The requested scope of the data types</param>
        /// <param name="asAt">The as at of the requested data types (optional)</param>
        /// <param name="includeSystem">Whether to additionally include those data types in the \&quot;system\&quot; scope (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfDataType</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfDataType> ListDataTypesWithHttpInfo(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), bool? includeSystem = default(bool?), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling DataTypesApi->ListDataTypes");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (includeSystem != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "includeSystem", includeSystem));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "sortBy", sortBy));
            }
            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "start", start));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4820");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfDataType>("/api/datatypes/{scope}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListDataTypes", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// ListDataTypes: List data types List all data types in a specified scope
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The requested scope of the data types</param>
        /// <param name="asAt">The as at of the requested data types (optional)</param>
        /// <param name="includeSystem">Whether to additionally include those data types in the \&quot;system\&quot; scope (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfDataType</returns>
        public async System.Threading.Tasks.Task<ResourceListOfDataType> ListDataTypesAsync(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), bool? includeSystem = default(bool?), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfDataType> localVarResponse = await ListDataTypesWithHttpInfoAsync(scope, asAt, includeSystem, sortBy, start, limit, filter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ListDataTypes: List data types List all data types in a specified scope
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The requested scope of the data types</param>
        /// <param name="asAt">The as at of the requested data types (optional)</param>
        /// <param name="includeSystem">Whether to additionally include those data types in the \&quot;system\&quot; scope (optional)</param>
        /// <param name="sortBy">Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName (optional)</param>
        /// <param name="start">Optional. When paginating, skip this number of results (optional)</param>
        /// <param name="limit">Optional. When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Optional. Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfDataType)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfDataType>> ListDataTypesWithHttpInfoAsync(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), bool? includeSystem = default(bool?), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling DataTypesApi->ListDataTypes");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (includeSystem != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "includeSystem", includeSystem));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "sortBy", sortBy));
            }
            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "start", start));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4820");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfDataType>("/api/datatypes/{scope}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListDataTypes", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateDataType: Update data type definition Update the definition of the specified existing data type    Not all elements within a data type definition are modifiable due to the potential implications for data  already stored against the types
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="updateDataTypeRequest">The updated definition of the data type</param>
        /// <returns>DataType</returns>
        public DataType UpdateDataType(string scope, string code, UpdateDataTypeRequest updateDataTypeRequest)
        {
            Lusid.Sdk.Client.ApiResponse<DataType> localVarResponse = UpdateDataTypeWithHttpInfo(scope, code, updateDataTypeRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateDataType: Update data type definition Update the definition of the specified existing data type    Not all elements within a data type definition are modifiable due to the potential implications for data  already stored against the types
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="updateDataTypeRequest">The updated definition of the data type</param>
        /// <returns>ApiResponse of DataType</returns>
        public Lusid.Sdk.Client.ApiResponse<DataType> UpdateDataTypeWithHttpInfo(string scope, string code, UpdateDataTypeRequest updateDataTypeRequest)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling DataTypesApi->UpdateDataType");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling DataTypesApi->UpdateDataType");

            // verify the required parameter 'updateDataTypeRequest' is set
            if (updateDataTypeRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'updateDataTypeRequest' when calling DataTypesApi->UpdateDataType");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.Data = updateDataTypeRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4820");

            // make the HTTP request
            var localVarResponse = this.Client.Put<DataType>("/api/datatypes/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateDataType", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateDataType: Update data type definition Update the definition of the specified existing data type    Not all elements within a data type definition are modifiable due to the potential implications for data  already stored against the types
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="updateDataTypeRequest">The updated definition of the data type</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataType</returns>
        public async System.Threading.Tasks.Task<DataType> UpdateDataTypeAsync(string scope, string code, UpdateDataTypeRequest updateDataTypeRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DataType> localVarResponse = await UpdateDataTypeWithHttpInfoAsync(scope, code, updateDataTypeRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateDataType: Update data type definition Update the definition of the specified existing data type    Not all elements within a data type definition are modifiable due to the potential implications for data  already stored against the types
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="updateDataTypeRequest">The updated definition of the data type</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DataType)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DataType>> UpdateDataTypeWithHttpInfoAsync(string scope, string code, UpdateDataTypeRequest updateDataTypeRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling DataTypesApi->UpdateDataType");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling DataTypesApi->UpdateDataType");

            // verify the required parameter 'updateDataTypeRequest' is set
            if (updateDataTypeRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'updateDataTypeRequest' when calling DataTypesApi->UpdateDataType");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.Data = updateDataTypeRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4820");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<DataType>("/api/datatypes/{scope}/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateDataType", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateReferenceValues: Update reference data on a data type Replaces the whole set of reference values
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="fieldValue">The updated reference values</param>
        /// <returns>DataType</returns>
        public DataType UpdateReferenceValues(string scope, string code, List<FieldValue> fieldValue)
        {
            Lusid.Sdk.Client.ApiResponse<DataType> localVarResponse = UpdateReferenceValuesWithHttpInfo(scope, code, fieldValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateReferenceValues: Update reference data on a data type Replaces the whole set of reference values
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="fieldValue">The updated reference values</param>
        /// <returns>ApiResponse of DataType</returns>
        public Lusid.Sdk.Client.ApiResponse<DataType> UpdateReferenceValuesWithHttpInfo(string scope, string code, List<FieldValue> fieldValue)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling DataTypesApi->UpdateReferenceValues");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling DataTypesApi->UpdateReferenceValues");

            // verify the required parameter 'fieldValue' is set
            if (fieldValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'fieldValue' when calling DataTypesApi->UpdateReferenceValues");

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.Data = fieldValue;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4820");

            // make the HTTP request
            var localVarResponse = this.Client.Put<DataType>("/api/datatypes/{scope}/{code}/referencedatavalues", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateReferenceValues", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateReferenceValues: Update reference data on a data type Replaces the whole set of reference values
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="fieldValue">The updated reference values</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataType</returns>
        public async System.Threading.Tasks.Task<DataType> UpdateReferenceValuesAsync(string scope, string code, List<FieldValue> fieldValue, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DataType> localVarResponse = await UpdateReferenceValuesWithHttpInfoAsync(scope, code, fieldValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateReferenceValues: Update reference data on a data type Replaces the whole set of reference values
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the data type</param>
        /// <param name="code">The code of the data type</param>
        /// <param name="fieldValue">The updated reference values</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DataType)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DataType>> UpdateReferenceValuesWithHttpInfoAsync(string scope, string code, List<FieldValue> fieldValue, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling DataTypesApi->UpdateReferenceValues");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling DataTypesApi->UpdateReferenceValues");

            // verify the required parameter 'fieldValue' is set
            if (fieldValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'fieldValue' when calling DataTypesApi->UpdateReferenceValues");


            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("scope", Lusid.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.Data = fieldValue;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4820");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<DataType>("/api/datatypes/{scope}/{code}/referencedatavalues", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateReferenceValues", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}