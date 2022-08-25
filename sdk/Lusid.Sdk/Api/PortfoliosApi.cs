/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-10\">-10</a>|Server Configuration Error|  | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"102\">102</a>|Version Not Found|  | | <a name=\"103\">103</a>|Api Rate Limit Violation|  | | <a name=\"104\">104</a>|Instrument Not Found|  | | <a name=\"105\">105</a>|Property Not Found|  | | <a name=\"106\">106</a>|Portfolio Recursion Depth|  | | <a name=\"108\">108</a>|Group Not Found|  | | <a name=\"109\">109</a>|Portfolio Not Found|  | | <a name=\"110\">110</a>|Property Schema Not Found|  | | <a name=\"111\">111</a>|Portfolio Ancestry Not Found|  | | <a name=\"112\">112</a>|Portfolio With Id Already Exists|  | | <a name=\"113\">113</a>|Orphaned Portfolio|  | | <a name=\"119\">119</a>|Missing Base Claims|  | | <a name=\"121\">121</a>|Property Not Defined|  | | <a name=\"122\">122</a>|Cannot Delete System Property|  | | <a name=\"123\">123</a>|Cannot Modify Immutable Property Field|  | | <a name=\"124\">124</a>|Property Already Exists|  | | <a name=\"125\">125</a>|Invalid Property Life Time|  | | <a name=\"126\">126</a>|Property Constraint Style Excludes Properties|  | | <a name=\"127\">127</a>|Cannot Modify Default Data Type|  | | <a name=\"128\">128</a>|Group Already Exists|  | | <a name=\"129\">129</a>|No Such Data Type|  | | <a name=\"130\">130</a>|Undefined Value For Data Type|  | | <a name=\"131\">131</a>|Unsupported Value Type Defined On Data Type|  | | <a name=\"132\">132</a>|Validation Error|  | | <a name=\"133\">133</a>|Loop Detected In Group Hierarchy|  | | <a name=\"134\">134</a>|Undefined Acceptable Values|  | | <a name=\"135\">135</a>|Sub Group Already Exists|  | | <a name=\"138\">138</a>|Price Source Not Found|  | | <a name=\"139\">139</a>|Analytic Store Not Found|  | | <a name=\"141\">141</a>|Analytic Store Already Exists|  | | <a name=\"143\">143</a>|Client Instrument Already Exists|  | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"147\">147</a>|Results Not Found|  | | <a name=\"148\">148</a>|Order Field Not In Result Set|  | | <a name=\"149\">149</a>|Operation Failed|  | | <a name=\"150\">150</a>|Elastic Search Error|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"153\">153</a>|Command Processing Failure|  | | <a name=\"154\">154</a>|Entity State Construction Failure|  | | <a name=\"155\">155</a>|Entity Timeline Does Not Exist|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"158\">158</a>|Event Publish Unknown|  | | <a name=\"159\">159</a>|Event Query Failure|  | | <a name=\"160\">160</a>|Blob Did Not Exist|  | | <a name=\"162\">162</a>|Sub System Request Failure|  | | <a name=\"163\">163</a>|Sub System Configuration Failure|  | | <a name=\"165\">165</a>|Failed To Delete|  | | <a name=\"166\">166</a>|Upsert Client Instrument Failure|  | | <a name=\"167\">167</a>|Illegal As At Interval|  | | <a name=\"168\">168</a>|Illegal Bitemporal Query|  | | <a name=\"169\">169</a>|Invalid Alternate Id|  | | <a name=\"170\">170</a>|Cannot Add Source Portfolio Property Explicitly|  | | <a name=\"171\">171</a>|Entity Already Exists In Group|  | | <a name=\"173\">173</a>|Entity With Id Already Exists|  | | <a name=\"174\">174</a>|Derived Portfolio Details Do Not Exist|  | | <a name=\"175\">175</a>|Entity Not In Group|  | | <a name=\"176\">176</a>|Portfolio With Name Already Exists|  | | <a name=\"177\">177</a>|Invalid Transactions|  | | <a name=\"178\">178</a>|Reference Portfolio Not Found|  | | <a name=\"179\">179</a>|Duplicate Id|  | | <a name=\"180\">180</a>|Command Retrieval Failure|  | | <a name=\"181\">181</a>|Data Filter Application Failure|  | | <a name=\"182\">182</a>|Search Failed|  | | <a name=\"183\">183</a>|Movements Engine Configuration Key Failure|  | | <a name=\"184\">184</a>|Fx Rate Source Not Found|  | | <a name=\"185\">185</a>|Accrual Source Not Found|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"188\">188</a>|Invalid Request Headers|  | | <a name=\"189\">189</a>|Price Not Found|  | | <a name=\"190\">190</a>|Invalid Sub Holding Keys Provided|  | | <a name=\"191\">191</a>|Duplicate Sub Holding Keys Provided|  | | <a name=\"192\">192</a>|Cut Definition Not Found|  | | <a name=\"193\">193</a>|Cut Definition Invalid|  | | <a name=\"194\">194</a>|Time Variant Property Deletion Date Unspecified|  | | <a name=\"195\">195</a>|Perpetual Property Deletion Date Specified|  | | <a name=\"196\">196</a>|Time Variant Property Upsert Date Unspecified|  | | <a name=\"197\">197</a>|Perpetual Property Upsert Date Specified|  | | <a name=\"200\">200</a>|Invalid Unit For Data Type|  | | <a name=\"201\">201</a>|Invalid Type For Data Type|  | | <a name=\"202\">202</a>|Invalid Value For Data Type|  | | <a name=\"203\">203</a>|Unit Not Defined For Data Type|  | | <a name=\"204\">204</a>|Units Not Supported On Data Type|  | | <a name=\"205\">205</a>|Cannot Specify Units On Data Type|  | | <a name=\"206\">206</a>|Unit Schema Inconsistent With Data Type|  | | <a name=\"207\">207</a>|Unit Definition Not Specified|  | | <a name=\"208\">208</a>|Duplicate Unit Definitions Specified|  | | <a name=\"209\">209</a>|Invalid Units Definition|  | | <a name=\"210\">210</a>|Invalid Instrument Identifier Unit|  | | <a name=\"211\">211</a>|Holdings Adjustment Does Not Exist|  | | <a name=\"212\">212</a>|Could Not Build Excel Url|  | | <a name=\"213\">213</a>|Could Not Get Excel Version|  | | <a name=\"214\">214</a>|Instrument By Code Not Found|  | | <a name=\"215\">215</a>|Entity Schema Does Not Exist|  | | <a name=\"216\">216</a>|Feature Not Supported On Portfolio Type|  | | <a name=\"217\">217</a>|Quote Not Found|  | | <a name=\"218\">218</a>|Invalid Quote Identifier|  | | <a name=\"219\">219</a>|Invalid Metric For Data Type|  | | <a name=\"220\">220</a>|Invalid Instrument Definition|  | | <a name=\"221\">221</a>|Instrument Upsert Failure|  | | <a name=\"222\">222</a>|Reference Portfolio Request Not Supported|  | | <a name=\"223\">223</a>|Transaction Portfolio Request Not Supported|  | | <a name=\"224\">224</a>|Invalid Property Value Assignment|  | | <a name=\"230\">230</a>|Transaction Type Not Found|  | | <a name=\"231\">231</a>|Transaction Type Duplication|  | | <a name=\"232\">232</a>|Portfolio Does Not Exist At Given Date|  | | <a name=\"233\">233</a>|Query Parser Failure|  | | <a name=\"234\">234</a>|Duplicate Constituent|  | | <a name=\"235\">235</a>|Unresolved Instrument Constituent|  | | <a name=\"236\">236</a>|Unresolved Instrument In Transition|  | | <a name=\"237\">237</a>|Missing Side Definitions|  | | <a name=\"299\">299</a>|Invalid Recipe|  | | <a name=\"300\">300</a>|Missing Recipe|  | | <a name=\"301\">301</a>|Dependencies|  | | <a name=\"304\">304</a>|Portfolio Preprocess Failure|  | | <a name=\"310\">310</a>|Valuation Engine Failure|  | | <a name=\"311\">311</a>|Task Factory Failure|  | | <a name=\"312\">312</a>|Task Evaluation Failure|  | | <a name=\"313\">313</a>|Task Generation Failure|  | | <a name=\"314\">314</a>|Engine Configuration Failure|  | | <a name=\"315\">315</a>|Model Specification Failure|  | | <a name=\"320\">320</a>|Market Data Key Failure|  | | <a name=\"321\">321</a>|Market Resolver Failure|  | | <a name=\"322\">322</a>|Market Data Failure|  | | <a name=\"330\">330</a>|Curve Failure|  | | <a name=\"331\">331</a>|Volatility Surface Failure|  | | <a name=\"332\">332</a>|Volatility Cube Failure|  | | <a name=\"350\">350</a>|Instrument Failure|  | | <a name=\"351\">351</a>|Cash Flows Failure|  | | <a name=\"352\">352</a>|Reference Data Failure|  | | <a name=\"360\">360</a>|Aggregation Failure|  | | <a name=\"361\">361</a>|Aggregation Measure Failure|  | | <a name=\"370\">370</a>|Result Retrieval Failure|  | | <a name=\"371\">371</a>|Result Processing Failure|  | | <a name=\"372\">372</a>|Vendor Result Processing Failure|  | | <a name=\"373\">373</a>|Vendor Result Mapping Failure|  | | <a name=\"374\">374</a>|Vendor Library Unauthorised|  | | <a name=\"375\">375</a>|Vendor Connectivity Error|  | | <a name=\"376\">376</a>|Vendor Interface Error|  | | <a name=\"377\">377</a>|Vendor Pricing Failure|  | | <a name=\"378\">378</a>|Vendor Translation Failure|  | | <a name=\"379\">379</a>|Vendor Key Mapping Failure|  | | <a name=\"380\">380</a>|Vendor Reflection Failure|  | | <a name=\"381\">381</a>|Vendor Process Failure|  | | <a name=\"382\">382</a>|Vendor System Failure|  | | <a name=\"390\">390</a>|Attempt To Upsert Duplicate Quotes|  | | <a name=\"391\">391</a>|Corporate Action Source Does Not Exist|  | | <a name=\"392\">392</a>|Corporate Action Source Already Exists|  | | <a name=\"393\">393</a>|Instrument Identifier Already In Use|  | | <a name=\"394\">394</a>|Properties Not Found|  | | <a name=\"395\">395</a>|Batch Operation Aborted|  | | <a name=\"400\">400</a>|Invalid Iso4217 Currency Code|  | | <a name=\"401\">401</a>|Cannot Assign Instrument Identifier To Currency|  | | <a name=\"402\">402</a>|Cannot Assign Currency Identifier To Non Currency|  | | <a name=\"403\">403</a>|Currency Instrument Cannot Be Deleted|  | | <a name=\"404\">404</a>|Currency Instrument Cannot Have Economic Definition|  | | <a name=\"405\">405</a>|Currency Instrument Cannot Have Lookthrough Portfolio|  | | <a name=\"406\">406</a>|Cannot Create Currency Instrument With Multiple Identifiers|  | | <a name=\"407\">407</a>|Specified Currency Is Undefined|  | | <a name=\"410\">410</a>|Index Does Not Exist|  | | <a name=\"411\">411</a>|Sort Field Does Not Exist|  | | <a name=\"413\">413</a>|Negative Pagination Parameters|  | | <a name=\"414\">414</a>|Invalid Search Syntax|  | | <a name=\"415\">415</a>|Filter Execution Timeout|  | | <a name=\"420\">420</a>|Side Definition Inconsistent|  | | <a name=\"450\">450</a>|Invalid Quote Access Metadata Rule|  | | <a name=\"451\">451</a>|Access Metadata Not Found|  | | <a name=\"452\">452</a>|Invalid Access Metadata Identifier|  | | <a name=\"460\">460</a>|Standard Resource Not Found|  | | <a name=\"461\">461</a>|Standard Resource Conflict|  | | <a name=\"462\">462</a>|Calendar Not Found|  | | <a name=\"463\">463</a>|Date In A Calendar Not Found|  | | <a name=\"464\">464</a>|Invalid Date Source Data|  | | <a name=\"465\">465</a>|Invalid Timezone|  | | <a name=\"601\">601</a>|Person Identifier Already In Use|  | | <a name=\"602\">602</a>|Person Not Found|  | | <a name=\"603\">603</a>|Cannot Set Identifier|  | | <a name=\"617\">617</a>|Invalid Recipe Specification In Request|  | | <a name=\"618\">618</a>|Inline Recipe Deserialisation Failure|  | | <a name=\"619\">619</a>|Identifier Types Not Set For Entity|  | | <a name=\"620\">620</a>|Cannot Delete All Client Defined Identifiers|  | | <a name=\"650\">650</a>|The Order requested was not found.|  | | <a name=\"654\">654</a>|The Allocation requested was not found.|  | | <a name=\"655\">655</a>|Cannot build the fx forward target with the given holdings.|  | | <a name=\"656\">656</a>|Group does not contain expected entities.|  | | <a name=\"665\">665</a>|Destination directory not found|  | | <a name=\"667\">667</a>|Relation definition already exists|  | | <a name=\"672\">672</a>|Could not retrieve file contents|  | | <a name=\"673\">673</a>|Missing entitlements for entities in Group|  | | <a name=\"674\">674</a>|Next Best Action not found|  | | <a name=\"676\">676</a>|Relation definition not defined|  | | <a name=\"677\">677</a>|Invalid entity identifier for relation|  | | <a name=\"681\">681</a>|Sorting by specified field not supported|One or more of the provided fields to order by were either invalid or not supported. | | <a name=\"682\">682</a>|Too many fields to sort by|The number of fields to sort the data by exceeds the number allowed by the endpoint | | <a name=\"684\">684</a>|Sequence Not Found|  | | <a name=\"685\">685</a>|Sequence Already Exists|  | | <a name=\"686\">686</a>|Non-cycling sequence has been exhausted|  | | <a name=\"687\">687</a>|Legal Entity Identifier Already In Use|  | | <a name=\"688\">688</a>|Legal Entity Not Found|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"690\">690</a>|Property Type Is Not Supported|  | | <a name=\"691\">691</a>|Multiple Tax-lots For Currency Type Is Not Supported|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"693\">693</a>|Entity type is not supported for Relationship|  | | <a name=\"694\">694</a>|Relationship Validation Failure|  | | <a name=\"695\">695</a>|Relationship Not Found|  | | <a name=\"697\">697</a>|Derived Property Formula No Longer Valid|  | | <a name=\"698\">698</a>|Story is not available|  | | <a name=\"703\">703</a>|Corporate Action Does Not Exist|  | | <a name=\"720\">720</a>|The provided sort and filter combination is not valid|  | | <a name=\"721\">721</a>|A2B generation failed|  | | <a name=\"722\">722</a>|Aggregated Return Calculation Failure|  | | <a name=\"723\">723</a>|Custom Entity Definition Identifier Already In Use|  | | <a name=\"724\">724</a>|Custom Entity Definition Not Found|  | | <a name=\"725\">725</a>|The Placement requested was not found.|  | | <a name=\"726\">726</a>|The Execution requested was not found.|  | | <a name=\"727\">727</a>|The Block requested was not found.|  | | <a name=\"728\">728</a>|The Participation requested was not found.|  | | <a name=\"729\">729</a>|The Package requested was not found.|  | | <a name=\"730\">730</a>|The OrderInstruction requested was not found.|  | | <a name=\"732\">732</a>|Custom Entity not found.|  | | <a name=\"733\">733</a>|Custom Entity Identifier already in use.|  | | <a name=\"735\">735</a>|Calculation Failed.|  | | <a name=\"736\">736</a>|An expected key on HttpResponse is missing.|  | | <a name=\"737\">737</a>|A required fee detail is missing.|  | | <a name=\"738\">738</a>|Zero rows were returned from Luminesce|  | | <a name=\"739\">739</a>|Provided Weekend Mask was invalid|  | | <a name=\"742\">742</a>|Custom Entity fields do not match the definition|  | | <a name=\"746\">746</a>|The provided sequence is not valid.|  | | <a name=\"751\">751</a>|The type of the Custom Entity is different than the type provided in the definition.|  | | <a name=\"752\">752</a>|Luminesce process returned an error.|  | | <a name=\"753\">753</a>|File name or content incompatible with operation.|  | | <a name=\"755\">755</a>|Schema of response from Drive is not as expected.|  | | <a name=\"757\">757</a>|Schema of response from Luminesce is not as expected.|  | | <a name=\"758\">758</a>|Luminesce timed out.|  | | <a name=\"763\">763</a>|Invalid Lusid Entity Identifier Unit|  | | <a name=\"768\">768</a>|Fee rule not found.|  | | <a name=\"769\">769</a>|Cannot update the base currency of a portfolio with transactions loaded|  | | <a name=\"771\">771</a>|Transaction configuration source not found|  | | <a name=\"774\">774</a>|Compliance rule not found.|  | | <a name=\"775\">775</a>|Fund accounting document cannot be processed.|  | | <a name=\"778\">778</a>|Unable to look up FX rate from trade ccy to portfolio ccy for some of the trades.|  | | <a name=\"782\">782</a>|The Property definition dataType is not matching the derivation formula dataType|  | | <a name=\"783\">783</a>|The Property definition domain is not supported for derived properties|  | | <a name=\"788\">788</a>|Compliance run not found failure.|  | | <a name=\"790\">790</a>|Custom Entity has missing or invalid identifiers|  | | <a name=\"791\">791</a>|Custom Entity definition already exists|  | | <a name=\"792\">792</a>|Compliance PropertyKey is missing.|  | | <a name=\"793\">793</a>|Compliance Criteria Value for matching is missing.|  | | <a name=\"800\">800</a>|Can not upsert an instrument event of this type.|  | | <a name=\"801\">801</a>|The instrument event does not exist.|  | | <a name=\"802\">802</a>|The Instrument event is missing salient information.|  | | <a name=\"803\">803</a>|The Instrument event could not be processed.|  | | <a name=\"804\">804</a>|Some data requested does not follow the order graph assumptions.|  | 
 *
 * The version of the OpenAPI document: 0.11.4730
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
    public interface IPortfoliosApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EARLY ACCESS] DeleteKeyFromPortfolioAccessMetadata: Delete a Portfolio Access Metadata Rule
        /// </summary>
        /// <remarks>
        /// Delete the Portfolio Access Metadata Rule that exactly matches the provided identifier parts
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Quote Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">The metadataKey identifying the access metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeleteKeyFromPortfolioAccessMetadata(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] DeleteKeyFromPortfolioAccessMetadata: Delete a Portfolio Access Metadata Rule
        /// </summary>
        /// <remarks>
        /// Delete the Portfolio Access Metadata Rule that exactly matches the provided identifier parts
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Quote Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">The metadataKey identifying the access metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeleteKeyFromPortfolioAccessMetadataWithHttpInfo(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));
        /// <summary>
        /// DeletePortfolio: Delete portfolio
        /// </summary>
        /// <remarks>
        /// Delete a particular portfolio.                The deletion will take effect from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime, as per the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePortfolio(string scope, string code);

        /// <summary>
        /// DeletePortfolio: Delete portfolio
        /// </summary>
        /// <remarks>
        /// Delete a particular portfolio.                The deletion will take effect from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime, as per the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePortfolioWithHttpInfo(string scope, string code);
        /// <summary>
        /// DeletePortfolioProperties: Delete portfolio properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a particular portfolio. If the properties are time-variant then an effective datetime from which  to delete properties must be specified. If the properties are perpetual then it is invalid to specify an effective datetime for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These must take the format              {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. Each property must be from the &#39;Portfolio&#39; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePortfolioProperties(string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));

        /// <summary>
        /// DeletePortfolioProperties: Delete portfolio properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a particular portfolio. If the properties are time-variant then an effective datetime from which  to delete properties must be specified. If the properties are perpetual then it is invalid to specify an effective datetime for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These must take the format              {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. Each property must be from the &#39;Portfolio&#39; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePortfolioPropertiesWithHttpInfo(string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));
        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioReturns: Delete Returns
        /// </summary>
        /// <remarks>
        /// Cancel one or more Returns which exist into the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to delete the Returns.</param>
        /// <param name="toEffectiveAt">The end date from which to delete the Returns.</param>
        /// <param name="period">The Period (Daily or Monthly) of the Returns to be deleted. Defaults to Daily. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePortfolioReturns(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, string period = default(string));

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioReturns: Delete Returns
        /// </summary>
        /// <remarks>
        /// Cancel one or more Returns which exist into the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to delete the Returns.</param>
        /// <param name="toEffectiveAt">The end date from which to delete the Returns.</param>
        /// <param name="period">The Period (Daily or Monthly) of the Returns to be deleted. Defaults to Daily. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePortfolioReturnsWithHttpInfo(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, string period = default(string));
        /// <summary>
        /// GetPortfolio: Get portfolio
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a particular portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to returning the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto the portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <returns>Portfolio</returns>
        Portfolio GetPortfolio(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>));

        /// <summary>
        /// GetPortfolio: Get portfolio
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a particular portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to returning the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto the portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        ApiResponse<Portfolio> GetPortfolioWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioAggregatedReturns: Aggregated Returns
        /// </summary>
        /// <remarks>
        /// Aggregate Returns which are on the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="aggregatedReturnsRequest">The request used in the AggregatedReturns.</param>
        /// <param name="fromEffectiveAt">The start date from which to calculate the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date for which to calculate the Returns. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <returns>AggregatedReturnsResponse</returns>
        AggregatedReturnsResponse GetPortfolioAggregatedReturns(string scope, string code, AggregatedReturnsRequest aggregatedReturnsRequest, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioAggregatedReturns: Aggregated Returns
        /// </summary>
        /// <remarks>
        /// Aggregate Returns which are on the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="aggregatedReturnsRequest">The request used in the AggregatedReturns.</param>
        /// <param name="fromEffectiveAt">The start date from which to calculate the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date for which to calculate the Returns. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <returns>ApiResponse of AggregatedReturnsResponse</returns>
        ApiResponse<AggregatedReturnsResponse> GetPortfolioAggregatedReturnsWithHttpInfo(string scope, string code, AggregatedReturnsRequest aggregatedReturnsRequest, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// GetPortfolioCommands: Get portfolio commands
        /// </summary>
        /// <remarks>
        /// Get all the commands that modified a particular portfolio, including any input transactions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the User ID, specify \&quot;userId.id eq &#39;string&#39;\&quot;.              For more information about filtering, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing commands; this value is returned from the previous call. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 500 if not specified. (optional)</param>
        /// <returns>ResourceListOfProcessedCommand</returns>
        ResourceListOfProcessedCommand GetPortfolioCommands(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?));

        /// <summary>
        /// GetPortfolioCommands: Get portfolio commands
        /// </summary>
        /// <remarks>
        /// Get all the commands that modified a particular portfolio, including any input transactions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the User ID, specify \&quot;userId.id eq &#39;string&#39;\&quot;.              For more information about filtering, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing commands; this value is returned from the previous call. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 500 if not specified. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfProcessedCommand</returns>
        ApiResponse<ResourceListOfProcessedCommand> GetPortfolioCommandsWithHttpInfo(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioMetadata: Get access metadata rules for a portfolio
        /// </summary>
        /// <remarks>
        /// Pass the scope and portfolio code parameters to retrieve the AccessMetadata associated with a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata rule. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <returns>Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        Dictionary<string, List<AccessMetadataValue>> GetPortfolioMetadata(string scope, string code, string effectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioMetadata: Get access metadata rules for a portfolio
        /// </summary>
        /// <remarks>
        /// Pass the scope and portfolio code parameters to retrieve the AccessMetadata associated with a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata rule. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        ApiResponse<Dictionary<string, List<AccessMetadataValue>>> GetPortfolioMetadataWithHttpInfo(string scope, string code, string effectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// GetPortfolioProperties: Get portfolio properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a particular portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to returning the latest version of each property if not specified. (optional)</param>
        /// <returns>PortfolioProperties</returns>
        PortfolioProperties GetPortfolioProperties(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// GetPortfolioProperties: Get portfolio properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a particular portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to returning the latest version of each property if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioProperties</returns>
        ApiResponse<PortfolioProperties> GetPortfolioPropertiesWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioRelationships: Get portfolio relationships
        /// </summary>
        /// <remarks>
        /// Get relationships for a particular portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to returning the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relationships. Provide a null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <returns>ResourceListOfRelationship</returns>
        ResourceListOfRelationship GetPortfolioRelationships(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioRelationships: Get portfolio relationships
        /// </summary>
        /// <remarks>
        /// Get relationships for a particular portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to returning the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relationships. Provide a null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfRelationship</returns>
        ApiResponse<ResourceListOfRelationship> GetPortfolioRelationshipsWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioReturns: Get Returns
        /// </summary>
        /// <remarks>
        /// Get Returns which are on the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to get the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date from which to get the Returns. (optional)</param>
        /// <param name="period">Show the Returns on a Daily or Monthly period. Defaults to Daily. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <returns>ResourceListOfPerformanceReturn</returns>
        ResourceListOfPerformanceReturn GetPortfolioReturns(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), string period = default(string), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioReturns: Get Returns
        /// </summary>
        /// <remarks>
        /// Get Returns which are on the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to get the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date from which to get the Returns. (optional)</param>
        /// <param name="period">Show the Returns on a Daily or Monthly period. Defaults to Daily. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPerformanceReturn</returns>
        ApiResponse<ResourceListOfPerformanceReturn> GetPortfolioReturnsWithHttpInfo(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), string period = default(string), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] GetPortfoliosAccessMetadataByKey: Get an entry identified by a metadataKey in the access metadata object
        /// </summary>
        /// <remarks>
        /// Get a specific portfolio access metadata rule by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="metadataKey">Key of the metadata to retrieve</param>
        /// <param name="effectiveAt">The effective date of the rule (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <returns>ICollection&lt;AccessMetadataValue&gt;</returns>
        ICollection<AccessMetadataValue> GetPortfoliosAccessMetadataByKey(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] GetPortfoliosAccessMetadataByKey: Get an entry identified by a metadataKey in the access metadata object
        /// </summary>
        /// <remarks>
        /// Get a specific portfolio access metadata rule by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="metadataKey">Key of the metadata to retrieve</param>
        /// <param name="effectiveAt">The effective date of the rule (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;AccessMetadataValue&gt;</returns>
        ApiResponse<ICollection<AccessMetadataValue>> GetPortfoliosAccessMetadataByKeyWithHttpInfo(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// ListPortfolios: List portfolios
        /// </summary>
        /// <remarks>
        /// List all the portfolios matching particular criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the transaction type, specify \&quot;type eq &#39;Transaction&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet. For example, to see which              portfolios have holdings in instruments with a LusidInstrumentId (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;,              specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <returns>ResourceListOfPortfolio</returns>
        ResourceListOfPortfolio ListPortfolios(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), string query = default(string), List<string> propertyKeys = default(List<string>));

        /// <summary>
        /// ListPortfolios: List portfolios
        /// </summary>
        /// <remarks>
        /// List all the portfolios matching particular criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the transaction type, specify \&quot;type eq &#39;Transaction&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet. For example, to see which              portfolios have holdings in instruments with a LusidInstrumentId (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;,              specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolio</returns>
        ApiResponse<ResourceListOfPortfolio> ListPortfoliosWithHttpInfo(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), string query = default(string), List<string> propertyKeys = default(List<string>));
        /// <summary>
        /// ListPortfoliosForScope: List portfolios for scope
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a particular scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope whose portfolios to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <returns>ResourceListOfPortfolio</returns>
        ResourceListOfPortfolio ListPortfoliosForScope(string scope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>));

        /// <summary>
        /// ListPortfoliosForScope: List portfolios for scope
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a particular scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope whose portfolios to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolio</returns>
        ApiResponse<ResourceListOfPortfolio> ListPortfoliosForScopeWithHttpInfo(string scope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>));
        /// <summary>
        /// UpdatePortfolio: Update portfolio
        /// </summary>
        /// <remarks>
        /// Update the definition of a particular portfolio.                Note that not all elements of a portfolio definition are  modifiable due to the potential implications for data already stored.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="updatePortfolioRequest">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current               LUSID system datetime if not specified. (optional)</param>
        /// <returns>Portfolio</returns>
        Portfolio UpdatePortfolio(string scope, string code, UpdatePortfolioRequest updatePortfolioRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));

        /// <summary>
        /// UpdatePortfolio: Update portfolio
        /// </summary>
        /// <remarks>
        /// Update the definition of a particular portfolio.                Note that not all elements of a portfolio definition are  modifiable due to the potential implications for data already stored.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="updatePortfolioRequest">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current               LUSID system datetime if not specified. (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        ApiResponse<Portfolio> UpdatePortfolioWithHttpInfo(string scope, string code, UpdatePortfolioRequest updatePortfolioRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));
        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioAccessMetadata: Upsert a Portfolio Access Metadata Rule associated with specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Portfolio Access Metadata Rule in a single scope. An item will be updated if it already exists  and inserted if it does not.    The response will return the successfully updated or inserted Portfolio Access Metadata Rule or failure message if unsuccessful    It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exists with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to use when updating or inserting the Portfolio Access Metadata Rule.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">Key of the access metadata to upsert</param>
        /// <param name="upsertPortfolioAccessMetadataRequest">The Portfolio Access Metadata Rule to update or insert</param>
        /// <param name="effectiveAt">The date this rule will effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>ResourceListOfAccessMetadataValueOf</returns>
        ResourceListOfAccessMetadataValueOf UpsertPortfolioAccessMetadata(string scope, string code, string metadataKey, UpsertPortfolioAccessMetadataRequest upsertPortfolioAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioAccessMetadata: Upsert a Portfolio Access Metadata Rule associated with specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Portfolio Access Metadata Rule in a single scope. An item will be updated if it already exists  and inserted if it does not.    The response will return the successfully updated or inserted Portfolio Access Metadata Rule or failure message if unsuccessful    It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exists with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to use when updating or inserting the Portfolio Access Metadata Rule.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">Key of the access metadata to upsert</param>
        /// <param name="upsertPortfolioAccessMetadataRequest">The Portfolio Access Metadata Rule to update or insert</param>
        /// <param name="effectiveAt">The date this rule will effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of ResourceListOfAccessMetadataValueOf</returns>
        ApiResponse<ResourceListOfAccessMetadataValueOf> UpsertPortfolioAccessMetadataWithHttpInfo(string scope, string code, string metadataKey, UpsertPortfolioAccessMetadataRequest upsertPortfolioAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));
        /// <summary>
        /// UpsertPortfolioProperties: Upsert portfolio properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more properties for a particular portfolio. A property is updated if it  already exists and created if it does not. All properties must be from the &#39;Portfolio&#39; domain.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which it is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="requestBody">The properties to be created or updated. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code}, for example               &#39;Portfolio/Manager/Id&#39;.</param>
        /// <returns>PortfolioProperties</returns>
        PortfolioProperties UpsertPortfolioProperties(string scope, string code, Dictionary<string, Property> requestBody);

        /// <summary>
        /// UpsertPortfolioProperties: Upsert portfolio properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more properties for a particular portfolio. A property is updated if it  already exists and created if it does not. All properties must be from the &#39;Portfolio&#39; domain.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which it is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="requestBody">The properties to be created or updated. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code}, for example               &#39;Portfolio/Manager/Id&#39;.</param>
        /// <returns>ApiResponse of PortfolioProperties</returns>
        ApiResponse<PortfolioProperties> UpsertPortfolioPropertiesWithHttpInfo(string scope, string code, Dictionary<string, Property> requestBody);
        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioReturns: Upsert Returns
        /// </summary>
        /// <remarks>
        /// Update or insert returns into the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="performanceReturn">This contains the Returns which need to be upsert.</param>
        /// <returns>UpsertReturnsResponse</returns>
        UpsertReturnsResponse UpsertPortfolioReturns(string scope, string code, string returnScope, string returnCode, List<PerformanceReturn> performanceReturn);

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioReturns: Upsert Returns
        /// </summary>
        /// <remarks>
        /// Update or insert returns into the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="performanceReturn">This contains the Returns which need to be upsert.</param>
        /// <returns>ApiResponse of UpsertReturnsResponse</returns>
        ApiResponse<UpsertReturnsResponse> UpsertPortfolioReturnsWithHttpInfo(string scope, string code, string returnScope, string returnCode, List<PerformanceReturn> performanceReturn);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPortfoliosApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] DeleteKeyFromPortfolioAccessMetadata: Delete a Portfolio Access Metadata Rule
        /// </summary>
        /// <remarks>
        /// Delete the Portfolio Access Metadata Rule that exactly matches the provided identifier parts
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Quote Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">The metadataKey identifying the access metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeleteKeyFromPortfolioAccessMetadataAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeleteKeyFromPortfolioAccessMetadata: Delete a Portfolio Access Metadata Rule
        /// </summary>
        /// <remarks>
        /// Delete the Portfolio Access Metadata Rule that exactly matches the provided identifier parts
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Quote Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">The metadataKey identifying the access metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeleteKeyFromPortfolioAccessMetadataWithHttpInfoAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// DeletePortfolio: Delete portfolio
        /// </summary>
        /// <remarks>
        /// Delete a particular portfolio.                The deletion will take effect from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime, as per the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioAsync(string scope, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// DeletePortfolio: Delete portfolio
        /// </summary>
        /// <remarks>
        /// Delete a particular portfolio.                The deletion will take effect from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime, as per the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePortfolioWithHttpInfoAsync(string scope, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// DeletePortfolioProperties: Delete portfolio properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a particular portfolio. If the properties are time-variant then an effective datetime from which  to delete properties must be specified. If the properties are perpetual then it is invalid to specify an effective datetime for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These must take the format              {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. Each property must be from the &#39;Portfolio&#39; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioPropertiesAsync(string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// DeletePortfolioProperties: Delete portfolio properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a particular portfolio. If the properties are time-variant then an effective datetime from which  to delete properties must be specified. If the properties are perpetual then it is invalid to specify an effective datetime for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These must take the format              {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. Each property must be from the &#39;Portfolio&#39; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePortfolioPropertiesWithHttpInfoAsync(string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioReturns: Delete Returns
        /// </summary>
        /// <remarks>
        /// Cancel one or more Returns which exist into the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to delete the Returns.</param>
        /// <param name="toEffectiveAt">The end date from which to delete the Returns.</param>
        /// <param name="period">The Period (Daily or Monthly) of the Returns to be deleted. Defaults to Daily. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioReturnsAsync(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, string period = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioReturns: Delete Returns
        /// </summary>
        /// <remarks>
        /// Cancel one or more Returns which exist into the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to delete the Returns.</param>
        /// <param name="toEffectiveAt">The end date from which to delete the Returns.</param>
        /// <param name="period">The Period (Daily or Monthly) of the Returns to be deleted. Defaults to Daily. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePortfolioReturnsWithHttpInfoAsync(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, string period = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetPortfolio: Get portfolio
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a particular portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to returning the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto the portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Portfolio</returns>
        System.Threading.Tasks.Task<Portfolio> GetPortfolioAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetPortfolio: Get portfolio
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a particular portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to returning the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto the portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<Portfolio>> GetPortfolioWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioAggregatedReturns: Aggregated Returns
        /// </summary>
        /// <remarks>
        /// Aggregate Returns which are on the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="aggregatedReturnsRequest">The request used in the AggregatedReturns.</param>
        /// <param name="fromEffectiveAt">The start date from which to calculate the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date for which to calculate the Returns. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AggregatedReturnsResponse</returns>
        System.Threading.Tasks.Task<AggregatedReturnsResponse> GetPortfolioAggregatedReturnsAsync(string scope, string code, AggregatedReturnsRequest aggregatedReturnsRequest, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioAggregatedReturns: Aggregated Returns
        /// </summary>
        /// <remarks>
        /// Aggregate Returns which are on the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="aggregatedReturnsRequest">The request used in the AggregatedReturns.</param>
        /// <param name="fromEffectiveAt">The start date from which to calculate the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date for which to calculate the Returns. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AggregatedReturnsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AggregatedReturnsResponse>> GetPortfolioAggregatedReturnsWithHttpInfoAsync(string scope, string code, AggregatedReturnsRequest aggregatedReturnsRequest, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetPortfolioCommands: Get portfolio commands
        /// </summary>
        /// <remarks>
        /// Get all the commands that modified a particular portfolio, including any input transactions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the User ID, specify \&quot;userId.id eq &#39;string&#39;\&quot;.              For more information about filtering, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing commands; this value is returned from the previous call. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 500 if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfProcessedCommand</returns>
        System.Threading.Tasks.Task<ResourceListOfProcessedCommand> GetPortfolioCommandsAsync(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetPortfolioCommands: Get portfolio commands
        /// </summary>
        /// <remarks>
        /// Get all the commands that modified a particular portfolio, including any input transactions.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the User ID, specify \&quot;userId.id eq &#39;string&#39;\&quot;.              For more information about filtering, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing commands; this value is returned from the previous call. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 500 if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfProcessedCommand)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfProcessedCommand>> GetPortfolioCommandsWithHttpInfoAsync(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioMetadata: Get access metadata rules for a portfolio
        /// </summary>
        /// <remarks>
        /// Pass the scope and portfolio code parameters to retrieve the AccessMetadata associated with a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata rule. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, List<AccessMetadataValue>>> GetPortfolioMetadataAsync(string scope, string code, string effectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioMetadata: Get access metadata rules for a portfolio
        /// </summary>
        /// <remarks>
        /// Pass the scope and portfolio code parameters to retrieve the AccessMetadata associated with a portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata rule. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, List<AccessMetadataValue>>>> GetPortfolioMetadataWithHttpInfoAsync(string scope, string code, string effectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetPortfolioProperties: Get portfolio properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a particular portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to returning the latest version of each property if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioProperties</returns>
        System.Threading.Tasks.Task<PortfolioProperties> GetPortfolioPropertiesAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetPortfolioProperties: Get portfolio properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a particular portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to returning the latest version of each property if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioProperties)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioProperties>> GetPortfolioPropertiesWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioRelationships: Get portfolio relationships
        /// </summary>
        /// <remarks>
        /// Get relationships for a particular portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to returning the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relationships. Provide a null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfRelationship</returns>
        System.Threading.Tasks.Task<ResourceListOfRelationship> GetPortfolioRelationshipsAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioRelationships: Get portfolio relationships
        /// </summary>
        /// <remarks>
        /// Get relationships for a particular portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to returning the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relationships. Provide a null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfRelationship)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfRelationship>> GetPortfolioRelationshipsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioReturns: Get Returns
        /// </summary>
        /// <remarks>
        /// Get Returns which are on the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to get the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date from which to get the Returns. (optional)</param>
        /// <param name="period">Show the Returns on a Daily or Monthly period. Defaults to Daily. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPerformanceReturn</returns>
        System.Threading.Tasks.Task<ResourceListOfPerformanceReturn> GetPortfolioReturnsAsync(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), string period = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioReturns: Get Returns
        /// </summary>
        /// <remarks>
        /// Get Returns which are on the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to get the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date from which to get the Returns. (optional)</param>
        /// <param name="period">Show the Returns on a Daily or Monthly period. Defaults to Daily. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPerformanceReturn)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPerformanceReturn>> GetPortfolioReturnsWithHttpInfoAsync(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), string period = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetPortfoliosAccessMetadataByKey: Get an entry identified by a metadataKey in the access metadata object
        /// </summary>
        /// <remarks>
        /// Get a specific portfolio access metadata rule by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="metadataKey">Key of the metadata to retrieve</param>
        /// <param name="effectiveAt">The effective date of the rule (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;AccessMetadataValue&gt;</returns>
        System.Threading.Tasks.Task<ICollection<AccessMetadataValue>> GetPortfoliosAccessMetadataByKeyAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetPortfoliosAccessMetadataByKey: Get an entry identified by a metadataKey in the access metadata object
        /// </summary>
        /// <remarks>
        /// Get a specific portfolio access metadata rule by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="metadataKey">Key of the metadata to retrieve</param>
        /// <param name="effectiveAt">The effective date of the rule (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;AccessMetadataValue&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<AccessMetadataValue>>> GetPortfoliosAccessMetadataByKeyWithHttpInfoAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// ListPortfolios: List portfolios
        /// </summary>
        /// <remarks>
        /// List all the portfolios matching particular criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the transaction type, specify \&quot;type eq &#39;Transaction&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet. For example, to see which              portfolios have holdings in instruments with a LusidInstrumentId (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;,              specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPortfolio</returns>
        System.Threading.Tasks.Task<ResourceListOfPortfolio> ListPortfoliosAsync(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), string query = default(string), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// ListPortfolios: List portfolios
        /// </summary>
        /// <remarks>
        /// List all the portfolios matching particular criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the transaction type, specify \&quot;type eq &#39;Transaction&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet. For example, to see which              portfolios have holdings in instruments with a LusidInstrumentId (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;,              specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolio>> ListPortfoliosWithHttpInfoAsync(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), string query = default(string), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// ListPortfoliosForScope: List portfolios for scope
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a particular scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope whose portfolios to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPortfolio</returns>
        System.Threading.Tasks.Task<ResourceListOfPortfolio> ListPortfoliosForScopeAsync(string scope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// ListPortfoliosForScope: List portfolios for scope
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a particular scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope whose portfolios to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolio>> ListPortfoliosForScopeWithHttpInfoAsync(string scope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// UpdatePortfolio: Update portfolio
        /// </summary>
        /// <remarks>
        /// Update the definition of a particular portfolio.                Note that not all elements of a portfolio definition are  modifiable due to the potential implications for data already stored.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="updatePortfolioRequest">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current               LUSID system datetime if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Portfolio</returns>
        System.Threading.Tasks.Task<Portfolio> UpdatePortfolioAsync(string scope, string code, UpdatePortfolioRequest updatePortfolioRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// UpdatePortfolio: Update portfolio
        /// </summary>
        /// <remarks>
        /// Update the definition of a particular portfolio.                Note that not all elements of a portfolio definition are  modifiable due to the potential implications for data already stored.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="updatePortfolioRequest">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current               LUSID system datetime if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<Portfolio>> UpdatePortfolioWithHttpInfoAsync(string scope, string code, UpdatePortfolioRequest updatePortfolioRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioAccessMetadata: Upsert a Portfolio Access Metadata Rule associated with specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Portfolio Access Metadata Rule in a single scope. An item will be updated if it already exists  and inserted if it does not.    The response will return the successfully updated or inserted Portfolio Access Metadata Rule or failure message if unsuccessful    It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exists with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to use when updating or inserting the Portfolio Access Metadata Rule.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">Key of the access metadata to upsert</param>
        /// <param name="upsertPortfolioAccessMetadataRequest">The Portfolio Access Metadata Rule to update or insert</param>
        /// <param name="effectiveAt">The date this rule will effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfAccessMetadataValueOf</returns>
        System.Threading.Tasks.Task<ResourceListOfAccessMetadataValueOf> UpsertPortfolioAccessMetadataAsync(string scope, string code, string metadataKey, UpsertPortfolioAccessMetadataRequest upsertPortfolioAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioAccessMetadata: Upsert a Portfolio Access Metadata Rule associated with specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Portfolio Access Metadata Rule in a single scope. An item will be updated if it already exists  and inserted if it does not.    The response will return the successfully updated or inserted Portfolio Access Metadata Rule or failure message if unsuccessful    It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exists with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to use when updating or inserting the Portfolio Access Metadata Rule.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">Key of the access metadata to upsert</param>
        /// <param name="upsertPortfolioAccessMetadataRequest">The Portfolio Access Metadata Rule to update or insert</param>
        /// <param name="effectiveAt">The date this rule will effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfAccessMetadataValueOf)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfAccessMetadataValueOf>> UpsertPortfolioAccessMetadataWithHttpInfoAsync(string scope, string code, string metadataKey, UpsertPortfolioAccessMetadataRequest upsertPortfolioAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// UpsertPortfolioProperties: Upsert portfolio properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more properties for a particular portfolio. A property is updated if it  already exists and created if it does not. All properties must be from the &#39;Portfolio&#39; domain.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which it is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="requestBody">The properties to be created or updated. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code}, for example               &#39;Portfolio/Manager/Id&#39;.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioProperties</returns>
        System.Threading.Tasks.Task<PortfolioProperties> UpsertPortfolioPropertiesAsync(string scope, string code, Dictionary<string, Property> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// UpsertPortfolioProperties: Upsert portfolio properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more properties for a particular portfolio. A property is updated if it  already exists and created if it does not. All properties must be from the &#39;Portfolio&#39; domain.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which it is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="requestBody">The properties to be created or updated. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code}, for example               &#39;Portfolio/Manager/Id&#39;.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioProperties)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioProperties>> UpsertPortfolioPropertiesWithHttpInfoAsync(string scope, string code, Dictionary<string, Property> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioReturns: Upsert Returns
        /// </summary>
        /// <remarks>
        /// Update or insert returns into the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="performanceReturn">This contains the Returns which need to be upsert.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpsertReturnsResponse</returns>
        System.Threading.Tasks.Task<UpsertReturnsResponse> UpsertPortfolioReturnsAsync(string scope, string code, string returnScope, string returnCode, List<PerformanceReturn> performanceReturn, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioReturns: Upsert Returns
        /// </summary>
        /// <remarks>
        /// Update or insert returns into the specified portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="performanceReturn">This contains the Returns which need to be upsert.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpsertReturnsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertReturnsResponse>> UpsertPortfolioReturnsWithHttpInfoAsync(string scope, string code, string returnScope, string returnCode, List<PerformanceReturn> performanceReturn, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPortfoliosApi : IPortfoliosApiSync, IPortfoliosApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PortfoliosApi : IPortfoliosApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfoliosApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PortfoliosApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfoliosApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PortfoliosApi(String basePath)
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
        /// Initializes a new instance of the <see cref="PortfoliosApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PortfoliosApi(Lusid.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfoliosApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PortfoliosApi(Lusid.Sdk.Client.ISynchronousClient client, Lusid.Sdk.Client.IAsynchronousClient asyncClient, Lusid.Sdk.Client.IReadableConfiguration configuration)
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
        /// [EARLY ACCESS] DeleteKeyFromPortfolioAccessMetadata: Delete a Portfolio Access Metadata Rule Delete the Portfolio Access Metadata Rule that exactly matches the provided identifier parts
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Quote Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">The metadataKey identifying the access metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeleteKeyFromPortfolioAccessMetadata(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeleteKeyFromPortfolioAccessMetadataWithHttpInfo(scope, code, metadataKey, effectiveAt, effectiveUntil);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteKeyFromPortfolioAccessMetadata: Delete a Portfolio Access Metadata Rule Delete the Portfolio Access Metadata Rule that exactly matches the provided identifier parts
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Quote Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">The metadataKey identifying the access metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> DeleteKeyFromPortfolioAccessMetadataWithHttpInfo(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->DeleteKeyFromPortfolioAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->DeleteKeyFromPortfolioAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PortfoliosApi->DeleteKeyFromPortfolioAccessMetadata");

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
            localVarRequestOptions.PathParameters.Add("metadataKey", Lusid.Sdk.Client.ClientUtils.ParameterToString(metadataKey)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (effectiveUntil != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveUntil", effectiveUntil));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeletedEntityResponse>("/api/portfolios/{scope}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteKeyFromPortfolioAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteKeyFromPortfolioAccessMetadata: Delete a Portfolio Access Metadata Rule Delete the Portfolio Access Metadata Rule that exactly matches the provided identifier parts
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Quote Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">The metadataKey identifying the access metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeleteKeyFromPortfolioAccessMetadataAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeleteKeyFromPortfolioAccessMetadataWithHttpInfoAsync(scope, code, metadataKey, effectiveAt, effectiveUntil, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteKeyFromPortfolioAccessMetadata: Delete a Portfolio Access Metadata Rule Delete the Portfolio Access Metadata Rule that exactly matches the provided identifier parts
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Quote Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">The metadataKey identifying the access metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeleteKeyFromPortfolioAccessMetadataWithHttpInfoAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->DeleteKeyFromPortfolioAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->DeleteKeyFromPortfolioAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PortfoliosApi->DeleteKeyFromPortfolioAccessMetadata");


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
            localVarRequestOptions.PathParameters.Add("metadataKey", Lusid.Sdk.Client.ClientUtils.ParameterToString(metadataKey)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (effectiveUntil != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveUntil", effectiveUntil));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/portfolios/{scope}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteKeyFromPortfolioAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// DeletePortfolio: Delete portfolio Delete a particular portfolio.                The deletion will take effect from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime, as per the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePortfolio(string scope, string code)
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeletePortfolioWithHttpInfo(scope, code);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DeletePortfolio: Delete portfolio Delete a particular portfolio.                The deletion will take effect from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime, as per the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> DeletePortfolioWithHttpInfo(string scope, string code)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->DeletePortfolio");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->DeletePortfolio");

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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeletedEntityResponse>("/api/portfolios/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePortfolio", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// DeletePortfolio: Delete portfolio Delete a particular portfolio.                The deletion will take effect from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime, as per the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioAsync(string scope, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePortfolioWithHttpInfoAsync(scope, code, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DeletePortfolio: Delete portfolio Delete a particular portfolio.                The deletion will take effect from the portfolio&#39;s creation datetime. This means that the portfolio will no longer exist at any effective datetime, as per the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeletePortfolioWithHttpInfoAsync(string scope, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->DeletePortfolio");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->DeletePortfolio");


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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/portfolios/{scope}/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePortfolio", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// DeletePortfolioProperties: Delete portfolio properties Delete one or more properties from a particular portfolio. If the properties are time-variant then an effective datetime from which  to delete properties must be specified. If the properties are perpetual then it is invalid to specify an effective datetime for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These must take the format              {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. Each property must be from the &#39;Portfolio&#39; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePortfolioProperties(string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeletePortfolioPropertiesWithHttpInfo(scope, code, propertyKeys, effectiveAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DeletePortfolioProperties: Delete portfolio properties Delete one or more properties from a particular portfolio. If the properties are time-variant then an effective datetime from which  to delete properties must be specified. If the properties are perpetual then it is invalid to specify an effective datetime for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These must take the format              {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. Each property must be from the &#39;Portfolio&#39; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> DeletePortfolioPropertiesWithHttpInfo(string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->DeletePortfolioProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->DeletePortfolioProperties");

            // verify the required parameter 'propertyKeys' is set
            if (propertyKeys == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKeys' when calling PortfoliosApi->DeletePortfolioProperties");

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
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeletedEntityResponse>("/api/portfolios/{scope}/{code}/properties", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePortfolioProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// DeletePortfolioProperties: Delete portfolio properties Delete one or more properties from a particular portfolio. If the properties are time-variant then an effective datetime from which  to delete properties must be specified. If the properties are perpetual then it is invalid to specify an effective datetime for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These must take the format              {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. Each property must be from the &#39;Portfolio&#39; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioPropertiesAsync(string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePortfolioPropertiesWithHttpInfoAsync(scope, code, propertyKeys, effectiveAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DeletePortfolioProperties: Delete portfolio properties Delete one or more properties from a particular portfolio. If the properties are time-variant then an effective datetime from which  to delete properties must be specified. If the properties are perpetual then it is invalid to specify an effective datetime for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete. These must take the format              {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. Each property must be from the &#39;Portfolio&#39; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeletePortfolioPropertiesWithHttpInfoAsync(string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->DeletePortfolioProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->DeletePortfolioProperties");

            // verify the required parameter 'propertyKeys' is set
            if (propertyKeys == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKeys' when calling PortfoliosApi->DeletePortfolioProperties");


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
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/portfolios/{scope}/{code}/properties", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePortfolioProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioReturns: Delete Returns Cancel one or more Returns which exist into the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to delete the Returns.</param>
        /// <param name="toEffectiveAt">The end date from which to delete the Returns.</param>
        /// <param name="period">The Period (Daily or Monthly) of the Returns to be deleted. Defaults to Daily. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePortfolioReturns(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, string period = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeletePortfolioReturnsWithHttpInfo(scope, code, returnScope, returnCode, fromEffectiveAt, toEffectiveAt, period);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioReturns: Delete Returns Cancel one or more Returns which exist into the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to delete the Returns.</param>
        /// <param name="toEffectiveAt">The end date from which to delete the Returns.</param>
        /// <param name="period">The Period (Daily or Monthly) of the Returns to be deleted. Defaults to Daily. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> DeletePortfolioReturnsWithHttpInfo(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, string period = default(string))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->DeletePortfolioReturns");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->DeletePortfolioReturns");

            // verify the required parameter 'returnScope' is set
            if (returnScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'returnScope' when calling PortfoliosApi->DeletePortfolioReturns");

            // verify the required parameter 'returnCode' is set
            if (returnCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'returnCode' when calling PortfoliosApi->DeletePortfolioReturns");

            // verify the required parameter 'fromEffectiveAt' is set
            if (fromEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'fromEffectiveAt' when calling PortfoliosApi->DeletePortfolioReturns");

            // verify the required parameter 'toEffectiveAt' is set
            if (toEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'toEffectiveAt' when calling PortfoliosApi->DeletePortfolioReturns");

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
            localVarRequestOptions.PathParameters.Add("returnScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(returnScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("returnCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(returnCode)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toEffectiveAt", toEffectiveAt));
            if (period != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "period", period));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeletedEntityResponse>("/api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode}/$delete", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePortfolioReturns", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioReturns: Delete Returns Cancel one or more Returns which exist into the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to delete the Returns.</param>
        /// <param name="toEffectiveAt">The end date from which to delete the Returns.</param>
        /// <param name="period">The Period (Daily or Monthly) of the Returns to be deleted. Defaults to Daily. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioReturnsAsync(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, string period = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePortfolioReturnsWithHttpInfoAsync(scope, code, returnScope, returnCode, fromEffectiveAt, toEffectiveAt, period, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioReturns: Delete Returns Cancel one or more Returns which exist into the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to delete the Returns.</param>
        /// <param name="toEffectiveAt">The end date from which to delete the Returns.</param>
        /// <param name="period">The Period (Daily or Monthly) of the Returns to be deleted. Defaults to Daily. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeletePortfolioReturnsWithHttpInfoAsync(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, string period = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->DeletePortfolioReturns");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->DeletePortfolioReturns");

            // verify the required parameter 'returnScope' is set
            if (returnScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'returnScope' when calling PortfoliosApi->DeletePortfolioReturns");

            // verify the required parameter 'returnCode' is set
            if (returnCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'returnCode' when calling PortfoliosApi->DeletePortfolioReturns");

            // verify the required parameter 'fromEffectiveAt' is set
            if (fromEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'fromEffectiveAt' when calling PortfoliosApi->DeletePortfolioReturns");

            // verify the required parameter 'toEffectiveAt' is set
            if (toEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'toEffectiveAt' when calling PortfoliosApi->DeletePortfolioReturns");


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
            localVarRequestOptions.PathParameters.Add("returnScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(returnScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("returnCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(returnCode)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toEffectiveAt", toEffectiveAt));
            if (period != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "period", period));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode}/$delete", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePortfolioReturns", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetPortfolio: Get portfolio Retrieve the definition of a particular portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to returning the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto the portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <returns>Portfolio</returns>
        public Portfolio GetPortfolio(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<Portfolio> localVarResponse = GetPortfolioWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetPortfolio: Get portfolio Retrieve the definition of a particular portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to returning the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto the portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        public Lusid.Sdk.Client.ApiResponse<Portfolio> GetPortfolioWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolio");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolio");

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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Get<Portfolio>("/api/portfolios/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolio", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetPortfolio: Get portfolio Retrieve the definition of a particular portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to returning the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto the portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Portfolio</returns>
        public async System.Threading.Tasks.Task<Portfolio> GetPortfolioAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Portfolio> localVarResponse = await GetPortfolioWithHttpInfoAsync(scope, code, effectiveAt, asAt, propertyKeys, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetPortfolio: Get portfolio Retrieve the definition of a particular portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio definition. Defaults to returning the latest version of the portfolio definition if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto the portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Portfolio>> GetPortfolioWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolio");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolio");


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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Portfolio>("/api/portfolios/{scope}/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolio", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioAggregatedReturns: Aggregated Returns Aggregate Returns which are on the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="aggregatedReturnsRequest">The request used in the AggregatedReturns.</param>
        /// <param name="fromEffectiveAt">The start date from which to calculate the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date for which to calculate the Returns. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <returns>AggregatedReturnsResponse</returns>
        public AggregatedReturnsResponse GetPortfolioAggregatedReturns(string scope, string code, AggregatedReturnsRequest aggregatedReturnsRequest, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<AggregatedReturnsResponse> localVarResponse = GetPortfolioAggregatedReturnsWithHttpInfo(scope, code, aggregatedReturnsRequest, fromEffectiveAt, toEffectiveAt, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioAggregatedReturns: Aggregated Returns Aggregate Returns which are on the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="aggregatedReturnsRequest">The request used in the AggregatedReturns.</param>
        /// <param name="fromEffectiveAt">The start date from which to calculate the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date for which to calculate the Returns. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <returns>ApiResponse of AggregatedReturnsResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<AggregatedReturnsResponse> GetPortfolioAggregatedReturnsWithHttpInfo(string scope, string code, AggregatedReturnsRequest aggregatedReturnsRequest, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioAggregatedReturns");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioAggregatedReturns");

            // verify the required parameter 'aggregatedReturnsRequest' is set
            if (aggregatedReturnsRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'aggregatedReturnsRequest' when calling PortfoliosApi->GetPortfolioAggregatedReturns");

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
            if (fromEffectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            }
            if (toEffectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toEffectiveAt", toEffectiveAt));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            localVarRequestOptions.Data = aggregatedReturnsRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Post<AggregatedReturnsResponse>("/api/portfolios/{scope}/{code}/returns/$aggregated", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioAggregatedReturns", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioAggregatedReturns: Aggregated Returns Aggregate Returns which are on the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="aggregatedReturnsRequest">The request used in the AggregatedReturns.</param>
        /// <param name="fromEffectiveAt">The start date from which to calculate the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date for which to calculate the Returns. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AggregatedReturnsResponse</returns>
        public async System.Threading.Tasks.Task<AggregatedReturnsResponse> GetPortfolioAggregatedReturnsAsync(string scope, string code, AggregatedReturnsRequest aggregatedReturnsRequest, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<AggregatedReturnsResponse> localVarResponse = await GetPortfolioAggregatedReturnsWithHttpInfoAsync(scope, code, aggregatedReturnsRequest, fromEffectiveAt, toEffectiveAt, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioAggregatedReturns: Aggregated Returns Aggregate Returns which are on the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="aggregatedReturnsRequest">The request used in the AggregatedReturns.</param>
        /// <param name="fromEffectiveAt">The start date from which to calculate the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date for which to calculate the Returns. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AggregatedReturnsResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<AggregatedReturnsResponse>> GetPortfolioAggregatedReturnsWithHttpInfoAsync(string scope, string code, AggregatedReturnsRequest aggregatedReturnsRequest, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioAggregatedReturns");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioAggregatedReturns");

            // verify the required parameter 'aggregatedReturnsRequest' is set
            if (aggregatedReturnsRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'aggregatedReturnsRequest' when calling PortfoliosApi->GetPortfolioAggregatedReturns");


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
            if (fromEffectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            }
            if (toEffectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toEffectiveAt", toEffectiveAt));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            localVarRequestOptions.Data = aggregatedReturnsRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AggregatedReturnsResponse>("/api/portfolios/{scope}/{code}/returns/$aggregated", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioAggregatedReturns", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetPortfolioCommands: Get portfolio commands Get all the commands that modified a particular portfolio, including any input transactions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the User ID, specify \&quot;userId.id eq &#39;string&#39;\&quot;.              For more information about filtering, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing commands; this value is returned from the previous call. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 500 if not specified. (optional)</param>
        /// <returns>ResourceListOfProcessedCommand</returns>
        public ResourceListOfProcessedCommand GetPortfolioCommands(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfProcessedCommand> localVarResponse = GetPortfolioCommandsWithHttpInfo(scope, code, fromAsAt, toAsAt, filter, page, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetPortfolioCommands: Get portfolio commands Get all the commands that modified a particular portfolio, including any input transactions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the User ID, specify \&quot;userId.id eq &#39;string&#39;\&quot;.              For more information about filtering, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing commands; this value is returned from the previous call. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 500 if not specified. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfProcessedCommand</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfProcessedCommand> GetPortfolioCommandsWithHttpInfo(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioCommands");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioCommands");

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
            if (fromAsAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromAsAt", fromAsAt));
            }
            if (toAsAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toAsAt", toAsAt));
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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfProcessedCommand>("/api/portfolios/{scope}/{code}/commands", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioCommands", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetPortfolioCommands: Get portfolio commands Get all the commands that modified a particular portfolio, including any input transactions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the User ID, specify \&quot;userId.id eq &#39;string&#39;\&quot;.              For more information about filtering, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing commands; this value is returned from the previous call. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 500 if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfProcessedCommand</returns>
        public async System.Threading.Tasks.Task<ResourceListOfProcessedCommand> GetPortfolioCommandsAsync(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfProcessedCommand> localVarResponse = await GetPortfolioCommandsWithHttpInfoAsync(scope, code, fromAsAt, toAsAt, filter, page, limit, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetPortfolioCommands: Get portfolio commands Get all the commands that modified a particular portfolio, including any input transactions.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the User ID, specify \&quot;userId.id eq &#39;string&#39;\&quot;.              For more information about filtering, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing commands; this value is returned from the previous call. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 500 if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfProcessedCommand)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfProcessedCommand>> GetPortfolioCommandsWithHttpInfoAsync(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioCommands");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioCommands");


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
            if (fromAsAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromAsAt", fromAsAt));
            }
            if (toAsAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toAsAt", toAsAt));
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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfProcessedCommand>("/api/portfolios/{scope}/{code}/commands", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioCommands", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioMetadata: Get access metadata rules for a portfolio Pass the scope and portfolio code parameters to retrieve the AccessMetadata associated with a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata rule. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <returns>Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public Dictionary<string, List<AccessMetadataValue>> GetPortfolioMetadata(string scope, string code, string effectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> localVarResponse = GetPortfolioMetadataWithHttpInfo(scope, code, effectiveAt, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioMetadata: Get access metadata rules for a portfolio Pass the scope and portfolio code parameters to retrieve the AccessMetadata associated with a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata rule. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> GetPortfolioMetadataWithHttpInfo(string scope, string code, string effectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioMetadata");

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
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Get<Dictionary<string, List<AccessMetadataValue>>>("/api/portfolios/{scope}/{code}/metadata", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioMetadata: Get access metadata rules for a portfolio Pass the scope and portfolio code parameters to retrieve the AccessMetadata associated with a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata rule. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, List<AccessMetadataValue>>> GetPortfolioMetadataAsync(string scope, string code, string effectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> localVarResponse = await GetPortfolioMetadataWithHttpInfoAsync(scope, code, effectiveAt, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioMetadata: Get access metadata rules for a portfolio Pass the scope and portfolio code parameters to retrieve the AccessMetadata associated with a portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata rule. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>>> GetPortfolioMetadataWithHttpInfoAsync(string scope, string code, string effectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioMetadata");


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
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Dictionary<string, List<AccessMetadataValue>>>("/api/portfolios/{scope}/{code}/metadata", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetPortfolioProperties: Get portfolio properties List all the properties of a particular portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to returning the latest version of each property if not specified. (optional)</param>
        /// <returns>PortfolioProperties</returns>
        public PortfolioProperties GetPortfolioProperties(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioProperties> localVarResponse = GetPortfolioPropertiesWithHttpInfo(scope, code, effectiveAt, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetPortfolioProperties: Get portfolio properties List all the properties of a particular portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to returning the latest version of each property if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioProperties</returns>
        public Lusid.Sdk.Client.ApiResponse<PortfolioProperties> GetPortfolioPropertiesWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioProperties");

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
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Get<PortfolioProperties>("/api/portfolios/{scope}/{code}/properties", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetPortfolioProperties: Get portfolio properties List all the properties of a particular portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to returning the latest version of each property if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioProperties</returns>
        public async System.Threading.Tasks.Task<PortfolioProperties> GetPortfolioPropertiesAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioProperties> localVarResponse = await GetPortfolioPropertiesWithHttpInfoAsync(scope, code, effectiveAt, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetPortfolioProperties: Get portfolio properties List all the properties of a particular portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio&#39;s properties. Defaults to returning the latest version of each property if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioProperties)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioProperties>> GetPortfolioPropertiesWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioProperties");


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
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PortfolioProperties>("/api/portfolios/{scope}/{code}/properties", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioRelationships: Get portfolio relationships Get relationships for a particular portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to returning the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relationships. Provide a null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <returns>ResourceListOfRelationship</returns>
        public ResourceListOfRelationship GetPortfolioRelationships(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfRelationship> localVarResponse = GetPortfolioRelationshipsWithHttpInfo(scope, code, effectiveAt, asAt, filter, identifierTypes);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioRelationships: Get portfolio relationships Get relationships for a particular portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to returning the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relationships. Provide a null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfRelationship</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfRelationship> GetPortfolioRelationshipsWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioRelationships");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioRelationships");

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
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (identifierTypes != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "identifierTypes", identifierTypes));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfRelationship>("/api/portfolios/{scope}/{code}/relationships", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioRelationships", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioRelationships: Get portfolio relationships Get relationships for a particular portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to returning the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relationships. Provide a null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfRelationship</returns>
        public async System.Threading.Tasks.Task<ResourceListOfRelationship> GetPortfolioRelationshipsAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfRelationship> localVarResponse = await GetPortfolioRelationshipsWithHttpInfoAsync(scope, code, effectiveAt, asAt, filter, identifierTypes, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioRelationships: Get portfolio relationships Get relationships for a particular portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to returning the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relationships. Provide a null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfRelationship)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfRelationship>> GetPortfolioRelationshipsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioRelationships");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioRelationships");


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
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (identifierTypes != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "identifierTypes", identifierTypes));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfRelationship>("/api/portfolios/{scope}/{code}/relationships", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioRelationships", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioReturns: Get Returns Get Returns which are on the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to get the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date from which to get the Returns. (optional)</param>
        /// <param name="period">Show the Returns on a Daily or Monthly period. Defaults to Daily. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <returns>ResourceListOfPerformanceReturn</returns>
        public ResourceListOfPerformanceReturn GetPortfolioReturns(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), string period = default(string), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPerformanceReturn> localVarResponse = GetPortfolioReturnsWithHttpInfo(scope, code, returnScope, returnCode, fromEffectiveAt, toEffectiveAt, period, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioReturns: Get Returns Get Returns which are on the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to get the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date from which to get the Returns. (optional)</param>
        /// <param name="period">Show the Returns on a Daily or Monthly period. Defaults to Daily. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPerformanceReturn</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfPerformanceReturn> GetPortfolioReturnsWithHttpInfo(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), string period = default(string), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioReturns");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioReturns");

            // verify the required parameter 'returnScope' is set
            if (returnScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'returnScope' when calling PortfoliosApi->GetPortfolioReturns");

            // verify the required parameter 'returnCode' is set
            if (returnCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'returnCode' when calling PortfoliosApi->GetPortfolioReturns");

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
            localVarRequestOptions.PathParameters.Add("returnScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(returnScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("returnCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(returnCode)); // path parameter
            if (fromEffectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            }
            if (toEffectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toEffectiveAt", toEffectiveAt));
            }
            if (period != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "period", period));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfPerformanceReturn>("/api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioReturns", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioReturns: Get Returns Get Returns which are on the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to get the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date from which to get the Returns. (optional)</param>
        /// <param name="period">Show the Returns on a Daily or Monthly period. Defaults to Daily. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPerformanceReturn</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPerformanceReturn> GetPortfolioReturnsAsync(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), string period = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPerformanceReturn> localVarResponse = await GetPortfolioReturnsWithHttpInfoAsync(scope, code, returnScope, returnCode, fromEffectiveAt, toEffectiveAt, period, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioReturns: Get Returns Get Returns which are on the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="fromEffectiveAt">The start date from which to get the Returns. (optional)</param>
        /// <param name="toEffectiveAt">The end date from which to get the Returns. (optional)</param>
        /// <param name="period">Show the Returns on a Daily or Monthly period. Defaults to Daily. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPerformanceReturn)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfPerformanceReturn>> GetPortfolioReturnsWithHttpInfoAsync(string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), string period = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfolioReturns");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfolioReturns");

            // verify the required parameter 'returnScope' is set
            if (returnScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'returnScope' when calling PortfoliosApi->GetPortfolioReturns");

            // verify the required parameter 'returnCode' is set
            if (returnCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'returnCode' when calling PortfoliosApi->GetPortfolioReturns");


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
            localVarRequestOptions.PathParameters.Add("returnScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(returnScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("returnCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(returnCode)); // path parameter
            if (fromEffectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            }
            if (toEffectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toEffectiveAt", toEffectiveAt));
            }
            if (period != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "period", period));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfPerformanceReturn>("/api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioReturns", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfoliosAccessMetadataByKey: Get an entry identified by a metadataKey in the access metadata object Get a specific portfolio access metadata rule by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="metadataKey">Key of the metadata to retrieve</param>
        /// <param name="effectiveAt">The effective date of the rule (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <returns>ICollection&lt;AccessMetadataValue&gt;</returns>
        public ICollection<AccessMetadataValue> GetPortfoliosAccessMetadataByKey(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>> localVarResponse = GetPortfoliosAccessMetadataByKeyWithHttpInfo(scope, code, metadataKey, effectiveAt, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfoliosAccessMetadataByKey: Get an entry identified by a metadataKey in the access metadata object Get a specific portfolio access metadata rule by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="metadataKey">Key of the metadata to retrieve</param>
        /// <param name="effectiveAt">The effective date of the rule (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;AccessMetadataValue&gt;</returns>
        public Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>> GetPortfoliosAccessMetadataByKeyWithHttpInfo(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfoliosAccessMetadataByKey");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfoliosAccessMetadataByKey");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PortfoliosApi->GetPortfoliosAccessMetadataByKey");

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
            localVarRequestOptions.PathParameters.Add("metadataKey", Lusid.Sdk.Client.ClientUtils.ParameterToString(metadataKey)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ICollection<AccessMetadataValue>>("/api/portfolios/{scope}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfoliosAccessMetadataByKey", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfoliosAccessMetadataByKey: Get an entry identified by a metadataKey in the access metadata object Get a specific portfolio access metadata rule by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="metadataKey">Key of the metadata to retrieve</param>
        /// <param name="effectiveAt">The effective date of the rule (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;AccessMetadataValue&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<AccessMetadataValue>> GetPortfoliosAccessMetadataByKeyAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>> localVarResponse = await GetPortfoliosAccessMetadataByKeyWithHttpInfoAsync(scope, code, metadataKey, effectiveAt, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfoliosAccessMetadataByKey: Get an entry identified by a metadataKey in the access metadata object Get a specific portfolio access metadata rule by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Access Metadata Rule to retrieve.</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="metadataKey">Key of the metadata to retrieve</param>
        /// <param name="effectiveAt">The effective date of the rule (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio access metadata. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;AccessMetadataValue&gt;)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>>> GetPortfoliosAccessMetadataByKeyWithHttpInfoAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->GetPortfoliosAccessMetadataByKey");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->GetPortfoliosAccessMetadataByKey");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PortfoliosApi->GetPortfoliosAccessMetadataByKey");


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
            localVarRequestOptions.PathParameters.Add("metadataKey", Lusid.Sdk.Client.ClientUtils.ParameterToString(metadataKey)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ICollection<AccessMetadataValue>>("/api/portfolios/{scope}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfoliosAccessMetadataByKey", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// ListPortfolios: List portfolios List all the portfolios matching particular criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the transaction type, specify \&quot;type eq &#39;Transaction&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet. For example, to see which              portfolios have holdings in instruments with a LusidInstrumentId (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;,              specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <returns>ResourceListOfPortfolio</returns>
        public ResourceListOfPortfolio ListPortfolios(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), string query = default(string), List<string> propertyKeys = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolio> localVarResponse = ListPortfoliosWithHttpInfo(effectiveAt, asAt, page, start, limit, filter, query, propertyKeys);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ListPortfolios: List portfolios List all the portfolios matching particular criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the transaction type, specify \&quot;type eq &#39;Transaction&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet. For example, to see which              portfolios have holdings in instruments with a LusidInstrumentId (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;,              specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolio</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolio> ListPortfoliosWithHttpInfo(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), string query = default(string), List<string> propertyKeys = default(List<string>))
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

            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
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
            if (query != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "query", query));
            }
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfPortfolio>("/api/portfolios", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPortfolios", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// ListPortfolios: List portfolios List all the portfolios matching particular criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the transaction type, specify \&quot;type eq &#39;Transaction&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet. For example, to see which              portfolios have holdings in instruments with a LusidInstrumentId (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;,              specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPortfolio</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPortfolio> ListPortfoliosAsync(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), string query = default(string), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolio> localVarResponse = await ListPortfoliosWithHttpInfoAsync(effectiveAt, asAt, page, start, limit, filter, query, propertyKeys, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ListPortfolios: List portfolios List all the portfolios matching particular criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to filter on the transaction type, specify \&quot;type eq &#39;Transaction&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="query">Expression specifying the criteria that the returned portfolios must meet. For example, to see which              portfolios have holdings in instruments with a LusidInstrumentId (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;,              specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolio)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolio>> ListPortfoliosWithHttpInfoAsync(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), string query = default(string), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
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
            if (query != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "query", query));
            }
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfPortfolio>("/api/portfolios", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPortfolios", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// ListPortfoliosForScope: List portfolios for scope List all the portfolios in a particular scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope whose portfolios to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <returns>ResourceListOfPortfolio</returns>
        public ResourceListOfPortfolio ListPortfoliosForScope(string scope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolio> localVarResponse = ListPortfoliosForScopeWithHttpInfo(scope, effectiveAt, asAt, page, start, limit, filter, propertyKeys);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ListPortfoliosForScope: List portfolios for scope List all the portfolios in a particular scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope whose portfolios to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolio</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolio> ListPortfoliosForScopeWithHttpInfo(string scope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->ListPortfoliosForScope");

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
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
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
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfPortfolio>("/api/portfolios/{scope}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPortfoliosForScope", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// ListPortfoliosForScope: List portfolios for scope List all the portfolios in a particular scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope whose portfolios to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPortfolio</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPortfolio> ListPortfoliosForScopeAsync(string scope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolio> localVarResponse = await ListPortfoliosForScopeWithHttpInfoAsync(scope, effectiveAt, asAt, page, start, limit, filter, propertyKeys, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ListPortfoliosForScope: List portfolios for scope List all the portfolios in a particular scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope whose portfolios to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing portfolios. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolio)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolio>> ListPortfoliosForScopeWithHttpInfoAsync(string scope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->ListPortfoliosForScope");


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
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
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
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfPortfolio>("/api/portfolios/{scope}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPortfoliosForScope", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// UpdatePortfolio: Update portfolio Update the definition of a particular portfolio.                Note that not all elements of a portfolio definition are  modifiable due to the potential implications for data already stored.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="updatePortfolioRequest">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current               LUSID system datetime if not specified. (optional)</param>
        /// <returns>Portfolio</returns>
        public Portfolio UpdatePortfolio(string scope, string code, UpdatePortfolioRequest updatePortfolioRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            Lusid.Sdk.Client.ApiResponse<Portfolio> localVarResponse = UpdatePortfolioWithHttpInfo(scope, code, updatePortfolioRequest, effectiveAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// UpdatePortfolio: Update portfolio Update the definition of a particular portfolio.                Note that not all elements of a portfolio definition are  modifiable due to the potential implications for data already stored.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="updatePortfolioRequest">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current               LUSID system datetime if not specified. (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        public Lusid.Sdk.Client.ApiResponse<Portfolio> UpdatePortfolioWithHttpInfo(string scope, string code, UpdatePortfolioRequest updatePortfolioRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpdatePortfolio");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpdatePortfolio");

            // verify the required parameter 'updatePortfolioRequest' is set
            if (updatePortfolioRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'updatePortfolioRequest' when calling PortfoliosApi->UpdatePortfolio");

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
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            localVarRequestOptions.Data = updatePortfolioRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Put<Portfolio>("/api/portfolios/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdatePortfolio", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// UpdatePortfolio: Update portfolio Update the definition of a particular portfolio.                Note that not all elements of a portfolio definition are  modifiable due to the potential implications for data already stored.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="updatePortfolioRequest">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current               LUSID system datetime if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Portfolio</returns>
        public async System.Threading.Tasks.Task<Portfolio> UpdatePortfolioAsync(string scope, string code, UpdatePortfolioRequest updatePortfolioRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Portfolio> localVarResponse = await UpdatePortfolioWithHttpInfoAsync(scope, code, updatePortfolioRequest, effectiveAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// UpdatePortfolio: Update portfolio Update the definition of a particular portfolio.                Note that not all elements of a portfolio definition are  modifiable due to the potential implications for data already stored.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="updatePortfolioRequest">The updated portfolio definition.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to update the definition. Defaults to the current               LUSID system datetime if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Portfolio>> UpdatePortfolioWithHttpInfoAsync(string scope, string code, UpdatePortfolioRequest updatePortfolioRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpdatePortfolio");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpdatePortfolio");

            // verify the required parameter 'updatePortfolioRequest' is set
            if (updatePortfolioRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'updatePortfolioRequest' when calling PortfoliosApi->UpdatePortfolio");


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
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            localVarRequestOptions.Data = updatePortfolioRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Portfolio>("/api/portfolios/{scope}/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdatePortfolio", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioAccessMetadata: Upsert a Portfolio Access Metadata Rule associated with specific metadataKey. This creates or updates the data in LUSID. Update or insert one Portfolio Access Metadata Rule in a single scope. An item will be updated if it already exists  and inserted if it does not.    The response will return the successfully updated or inserted Portfolio Access Metadata Rule or failure message if unsuccessful    It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exists with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to use when updating or inserting the Portfolio Access Metadata Rule.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">Key of the access metadata to upsert</param>
        /// <param name="upsertPortfolioAccessMetadataRequest">The Portfolio Access Metadata Rule to update or insert</param>
        /// <param name="effectiveAt">The date this rule will effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>ResourceListOfAccessMetadataValueOf</returns>
        public ResourceListOfAccessMetadataValueOf UpsertPortfolioAccessMetadata(string scope, string code, string metadataKey, UpsertPortfolioAccessMetadataRequest upsertPortfolioAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfAccessMetadataValueOf> localVarResponse = UpsertPortfolioAccessMetadataWithHttpInfo(scope, code, metadataKey, upsertPortfolioAccessMetadataRequest, effectiveAt, effectiveUntil);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioAccessMetadata: Upsert a Portfolio Access Metadata Rule associated with specific metadataKey. This creates or updates the data in LUSID. Update or insert one Portfolio Access Metadata Rule in a single scope. An item will be updated if it already exists  and inserted if it does not.    The response will return the successfully updated or inserted Portfolio Access Metadata Rule or failure message if unsuccessful    It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exists with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to use when updating or inserting the Portfolio Access Metadata Rule.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">Key of the access metadata to upsert</param>
        /// <param name="upsertPortfolioAccessMetadataRequest">The Portfolio Access Metadata Rule to update or insert</param>
        /// <param name="effectiveAt">The date this rule will effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of ResourceListOfAccessMetadataValueOf</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfAccessMetadataValueOf> UpsertPortfolioAccessMetadataWithHttpInfo(string scope, string code, string metadataKey, UpsertPortfolioAccessMetadataRequest upsertPortfolioAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpsertPortfolioAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpsertPortfolioAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PortfoliosApi->UpsertPortfolioAccessMetadata");

            // verify the required parameter 'upsertPortfolioAccessMetadataRequest' is set
            if (upsertPortfolioAccessMetadataRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'upsertPortfolioAccessMetadataRequest' when calling PortfoliosApi->UpsertPortfolioAccessMetadata");

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
            localVarRequestOptions.PathParameters.Add("metadataKey", Lusid.Sdk.Client.ClientUtils.ParameterToString(metadataKey)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (effectiveUntil != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveUntil", effectiveUntil));
            }
            localVarRequestOptions.Data = upsertPortfolioAccessMetadataRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Put<ResourceListOfAccessMetadataValueOf>("/api/portfolios/{scope}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertPortfolioAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioAccessMetadata: Upsert a Portfolio Access Metadata Rule associated with specific metadataKey. This creates or updates the data in LUSID. Update or insert one Portfolio Access Metadata Rule in a single scope. An item will be updated if it already exists  and inserted if it does not.    The response will return the successfully updated or inserted Portfolio Access Metadata Rule or failure message if unsuccessful    It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exists with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to use when updating or inserting the Portfolio Access Metadata Rule.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">Key of the access metadata to upsert</param>
        /// <param name="upsertPortfolioAccessMetadataRequest">The Portfolio Access Metadata Rule to update or insert</param>
        /// <param name="effectiveAt">The date this rule will effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfAccessMetadataValueOf</returns>
        public async System.Threading.Tasks.Task<ResourceListOfAccessMetadataValueOf> UpsertPortfolioAccessMetadataAsync(string scope, string code, string metadataKey, UpsertPortfolioAccessMetadataRequest upsertPortfolioAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfAccessMetadataValueOf> localVarResponse = await UpsertPortfolioAccessMetadataWithHttpInfoAsync(scope, code, metadataKey, upsertPortfolioAccessMetadataRequest, effectiveAt, effectiveUntil, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioAccessMetadata: Upsert a Portfolio Access Metadata Rule associated with specific metadataKey. This creates or updates the data in LUSID. Update or insert one Portfolio Access Metadata Rule in a single scope. An item will be updated if it already exists  and inserted if it does not.    The response will return the successfully updated or inserted Portfolio Access Metadata Rule or failure message if unsuccessful    It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exists with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to use when updating or inserting the Portfolio Access Metadata Rule.</param>
        /// <param name="code">Portfolio code</param>
        /// <param name="metadataKey">Key of the access metadata to upsert</param>
        /// <param name="upsertPortfolioAccessMetadataRequest">The Portfolio Access Metadata Rule to update or insert</param>
        /// <param name="effectiveAt">The date this rule will effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfAccessMetadataValueOf)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfAccessMetadataValueOf>> UpsertPortfolioAccessMetadataWithHttpInfoAsync(string scope, string code, string metadataKey, UpsertPortfolioAccessMetadataRequest upsertPortfolioAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpsertPortfolioAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpsertPortfolioAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PortfoliosApi->UpsertPortfolioAccessMetadata");

            // verify the required parameter 'upsertPortfolioAccessMetadataRequest' is set
            if (upsertPortfolioAccessMetadataRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'upsertPortfolioAccessMetadataRequest' when calling PortfoliosApi->UpsertPortfolioAccessMetadata");


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
            localVarRequestOptions.PathParameters.Add("metadataKey", Lusid.Sdk.Client.ClientUtils.ParameterToString(metadataKey)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (effectiveUntil != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveUntil", effectiveUntil));
            }
            localVarRequestOptions.Data = upsertPortfolioAccessMetadataRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<ResourceListOfAccessMetadataValueOf>("/api/portfolios/{scope}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertPortfolioAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// UpsertPortfolioProperties: Upsert portfolio properties Create or update one or more properties for a particular portfolio. A property is updated if it  already exists and created if it does not. All properties must be from the &#39;Portfolio&#39; domain.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which it is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="requestBody">The properties to be created or updated. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code}, for example               &#39;Portfolio/Manager/Id&#39;.</param>
        /// <returns>PortfolioProperties</returns>
        public PortfolioProperties UpsertPortfolioProperties(string scope, string code, Dictionary<string, Property> requestBody)
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioProperties> localVarResponse = UpsertPortfolioPropertiesWithHttpInfo(scope, code, requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// UpsertPortfolioProperties: Upsert portfolio properties Create or update one or more properties for a particular portfolio. A property is updated if it  already exists and created if it does not. All properties must be from the &#39;Portfolio&#39; domain.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which it is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="requestBody">The properties to be created or updated. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code}, for example               &#39;Portfolio/Manager/Id&#39;.</param>
        /// <returns>ApiResponse of PortfolioProperties</returns>
        public Lusid.Sdk.Client.ApiResponse<PortfolioProperties> UpsertPortfolioPropertiesWithHttpInfo(string scope, string code, Dictionary<string, Property> requestBody)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpsertPortfolioProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpsertPortfolioProperties");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling PortfoliosApi->UpsertPortfolioProperties");

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
            localVarRequestOptions.Data = requestBody;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Post<PortfolioProperties>("/api/portfolios/{scope}/{code}/properties", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertPortfolioProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// UpsertPortfolioProperties: Upsert portfolio properties Create or update one or more properties for a particular portfolio. A property is updated if it  already exists and created if it does not. All properties must be from the &#39;Portfolio&#39; domain.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which it is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="requestBody">The properties to be created or updated. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code}, for example               &#39;Portfolio/Manager/Id&#39;.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioProperties</returns>
        public async System.Threading.Tasks.Task<PortfolioProperties> UpsertPortfolioPropertiesAsync(string scope, string code, Dictionary<string, Property> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioProperties> localVarResponse = await UpsertPortfolioPropertiesWithHttpInfoAsync(scope, code, requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// UpsertPortfolioProperties: Upsert portfolio properties Create or update one or more properties for a particular portfolio. A property is updated if it  already exists and created if it does not. All properties must be from the &#39;Portfolio&#39; domain.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime from which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which it is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio.</param>
        /// <param name="code">The code of the portfolio. Together with the scope this uniquely identifies the portfolio.</param>
        /// <param name="requestBody">The properties to be created or updated. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code}, for example               &#39;Portfolio/Manager/Id&#39;.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioProperties)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioProperties>> UpsertPortfolioPropertiesWithHttpInfoAsync(string scope, string code, Dictionary<string, Property> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpsertPortfolioProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpsertPortfolioProperties");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling PortfoliosApi->UpsertPortfolioProperties");


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
            localVarRequestOptions.Data = requestBody;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<PortfolioProperties>("/api/portfolios/{scope}/{code}/properties", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertPortfolioProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioReturns: Upsert Returns Update or insert returns into the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="performanceReturn">This contains the Returns which need to be upsert.</param>
        /// <returns>UpsertReturnsResponse</returns>
        public UpsertReturnsResponse UpsertPortfolioReturns(string scope, string code, string returnScope, string returnCode, List<PerformanceReturn> performanceReturn)
        {
            Lusid.Sdk.Client.ApiResponse<UpsertReturnsResponse> localVarResponse = UpsertPortfolioReturnsWithHttpInfo(scope, code, returnScope, returnCode, performanceReturn);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioReturns: Upsert Returns Update or insert returns into the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="performanceReturn">This contains the Returns which need to be upsert.</param>
        /// <returns>ApiResponse of UpsertReturnsResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<UpsertReturnsResponse> UpsertPortfolioReturnsWithHttpInfo(string scope, string code, string returnScope, string returnCode, List<PerformanceReturn> performanceReturn)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpsertPortfolioReturns");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpsertPortfolioReturns");

            // verify the required parameter 'returnScope' is set
            if (returnScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'returnScope' when calling PortfoliosApi->UpsertPortfolioReturns");

            // verify the required parameter 'returnCode' is set
            if (returnCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'returnCode' when calling PortfoliosApi->UpsertPortfolioReturns");

            // verify the required parameter 'performanceReturn' is set
            if (performanceReturn == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'performanceReturn' when calling PortfoliosApi->UpsertPortfolioReturns");

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
            localVarRequestOptions.PathParameters.Add("returnScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(returnScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("returnCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(returnCode)); // path parameter
            localVarRequestOptions.Data = performanceReturn;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request
            var localVarResponse = this.Client.Post<UpsertReturnsResponse>("/api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertPortfolioReturns", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioReturns: Upsert Returns Update or insert returns into the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="performanceReturn">This contains the Returns which need to be upsert.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpsertReturnsResponse</returns>
        public async System.Threading.Tasks.Task<UpsertReturnsResponse> UpsertPortfolioReturnsAsync(string scope, string code, string returnScope, string returnCode, List<PerformanceReturn> performanceReturn, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<UpsertReturnsResponse> localVarResponse = await UpsertPortfolioReturnsWithHttpInfoAsync(scope, code, returnScope, returnCode, performanceReturn, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioReturns: Upsert Returns Update or insert returns into the specified portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio.</param>
        /// <param name="code">The code of the  Portfolio.</param>
        /// <param name="returnScope">The scope of the Returns.</param>
        /// <param name="returnCode">The code of the Returns.</param>
        /// <param name="performanceReturn">This contains the Returns which need to be upsert.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpsertReturnsResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<UpsertReturnsResponse>> UpsertPortfolioReturnsWithHttpInfoAsync(string scope, string code, string returnScope, string returnCode, List<PerformanceReturn> performanceReturn, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfoliosApi->UpsertPortfolioReturns");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfoliosApi->UpsertPortfolioReturns");

            // verify the required parameter 'returnScope' is set
            if (returnScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'returnScope' when calling PortfoliosApi->UpsertPortfolioReturns");

            // verify the required parameter 'returnCode' is set
            if (returnCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'returnCode' when calling PortfoliosApi->UpsertPortfolioReturns");

            // verify the required parameter 'performanceReturn' is set
            if (performanceReturn == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'performanceReturn' when calling PortfoliosApi->UpsertPortfolioReturns");


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
            localVarRequestOptions.PathParameters.Add("returnScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(returnScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("returnCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(returnCode)); // path parameter
            localVarRequestOptions.Data = performanceReturn;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4730");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<UpsertReturnsResponse>("/api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertPortfolioReturns", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}