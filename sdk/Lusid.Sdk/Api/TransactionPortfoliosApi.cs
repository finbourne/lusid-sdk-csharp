/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](../../../api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application   | Description                                                                       | API / Swagger Documentation                          | |- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | LUSID         | Open, API-first, developer-friendly investment data platform.                     | [Swagger](../../../api/swagger/index.html)           | | Web app       | User-facing front end for LUSID.                                                  | [Swagger](../../../app/swagger/index.html)           | | Scheduler     | Automated job scheduler.                                                          | [Swagger](../../../scheduler2/swagger/index.html)    | | Insights      | Monitoring and troubleshooting service.                                           | [Swagger](../../../insights/swagger/index.html)      | | Identity      | Identity management for LUSID (in conjunction with Access)                        | [Swagger](../../../identity/swagger/index.html)      | | Access        | Access control for LUSID (in conjunction with Identity)                           | [Swagger](../../../access/swagger/index.html)        | | Drive         | Secure file repository and manager for collaboration.                             | [Swagger](../../../drive/swagger/index.html)         | | Luminesce     | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](../../../honeycomb/swagger/index.html)     | | Notification  | Notification service.                                                             | [Swagger](../../../notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information.                           | [Swagger](../../../configuration/swagger/index.html) |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-10\">-10</a>|Server Configuration Error|  | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"102\">102</a>|Version Not Found|  | | <a name=\"103\">103</a>|Api Rate Limit Violation|  | | <a name=\"104\">104</a>|Instrument Not Found|  | | <a name=\"105\">105</a>|Property Not Found|  | | <a name=\"106\">106</a>|Portfolio Recursion Depth|  | | <a name=\"108\">108</a>|Group Not Found|  | | <a name=\"109\">109</a>|Portfolio Not Found|  | | <a name=\"110\">110</a>|Property Schema Not Found|  | | <a name=\"111\">111</a>|Portfolio Ancestry Not Found|  | | <a name=\"112\">112</a>|Portfolio With Id Already Exists|  | | <a name=\"113\">113</a>|Orphaned Portfolio|  | | <a name=\"119\">119</a>|Missing Base Claims|  | | <a name=\"121\">121</a>|Property Not Defined|  | | <a name=\"122\">122</a>|Cannot Delete System Property|  | | <a name=\"123\">123</a>|Cannot Modify Immutable Property Field|  | | <a name=\"124\">124</a>|Property Already Exists|  | | <a name=\"125\">125</a>|Invalid Property Life Time|  | | <a name=\"126\">126</a>|Property Constraint Style Excludes Properties|  | | <a name=\"127\">127</a>|Cannot Modify Default Data Type|  | | <a name=\"128\">128</a>|Group Already Exists|  | | <a name=\"129\">129</a>|No Such Data Type|  | | <a name=\"130\">130</a>|Undefined Value For Data Type|  | | <a name=\"131\">131</a>|Unsupported Value Type Defined On Data Type|  | | <a name=\"132\">132</a>|Validation Error|  | | <a name=\"133\">133</a>|Loop Detected In Group Hierarchy|  | | <a name=\"134\">134</a>|Undefined Acceptable Values|  | | <a name=\"135\">135</a>|Sub Group Already Exists|  | | <a name=\"138\">138</a>|Price Source Not Found|  | | <a name=\"139\">139</a>|Analytic Store Not Found|  | | <a name=\"141\">141</a>|Analytic Store Already Exists|  | | <a name=\"143\">143</a>|Client Instrument Already Exists|  | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"147\">147</a>|Results Not Found|  | | <a name=\"148\">148</a>|Order Field Not In Result Set|  | | <a name=\"149\">149</a>|Operation Failed|  | | <a name=\"150\">150</a>|Elastic Search Error|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"153\">153</a>|Command Processing Failure|  | | <a name=\"154\">154</a>|Entity State Construction Failure|  | | <a name=\"155\">155</a>|Entity Timeline Does Not Exist|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"158\">158</a>|Event Publish Unknown|  | | <a name=\"159\">159</a>|Event Query Failure|  | | <a name=\"160\">160</a>|Blob Did Not Exist|  | | <a name=\"162\">162</a>|Sub System Request Failure|  | | <a name=\"163\">163</a>|Sub System Configuration Failure|  | | <a name=\"165\">165</a>|Failed To Delete|  | | <a name=\"166\">166</a>|Upsert Client Instrument Failure|  | | <a name=\"167\">167</a>|Illegal As At Interval|  | | <a name=\"168\">168</a>|Illegal Bitemporal Query|  | | <a name=\"169\">169</a>|Invalid Alternate Id|  | | <a name=\"170\">170</a>|Cannot Add Source Portfolio Property Explicitly|  | | <a name=\"171\">171</a>|Entity Already Exists In Group|  | | <a name=\"173\">173</a>|Entity With Id Already Exists|  | | <a name=\"174\">174</a>|Derived Portfolio Details Do Not Exist|  | | <a name=\"175\">175</a>|Entity Not In Group|  | | <a name=\"176\">176</a>|Portfolio With Name Already Exists|  | | <a name=\"177\">177</a>|Invalid Transactions|  | | <a name=\"178\">178</a>|Reference Portfolio Not Found|  | | <a name=\"179\">179</a>|Duplicate Id|  | | <a name=\"180\">180</a>|Command Retrieval Failure|  | | <a name=\"181\">181</a>|Data Filter Application Failure|  | | <a name=\"182\">182</a>|Search Failed|  | | <a name=\"183\">183</a>|Movements Engine Configuration Key Failure|  | | <a name=\"184\">184</a>|Fx Rate Source Not Found|  | | <a name=\"185\">185</a>|Accrual Source Not Found|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"188\">188</a>|Invalid Request Headers|  | | <a name=\"189\">189</a>|Price Not Found|  | | <a name=\"190\">190</a>|Invalid Sub Holding Keys Provided|  | | <a name=\"191\">191</a>|Duplicate Sub Holding Keys Provided|  | | <a name=\"192\">192</a>|Cut Definition Not Found|  | | <a name=\"193\">193</a>|Cut Definition Invalid|  | | <a name=\"194\">194</a>|Time Variant Property Deletion Date Unspecified|  | | <a name=\"195\">195</a>|Perpetual Property Deletion Date Specified|  | | <a name=\"196\">196</a>|Time Variant Property Upsert Date Unspecified|  | | <a name=\"197\">197</a>|Perpetual Property Upsert Date Specified|  | | <a name=\"200\">200</a>|Invalid Unit For Data Type|  | | <a name=\"201\">201</a>|Invalid Type For Data Type|  | | <a name=\"202\">202</a>|Invalid Value For Data Type|  | | <a name=\"203\">203</a>|Unit Not Defined For Data Type|  | | <a name=\"204\">204</a>|Units Not Supported On Data Type|  | | <a name=\"205\">205</a>|Cannot Specify Units On Data Type|  | | <a name=\"206\">206</a>|Unit Schema Inconsistent With Data Type|  | | <a name=\"207\">207</a>|Unit Definition Not Specified|  | | <a name=\"208\">208</a>|Duplicate Unit Definitions Specified|  | | <a name=\"209\">209</a>|Invalid Units Definition|  | | <a name=\"210\">210</a>|Invalid Instrument Identifier Unit|  | | <a name=\"211\">211</a>|Holdings Adjustment Does Not Exist|  | | <a name=\"212\">212</a>|Could Not Build Excel Url|  | | <a name=\"213\">213</a>|Could Not Get Excel Version|  | | <a name=\"214\">214</a>|Instrument By Code Not Found|  | | <a name=\"215\">215</a>|Entity Schema Does Not Exist|  | | <a name=\"216\">216</a>|Feature Not Supported On Portfolio Type|  | | <a name=\"217\">217</a>|Quote Not Found|  | | <a name=\"218\">218</a>|Invalid Quote Identifier|  | | <a name=\"219\">219</a>|Invalid Metric For Data Type|  | | <a name=\"220\">220</a>|Invalid Instrument Definition|  | | <a name=\"221\">221</a>|Instrument Upsert Failure|  | | <a name=\"222\">222</a>|Reference Portfolio Request Not Supported|  | | <a name=\"223\">223</a>|Transaction Portfolio Request Not Supported|  | | <a name=\"224\">224</a>|Invalid Property Value Assignment|  | | <a name=\"230\">230</a>|Transaction Type Not Found|  | | <a name=\"231\">231</a>|Transaction Type Duplication|  | | <a name=\"232\">232</a>|Portfolio Does Not Exist At Given Date|  | | <a name=\"233\">233</a>|Query Parser Failure|  | | <a name=\"234\">234</a>|Duplicate Constituent|  | | <a name=\"235\">235</a>|Unresolved Instrument Constituent|  | | <a name=\"236\">236</a>|Unresolved Instrument In Transition|  | | <a name=\"237\">237</a>|Missing Side Definitions|  | | <a name=\"299\">299</a>|Invalid Recipe|  | | <a name=\"300\">300</a>|Missing Recipe|  | | <a name=\"301\">301</a>|Dependencies|  | | <a name=\"304\">304</a>|Portfolio Preprocess Failure|  | | <a name=\"310\">310</a>|Valuation Engine Failure|  | | <a name=\"311\">311</a>|Task Factory Failure|  | | <a name=\"312\">312</a>|Task Evaluation Failure|  | | <a name=\"313\">313</a>|Task Generation Failure|  | | <a name=\"314\">314</a>|Engine Configuration Failure|  | | <a name=\"315\">315</a>|Model Specification Failure|  | | <a name=\"320\">320</a>|Market Data Key Failure|  | | <a name=\"321\">321</a>|Market Resolver Failure|  | | <a name=\"322\">322</a>|Market Data Failure|  | | <a name=\"330\">330</a>|Curve Failure|  | | <a name=\"331\">331</a>|Volatility Surface Failure|  | | <a name=\"332\">332</a>|Volatility Cube Failure|  | | <a name=\"350\">350</a>|Instrument Failure|  | | <a name=\"351\">351</a>|Cash Flows Failure|  | | <a name=\"352\">352</a>|Reference Data Failure|  | | <a name=\"360\">360</a>|Aggregation Failure|  | | <a name=\"361\">361</a>|Aggregation Measure Failure|  | | <a name=\"370\">370</a>|Result Retrieval Failure|  | | <a name=\"371\">371</a>|Result Processing Failure|  | | <a name=\"372\">372</a>|Vendor Result Processing Failure|  | | <a name=\"373\">373</a>|Vendor Result Mapping Failure|  | | <a name=\"374\">374</a>|Vendor Library Unauthorised|  | | <a name=\"375\">375</a>|Vendor Connectivity Error|  | | <a name=\"376\">376</a>|Vendor Interface Error|  | | <a name=\"377\">377</a>|Vendor Pricing Failure|  | | <a name=\"378\">378</a>|Vendor Translation Failure|  | | <a name=\"379\">379</a>|Vendor Key Mapping Failure|  | | <a name=\"380\">380</a>|Vendor Reflection Failure|  | | <a name=\"381\">381</a>|Vendor Process Failure|  | | <a name=\"382\">382</a>|Vendor System Failure|  | | <a name=\"390\">390</a>|Attempt To Upsert Duplicate Quotes|  | | <a name=\"391\">391</a>|Corporate Action Source Does Not Exist|  | | <a name=\"392\">392</a>|Corporate Action Source Already Exists|  | | <a name=\"393\">393</a>|Instrument Identifier Already In Use|  | | <a name=\"394\">394</a>|Properties Not Found|  | | <a name=\"395\">395</a>|Batch Operation Aborted|  | | <a name=\"400\">400</a>|Invalid Iso4217 Currency Code|  | | <a name=\"401\">401</a>|Cannot Assign Instrument Identifier To Currency|  | | <a name=\"402\">402</a>|Cannot Assign Currency Identifier To Non Currency|  | | <a name=\"403\">403</a>|Currency Instrument Cannot Be Deleted|  | | <a name=\"404\">404</a>|Currency Instrument Cannot Have Economic Definition|  | | <a name=\"405\">405</a>|Currency Instrument Cannot Have Lookthrough Portfolio|  | | <a name=\"406\">406</a>|Cannot Create Currency Instrument With Multiple Identifiers|  | | <a name=\"407\">407</a>|Specified Currency Is Undefined|  | | <a name=\"410\">410</a>|Index Does Not Exist|  | | <a name=\"411\">411</a>|Sort Field Does Not Exist|  | | <a name=\"413\">413</a>|Negative Pagination Parameters|  | | <a name=\"414\">414</a>|Invalid Search Syntax|  | | <a name=\"415\">415</a>|Filter Execution Timeout|  | | <a name=\"420\">420</a>|Side Definition Inconsistent|  | | <a name=\"450\">450</a>|Invalid Quote Access Metadata Rule|  | | <a name=\"451\">451</a>|Access Metadata Not Found|  | | <a name=\"452\">452</a>|Invalid Access Metadata Identifier|  | | <a name=\"460\">460</a>|Standard Resource Not Found|  | | <a name=\"461\">461</a>|Standard Resource Conflict|  | | <a name=\"462\">462</a>|Calendar Not Found|  | | <a name=\"463\">463</a>|Date In A Calendar Not Found|  | | <a name=\"464\">464</a>|Invalid Date Source Data|  | | <a name=\"465\">465</a>|Invalid Timezone|  | | <a name=\"601\">601</a>|Person Identifier Already In Use|  | | <a name=\"602\">602</a>|Person Not Found|  | | <a name=\"603\">603</a>|Cannot Set Identifier|  | | <a name=\"617\">617</a>|Invalid Recipe Specification In Request|  | | <a name=\"618\">618</a>|Inline Recipe Deserialisation Failure|  | | <a name=\"619\">619</a>|Identifier Types Not Set For Entity|  | | <a name=\"620\">620</a>|Cannot Delete All Client Defined Identifiers|  | | <a name=\"650\">650</a>|The Order requested was not found.|  | | <a name=\"654\">654</a>|The Allocation requested was not found.|  | | <a name=\"655\">655</a>|Cannot build the fx forward target with the given holdings.|  | | <a name=\"656\">656</a>|Group does not contain expected entities.|  | | <a name=\"665\">665</a>|Destination directory not found|  | | <a name=\"667\">667</a>|Relation definition already exists|  | | <a name=\"672\">672</a>|Could not retrieve file contents|  | | <a name=\"673\">673</a>|Missing entitlements for entities in Group|  | | <a name=\"674\">674</a>|Next Best Action not found|  | | <a name=\"676\">676</a>|Relation definition not defined|  | | <a name=\"677\">677</a>|Invalid entity identifier for relation|  | | <a name=\"681\">681</a>|Sorting by specified field not supported|One or more of the provided fields to order by were either invalid or not supported. | | <a name=\"682\">682</a>|Too many fields to sort by|The number of fields to sort the data by exceeds the number allowed by the endpoint | | <a name=\"684\">684</a>|Sequence Not Found|  | | <a name=\"685\">685</a>|Sequence Already Exists|  | | <a name=\"686\">686</a>|Non-cycling sequence has been exhausted|  | | <a name=\"687\">687</a>|Legal Entity Identifier Already In Use|  | | <a name=\"688\">688</a>|Legal Entity Not Found|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"690\">690</a>|Property Type Is Not Supported|  | | <a name=\"691\">691</a>|Multiple Tax-lots For Currency Type Is Not Supported|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"693\">693</a>|Entity type is not supported for Relationship|  | | <a name=\"694\">694</a>|Relationship Validation Failure|  | | <a name=\"695\">695</a>|Relationship Not Found|  | | <a name=\"697\">697</a>|Derived Property Formula No Longer Valid|  | | <a name=\"698\">698</a>|Story is not available|  | | <a name=\"703\">703</a>|Corporate Action Does Not Exist|  | | <a name=\"720\">720</a>|The provided sort and filter combination is not valid|  | | <a name=\"721\">721</a>|A2B generation failed|  | | <a name=\"722\">722</a>|Aggregated Return Calculation Failure|  | | <a name=\"723\">723</a>|Custom Entity Definition Identifier Already In Use|  | | <a name=\"724\">724</a>|Custom Entity Definition Not Found|  | | <a name=\"725\">725</a>|The Placement requested was not found.|  | | <a name=\"726\">726</a>|The Execution requested was not found.|  | | <a name=\"727\">727</a>|The Block requested was not found.|  | | <a name=\"728\">728</a>|The Participation requested was not found.|  | | <a name=\"729\">729</a>|The Package requested was not found.|  | | <a name=\"730\">730</a>|The OrderInstruction requested was not found.|  | | <a name=\"732\">732</a>|Custom Entity not found.|  | | <a name=\"733\">733</a>|Custom Entity Identifier already in use.|  | | <a name=\"735\">735</a>|Calculation Failed.|  | | <a name=\"736\">736</a>|An expected key on HttpResponse is missing.|  | | <a name=\"737\">737</a>|A required fee detail is missing.|  | | <a name=\"738\">738</a>|Zero rows were returned from Luminesce|  | | <a name=\"739\">739</a>|Provided Weekend Mask was invalid|  | | <a name=\"742\">742</a>|Custom Entity fields do not match the definition|  | | <a name=\"746\">746</a>|The provided sequence is not valid.|  | | <a name=\"751\">751</a>|The type of the Custom Entity is different than the type provided in the definition.|  | | <a name=\"752\">752</a>|Luminesce process returned an error.|  | | <a name=\"753\">753</a>|File name or content incompatible with operation.|  | | <a name=\"755\">755</a>|Schema of response from Drive is not as expected.|  | | <a name=\"757\">757</a>|Schema of response from Luminesce is not as expected.|  | | <a name=\"758\">758</a>|Luminesce timed out.|  | | <a name=\"763\">763</a>|Invalid Lusid Entity Identifier Unit|  | | <a name=\"768\">768</a>|Fee rule not found.|  | | <a name=\"769\">769</a>|Cannot update the base currency of a portfolio with transactions loaded|  | | <a name=\"771\">771</a>|Transaction configuration source not found|  | | <a name=\"774\">774</a>|Compliance rule not found.|  | | <a name=\"775\">775</a>|Fund accounting document cannot be processed.|  | | <a name=\"778\">778</a>|Unable to look up FX rate from trade ccy to portfolio ccy for some of the trades.|  | | <a name=\"782\">782</a>|The Property definition dataType is not matching the derivation formula dataType|  | | <a name=\"783\">783</a>|The Property definition domain is not supported for derived properties|  | | <a name=\"788\">788</a>|Compliance run not found failure.|  | | <a name=\"790\">790</a>|Custom Entity has missing or invalid identifiers|  | | <a name=\"791\">791</a>|Custom Entity definition already exists|  | | <a name=\"792\">792</a>|Compliance PropertyKey is missing.|  | | <a name=\"793\">793</a>|Compliance Criteria Value for matching is missing.|  | | <a name=\"795\">795</a>|Cannot delete identifier definition|  | | <a name=\"796\">796</a>|Tax rule set not found.|  | | <a name=\"797\">797</a>|A tax rule set with this id already exists.|  | | <a name=\"798\">798</a>|Multiple rule sets for the same property key are applicable.|  | | <a name=\"800\">800</a>|Can not upsert an instrument event of this type.|  | | <a name=\"801\">801</a>|The instrument event does not exist.|  | | <a name=\"802\">802</a>|The Instrument event is missing salient information.|  | | <a name=\"803\">803</a>|The Instrument event could not be processed.|  | | <a name=\"804\">804</a>|Some data requested does not follow the order graph assumptions.|  | | <a name=\"811\">811</a>|A price could not be found for an order.|  | | <a name=\"812\">812</a>|A price could not be found for an allocation.|  | | <a name=\"813\">813</a>|Chart of Accounts not found.|  | | <a name=\"814\">814</a>|Account not found.|  | | <a name=\"815\">815</a>|Abor not found.|  | | <a name=\"816\">816</a>|Abor Configuration not found.|  | | <a name=\"817\">817</a>|Reconciliation mapping not found|  | | <a name=\"818\">818</a>|Attribute type could not be deleted because it doesn't exist.|  | | <a name=\"819\">819</a>|Reconciliation not found.|  | | <a name=\"820\">820</a>|Custodian Account not found.|  | | <a name=\"821\">821</a>|Allocation Failure|  | | <a name=\"822\">822</a>|Reconciliation run not found|  | | <a name=\"823\">823</a>|Reconciliation break not found|  | | <a name=\"824\">824</a>|Entity link type could not be deleted because it doesn't exist.|  | 
 *
 * The version of the OpenAPI document: 1.0.137
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
    public interface ITransactionPortfoliosApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// AdjustHoldings: Adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>AdjustHolding</returns>
        AdjustHolding AdjustHoldings(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>));

        /// <summary>
        /// AdjustHoldings: Adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>ApiResponse of AdjustHolding</returns>
        ApiResponse<AdjustHolding> AdjustHoldingsWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] BatchAdjustHoldings: Batch adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime in each request.                Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each adjustment in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The selected set of holdings to adjust to the provided targets for the               transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>BatchAdjustHoldingsResponse</returns>
        BatchAdjustHoldingsResponse BatchAdjustHoldings(string scope, string code, string successMode, Dictionary<string, AdjustHoldingForDateRequest> requestBody, List<string> reconciliationMethods = default(List<string>));

        /// <summary>
        /// [EARLY ACCESS] BatchAdjustHoldings: Batch adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime in each request.                Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each adjustment in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The selected set of holdings to adjust to the provided targets for the               transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>ApiResponse of BatchAdjustHoldingsResponse</returns>
        ApiResponse<BatchAdjustHoldingsResponse> BatchAdjustHoldingsWithHttpInfo(string scope, string code, string successMode, Dictionary<string, AdjustHoldingForDateRequest> requestBody, List<string> reconciliationMethods = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] BatchUpsertTransactions: Batch upsert transactions
        /// </summary>
        /// <remarks>
        /// Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.    Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each transaction in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial.</param>
        /// <param name="requestBody">The payload describing the transactions to be created or updated.</param>
        /// <returns>BatchUpsertPortfolioTransactionsResponse</returns>
        BatchUpsertPortfolioTransactionsResponse BatchUpsertTransactions(string scope, string code, string successMode, Dictionary<string, TransactionRequest> requestBody);

        /// <summary>
        /// [EARLY ACCESS] BatchUpsertTransactions: Batch upsert transactions
        /// </summary>
        /// <remarks>
        /// Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.    Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each transaction in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial.</param>
        /// <param name="requestBody">The payload describing the transactions to be created or updated.</param>
        /// <returns>ApiResponse of BatchUpsertPortfolioTransactionsResponse</returns>
        ApiResponse<BatchUpsertPortfolioTransactionsResponse> BatchUpsertTransactionsWithHttpInfo(string scope, string code, string successMode, Dictionary<string, TransactionRequest> requestBody);
        /// <summary>
        /// BuildTransactions: Build transactions
        /// </summary>
        /// <remarks>
        /// Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>VersionedResourceListOfOutputTransaction</returns>
        VersionedResourceListOfOutputTransaction BuildTransactions(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string));

        /// <summary>
        /// BuildTransactions: Build transactions
        /// </summary>
        /// <remarks>
        /// Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfOutputTransaction</returns>
        ApiResponse<VersionedResourceListOfOutputTransaction> BuildTransactionsWithHttpInfo(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string));
        /// <summary>
        /// CancelAdjustHoldings: Cancel adjust holdings
        /// </summary>
        /// <remarks>
        /// Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse CancelAdjustHoldings(string scope, string code, DateTimeOrCutLabel effectiveAt);

        /// <summary>
        /// CancelAdjustHoldings: Cancel adjust holdings
        /// </summary>
        /// <remarks>
        /// Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> CancelAdjustHoldingsWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt);
        /// <summary>
        /// CancelTransactions: Cancel transactions
        /// </summary>
        /// <remarks>
        /// Cancel one or more transactions from the transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse CancelTransactions(string scope, string code, List<string> transactionIds);

        /// <summary>
        /// CancelTransactions: Cancel transactions
        /// </summary>
        /// <remarks>
        /// Cancel one or more transactions from the transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> CancelTransactionsWithHttpInfo(string scope, string code, List<string> transactionIds);
        /// <summary>
        /// CreatePortfolio: Create portfolio
        /// </summary>
        /// <remarks>
        /// Create a transaction portfolio in a particular scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <returns>Portfolio</returns>
        Portfolio CreatePortfolio(string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest);

        /// <summary>
        /// CreatePortfolio: Create portfolio
        /// </summary>
        /// <remarks>
        /// Create a transaction portfolio in a particular scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <returns>ApiResponse of Portfolio</returns>
        ApiResponse<Portfolio> CreatePortfolioWithHttpInfo(string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest);
        /// <summary>
        /// DeletePropertiesFromTransaction: Delete properties from transaction
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single transaction in a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePropertiesFromTransaction(string scope, string code, string transactionId, List<string> propertyKeys);

        /// <summary>
        /// DeletePropertiesFromTransaction: Delete properties from transaction
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single transaction in a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePropertiesFromTransactionWithHttpInfo(string scope, string code, string transactionId, List<string> propertyKeys);
        /// <summary>
        /// GetA2BData: Get A2B data
        /// </summary>
        /// <remarks>
        /// Get an A2B report for the given portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>VersionedResourceListOfA2BDataRecord</returns>
        VersionedResourceListOfA2BDataRecord GetA2BData(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string));

        /// <summary>
        /// GetA2BData: Get A2B data
        /// </summary>
        /// <remarks>
        /// Get an A2B report for the given portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfA2BDataRecord</returns>
        ApiResponse<VersionedResourceListOfA2BDataRecord> GetA2BDataWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string));
        /// <summary>
        /// GetA2BMovements: Get an A2B report at the movement level for the given portfolio.
        /// </summary>
        /// <remarks>
        /// Get an A2B report at the movement level for the given portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B movement report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B movement report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>VersionedResourceListOfA2BMovementRecord</returns>
        VersionedResourceListOfA2BMovementRecord GetA2BMovements(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string));

        /// <summary>
        /// GetA2BMovements: Get an A2B report at the movement level for the given portfolio.
        /// </summary>
        /// <remarks>
        /// Get an A2B report at the movement level for the given portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B movement report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B movement report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfA2BMovementRecord</returns>
        ApiResponse<VersionedResourceListOfA2BMovementRecord> GetA2BMovementsWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string));
        /// <summary>
        /// GetDetails: Get details
        /// </summary>
        /// <remarks>
        /// Get certain details associated with a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <returns>PortfolioDetails</returns>
        PortfolioDetails GetDetails(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// GetDetails: Get details
        /// </summary>
        /// <remarks>
        /// Get certain details associated with a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioDetails</returns>
        ApiResponse<PortfolioDetails> GetDetailsWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// GetHoldings: Get holdings
        /// </summary>
        /// <remarks>
        /// Calculate holdings for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot;, \&quot;Holding\&quot;, \&quot;Custodian Account\&quot; or \&quot;Portfolio\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>VersionedResourceListOfPortfolioHolding</returns>
        VersionedResourceListOfPortfolioHolding GetHoldings(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?));

        /// <summary>
        /// GetHoldings: Get holdings
        /// </summary>
        /// <remarks>
        /// Calculate holdings for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot;, \&quot;Holding\&quot;, \&quot;Custodian Account\&quot; or \&quot;Portfolio\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfPortfolioHolding</returns>
        ApiResponse<VersionedResourceListOfPortfolioHolding> GetHoldingsWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?));
        /// <summary>
        /// GetHoldingsAdjustment: Get holdings adjustment
        /// </summary>
        /// <remarks>
        /// Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the ‘Instrument&#39; domain to decorate onto holdings adjustments.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.              Note that properties from the &#39;Holding’ domain are automatically returned. (optional)</param>
        /// <returns>HoldingsAdjustment</returns>
        HoldingsAdjustment GetHoldingsAdjustment(string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>));

        /// <summary>
        /// GetHoldingsAdjustment: Get holdings adjustment
        /// </summary>
        /// <remarks>
        /// Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the ‘Instrument&#39; domain to decorate onto holdings adjustments.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.              Note that properties from the &#39;Holding’ domain are automatically returned. (optional)</param>
        /// <returns>ApiResponse of HoldingsAdjustment</returns>
        ApiResponse<HoldingsAdjustment> GetHoldingsAdjustmentWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>));
        /// <summary>
        /// GetPortfolioCashLadder: Get portfolio cash ladder
        /// </summary>
        /// <remarks>
        /// Get a cash ladder for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="effectiveAt">The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <param name="excludeUnsettledTrades">If absent or set to false, cashflows will returned based on trade date - more specifically, cashflows from any unsettled trades will be included in the results. If set to true, unsettled trades will be excluded from the result set. (optional, default to false)</param>
        /// <returns>ResourceListOfPortfolioCashLadder</returns>
        ResourceListOfPortfolioCashLadder GetPortfolioCashLadder(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string), bool? excludeUnsettledTrades = default(bool?));

        /// <summary>
        /// GetPortfolioCashLadder: Get portfolio cash ladder
        /// </summary>
        /// <remarks>
        /// Get a cash ladder for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="effectiveAt">The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <param name="excludeUnsettledTrades">If absent or set to false, cashflows will returned based on trade date - more specifically, cashflows from any unsettled trades will be included in the results. If set to true, unsettled trades will be excluded from the result set. (optional, default to false)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolioCashLadder</returns>
        ApiResponse<ResourceListOfPortfolioCashLadder> GetPortfolioCashLadderWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string), bool? excludeUnsettledTrades = default(bool?));
        /// <summary>
        /// GetPortfolioCashStatement: Get portfolio cash statement
        /// </summary>
        /// <remarks>
        /// Get a cash statement for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <returns>ResourceListOfPortfolioCashFlow</returns>
        ResourceListOfPortfolioCashFlow GetPortfolioCashStatement(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string));

        /// <summary>
        /// GetPortfolioCashStatement: Get portfolio cash statement
        /// </summary>
        /// <remarks>
        /// Get a cash statement for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolioCashFlow</returns>
        ApiResponse<ResourceListOfPortfolioCashFlow> GetPortfolioCashStatementWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string));
        /// <summary>
        /// [EARLY ACCESS] GetTransactionHistory: Get the history of a transaction
        /// </summary>
        /// <remarks>
        /// Get all of the changes that have happened to a transaction.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the history of the transaction. Defaults              to return the latest version if not specified. (optional)</param>
        /// <returns>ResourceListOfChangeHistory</returns>
        ResourceListOfChangeHistory GetTransactionHistory(string scope, string code, string transactionId, DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] GetTransactionHistory: Get the history of a transaction
        /// </summary>
        /// <remarks>
        /// Get all of the changes that have happened to a transaction.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the history of the transaction. Defaults              to return the latest version if not specified. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfChangeHistory</returns>
        ApiResponse<ResourceListOfChangeHistory> GetTransactionHistoryWithHttpInfo(string scope, string code, string transactionId, DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// GetTransactions: Get transactions
        /// </summary>
        /// <remarks>
        /// Retrieve all the transactions that occurred during a particular time interval.                If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, \&quot;LegalEntity\&quot; or \&quot;CustodianAccount\&quot; domain to decorate onto               transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or               &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. The current behaviour is               to return all transactions if possible, but this will change to defaulting to 1000 if not specified in the future. It is recommended               to populate this field to enable pagination. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <returns>VersionedResourceListOfTransaction</returns>
        VersionedResourceListOfTransaction GetTransactions(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), string page = default(string), int? limit = default(int?), bool? showCancelledTransactions = default(bool?));

        /// <summary>
        /// GetTransactions: Get transactions
        /// </summary>
        /// <remarks>
        /// Retrieve all the transactions that occurred during a particular time interval.                If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, \&quot;LegalEntity\&quot; or \&quot;CustodianAccount\&quot; domain to decorate onto               transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or               &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. The current behaviour is               to return all transactions if possible, but this will change to defaulting to 1000 if not specified in the future. It is recommended               to populate this field to enable pagination. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfTransaction</returns>
        ApiResponse<VersionedResourceListOfTransaction> GetTransactionsWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), string page = default(string), int? limit = default(int?), bool? showCancelledTransactions = default(bool?));
        /// <summary>
        /// ListHoldingsAdjustments: List holdings adjustments
        /// </summary>
        /// <remarks>
        /// List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <returns>ResourceListOfHoldingsAdjustmentHeader</returns>
        ResourceListOfHoldingsAdjustmentHeader ListHoldingsAdjustments(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// ListHoldingsAdjustments: List holdings adjustments
        /// </summary>
        /// <remarks>
        /// List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfHoldingsAdjustmentHeader</returns>
        ApiResponse<ResourceListOfHoldingsAdjustmentHeader> ListHoldingsAdjustmentsWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] PatchPortfolioDetails: Patch portfolio details
        /// </summary>
        /// <remarks>
        /// Create or update certain details for a particular transaction portfolio.  The behaviour is defined by the JSON Patch specification.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.  Currently supported properties are: SubHoldingKeys, BaseCurrency, AmortisationMethod
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="operation">The patch document.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified.               Note that this will affect all bitemporal entities in the request, but will not be used for any perpetual entities. (optional)</param>
        /// <returns>PortfolioDetails</returns>
        PortfolioDetails PatchPortfolioDetails(string scope, string code, List<Operation> operation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));

        /// <summary>
        /// [EARLY ACCESS] PatchPortfolioDetails: Patch portfolio details
        /// </summary>
        /// <remarks>
        /// Create or update certain details for a particular transaction portfolio.  The behaviour is defined by the JSON Patch specification.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.  Currently supported properties are: SubHoldingKeys, BaseCurrency, AmortisationMethod
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="operation">The patch document.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified.               Note that this will affect all bitemporal entities in the request, but will not be used for any perpetual entities. (optional)</param>
        /// <returns>ApiResponse of PortfolioDetails</returns>
        ApiResponse<PortfolioDetails> PatchPortfolioDetailsWithHttpInfo(string scope, string code, List<Operation> operation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));
        /// <summary>
        /// [EARLY ACCESS] ResolveInstrument: Resolve instrument
        /// </summary>
        /// <remarks>
        /// Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified  period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="reResolve">When set to true, instrument resolution will be attempted for all transactions and holdings for the given identifier and date range.              When set to false (default behaviour), instrument resolution will only be attempted for those transactions and holdings that were previously unresolved. (optional, default to false)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the             transaction and holdings. (optional)</param>
        /// <returns>UpsertPortfolioTransactionsResponse</returns>
        UpsertPortfolioTransactionsResponse ResolveInstrument(string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), bool? reResolve = default(bool?), Dictionary<string, string> requestBody = default(Dictionary<string, string>));

        /// <summary>
        /// [EARLY ACCESS] ResolveInstrument: Resolve instrument
        /// </summary>
        /// <remarks>
        /// Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified  period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="reResolve">When set to true, instrument resolution will be attempted for all transactions and holdings for the given identifier and date range.              When set to false (default behaviour), instrument resolution will only be attempted for those transactions and holdings that were previously unresolved. (optional, default to false)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the             transaction and holdings. (optional)</param>
        /// <returns>ApiResponse of UpsertPortfolioTransactionsResponse</returns>
        ApiResponse<UpsertPortfolioTransactionsResponse> ResolveInstrumentWithHttpInfo(string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), bool? reResolve = default(bool?), Dictionary<string, string> requestBody = default(Dictionary<string, string>));
        /// <summary>
        /// SetHoldings: Set holdings
        /// </summary>
        /// <remarks>
        /// Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>AdjustHolding</returns>
        AdjustHolding SetHoldings(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>));

        /// <summary>
        /// SetHoldings: Set holdings
        /// </summary>
        /// <remarks>
        /// Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>ApiResponse of AdjustHolding</returns>
        ApiResponse<AdjustHolding> SetHoldingsWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>));
        /// <summary>
        /// UpsertPortfolioDetails: Upsert portfolio details
        /// </summary>
        /// <remarks>
        /// Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <returns>PortfolioDetails</returns>
        PortfolioDetails UpsertPortfolioDetails(string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));

        /// <summary>
        /// UpsertPortfolioDetails: Upsert portfolio details
        /// </summary>
        /// <remarks>
        /// Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioDetails</returns>
        ApiResponse<PortfolioDetails> UpsertPortfolioDetailsWithHttpInfo(string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));
        /// <summary>
        /// UpsertTransactionProperties: Upsert transaction properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <returns>UpsertTransactionPropertiesResponse</returns>
        UpsertTransactionPropertiesResponse UpsertTransactionProperties(string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody);

        /// <summary>
        /// UpsertTransactionProperties: Upsert transaction properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <returns>ApiResponse of UpsertTransactionPropertiesResponse</returns>
        ApiResponse<UpsertTransactionPropertiesResponse> UpsertTransactionPropertiesWithHttpInfo(string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody);
        /// <summary>
        /// UpsertTransactions: Upsert transactions
        /// </summary>
        /// <remarks>
        /// Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <returns>UpsertPortfolioTransactionsResponse</returns>
        UpsertPortfolioTransactionsResponse UpsertTransactions(string scope, string code, List<TransactionRequest> transactionRequest);

        /// <summary>
        /// UpsertTransactions: Upsert transactions
        /// </summary>
        /// <remarks>
        /// Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <returns>ApiResponse of UpsertPortfolioTransactionsResponse</returns>
        ApiResponse<UpsertPortfolioTransactionsResponse> UpsertTransactionsWithHttpInfo(string scope, string code, List<TransactionRequest> transactionRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionPortfoliosApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// AdjustHoldings: Adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdjustHolding</returns>
        System.Threading.Tasks.Task<AdjustHolding> AdjustHoldingsAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// AdjustHoldings: Adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdjustHolding)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdjustHolding>> AdjustHoldingsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] BatchAdjustHoldings: Batch adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime in each request.                Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each adjustment in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The selected set of holdings to adjust to the provided targets for the               transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BatchAdjustHoldingsResponse</returns>
        System.Threading.Tasks.Task<BatchAdjustHoldingsResponse> BatchAdjustHoldingsAsync(string scope, string code, string successMode, Dictionary<string, AdjustHoldingForDateRequest> requestBody, List<string> reconciliationMethods = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] BatchAdjustHoldings: Batch adjust holdings
        /// </summary>
        /// <remarks>
        /// Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime in each request.                Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each adjustment in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The selected set of holdings to adjust to the provided targets for the               transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BatchAdjustHoldingsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BatchAdjustHoldingsResponse>> BatchAdjustHoldingsWithHttpInfoAsync(string scope, string code, string successMode, Dictionary<string, AdjustHoldingForDateRequest> requestBody, List<string> reconciliationMethods = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] BatchUpsertTransactions: Batch upsert transactions
        /// </summary>
        /// <remarks>
        /// Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.    Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each transaction in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial.</param>
        /// <param name="requestBody">The payload describing the transactions to be created or updated.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BatchUpsertPortfolioTransactionsResponse</returns>
        System.Threading.Tasks.Task<BatchUpsertPortfolioTransactionsResponse> BatchUpsertTransactionsAsync(string scope, string code, string successMode, Dictionary<string, TransactionRequest> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] BatchUpsertTransactions: Batch upsert transactions
        /// </summary>
        /// <remarks>
        /// Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.    Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each transaction in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial.</param>
        /// <param name="requestBody">The payload describing the transactions to be created or updated.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BatchUpsertPortfolioTransactionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BatchUpsertPortfolioTransactionsResponse>> BatchUpsertTransactionsWithHttpInfoAsync(string scope, string code, string successMode, Dictionary<string, TransactionRequest> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// BuildTransactions: Build transactions
        /// </summary>
        /// <remarks>
        /// Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfOutputTransaction</returns>
        System.Threading.Tasks.Task<VersionedResourceListOfOutputTransaction> BuildTransactionsAsync(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// BuildTransactions: Build transactions
        /// </summary>
        /// <remarks>
        /// Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfOutputTransaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfOutputTransaction>> BuildTransactionsWithHttpInfoAsync(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// CancelAdjustHoldings: Cancel adjust holdings
        /// </summary>
        /// <remarks>
        /// Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> CancelAdjustHoldingsAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// CancelAdjustHoldings: Cancel adjust holdings
        /// </summary>
        /// <remarks>
        /// Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> CancelAdjustHoldingsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// CancelTransactions: Cancel transactions
        /// </summary>
        /// <remarks>
        /// Cancel one or more transactions from the transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> CancelTransactionsAsync(string scope, string code, List<string> transactionIds, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// CancelTransactions: Cancel transactions
        /// </summary>
        /// <remarks>
        /// Cancel one or more transactions from the transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> CancelTransactionsWithHttpInfoAsync(string scope, string code, List<string> transactionIds, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// CreatePortfolio: Create portfolio
        /// </summary>
        /// <remarks>
        /// Create a transaction portfolio in a particular scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Portfolio</returns>
        System.Threading.Tasks.Task<Portfolio> CreatePortfolioAsync(string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// CreatePortfolio: Create portfolio
        /// </summary>
        /// <remarks>
        /// Create a transaction portfolio in a particular scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<Portfolio>> CreatePortfolioWithHttpInfoAsync(string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// DeletePropertiesFromTransaction: Delete properties from transaction
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single transaction in a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePropertiesFromTransactionAsync(string scope, string code, string transactionId, List<string> propertyKeys, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// DeletePropertiesFromTransaction: Delete properties from transaction
        /// </summary>
        /// <remarks>
        /// Delete one or more properties from a single transaction in a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePropertiesFromTransactionWithHttpInfoAsync(string scope, string code, string transactionId, List<string> propertyKeys, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetA2BData: Get A2B data
        /// </summary>
        /// <remarks>
        /// Get an A2B report for the given portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfA2BDataRecord</returns>
        System.Threading.Tasks.Task<VersionedResourceListOfA2BDataRecord> GetA2BDataAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetA2BData: Get A2B data
        /// </summary>
        /// <remarks>
        /// Get an A2B report for the given portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfA2BDataRecord)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfA2BDataRecord>> GetA2BDataWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetA2BMovements: Get an A2B report at the movement level for the given portfolio.
        /// </summary>
        /// <remarks>
        /// Get an A2B report at the movement level for the given portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B movement report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B movement report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfA2BMovementRecord</returns>
        System.Threading.Tasks.Task<VersionedResourceListOfA2BMovementRecord> GetA2BMovementsAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetA2BMovements: Get an A2B report at the movement level for the given portfolio.
        /// </summary>
        /// <remarks>
        /// Get an A2B report at the movement level for the given portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B movement report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B movement report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfA2BMovementRecord)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfA2BMovementRecord>> GetA2BMovementsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetDetails: Get details
        /// </summary>
        /// <remarks>
        /// Get certain details associated with a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioDetails</returns>
        System.Threading.Tasks.Task<PortfolioDetails> GetDetailsAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetDetails: Get details
        /// </summary>
        /// <remarks>
        /// Get certain details associated with a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioDetails>> GetDetailsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetHoldings: Get holdings
        /// </summary>
        /// <remarks>
        /// Calculate holdings for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot;, \&quot;Holding\&quot;, \&quot;Custodian Account\&quot; or \&quot;Portfolio\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfPortfolioHolding</returns>
        System.Threading.Tasks.Task<VersionedResourceListOfPortfolioHolding> GetHoldingsAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetHoldings: Get holdings
        /// </summary>
        /// <remarks>
        /// Calculate holdings for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot;, \&quot;Holding\&quot;, \&quot;Custodian Account\&quot; or \&quot;Portfolio\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfPortfolioHolding)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfPortfolioHolding>> GetHoldingsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetHoldingsAdjustment: Get holdings adjustment
        /// </summary>
        /// <remarks>
        /// Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the ‘Instrument&#39; domain to decorate onto holdings adjustments.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.              Note that properties from the &#39;Holding’ domain are automatically returned. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of HoldingsAdjustment</returns>
        System.Threading.Tasks.Task<HoldingsAdjustment> GetHoldingsAdjustmentAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetHoldingsAdjustment: Get holdings adjustment
        /// </summary>
        /// <remarks>
        /// Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the ‘Instrument&#39; domain to decorate onto holdings adjustments.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.              Note that properties from the &#39;Holding’ domain are automatically returned. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (HoldingsAdjustment)</returns>
        System.Threading.Tasks.Task<ApiResponse<HoldingsAdjustment>> GetHoldingsAdjustmentWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetPortfolioCashLadder: Get portfolio cash ladder
        /// </summary>
        /// <remarks>
        /// Get a cash ladder for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="effectiveAt">The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <param name="excludeUnsettledTrades">If absent or set to false, cashflows will returned based on trade date - more specifically, cashflows from any unsettled trades will be included in the results. If set to true, unsettled trades will be excluded from the result set. (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPortfolioCashLadder</returns>
        System.Threading.Tasks.Task<ResourceListOfPortfolioCashLadder> GetPortfolioCashLadderAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string), bool? excludeUnsettledTrades = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetPortfolioCashLadder: Get portfolio cash ladder
        /// </summary>
        /// <remarks>
        /// Get a cash ladder for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="effectiveAt">The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <param name="excludeUnsettledTrades">If absent or set to false, cashflows will returned based on trade date - more specifically, cashflows from any unsettled trades will be included in the results. If set to true, unsettled trades will be excluded from the result set. (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolioCashLadder)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolioCashLadder>> GetPortfolioCashLadderWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string), bool? excludeUnsettledTrades = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetPortfolioCashStatement: Get portfolio cash statement
        /// </summary>
        /// <remarks>
        /// Get a cash statement for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPortfolioCashFlow</returns>
        System.Threading.Tasks.Task<ResourceListOfPortfolioCashFlow> GetPortfolioCashStatementAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetPortfolioCashStatement: Get portfolio cash statement
        /// </summary>
        /// <remarks>
        /// Get a cash statement for a transaction portfolio.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolioCashFlow)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPortfolioCashFlow>> GetPortfolioCashStatementWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetTransactionHistory: Get the history of a transaction
        /// </summary>
        /// <remarks>
        /// Get all of the changes that have happened to a transaction.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the history of the transaction. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfChangeHistory</returns>
        System.Threading.Tasks.Task<ResourceListOfChangeHistory> GetTransactionHistoryAsync(string scope, string code, string transactionId, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetTransactionHistory: Get the history of a transaction
        /// </summary>
        /// <remarks>
        /// Get all of the changes that have happened to a transaction.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the history of the transaction. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfChangeHistory)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfChangeHistory>> GetTransactionHistoryWithHttpInfoAsync(string scope, string code, string transactionId, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetTransactions: Get transactions
        /// </summary>
        /// <remarks>
        /// Retrieve all the transactions that occurred during a particular time interval.                If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, \&quot;LegalEntity\&quot; or \&quot;CustodianAccount\&quot; domain to decorate onto               transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or               &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. The current behaviour is               to return all transactions if possible, but this will change to defaulting to 1000 if not specified in the future. It is recommended               to populate this field to enable pagination. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfTransaction</returns>
        System.Threading.Tasks.Task<VersionedResourceListOfTransaction> GetTransactionsAsync(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), string page = default(string), int? limit = default(int?), bool? showCancelledTransactions = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetTransactions: Get transactions
        /// </summary>
        /// <remarks>
        /// Retrieve all the transactions that occurred during a particular time interval.                If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, \&quot;LegalEntity\&quot; or \&quot;CustodianAccount\&quot; domain to decorate onto               transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or               &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. The current behaviour is               to return all transactions if possible, but this will change to defaulting to 1000 if not specified in the future. It is recommended               to populate this field to enable pagination. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfTransaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedResourceListOfTransaction>> GetTransactionsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), string page = default(string), int? limit = default(int?), bool? showCancelledTransactions = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// ListHoldingsAdjustments: List holdings adjustments
        /// </summary>
        /// <remarks>
        /// List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfHoldingsAdjustmentHeader</returns>
        System.Threading.Tasks.Task<ResourceListOfHoldingsAdjustmentHeader> ListHoldingsAdjustmentsAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// ListHoldingsAdjustments: List holdings adjustments
        /// </summary>
        /// <remarks>
        /// List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfHoldingsAdjustmentHeader)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfHoldingsAdjustmentHeader>> ListHoldingsAdjustmentsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] PatchPortfolioDetails: Patch portfolio details
        /// </summary>
        /// <remarks>
        /// Create or update certain details for a particular transaction portfolio.  The behaviour is defined by the JSON Patch specification.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.  Currently supported properties are: SubHoldingKeys, BaseCurrency, AmortisationMethod
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="operation">The patch document.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified.               Note that this will affect all bitemporal entities in the request, but will not be used for any perpetual entities. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioDetails</returns>
        System.Threading.Tasks.Task<PortfolioDetails> PatchPortfolioDetailsAsync(string scope, string code, List<Operation> operation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] PatchPortfolioDetails: Patch portfolio details
        /// </summary>
        /// <remarks>
        /// Create or update certain details for a particular transaction portfolio.  The behaviour is defined by the JSON Patch specification.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.  Currently supported properties are: SubHoldingKeys, BaseCurrency, AmortisationMethod
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="operation">The patch document.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified.               Note that this will affect all bitemporal entities in the request, but will not be used for any perpetual entities. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioDetails>> PatchPortfolioDetailsWithHttpInfoAsync(string scope, string code, List<Operation> operation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] ResolveInstrument: Resolve instrument
        /// </summary>
        /// <remarks>
        /// Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified  period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="reResolve">When set to true, instrument resolution will be attempted for all transactions and holdings for the given identifier and date range.              When set to false (default behaviour), instrument resolution will only be attempted for those transactions and holdings that were previously unresolved. (optional, default to false)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the             transaction and holdings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpsertPortfolioTransactionsResponse</returns>
        System.Threading.Tasks.Task<UpsertPortfolioTransactionsResponse> ResolveInstrumentAsync(string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), bool? reResolve = default(bool?), Dictionary<string, string> requestBody = default(Dictionary<string, string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] ResolveInstrument: Resolve instrument
        /// </summary>
        /// <remarks>
        /// Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified  period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="reResolve">When set to true, instrument resolution will be attempted for all transactions and holdings for the given identifier and date range.              When set to false (default behaviour), instrument resolution will only be attempted for those transactions and holdings that were previously unresolved. (optional, default to false)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the             transaction and holdings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpsertPortfolioTransactionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertPortfolioTransactionsResponse>> ResolveInstrumentWithHttpInfoAsync(string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), bool? reResolve = default(bool?), Dictionary<string, string> requestBody = default(Dictionary<string, string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// SetHoldings: Set holdings
        /// </summary>
        /// <remarks>
        /// Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdjustHolding</returns>
        System.Threading.Tasks.Task<AdjustHolding> SetHoldingsAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// SetHoldings: Set holdings
        /// </summary>
        /// <remarks>
        /// Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdjustHolding)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdjustHolding>> SetHoldingsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// UpsertPortfolioDetails: Upsert portfolio details
        /// </summary>
        /// <remarks>
        /// Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioDetails</returns>
        System.Threading.Tasks.Task<PortfolioDetails> UpsertPortfolioDetailsAsync(string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// UpsertPortfolioDetails: Upsert portfolio details
        /// </summary>
        /// <remarks>
        /// Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortfolioDetails>> UpsertPortfolioDetailsWithHttpInfoAsync(string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// UpsertTransactionProperties: Upsert transaction properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpsertTransactionPropertiesResponse</returns>
        System.Threading.Tasks.Task<UpsertTransactionPropertiesResponse> UpsertTransactionPropertiesAsync(string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// UpsertTransactionProperties: Upsert transaction properties
        /// </summary>
        /// <remarks>
        /// Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpsertTransactionPropertiesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertTransactionPropertiesResponse>> UpsertTransactionPropertiesWithHttpInfoAsync(string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// UpsertTransactions: Upsert transactions
        /// </summary>
        /// <remarks>
        /// Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpsertPortfolioTransactionsResponse</returns>
        System.Threading.Tasks.Task<UpsertPortfolioTransactionsResponse> UpsertTransactionsAsync(string scope, string code, List<TransactionRequest> transactionRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// UpsertTransactions: Upsert transactions
        /// </summary>
        /// <remarks>
        /// Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpsertPortfolioTransactionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertPortfolioTransactionsResponse>> UpsertTransactionsWithHttpInfoAsync(string scope, string code, List<TransactionRequest> transactionRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionPortfoliosApi : ITransactionPortfoliosApiSync, ITransactionPortfoliosApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransactionPortfoliosApi : ITransactionPortfoliosApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionPortfoliosApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionPortfoliosApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionPortfoliosApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionPortfoliosApi(String basePath)
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
        /// Initializes a new instance of the <see cref="TransactionPortfoliosApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionPortfoliosApi(Lusid.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionPortfoliosApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TransactionPortfoliosApi(Lusid.Sdk.Client.ISynchronousClient client, Lusid.Sdk.Client.IAsynchronousClient asyncClient, Lusid.Sdk.Client.IReadableConfiguration configuration)
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
        /// AdjustHoldings: Adjust holdings Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>AdjustHolding</returns>
        public AdjustHolding AdjustHoldings(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<AdjustHolding> localVarResponse = AdjustHoldingsWithHttpInfo(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods);
            return localVarResponse.Data;
        }

        /// <summary>
        /// AdjustHoldings: Adjust holdings Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>ApiResponse of AdjustHolding</returns>
        public Lusid.Sdk.Client.ApiResponse<AdjustHolding> AdjustHoldingsWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->AdjustHoldings");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->AdjustHoldings");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->AdjustHoldings");

            // verify the required parameter 'adjustHoldingRequest' is set
            if (adjustHoldingRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'adjustHoldingRequest' when calling TransactionPortfoliosApi->AdjustHoldings");

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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            if (reconciliationMethods != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "reconciliationMethods", reconciliationMethods));
            }
            localVarRequestOptions.Data = adjustHoldingRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Post<AdjustHolding>("/api/transactionportfolios/{scope}/{code}/holdings", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AdjustHoldings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// AdjustHoldings: Adjust holdings Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdjustHolding</returns>
        public async System.Threading.Tasks.Task<AdjustHolding> AdjustHoldingsAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<AdjustHolding> localVarResponse = await AdjustHoldingsWithHttpInfoAsync(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// AdjustHoldings: Adjust holdings Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The selected set of holdings to adjust to the provided targets for the              transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdjustHolding)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<AdjustHolding>> AdjustHoldingsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->AdjustHoldings");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->AdjustHoldings");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->AdjustHoldings");

            // verify the required parameter 'adjustHoldingRequest' is set
            if (adjustHoldingRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'adjustHoldingRequest' when calling TransactionPortfoliosApi->AdjustHoldings");


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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            if (reconciliationMethods != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "reconciliationMethods", reconciliationMethods));
            }
            localVarRequestOptions.Data = adjustHoldingRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AdjustHolding>("/api/transactionportfolios/{scope}/{code}/holdings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AdjustHoldings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] BatchAdjustHoldings: Batch adjust holdings Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime in each request.                Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each adjustment in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The selected set of holdings to adjust to the provided targets for the               transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>BatchAdjustHoldingsResponse</returns>
        public BatchAdjustHoldingsResponse BatchAdjustHoldings(string scope, string code, string successMode, Dictionary<string, AdjustHoldingForDateRequest> requestBody, List<string> reconciliationMethods = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<BatchAdjustHoldingsResponse> localVarResponse = BatchAdjustHoldingsWithHttpInfo(scope, code, successMode, requestBody, reconciliationMethods);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] BatchAdjustHoldings: Batch adjust holdings Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime in each request.                Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each adjustment in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The selected set of holdings to adjust to the provided targets for the               transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>ApiResponse of BatchAdjustHoldingsResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<BatchAdjustHoldingsResponse> BatchAdjustHoldingsWithHttpInfo(string scope, string code, string successMode, Dictionary<string, AdjustHoldingForDateRequest> requestBody, List<string> reconciliationMethods = default(List<string>))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->BatchAdjustHoldings");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->BatchAdjustHoldings");

            // verify the required parameter 'successMode' is set
            if (successMode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'successMode' when calling TransactionPortfoliosApi->BatchAdjustHoldings");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling TransactionPortfoliosApi->BatchAdjustHoldings");

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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "successMode", successMode));
            if (reconciliationMethods != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "reconciliationMethods", reconciliationMethods));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Post<BatchAdjustHoldingsResponse>("/api/transactionportfolios/{scope}/{code}/holdings/$batchAdjust", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BatchAdjustHoldings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] BatchAdjustHoldings: Batch adjust holdings Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime in each request.                Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each adjustment in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The selected set of holdings to adjust to the provided targets for the               transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BatchAdjustHoldingsResponse</returns>
        public async System.Threading.Tasks.Task<BatchAdjustHoldingsResponse> BatchAdjustHoldingsAsync(string scope, string code, string successMode, Dictionary<string, AdjustHoldingForDateRequest> requestBody, List<string> reconciliationMethods = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<BatchAdjustHoldingsResponse> localVarResponse = await BatchAdjustHoldingsWithHttpInfoAsync(scope, code, successMode, requestBody, reconciliationMethods, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] BatchAdjustHoldings: Batch adjust holdings Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime in each request.                Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each adjustment in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The selected set of holdings to adjust to the provided targets for the               transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BatchAdjustHoldingsResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<BatchAdjustHoldingsResponse>> BatchAdjustHoldingsWithHttpInfoAsync(string scope, string code, string successMode, Dictionary<string, AdjustHoldingForDateRequest> requestBody, List<string> reconciliationMethods = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->BatchAdjustHoldings");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->BatchAdjustHoldings");

            // verify the required parameter 'successMode' is set
            if (successMode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'successMode' when calling TransactionPortfoliosApi->BatchAdjustHoldings");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling TransactionPortfoliosApi->BatchAdjustHoldings");


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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "successMode", successMode));
            if (reconciliationMethods != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "reconciliationMethods", reconciliationMethods));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<BatchAdjustHoldingsResponse>("/api/transactionportfolios/{scope}/{code}/holdings/$batchAdjust", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BatchAdjustHoldings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] BatchUpsertTransactions: Batch upsert transactions Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.    Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each transaction in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial.</param>
        /// <param name="requestBody">The payload describing the transactions to be created or updated.</param>
        /// <returns>BatchUpsertPortfolioTransactionsResponse</returns>
        public BatchUpsertPortfolioTransactionsResponse BatchUpsertTransactions(string scope, string code, string successMode, Dictionary<string, TransactionRequest> requestBody)
        {
            Lusid.Sdk.Client.ApiResponse<BatchUpsertPortfolioTransactionsResponse> localVarResponse = BatchUpsertTransactionsWithHttpInfo(scope, code, successMode, requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] BatchUpsertTransactions: Batch upsert transactions Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.    Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each transaction in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial.</param>
        /// <param name="requestBody">The payload describing the transactions to be created or updated.</param>
        /// <returns>ApiResponse of BatchUpsertPortfolioTransactionsResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<BatchUpsertPortfolioTransactionsResponse> BatchUpsertTransactionsWithHttpInfo(string scope, string code, string successMode, Dictionary<string, TransactionRequest> requestBody)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->BatchUpsertTransactions");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->BatchUpsertTransactions");

            // verify the required parameter 'successMode' is set
            if (successMode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'successMode' when calling TransactionPortfoliosApi->BatchUpsertTransactions");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling TransactionPortfoliosApi->BatchUpsertTransactions");

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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "successMode", successMode));
            localVarRequestOptions.Data = requestBody;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Post<BatchUpsertPortfolioTransactionsResponse>("/api/transactionportfolios/{scope}/{code}/transactions/$batchUpsert", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BatchUpsertTransactions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] BatchUpsertTransactions: Batch upsert transactions Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.    Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each transaction in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial.</param>
        /// <param name="requestBody">The payload describing the transactions to be created or updated.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BatchUpsertPortfolioTransactionsResponse</returns>
        public async System.Threading.Tasks.Task<BatchUpsertPortfolioTransactionsResponse> BatchUpsertTransactionsAsync(string scope, string code, string successMode, Dictionary<string, TransactionRequest> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<BatchUpsertPortfolioTransactionsResponse> localVarResponse = await BatchUpsertTransactionsWithHttpInfoAsync(scope, code, successMode, requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] BatchUpsertTransactions: Batch upsert transactions Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.    Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each transaction in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial.</param>
        /// <param name="requestBody">The payload describing the transactions to be created or updated.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BatchUpsertPortfolioTransactionsResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<BatchUpsertPortfolioTransactionsResponse>> BatchUpsertTransactionsWithHttpInfoAsync(string scope, string code, string successMode, Dictionary<string, TransactionRequest> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->BatchUpsertTransactions");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->BatchUpsertTransactions");

            // verify the required parameter 'successMode' is set
            if (successMode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'successMode' when calling TransactionPortfoliosApi->BatchUpsertTransactions");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling TransactionPortfoliosApi->BatchUpsertTransactions");


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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "successMode", successMode));
            localVarRequestOptions.Data = requestBody;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<BatchUpsertPortfolioTransactionsResponse>("/api/transactionportfolios/{scope}/{code}/transactions/$batchUpsert", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BatchUpsertTransactions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// BuildTransactions: Build transactions Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>VersionedResourceListOfOutputTransaction</returns>
        public VersionedResourceListOfOutputTransaction BuildTransactions(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfOutputTransaction> localVarResponse = BuildTransactionsWithHttpInfo(scope, code, transactionQueryParameters, asAt, filter, propertyKeys, limit, page);
            return localVarResponse.Data;
        }

        /// <summary>
        /// BuildTransactions: Build transactions Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfOutputTransaction</returns>
        public Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfOutputTransaction> BuildTransactionsWithHttpInfo(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->BuildTransactions");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->BuildTransactions");

            // verify the required parameter 'transactionQueryParameters' is set
            if (transactionQueryParameters == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'transactionQueryParameters' when calling TransactionPortfoliosApi->BuildTransactions");

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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Post<VersionedResourceListOfOutputTransaction>("/api/transactionportfolios/{scope}/{code}/transactions/$build", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BuildTransactions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// BuildTransactions: Build transactions Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfOutputTransaction</returns>
        public async System.Threading.Tasks.Task<VersionedResourceListOfOutputTransaction> BuildTransactionsAsync(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfOutputTransaction> localVarResponse = await BuildTransactionsWithHttpInfoAsync(scope, code, transactionQueryParameters, asAt, filter, propertyKeys, limit, page, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// BuildTransactions: Build transactions Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionQueryParameters">The query queryParameters which control how the output transactions are built.</param>
        /// <param name="asAt">The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfOutputTransaction)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfOutputTransaction>> BuildTransactionsWithHttpInfoAsync(string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), int? limit = default(int?), string page = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->BuildTransactions");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->BuildTransactions");

            // verify the required parameter 'transactionQueryParameters' is set
            if (transactionQueryParameters == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'transactionQueryParameters' when calling TransactionPortfoliosApi->BuildTransactions");


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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<VersionedResourceListOfOutputTransaction>("/api/transactionportfolios/{scope}/{code}/transactions/$build", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BuildTransactions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// CancelAdjustHoldings: Cancel adjust holdings Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse CancelAdjustHoldings(string scope, string code, DateTimeOrCutLabel effectiveAt)
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = CancelAdjustHoldingsWithHttpInfo(scope, code, effectiveAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// CancelAdjustHoldings: Cancel adjust holdings Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> CancelAdjustHoldingsWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->CancelAdjustHoldings");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->CancelAdjustHoldings");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->CancelAdjustHoldings");

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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeletedEntityResponse>("/api/transactionportfolios/{scope}/{code}/holdings", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelAdjustHoldings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// CancelAdjustHoldings: Cancel adjust holdings Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> CancelAdjustHoldingsAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await CancelAdjustHoldingsWithHttpInfoAsync(scope, code, effectiveAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// CancelAdjustHoldings: Cancel adjust holdings Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holding adjustments should be undone.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> CancelAdjustHoldingsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->CancelAdjustHoldings");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->CancelAdjustHoldings");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->CancelAdjustHoldings");


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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/transactionportfolios/{scope}/{code}/holdings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelAdjustHoldings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// CancelTransactions: Cancel transactions Cancel one or more transactions from the transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse CancelTransactions(string scope, string code, List<string> transactionIds)
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = CancelTransactionsWithHttpInfo(scope, code, transactionIds);
            return localVarResponse.Data;
        }

        /// <summary>
        /// CancelTransactions: Cancel transactions Cancel one or more transactions from the transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> CancelTransactionsWithHttpInfo(string scope, string code, List<string> transactionIds)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->CancelTransactions");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->CancelTransactions");

            // verify the required parameter 'transactionIds' is set
            if (transactionIds == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'transactionIds' when calling TransactionPortfoliosApi->CancelTransactions");

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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "transactionIds", transactionIds));

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeletedEntityResponse>("/api/transactionportfolios/{scope}/{code}/transactions", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelTransactions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// CancelTransactions: Cancel transactions Cancel one or more transactions from the transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> CancelTransactionsAsync(string scope, string code, List<string> transactionIds, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await CancelTransactionsWithHttpInfoAsync(scope, code, transactionIds, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// CancelTransactions: Cancel transactions Cancel one or more transactions from the transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionIds">The IDs of the transactions to cancel.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> CancelTransactionsWithHttpInfoAsync(string scope, string code, List<string> transactionIds, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->CancelTransactions");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->CancelTransactions");

            // verify the required parameter 'transactionIds' is set
            if (transactionIds == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'transactionIds' when calling TransactionPortfoliosApi->CancelTransactions");


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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "transactionIds", transactionIds));

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/transactionportfolios/{scope}/{code}/transactions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelTransactions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// CreatePortfolio: Create portfolio Create a transaction portfolio in a particular scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <returns>Portfolio</returns>
        public Portfolio CreatePortfolio(string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest)
        {
            Lusid.Sdk.Client.ApiResponse<Portfolio> localVarResponse = CreatePortfolioWithHttpInfo(scope, createTransactionPortfolioRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// CreatePortfolio: Create portfolio Create a transaction portfolio in a particular scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <returns>ApiResponse of Portfolio</returns>
        public Lusid.Sdk.Client.ApiResponse<Portfolio> CreatePortfolioWithHttpInfo(string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->CreatePortfolio");

            // verify the required parameter 'createTransactionPortfolioRequest' is set
            if (createTransactionPortfolioRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'createTransactionPortfolioRequest' when calling TransactionPortfoliosApi->CreatePortfolio");

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
            localVarRequestOptions.Data = createTransactionPortfolioRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Post<Portfolio>("/api/transactionportfolios/{scope}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreatePortfolio", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// CreatePortfolio: Create portfolio Create a transaction portfolio in a particular scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Portfolio</returns>
        public async System.Threading.Tasks.Task<Portfolio> CreatePortfolioAsync(string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Portfolio> localVarResponse = await CreatePortfolioWithHttpInfoAsync(scope, createTransactionPortfolioRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// CreatePortfolio: Create portfolio Create a transaction portfolio in a particular scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope in which to create the transaction portfolio.</param>
        /// <param name="createTransactionPortfolioRequest">The definition of the transaction portfolio.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Portfolio>> CreatePortfolioWithHttpInfoAsync(string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->CreatePortfolio");

            // verify the required parameter 'createTransactionPortfolioRequest' is set
            if (createTransactionPortfolioRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'createTransactionPortfolioRequest' when calling TransactionPortfoliosApi->CreatePortfolio");


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
            localVarRequestOptions.Data = createTransactionPortfolioRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Portfolio>("/api/transactionportfolios/{scope}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreatePortfolio", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// DeletePropertiesFromTransaction: Delete properties from transaction Delete one or more properties from a single transaction in a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePropertiesFromTransaction(string scope, string code, string transactionId, List<string> propertyKeys)
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeletePropertiesFromTransactionWithHttpInfo(scope, code, transactionId, propertyKeys);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DeletePropertiesFromTransaction: Delete properties from transaction Delete one or more properties from a single transaction in a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> DeletePropertiesFromTransactionWithHttpInfo(string scope, string code, string transactionId, List<string> propertyKeys)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");

            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'transactionId' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");

            // verify the required parameter 'propertyKeys' is set
            if (propertyKeys == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKeys' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");

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
            localVarRequestOptions.PathParameters.Add("transactionId", Lusid.Sdk.Client.ClientUtils.ParameterToString(transactionId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeletedEntityResponse>("/api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePropertiesFromTransaction", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// DeletePropertiesFromTransaction: Delete properties from transaction Delete one or more properties from a single transaction in a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePropertiesFromTransactionAsync(string scope, string code, string transactionId, List<string> propertyKeys, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePropertiesFromTransactionWithHttpInfoAsync(scope, code, transactionId, propertyKeys, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DeletePropertiesFromTransaction: Delete properties from transaction Delete one or more properties from a single transaction in a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction from which to delete properties.</param>
        /// <param name="propertyKeys">The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeletePropertiesFromTransactionWithHttpInfoAsync(string scope, string code, string transactionId, List<string> propertyKeys, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");

            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'transactionId' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");

            // verify the required parameter 'propertyKeys' is set
            if (propertyKeys == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKeys' when calling TransactionPortfoliosApi->DeletePropertiesFromTransaction");


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
            localVarRequestOptions.PathParameters.Add("transactionId", Lusid.Sdk.Client.ClientUtils.ParameterToString(transactionId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePropertiesFromTransaction", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetA2BData: Get A2B data Get an A2B report for the given portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>VersionedResourceListOfA2BDataRecord</returns>
        public VersionedResourceListOfA2BDataRecord GetA2BData(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfA2BDataRecord> localVarResponse = GetA2BDataWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt, recipeIdScope, recipeIdCode, propertyKeys, filter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetA2BData: Get A2B data Get an A2B report for the given portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfA2BDataRecord</returns>
        public Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfA2BDataRecord> GetA2BDataWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetA2BData");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetA2BData");

            // verify the required parameter 'fromEffectiveAt' is set
            if (fromEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'fromEffectiveAt' when calling TransactionPortfoliosApi->GetA2BData");

            // verify the required parameter 'toEffectiveAt' is set
            if (toEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'toEffectiveAt' when calling TransactionPortfoliosApi->GetA2BData");

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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toEffectiveAt", toEffectiveAt));
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (recipeIdScope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdScope", recipeIdScope));
            }
            if (recipeIdCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdCode", recipeIdCode));
            }
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Get<VersionedResourceListOfA2BDataRecord>("/api/transactionportfolios/{scope}/{code}/a2b", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetA2BData", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetA2BData: Get A2B data Get an A2B report for the given portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfA2BDataRecord</returns>
        public async System.Threading.Tasks.Task<VersionedResourceListOfA2BDataRecord> GetA2BDataAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfA2BDataRecord> localVarResponse = await GetA2BDataWithHttpInfoAsync(scope, code, fromEffectiveAt, toEffectiveAt, asAt, recipeIdScope, recipeIdCode, propertyKeys, filter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetA2BData: Get A2B data Get an A2B report for the given portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfA2BDataRecord)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfA2BDataRecord>> GetA2BDataWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetA2BData");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetA2BData");

            // verify the required parameter 'fromEffectiveAt' is set
            if (fromEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'fromEffectiveAt' when calling TransactionPortfoliosApi->GetA2BData");

            // verify the required parameter 'toEffectiveAt' is set
            if (toEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'toEffectiveAt' when calling TransactionPortfoliosApi->GetA2BData");


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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toEffectiveAt", toEffectiveAt));
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (recipeIdScope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdScope", recipeIdScope));
            }
            if (recipeIdCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdCode", recipeIdCode));
            }
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<VersionedResourceListOfA2BDataRecord>("/api/transactionportfolios/{scope}/{code}/a2b", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetA2BData", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetA2BMovements: Get an A2B report at the movement level for the given portfolio. Get an A2B report at the movement level for the given portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B movement report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B movement report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>VersionedResourceListOfA2BMovementRecord</returns>
        public VersionedResourceListOfA2BMovementRecord GetA2BMovements(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfA2BMovementRecord> localVarResponse = GetA2BMovementsWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt, recipeIdScope, recipeIdCode, propertyKeys, filter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetA2BMovements: Get an A2B report at the movement level for the given portfolio. Get an A2B report at the movement level for the given portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B movement report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B movement report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfA2BMovementRecord</returns>
        public Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfA2BMovementRecord> GetA2BMovementsWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetA2BMovements");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetA2BMovements");

            // verify the required parameter 'fromEffectiveAt' is set
            if (fromEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'fromEffectiveAt' when calling TransactionPortfoliosApi->GetA2BMovements");

            // verify the required parameter 'toEffectiveAt' is set
            if (toEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'toEffectiveAt' when calling TransactionPortfoliosApi->GetA2BMovements");

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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toEffectiveAt", toEffectiveAt));
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (recipeIdScope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdScope", recipeIdScope));
            }
            if (recipeIdCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdCode", recipeIdCode));
            }
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Get<VersionedResourceListOfA2BMovementRecord>("/api/transactionportfolios/{scope}/{code}/a2bmovements", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetA2BMovements", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetA2BMovements: Get an A2B report at the movement level for the given portfolio. Get an A2B report at the movement level for the given portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B movement report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B movement report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfA2BMovementRecord</returns>
        public async System.Threading.Tasks.Task<VersionedResourceListOfA2BMovementRecord> GetA2BMovementsAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfA2BMovementRecord> localVarResponse = await GetA2BMovementsWithHttpInfoAsync(scope, code, fromEffectiveAt, toEffectiveAt, asAt, recipeIdScope, recipeIdCode, propertyKeys, filter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetA2BMovements: Get an A2B report at the movement level for the given portfolio. Get an A2B report at the movement level for the given portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio to retrieve the A2B movement report for.</param>
        /// <param name="code">The code of the portfolio to retrieve the A2B movement report for. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeId (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfA2BMovementRecord)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfA2BMovementRecord>> GetA2BMovementsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string recipeIdScope = default(string), string recipeIdCode = default(string), List<string> propertyKeys = default(List<string>), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetA2BMovements");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetA2BMovements");

            // verify the required parameter 'fromEffectiveAt' is set
            if (fromEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'fromEffectiveAt' when calling TransactionPortfoliosApi->GetA2BMovements");

            // verify the required parameter 'toEffectiveAt' is set
            if (toEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'toEffectiveAt' when calling TransactionPortfoliosApi->GetA2BMovements");


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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toEffectiveAt", toEffectiveAt));
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (recipeIdScope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdScope", recipeIdScope));
            }
            if (recipeIdCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdCode", recipeIdCode));
            }
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<VersionedResourceListOfA2BMovementRecord>("/api/transactionportfolios/{scope}/{code}/a2bmovements", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetA2BMovements", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetDetails: Get details Get certain details associated with a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <returns>PortfolioDetails</returns>
        public PortfolioDetails GetDetails(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioDetails> localVarResponse = GetDetailsWithHttpInfo(scope, code, effectiveAt, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetDetails: Get details Get certain details associated with a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioDetails</returns>
        public Lusid.Sdk.Client.ApiResponse<PortfolioDetails> GetDetailsWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetDetails");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetDetails");

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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Get<PortfolioDetails>("/api/transactionportfolios/{scope}/{code}/details", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDetails", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetDetails: Get details Get certain details associated with a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioDetails</returns>
        public async System.Threading.Tasks.Task<PortfolioDetails> GetDetailsAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioDetails> localVarResponse = await GetDetailsWithHttpInfoAsync(scope, code, effectiveAt, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetDetails: Get details Get certain details associated with a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioDetails)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioDetails>> GetDetailsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetDetails");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetDetails");


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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PortfolioDetails>("/api/transactionportfolios/{scope}/{code}/details", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDetails", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetHoldings: Get holdings Calculate holdings for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot;, \&quot;Holding\&quot;, \&quot;Custodian Account\&quot; or \&quot;Portfolio\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>VersionedResourceListOfPortfolioHolding</returns>
        public VersionedResourceListOfPortfolioHolding GetHoldings(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfPortfolioHolding> localVarResponse = GetHoldingsWithHttpInfo(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetHoldings: Get holdings Calculate holdings for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot;, \&quot;Holding\&quot;, \&quot;Custodian Account\&quot; or \&quot;Portfolio\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfPortfolioHolding</returns>
        public Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfPortfolioHolding> GetHoldingsWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetHoldings");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetHoldings");

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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Get<VersionedResourceListOfPortfolioHolding>("/api/transactionportfolios/{scope}/{code}/holdings", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetHoldings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetHoldings: Get holdings Calculate holdings for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot;, \&quot;Holding\&quot;, \&quot;Custodian Account\&quot; or \&quot;Portfolio\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfPortfolioHolding</returns>
        public async System.Threading.Tasks.Task<VersionedResourceListOfPortfolioHolding> GetHoldingsAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfPortfolioHolding> localVarResponse = await GetHoldingsWithHttpInfoAsync(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetHoldings: Get holdings Calculate holdings for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Instrument\&quot;, \&quot;Holding\&quot;, \&quot;Custodian Account\&quot; or \&quot;Portfolio\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. (optional)</param>
        /// <param name="byTaxlots">Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfPortfolioHolding)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfPortfolioHolding>> GetHoldingsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), bool? byTaxlots = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetHoldings");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetHoldings");


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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<VersionedResourceListOfPortfolioHolding>("/api/transactionportfolios/{scope}/{code}/holdings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetHoldings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetHoldingsAdjustment: Get holdings adjustment Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the ‘Instrument&#39; domain to decorate onto holdings adjustments.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.              Note that properties from the &#39;Holding’ domain are automatically returned. (optional)</param>
        /// <returns>HoldingsAdjustment</returns>
        public HoldingsAdjustment GetHoldingsAdjustment(string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<HoldingsAdjustment> localVarResponse = GetHoldingsAdjustmentWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetHoldingsAdjustment: Get holdings adjustment Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the ‘Instrument&#39; domain to decorate onto holdings adjustments.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.              Note that properties from the &#39;Holding’ domain are automatically returned. (optional)</param>
        /// <returns>ApiResponse of HoldingsAdjustment</returns>
        public Lusid.Sdk.Client.ApiResponse<HoldingsAdjustment> GetHoldingsAdjustmentWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetHoldingsAdjustment");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetHoldingsAdjustment");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->GetHoldingsAdjustment");

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
            localVarRequestOptions.PathParameters.Add("effectiveAt", Lusid.Sdk.Client.ClientUtils.ParameterToString(effectiveAt)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Get<HoldingsAdjustment>("/api/transactionportfolios/{scope}/{code}/holdingsadjustments/{effectiveAt}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetHoldingsAdjustment", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetHoldingsAdjustment: Get holdings adjustment Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the ‘Instrument&#39; domain to decorate onto holdings adjustments.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.              Note that properties from the &#39;Holding’ domain are automatically returned. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of HoldingsAdjustment</returns>
        public async System.Threading.Tasks.Task<HoldingsAdjustment> GetHoldingsAdjustmentAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<HoldingsAdjustment> localVarResponse = await GetHoldingsAdjustmentWithHttpInfoAsync(scope, code, effectiveAt, asAt, propertyKeys, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetHoldingsAdjustment: Get holdings adjustment Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label of the holdings adjustment.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the ‘Instrument&#39; domain to decorate onto holdings adjustments.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.              Note that properties from the &#39;Holding’ domain are automatically returned. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (HoldingsAdjustment)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<HoldingsAdjustment>> GetHoldingsAdjustmentWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), List<string> propertyKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetHoldingsAdjustment");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetHoldingsAdjustment");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->GetHoldingsAdjustment");


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
            localVarRequestOptions.PathParameters.Add("effectiveAt", Lusid.Sdk.Client.ClientUtils.ParameterToString(effectiveAt)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<HoldingsAdjustment>("/api/transactionportfolios/{scope}/{code}/holdingsadjustments/{effectiveAt}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetHoldingsAdjustment", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetPortfolioCashLadder: Get portfolio cash ladder Get a cash ladder for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="effectiveAt">The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <param name="excludeUnsettledTrades">If absent or set to false, cashflows will returned based on trade date - more specifically, cashflows from any unsettled trades will be included in the results. If set to true, unsettled trades will be excluded from the result set. (optional, default to false)</param>
        /// <returns>ResourceListOfPortfolioCashLadder</returns>
        public ResourceListOfPortfolioCashLadder GetPortfolioCashLadder(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string), bool? excludeUnsettledTrades = default(bool?))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolioCashLadder> localVarResponse = GetPortfolioCashLadderWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, effectiveAt, asAt, filter, recipeIdScope, recipeIdCode, excludeUnsettledTrades);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetPortfolioCashLadder: Get portfolio cash ladder Get a cash ladder for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="effectiveAt">The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <param name="excludeUnsettledTrades">If absent or set to false, cashflows will returned based on trade date - more specifically, cashflows from any unsettled trades will be included in the results. If set to true, unsettled trades will be excluded from the result set. (optional, default to false)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolioCashLadder</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolioCashLadder> GetPortfolioCashLadderWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string), bool? excludeUnsettledTrades = default(bool?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetPortfolioCashLadder");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetPortfolioCashLadder");

            // verify the required parameter 'fromEffectiveAt' is set
            if (fromEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'fromEffectiveAt' when calling TransactionPortfoliosApi->GetPortfolioCashLadder");

            // verify the required parameter 'toEffectiveAt' is set
            if (toEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'toEffectiveAt' when calling TransactionPortfoliosApi->GetPortfolioCashLadder");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->GetPortfolioCashLadder");

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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toEffectiveAt", toEffectiveAt));
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (recipeIdScope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdScope", recipeIdScope));
            }
            if (recipeIdCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdCode", recipeIdCode));
            }
            if (excludeUnsettledTrades != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "excludeUnsettledTrades", excludeUnsettledTrades));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfPortfolioCashLadder>("/api/transactionportfolios/{scope}/{code}/cashladder", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioCashLadder", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetPortfolioCashLadder: Get portfolio cash ladder Get a cash ladder for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="effectiveAt">The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <param name="excludeUnsettledTrades">If absent or set to false, cashflows will returned based on trade date - more specifically, cashflows from any unsettled trades will be included in the results. If set to true, unsettled trades will be excluded from the result set. (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPortfolioCashLadder</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPortfolioCashLadder> GetPortfolioCashLadderAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string), bool? excludeUnsettledTrades = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolioCashLadder> localVarResponse = await GetPortfolioCashLadderWithHttpInfoAsync(scope, code, fromEffectiveAt, toEffectiveAt, effectiveAt, asAt, filter, recipeIdScope, recipeIdCode, excludeUnsettledTrades, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetPortfolioCashLadder: Get portfolio cash ladder Get a cash ladder for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="effectiveAt">The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <param name="excludeUnsettledTrades">If absent or set to false, cashflows will returned based on trade date - more specifically, cashflows from any unsettled trades will be included in the results. If set to true, unsettled trades will be excluded from the result set. (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolioCashLadder)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolioCashLadder>> GetPortfolioCashLadderWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string), bool? excludeUnsettledTrades = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetPortfolioCashLadder");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetPortfolioCashLadder");

            // verify the required parameter 'fromEffectiveAt' is set
            if (fromEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'fromEffectiveAt' when calling TransactionPortfoliosApi->GetPortfolioCashLadder");

            // verify the required parameter 'toEffectiveAt' is set
            if (toEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'toEffectiveAt' when calling TransactionPortfoliosApi->GetPortfolioCashLadder");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->GetPortfolioCashLadder");


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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toEffectiveAt", toEffectiveAt));
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (recipeIdScope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdScope", recipeIdScope));
            }
            if (recipeIdCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdCode", recipeIdCode));
            }
            if (excludeUnsettledTrades != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "excludeUnsettledTrades", excludeUnsettledTrades));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfPortfolioCashLadder>("/api/transactionportfolios/{scope}/{code}/cashladder", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioCashLadder", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetPortfolioCashStatement: Get portfolio cash statement Get a cash statement for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <returns>ResourceListOfPortfolioCashFlow</returns>
        public ResourceListOfPortfolioCashFlow GetPortfolioCashStatement(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolioCashFlow> localVarResponse = GetPortfolioCashStatementWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt, filter, recipeIdScope, recipeIdCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetPortfolioCashStatement: Get portfolio cash statement Get a cash statement for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPortfolioCashFlow</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolioCashFlow> GetPortfolioCashStatementWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");

            // verify the required parameter 'fromEffectiveAt' is set
            if (fromEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'fromEffectiveAt' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");

            // verify the required parameter 'toEffectiveAt' is set
            if (toEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'toEffectiveAt' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");

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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toEffectiveAt", toEffectiveAt));
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (recipeIdScope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdScope", recipeIdScope));
            }
            if (recipeIdCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdCode", recipeIdCode));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfPortfolioCashFlow>("/api/transactionportfolios/{scope}/{code}/cashstatement", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioCashStatement", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetPortfolioCashStatement: Get portfolio cash statement Get a cash statement for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPortfolioCashFlow</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPortfolioCashFlow> GetPortfolioCashStatementAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolioCashFlow> localVarResponse = await GetPortfolioCashStatementWithHttpInfoAsync(scope, code, fromEffectiveAt, toEffectiveAt, asAt, filter, recipeIdScope, recipeIdCode, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetPortfolioCashStatement: Get portfolio cash statement Get a cash statement for a transaction portfolio.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="recipeIdScope">The scope of the given recipeId (optional)</param>
        /// <param name="recipeIdCode">The code of the given recipeID (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPortfolioCashFlow)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfPortfolioCashFlow>> GetPortfolioCashStatementWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string recipeIdScope = default(string), string recipeIdCode = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");

            // verify the required parameter 'fromEffectiveAt' is set
            if (fromEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'fromEffectiveAt' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");

            // verify the required parameter 'toEffectiveAt' is set
            if (toEffectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'toEffectiveAt' when calling TransactionPortfoliosApi->GetPortfolioCashStatement");


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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "toEffectiveAt", toEffectiveAt));
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (recipeIdScope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdScope", recipeIdScope));
            }
            if (recipeIdCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "recipeIdCode", recipeIdCode));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfPortfolioCashFlow>("/api/transactionportfolios/{scope}/{code}/cashstatement", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPortfolioCashStatement", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetTransactionHistory: Get the history of a transaction Get all of the changes that have happened to a transaction.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the history of the transaction. Defaults              to return the latest version if not specified. (optional)</param>
        /// <returns>ResourceListOfChangeHistory</returns>
        public ResourceListOfChangeHistory GetTransactionHistory(string scope, string code, string transactionId, DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfChangeHistory> localVarResponse = GetTransactionHistoryWithHttpInfo(scope, code, transactionId, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetTransactionHistory: Get the history of a transaction Get all of the changes that have happened to a transaction.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the history of the transaction. Defaults              to return the latest version if not specified. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfChangeHistory</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfChangeHistory> GetTransactionHistoryWithHttpInfo(string scope, string code, string transactionId, DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetTransactionHistory");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetTransactionHistory");

            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'transactionId' when calling TransactionPortfoliosApi->GetTransactionHistory");

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
            localVarRequestOptions.PathParameters.Add("transactionId", Lusid.Sdk.Client.ClientUtils.ParameterToString(transactionId)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfChangeHistory>("/api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/history", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTransactionHistory", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetTransactionHistory: Get the history of a transaction Get all of the changes that have happened to a transaction.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the history of the transaction. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfChangeHistory</returns>
        public async System.Threading.Tasks.Task<ResourceListOfChangeHistory> GetTransactionHistoryAsync(string scope, string code, string transactionId, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfChangeHistory> localVarResponse = await GetTransactionHistoryWithHttpInfoAsync(scope, code, transactionId, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetTransactionHistory: Get the history of a transaction Get all of the changes that have happened to a transaction.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update.</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the history of the transaction. Defaults              to return the latest version if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfChangeHistory)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfChangeHistory>> GetTransactionHistoryWithHttpInfoAsync(string scope, string code, string transactionId, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetTransactionHistory");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetTransactionHistory");

            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'transactionId' when calling TransactionPortfoliosApi->GetTransactionHistory");


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
            localVarRequestOptions.PathParameters.Add("transactionId", Lusid.Sdk.Client.ClientUtils.ParameterToString(transactionId)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfChangeHistory>("/api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/history", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTransactionHistory", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetTransactions: Get transactions Retrieve all the transactions that occurred during a particular time interval.                If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, \&quot;LegalEntity\&quot; or \&quot;CustodianAccount\&quot; domain to decorate onto               transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or               &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. The current behaviour is               to return all transactions if possible, but this will change to defaulting to 1000 if not specified in the future. It is recommended               to populate this field to enable pagination. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <returns>VersionedResourceListOfTransaction</returns>
        public VersionedResourceListOfTransaction GetTransactions(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), string page = default(string), int? limit = default(int?), bool? showCancelledTransactions = default(bool?))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfTransaction> localVarResponse = GetTransactionsWithHttpInfo(scope, code, fromTransactionDate, toTransactionDate, asAt, filter, propertyKeys, page, limit, showCancelledTransactions);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetTransactions: Get transactions Retrieve all the transactions that occurred during a particular time interval.                If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, \&quot;LegalEntity\&quot; or \&quot;CustodianAccount\&quot; domain to decorate onto               transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or               &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. The current behaviour is               to return all transactions if possible, but this will change to defaulting to 1000 if not specified in the future. It is recommended               to populate this field to enable pagination. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <returns>ApiResponse of VersionedResourceListOfTransaction</returns>
        public Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfTransaction> GetTransactionsWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), string page = default(string), int? limit = default(int?), bool? showCancelledTransactions = default(bool?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetTransactions");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetTransactions");

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
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Get<VersionedResourceListOfTransaction>("/api/transactionportfolios/{scope}/{code}/transactions", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTransactions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetTransactions: Get transactions Retrieve all the transactions that occurred during a particular time interval.                If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, \&quot;LegalEntity\&quot; or \&quot;CustodianAccount\&quot; domain to decorate onto               transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or               &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. The current behaviour is               to return all transactions if possible, but this will change to defaulting to 1000 if not specified in the future. It is recommended               to populate this field to enable pagination. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedResourceListOfTransaction</returns>
        public async System.Threading.Tasks.Task<VersionedResourceListOfTransaction> GetTransactionsAsync(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), string page = default(string), int? limit = default(int?), bool? showCancelledTransactions = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfTransaction> localVarResponse = await GetTransactionsWithHttpInfoAsync(scope, code, fromTransactionDate, toTransactionDate, asAt, filter, propertyKeys, page, limit, showCancelledTransactions, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetTransactions: Get transactions Retrieve all the transactions that occurred during a particular time interval.                If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.</param>
        /// <param name="fromTransactionDate">The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toTransactionDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve transactions. Defaults to returning the latest version               of each transaction if not specified. (optional)</param>
        /// <param name="filter">Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, \&quot;LegalEntity\&quot; or \&quot;CustodianAccount\&quot; domain to decorate onto               transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or               &#39;Transaction/strategy/quantsignal&#39;. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. The current behaviour is               to return all transactions if possible, but this will change to defaulting to 1000 if not specified in the future. It is recommended               to populate this field to enable pagination. (optional)</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedResourceListOfTransaction)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<VersionedResourceListOfTransaction>> GetTransactionsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromTransactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel toTransactionDate = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> propertyKeys = default(List<string>), string page = default(string), int? limit = default(int?), bool? showCancelledTransactions = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->GetTransactions");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->GetTransactions");


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
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<VersionedResourceListOfTransaction>("/api/transactionportfolios/{scope}/{code}/transactions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTransactions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// ListHoldingsAdjustments: List holdings adjustments List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <returns>ResourceListOfHoldingsAdjustmentHeader</returns>
        public ResourceListOfHoldingsAdjustmentHeader ListHoldingsAdjustments(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfHoldingsAdjustmentHeader> localVarResponse = ListHoldingsAdjustmentsWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ListHoldingsAdjustments: List holdings adjustments List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfHoldingsAdjustmentHeader</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfHoldingsAdjustmentHeader> ListHoldingsAdjustmentsWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->ListHoldingsAdjustments");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->ListHoldingsAdjustments");

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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfHoldingsAdjustmentHeader>("/api/transactionportfolios/{scope}/{code}/holdingsadjustments", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListHoldingsAdjustments", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// ListHoldingsAdjustments: List holdings adjustments List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfHoldingsAdjustmentHeader</returns>
        public async System.Threading.Tasks.Task<ResourceListOfHoldingsAdjustmentHeader> ListHoldingsAdjustmentsAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfHoldingsAdjustmentHeader> localVarResponse = await ListHoldingsAdjustmentsWithHttpInfoAsync(scope, code, fromEffectiveAt, toEffectiveAt, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ListHoldingsAdjustments: List holdings adjustments List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional)</param>
        /// <param name="toEffectiveAt">The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfHoldingsAdjustmentHeader)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfHoldingsAdjustmentHeader>> ListHoldingsAdjustmentsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->ListHoldingsAdjustments");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->ListHoldingsAdjustments");


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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfHoldingsAdjustmentHeader>("/api/transactionportfolios/{scope}/{code}/holdingsadjustments", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListHoldingsAdjustments", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] PatchPortfolioDetails: Patch portfolio details Create or update certain details for a particular transaction portfolio.  The behaviour is defined by the JSON Patch specification.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.  Currently supported properties are: SubHoldingKeys, BaseCurrency, AmortisationMethod
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="operation">The patch document.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified.               Note that this will affect all bitemporal entities in the request, but will not be used for any perpetual entities. (optional)</param>
        /// <returns>PortfolioDetails</returns>
        public PortfolioDetails PatchPortfolioDetails(string scope, string code, List<Operation> operation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioDetails> localVarResponse = PatchPortfolioDetailsWithHttpInfo(scope, code, operation, effectiveAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] PatchPortfolioDetails: Patch portfolio details Create or update certain details for a particular transaction portfolio.  The behaviour is defined by the JSON Patch specification.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.  Currently supported properties are: SubHoldingKeys, BaseCurrency, AmortisationMethod
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="operation">The patch document.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified.               Note that this will affect all bitemporal entities in the request, but will not be used for any perpetual entities. (optional)</param>
        /// <returns>ApiResponse of PortfolioDetails</returns>
        public Lusid.Sdk.Client.ApiResponse<PortfolioDetails> PatchPortfolioDetailsWithHttpInfo(string scope, string code, List<Operation> operation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->PatchPortfolioDetails");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->PatchPortfolioDetails");

            // verify the required parameter 'operation' is set
            if (operation == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'operation' when calling TransactionPortfoliosApi->PatchPortfolioDetails");

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
            localVarRequestOptions.Data = operation;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Patch<PortfolioDetails>("/api/transactionportfolios/{scope}/{code}/details", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchPortfolioDetails", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] PatchPortfolioDetails: Patch portfolio details Create or update certain details for a particular transaction portfolio.  The behaviour is defined by the JSON Patch specification.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.  Currently supported properties are: SubHoldingKeys, BaseCurrency, AmortisationMethod
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="operation">The patch document.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified.               Note that this will affect all bitemporal entities in the request, but will not be used for any perpetual entities. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioDetails</returns>
        public async System.Threading.Tasks.Task<PortfolioDetails> PatchPortfolioDetailsAsync(string scope, string code, List<Operation> operation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioDetails> localVarResponse = await PatchPortfolioDetailsWithHttpInfoAsync(scope, code, operation, effectiveAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] PatchPortfolioDetails: Patch portfolio details Create or update certain details for a particular transaction portfolio.  The behaviour is defined by the JSON Patch specification.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.  Currently supported properties are: SubHoldingKeys, BaseCurrency, AmortisationMethod
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="operation">The patch document.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified.               Note that this will affect all bitemporal entities in the request, but will not be used for any perpetual entities. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioDetails)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioDetails>> PatchPortfolioDetailsWithHttpInfoAsync(string scope, string code, List<Operation> operation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->PatchPortfolioDetails");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->PatchPortfolioDetails");

            // verify the required parameter 'operation' is set
            if (operation == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'operation' when calling TransactionPortfoliosApi->PatchPortfolioDetails");


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
            localVarRequestOptions.Data = operation;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PatchAsync<PortfolioDetails>("/api/transactionportfolios/{scope}/{code}/details", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchPortfolioDetails", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ResolveInstrument: Resolve instrument Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified  period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="reResolve">When set to true, instrument resolution will be attempted for all transactions and holdings for the given identifier and date range.              When set to false (default behaviour), instrument resolution will only be attempted for those transactions and holdings that were previously unresolved. (optional, default to false)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the             transaction and holdings. (optional)</param>
        /// <returns>UpsertPortfolioTransactionsResponse</returns>
        public UpsertPortfolioTransactionsResponse ResolveInstrument(string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), bool? reResolve = default(bool?), Dictionary<string, string> requestBody = default(Dictionary<string, string>))
        {
            Lusid.Sdk.Client.ApiResponse<UpsertPortfolioTransactionsResponse> localVarResponse = ResolveInstrumentWithHttpInfo(scope, code, instrumentIdentifierType, instrumentIdentifierValue, fromEffectiveAt, reResolve, requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ResolveInstrument: Resolve instrument Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified  period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="reResolve">When set to true, instrument resolution will be attempted for all transactions and holdings for the given identifier and date range.              When set to false (default behaviour), instrument resolution will only be attempted for those transactions and holdings that were previously unresolved. (optional, default to false)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the             transaction and holdings. (optional)</param>
        /// <returns>ApiResponse of UpsertPortfolioTransactionsResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<UpsertPortfolioTransactionsResponse> ResolveInstrumentWithHttpInfo(string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), bool? reResolve = default(bool?), Dictionary<string, string> requestBody = default(Dictionary<string, string>))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->ResolveInstrument");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->ResolveInstrument");

            // verify the required parameter 'instrumentIdentifierType' is set
            if (instrumentIdentifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'instrumentIdentifierType' when calling TransactionPortfoliosApi->ResolveInstrument");

            // verify the required parameter 'instrumentIdentifierValue' is set
            if (instrumentIdentifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'instrumentIdentifierValue' when calling TransactionPortfoliosApi->ResolveInstrument");

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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "instrumentIdentifierType", instrumentIdentifierType));
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "instrumentIdentifierValue", instrumentIdentifierValue));
            if (fromEffectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            }
            if (reResolve != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "reResolve", reResolve));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Post<UpsertPortfolioTransactionsResponse>("/api/transactionportfolios/{scope}/{code}/$resolve", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ResolveInstrument", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ResolveInstrument: Resolve instrument Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified  period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="reResolve">When set to true, instrument resolution will be attempted for all transactions and holdings for the given identifier and date range.              When set to false (default behaviour), instrument resolution will only be attempted for those transactions and holdings that were previously unresolved. (optional, default to false)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the             transaction and holdings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpsertPortfolioTransactionsResponse</returns>
        public async System.Threading.Tasks.Task<UpsertPortfolioTransactionsResponse> ResolveInstrumentAsync(string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), bool? reResolve = default(bool?), Dictionary<string, string> requestBody = default(Dictionary<string, string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<UpsertPortfolioTransactionsResponse> localVarResponse = await ResolveInstrumentWithHttpInfoAsync(scope, code, instrumentIdentifierType, instrumentIdentifierValue, fromEffectiveAt, reResolve, requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ResolveInstrument: Resolve instrument Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified  period of time. Also update the instrument identifiers with the given instrument identifiers collection.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="instrumentIdentifierType">The instrument identifier type.</param>
        /// <param name="instrumentIdentifierValue">The value for the given instrument identifier.</param>
        /// <param name="fromEffectiveAt">The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional)</param>
        /// <param name="reResolve">When set to true, instrument resolution will be attempted for all transactions and holdings for the given identifier and date range.              When set to false (default behaviour), instrument resolution will only be attempted for those transactions and holdings that were previously unresolved. (optional, default to false)</param>
        /// <param name="requestBody">The dictionary with the instrument identifiers to be updated on the             transaction and holdings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpsertPortfolioTransactionsResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<UpsertPortfolioTransactionsResponse>> ResolveInstrumentWithHttpInfoAsync(string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), bool? reResolve = default(bool?), Dictionary<string, string> requestBody = default(Dictionary<string, string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->ResolveInstrument");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->ResolveInstrument");

            // verify the required parameter 'instrumentIdentifierType' is set
            if (instrumentIdentifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'instrumentIdentifierType' when calling TransactionPortfoliosApi->ResolveInstrument");

            // verify the required parameter 'instrumentIdentifierValue' is set
            if (instrumentIdentifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'instrumentIdentifierValue' when calling TransactionPortfoliosApi->ResolveInstrument");


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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "instrumentIdentifierType", instrumentIdentifierType));
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "instrumentIdentifierValue", instrumentIdentifierValue));
            if (fromEffectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "fromEffectiveAt", fromEffectiveAt));
            }
            if (reResolve != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "reResolve", reResolve));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<UpsertPortfolioTransactionsResponse>("/api/transactionportfolios/{scope}/{code}/$resolve", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ResolveInstrument", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// SetHoldings: Set holdings Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>AdjustHolding</returns>
        public AdjustHolding SetHoldings(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<AdjustHolding> localVarResponse = SetHoldingsWithHttpInfo(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods);
            return localVarResponse.Data;
        }

        /// <summary>
        /// SetHoldings: Set holdings Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <returns>ApiResponse of AdjustHolding</returns>
        public Lusid.Sdk.Client.ApiResponse<AdjustHolding> SetHoldingsWithHttpInfo(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->SetHoldings");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->SetHoldings");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->SetHoldings");

            // verify the required parameter 'adjustHoldingRequest' is set
            if (adjustHoldingRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'adjustHoldingRequest' when calling TransactionPortfoliosApi->SetHoldings");

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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            if (reconciliationMethods != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "reconciliationMethods", reconciliationMethods));
            }
            localVarRequestOptions.Data = adjustHoldingRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Put<AdjustHolding>("/api/transactionportfolios/{scope}/{code}/holdings", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetHoldings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// SetHoldings: Set holdings Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdjustHolding</returns>
        public async System.Threading.Tasks.Task<AdjustHolding> SetHoldingsAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<AdjustHolding> localVarResponse = await SetHoldingsWithHttpInfoAsync(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// SetHoldings: Set holdings Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the holdings should be set to the provided targets.</param>
        /// <param name="adjustHoldingRequest">The complete set of target holdings for the transaction portfolio.</param>
        /// <param name="reconciliationMethods">Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdjustHolding)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<AdjustHolding>> SetHoldingsWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->SetHoldings");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->SetHoldings");

            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'effectiveAt' when calling TransactionPortfoliosApi->SetHoldings");

            // verify the required parameter 'adjustHoldingRequest' is set
            if (adjustHoldingRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'adjustHoldingRequest' when calling TransactionPortfoliosApi->SetHoldings");


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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            if (reconciliationMethods != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "reconciliationMethods", reconciliationMethods));
            }
            localVarRequestOptions.Data = adjustHoldingRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<AdjustHolding>("/api/transactionportfolios/{scope}/{code}/holdings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetHoldings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// UpsertPortfolioDetails: Upsert portfolio details Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <returns>PortfolioDetails</returns>
        public PortfolioDetails UpsertPortfolioDetails(string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioDetails> localVarResponse = UpsertPortfolioDetailsWithHttpInfo(scope, code, createPortfolioDetails, effectiveAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// UpsertPortfolioDetails: Upsert portfolio details Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <returns>ApiResponse of PortfolioDetails</returns>
        public Lusid.Sdk.Client.ApiResponse<PortfolioDetails> UpsertPortfolioDetailsWithHttpInfo(string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");

            // verify the required parameter 'createPortfolioDetails' is set
            if (createPortfolioDetails == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'createPortfolioDetails' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");

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
            localVarRequestOptions.Data = createPortfolioDetails;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Post<PortfolioDetails>("/api/transactionportfolios/{scope}/{code}/details", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertPortfolioDetails", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// UpsertPortfolioDetails: Upsert portfolio details Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PortfolioDetails</returns>
        public async System.Threading.Tasks.Task<PortfolioDetails> UpsertPortfolioDetailsAsync(string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PortfolioDetails> localVarResponse = await UpsertPortfolioDetailsWithHttpInfoAsync(scope, code, createPortfolioDetails, effectiveAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// UpsertPortfolioDetails: Upsert portfolio details Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.</param>
        /// <param name="createPortfolioDetails">The details to create or update for the specified transaction portfolio.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PortfolioDetails)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PortfolioDetails>> UpsertPortfolioDetailsWithHttpInfoAsync(string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");

            // verify the required parameter 'createPortfolioDetails' is set
            if (createPortfolioDetails == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'createPortfolioDetails' when calling TransactionPortfoliosApi->UpsertPortfolioDetails");


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
            localVarRequestOptions.Data = createPortfolioDetails;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<PortfolioDetails>("/api/transactionportfolios/{scope}/{code}/details", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertPortfolioDetails", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// UpsertTransactionProperties: Upsert transaction properties Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <returns>UpsertTransactionPropertiesResponse</returns>
        public UpsertTransactionPropertiesResponse UpsertTransactionProperties(string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody)
        {
            Lusid.Sdk.Client.ApiResponse<UpsertTransactionPropertiesResponse> localVarResponse = UpsertTransactionPropertiesWithHttpInfo(scope, code, transactionId, requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// UpsertTransactionProperties: Upsert transaction properties Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <returns>ApiResponse of UpsertTransactionPropertiesResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<UpsertTransactionPropertiesResponse> UpsertTransactionPropertiesWithHttpInfo(string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertTransactionProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertTransactionProperties");

            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'transactionId' when calling TransactionPortfoliosApi->UpsertTransactionProperties");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling TransactionPortfoliosApi->UpsertTransactionProperties");

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
            localVarRequestOptions.PathParameters.Add("transactionId", Lusid.Sdk.Client.ClientUtils.ParameterToString(transactionId)); // path parameter
            localVarRequestOptions.Data = requestBody;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Post<UpsertTransactionPropertiesResponse>("/api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertTransactionProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// UpsertTransactionProperties: Upsert transaction properties Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpsertTransactionPropertiesResponse</returns>
        public async System.Threading.Tasks.Task<UpsertTransactionPropertiesResponse> UpsertTransactionPropertiesAsync(string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<UpsertTransactionPropertiesResponse> localVarResponse = await UpsertTransactionPropertiesWithHttpInfoAsync(scope, code, transactionId, requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// UpsertTransactionProperties: Upsert transaction properties Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionId">The unique ID of the transaction to create or update properties for.</param>
        /// <param name="requestBody">The properties and their associated values to create or update.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpsertTransactionPropertiesResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<UpsertTransactionPropertiesResponse>> UpsertTransactionPropertiesWithHttpInfoAsync(string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertTransactionProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertTransactionProperties");

            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'transactionId' when calling TransactionPortfoliosApi->UpsertTransactionProperties");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling TransactionPortfoliosApi->UpsertTransactionProperties");


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
            localVarRequestOptions.PathParameters.Add("transactionId", Lusid.Sdk.Client.ClientUtils.ParameterToString(transactionId)); // path parameter
            localVarRequestOptions.Data = requestBody;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<UpsertTransactionPropertiesResponse>("/api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertTransactionProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// UpsertTransactions: Upsert transactions Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <returns>UpsertPortfolioTransactionsResponse</returns>
        public UpsertPortfolioTransactionsResponse UpsertTransactions(string scope, string code, List<TransactionRequest> transactionRequest)
        {
            Lusid.Sdk.Client.ApiResponse<UpsertPortfolioTransactionsResponse> localVarResponse = UpsertTransactionsWithHttpInfo(scope, code, transactionRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// UpsertTransactions: Upsert transactions Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <returns>ApiResponse of UpsertPortfolioTransactionsResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<UpsertPortfolioTransactionsResponse> UpsertTransactionsWithHttpInfo(string scope, string code, List<TransactionRequest> transactionRequest)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertTransactions");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertTransactions");

            // verify the required parameter 'transactionRequest' is set
            if (transactionRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'transactionRequest' when calling TransactionPortfoliosApi->UpsertTransactions");

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
            localVarRequestOptions.Data = transactionRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request
            var localVarResponse = this.Client.Post<UpsertPortfolioTransactionsResponse>("/api/transactionportfolios/{scope}/{code}/transactions", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertTransactions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// UpsertTransactions: Upsert transactions Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpsertPortfolioTransactionsResponse</returns>
        public async System.Threading.Tasks.Task<UpsertPortfolioTransactionsResponse> UpsertTransactionsAsync(string scope, string code, List<TransactionRequest> transactionRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<UpsertPortfolioTransactionsResponse> localVarResponse = await UpsertTransactionsWithHttpInfoAsync(scope, code, transactionRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// UpsertTransactions: Upsert transactions Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the transaction portfolio.</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.</param>
        /// <param name="transactionRequest">A list of transactions to be created or updated.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpsertPortfolioTransactionsResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<UpsertPortfolioTransactionsResponse>> UpsertTransactionsWithHttpInfoAsync(string scope, string code, List<TransactionRequest> transactionRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling TransactionPortfoliosApi->UpsertTransactions");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling TransactionPortfoliosApi->UpsertTransactions");

            // verify the required parameter 'transactionRequest' is set
            if (transactionRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'transactionRequest' when calling TransactionPortfoliosApi->UpsertTransactions");


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
            localVarRequestOptions.Data = transactionRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.137");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<UpsertPortfolioTransactionsResponse>("/api/transactionportfolios/{scope}/{code}/transactions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertTransactions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}