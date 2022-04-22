/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-10\">-10</a>|Server Configuration Error|  | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"102\">102</a>|Version Not Found|  | | <a name=\"103\">103</a>|Api Rate Limit Violation|  | | <a name=\"104\">104</a>|Instrument Not Found|  | | <a name=\"105\">105</a>|Property Not Found|  | | <a name=\"106\">106</a>|Portfolio Recursion Depth|  | | <a name=\"108\">108</a>|Group Not Found|  | | <a name=\"109\">109</a>|Portfolio Not Found|  | | <a name=\"110\">110</a>|Property Schema Not Found|  | | <a name=\"111\">111</a>|Portfolio Ancestry Not Found|  | | <a name=\"112\">112</a>|Portfolio With Id Already Exists|  | | <a name=\"113\">113</a>|Orphaned Portfolio|  | | <a name=\"119\">119</a>|Missing Base Claims|  | | <a name=\"121\">121</a>|Property Not Defined|  | | <a name=\"122\">122</a>|Cannot Delete System Property|  | | <a name=\"123\">123</a>|Cannot Modify Immutable Property Field|  | | <a name=\"124\">124</a>|Property Already Exists|  | | <a name=\"125\">125</a>|Invalid Property Life Time|  | | <a name=\"126\">126</a>|Property Constraint Style Excludes Properties|  | | <a name=\"127\">127</a>|Cannot Modify Default Data Type|  | | <a name=\"128\">128</a>|Group Already Exists|  | | <a name=\"129\">129</a>|No Such Data Type|  | | <a name=\"130\">130</a>|Undefined Value For Data Type|  | | <a name=\"131\">131</a>|Unsupported Value Type Defined On Data Type|  | | <a name=\"132\">132</a>|Validation Error|  | | <a name=\"133\">133</a>|Loop Detected In Group Hierarchy|  | | <a name=\"134\">134</a>|Undefined Acceptable Values|  | | <a name=\"135\">135</a>|Sub Group Already Exists|  | | <a name=\"138\">138</a>|Price Source Not Found|  | | <a name=\"139\">139</a>|Analytic Store Not Found|  | | <a name=\"141\">141</a>|Analytic Store Already Exists|  | | <a name=\"143\">143</a>|Client Instrument Already Exists|  | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"147\">147</a>|Results Not Found|  | | <a name=\"148\">148</a>|Order Field Not In Result Set|  | | <a name=\"149\">149</a>|Operation Failed|  | | <a name=\"150\">150</a>|Elastic Search Error|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"153\">153</a>|Command Processing Failure|  | | <a name=\"154\">154</a>|Entity State Construction Failure|  | | <a name=\"155\">155</a>|Entity Timeline Does Not Exist|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"158\">158</a>|Event Publish Unknown|  | | <a name=\"159\">159</a>|Event Query Failure|  | | <a name=\"160\">160</a>|Blob Did Not Exist|  | | <a name=\"162\">162</a>|Sub System Request Failure|  | | <a name=\"163\">163</a>|Sub System Configuration Failure|  | | <a name=\"165\">165</a>|Failed To Delete|  | | <a name=\"166\">166</a>|Upsert Client Instrument Failure|  | | <a name=\"167\">167</a>|Illegal As At Interval|  | | <a name=\"168\">168</a>|Illegal Bitemporal Query|  | | <a name=\"169\">169</a>|Invalid Alternate Id|  | | <a name=\"170\">170</a>|Cannot Add Source Portfolio Property Explicitly|  | | <a name=\"171\">171</a>|Entity Already Exists In Group|  | | <a name=\"173\">173</a>|Entity With Id Already Exists|  | | <a name=\"174\">174</a>|Derived Portfolio Details Do Not Exist|  | | <a name=\"175\">175</a>|Entity Not In Group|  | | <a name=\"176\">176</a>|Portfolio With Name Already Exists|  | | <a name=\"177\">177</a>|Invalid Transactions|  | | <a name=\"178\">178</a>|Reference Portfolio Not Found|  | | <a name=\"179\">179</a>|Duplicate Id|  | | <a name=\"180\">180</a>|Command Retrieval Failure|  | | <a name=\"181\">181</a>|Data Filter Application Failure|  | | <a name=\"182\">182</a>|Search Failed|  | | <a name=\"183\">183</a>|Movements Engine Configuration Key Failure|  | | <a name=\"184\">184</a>|Fx Rate Source Not Found|  | | <a name=\"185\">185</a>|Accrual Source Not Found|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"188\">188</a>|Invalid Request Headers|  | | <a name=\"189\">189</a>|Price Not Found|  | | <a name=\"190\">190</a>|Invalid Sub Holding Keys Provided|  | | <a name=\"191\">191</a>|Duplicate Sub Holding Keys Provided|  | | <a name=\"192\">192</a>|Cut Definition Not Found|  | | <a name=\"193\">193</a>|Cut Definition Invalid|  | | <a name=\"194\">194</a>|Time Variant Property Deletion Date Unspecified|  | | <a name=\"195\">195</a>|Perpetual Property Deletion Date Specified|  | | <a name=\"196\">196</a>|Time Variant Property Upsert Date Unspecified|  | | <a name=\"197\">197</a>|Perpetual Property Upsert Date Specified|  | | <a name=\"200\">200</a>|Invalid Unit For Data Type|  | | <a name=\"201\">201</a>|Invalid Type For Data Type|  | | <a name=\"202\">202</a>|Invalid Value For Data Type|  | | <a name=\"203\">203</a>|Unit Not Defined For Data Type|  | | <a name=\"204\">204</a>|Units Not Supported On Data Type|  | | <a name=\"205\">205</a>|Cannot Specify Units On Data Type|  | | <a name=\"206\">206</a>|Unit Schema Inconsistent With Data Type|  | | <a name=\"207\">207</a>|Unit Definition Not Specified|  | | <a name=\"208\">208</a>|Duplicate Unit Definitions Specified|  | | <a name=\"209\">209</a>|Invalid Units Definition|  | | <a name=\"210\">210</a>|Invalid Instrument Identifier Unit|  | | <a name=\"211\">211</a>|Holdings Adjustment Does Not Exist|  | | <a name=\"212\">212</a>|Could Not Build Excel Url|  | | <a name=\"213\">213</a>|Could Not Get Excel Version|  | | <a name=\"214\">214</a>|Instrument By Code Not Found|  | | <a name=\"215\">215</a>|Entity Schema Does Not Exist|  | | <a name=\"216\">216</a>|Feature Not Supported On Portfolio Type|  | | <a name=\"217\">217</a>|Quote Not Found|  | | <a name=\"218\">218</a>|Invalid Quote Identifier|  | | <a name=\"219\">219</a>|Invalid Metric For Data Type|  | | <a name=\"220\">220</a>|Invalid Instrument Definition|  | | <a name=\"221\">221</a>|Instrument Upsert Failure|  | | <a name=\"222\">222</a>|Reference Portfolio Request Not Supported|  | | <a name=\"223\">223</a>|Transaction Portfolio Request Not Supported|  | | <a name=\"224\">224</a>|Invalid Property Value Assignment|  | | <a name=\"230\">230</a>|Transaction Type Not Found|  | | <a name=\"231\">231</a>|Transaction Type Duplication|  | | <a name=\"232\">232</a>|Portfolio Does Not Exist At Given Date|  | | <a name=\"233\">233</a>|Query Parser Failure|  | | <a name=\"234\">234</a>|Duplicate Constituent|  | | <a name=\"235\">235</a>|Unresolved Instrument Constituent|  | | <a name=\"236\">236</a>|Unresolved Instrument In Transition|  | | <a name=\"237\">237</a>|Missing Side Definitions|  | | <a name=\"299\">299</a>|Invalid Recipe|  | | <a name=\"300\">300</a>|Missing Recipe|  | | <a name=\"301\">301</a>|Dependencies|  | | <a name=\"304\">304</a>|Portfolio Preprocess Failure|  | | <a name=\"310\">310</a>|Valuation Engine Failure|  | | <a name=\"311\">311</a>|Task Factory Failure|  | | <a name=\"312\">312</a>|Task Evaluation Failure|  | | <a name=\"313\">313</a>|Task Generation Failure|  | | <a name=\"314\">314</a>|Engine Configuration Failure|  | | <a name=\"315\">315</a>|Model Specification Failure|  | | <a name=\"320\">320</a>|Market Data Key Failure|  | | <a name=\"321\">321</a>|Market Resolver Failure|  | | <a name=\"322\">322</a>|Market Data Failure|  | | <a name=\"330\">330</a>|Curve Failure|  | | <a name=\"331\">331</a>|Volatility Surface Failure|  | | <a name=\"332\">332</a>|Volatility Cube Failure|  | | <a name=\"350\">350</a>|Instrument Failure|  | | <a name=\"351\">351</a>|Cash Flows Failure|  | | <a name=\"352\">352</a>|Reference Data Failure|  | | <a name=\"360\">360</a>|Aggregation Failure|  | | <a name=\"361\">361</a>|Aggregation Measure Failure|  | | <a name=\"370\">370</a>|Result Retrieval Failure|  | | <a name=\"371\">371</a>|Result Processing Failure|  | | <a name=\"372\">372</a>|Vendor Result Processing Failure|  | | <a name=\"373\">373</a>|Vendor Result Mapping Failure|  | | <a name=\"374\">374</a>|Vendor Library Unauthorised|  | | <a name=\"375\">375</a>|Vendor Connectivity Error|  | | <a name=\"376\">376</a>|Vendor Interface Error|  | | <a name=\"377\">377</a>|Vendor Pricing Failure|  | | <a name=\"378\">378</a>|Vendor Translation Failure|  | | <a name=\"379\">379</a>|Vendor Key Mapping Failure|  | | <a name=\"380\">380</a>|Vendor Reflection Failure|  | | <a name=\"381\">381</a>|Vendor Process Failure|  | | <a name=\"382\">382</a>|Vendor System Failure|  | | <a name=\"390\">390</a>|Attempt To Upsert Duplicate Quotes|  | | <a name=\"391\">391</a>|Corporate Action Source Does Not Exist|  | | <a name=\"392\">392</a>|Corporate Action Source Already Exists|  | | <a name=\"393\">393</a>|Instrument Identifier Already In Use|  | | <a name=\"394\">394</a>|Properties Not Found|  | | <a name=\"395\">395</a>|Batch Operation Aborted|  | | <a name=\"400\">400</a>|Invalid Iso4217 Currency Code|  | | <a name=\"401\">401</a>|Cannot Assign Instrument Identifier To Currency|  | | <a name=\"402\">402</a>|Cannot Assign Currency Identifier To Non Currency|  | | <a name=\"403\">403</a>|Currency Instrument Cannot Be Deleted|  | | <a name=\"404\">404</a>|Currency Instrument Cannot Have Economic Definition|  | | <a name=\"405\">405</a>|Currency Instrument Cannot Have Lookthrough Portfolio|  | | <a name=\"406\">406</a>|Cannot Create Currency Instrument With Multiple Identifiers|  | | <a name=\"407\">407</a>|Specified Currency Is Undefined|  | | <a name=\"410\">410</a>|Index Does Not Exist|  | | <a name=\"411\">411</a>|Sort Field Does Not Exist|  | | <a name=\"413\">413</a>|Negative Pagination Parameters|  | | <a name=\"414\">414</a>|Invalid Search Syntax|  | | <a name=\"415\">415</a>|Filter Execution Timeout|  | | <a name=\"420\">420</a>|Side Definition Inconsistent|  | | <a name=\"450\">450</a>|Invalid Quote Access Metadata Rule|  | | <a name=\"451\">451</a>|Access Metadata Not Found|  | | <a name=\"452\">452</a>|Invalid Access Metadata Identifier|  | | <a name=\"460\">460</a>|Standard Resource Not Found|  | | <a name=\"461\">461</a>|Standard Resource Conflict|  | | <a name=\"462\">462</a>|Calendar Not Found|  | | <a name=\"463\">463</a>|Date In A Calendar Not Found|  | | <a name=\"464\">464</a>|Invalid Date Source Data|  | | <a name=\"465\">465</a>|Invalid Timezone|  | | <a name=\"601\">601</a>|Person Identifier Already In Use|  | | <a name=\"602\">602</a>|Person Not Found|  | | <a name=\"603\">603</a>|Cannot Set Identifier|  | | <a name=\"617\">617</a>|Invalid Recipe Specification In Request|  | | <a name=\"618\">618</a>|Inline Recipe Deserialisation Failure|  | | <a name=\"619\">619</a>|Identifier Types Not Set For Entity|  | | <a name=\"620\">620</a>|Cannot Delete All Client Defined Identifiers|  | | <a name=\"650\">650</a>|The Order requested was not found.|  | | <a name=\"654\">654</a>|The Allocation requested was not found.|  | | <a name=\"655\">655</a>|Cannot build the fx forward target with the given holdings.|  | | <a name=\"656\">656</a>|Group does not contain expected entities.|  | | <a name=\"665\">665</a>|Destination directory not found|  | | <a name=\"667\">667</a>|Relation definition already exists|  | | <a name=\"672\">672</a>|Could not retrieve file contents|  | | <a name=\"673\">673</a>|Missing entitlements for entities in Group|  | | <a name=\"674\">674</a>|Next Best Action not found|  | | <a name=\"676\">676</a>|Relation definition not defined|  | | <a name=\"677\">677</a>|Invalid entity identifier for relation|  | | <a name=\"681\">681</a>|Sorting by specified field not supported|One or more of the provided fields to order by were either invalid or not supported. | | <a name=\"682\">682</a>|Too many fields to sort by|The number of fields to sort the data by exceeds the number allowed by the endpoint | | <a name=\"684\">684</a>|Sequence Not Found|  | | <a name=\"685\">685</a>|Sequence Already Exists|  | | <a name=\"686\">686</a>|Non-cycling sequence has been exhausted|  | | <a name=\"687\">687</a>|Legal Entity Identifier Already In Use|  | | <a name=\"688\">688</a>|Legal Entity Not Found|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"690\">690</a>|Property Type Is Not Supported|  | | <a name=\"691\">691</a>|Multiple Tax-lots For Currency Type Is Not Supported|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"693\">693</a>|Entity type is not supported for Relationship|  | | <a name=\"694\">694</a>|Relationship Validation Failure|  | | <a name=\"695\">695</a>|Relationship Not Found|  | | <a name=\"697\">697</a>|Derived Property Formula No Longer Valid|  | | <a name=\"698\">698</a>|Story is not available|  | | <a name=\"703\">703</a>|Corporate Action Does Not Exist|  | | <a name=\"720\">720</a>|The provided sort and filter combination is not valid|  | | <a name=\"721\">721</a>|A2B generation failed|  | | <a name=\"722\">722</a>|Aggregated Return Calculation Failure|  | | <a name=\"723\">723</a>|Custom Entity Definition Identifier Already In Use|  | | <a name=\"724\">724</a>|Custom Entity Definition Not Found|  | | <a name=\"725\">725</a>|The Placement requested was not found.|  | | <a name=\"726\">726</a>|The Execution requested was not found.|  | | <a name=\"727\">727</a>|The Block requested was not found.|  | | <a name=\"728\">728</a>|The Participation requested was not found.|  | | <a name=\"729\">729</a>|The Package requested was not found.|  | | <a name=\"730\">730</a>|The OrderInstruction requested was not found.|  | | <a name=\"732\">732</a>|Custom Entity not found.|  | | <a name=\"733\">733</a>|Custom Entity Identifier already in use.|  | | <a name=\"735\">735</a>|Calculation Failed.|  | | <a name=\"736\">736</a>|An expected key on HttpResponse is missing.|  | | <a name=\"737\">737</a>|A required fee detail is missing.|  | | <a name=\"738\">738</a>|Zero rows were returned from Luminesce|  | | <a name=\"739\">739</a>|Provided Weekend Mask was invalid|  | | <a name=\"742\">742</a>|Custom Entity fields do not match the definition|  | | <a name=\"746\">746</a>|The provided sequence is not valid.|  | | <a name=\"751\">751</a>|The type of the Custom Entity is different than the type provided in the definition.|  | | <a name=\"752\">752</a>|Luminesce process returned an error.|  | | <a name=\"753\">753</a>|File name or content incompatible with operation.|  | | <a name=\"755\">755</a>|Schema of response from Drive is not as expected.|  | | <a name=\"757\">757</a>|Schema of response from Luminesce is not as expected.|  | | <a name=\"758\">758</a>|Luminesce timed out.|  | | <a name=\"763\">763</a>|Invalid Lusid Entity Identifier Unit|  | | <a name=\"768\">768</a>|Fee rule not found.|  | | <a name=\"769\">769</a>|Cannot update the base currency of a portfolio with transactions loaded|  | | <a name=\"771\">771</a>|Transaction configuration source not found|  | | <a name=\"774\">774</a>|Compliance rule not found.|  | | <a name=\"775\">775</a>|Fund accounting document cannot be processed.|  | | <a name=\"778\">778</a>|Unable to look up FX rate from trade ccy to portfolio ccy for some of the trades.|  | | <a name=\"782\">782</a>|The Property definition dataType is not matching the derivation formula dataType|  | | <a name=\"783\">783</a>|The Property definition domain is not supported for derived properties|  | 
 *
 * The version of the OpenAPI document: 0.11.4245
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
    public interface IInstrumentsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EARLY ACCESS] DeleteInstrument: Delete instrument
        /// </summary>
        /// <remarks>
        /// Delete a particular instrument, as identified by a particular instrument identifier.                Once deleted, an instrument is marked as inactive and can no longer be referenced when creating or updating  transactions or holdings. You can still query existing transactions and holdings related to the  deleted instrument.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>DeleteInstrumentResponse</returns>
        DeleteInstrumentResponse DeleteInstrument(string identifierType, string identifier, string scope = default(string));

        /// <summary>
        /// [EARLY ACCESS] DeleteInstrument: Delete instrument
        /// </summary>
        /// <remarks>
        /// Delete a particular instrument, as identified by a particular instrument identifier.                Once deleted, an instrument is marked as inactive and can no longer be referenced when creating or updating  transactions or holdings. You can still query existing transactions and holdings related to the  deleted instrument.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of DeleteInstrumentResponse</returns>
        ApiResponse<DeleteInstrumentResponse> DeleteInstrumentWithHttpInfo(string identifierType, string identifier, string scope = default(string));
        /// <summary>
        /// GetInstrument: Get instrument
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a particular instrument, as identified by a particular unique identifier.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>Instrument</returns>
        Instrument GetInstrument(string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string));

        /// <summary>
        /// GetInstrument: Get instrument
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a particular instrument, as identified by a particular unique identifier.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of Instrument</returns>
        ApiResponse<Instrument> GetInstrumentWithHttpInfo(string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string));
        /// <summary>
        /// [EARLY ACCESS] GetInstrumentIdentifierTypes: Get instrument identifier types
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all valid instrument identifier types and whether they are unique or not.                An instrument must have a value for at least one unique identifier type (it can have more than one unique type and value).  In addition, a value is automatically generated for a LUSID Instrument ID (LUID) unique type by the system.                An instrument can have values for multiple non-unique identifier types (or it can have zero non-unique types and values).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ResourceListOfInstrumentIdTypeDescriptor</returns>
        ResourceListOfInstrumentIdTypeDescriptor GetInstrumentIdentifierTypes();

        /// <summary>
        /// [EARLY ACCESS] GetInstrumentIdentifierTypes: Get instrument identifier types
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all valid instrument identifier types and whether they are unique or not.                An instrument must have a value for at least one unique identifier type (it can have more than one unique type and value).  In addition, a value is automatically generated for a LUSID Instrument ID (LUID) unique type by the system.                An instrument can have values for multiple non-unique identifier types (or it can have zero non-unique types and values).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ResourceListOfInstrumentIdTypeDescriptor</returns>
        ApiResponse<ResourceListOfInstrumentIdTypeDescriptor> GetInstrumentIdentifierTypesWithHttpInfo();
        /// <summary>
        /// [EARLY ACCESS] GetInstrumentPropertyTimeSeries: Get instrument property time series
        /// </summary>
        /// <remarks>
        /// Retrieve the complete time series (history) for a particular property of an instrument.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="propertyKey">The property key of a property from the &#39;Instrument&#39; domain whose history to retrieve.              This must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.</param>
        /// <param name="identifierEffectiveAt">The effective datetime used to resolve the instrument from the identifier.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument&#39;s property history. Defaults to              returning the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering,              see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties; this value is returned from              the previous call. If a pagination token is provided, the &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and              &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. For more information, see              https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ResourceListOfPropertyInterval</returns>
        ResourceListOfPropertyInterval GetInstrumentPropertyTimeSeries(string identifierType, string identifier, string propertyKey, string identifierEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), string scope = default(string));

        /// <summary>
        /// [EARLY ACCESS] GetInstrumentPropertyTimeSeries: Get instrument property time series
        /// </summary>
        /// <remarks>
        /// Retrieve the complete time series (history) for a particular property of an instrument.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="propertyKey">The property key of a property from the &#39;Instrument&#39; domain whose history to retrieve.              This must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.</param>
        /// <param name="identifierEffectiveAt">The effective datetime used to resolve the instrument from the identifier.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument&#39;s property history. Defaults to              returning the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering,              see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties; this value is returned from              the previous call. If a pagination token is provided, the &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and              &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. For more information, see              https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of ResourceListOfPropertyInterval</returns>
        ApiResponse<ResourceListOfPropertyInterval> GetInstrumentPropertyTimeSeriesWithHttpInfo(string identifierType, string identifier, string propertyKey, string identifierEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), string scope = default(string));
        /// <summary>
        /// GetInstruments: Get instruments
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of one or more instruments, as identified by a collection of unique identifiers.                Note that to retrieve all the instruments in the instrument master, use the List instruments endpoint instead.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="requestBody">A list of one or more &lt;i&gt;identifierType&lt;/i&gt; values to use to identify instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.               Defaults to returning the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.               These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>GetInstrumentsResponse</returns>
        GetInstrumentsResponse GetInstruments(string identifierType, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string));

        /// <summary>
        /// GetInstruments: Get instruments
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of one or more instruments, as identified by a collection of unique identifiers.                Note that to retrieve all the instruments in the instrument master, use the List instruments endpoint instead.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="requestBody">A list of one or more &lt;i&gt;identifierType&lt;/i&gt; values to use to identify instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.               Defaults to returning the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.               These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of GetInstrumentsResponse</returns>
        ApiResponse<GetInstrumentsResponse> GetInstrumentsWithHttpInfo(string identifierType, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string));
        /// <summary>
        /// [EARLY ACCESS] ListInstruments: List instruments
        /// </summary>
        /// <remarks>
        /// List all the instruments in the instrument master.                To retrieve a particular set of instruments instead, use the Get instruments endpoint.  The maximum number of instruments that this method can list per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list instruments. Defaults to returning the latest               version of each instrument if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list instruments.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments; this value is returned from               the previous call. If a pagination token is provided, the &lt;i&gt;sortBy&lt;/i&gt;, &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and               &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. Also, a &lt;i&gt;start&lt;/i&gt; value cannot be               provided. For more information, see https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="sortBy">Order results by particular fields. Use the &#39;-&#39; sign to denote descending order, for               example &#39;-MyFieldName&#39;. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filtering out inactive instruments               (that is, those that have been deleted). For more information about filtering results,               see https://support.lusid.com/knowledgebase/article/KA-01914. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto               instruments. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>PagedResourceListOfInstrument</returns>
        PagedResourceListOfInstrument ListInstruments(DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), string page = default(string), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> instrumentPropertyKeys = default(List<string>), string scope = default(string));

        /// <summary>
        /// [EARLY ACCESS] ListInstruments: List instruments
        /// </summary>
        /// <remarks>
        /// List all the instruments in the instrument master.                To retrieve a particular set of instruments instead, use the Get instruments endpoint.  The maximum number of instruments that this method can list per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list instruments. Defaults to returning the latest               version of each instrument if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list instruments.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments; this value is returned from               the previous call. If a pagination token is provided, the &lt;i&gt;sortBy&lt;/i&gt;, &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and               &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. Also, a &lt;i&gt;start&lt;/i&gt; value cannot be               provided. For more information, see https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="sortBy">Order results by particular fields. Use the &#39;-&#39; sign to denote descending order, for               example &#39;-MyFieldName&#39;. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filtering out inactive instruments               (that is, those that have been deleted). For more information about filtering results,               see https://support.lusid.com/knowledgebase/article/KA-01914. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto               instruments. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of PagedResourceListOfInstrument</returns>
        ApiResponse<PagedResourceListOfInstrument> ListInstrumentsWithHttpInfo(DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), string page = default(string), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> instrumentPropertyKeys = default(List<string>), string scope = default(string));
        /// <summary>
        /// [EARLY ACCESS] UpdateInstrumentIdentifier: Update instrument identifier
        /// </summary>
        /// <remarks>
        /// Create, update or delete a particular instrument identifier for an instrument.                To delete the identifier, leave the value unspecified in the request. If not being deleted, the  identifier is updated if it exists and created if it does not.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="updateInstrumentIdentifierRequest">The identifier to update or delete. This need not be the same value as the               &#39;identifier&#39; parameter used to retrieve the instrument.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>Instrument</returns>
        Instrument UpdateInstrumentIdentifier(string identifierType, string identifier, UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest, string scope = default(string));

        /// <summary>
        /// [EARLY ACCESS] UpdateInstrumentIdentifier: Update instrument identifier
        /// </summary>
        /// <remarks>
        /// Create, update or delete a particular instrument identifier for an instrument.                To delete the identifier, leave the value unspecified in the request. If not being deleted, the  identifier is updated if it exists and created if it does not.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="updateInstrumentIdentifierRequest">The identifier to update or delete. This need not be the same value as the               &#39;identifier&#39; parameter used to retrieve the instrument.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of Instrument</returns>
        ApiResponse<Instrument> UpdateInstrumentIdentifierWithHttpInfo(string identifierType, string identifier, UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest, string scope = default(string));
        /// <summary>
        /// UpsertInstruments: Upsert instruments
        /// </summary>
        /// <remarks>
        /// Create or update one or more instruments in the instrument master. An instrument is updated  if it already exists and created if it does not.                In the request, each instrument definition should be keyed by a unique correlation ID. This ID is ephemeral  and not stored by LUSID. It serves only to easily identify each instrument in the response.                Note that an instrument must have at least one unique identifier, which is a combination of a type  (such as &#39;Figi&#39;) and a value (such as &#39;BBG000BS1N49&#39;). In addition, a random value is automatically  generated for a LUSID Instrument ID (LUID) unique type by the system. For more information, see  https://support.lusid.com/knowledgebase/article/KA-01862.                The response returns both the collection of successfully created or updated instruments, as well as those  that failed. For each failure, a reason is provided. It is important to check the failed set for  unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The definitions of the instruments to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>UpsertInstrumentsResponse</returns>
        UpsertInstrumentsResponse UpsertInstruments(Dictionary<string, InstrumentDefinition> requestBody, string scope = default(string));

        /// <summary>
        /// UpsertInstruments: Upsert instruments
        /// </summary>
        /// <remarks>
        /// Create or update one or more instruments in the instrument master. An instrument is updated  if it already exists and created if it does not.                In the request, each instrument definition should be keyed by a unique correlation ID. This ID is ephemeral  and not stored by LUSID. It serves only to easily identify each instrument in the response.                Note that an instrument must have at least one unique identifier, which is a combination of a type  (such as &#39;Figi&#39;) and a value (such as &#39;BBG000BS1N49&#39;). In addition, a random value is automatically  generated for a LUSID Instrument ID (LUID) unique type by the system. For more information, see  https://support.lusid.com/knowledgebase/article/KA-01862.                The response returns both the collection of successfully created or updated instruments, as well as those  that failed. For each failure, a reason is provided. It is important to check the failed set for  unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The definitions of the instruments to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of UpsertInstrumentsResponse</returns>
        ApiResponse<UpsertInstrumentsResponse> UpsertInstrumentsWithHttpInfo(Dictionary<string, InstrumentDefinition> requestBody, string scope = default(string));
        /// <summary>
        /// UpsertInstrumentsProperties: Upsert instruments properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more properties for particular instruments.                Each instrument property is updated if it exists and created if it does not. For any failures, a reason  is provided.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertInstrumentPropertyRequest">A list of instruments and associated instrument properties to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>UpsertInstrumentPropertiesResponse</returns>
        UpsertInstrumentPropertiesResponse UpsertInstrumentsProperties(List<UpsertInstrumentPropertyRequest> upsertInstrumentPropertyRequest, string scope = default(string));

        /// <summary>
        /// UpsertInstrumentsProperties: Upsert instruments properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more properties for particular instruments.                Each instrument property is updated if it exists and created if it does not. For any failures, a reason  is provided.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertInstrumentPropertyRequest">A list of instruments and associated instrument properties to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of UpsertInstrumentPropertiesResponse</returns>
        ApiResponse<UpsertInstrumentPropertiesResponse> UpsertInstrumentsPropertiesWithHttpInfo(List<UpsertInstrumentPropertyRequest> upsertInstrumentPropertyRequest, string scope = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInstrumentsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] DeleteInstrument: Delete instrument
        /// </summary>
        /// <remarks>
        /// Delete a particular instrument, as identified by a particular instrument identifier.                Once deleted, an instrument is marked as inactive and can no longer be referenced when creating or updating  transactions or holdings. You can still query existing transactions and holdings related to the  deleted instrument.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeleteInstrumentResponse</returns>
        System.Threading.Tasks.Task<DeleteInstrumentResponse> DeleteInstrumentAsync(string identifierType, string identifier, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeleteInstrument: Delete instrument
        /// </summary>
        /// <remarks>
        /// Delete a particular instrument, as identified by a particular instrument identifier.                Once deleted, an instrument is marked as inactive and can no longer be referenced when creating or updating  transactions or holdings. You can still query existing transactions and holdings related to the  deleted instrument.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeleteInstrumentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeleteInstrumentResponse>> DeleteInstrumentWithHttpInfoAsync(string identifierType, string identifier, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetInstrument: Get instrument
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a particular instrument, as identified by a particular unique identifier.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Instrument</returns>
        System.Threading.Tasks.Task<Instrument> GetInstrumentAsync(string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetInstrument: Get instrument
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a particular instrument, as identified by a particular unique identifier.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Instrument)</returns>
        System.Threading.Tasks.Task<ApiResponse<Instrument>> GetInstrumentWithHttpInfoAsync(string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetInstrumentIdentifierTypes: Get instrument identifier types
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all valid instrument identifier types and whether they are unique or not.                An instrument must have a value for at least one unique identifier type (it can have more than one unique type and value).  In addition, a value is automatically generated for a LUSID Instrument ID (LUID) unique type by the system.                An instrument can have values for multiple non-unique identifier types (or it can have zero non-unique types and values).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfInstrumentIdTypeDescriptor</returns>
        System.Threading.Tasks.Task<ResourceListOfInstrumentIdTypeDescriptor> GetInstrumentIdentifierTypesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetInstrumentIdentifierTypes: Get instrument identifier types
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all valid instrument identifier types and whether they are unique or not.                An instrument must have a value for at least one unique identifier type (it can have more than one unique type and value).  In addition, a value is automatically generated for a LUSID Instrument ID (LUID) unique type by the system.                An instrument can have values for multiple non-unique identifier types (or it can have zero non-unique types and values).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfInstrumentIdTypeDescriptor)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfInstrumentIdTypeDescriptor>> GetInstrumentIdentifierTypesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetInstrumentPropertyTimeSeries: Get instrument property time series
        /// </summary>
        /// <remarks>
        /// Retrieve the complete time series (history) for a particular property of an instrument.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="propertyKey">The property key of a property from the &#39;Instrument&#39; domain whose history to retrieve.              This must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.</param>
        /// <param name="identifierEffectiveAt">The effective datetime used to resolve the instrument from the identifier.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument&#39;s property history. Defaults to              returning the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering,              see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties; this value is returned from              the previous call. If a pagination token is provided, the &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and              &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. For more information, see              https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPropertyInterval</returns>
        System.Threading.Tasks.Task<ResourceListOfPropertyInterval> GetInstrumentPropertyTimeSeriesAsync(string identifierType, string identifier, string propertyKey, string identifierEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetInstrumentPropertyTimeSeries: Get instrument property time series
        /// </summary>
        /// <remarks>
        /// Retrieve the complete time series (history) for a particular property of an instrument.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="propertyKey">The property key of a property from the &#39;Instrument&#39; domain whose history to retrieve.              This must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.</param>
        /// <param name="identifierEffectiveAt">The effective datetime used to resolve the instrument from the identifier.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument&#39;s property history. Defaults to              returning the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering,              see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties; this value is returned from              the previous call. If a pagination token is provided, the &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and              &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. For more information, see              https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPropertyInterval)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPropertyInterval>> GetInstrumentPropertyTimeSeriesWithHttpInfoAsync(string identifierType, string identifier, string propertyKey, string identifierEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetInstruments: Get instruments
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of one or more instruments, as identified by a collection of unique identifiers.                Note that to retrieve all the instruments in the instrument master, use the List instruments endpoint instead.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="requestBody">A list of one or more &lt;i&gt;identifierType&lt;/i&gt; values to use to identify instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.               Defaults to returning the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.               These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetInstrumentsResponse</returns>
        System.Threading.Tasks.Task<GetInstrumentsResponse> GetInstrumentsAsync(string identifierType, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetInstruments: Get instruments
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of one or more instruments, as identified by a collection of unique identifiers.                Note that to retrieve all the instruments in the instrument master, use the List instruments endpoint instead.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="requestBody">A list of one or more &lt;i&gt;identifierType&lt;/i&gt; values to use to identify instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.               Defaults to returning the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.               These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetInstrumentsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetInstrumentsResponse>> GetInstrumentsWithHttpInfoAsync(string identifierType, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] ListInstruments: List instruments
        /// </summary>
        /// <remarks>
        /// List all the instruments in the instrument master.                To retrieve a particular set of instruments instead, use the Get instruments endpoint.  The maximum number of instruments that this method can list per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list instruments. Defaults to returning the latest               version of each instrument if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list instruments.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments; this value is returned from               the previous call. If a pagination token is provided, the &lt;i&gt;sortBy&lt;/i&gt;, &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and               &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. Also, a &lt;i&gt;start&lt;/i&gt; value cannot be               provided. For more information, see https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="sortBy">Order results by particular fields. Use the &#39;-&#39; sign to denote descending order, for               example &#39;-MyFieldName&#39;. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filtering out inactive instruments               (that is, those that have been deleted). For more information about filtering results,               see https://support.lusid.com/knowledgebase/article/KA-01914. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto               instruments. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PagedResourceListOfInstrument</returns>
        System.Threading.Tasks.Task<PagedResourceListOfInstrument> ListInstrumentsAsync(DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), string page = default(string), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> instrumentPropertyKeys = default(List<string>), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] ListInstruments: List instruments
        /// </summary>
        /// <remarks>
        /// List all the instruments in the instrument master.                To retrieve a particular set of instruments instead, use the Get instruments endpoint.  The maximum number of instruments that this method can list per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list instruments. Defaults to returning the latest               version of each instrument if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list instruments.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments; this value is returned from               the previous call. If a pagination token is provided, the &lt;i&gt;sortBy&lt;/i&gt;, &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and               &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. Also, a &lt;i&gt;start&lt;/i&gt; value cannot be               provided. For more information, see https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="sortBy">Order results by particular fields. Use the &#39;-&#39; sign to denote descending order, for               example &#39;-MyFieldName&#39;. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filtering out inactive instruments               (that is, those that have been deleted). For more information about filtering results,               see https://support.lusid.com/knowledgebase/article/KA-01914. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto               instruments. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PagedResourceListOfInstrument)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagedResourceListOfInstrument>> ListInstrumentsWithHttpInfoAsync(DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), string page = default(string), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> instrumentPropertyKeys = default(List<string>), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] UpdateInstrumentIdentifier: Update instrument identifier
        /// </summary>
        /// <remarks>
        /// Create, update or delete a particular instrument identifier for an instrument.                To delete the identifier, leave the value unspecified in the request. If not being deleted, the  identifier is updated if it exists and created if it does not.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="updateInstrumentIdentifierRequest">The identifier to update or delete. This need not be the same value as the               &#39;identifier&#39; parameter used to retrieve the instrument.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Instrument</returns>
        System.Threading.Tasks.Task<Instrument> UpdateInstrumentIdentifierAsync(string identifierType, string identifier, UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] UpdateInstrumentIdentifier: Update instrument identifier
        /// </summary>
        /// <remarks>
        /// Create, update or delete a particular instrument identifier for an instrument.                To delete the identifier, leave the value unspecified in the request. If not being deleted, the  identifier is updated if it exists and created if it does not.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="updateInstrumentIdentifierRequest">The identifier to update or delete. This need not be the same value as the               &#39;identifier&#39; parameter used to retrieve the instrument.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Instrument)</returns>
        System.Threading.Tasks.Task<ApiResponse<Instrument>> UpdateInstrumentIdentifierWithHttpInfoAsync(string identifierType, string identifier, UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// UpsertInstruments: Upsert instruments
        /// </summary>
        /// <remarks>
        /// Create or update one or more instruments in the instrument master. An instrument is updated  if it already exists and created if it does not.                In the request, each instrument definition should be keyed by a unique correlation ID. This ID is ephemeral  and not stored by LUSID. It serves only to easily identify each instrument in the response.                Note that an instrument must have at least one unique identifier, which is a combination of a type  (such as &#39;Figi&#39;) and a value (such as &#39;BBG000BS1N49&#39;). In addition, a random value is automatically  generated for a LUSID Instrument ID (LUID) unique type by the system. For more information, see  https://support.lusid.com/knowledgebase/article/KA-01862.                The response returns both the collection of successfully created or updated instruments, as well as those  that failed. For each failure, a reason is provided. It is important to check the failed set for  unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The definitions of the instruments to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpsertInstrumentsResponse</returns>
        System.Threading.Tasks.Task<UpsertInstrumentsResponse> UpsertInstrumentsAsync(Dictionary<string, InstrumentDefinition> requestBody, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// UpsertInstruments: Upsert instruments
        /// </summary>
        /// <remarks>
        /// Create or update one or more instruments in the instrument master. An instrument is updated  if it already exists and created if it does not.                In the request, each instrument definition should be keyed by a unique correlation ID. This ID is ephemeral  and not stored by LUSID. It serves only to easily identify each instrument in the response.                Note that an instrument must have at least one unique identifier, which is a combination of a type  (such as &#39;Figi&#39;) and a value (such as &#39;BBG000BS1N49&#39;). In addition, a random value is automatically  generated for a LUSID Instrument ID (LUID) unique type by the system. For more information, see  https://support.lusid.com/knowledgebase/article/KA-01862.                The response returns both the collection of successfully created or updated instruments, as well as those  that failed. For each failure, a reason is provided. It is important to check the failed set for  unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The definitions of the instruments to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpsertInstrumentsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertInstrumentsResponse>> UpsertInstrumentsWithHttpInfoAsync(Dictionary<string, InstrumentDefinition> requestBody, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// UpsertInstrumentsProperties: Upsert instruments properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more properties for particular instruments.                Each instrument property is updated if it exists and created if it does not. For any failures, a reason  is provided.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertInstrumentPropertyRequest">A list of instruments and associated instrument properties to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpsertInstrumentPropertiesResponse</returns>
        System.Threading.Tasks.Task<UpsertInstrumentPropertiesResponse> UpsertInstrumentsPropertiesAsync(List<UpsertInstrumentPropertyRequest> upsertInstrumentPropertyRequest, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// UpsertInstrumentsProperties: Upsert instruments properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more properties for particular instruments.                Each instrument property is updated if it exists and created if it does not. For any failures, a reason  is provided.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertInstrumentPropertyRequest">A list of instruments and associated instrument properties to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpsertInstrumentPropertiesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertInstrumentPropertiesResponse>> UpsertInstrumentsPropertiesWithHttpInfoAsync(List<UpsertInstrumentPropertyRequest> upsertInstrumentPropertyRequest, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInstrumentsApi : IInstrumentsApiSync, IInstrumentsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InstrumentsApi : IInstrumentsApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InstrumentsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InstrumentsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="InstrumentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InstrumentsApi(Lusid.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public InstrumentsApi(Lusid.Sdk.Client.ISynchronousClient client, Lusid.Sdk.Client.IAsynchronousClient asyncClient, Lusid.Sdk.Client.IReadableConfiguration configuration)
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
        /// [EARLY ACCESS] DeleteInstrument: Delete instrument Delete a particular instrument, as identified by a particular instrument identifier.                Once deleted, an instrument is marked as inactive and can no longer be referenced when creating or updating  transactions or holdings. You can still query existing transactions and holdings related to the  deleted instrument.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>DeleteInstrumentResponse</returns>
        public DeleteInstrumentResponse DeleteInstrument(string identifierType, string identifier, string scope = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<DeleteInstrumentResponse> localVarResponse = DeleteInstrumentWithHttpInfo(identifierType, identifier, scope);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteInstrument: Delete instrument Delete a particular instrument, as identified by a particular instrument identifier.                Once deleted, an instrument is marked as inactive and can no longer be referenced when creating or updating  transactions or holdings. You can still query existing transactions and holdings related to the  deleted instrument.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of DeleteInstrumentResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeleteInstrumentResponse> DeleteInstrumentWithHttpInfo(string identifierType, string identifier, string scope = default(string))
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->DeleteInstrument");

            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->DeleteInstrument");

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

            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifier", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifier)); // path parameter
            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeleteInstrumentResponse>("/api/instruments/{identifierType}/{identifier}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteInstrument", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteInstrument: Delete instrument Delete a particular instrument, as identified by a particular instrument identifier.                Once deleted, an instrument is marked as inactive and can no longer be referenced when creating or updating  transactions or holdings. You can still query existing transactions and holdings related to the  deleted instrument.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeleteInstrumentResponse</returns>
        public async System.Threading.Tasks.Task<DeleteInstrumentResponse> DeleteInstrumentAsync(string identifierType, string identifier, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeleteInstrumentResponse> localVarResponse = await DeleteInstrumentWithHttpInfoAsync(identifierType, identifier, scope, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteInstrument: Delete instrument Delete a particular instrument, as identified by a particular instrument identifier.                Once deleted, an instrument is marked as inactive and can no longer be referenced when creating or updating  transactions or holdings. You can still query existing transactions and holdings related to the  deleted instrument.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeleteInstrumentResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeleteInstrumentResponse>> DeleteInstrumentWithHttpInfoAsync(string identifierType, string identifier, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->DeleteInstrument");

            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->DeleteInstrument");


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

            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifier", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifier)); // path parameter
            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeleteInstrumentResponse>("/api/instruments/{identifierType}/{identifier}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteInstrument", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetInstrument: Get instrument Retrieve the definition of a particular instrument, as identified by a particular unique identifier.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>Instrument</returns>
        public Instrument GetInstrument(string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<Instrument> localVarResponse = GetInstrumentWithHttpInfo(identifierType, identifier, effectiveAt, asAt, propertyKeys, scope);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetInstrument: Get instrument Retrieve the definition of a particular instrument, as identified by a particular unique identifier.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of Instrument</returns>
        public Lusid.Sdk.Client.ApiResponse<Instrument> GetInstrumentWithHttpInfo(string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string))
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->GetInstrument");

            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->GetInstrument");

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

            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifier", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifier)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }
            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request
            var localVarResponse = this.Client.Get<Instrument>("/api/instruments/{identifierType}/{identifier}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstrument", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetInstrument: Get instrument Retrieve the definition of a particular instrument, as identified by a particular unique identifier.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Instrument</returns>
        public async System.Threading.Tasks.Task<Instrument> GetInstrumentAsync(string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Instrument> localVarResponse = await GetInstrumentWithHttpInfoAsync(identifierType, identifier, effectiveAt, asAt, propertyKeys, scope, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetInstrument: Get instrument Retrieve the definition of a particular instrument, as identified by a particular unique identifier.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Instrument)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Instrument>> GetInstrumentWithHttpInfoAsync(string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->GetInstrument");

            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->GetInstrument");


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

            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifier", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifier)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }
            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Instrument>("/api/instruments/{identifierType}/{identifier}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstrument", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetInstrumentIdentifierTypes: Get instrument identifier types Retrieve a list of all valid instrument identifier types and whether they are unique or not.                An instrument must have a value for at least one unique identifier type (it can have more than one unique type and value).  In addition, a value is automatically generated for a LUSID Instrument ID (LUID) unique type by the system.                An instrument can have values for multiple non-unique identifier types (or it can have zero non-unique types and values).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ResourceListOfInstrumentIdTypeDescriptor</returns>
        public ResourceListOfInstrumentIdTypeDescriptor GetInstrumentIdentifierTypes()
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfInstrumentIdTypeDescriptor> localVarResponse = GetInstrumentIdentifierTypesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetInstrumentIdentifierTypes: Get instrument identifier types Retrieve a list of all valid instrument identifier types and whether they are unique or not.                An instrument must have a value for at least one unique identifier type (it can have more than one unique type and value).  In addition, a value is automatically generated for a LUSID Instrument ID (LUID) unique type by the system.                An instrument can have values for multiple non-unique identifier types (or it can have zero non-unique types and values).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ResourceListOfInstrumentIdTypeDescriptor</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfInstrumentIdTypeDescriptor> GetInstrumentIdentifierTypesWithHttpInfo()
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


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfInstrumentIdTypeDescriptor>("/api/instruments/identifierTypes", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstrumentIdentifierTypes", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetInstrumentIdentifierTypes: Get instrument identifier types Retrieve a list of all valid instrument identifier types and whether they are unique or not.                An instrument must have a value for at least one unique identifier type (it can have more than one unique type and value).  In addition, a value is automatically generated for a LUSID Instrument ID (LUID) unique type by the system.                An instrument can have values for multiple non-unique identifier types (or it can have zero non-unique types and values).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfInstrumentIdTypeDescriptor</returns>
        public async System.Threading.Tasks.Task<ResourceListOfInstrumentIdTypeDescriptor> GetInstrumentIdentifierTypesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfInstrumentIdTypeDescriptor> localVarResponse = await GetInstrumentIdentifierTypesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetInstrumentIdentifierTypes: Get instrument identifier types Retrieve a list of all valid instrument identifier types and whether they are unique or not.                An instrument must have a value for at least one unique identifier type (it can have more than one unique type and value).  In addition, a value is automatically generated for a LUSID Instrument ID (LUID) unique type by the system.                An instrument can have values for multiple non-unique identifier types (or it can have zero non-unique types and values).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfInstrumentIdTypeDescriptor)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfInstrumentIdTypeDescriptor>> GetInstrumentIdentifierTypesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfInstrumentIdTypeDescriptor>("/api/instruments/identifierTypes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstrumentIdentifierTypes", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetInstrumentPropertyTimeSeries: Get instrument property time series Retrieve the complete time series (history) for a particular property of an instrument.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="propertyKey">The property key of a property from the &#39;Instrument&#39; domain whose history to retrieve.              This must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.</param>
        /// <param name="identifierEffectiveAt">The effective datetime used to resolve the instrument from the identifier.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument&#39;s property history. Defaults to              returning the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering,              see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties; this value is returned from              the previous call. If a pagination token is provided, the &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and              &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. For more information, see              https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ResourceListOfPropertyInterval</returns>
        public ResourceListOfPropertyInterval GetInstrumentPropertyTimeSeries(string identifierType, string identifier, string propertyKey, string identifierEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), string scope = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPropertyInterval> localVarResponse = GetInstrumentPropertyTimeSeriesWithHttpInfo(identifierType, identifier, propertyKey, identifierEffectiveAt, asAt, filter, page, limit, scope);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetInstrumentPropertyTimeSeries: Get instrument property time series Retrieve the complete time series (history) for a particular property of an instrument.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="propertyKey">The property key of a property from the &#39;Instrument&#39; domain whose history to retrieve.              This must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.</param>
        /// <param name="identifierEffectiveAt">The effective datetime used to resolve the instrument from the identifier.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument&#39;s property history. Defaults to              returning the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering,              see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties; this value is returned from              the previous call. If a pagination token is provided, the &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and              &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. For more information, see              https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of ResourceListOfPropertyInterval</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfPropertyInterval> GetInstrumentPropertyTimeSeriesWithHttpInfo(string identifierType, string identifier, string propertyKey, string identifierEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), string scope = default(string))
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->GetInstrumentPropertyTimeSeries");

            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->GetInstrumentPropertyTimeSeries");

            // verify the required parameter 'propertyKey' is set
            if (propertyKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKey' when calling InstrumentsApi->GetInstrumentPropertyTimeSeries");

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

            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifier", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifier)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "propertyKey", propertyKey));
            if (identifierEffectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierEffectiveAt", identifierEffectiveAt));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfPropertyInterval>("/api/instruments/{identifierType}/{identifier}/properties/time-series", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstrumentPropertyTimeSeries", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetInstrumentPropertyTimeSeries: Get instrument property time series Retrieve the complete time series (history) for a particular property of an instrument.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="propertyKey">The property key of a property from the &#39;Instrument&#39; domain whose history to retrieve.              This must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.</param>
        /// <param name="identifierEffectiveAt">The effective datetime used to resolve the instrument from the identifier.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument&#39;s property history. Defaults to              returning the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering,              see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties; this value is returned from              the previous call. If a pagination token is provided, the &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and              &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. For more information, see              https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPropertyInterval</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPropertyInterval> GetInstrumentPropertyTimeSeriesAsync(string identifierType, string identifier, string propertyKey, string identifierEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPropertyInterval> localVarResponse = await GetInstrumentPropertyTimeSeriesWithHttpInfoAsync(identifierType, identifier, propertyKey, identifierEffectiveAt, asAt, filter, page, limit, scope, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetInstrumentPropertyTimeSeries: Get instrument property time series Retrieve the complete time series (history) for a particular property of an instrument.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="propertyKey">The property key of a property from the &#39;Instrument&#39; domain whose history to retrieve.              This must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.</param>
        /// <param name="identifierEffectiveAt">The effective datetime used to resolve the instrument from the identifier.              Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument&#39;s property history. Defaults to              returning the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering,              see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties; this value is returned from              the previous call. If a pagination token is provided, the &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and              &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. For more information, see              https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPropertyInterval)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfPropertyInterval>> GetInstrumentPropertyTimeSeriesWithHttpInfoAsync(string identifierType, string identifier, string propertyKey, string identifierEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->GetInstrumentPropertyTimeSeries");

            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->GetInstrumentPropertyTimeSeries");

            // verify the required parameter 'propertyKey' is set
            if (propertyKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKey' when calling InstrumentsApi->GetInstrumentPropertyTimeSeries");


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

            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifier", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifier)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "propertyKey", propertyKey));
            if (identifierEffectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierEffectiveAt", identifierEffectiveAt));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfPropertyInterval>("/api/instruments/{identifierType}/{identifier}/properties/time-series", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstrumentPropertyTimeSeries", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetInstruments: Get instruments Retrieve the definition of one or more instruments, as identified by a collection of unique identifiers.                Note that to retrieve all the instruments in the instrument master, use the List instruments endpoint instead.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="requestBody">A list of one or more &lt;i&gt;identifierType&lt;/i&gt; values to use to identify instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.               Defaults to returning the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.               These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>GetInstrumentsResponse</returns>
        public GetInstrumentsResponse GetInstruments(string identifierType, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<GetInstrumentsResponse> localVarResponse = GetInstrumentsWithHttpInfo(identifierType, requestBody, effectiveAt, asAt, propertyKeys, scope);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetInstruments: Get instruments Retrieve the definition of one or more instruments, as identified by a collection of unique identifiers.                Note that to retrieve all the instruments in the instrument master, use the List instruments endpoint instead.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="requestBody">A list of one or more &lt;i&gt;identifierType&lt;/i&gt; values to use to identify instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.               Defaults to returning the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.               These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of GetInstrumentsResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<GetInstrumentsResponse> GetInstrumentsWithHttpInfo(string identifierType, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string))
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->GetInstruments");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling InstrumentsApi->GetInstruments");

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

            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierType", identifierType));
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }
            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }
            localVarRequestOptions.Data = requestBody;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request
            var localVarResponse = this.Client.Post<GetInstrumentsResponse>("/api/instruments/$get", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstruments", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetInstruments: Get instruments Retrieve the definition of one or more instruments, as identified by a collection of unique identifiers.                Note that to retrieve all the instruments in the instrument master, use the List instruments endpoint instead.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="requestBody">A list of one or more &lt;i&gt;identifierType&lt;/i&gt; values to use to identify instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.               Defaults to returning the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.               These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetInstrumentsResponse</returns>
        public async System.Threading.Tasks.Task<GetInstrumentsResponse> GetInstrumentsAsync(string identifierType, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<GetInstrumentsResponse> localVarResponse = await GetInstrumentsWithHttpInfoAsync(identifierType, requestBody, effectiveAt, asAt, propertyKeys, scope, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetInstruments: Get instruments Retrieve the definition of one or more instruments, as identified by a collection of unique identifiers.                Note that to retrieve all the instruments in the instrument master, use the List instruments endpoint instead.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to use, for example &#39;Figi&#39;.</param>
        /// <param name="requestBody">A list of one or more &lt;i&gt;identifierType&lt;/i&gt; values to use to identify instruments.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the instrument definitions.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the instrument definitions.               Defaults to returning the latest version of each instrument definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto the instrument.               These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetInstrumentsResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<GetInstrumentsResponse>> GetInstrumentsWithHttpInfoAsync(string identifierType, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->GetInstruments");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling InstrumentsApi->GetInstruments");


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

            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierType", identifierType));
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }
            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }
            localVarRequestOptions.Data = requestBody;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<GetInstrumentsResponse>("/api/instruments/$get", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstruments", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListInstruments: List instruments List all the instruments in the instrument master.                To retrieve a particular set of instruments instead, use the Get instruments endpoint.  The maximum number of instruments that this method can list per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list instruments. Defaults to returning the latest               version of each instrument if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list instruments.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments; this value is returned from               the previous call. If a pagination token is provided, the &lt;i&gt;sortBy&lt;/i&gt;, &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and               &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. Also, a &lt;i&gt;start&lt;/i&gt; value cannot be               provided. For more information, see https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="sortBy">Order results by particular fields. Use the &#39;-&#39; sign to denote descending order, for               example &#39;-MyFieldName&#39;. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filtering out inactive instruments               (that is, those that have been deleted). For more information about filtering results,               see https://support.lusid.com/knowledgebase/article/KA-01914. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto               instruments. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>PagedResourceListOfInstrument</returns>
        public PagedResourceListOfInstrument ListInstruments(DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), string page = default(string), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> instrumentPropertyKeys = default(List<string>), string scope = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<PagedResourceListOfInstrument> localVarResponse = ListInstrumentsWithHttpInfo(asAt, effectiveAt, page, sortBy, start, limit, filter, instrumentPropertyKeys, scope);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListInstruments: List instruments List all the instruments in the instrument master.                To retrieve a particular set of instruments instead, use the Get instruments endpoint.  The maximum number of instruments that this method can list per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list instruments. Defaults to returning the latest               version of each instrument if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list instruments.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments; this value is returned from               the previous call. If a pagination token is provided, the &lt;i&gt;sortBy&lt;/i&gt;, &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and               &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. Also, a &lt;i&gt;start&lt;/i&gt; value cannot be               provided. For more information, see https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="sortBy">Order results by particular fields. Use the &#39;-&#39; sign to denote descending order, for               example &#39;-MyFieldName&#39;. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filtering out inactive instruments               (that is, those that have been deleted). For more information about filtering results,               see https://support.lusid.com/knowledgebase/article/KA-01914. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto               instruments. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of PagedResourceListOfInstrument</returns>
        public Lusid.Sdk.Client.ApiResponse<PagedResourceListOfInstrument> ListInstrumentsWithHttpInfo(DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), string page = default(string), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> instrumentPropertyKeys = default(List<string>), string scope = default(string))
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
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
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
            if (instrumentPropertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "instrumentPropertyKeys", instrumentPropertyKeys));
            }
            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request
            var localVarResponse = this.Client.Get<PagedResourceListOfInstrument>("/api/instruments", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListInstruments", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListInstruments: List instruments List all the instruments in the instrument master.                To retrieve a particular set of instruments instead, use the Get instruments endpoint.  The maximum number of instruments that this method can list per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list instruments. Defaults to returning the latest               version of each instrument if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list instruments.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments; this value is returned from               the previous call. If a pagination token is provided, the &lt;i&gt;sortBy&lt;/i&gt;, &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and               &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. Also, a &lt;i&gt;start&lt;/i&gt; value cannot be               provided. For more information, see https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="sortBy">Order results by particular fields. Use the &#39;-&#39; sign to denote descending order, for               example &#39;-MyFieldName&#39;. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filtering out inactive instruments               (that is, those that have been deleted). For more information about filtering results,               see https://support.lusid.com/knowledgebase/article/KA-01914. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto               instruments. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PagedResourceListOfInstrument</returns>
        public async System.Threading.Tasks.Task<PagedResourceListOfInstrument> ListInstrumentsAsync(DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), string page = default(string), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> instrumentPropertyKeys = default(List<string>), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PagedResourceListOfInstrument> localVarResponse = await ListInstrumentsWithHttpInfoAsync(asAt, effectiveAt, page, sortBy, start, limit, filter, instrumentPropertyKeys, scope, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListInstruments: List instruments List all the instruments in the instrument master.                To retrieve a particular set of instruments instead, use the Get instruments endpoint.  The maximum number of instruments that this method can list per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The asAt datetime at which to list instruments. Defaults to returning the latest               version of each instrument if not specified. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list instruments.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing instruments; this value is returned from               the previous call. If a pagination token is provided, the &lt;i&gt;sortBy&lt;/i&gt;, &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and               &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. Also, a &lt;i&gt;start&lt;/i&gt; value cannot be               provided. For more information, see https://support.lusid.com/knowledgebase/article/KA-01915. (optional)</param>
        /// <param name="sortBy">Order results by particular fields. Use the &#39;-&#39; sign to denote descending order, for               example &#39;-MyFieldName&#39;. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Defaults to filtering out inactive instruments               (that is, those that have been deleted). For more information about filtering results,               see https://support.lusid.com/knowledgebase/article/KA-01914. (optional, default to &quot;State eq &#39;Active&#39;&quot;)</param>
        /// <param name="instrumentPropertyKeys">A list of property keys from the &#39;Instrument&#39; domain to decorate onto               instruments. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. (optional)</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PagedResourceListOfInstrument)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PagedResourceListOfInstrument>> ListInstrumentsWithHttpInfoAsync(DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), string page = default(string), List<string> sortBy = default(List<string>), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> instrumentPropertyKeys = default(List<string>), string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
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
            if (instrumentPropertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "instrumentPropertyKeys", instrumentPropertyKeys));
            }
            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PagedResourceListOfInstrument>("/api/instruments", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListInstruments", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateInstrumentIdentifier: Update instrument identifier Create, update or delete a particular instrument identifier for an instrument.                To delete the identifier, leave the value unspecified in the request. If not being deleted, the  identifier is updated if it exists and created if it does not.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="updateInstrumentIdentifierRequest">The identifier to update or delete. This need not be the same value as the               &#39;identifier&#39; parameter used to retrieve the instrument.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>Instrument</returns>
        public Instrument UpdateInstrumentIdentifier(string identifierType, string identifier, UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest, string scope = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<Instrument> localVarResponse = UpdateInstrumentIdentifierWithHttpInfo(identifierType, identifier, updateInstrumentIdentifierRequest, scope);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateInstrumentIdentifier: Update instrument identifier Create, update or delete a particular instrument identifier for an instrument.                To delete the identifier, leave the value unspecified in the request. If not being deleted, the  identifier is updated if it exists and created if it does not.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="updateInstrumentIdentifierRequest">The identifier to update or delete. This need not be the same value as the               &#39;identifier&#39; parameter used to retrieve the instrument.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of Instrument</returns>
        public Lusid.Sdk.Client.ApiResponse<Instrument> UpdateInstrumentIdentifierWithHttpInfo(string identifierType, string identifier, UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest, string scope = default(string))
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->UpdateInstrumentIdentifier");

            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->UpdateInstrumentIdentifier");

            // verify the required parameter 'updateInstrumentIdentifierRequest' is set
            if (updateInstrumentIdentifierRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'updateInstrumentIdentifierRequest' when calling InstrumentsApi->UpdateInstrumentIdentifier");

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

            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifier", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifier)); // path parameter
            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }
            localVarRequestOptions.Data = updateInstrumentIdentifierRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request
            var localVarResponse = this.Client.Post<Instrument>("/api/instruments/{identifierType}/{identifier}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateInstrumentIdentifier", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateInstrumentIdentifier: Update instrument identifier Create, update or delete a particular instrument identifier for an instrument.                To delete the identifier, leave the value unspecified in the request. If not being deleted, the  identifier is updated if it exists and created if it does not.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="updateInstrumentIdentifierRequest">The identifier to update or delete. This need not be the same value as the               &#39;identifier&#39; parameter used to retrieve the instrument.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Instrument</returns>
        public async System.Threading.Tasks.Task<Instrument> UpdateInstrumentIdentifierAsync(string identifierType, string identifier, UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Instrument> localVarResponse = await UpdateInstrumentIdentifierWithHttpInfoAsync(identifierType, identifier, updateInstrumentIdentifierRequest, scope, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateInstrumentIdentifier: Update instrument identifier Create, update or delete a particular instrument identifier for an instrument.                To delete the identifier, leave the value unspecified in the request. If not being deleted, the  identifier is updated if it exists and created if it does not.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifierType">The unique identifier type to search, for example &#39;Figi&#39;.</param>
        /// <param name="identifier">An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;.</param>
        /// <param name="updateInstrumentIdentifierRequest">The identifier to update or delete. This need not be the same value as the               &#39;identifier&#39; parameter used to retrieve the instrument.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Instrument)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Instrument>> UpdateInstrumentIdentifierWithHttpInfoAsync(string identifierType, string identifier, UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling InstrumentsApi->UpdateInstrumentIdentifier");

            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifier' when calling InstrumentsApi->UpdateInstrumentIdentifier");

            // verify the required parameter 'updateInstrumentIdentifierRequest' is set
            if (updateInstrumentIdentifierRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'updateInstrumentIdentifierRequest' when calling InstrumentsApi->UpdateInstrumentIdentifier");


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

            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifier", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifier)); // path parameter
            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }
            localVarRequestOptions.Data = updateInstrumentIdentifierRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Instrument>("/api/instruments/{identifierType}/{identifier}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateInstrumentIdentifier", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// UpsertInstruments: Upsert instruments Create or update one or more instruments in the instrument master. An instrument is updated  if it already exists and created if it does not.                In the request, each instrument definition should be keyed by a unique correlation ID. This ID is ephemeral  and not stored by LUSID. It serves only to easily identify each instrument in the response.                Note that an instrument must have at least one unique identifier, which is a combination of a type  (such as &#39;Figi&#39;) and a value (such as &#39;BBG000BS1N49&#39;). In addition, a random value is automatically  generated for a LUSID Instrument ID (LUID) unique type by the system. For more information, see  https://support.lusid.com/knowledgebase/article/KA-01862.                The response returns both the collection of successfully created or updated instruments, as well as those  that failed. For each failure, a reason is provided. It is important to check the failed set for  unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The definitions of the instruments to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>UpsertInstrumentsResponse</returns>
        public UpsertInstrumentsResponse UpsertInstruments(Dictionary<string, InstrumentDefinition> requestBody, string scope = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<UpsertInstrumentsResponse> localVarResponse = UpsertInstrumentsWithHttpInfo(requestBody, scope);
            return localVarResponse.Data;
        }

        /// <summary>
        /// UpsertInstruments: Upsert instruments Create or update one or more instruments in the instrument master. An instrument is updated  if it already exists and created if it does not.                In the request, each instrument definition should be keyed by a unique correlation ID. This ID is ephemeral  and not stored by LUSID. It serves only to easily identify each instrument in the response.                Note that an instrument must have at least one unique identifier, which is a combination of a type  (such as &#39;Figi&#39;) and a value (such as &#39;BBG000BS1N49&#39;). In addition, a random value is automatically  generated for a LUSID Instrument ID (LUID) unique type by the system. For more information, see  https://support.lusid.com/knowledgebase/article/KA-01862.                The response returns both the collection of successfully created or updated instruments, as well as those  that failed. For each failure, a reason is provided. It is important to check the failed set for  unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The definitions of the instruments to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of UpsertInstrumentsResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<UpsertInstrumentsResponse> UpsertInstrumentsWithHttpInfo(Dictionary<string, InstrumentDefinition> requestBody, string scope = default(string))
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling InstrumentsApi->UpsertInstruments");

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

            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }
            localVarRequestOptions.Data = requestBody;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request
            var localVarResponse = this.Client.Post<UpsertInstrumentsResponse>("/api/instruments", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertInstruments", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// UpsertInstruments: Upsert instruments Create or update one or more instruments in the instrument master. An instrument is updated  if it already exists and created if it does not.                In the request, each instrument definition should be keyed by a unique correlation ID. This ID is ephemeral  and not stored by LUSID. It serves only to easily identify each instrument in the response.                Note that an instrument must have at least one unique identifier, which is a combination of a type  (such as &#39;Figi&#39;) and a value (such as &#39;BBG000BS1N49&#39;). In addition, a random value is automatically  generated for a LUSID Instrument ID (LUID) unique type by the system. For more information, see  https://support.lusid.com/knowledgebase/article/KA-01862.                The response returns both the collection of successfully created or updated instruments, as well as those  that failed. For each failure, a reason is provided. It is important to check the failed set for  unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The definitions of the instruments to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpsertInstrumentsResponse</returns>
        public async System.Threading.Tasks.Task<UpsertInstrumentsResponse> UpsertInstrumentsAsync(Dictionary<string, InstrumentDefinition> requestBody, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<UpsertInstrumentsResponse> localVarResponse = await UpsertInstrumentsWithHttpInfoAsync(requestBody, scope, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// UpsertInstruments: Upsert instruments Create or update one or more instruments in the instrument master. An instrument is updated  if it already exists and created if it does not.                In the request, each instrument definition should be keyed by a unique correlation ID. This ID is ephemeral  and not stored by LUSID. It serves only to easily identify each instrument in the response.                Note that an instrument must have at least one unique identifier, which is a combination of a type  (such as &#39;Figi&#39;) and a value (such as &#39;BBG000BS1N49&#39;). In addition, a random value is automatically  generated for a LUSID Instrument ID (LUID) unique type by the system. For more information, see  https://support.lusid.com/knowledgebase/article/KA-01862.                The response returns both the collection of successfully created or updated instruments, as well as those  that failed. For each failure, a reason is provided. It is important to check the failed set for  unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The definitions of the instruments to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpsertInstrumentsResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<UpsertInstrumentsResponse>> UpsertInstrumentsWithHttpInfoAsync(Dictionary<string, InstrumentDefinition> requestBody, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling InstrumentsApi->UpsertInstruments");


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

            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }
            localVarRequestOptions.Data = requestBody;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<UpsertInstrumentsResponse>("/api/instruments", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertInstruments", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// UpsertInstrumentsProperties: Upsert instruments properties Create or update one or more properties for particular instruments.                Each instrument property is updated if it exists and created if it does not. For any failures, a reason  is provided.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertInstrumentPropertyRequest">A list of instruments and associated instrument properties to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>UpsertInstrumentPropertiesResponse</returns>
        public UpsertInstrumentPropertiesResponse UpsertInstrumentsProperties(List<UpsertInstrumentPropertyRequest> upsertInstrumentPropertyRequest, string scope = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<UpsertInstrumentPropertiesResponse> localVarResponse = UpsertInstrumentsPropertiesWithHttpInfo(upsertInstrumentPropertyRequest, scope);
            return localVarResponse.Data;
        }

        /// <summary>
        /// UpsertInstrumentsProperties: Upsert instruments properties Create or update one or more properties for particular instruments.                Each instrument property is updated if it exists and created if it does not. For any failures, a reason  is provided.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertInstrumentPropertyRequest">A list of instruments and associated instrument properties to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of UpsertInstrumentPropertiesResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<UpsertInstrumentPropertiesResponse> UpsertInstrumentsPropertiesWithHttpInfo(List<UpsertInstrumentPropertyRequest> upsertInstrumentPropertyRequest, string scope = default(string))
        {
            // verify the required parameter 'upsertInstrumentPropertyRequest' is set
            if (upsertInstrumentPropertyRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'upsertInstrumentPropertyRequest' when calling InstrumentsApi->UpsertInstrumentsProperties");

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

            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }
            localVarRequestOptions.Data = upsertInstrumentPropertyRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request
            var localVarResponse = this.Client.Post<UpsertInstrumentPropertiesResponse>("/api/instruments/$upsertproperties", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertInstrumentsProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// UpsertInstrumentsProperties: Upsert instruments properties Create or update one or more properties for particular instruments.                Each instrument property is updated if it exists and created if it does not. For any failures, a reason  is provided.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertInstrumentPropertyRequest">A list of instruments and associated instrument properties to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpsertInstrumentPropertiesResponse</returns>
        public async System.Threading.Tasks.Task<UpsertInstrumentPropertiesResponse> UpsertInstrumentsPropertiesAsync(List<UpsertInstrumentPropertyRequest> upsertInstrumentPropertyRequest, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<UpsertInstrumentPropertiesResponse> localVarResponse = await UpsertInstrumentsPropertiesWithHttpInfoAsync(upsertInstrumentPropertyRequest, scope, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// UpsertInstrumentsProperties: Upsert instruments properties Create or update one or more properties for particular instruments.                Each instrument property is updated if it exists and created if it does not. For any failures, a reason  is provided.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertInstrumentPropertyRequest">A list of instruments and associated instrument properties to create or update.</param>
        /// <param name="scope">The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpsertInstrumentPropertiesResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<UpsertInstrumentPropertiesResponse>> UpsertInstrumentsPropertiesWithHttpInfoAsync(List<UpsertInstrumentPropertyRequest> upsertInstrumentPropertyRequest, string scope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'upsertInstrumentPropertyRequest' is set
            if (upsertInstrumentPropertyRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'upsertInstrumentPropertyRequest' when calling InstrumentsApi->UpsertInstrumentsProperties");


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

            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }
            localVarRequestOptions.Data = upsertInstrumentPropertyRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4245");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<UpsertInstrumentPropertiesResponse>("/api/instruments/$upsertproperties", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertInstrumentsProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}