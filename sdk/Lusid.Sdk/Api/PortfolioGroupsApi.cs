/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-10\">-10</a>|Server Configuration Error|  | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"102\">102</a>|Version Not Found|  | | <a name=\"103\">103</a>|Api Rate Limit Violation|  | | <a name=\"104\">104</a>|Instrument Not Found|  | | <a name=\"105\">105</a>|Property Not Found|  | | <a name=\"106\">106</a>|Portfolio Recursion Depth|  | | <a name=\"108\">108</a>|Group Not Found|  | | <a name=\"109\">109</a>|Portfolio Not Found|  | | <a name=\"110\">110</a>|Property Schema Not Found|  | | <a name=\"111\">111</a>|Portfolio Ancestry Not Found|  | | <a name=\"112\">112</a>|Portfolio With Id Already Exists|  | | <a name=\"113\">113</a>|Orphaned Portfolio|  | | <a name=\"119\">119</a>|Missing Base Claims|  | | <a name=\"121\">121</a>|Property Not Defined|  | | <a name=\"122\">122</a>|Cannot Delete System Property|  | | <a name=\"123\">123</a>|Cannot Modify Immutable Property Field|  | | <a name=\"124\">124</a>|Property Already Exists|  | | <a name=\"125\">125</a>|Invalid Property Life Time|  | | <a name=\"126\">126</a>|Property Constraint Style Excludes Properties|  | | <a name=\"127\">127</a>|Cannot Modify Default Data Type|  | | <a name=\"128\">128</a>|Group Already Exists|  | | <a name=\"129\">129</a>|No Such Data Type|  | | <a name=\"130\">130</a>|Undefined Value For Data Type|  | | <a name=\"131\">131</a>|Unsupported Value Type Defined On Data Type|  | | <a name=\"132\">132</a>|Validation Error|  | | <a name=\"133\">133</a>|Loop Detected In Group Hierarchy|  | | <a name=\"134\">134</a>|Undefined Acceptable Values|  | | <a name=\"135\">135</a>|Sub Group Already Exists|  | | <a name=\"138\">138</a>|Price Source Not Found|  | | <a name=\"139\">139</a>|Analytic Store Not Found|  | | <a name=\"141\">141</a>|Analytic Store Already Exists|  | | <a name=\"143\">143</a>|Client Instrument Already Exists|  | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"147\">147</a>|Results Not Found|  | | <a name=\"148\">148</a>|Order Field Not In Result Set|  | | <a name=\"149\">149</a>|Operation Failed|  | | <a name=\"150\">150</a>|Elastic Search Error|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"153\">153</a>|Command Processing Failure|  | | <a name=\"154\">154</a>|Entity State Construction Failure|  | | <a name=\"155\">155</a>|Entity Timeline Does Not Exist|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"158\">158</a>|Event Publish Unknown|  | | <a name=\"159\">159</a>|Event Query Failure|  | | <a name=\"160\">160</a>|Blob Did Not Exist|  | | <a name=\"162\">162</a>|Sub System Request Failure|  | | <a name=\"163\">163</a>|Sub System Configuration Failure|  | | <a name=\"165\">165</a>|Failed To Delete|  | | <a name=\"166\">166</a>|Upsert Client Instrument Failure|  | | <a name=\"167\">167</a>|Illegal As At Interval|  | | <a name=\"168\">168</a>|Illegal Bitemporal Query|  | | <a name=\"169\">169</a>|Invalid Alternate Id|  | | <a name=\"170\">170</a>|Cannot Add Source Portfolio Property Explicitly|  | | <a name=\"171\">171</a>|Entity Already Exists In Group|  | | <a name=\"173\">173</a>|Entity With Id Already Exists|  | | <a name=\"174\">174</a>|Derived Portfolio Details Do Not Exist|  | | <a name=\"175\">175</a>|Entity Not In Group|  | | <a name=\"176\">176</a>|Portfolio With Name Already Exists|  | | <a name=\"177\">177</a>|Invalid Transactions|  | | <a name=\"178\">178</a>|Reference Portfolio Not Found|  | | <a name=\"179\">179</a>|Duplicate Id|  | | <a name=\"180\">180</a>|Command Retrieval Failure|  | | <a name=\"181\">181</a>|Data Filter Application Failure|  | | <a name=\"182\">182</a>|Search Failed|  | | <a name=\"183\">183</a>|Movements Engine Configuration Key Failure|  | | <a name=\"184\">184</a>|Fx Rate Source Not Found|  | | <a name=\"185\">185</a>|Accrual Source Not Found|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"188\">188</a>|Invalid Request Headers|  | | <a name=\"189\">189</a>|Price Not Found|  | | <a name=\"190\">190</a>|Invalid Sub Holding Keys Provided|  | | <a name=\"191\">191</a>|Duplicate Sub Holding Keys Provided|  | | <a name=\"192\">192</a>|Cut Definition Not Found|  | | <a name=\"193\">193</a>|Cut Definition Invalid|  | | <a name=\"194\">194</a>|Time Variant Property Deletion Date Unspecified|  | | <a name=\"195\">195</a>|Perpetual Property Deletion Date Specified|  | | <a name=\"196\">196</a>|Time Variant Property Upsert Date Unspecified|  | | <a name=\"197\">197</a>|Perpetual Property Upsert Date Specified|  | | <a name=\"200\">200</a>|Invalid Unit For Data Type|  | | <a name=\"201\">201</a>|Invalid Type For Data Type|  | | <a name=\"202\">202</a>|Invalid Value For Data Type|  | | <a name=\"203\">203</a>|Unit Not Defined For Data Type|  | | <a name=\"204\">204</a>|Units Not Supported On Data Type|  | | <a name=\"205\">205</a>|Cannot Specify Units On Data Type|  | | <a name=\"206\">206</a>|Unit Schema Inconsistent With Data Type|  | | <a name=\"207\">207</a>|Unit Definition Not Specified|  | | <a name=\"208\">208</a>|Duplicate Unit Definitions Specified|  | | <a name=\"209\">209</a>|Invalid Units Definition|  | | <a name=\"210\">210</a>|Invalid Instrument Identifier Unit|  | | <a name=\"211\">211</a>|Holdings Adjustment Does Not Exist|  | | <a name=\"212\">212</a>|Could Not Build Excel Url|  | | <a name=\"213\">213</a>|Could Not Get Excel Version|  | | <a name=\"214\">214</a>|Instrument By Code Not Found|  | | <a name=\"215\">215</a>|Entity Schema Does Not Exist|  | | <a name=\"216\">216</a>|Feature Not Supported On Portfolio Type|  | | <a name=\"217\">217</a>|Quote Not Found|  | | <a name=\"218\">218</a>|Invalid Quote Identifier|  | | <a name=\"219\">219</a>|Invalid Metric For Data Type|  | | <a name=\"220\">220</a>|Invalid Instrument Definition|  | | <a name=\"221\">221</a>|Instrument Upsert Failure|  | | <a name=\"222\">222</a>|Reference Portfolio Request Not Supported|  | | <a name=\"223\">223</a>|Transaction Portfolio Request Not Supported|  | | <a name=\"224\">224</a>|Invalid Property Value Assignment|  | | <a name=\"230\">230</a>|Transaction Type Not Found|  | | <a name=\"231\">231</a>|Transaction Type Duplication|  | | <a name=\"232\">232</a>|Portfolio Does Not Exist At Given Date|  | | <a name=\"233\">233</a>|Query Parser Failure|  | | <a name=\"234\">234</a>|Duplicate Constituent|  | | <a name=\"235\">235</a>|Unresolved Instrument Constituent|  | | <a name=\"236\">236</a>|Unresolved Instrument In Transition|  | | <a name=\"237\">237</a>|Missing Side Definitions|  | | <a name=\"299\">299</a>|Invalid Recipe|  | | <a name=\"300\">300</a>|Missing Recipe|  | | <a name=\"301\">301</a>|Dependencies|  | | <a name=\"304\">304</a>|Portfolio Preprocess Failure|  | | <a name=\"310\">310</a>|Valuation Engine Failure|  | | <a name=\"311\">311</a>|Task Factory Failure|  | | <a name=\"312\">312</a>|Task Evaluation Failure|  | | <a name=\"313\">313</a>|Task Generation Failure|  | | <a name=\"314\">314</a>|Engine Configuration Failure|  | | <a name=\"315\">315</a>|Model Specification Failure|  | | <a name=\"320\">320</a>|Market Data Key Failure|  | | <a name=\"321\">321</a>|Market Resolver Failure|  | | <a name=\"322\">322</a>|Market Data Failure|  | | <a name=\"330\">330</a>|Curve Failure|  | | <a name=\"331\">331</a>|Volatility Surface Failure|  | | <a name=\"332\">332</a>|Volatility Cube Failure|  | | <a name=\"350\">350</a>|Instrument Failure|  | | <a name=\"351\">351</a>|Cash Flows Failure|  | | <a name=\"352\">352</a>|Reference Data Failure|  | | <a name=\"360\">360</a>|Aggregation Failure|  | | <a name=\"361\">361</a>|Aggregation Measure Failure|  | | <a name=\"370\">370</a>|Result Retrieval Failure|  | | <a name=\"371\">371</a>|Result Processing Failure|  | | <a name=\"372\">372</a>|Vendor Result Processing Failure|  | | <a name=\"373\">373</a>|Vendor Result Mapping Failure|  | | <a name=\"374\">374</a>|Vendor Library Unauthorised|  | | <a name=\"375\">375</a>|Vendor Connectivity Error|  | | <a name=\"376\">376</a>|Vendor Interface Error|  | | <a name=\"377\">377</a>|Vendor Pricing Failure|  | | <a name=\"378\">378</a>|Vendor Translation Failure|  | | <a name=\"379\">379</a>|Vendor Key Mapping Failure|  | | <a name=\"380\">380</a>|Vendor Reflection Failure|  | | <a name=\"381\">381</a>|Vendor Process Failure|  | | <a name=\"382\">382</a>|Vendor System Failure|  | | <a name=\"390\">390</a>|Attempt To Upsert Duplicate Quotes|  | | <a name=\"391\">391</a>|Corporate Action Source Does Not Exist|  | | <a name=\"392\">392</a>|Corporate Action Source Already Exists|  | | <a name=\"393\">393</a>|Instrument Identifier Already In Use|  | | <a name=\"394\">394</a>|Properties Not Found|  | | <a name=\"395\">395</a>|Batch Operation Aborted|  | | <a name=\"400\">400</a>|Invalid Iso4217 Currency Code|  | | <a name=\"401\">401</a>|Cannot Assign Instrument Identifier To Currency|  | | <a name=\"402\">402</a>|Cannot Assign Currency Identifier To Non Currency|  | | <a name=\"403\">403</a>|Currency Instrument Cannot Be Deleted|  | | <a name=\"404\">404</a>|Currency Instrument Cannot Have Economic Definition|  | | <a name=\"405\">405</a>|Currency Instrument Cannot Have Lookthrough Portfolio|  | | <a name=\"406\">406</a>|Cannot Create Currency Instrument With Multiple Identifiers|  | | <a name=\"407\">407</a>|Specified Currency Is Undefined|  | | <a name=\"410\">410</a>|Index Does Not Exist|  | | <a name=\"411\">411</a>|Sort Field Does Not Exist|  | | <a name=\"413\">413</a>|Negative Pagination Parameters|  | | <a name=\"414\">414</a>|Invalid Search Syntax|  | | <a name=\"415\">415</a>|Filter Execution Timeout|  | | <a name=\"420\">420</a>|Side Definition Inconsistent|  | | <a name=\"450\">450</a>|Invalid Quote Access Metadata Rule|  | | <a name=\"451\">451</a>|Access Metadata Not Found|  | | <a name=\"452\">452</a>|Invalid Access Metadata Identifier|  | | <a name=\"460\">460</a>|Standard Resource Not Found|  | | <a name=\"461\">461</a>|Standard Resource Conflict|  | | <a name=\"462\">462</a>|Calendar Not Found|  | | <a name=\"463\">463</a>|Date In A Calendar Not Found|  | | <a name=\"464\">464</a>|Invalid Date Source Data|  | | <a name=\"465\">465</a>|Invalid Timezone|  | | <a name=\"601\">601</a>|Person Identifier Already In Use|  | | <a name=\"602\">602</a>|Person Not Found|  | | <a name=\"603\">603</a>|Cannot Set Identifier|  | | <a name=\"617\">617</a>|Invalid Recipe Specification In Request|  | | <a name=\"618\">618</a>|Inline Recipe Deserialisation Failure|  | | <a name=\"619\">619</a>|Identifier Types Not Set For Entity|  | | <a name=\"620\">620</a>|Cannot Delete All Client Defined Identifiers|  | | <a name=\"650\">650</a>|The Order requested was not found.|  | | <a name=\"654\">654</a>|The Allocation requested was not found.|  | | <a name=\"655\">655</a>|Cannot build the fx forward target with the given holdings.|  | | <a name=\"656\">656</a>|Group does not contain expected entities.|  | | <a name=\"665\">665</a>|Destination directory not found|  | | <a name=\"667\">667</a>|Relation definition already exists|  | | <a name=\"672\">672</a>|Could not retrieve file contents|  | | <a name=\"673\">673</a>|Missing entitlements for entities in Group|  | | <a name=\"674\">674</a>|Next Best Action not found|  | | <a name=\"676\">676</a>|Relation definition not defined|  | | <a name=\"677\">677</a>|Invalid entity identifier for relation|  | | <a name=\"681\">681</a>|Sorting by specified field not supported|One or more of the provided fields to order by were either invalid or not supported. | | <a name=\"682\">682</a>|Too many fields to sort by|The number of fields to sort the data by exceeds the number allowed by the endpoint | | <a name=\"684\">684</a>|Sequence Not Found|  | | <a name=\"685\">685</a>|Sequence Already Exists|  | | <a name=\"686\">686</a>|Non-cycling sequence has been exhausted|  | | <a name=\"687\">687</a>|Legal Entity Identifier Already In Use|  | | <a name=\"688\">688</a>|Legal Entity Not Found|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"690\">690</a>|Property Type Is Not Supported|  | | <a name=\"691\">691</a>|Multiple Tax-lots For Currency Type Is Not Supported|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"693\">693</a>|Entity type is not supported for Relationship|  | | <a name=\"694\">694</a>|Relationship Validation Failure|  | | <a name=\"695\">695</a>|Relationship Not Found|  | | <a name=\"697\">697</a>|Derived Property Formula No Longer Valid|  | | <a name=\"698\">698</a>|Story is not available|  | | <a name=\"703\">703</a>|Corporate Action Does Not Exist|  | | <a name=\"720\">720</a>|The provided sort and filter combination is not valid|  | | <a name=\"721\">721</a>|A2B generation failed|  | | <a name=\"722\">722</a>|Aggregated Return Calculation Failure|  | | <a name=\"723\">723</a>|Custom Entity Definition Identifier Already In Use|  | | <a name=\"724\">724</a>|Custom Entity Definition Not Found|  | | <a name=\"725\">725</a>|The Placement requested was not found.|  | | <a name=\"726\">726</a>|The Execution requested was not found.|  | | <a name=\"727\">727</a>|The Block requested was not found.|  | | <a name=\"728\">728</a>|The Participation requested was not found.|  | | <a name=\"729\">729</a>|The Package requested was not found.|  | | <a name=\"730\">730</a>|The OrderInstruction requested was not found.|  | | <a name=\"732\">732</a>|Custom Entity not found.|  | | <a name=\"733\">733</a>|Custom Entity Identifier already in use.|  | | <a name=\"735\">735</a>|Calculation Failed.|  | | <a name=\"736\">736</a>|An expected key on HttpResponse is missing.|  | | <a name=\"737\">737</a>|A required fee detail is missing.|  | | <a name=\"738\">738</a>|Zero rows were returned from Luminesce|  | | <a name=\"739\">739</a>|Provided Weekend Mask was invalid|  | | <a name=\"742\">742</a>|Custom Entity fields do not match the definition|  | | <a name=\"746\">746</a>|The provided sequence is not valid.|  | | <a name=\"751\">751</a>|The type of the Custom Entity is different than the type provided in the definition.|  | | <a name=\"752\">752</a>|Luminesce process returned an error.|  | | <a name=\"753\">753</a>|File name or content incompatible with operation.|  | | <a name=\"755\">755</a>|Schema of response from Drive is not as expected.|  | | <a name=\"757\">757</a>|Schema of response from Luminesce is not as expected.|  | | <a name=\"758\">758</a>|Luminesce timed out.|  | | <a name=\"763\">763</a>|Invalid Lusid Entity Identifier Unit|  | | <a name=\"768\">768</a>|Fee rule not found.|  | | <a name=\"769\">769</a>|Cannot update the base currency of a portfolio with transactions loaded|  | | <a name=\"771\">771</a>|Transaction configuration source not found|  | | <a name=\"774\">774</a>|Compliance rule not found.|  | | <a name=\"775\">775</a>|Fund accounting document cannot be processed.|  | | <a name=\"778\">778</a>|Unable to look up FX rate from trade ccy to portfolio ccy for some of the trades.|  | | <a name=\"782\">782</a>|The Property definition dataType is not matching the derivation formula dataType|  | | <a name=\"783\">783</a>|The Property definition domain is not supported for derived properties|  | | <a name=\"788\">788</a>|Compliance run not found failure.|  | | <a name=\"790\">790</a>|Custom Entity has missing or invalid identifiers|  | | <a name=\"791\">791</a>|Custom Entity definition already exists|  | | <a name=\"792\">792</a>|Compliance PropertyKey is missing.|  | | <a name=\"793\">793</a>|Compliance Criteria Value for matching is missing.|  | | <a name=\"800\">800</a>|Can not upsert an instrument event of this type.|  | | <a name=\"801\">801</a>|The instrument event does not exist.|  | | <a name=\"802\">802</a>|The Instrument event is missing salient information.|  | | <a name=\"803\">803</a>|The Instrument event could not be processed.|  | 
 *
 * The version of the OpenAPI document: 0.11.4555
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
    public interface IPortfolioGroupsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EARLY ACCESS] AddPortfolioToGroup: Add portfolio to group
        /// </summary>
        /// <remarks>
        /// Add a single portfolio to a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        PortfolioGroup AddPortfolioToGroup(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId));

        /// <summary>
        /// [EARLY ACCESS] AddPortfolioToGroup: Add portfolio to group
        /// </summary>
        /// <remarks>
        /// Add a single portfolio to a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        ApiResponse<PortfolioGroup> AddPortfolioToGroupWithHttpInfo(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId));
        /// <summary>
        /// [EARLY ACCESS] AddSubGroupToGroup: Add sub group to group
        /// </summary>
        /// <remarks>
        /// Add a portfolio group to a portfolio group as a sub group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        PortfolioGroup AddSubGroupToGroup(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId));

        /// <summary>
        /// [EARLY ACCESS] AddSubGroupToGroup: Add sub group to group
        /// </summary>
        /// <remarks>
        /// Add a portfolio group to a portfolio group as a sub group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        ApiResponse<PortfolioGroup> AddSubGroupToGroupWithHttpInfo(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId));
        /// <summary>
        /// BuildTransactionsForPortfolioGroup: Build transactions for transaction portfolios in a portfolio group
        /// </summary>
        /// <remarks>
        /// Build transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest               version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>VersionedResourceListOfOutputTransaction</returns>
        VersionedResourceListOfOutputTransaction BuildTransactionsForPortfolioGroup(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string));

        /// <summary>
        /// BuildTransactionsForPortfolioGroup: Build transactions for transaction portfolios in a portfolio group
        /// </summary>
        /// <remarks>
        /// Build transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest               version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfOutputTransaction</returns>
        ApiResponse<VersionedResourceListOfOutputTransaction> BuildTransactionsForPortfolioGroupWithHttpInfo(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string));
        /// <summary>
        /// CreatePortfolioGroup: Create portfolio group
        /// </summary>
        /// <remarks>
        /// Create a portfolio group in a specific scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="createPortfolioGroupRequest">The definition and details of the portfolio group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        PortfolioGroup CreatePortfolioGroup(string scope, CreatePortfolioGroupRequest createPortfolioGroupRequest = default(CreatePortfolioGroupRequest));

        /// <summary>
        /// CreatePortfolioGroup: Create portfolio group
        /// </summary>
        /// <remarks>
        /// Create a portfolio group in a specific scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="createPortfolioGroupRequest">The definition and details of the portfolio group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        ApiResponse<PortfolioGroup> CreatePortfolioGroupWithHttpInfo(string scope, CreatePortfolioGroupRequest createPortfolioGroupRequest = default(CreatePortfolioGroupRequest));
        /// <summary>
        /// [EARLY ACCESS] DeleteGroupProperties: Delete group properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeleteGroupProperties(string scope, string code, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));

        /// <summary>
        /// [EARLY ACCESS] DeleteGroupProperties: Delete group properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeleteGroupPropertiesWithHttpInfo(string scope, string code, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));
        /// <summary>
        /// [EARLY ACCESS] DeleteKeyFromPortfolioGroupAccessMetadata: Delete a Portfolio Group Access Metadata entry
        /// </summary>
        /// <remarks>
        /// Deletes the Portfolio Group Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the Access Metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeleteKeyFromPortfolioGroupAccessMetadata(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] DeleteKeyFromPortfolioGroupAccessMetadata: Delete a Portfolio Group Access Metadata entry
        /// </summary>
        /// <remarks>
        /// Deletes the Portfolio Group Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the Access Metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeleteKeyFromPortfolioGroupAccessMetadataWithHttpInfo(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioFromGroup: Delete portfolio from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        PortfolioGroup DeletePortfolioFromGroup(string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioFromGroup: Delete portfolio from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        ApiResponse<PortfolioGroup> DeletePortfolioFromGroupWithHttpInfo(string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioGroup: Delete portfolio group
        /// </summary>
        /// <remarks>
        /// Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePortfolioGroup(string scope, string code);

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioGroup: Delete portfolio group
        /// </summary>
        /// <remarks>
        /// Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePortfolioGroupWithHttpInfo(string scope, string code);
        /// <summary>
        /// [EARLY ACCESS] DeleteSubGroupFromGroup: Delete sub group from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio group (sub group) from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        PortfolioGroup DeleteSubGroupFromGroup(string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] DeleteSubGroupFromGroup: Delete sub group from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio group (sub group) from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        ApiResponse<PortfolioGroup> DeleteSubGroupFromGroupWithHttpInfo(string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] GetGroupProperties: Get group properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>PortfolioGroupProperties</returns>
        PortfolioGroupProperties GetGroupProperties(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] GetGroupProperties: Get group properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroupProperties</returns>
        ApiResponse<PortfolioGroupProperties> GetGroupPropertiesWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// GetHoldingsForPortfolioGroup: Get holdings for transaction portfolios in portfolio group
        /// </summary>
        /// <remarks>
        /// Get the holdings of transaction portfolios in specified portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of transaction              portfolios in the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of transaction portfolios in the portfolio group. Defaults              to return the latest version of the holdings if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>VersionedResourceListOfPortfolioHolding</returns>
        VersionedResourceListOfPortfolioHolding GetHoldingsForPortfolioGroup(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?));

        /// <summary>
        /// GetHoldingsForPortfolioGroup: Get holdings for transaction portfolios in portfolio group
        /// </summary>
        /// <remarks>
        /// Get the holdings of transaction portfolios in specified portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of transaction              portfolios in the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of transaction portfolios in the portfolio group. Defaults              to return the latest version of the holdings if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfPortfolioHolding</returns>
        ApiResponse<VersionedResourceListOfPortfolioHolding> GetHoldingsForPortfolioGroupWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?));
        /// <summary>
        /// GetPortfolioGroup: Get portfolio group
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        PortfolioGroup GetPortfolioGroup(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// GetPortfolioGroup: Get portfolio group
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        ApiResponse<PortfolioGroup> GetPortfolioGroupWithHttpInfo(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Portfolio Group
        /// </summary>
        /// <remarks>
        /// Get a specific Portfolio Group access metadata by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the access metadata (optional)</param>
        /// <returns>ICollection&lt;AccessMetadataValue&gt;</returns>
        ICollection<AccessMetadataValue> GetPortfolioGroupAccessMetadataByKey(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Portfolio Group
        /// </summary>
        /// <remarks>
        /// Get a specific Portfolio Group access metadata by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the access metadata (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;AccessMetadataValue&gt;</returns>
        ApiResponse<ICollection<AccessMetadataValue>> GetPortfolioGroupAccessMetadataByKeyWithHttpInfo(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// GetPortfolioGroupCommands: Get portfolio group commands
        /// </summary>
        /// <remarks>
        /// Gets all the commands that modified a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the User ID, use \&quot;userId.id eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ResourceListOfProcessedCommand</returns>
        ResourceListOfProcessedCommand GetPortfolioGroupCommands(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string));

        /// <summary>
        /// GetPortfolioGroupCommands: Get portfolio group commands
        /// </summary>
        /// <remarks>
        /// Gets all the commands that modified a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the User ID, use \&quot;userId.id eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfProcessedCommand</returns>
        ApiResponse<ResourceListOfProcessedCommand> GetPortfolioGroupCommandsWithHttpInfo(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupExpansion: Get portfolio group expansion
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ExpandedGroup</returns>
        ExpandedGroup GetPortfolioGroupExpansion(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupExpansion: Get portfolio group expansion
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ApiResponse of ExpandedGroup</returns>
        ApiResponse<ExpandedGroup> GetPortfolioGroupExpansionWithHttpInfo(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupMetadata: Get Access Metadata rules for Portfolio Group
        /// </summary>
        /// <remarks>
        /// Pass the scope and Portfolio Group code parameters to retrieve the associated Access Metadata
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <returns>Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        Dictionary<string, List<AccessMetadataValue>> GetPortfolioGroupMetadata(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupMetadata: Get Access Metadata rules for Portfolio Group
        /// </summary>
        /// <remarks>
        /// Pass the scope and Portfolio Group code parameters to retrieve the associated Access Metadata
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        ApiResponse<Dictionary<string, List<AccessMetadataValue>>> GetPortfolioGroupMetadataWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupPropertyTimeSeries: Get the time series of a portfolio group property
        /// </summary>
        /// <remarks>
        /// List the complete time series of a portfolio group property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group.</param>
        /// <param name="code">The code of the group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;.              Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="portfolioGroupEffectiveAt">The effective datetime used to resolve the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio group&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>ResourceListOfPropertyInterval</returns>
        ResourceListOfPropertyInterval GetPortfolioGroupPropertyTimeSeries(string scope, string code, string propertyKey, string portfolioGroupEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupPropertyTimeSeries: Get the time series of a portfolio group property
        /// </summary>
        /// <remarks>
        /// List the complete time series of a portfolio group property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group.</param>
        /// <param name="code">The code of the group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;.              Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="portfolioGroupEffectiveAt">The effective datetime used to resolve the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio group&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPropertyInterval</returns>
        ApiResponse<ResourceListOfPropertyInterval> GetPortfolioGroupPropertyTimeSeriesWithHttpInfo(string scope, string code, string propertyKey, string portfolioGroupEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?));
        /// <summary>
        /// GetTransactionsForPortfolioGroup: Get transactions for transaction portfolios in a portfolio group
        /// </summary>
        /// <remarks>
        /// Get transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve the transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the transactions. Defaults to return the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <returns>VersionedResourceListOfTransaction</returns>
        VersionedResourceListOfTransaction GetTransactionsForPortfolioGroup(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), bool? showCancelledTransactions = default(bool?));

        /// <summary>
        /// GetTransactionsForPortfolioGroup: Get transactions for transaction portfolios in a portfolio group
        /// </summary>
        /// <remarks>
        /// Get transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve the transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the transactions. Defaults to return the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfTransaction</returns>
        ApiResponse<VersionedResourceListOfTransaction> GetTransactionsForPortfolioGroupWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), bool? showCancelledTransactions = default(bool?));
        /// <summary>
        /// [EARLY ACCESS] ListPortfolioGroups: List portfolio groups
        /// </summary>
        /// <remarks>
        /// List all the portfolio groups in a single scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ResourceListOfPortfolioGroup</returns>
        ResourceListOfPortfolioGroup ListPortfolioGroups(string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string));

        /// <summary>
        /// [EARLY ACCESS] ListPortfolioGroups: List portfolio groups
        /// </summary>
        /// <remarks>
        /// List all the portfolio groups in a single scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolioGroup</returns>
        ApiResponse<ResourceListOfPortfolioGroup> ListPortfolioGroupsWithHttpInfo(string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string));
        /// <summary>
        /// [EARLY ACCESS] UpdatePortfolioGroup: Update portfolio group
        /// </summary>
        /// <remarks>
        /// Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition. (optional)</param>
        /// <param name="updatePortfolioGroupRequest">The updated portfolio group definition. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        PortfolioGroup UpdatePortfolioGroup(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), UpdatePortfolioGroupRequest updatePortfolioGroupRequest = default(UpdatePortfolioGroupRequest));

        /// <summary>
        /// [EARLY ACCESS] UpdatePortfolioGroup: Update portfolio group
        /// </summary>
        /// <remarks>
        /// Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition. (optional)</param>
        /// <param name="updatePortfolioGroupRequest">The updated portfolio group definition. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        ApiResponse<PortfolioGroup> UpdatePortfolioGroupWithHttpInfo(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), UpdatePortfolioGroupRequest updatePortfolioGroupRequest = default(UpdatePortfolioGroupRequest));
        /// <summary>
        /// [EARLY ACCESS] UpsertGroupProperties: Upsert group properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.                Upserting a property that exists for a group, with a null value, will delete the instance of the property for that group.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime for which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The properties to be updated or inserted onto the group. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <returns>PortfolioGroupProperties</returns>
        PortfolioGroupProperties UpsertGroupProperties(string scope, string code, Dictionary<string, Property> requestBody = default(Dictionary<string, Property>));

        /// <summary>
        /// [EARLY ACCESS] UpsertGroupProperties: Upsert group properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.                Upserting a property that exists for a group, with a null value, will delete the instance of the property for that group.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime for which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The properties to be updated or inserted onto the group. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroupProperties</returns>
        ApiResponse<PortfolioGroupProperties> UpsertGroupPropertiesWithHttpInfo(string scope, string code, Dictionary<string, Property> requestBody = default(Dictionary<string, Property>));
        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioGroupAccessMetadata: Upsert a Portfolio Group Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Portfolio Group Access Metadata Entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Portfolio Group Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the access metadata entry to upsert</param>
        /// <param name="upsertPortfolioGroupAccessMetadataRequest">The Portfolio Group Access Metadata rule to upsert</param>
        /// <param name="effectiveAt">The date this rule will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>ResourceListOfAccessMetadataValueOf</returns>
        ResourceListOfAccessMetadataValueOf UpsertPortfolioGroupAccessMetadata(string scope, string code, string metadataKey, UpsertPortfolioGroupAccessMetadataRequest upsertPortfolioGroupAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioGroupAccessMetadata: Upsert a Portfolio Group Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Portfolio Group Access Metadata Entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Portfolio Group Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the access metadata entry to upsert</param>
        /// <param name="upsertPortfolioGroupAccessMetadataRequest">The Portfolio Group Access Metadata rule to upsert</param>
        /// <param name="effectiveAt">The date this rule will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of ResourceListOfAccessMetadataValueOf</returns>
        ApiResponse<ResourceListOfAccessMetadataValueOf> UpsertPortfolioGroupAccessMetadataWithHttpInfo(string scope, string code, string metadataKey, UpsertPortfolioGroupAccessMetadataRequest upsertPortfolioGroupAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPortfolioGroupsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] AddPortfolioToGroup: Add portfolio to group
        /// </summary>
        /// <remarks>
        /// Add a single portfolio to a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroup</returns>
        System.Threading.Tasks.Task<PortfolioGroup> AddPortfolioToGroupAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] AddPortfolioToGroup: Add portfolio to group
        /// </summary>
        /// <remarks>
        /// Add a single portfolio to a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroup>> AddPortfolioToGroupWithHttpInfoAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] AddSubGroupToGroup: Add sub group to group
        /// </summary>
        /// <remarks>
        /// Add a portfolio group to a portfolio group as a sub group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroup</returns>
        System.Threading.Tasks.Task<PortfolioGroup> AddSubGroupToGroupAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] AddSubGroupToGroup: Add sub group to group
        /// </summary>
        /// <remarks>
        /// Add a portfolio group to a portfolio group as a sub group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroup>> AddSubGroupToGroupWithHttpInfoAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// BuildTransactionsForPortfolioGroup: Build transactions for transaction portfolios in a portfolio group
        /// </summary>
        /// <remarks>
        /// Build transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest               version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfOutputTransaction</returns>
        System.Threading.Tasks.Task<VersionedResourceListOfOutputTransaction> BuildTransactionsForPortfolioGroupAsync(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// BuildTransactionsForPortfolioGroup: Build transactions for transaction portfolios in a portfolio group
        /// </summary>
        /// <remarks>
        /// Build transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest               version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfOutputTransaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfOutputTransaction>> BuildTransactionsForPortfolioGroupWithHttpInfoAsync(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// CreatePortfolioGroup: Create portfolio group
        /// </summary>
        /// <remarks>
        /// Create a portfolio group in a specific scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="createPortfolioGroupRequest">The definition and details of the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroup</returns>
        System.Threading.Tasks.Task<PortfolioGroup> CreatePortfolioGroupAsync(string scope, CreatePortfolioGroupRequest createPortfolioGroupRequest = default(CreatePortfolioGroupRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// CreatePortfolioGroup: Create portfolio group
        /// </summary>
        /// <remarks>
        /// Create a portfolio group in a specific scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="createPortfolioGroupRequest">The definition and details of the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroup>> CreatePortfolioGroupWithHttpInfoAsync(string scope, CreatePortfolioGroupRequest createPortfolioGroupRequest = default(CreatePortfolioGroupRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] DeleteGroupProperties: Delete group properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeleteGroupPropertiesAsync(string scope, string code, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeleteGroupProperties: Delete group properties
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeleteGroupPropertiesWithHttpInfoAsync(string scope, string code, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] DeleteKeyFromPortfolioGroupAccessMetadata: Delete a Portfolio Group Access Metadata entry
        /// </summary>
        /// <remarks>
        /// Deletes the Portfolio Group Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the Access Metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeleteKeyFromPortfolioGroupAccessMetadataAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeleteKeyFromPortfolioGroupAccessMetadata: Delete a Portfolio Group Access Metadata entry
        /// </summary>
        /// <remarks>
        /// Deletes the Portfolio Group Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the Access Metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeleteKeyFromPortfolioGroupAccessMetadataWithHttpInfoAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioFromGroup: Delete portfolio from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroup</returns>
        System.Threading.Tasks.Task<PortfolioGroup> DeletePortfolioFromGroupAsync(string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioFromGroup: Delete portfolio from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroup>> DeletePortfolioFromGroupWithHttpInfoAsync(string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioGroup: Delete portfolio group
        /// </summary>
        /// <remarks>
        /// Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioGroupAsync(string scope, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioGroup: Delete portfolio group
        /// </summary>
        /// <remarks>
        /// Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePortfolioGroupWithHttpInfoAsync(string scope, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] DeleteSubGroupFromGroup: Delete sub group from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio group (sub group) from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroup</returns>
        System.Threading.Tasks.Task<PortfolioGroup> DeleteSubGroupFromGroupAsync(string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeleteSubGroupFromGroup: Delete sub group from group
        /// </summary>
        /// <remarks>
        /// Remove a single portfolio group (sub group) from a portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroup>> DeleteSubGroupFromGroupWithHttpInfoAsync(string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetGroupProperties: Get group properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroupProperties</returns>
        System.Threading.Tasks.Task<PortfolioGroupProperties> GetGroupPropertiesAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetGroupProperties: Get group properties
        /// </summary>
        /// <remarks>
        /// List all the properties of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroupProperties)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroupProperties>> GetGroupPropertiesWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetHoldingsForPortfolioGroup: Get holdings for transaction portfolios in portfolio group
        /// </summary>
        /// <remarks>
        /// Get the holdings of transaction portfolios in specified portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of transaction              portfolios in the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of transaction portfolios in the portfolio group. Defaults              to return the latest version of the holdings if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfPortfolioHolding</returns>
        System.Threading.Tasks.Task<VersionedResourceListOfPortfolioHolding> GetHoldingsForPortfolioGroupAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetHoldingsForPortfolioGroup: Get holdings for transaction portfolios in portfolio group
        /// </summary>
        /// <remarks>
        /// Get the holdings of transaction portfolios in specified portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of transaction              portfolios in the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of transaction portfolios in the portfolio group. Defaults              to return the latest version of the holdings if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfPortfolioHolding)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfPortfolioHolding>> GetHoldingsForPortfolioGroupWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetPortfolioGroup: Get portfolio group
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroup</returns>
        System.Threading.Tasks.Task<PortfolioGroup> GetPortfolioGroupAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetPortfolioGroup: Get portfolio group
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroup>> GetPortfolioGroupWithHttpInfoAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Portfolio Group
        /// </summary>
        /// <remarks>
        /// Get a specific Portfolio Group access metadata by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the access metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;AccessMetadataValue&gt;</returns>
        System.Threading.Tasks.Task<ICollection<AccessMetadataValue>> GetPortfolioGroupAccessMetadataByKeyAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Portfolio Group
        /// </summary>
        /// <remarks>
        /// Get a specific Portfolio Group access metadata by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the access metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;AccessMetadataValue&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<AccessMetadataValue>>> GetPortfolioGroupAccessMetadataByKeyWithHttpInfoAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetPortfolioGroupCommands: Get portfolio group commands
        /// </summary>
        /// <remarks>
        /// Gets all the commands that modified a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the User ID, use \&quot;userId.id eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfProcessedCommand</returns>
        System.Threading.Tasks.Task<ResourceListOfProcessedCommand> GetPortfolioGroupCommandsAsync(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetPortfolioGroupCommands: Get portfolio group commands
        /// </summary>
        /// <remarks>
        /// Gets all the commands that modified a single portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the User ID, use \&quot;userId.id eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfProcessedCommand)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfProcessedCommand>> GetPortfolioGroupCommandsWithHttpInfoAsync(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupExpansion: Get portfolio group expansion
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExpandedGroup</returns>
        System.Threading.Tasks.Task<ExpandedGroup> GetPortfolioGroupExpansionAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupExpansion: Get portfolio group expansion
        /// </summary>
        /// <remarks>
        /// List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExpandedGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExpandedGroup>> GetPortfolioGroupExpansionWithHttpInfoAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupMetadata: Get Access Metadata rules for Portfolio Group
        /// </summary>
        /// <remarks>
        /// Pass the scope and Portfolio Group code parameters to retrieve the associated Access Metadata
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, List<AccessMetadataValue>>> GetPortfolioGroupMetadataAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupMetadata: Get Access Metadata rules for Portfolio Group
        /// </summary>
        /// <remarks>
        /// Pass the scope and Portfolio Group code parameters to retrieve the associated Access Metadata
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, List<AccessMetadataValue>>>> GetPortfolioGroupMetadataWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupPropertyTimeSeries: Get the time series of a portfolio group property
        /// </summary>
        /// <remarks>
        /// List the complete time series of a portfolio group property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group.</param>
        /// <param name="code">The code of the group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;.              Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="portfolioGroupEffectiveAt">The effective datetime used to resolve the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio group&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPropertyInterval</returns>
        System.Threading.Tasks.Task<ResourceListOfPropertyInterval> GetPortfolioGroupPropertyTimeSeriesAsync(string scope, string code, string propertyKey, string portfolioGroupEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupPropertyTimeSeries: Get the time series of a portfolio group property
        /// </summary>
        /// <remarks>
        /// List the complete time series of a portfolio group property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group.</param>
        /// <param name="code">The code of the group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;.              Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="portfolioGroupEffectiveAt">The effective datetime used to resolve the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio group&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPropertyInterval)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPropertyInterval>> GetPortfolioGroupPropertyTimeSeriesWithHttpInfoAsync(string scope, string code, string propertyKey, string portfolioGroupEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetTransactionsForPortfolioGroup: Get transactions for transaction portfolios in a portfolio group
        /// </summary>
        /// <remarks>
        /// Get transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve the transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the transactions. Defaults to return the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfTransaction</returns>
        System.Threading.Tasks.Task<VersionedResourceListOfTransaction> GetTransactionsForPortfolioGroupAsync(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), bool? showCancelledTransactions = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetTransactionsForPortfolioGroup: Get transactions for transaction portfolios in a portfolio group
        /// </summary>
        /// <remarks>
        /// Get transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve the transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the transactions. Defaults to return the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfTransaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfTransaction>> GetTransactionsForPortfolioGroupWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), bool? showCancelledTransactions = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] ListPortfolioGroups: List portfolio groups
        /// </summary>
        /// <remarks>
        /// List all the portfolio groups in a single scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPortfolioGroup</returns>
        System.Threading.Tasks.Task<ResourceListOfPortfolioGroup> ListPortfolioGroupsAsync(string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] ListPortfolioGroups: List portfolio groups
        /// </summary>
        /// <remarks>
        /// List all the portfolio groups in a single scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolioGroup>> ListPortfolioGroupsWithHttpInfoAsync(string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] UpdatePortfolioGroup: Update portfolio group
        /// </summary>
        /// <remarks>
        /// Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition. (optional)</param>
        /// <param name="updatePortfolioGroupRequest">The updated portfolio group definition. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroup</returns>
        System.Threading.Tasks.Task<PortfolioGroup> UpdatePortfolioGroupAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), UpdatePortfolioGroupRequest updatePortfolioGroupRequest = default(UpdatePortfolioGroupRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] UpdatePortfolioGroup: Update portfolio group
        /// </summary>
        /// <remarks>
        /// Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition. (optional)</param>
        /// <param name="updatePortfolioGroupRequest">The updated portfolio group definition. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroup>> UpdatePortfolioGroupWithHttpInfoAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), UpdatePortfolioGroupRequest updatePortfolioGroupRequest = default(UpdatePortfolioGroupRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] UpsertGroupProperties: Upsert group properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.                Upserting a property that exists for a group, with a null value, will delete the instance of the property for that group.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime for which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The properties to be updated or inserted onto the group. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroupProperties</returns>
        System.Threading.Tasks.Task<PortfolioGroupProperties> UpsertGroupPropertiesAsync(string scope, string code, Dictionary<string, Property> requestBody = default(Dictionary<string, Property>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] UpsertGroupProperties: Upsert group properties
        /// </summary>
        /// <remarks>
        /// Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.                Upserting a property that exists for a group, with a null value, will delete the instance of the property for that group.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime for which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The properties to be updated or inserted onto the group. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroupProperties)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioGroupProperties>> UpsertGroupPropertiesWithHttpInfoAsync(string scope, string code, Dictionary<string, Property> requestBody = default(Dictionary<string, Property>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioGroupAccessMetadata: Upsert a Portfolio Group Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Portfolio Group Access Metadata Entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Portfolio Group Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the access metadata entry to upsert</param>
        /// <param name="upsertPortfolioGroupAccessMetadataRequest">The Portfolio Group Access Metadata rule to upsert</param>
        /// <param name="effectiveAt">The date this rule will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfAccessMetadataValueOf</returns>
        System.Threading.Tasks.Task<ResourceListOfAccessMetadataValueOf> UpsertPortfolioGroupAccessMetadataAsync(string scope, string code, string metadataKey, UpsertPortfolioGroupAccessMetadataRequest upsertPortfolioGroupAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioGroupAccessMetadata: Upsert a Portfolio Group Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Portfolio Group Access Metadata Entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Portfolio Group Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the access metadata entry to upsert</param>
        /// <param name="upsertPortfolioGroupAccessMetadataRequest">The Portfolio Group Access Metadata rule to upsert</param>
        /// <param name="effectiveAt">The date this rule will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfAccessMetadataValueOf)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfAccessMetadataValueOf>> UpsertPortfolioGroupAccessMetadataWithHttpInfoAsync(string scope, string code, string metadataKey, UpsertPortfolioGroupAccessMetadataRequest upsertPortfolioGroupAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPortfolioGroupsApi : IPortfolioGroupsApiSync, IPortfolioGroupsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PortfolioGroupsApi : IPortfolioGroupsApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioGroupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PortfolioGroupsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioGroupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PortfolioGroupsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="PortfolioGroupsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PortfolioGroupsApi(Lusid.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioGroupsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PortfolioGroupsApi(Lusid.Sdk.Client.ISynchronousClient client, Lusid.Sdk.Client.IAsynchronousClient asyncClient, Lusid.Sdk.Client.IReadableConfiguration configuration)
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
        /// [EARLY ACCESS] AddPortfolioToGroup: Add portfolio to group Add a single portfolio to a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        public PortfolioGroup AddPortfolioToGroup(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = AddPortfolioToGroupWithHttpInfo(scope, code, effectiveAt, resourceId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] AddPortfolioToGroup: Add portfolio to group Add a single portfolio to a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse<PortfolioGroup> AddPortfolioToGroupWithHttpInfo(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->AddPortfolioToGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->AddPortfolioToGroup");

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
            localVarRequestOptions.Data = resourceId;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Post<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}/portfolios", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddPortfolioToGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] AddPortfolioToGroup: Add portfolio to group Add a single portfolio to a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroup</returns>
        public async System.Threading.Tasks.Task<PortfolioGroup> AddPortfolioToGroupAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = await AddPortfolioToGroupWithHttpInfoAsync(scope, code, effectiveAt, resourceId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] AddPortfolioToGroup: Add portfolio to group Add a single portfolio to a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio to add to the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroup>> AddPortfolioToGroupWithHttpInfoAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->AddPortfolioToGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->AddPortfolioToGroup");


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
            localVarRequestOptions.Data = resourceId;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}/portfolios", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddPortfolioToGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] AddSubGroupToGroup: Add sub group to group Add a portfolio group to a portfolio group as a sub group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        public PortfolioGroup AddSubGroupToGroup(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = AddSubGroupToGroupWithHttpInfo(scope, code, effectiveAt, resourceId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] AddSubGroupToGroup: Add sub group to group Add a portfolio group to a portfolio group as a sub group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse<PortfolioGroup> AddSubGroupToGroupWithHttpInfo(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->AddSubGroupToGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->AddSubGroupToGroup");

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
            localVarRequestOptions.Data = resourceId;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Post<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}/subgroups", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddSubGroupToGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] AddSubGroupToGroup: Add sub group to group Add a portfolio group to a portfolio group as a sub group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroup</returns>
        public async System.Threading.Tasks.Task<PortfolioGroup> AddSubGroupToGroupAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = await AddSubGroupToGroupWithHttpInfoAsync(scope, code, effectiveAt, resourceId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] AddSubGroupToGroup: Add sub group to group Add a portfolio group to a portfolio group as a sub group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to add a portfolio group to.</param>
        /// <param name="code">The code of the portfolio group to add a portfolio group to. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be added to the group. (optional)</param>
        /// <param name="resourceId">The resource identifier of the portfolio group to add to the portfolio group as a sub group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroup>> AddSubGroupToGroupWithHttpInfoAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), ResourceId resourceId = default(ResourceId), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->AddSubGroupToGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->AddSubGroupToGroup");


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
            localVarRequestOptions.Data = resourceId;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}/subgroups", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddSubGroupToGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// BuildTransactionsForPortfolioGroup: Build transactions for transaction portfolios in a portfolio group Build transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest               version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>VersionedResourceListOfOutputTransaction</returns>
        public VersionedResourceListOfOutputTransaction BuildTransactionsForPortfolioGroup(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfOutputTransaction> localVarResponse = BuildTransactionsForPortfolioGroupWithHttpInfo(scope, code, transactionQueryParameters, asAt, filter, propertyKeys, limit, page);
            return localVarResponse.Data;
        }

        /// <summary>
        /// BuildTransactionsForPortfolioGroup: Build transactions for transaction portfolios in a portfolio group Build transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest               version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfOutputTransaction</returns>
        public Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfOutputTransaction> BuildTransactionsForPortfolioGroupWithHttpInfo(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->BuildTransactionsForPortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->BuildTransactionsForPortfolioGroup");

            // verify the required parameter 'transactionQueryParameters' is set
            if (transactionQueryParameters == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'transactionQueryParameters' when calling PortfolioGroupsApi->BuildTransactionsForPortfolioGroup");

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
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            localVarRequestOptions.Data = transactionQueryParameters;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Post<VersionedResourceListOfOutputTransaction>("/api/portfoliogroups/{scope}/{code}/transactions/$build", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BuildTransactionsForPortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// BuildTransactionsForPortfolioGroup: Build transactions for transaction portfolios in a portfolio group Build transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest               version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfOutputTransaction</returns>
        public async System.Threading.Tasks.Task<VersionedResourceListOfOutputTransaction> BuildTransactionsForPortfolioGroupAsync(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfOutputTransaction> localVarResponse = await BuildTransactionsForPortfolioGroupWithHttpInfoAsync(scope, code, transactionQueryParameters, asAt, filter, propertyKeys, limit, page, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// BuildTransactionsForPortfolioGroup: Build transactions for transaction portfolios in a portfolio group Build transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest               version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfOutputTransaction)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfOutputTransaction>> BuildTransactionsForPortfolioGroupWithHttpInfoAsync(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->BuildTransactionsForPortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->BuildTransactionsForPortfolioGroup");

            // verify the required parameter 'transactionQueryParameters' is set
            if (transactionQueryParameters == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'transactionQueryParameters' when calling PortfolioGroupsApi->BuildTransactionsForPortfolioGroup");


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
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            localVarRequestOptions.Data = transactionQueryParameters;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<VersionedResourceListOfOutputTransaction>("/api/portfoliogroups/{scope}/{code}/transactions/$build", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BuildTransactionsForPortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// CreatePortfolioGroup: Create portfolio group Create a portfolio group in a specific scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="createPortfolioGroupRequest">The definition and details of the portfolio group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        public PortfolioGroup CreatePortfolioGroup(string scope, CreatePortfolioGroupRequest createPortfolioGroupRequest = default(CreatePortfolioGroupRequest))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = CreatePortfolioGroupWithHttpInfo(scope, createPortfolioGroupRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// CreatePortfolioGroup: Create portfolio group Create a portfolio group in a specific scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="createPortfolioGroupRequest">The definition and details of the portfolio group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse<PortfolioGroup> CreatePortfolioGroupWithHttpInfo(string scope, CreatePortfolioGroupRequest createPortfolioGroupRequest = default(CreatePortfolioGroupRequest))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->CreatePortfolioGroup");

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
            localVarRequestOptions.Data = createPortfolioGroupRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Post<PortfolioGroup>("/api/portfoliogroups/{scope}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreatePortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// CreatePortfolioGroup: Create portfolio group Create a portfolio group in a specific scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="createPortfolioGroupRequest">The definition and details of the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroup</returns>
        public async System.Threading.Tasks.Task<PortfolioGroup> CreatePortfolioGroupAsync(string scope, CreatePortfolioGroupRequest createPortfolioGroupRequest = default(CreatePortfolioGroupRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = await CreatePortfolioGroupWithHttpInfoAsync(scope, createPortfolioGroupRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// CreatePortfolioGroup: Create portfolio group Create a portfolio group in a specific scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope that the portfolio group will be created in.</param>
        /// <param name="createPortfolioGroupRequest">The definition and details of the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroup>> CreatePortfolioGroupWithHttpInfoAsync(string scope, CreatePortfolioGroupRequest createPortfolioGroupRequest = default(CreatePortfolioGroupRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->CreatePortfolioGroup");


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
            localVarRequestOptions.Data = createPortfolioGroupRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<PortfolioGroup>("/api/portfoliogroups/{scope}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreatePortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteGroupProperties: Delete group properties Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeleteGroupProperties(string scope, string code, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeleteGroupPropertiesWithHttpInfo(scope, code, requestBody, effectiveAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteGroupProperties: Delete group properties Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> DeleteGroupPropertiesWithHttpInfo(string scope, string code, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeleteGroupProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeleteGroupProperties");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling PortfolioGroupsApi->DeleteGroupProperties");

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
            localVarRequestOptions.Data = requestBody;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Post<DeletedEntityResponse>("/api/portfoliogroups/{scope}/{code}/properties/$delete", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteGroupProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteGroupProperties: Delete group properties Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeleteGroupPropertiesAsync(string scope, string code, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeleteGroupPropertiesWithHttpInfoAsync(scope, code, requestBody, effectiveAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteGroupProperties: Delete group properties Delete one or more properties from a single portfolio group. If the properties are time variant then an effective date time from which the properties  will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to delete properties from.</param>
        /// <param name="code">The code of the group to delete properties from. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeleteGroupPropertiesWithHttpInfoAsync(string scope, string code, List<string> requestBody, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeleteGroupProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeleteGroupProperties");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling PortfolioGroupsApi->DeleteGroupProperties");


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
            localVarRequestOptions.Data = requestBody;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<DeletedEntityResponse>("/api/portfoliogroups/{scope}/{code}/properties/$delete", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteGroupProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteKeyFromPortfolioGroupAccessMetadata: Delete a Portfolio Group Access Metadata entry Deletes the Portfolio Group Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the Access Metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeleteKeyFromPortfolioGroupAccessMetadata(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeleteKeyFromPortfolioGroupAccessMetadataWithHttpInfo(scope, code, metadataKey, effectiveAt, effectiveUntil);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteKeyFromPortfolioGroupAccessMetadata: Delete a Portfolio Group Access Metadata entry Deletes the Portfolio Group Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the Access Metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> DeleteKeyFromPortfolioGroupAccessMetadataWithHttpInfo(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeleteKeyFromPortfolioGroupAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeleteKeyFromPortfolioGroupAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PortfolioGroupsApi->DeleteKeyFromPortfolioGroupAccessMetadata");

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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeletedEntityResponse>("/api/portfoliogroups/{scope}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteKeyFromPortfolioGroupAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteKeyFromPortfolioGroupAccessMetadata: Delete a Portfolio Group Access Metadata entry Deletes the Portfolio Group Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the Access Metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeleteKeyFromPortfolioGroupAccessMetadataAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeleteKeyFromPortfolioGroupAccessMetadataWithHttpInfoAsync(scope, code, metadataKey, effectiveAt, effectiveUntil, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteKeyFromPortfolioGroupAccessMetadata: Delete a Portfolio Group Access Metadata entry Deletes the Portfolio Group Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the Access Metadata entry to delete</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeleteKeyFromPortfolioGroupAccessMetadataWithHttpInfoAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeleteKeyFromPortfolioGroupAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeleteKeyFromPortfolioGroupAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PortfolioGroupsApi->DeleteKeyFromPortfolioGroupAccessMetadata");


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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/portfoliogroups/{scope}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteKeyFromPortfolioGroupAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioFromGroup: Delete portfolio from group Remove a single portfolio from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        public PortfolioGroup DeletePortfolioFromGroup(string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = DeletePortfolioFromGroupWithHttpInfo(scope, code, portfolioScope, portfolioCode, effectiveAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioFromGroup: Delete portfolio from group Remove a single portfolio from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse<PortfolioGroup> DeletePortfolioFromGroupWithHttpInfo(string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

            // verify the required parameter 'portfolioScope' is set
            if (portfolioScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'portfolioScope' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

            // verify the required parameter 'portfolioCode' is set
            if (portfolioCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'portfolioCode' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

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
            localVarRequestOptions.PathParameters.Add("portfolioScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(portfolioScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("portfolioCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(portfolioCode)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}/portfolios/{portfolioScope}/{portfolioCode}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePortfolioFromGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioFromGroup: Delete portfolio from group Remove a single portfolio from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroup</returns>
        public async System.Threading.Tasks.Task<PortfolioGroup> DeletePortfolioFromGroupAsync(string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = await DeletePortfolioFromGroupWithHttpInfoAsync(scope, code, portfolioScope, portfolioCode, effectiveAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioFromGroup: Delete portfolio from group Remove a single portfolio from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the portfolio from.</param>
        /// <param name="code">The code of the portfolio group to remove the portfolio from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="portfolioScope">The scope of the portfolio being removed from the portfolio group.</param>
        /// <param name="portfolioCode">The code of the portfolio being removed from the portfolio group. Together with the scope this uniquely identifies the portfolio to remove.</param>
        /// <param name="effectiveAt">The effective datetime from which the portfolio will be removed from the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroup>> DeletePortfolioFromGroupWithHttpInfoAsync(string scope, string code, string portfolioScope, string portfolioCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

            // verify the required parameter 'portfolioScope' is set
            if (portfolioScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'portfolioScope' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");

            // verify the required parameter 'portfolioCode' is set
            if (portfolioCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'portfolioCode' when calling PortfolioGroupsApi->DeletePortfolioFromGroup");


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
            localVarRequestOptions.PathParameters.Add("portfolioScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(portfolioScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("portfolioCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(portfolioCode)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}/portfolios/{portfolioScope}/{portfolioCode}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePortfolioFromGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioGroup: Delete portfolio group Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePortfolioGroup(string scope, string code)
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeletePortfolioGroupWithHttpInfo(scope, code);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioGroup: Delete portfolio group Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> DeletePortfolioGroupWithHttpInfo(string scope, string code)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeletePortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeletePortfolioGroup");

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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeletedEntityResponse>("/api/portfoliogroups/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioGroup: Delete portfolio group Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePortfolioGroupAsync(string scope, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePortfolioGroupWithHttpInfoAsync(scope, code, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePortfolioGroup: Delete portfolio group Delete a single portfolio group. A portfolio group can be deleted while it still contains portfolios or sub groups.  In this case any portfolios or sub groups contained in this group will not be deleted, however they will no longer be grouped together by this portfolio group.  The deletion will be valid from the portfolio group&#39;s creation datetime, ie. the portfolio group will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to delete.</param>
        /// <param name="code">The code of the portfolio group to delete. Together with the scope this uniquely identifies the portfolio group to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeletePortfolioGroupWithHttpInfoAsync(string scope, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeletePortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeletePortfolioGroup");


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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/portfoliogroups/{scope}/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteSubGroupFromGroup: Delete sub group from group Remove a single portfolio group (sub group) from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        public PortfolioGroup DeleteSubGroupFromGroup(string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = DeleteSubGroupFromGroupWithHttpInfo(scope, code, subgroupScope, subgroupCode, effectiveAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteSubGroupFromGroup: Delete sub group from group Remove a single portfolio group (sub group) from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse<PortfolioGroup> DeleteSubGroupFromGroupWithHttpInfo(string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

            // verify the required parameter 'subgroupScope' is set
            if (subgroupScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'subgroupScope' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

            // verify the required parameter 'subgroupCode' is set
            if (subgroupCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'subgroupCode' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

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
            localVarRequestOptions.PathParameters.Add("subgroupScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(subgroupScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("subgroupCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(subgroupCode)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}/subgroups/{subgroupScope}/{subgroupCode}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteSubGroupFromGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteSubGroupFromGroup: Delete sub group from group Remove a single portfolio group (sub group) from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroup</returns>
        public async System.Threading.Tasks.Task<PortfolioGroup> DeleteSubGroupFromGroupAsync(string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = await DeleteSubGroupFromGroupWithHttpInfoAsync(scope, code, subgroupScope, subgroupCode, effectiveAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteSubGroupFromGroup: Delete sub group from group Remove a single portfolio group (sub group) from a portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to remove the sub group from.</param>
        /// <param name="code">The code of the portfolio group to remove the sub group from. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="subgroupScope">The scope of the sub group to remove from the portfolio group.</param>
        /// <param name="subgroupCode">The code of the sub group to remove from the portfolio group. Together with the scope this uniquely identifies the sub group.</param>
        /// <param name="effectiveAt">The effective datetime from which the sub group will be removed from the portfolio group. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroup>> DeleteSubGroupFromGroupWithHttpInfoAsync(string scope, string code, string subgroupScope, string subgroupCode, DateTimeOffset? effectiveAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

            // verify the required parameter 'subgroupScope' is set
            if (subgroupScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'subgroupScope' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");

            // verify the required parameter 'subgroupCode' is set
            if (subgroupCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'subgroupCode' when calling PortfolioGroupsApi->DeleteSubGroupFromGroup");


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
            localVarRequestOptions.PathParameters.Add("subgroupScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(subgroupScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("subgroupCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(subgroupCode)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}/subgroups/{subgroupScope}/{subgroupCode}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteSubGroupFromGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetGroupProperties: Get group properties List all the properties of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>PortfolioGroupProperties</returns>
        public PortfolioGroupProperties GetGroupProperties(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroupProperties> localVarResponse = GetGroupPropertiesWithHttpInfo(scope, code, effectiveAt, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetGroupProperties: Get group properties List all the properties of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroupProperties</returns>
        public Lusid.Sdk.Client.ApiResponse<PortfolioGroupProperties> GetGroupPropertiesWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetGroupProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetGroupProperties");

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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Get<PortfolioGroupProperties>("/api/portfoliogroups/{scope}/{code}/properties", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetGroupProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetGroupProperties: Get group properties List all the properties of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroupProperties</returns>
        public async System.Threading.Tasks.Task<PortfolioGroupProperties> GetGroupPropertiesAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroupProperties> localVarResponse = await GetGroupPropertiesWithHttpInfoAsync(scope, code, effectiveAt, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetGroupProperties: Get group properties List all the properties of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to list the properties for.</param>
        /// <param name="code">The code of the group to list the properties for. Together with the scope this uniquely identifies the group.</param>
        /// <param name="effectiveAt">The effective date time or cut label at which to list the group&#39;s properties. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt date time at which to list the group&#39;s properties. Defaults to return the latest version of each property if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroupProperties)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroupProperties>> GetGroupPropertiesWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetGroupProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetGroupProperties");


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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PortfolioGroupProperties>("/api/portfoliogroups/{scope}/{code}/properties", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetGroupProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetHoldingsForPortfolioGroup: Get holdings for transaction portfolios in portfolio group Get the holdings of transaction portfolios in specified portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of transaction              portfolios in the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of transaction portfolios in the portfolio group. Defaults              to return the latest version of the holdings if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>VersionedResourceListOfPortfolioHolding</returns>
        public VersionedResourceListOfPortfolioHolding GetHoldingsForPortfolioGroup(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfPortfolioHolding> localVarResponse = GetHoldingsForPortfolioGroupWithHttpInfo(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetHoldingsForPortfolioGroup: Get holdings for transaction portfolios in portfolio group Get the holdings of transaction portfolios in specified portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of transaction              portfolios in the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of transaction portfolios in the portfolio group. Defaults              to return the latest version of the holdings if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfPortfolioHolding</returns>
        public Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfPortfolioHolding> GetHoldingsForPortfolioGroupWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetHoldingsForPortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetHoldingsForPortfolioGroup");

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
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }
            if (byTaxlots != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "byTaxlots", byTaxlots));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Get<VersionedResourceListOfPortfolioHolding>("/api/portfoliogroups/{scope}/{code}/holdings", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetHoldingsForPortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetHoldingsForPortfolioGroup: Get holdings for transaction portfolios in portfolio group Get the holdings of transaction portfolios in specified portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of transaction              portfolios in the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of transaction portfolios in the portfolio group. Defaults              to return the latest version of the holdings if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfPortfolioHolding</returns>
        public async System.Threading.Tasks.Task<VersionedResourceListOfPortfolioHolding> GetHoldingsForPortfolioGroupAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfPortfolioHolding> localVarResponse = await GetHoldingsForPortfolioGroupWithHttpInfoAsync(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetHoldingsForPortfolioGroup: Get holdings for transaction portfolios in portfolio group Get the holdings of transaction portfolios in specified portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of transaction              portfolios in the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of transaction portfolios in the portfolio group. Defaults              to return the latest version of the holdings if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfPortfolioHolding)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfPortfolioHolding>> GetHoldingsForPortfolioGroupWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetHoldingsForPortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetHoldingsForPortfolioGroup");


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
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }
            if (byTaxlots != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "byTaxlots", byTaxlots));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<VersionedResourceListOfPortfolioHolding>("/api/portfoliogroups/{scope}/{code}/holdings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetHoldingsForPortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetPortfolioGroup: Get portfolio group Retrieve the definition of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        public PortfolioGroup GetPortfolioGroup(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = GetPortfolioGroupWithHttpInfo(scope, code, effectiveAt, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetPortfolioGroup: Get portfolio group Retrieve the definition of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse<PortfolioGroup> GetPortfolioGroupWithHttpInfo(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroup");

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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Get<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetPortfolioGroup: Get portfolio group Retrieve the definition of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroup</returns>
        public async System.Threading.Tasks.Task<PortfolioGroup> GetPortfolioGroupAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = await GetPortfolioGroupWithHttpInfoAsync(scope, code, effectiveAt, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetPortfolioGroup: Get portfolio group Retrieve the definition of a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the definition for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the definition for. Together with the scope              this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to retrieve the portfolio group definition. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio group definition. Defaults to return              the latest version of the portfolio group definition if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroup>> GetPortfolioGroupWithHttpInfoAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroup");


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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Portfolio Group Get a specific Portfolio Group access metadata by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the access metadata (optional)</param>
        /// <returns>ICollection&lt;AccessMetadataValue&gt;</returns>
        public ICollection<AccessMetadataValue> GetPortfolioGroupAccessMetadataByKey(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>> localVarResponse = GetPortfolioGroupAccessMetadataByKeyWithHttpInfo(scope, code, metadataKey, effectiveAt, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Portfolio Group Get a specific Portfolio Group access metadata by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the access metadata (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;AccessMetadataValue&gt;</returns>
        public Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>> GetPortfolioGroupAccessMetadataByKeyWithHttpInfo(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroupAccessMetadataByKey");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroupAccessMetadataByKey");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PortfolioGroupsApi->GetPortfolioGroupAccessMetadataByKey");

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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ICollection<AccessMetadataValue>>("/api/portfoliogroups/{scope}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroupAccessMetadataByKey", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Portfolio Group Get a specific Portfolio Group access metadata by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the access metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;AccessMetadataValue&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<AccessMetadataValue>> GetPortfolioGroupAccessMetadataByKeyAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>> localVarResponse = await GetPortfolioGroupAccessMetadataByKeyWithHttpInfoAsync(scope, code, metadataKey, effectiveAt, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Portfolio Group Get a specific Portfolio Group access metadata by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the access metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the access metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;AccessMetadataValue&gt;)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>>> GetPortfolioGroupAccessMetadataByKeyWithHttpInfoAsync(string scope, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroupAccessMetadataByKey");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroupAccessMetadataByKey");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PortfolioGroupsApi->GetPortfolioGroupAccessMetadataByKey");


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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ICollection<AccessMetadataValue>>("/api/portfoliogroups/{scope}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroupAccessMetadataByKey", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetPortfolioGroupCommands: Get portfolio group commands Gets all the commands that modified a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the User ID, use \&quot;userId.id eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ResourceListOfProcessedCommand</returns>
        public ResourceListOfProcessedCommand GetPortfolioGroupCommands(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfProcessedCommand> localVarResponse = GetPortfolioGroupCommandsWithHttpInfo(scope, code, fromAsAt, toAsAt, filter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetPortfolioGroupCommands: Get portfolio group commands Gets all the commands that modified a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the User ID, use \&quot;userId.id eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfProcessedCommand</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfProcessedCommand> GetPortfolioGroupCommandsWithHttpInfo(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroupCommands");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroupCommands");

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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfProcessedCommand>("/api/portfoliogroups/{scope}/{code}/commands", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroupCommands", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetPortfolioGroupCommands: Get portfolio group commands Gets all the commands that modified a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the User ID, use \&quot;userId.id eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfProcessedCommand</returns>
        public async System.Threading.Tasks.Task<ResourceListOfProcessedCommand> GetPortfolioGroupCommandsAsync(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfProcessedCommand> localVarResponse = await GetPortfolioGroupCommandsWithHttpInfoAsync(scope, code, fromAsAt, toAsAt, filter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetPortfolioGroupCommands: Get portfolio group commands Gets all the commands that modified a single portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to retrieve the commands for.</param>
        /// <param name="code">The code of the portfolio group to retrieve the commands for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="fromAsAt">The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toAsAt">The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the User ID, use \&quot;userId.id eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfProcessedCommand)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfProcessedCommand>> GetPortfolioGroupCommandsWithHttpInfoAsync(string scope, string code, DateTimeOffset? fromAsAt = default(DateTimeOffset?), DateTimeOffset? toAsAt = default(DateTimeOffset?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroupCommands");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroupCommands");


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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfProcessedCommand>("/api/portfoliogroups/{scope}/{code}/commands", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroupCommands", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupExpansion: Get portfolio group expansion List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ExpandedGroup</returns>
        public ExpandedGroup GetPortfolioGroupExpansion(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<ExpandedGroup> localVarResponse = GetPortfolioGroupExpansionWithHttpInfo(scope, code, effectiveAt, asAt, propertyFilter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupExpansion: Get portfolio group expansion List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <returns>ApiResponse of ExpandedGroup</returns>
        public Lusid.Sdk.Client.ApiResponse<ExpandedGroup> GetPortfolioGroupExpansionWithHttpInfo(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroupExpansion");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroupExpansion");

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
            if (propertyFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyFilter", propertyFilter));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ExpandedGroup>("/api/portfoliogroups/{scope}/{code}/expansion", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroupExpansion", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupExpansion: Get portfolio group expansion List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExpandedGroup</returns>
        public async System.Threading.Tasks.Task<ExpandedGroup> GetPortfolioGroupExpansionAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ExpandedGroup> localVarResponse = await GetPortfolioGroupExpansionWithHttpInfoAsync(scope, code, effectiveAt, asAt, propertyFilter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupExpansion: Get portfolio group expansion List all the portfolios in a group, including all portfolios within sub groups in the group. Each portfolio will be decorated with all of its properties unless a property filter is specified.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to expand.</param>
        /// <param name="code">The code of the portfolio group to expand. Together with the scope this uniquely identifies the portfolio              group to expand.</param>
        /// <param name="effectiveAt">The effective datetime at which to expand the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to expand the portfolio group. Defaults to return the latest version of each portfolio in the group if not specified. (optional)</param>
        /// <param name="propertyFilter">The restricted list of property keys from the \&quot;Portfolio\&quot; domain which will be decorated onto each portfolio. These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExpandedGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ExpandedGroup>> GetPortfolioGroupExpansionWithHttpInfoAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyFilter = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroupExpansion");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroupExpansion");


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
            if (propertyFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyFilter", propertyFilter));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ExpandedGroup>("/api/portfoliogroups/{scope}/{code}/expansion", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroupExpansion", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupMetadata: Get Access Metadata rules for Portfolio Group Pass the scope and Portfolio Group code parameters to retrieve the associated Access Metadata
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <returns>Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public Dictionary<string, List<AccessMetadataValue>> GetPortfolioGroupMetadata(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> localVarResponse = GetPortfolioGroupMetadataWithHttpInfo(scope, code, effectiveAt, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupMetadata: Get Access Metadata rules for Portfolio Group Pass the scope and Portfolio Group code parameters to retrieve the associated Access Metadata
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> GetPortfolioGroupMetadataWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroupMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroupMetadata");

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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Get<Dictionary<string, List<AccessMetadataValue>>>("/api/portfoliogroups/{scope}/{code}/metadata", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroupMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupMetadata: Get Access Metadata rules for Portfolio Group Pass the scope and Portfolio Group code parameters to retrieve the associated Access Metadata
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, List<AccessMetadataValue>>> GetPortfolioGroupMetadataAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> localVarResponse = await GetPortfolioGroupMetadataWithHttpInfoAsync(scope, code, effectiveAt, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupMetadata: Get Access Metadata rules for Portfolio Group Pass the scope and Portfolio Group code parameters to retrieve the associated Access Metadata
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>>> GetPortfolioGroupMetadataWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroupMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroupMetadata");


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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Dictionary<string, List<AccessMetadataValue>>>("/api/portfoliogroups/{scope}/{code}/metadata", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroupMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupPropertyTimeSeries: Get the time series of a portfolio group property List the complete time series of a portfolio group property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group.</param>
        /// <param name="code">The code of the group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;.              Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="portfolioGroupEffectiveAt">The effective datetime used to resolve the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio group&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>ResourceListOfPropertyInterval</returns>
        public ResourceListOfPropertyInterval GetPortfolioGroupPropertyTimeSeries(string scope, string code, string propertyKey, string portfolioGroupEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPropertyInterval> localVarResponse = GetPortfolioGroupPropertyTimeSeriesWithHttpInfo(scope, code, propertyKey, portfolioGroupEffectiveAt, asAt, filter, page, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupPropertyTimeSeries: Get the time series of a portfolio group property List the complete time series of a portfolio group property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group.</param>
        /// <param name="code">The code of the group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;.              Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="portfolioGroupEffectiveAt">The effective datetime used to resolve the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio group&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPropertyInterval</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfPropertyInterval> GetPortfolioGroupPropertyTimeSeriesWithHttpInfo(string scope, string code, string propertyKey, string portfolioGroupEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroupPropertyTimeSeries");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroupPropertyTimeSeries");

            // verify the required parameter 'propertyKey' is set
            if (propertyKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKey' when calling PortfolioGroupsApi->GetPortfolioGroupPropertyTimeSeries");

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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "propertyKey", propertyKey));
            if (portfolioGroupEffectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "portfolioGroupEffectiveAt", portfolioGroupEffectiveAt));
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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfPropertyInterval>("/api/portfoliogroups/{scope}/{code}/properties/time-series", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroupPropertyTimeSeries", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupPropertyTimeSeries: Get the time series of a portfolio group property List the complete time series of a portfolio group property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group.</param>
        /// <param name="code">The code of the group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;.              Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="portfolioGroupEffectiveAt">The effective datetime used to resolve the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio group&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPropertyInterval</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPropertyInterval> GetPortfolioGroupPropertyTimeSeriesAsync(string scope, string code, string propertyKey, string portfolioGroupEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPropertyInterval> localVarResponse = await GetPortfolioGroupPropertyTimeSeriesWithHttpInfoAsync(scope, code, propertyKey, portfolioGroupEffectiveAt, asAt, filter, page, limit, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPortfolioGroupPropertyTimeSeries: Get the time series of a portfolio group property List the complete time series of a portfolio group property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group.</param>
        /// <param name="code">The code of the group. Together with the scope this uniquely identifies              the portfolio group.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;.              Each property must be from the \&quot;PortfolioGroup\&quot; domain.</param>
        /// <param name="portfolioGroupEffectiveAt">The effective datetime used to resolve the portfolio group. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio group&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPropertyInterval)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfPropertyInterval>> GetPortfolioGroupPropertyTimeSeriesWithHttpInfoAsync(string scope, string code, string propertyKey, string portfolioGroupEffectiveAt = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetPortfolioGroupPropertyTimeSeries");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetPortfolioGroupPropertyTimeSeries");

            // verify the required parameter 'propertyKey' is set
            if (propertyKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKey' when calling PortfolioGroupsApi->GetPortfolioGroupPropertyTimeSeries");


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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "propertyKey", propertyKey));
            if (portfolioGroupEffectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "portfolioGroupEffectiveAt", portfolioGroupEffectiveAt));
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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfPropertyInterval>("/api/portfoliogroups/{scope}/{code}/properties/time-series", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioGroupPropertyTimeSeries", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetTransactionsForPortfolioGroup: Get transactions for transaction portfolios in a portfolio group Get transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve the transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the transactions. Defaults to return the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <returns>VersionedResourceListOfTransaction</returns>
        public VersionedResourceListOfTransaction GetTransactionsForPortfolioGroup(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), bool? showCancelledTransactions = default(bool?))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfTransaction> localVarResponse = GetTransactionsForPortfolioGroupWithHttpInfo(scope, code, fromTransactionDate, toTransactionDate, asAt, filter, propertyKeys, limit, page, showCancelledTransactions);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetTransactionsForPortfolioGroup: Get transactions for transaction portfolios in a portfolio group Get transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve the transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the transactions. Defaults to return the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfTransaction</returns>
        public Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfTransaction> GetTransactionsForPortfolioGroupWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), bool? showCancelledTransactions = default(bool?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetTransactionsForPortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetTransactionsForPortfolioGroup");

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
            if (fromTransactionDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromTransactionDate", fromTransactionDate));
            }
            if (toTransactionDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toTransactionDate", toTransactionDate));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (showCancelledTransactions != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "showCancelledTransactions", showCancelledTransactions));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Get<VersionedResourceListOfTransaction>("/api/portfoliogroups/{scope}/{code}/transactions", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTransactionsForPortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetTransactionsForPortfolioGroup: Get transactions for transaction portfolios in a portfolio group Get transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve the transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the transactions. Defaults to return the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfTransaction</returns>
        public async System.Threading.Tasks.Task<VersionedResourceListOfTransaction> GetTransactionsForPortfolioGroupAsync(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), bool? showCancelledTransactions = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfTransaction> localVarResponse = await GetTransactionsForPortfolioGroupWithHttpInfoAsync(scope, code, fromTransactionDate, toTransactionDate, asAt, filter, propertyKeys, limit, page, showCancelledTransactions, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetTransactionsForPortfolioGroup: Get transactions for transaction portfolios in a portfolio group Get transactions for transaction portfolios in a portfolio group over a given interval of effective time.                When the specified portfolio in a portfolio group is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group.</param>
        /// <param name="code">The code of the portfolio group. Together with the scope this uniquely identifies               the portfolio group.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve the transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the transactions. Defaults to return the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the Transaction Type, use \&quot;type eq &#39;Buy&#39;\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto               the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or               \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfTransaction)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfTransaction>> GetTransactionsForPortfolioGroupWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), bool? showCancelledTransactions = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->GetTransactionsForPortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->GetTransactionsForPortfolioGroup");


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
            if (fromTransactionDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromTransactionDate", fromTransactionDate));
            }
            if (toTransactionDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toTransactionDate", toTransactionDate));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (showCancelledTransactions != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "showCancelledTransactions", showCancelledTransactions));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<VersionedResourceListOfTransaction>("/api/portfoliogroups/{scope}/{code}/transactions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTransactionsForPortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListPortfolioGroups: List portfolio groups List all the portfolio groups in a single scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ResourceListOfPortfolioGroup</returns>
        public ResourceListOfPortfolioGroup ListPortfolioGroups(string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolioGroup> localVarResponse = ListPortfolioGroupsWithHttpInfo(scope, effectiveAt, asAt, filter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListPortfolioGroups: List portfolio groups List all the portfolio groups in a single scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolioGroup> ListPortfolioGroupsWithHttpInfo(string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->ListPortfolioGroups");

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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfPortfolioGroup>("/api/portfoliogroups/{scope}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPortfolioGroups", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListPortfolioGroups: List portfolio groups List all the portfolio groups in a single scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPortfolioGroup</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPortfolioGroup> ListPortfolioGroupsAsync(string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolioGroup> localVarResponse = await ListPortfolioGroupsWithHttpInfoAsync(scope, effectiveAt, asAt, filter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListPortfolioGroups: List portfolio groups List all the portfolio groups in a single scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to list the portfolio groups in.</param>
        /// <param name="effectiveAt">The effective datetime at which to list the portfolio groups. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the portfolio groups. Defaults to return the latest version of each portfolio group if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolioGroup>> ListPortfolioGroupsWithHttpInfoAsync(string scope, DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->ListPortfolioGroups");


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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfPortfolioGroup>("/api/portfoliogroups/{scope}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPortfolioGroups", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdatePortfolioGroup: Update portfolio group Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition. (optional)</param>
        /// <param name="updatePortfolioGroupRequest">The updated portfolio group definition. (optional)</param>
        /// <returns>PortfolioGroup</returns>
        public PortfolioGroup UpdatePortfolioGroup(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), UpdatePortfolioGroupRequest updatePortfolioGroupRequest = default(UpdatePortfolioGroupRequest))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = UpdatePortfolioGroupWithHttpInfo(scope, code, effectiveAt, updatePortfolioGroupRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdatePortfolioGroup: Update portfolio group Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition. (optional)</param>
        /// <param name="updatePortfolioGroupRequest">The updated portfolio group definition. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroup</returns>
        public Lusid.Sdk.Client.ApiResponse<PortfolioGroup> UpdatePortfolioGroupWithHttpInfo(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), UpdatePortfolioGroupRequest updatePortfolioGroupRequest = default(UpdatePortfolioGroupRequest))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->UpdatePortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->UpdatePortfolioGroup");

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
            localVarRequestOptions.Data = updatePortfolioGroupRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Put<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdatePortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdatePortfolioGroup: Update portfolio group Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition. (optional)</param>
        /// <param name="updatePortfolioGroupRequest">The updated portfolio group definition. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroup</returns>
        public async System.Threading.Tasks.Task<PortfolioGroup> UpdatePortfolioGroupAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), UpdatePortfolioGroupRequest updatePortfolioGroupRequest = default(UpdatePortfolioGroupRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroup> localVarResponse = await UpdatePortfolioGroupWithHttpInfoAsync(scope, code, effectiveAt, updatePortfolioGroupRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdatePortfolioGroup: Update portfolio group Update the definition of a single portfolio group. Not all elements within a portfolio group definition are modifiable  due to the potential implications for data already stored against the portfolio group.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio group to update the definition for.</param>
        /// <param name="code">The code of the portfolio group to update the definition for. Together with the scope this uniquely identifies the portfolio group.</param>
        /// <param name="effectiveAt">The effective datetime at which to update the definition. (optional)</param>
        /// <param name="updatePortfolioGroupRequest">The updated portfolio group definition. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroup)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroup>> UpdatePortfolioGroupWithHttpInfoAsync(string scope, string code, DateTimeOffset? effectiveAt = default(DateTimeOffset?), UpdatePortfolioGroupRequest updatePortfolioGroupRequest = default(UpdatePortfolioGroupRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->UpdatePortfolioGroup");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->UpdatePortfolioGroup");


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
            localVarRequestOptions.Data = updatePortfolioGroupRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<PortfolioGroup>("/api/portfoliogroups/{scope}/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdatePortfolioGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertGroupProperties: Upsert group properties Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.                Upserting a property that exists for a group, with a null value, will delete the instance of the property for that group.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime for which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The properties to be updated or inserted onto the group. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <returns>PortfolioGroupProperties</returns>
        public PortfolioGroupProperties UpsertGroupProperties(string scope, string code, Dictionary<string, Property> requestBody = default(Dictionary<string, Property>))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroupProperties> localVarResponse = UpsertGroupPropertiesWithHttpInfo(scope, code, requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertGroupProperties: Upsert group properties Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.                Upserting a property that exists for a group, with a null value, will delete the instance of the property for that group.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime for which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The properties to be updated or inserted onto the group. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <returns>ApiResponse of PortfolioGroupProperties</returns>
        public Lusid.Sdk.Client.ApiResponse<PortfolioGroupProperties> UpsertGroupPropertiesWithHttpInfo(string scope, string code, Dictionary<string, Property> requestBody = default(Dictionary<string, Property>))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->UpsertGroupProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->UpsertGroupProperties");

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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Post<PortfolioGroupProperties>("/api/portfoliogroups/{scope}/{code}/properties/$upsert", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertGroupProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertGroupProperties: Upsert group properties Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.                Upserting a property that exists for a group, with a null value, will delete the instance of the property for that group.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime for which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The properties to be updated or inserted onto the group. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioGroupProperties</returns>
        public async System.Threading.Tasks.Task<PortfolioGroupProperties> UpsertGroupPropertiesAsync(string scope, string code, Dictionary<string, Property> requestBody = default(Dictionary<string, Property>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioGroupProperties> localVarResponse = await UpsertGroupPropertiesWithHttpInfoAsync(scope, code, requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertGroupProperties: Upsert group properties Update or insert one or more properties onto a single group. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain &#39;PortfolioGroup&#39;.                Upserting a property that exists for a group, with a null value, will delete the instance of the property for that group.                Properties have an &lt;i&gt;effectiveFrom&lt;/i&gt; datetime for which the property is valid, and an &lt;i&gt;effectiveUntil&lt;/i&gt;  datetime until which the property is valid. Not supplying an &lt;i&gt;effectiveUntil&lt;/i&gt; datetime results in the property being  valid indefinitely, or until the next &lt;i&gt;effectiveFrom&lt;/i&gt; datetime of the property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the group to update or insert the properties onto.</param>
        /// <param name="code">The code of the group to update or insert the properties onto. Together with the scope this uniquely identifies the group.</param>
        /// <param name="requestBody">The properties to be updated or inserted onto the group. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;PortfolioGroup/Manager/Id\&quot;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioGroupProperties)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioGroupProperties>> UpsertGroupPropertiesWithHttpInfoAsync(string scope, string code, Dictionary<string, Property> requestBody = default(Dictionary<string, Property>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->UpsertGroupProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->UpsertGroupProperties");


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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<PortfolioGroupProperties>("/api/portfoliogroups/{scope}/{code}/properties/$upsert", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertGroupProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioGroupAccessMetadata: Upsert a Portfolio Group Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID. Update or insert one Portfolio Group Access Metadata Entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Portfolio Group Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the access metadata entry to upsert</param>
        /// <param name="upsertPortfolioGroupAccessMetadataRequest">The Portfolio Group Access Metadata rule to upsert</param>
        /// <param name="effectiveAt">The date this rule will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>ResourceListOfAccessMetadataValueOf</returns>
        public ResourceListOfAccessMetadataValueOf UpsertPortfolioGroupAccessMetadata(string scope, string code, string metadataKey, UpsertPortfolioGroupAccessMetadataRequest upsertPortfolioGroupAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfAccessMetadataValueOf> localVarResponse = UpsertPortfolioGroupAccessMetadataWithHttpInfo(scope, code, metadataKey, upsertPortfolioGroupAccessMetadataRequest, effectiveAt, effectiveUntil);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioGroupAccessMetadata: Upsert a Portfolio Group Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID. Update or insert one Portfolio Group Access Metadata Entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Portfolio Group Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the access metadata entry to upsert</param>
        /// <param name="upsertPortfolioGroupAccessMetadataRequest">The Portfolio Group Access Metadata rule to upsert</param>
        /// <param name="effectiveAt">The date this rule will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of ResourceListOfAccessMetadataValueOf</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfAccessMetadataValueOf> UpsertPortfolioGroupAccessMetadataWithHttpInfo(string scope, string code, string metadataKey, UpsertPortfolioGroupAccessMetadataRequest upsertPortfolioGroupAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->UpsertPortfolioGroupAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->UpsertPortfolioGroupAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PortfolioGroupsApi->UpsertPortfolioGroupAccessMetadata");

            // verify the required parameter 'upsertPortfolioGroupAccessMetadataRequest' is set
            if (upsertPortfolioGroupAccessMetadataRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'upsertPortfolioGroupAccessMetadataRequest' when calling PortfolioGroupsApi->UpsertPortfolioGroupAccessMetadata");

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
            localVarRequestOptions.Data = upsertPortfolioGroupAccessMetadataRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request
            var localVarResponse = this.Client.Put<ResourceListOfAccessMetadataValueOf>("/api/portfoliogroups/{scope}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertPortfolioGroupAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioGroupAccessMetadata: Upsert a Portfolio Group Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID. Update or insert one Portfolio Group Access Metadata Entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Portfolio Group Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the access metadata entry to upsert</param>
        /// <param name="upsertPortfolioGroupAccessMetadataRequest">The Portfolio Group Access Metadata rule to upsert</param>
        /// <param name="effectiveAt">The date this rule will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfAccessMetadataValueOf</returns>
        public async System.Threading.Tasks.Task<ResourceListOfAccessMetadataValueOf> UpsertPortfolioGroupAccessMetadataAsync(string scope, string code, string metadataKey, UpsertPortfolioGroupAccessMetadataRequest upsertPortfolioGroupAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfAccessMetadataValueOf> localVarResponse = await UpsertPortfolioGroupAccessMetadataWithHttpInfoAsync(scope, code, metadataKey, upsertPortfolioGroupAccessMetadataRequest, effectiveAt, effectiveUntil, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPortfolioGroupAccessMetadata: Upsert a Portfolio Group Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID. Update or insert one Portfolio Group Access Metadata Entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Portfolio Group Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the Portfolio Group</param>
        /// <param name="code">The Portfolio Group code</param>
        /// <param name="metadataKey">Key of the access metadata entry to upsert</param>
        /// <param name="upsertPortfolioGroupAccessMetadataRequest">The Portfolio Group Access Metadata rule to upsert</param>
        /// <param name="effectiveAt">The date this rule will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfAccessMetadataValueOf)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfAccessMetadataValueOf>> UpsertPortfolioGroupAccessMetadataWithHttpInfoAsync(string scope, string code, string metadataKey, UpsertPortfolioGroupAccessMetadataRequest upsertPortfolioGroupAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling PortfolioGroupsApi->UpsertPortfolioGroupAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PortfolioGroupsApi->UpsertPortfolioGroupAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PortfolioGroupsApi->UpsertPortfolioGroupAccessMetadata");

            // verify the required parameter 'upsertPortfolioGroupAccessMetadataRequest' is set
            if (upsertPortfolioGroupAccessMetadataRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'upsertPortfolioGroupAccessMetadataRequest' when calling PortfolioGroupsApi->UpsertPortfolioGroupAccessMetadata");


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
            localVarRequestOptions.Data = upsertPortfolioGroupAccessMetadataRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.4555");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<ResourceListOfAccessMetadataValueOf>("/api/portfoliogroups/{scope}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertPortfolioGroupAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}