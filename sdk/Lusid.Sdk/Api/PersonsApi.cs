/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-10\">-10</a>|Server Configuration Error|  | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"102\">102</a>|Version Not Found|  | | <a name=\"103\">103</a>|Api Rate Limit Violation|  | | <a name=\"104\">104</a>|Instrument Not Found|  | | <a name=\"105\">105</a>|Property Not Found|  | | <a name=\"106\">106</a>|Portfolio Recursion Depth|  | | <a name=\"108\">108</a>|Group Not Found|  | | <a name=\"109\">109</a>|Portfolio Not Found|  | | <a name=\"110\">110</a>|Property Schema Not Found|  | | <a name=\"111\">111</a>|Portfolio Ancestry Not Found|  | | <a name=\"112\">112</a>|Portfolio With Id Already Exists|  | | <a name=\"113\">113</a>|Orphaned Portfolio|  | | <a name=\"119\">119</a>|Missing Base Claims|  | | <a name=\"121\">121</a>|Property Not Defined|  | | <a name=\"122\">122</a>|Cannot Delete System Property|  | | <a name=\"123\">123</a>|Cannot Modify Immutable Property Field|  | | <a name=\"124\">124</a>|Property Already Exists|  | | <a name=\"125\">125</a>|Invalid Property Life Time|  | | <a name=\"126\">126</a>|Property Constraint Style Excludes Properties|  | | <a name=\"127\">127</a>|Cannot Modify Default Data Type|  | | <a name=\"128\">128</a>|Group Already Exists|  | | <a name=\"129\">129</a>|No Such Data Type|  | | <a name=\"130\">130</a>|Undefined Value For Data Type|  | | <a name=\"131\">131</a>|Unsupported Value Type Defined On Data Type|  | | <a name=\"132\">132</a>|Validation Error|  | | <a name=\"133\">133</a>|Loop Detected In Group Hierarchy|  | | <a name=\"134\">134</a>|Undefined Acceptable Values|  | | <a name=\"135\">135</a>|Sub Group Already Exists|  | | <a name=\"138\">138</a>|Price Source Not Found|  | | <a name=\"139\">139</a>|Analytic Store Not Found|  | | <a name=\"141\">141</a>|Analytic Store Already Exists|  | | <a name=\"143\">143</a>|Client Instrument Already Exists|  | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"147\">147</a>|Results Not Found|  | | <a name=\"148\">148</a>|Order Field Not In Result Set|  | | <a name=\"149\">149</a>|Operation Failed|  | | <a name=\"150\">150</a>|Elastic Search Error|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"153\">153</a>|Command Processing Failure|  | | <a name=\"154\">154</a>|Entity State Construction Failure|  | | <a name=\"155\">155</a>|Entity Timeline Does Not Exist|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"158\">158</a>|Event Publish Unknown|  | | <a name=\"159\">159</a>|Event Query Failure|  | | <a name=\"160\">160</a>|Blob Did Not Exist|  | | <a name=\"162\">162</a>|Sub System Request Failure|  | | <a name=\"163\">163</a>|Sub System Configuration Failure|  | | <a name=\"165\">165</a>|Failed To Delete|  | | <a name=\"166\">166</a>|Upsert Client Instrument Failure|  | | <a name=\"167\">167</a>|Illegal As At Interval|  | | <a name=\"168\">168</a>|Illegal Bitemporal Query|  | | <a name=\"169\">169</a>|Invalid Alternate Id|  | | <a name=\"170\">170</a>|Cannot Add Source Portfolio Property Explicitly|  | | <a name=\"171\">171</a>|Entity Already Exists In Group|  | | <a name=\"173\">173</a>|Entity With Id Already Exists|  | | <a name=\"174\">174</a>|Derived Portfolio Details Do Not Exist|  | | <a name=\"175\">175</a>|Entity Not In Group|  | | <a name=\"176\">176</a>|Portfolio With Name Already Exists|  | | <a name=\"177\">177</a>|Invalid Transactions|  | | <a name=\"178\">178</a>|Reference Portfolio Not Found|  | | <a name=\"179\">179</a>|Duplicate Id|  | | <a name=\"180\">180</a>|Command Retrieval Failure|  | | <a name=\"181\">181</a>|Data Filter Application Failure|  | | <a name=\"182\">182</a>|Search Failed|  | | <a name=\"183\">183</a>|Movements Engine Configuration Key Failure|  | | <a name=\"184\">184</a>|Fx Rate Source Not Found|  | | <a name=\"185\">185</a>|Accrual Source Not Found|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"188\">188</a>|Invalid Request Headers|  | | <a name=\"189\">189</a>|Price Not Found|  | | <a name=\"190\">190</a>|Invalid Sub Holding Keys Provided|  | | <a name=\"191\">191</a>|Duplicate Sub Holding Keys Provided|  | | <a name=\"192\">192</a>|Cut Definition Not Found|  | | <a name=\"193\">193</a>|Cut Definition Invalid|  | | <a name=\"194\">194</a>|Time Variant Property Deletion Date Unspecified|  | | <a name=\"195\">195</a>|Perpetual Property Deletion Date Specified|  | | <a name=\"196\">196</a>|Time Variant Property Upsert Date Unspecified|  | | <a name=\"197\">197</a>|Perpetual Property Upsert Date Specified|  | | <a name=\"200\">200</a>|Invalid Unit For Data Type|  | | <a name=\"201\">201</a>|Invalid Type For Data Type|  | | <a name=\"202\">202</a>|Invalid Value For Data Type|  | | <a name=\"203\">203</a>|Unit Not Defined For Data Type|  | | <a name=\"204\">204</a>|Units Not Supported On Data Type|  | | <a name=\"205\">205</a>|Cannot Specify Units On Data Type|  | | <a name=\"206\">206</a>|Unit Schema Inconsistent With Data Type|  | | <a name=\"207\">207</a>|Unit Definition Not Specified|  | | <a name=\"208\">208</a>|Duplicate Unit Definitions Specified|  | | <a name=\"209\">209</a>|Invalid Units Definition|  | | <a name=\"210\">210</a>|Invalid Instrument Identifier Unit|  | | <a name=\"211\">211</a>|Holdings Adjustment Does Not Exist|  | | <a name=\"212\">212</a>|Could Not Build Excel Url|  | | <a name=\"213\">213</a>|Could Not Get Excel Version|  | | <a name=\"214\">214</a>|Instrument By Code Not Found|  | | <a name=\"215\">215</a>|Entity Schema Does Not Exist|  | | <a name=\"216\">216</a>|Feature Not Supported On Portfolio Type|  | | <a name=\"217\">217</a>|Quote Not Found|  | | <a name=\"218\">218</a>|Invalid Quote Identifier|  | | <a name=\"219\">219</a>|Invalid Metric For Data Type|  | | <a name=\"220\">220</a>|Invalid Instrument Definition|  | | <a name=\"221\">221</a>|Instrument Upsert Failure|  | | <a name=\"222\">222</a>|Reference Portfolio Request Not Supported|  | | <a name=\"223\">223</a>|Transaction Portfolio Request Not Supported|  | | <a name=\"224\">224</a>|Invalid Property Value Assignment|  | | <a name=\"230\">230</a>|Transaction Type Not Found|  | | <a name=\"231\">231</a>|Transaction Type Duplication|  | | <a name=\"232\">232</a>|Portfolio Does Not Exist At Given Date|  | | <a name=\"233\">233</a>|Query Parser Failure|  | | <a name=\"234\">234</a>|Duplicate Constituent|  | | <a name=\"235\">235</a>|Unresolved Instrument Constituent|  | | <a name=\"236\">236</a>|Unresolved Instrument In Transition|  | | <a name=\"237\">237</a>|Missing Side Definitions|  | | <a name=\"299\">299</a>|Invalid Recipe|  | | <a name=\"300\">300</a>|Missing Recipe|  | | <a name=\"301\">301</a>|Dependencies|  | | <a name=\"304\">304</a>|Portfolio Preprocess Failure|  | | <a name=\"310\">310</a>|Valuation Engine Failure|  | | <a name=\"311\">311</a>|Task Factory Failure|  | | <a name=\"312\">312</a>|Task Evaluation Failure|  | | <a name=\"313\">313</a>|Task Generation Failure|  | | <a name=\"314\">314</a>|Engine Configuration Failure|  | | <a name=\"315\">315</a>|Model Specification Failure|  | | <a name=\"320\">320</a>|Market Data Key Failure|  | | <a name=\"321\">321</a>|Market Resolver Failure|  | | <a name=\"322\">322</a>|Market Data Failure|  | | <a name=\"330\">330</a>|Curve Failure|  | | <a name=\"331\">331</a>|Volatility Surface Failure|  | | <a name=\"332\">332</a>|Volatility Cube Failure|  | | <a name=\"350\">350</a>|Instrument Failure|  | | <a name=\"351\">351</a>|Cash Flows Failure|  | | <a name=\"352\">352</a>|Reference Data Failure|  | | <a name=\"360\">360</a>|Aggregation Failure|  | | <a name=\"361\">361</a>|Aggregation Measure Failure|  | | <a name=\"370\">370</a>|Result Retrieval Failure|  | | <a name=\"371\">371</a>|Result Processing Failure|  | | <a name=\"372\">372</a>|Vendor Result Processing Failure|  | | <a name=\"373\">373</a>|Vendor Result Mapping Failure|  | | <a name=\"374\">374</a>|Vendor Library Unauthorised|  | | <a name=\"375\">375</a>|Vendor Connectivity Error|  | | <a name=\"376\">376</a>|Vendor Interface Error|  | | <a name=\"377\">377</a>|Vendor Pricing Failure|  | | <a name=\"378\">378</a>|Vendor Translation Failure|  | | <a name=\"379\">379</a>|Vendor Key Mapping Failure|  | | <a name=\"380\">380</a>|Vendor Reflection Failure|  | | <a name=\"381\">381</a>|Vendor Process Failure|  | | <a name=\"382\">382</a>|Vendor System Failure|  | | <a name=\"390\">390</a>|Attempt To Upsert Duplicate Quotes|  | | <a name=\"391\">391</a>|Corporate Action Source Does Not Exist|  | | <a name=\"392\">392</a>|Corporate Action Source Already Exists|  | | <a name=\"393\">393</a>|Instrument Identifier Already In Use|  | | <a name=\"394\">394</a>|Properties Not Found|  | | <a name=\"395\">395</a>|Batch Operation Aborted|  | | <a name=\"400\">400</a>|Invalid Iso4217 Currency Code|  | | <a name=\"401\">401</a>|Cannot Assign Instrument Identifier To Currency|  | | <a name=\"402\">402</a>|Cannot Assign Currency Identifier To Non Currency|  | | <a name=\"403\">403</a>|Currency Instrument Cannot Be Deleted|  | | <a name=\"404\">404</a>|Currency Instrument Cannot Have Economic Definition|  | | <a name=\"405\">405</a>|Currency Instrument Cannot Have Lookthrough Portfolio|  | | <a name=\"406\">406</a>|Cannot Create Currency Instrument With Multiple Identifiers|  | | <a name=\"407\">407</a>|Specified Currency Is Undefined|  | | <a name=\"410\">410</a>|Index Does Not Exist|  | | <a name=\"411\">411</a>|Sort Field Does Not Exist|  | | <a name=\"413\">413</a>|Negative Pagination Parameters|  | | <a name=\"414\">414</a>|Invalid Search Syntax|  | | <a name=\"415\">415</a>|Filter Execution Timeout|  | | <a name=\"420\">420</a>|Side Definition Inconsistent|  | | <a name=\"450\">450</a>|Invalid Quote Access Metadata Rule|  | | <a name=\"451\">451</a>|Access Metadata Not Found|  | | <a name=\"452\">452</a>|Invalid Access Metadata Identifier|  | | <a name=\"460\">460</a>|Standard Resource Not Found|  | | <a name=\"461\">461</a>|Standard Resource Conflict|  | | <a name=\"462\">462</a>|Calendar Not Found|  | | <a name=\"463\">463</a>|Date In A Calendar Not Found|  | | <a name=\"464\">464</a>|Invalid Date Source Data|  | | <a name=\"465\">465</a>|Invalid Timezone|  | | <a name=\"601\">601</a>|Person Identifier Already In Use|  | | <a name=\"602\">602</a>|Person Not Found|  | | <a name=\"603\">603</a>|Cannot Set Identifier|  | | <a name=\"617\">617</a>|Invalid Recipe Specification In Request|  | | <a name=\"618\">618</a>|Inline Recipe Deserialisation Failure|  | | <a name=\"619\">619</a>|Identifier Types Not Set For Entity|  | | <a name=\"620\">620</a>|Cannot Delete All Client Defined Identifiers|  | | <a name=\"650\">650</a>|The Order requested was not found.|  | | <a name=\"654\">654</a>|The Allocation requested was not found.|  | | <a name=\"655\">655</a>|Cannot build the fx forward target with the given holdings.|  | | <a name=\"656\">656</a>|Group does not contain expected entities.|  | | <a name=\"665\">665</a>|Destination directory not found|  | | <a name=\"667\">667</a>|Relation definition already exists|  | | <a name=\"672\">672</a>|Could not retrieve file contents|  | | <a name=\"673\">673</a>|Missing entitlements for entities in Group|  | | <a name=\"674\">674</a>|Next Best Action not found|  | | <a name=\"676\">676</a>|Relation definition not defined|  | | <a name=\"677\">677</a>|Invalid entity identifier for relation|  | | <a name=\"681\">681</a>|Sorting by specified field not supported|One or more of the provided fields to order by were either invalid or not supported. | | <a name=\"682\">682</a>|Too many fields to sort by|The number of fields to sort the data by exceeds the number allowed by the endpoint | | <a name=\"684\">684</a>|Sequence Not Found|  | | <a name=\"685\">685</a>|Sequence Already Exists|  | | <a name=\"686\">686</a>|Non-cycling sequence has been exhausted|  | | <a name=\"687\">687</a>|Legal Entity Identifier Already In Use|  | | <a name=\"688\">688</a>|Legal Entity Not Found|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"690\">690</a>|Property Type Is Not Supported|  | | <a name=\"691\">691</a>|Multiple Tax-lots For Currency Type Is Not Supported|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"693\">693</a>|Entity type is not supported for Relationship|  | | <a name=\"694\">694</a>|Relationship Validation Failure|  | | <a name=\"695\">695</a>|Relationship Not Found|  | | <a name=\"697\">697</a>|Derived Property Formula No Longer Valid|  | | <a name=\"698\">698</a>|Story is not available|  | | <a name=\"703\">703</a>|Corporate Action Does Not Exist|  | | <a name=\"720\">720</a>|The provided sort and filter combination is not valid|  | | <a name=\"721\">721</a>|A2B generation failed|  | | <a name=\"722\">722</a>|Aggregated Return Calculation Failure|  | | <a name=\"723\">723</a>|Custom Entity Definition Identifier Already In Use|  | | <a name=\"724\">724</a>|Custom Entity Definition Not Found|  | | <a name=\"725\">725</a>|The Placement requested was not found.|  | | <a name=\"726\">726</a>|The Execution requested was not found.|  | | <a name=\"727\">727</a>|The Block requested was not found.|  | | <a name=\"728\">728</a>|The Participation requested was not found.|  | | <a name=\"729\">729</a>|The Package requested was not found.|  | | <a name=\"730\">730</a>|The OrderInstruction requested was not found.|  | | <a name=\"732\">732</a>|Custom Entity not found.|  | | <a name=\"733\">733</a>|Custom Entity Identifier already in use.|  | | <a name=\"735\">735</a>|Calculation Failed.|  | | <a name=\"736\">736</a>|An expected key on HttpResponse is missing.|  | | <a name=\"737\">737</a>|A required fee detail is missing.|  | | <a name=\"738\">738</a>|Zero rows were returned from Luminesce|  | | <a name=\"739\">739</a>|Provided Weekend Mask was invalid|  | | <a name=\"742\">742</a>|Custom Entity fields do not match the definition|  | | <a name=\"746\">746</a>|The provided sequence is not valid.|  | | <a name=\"751\">751</a>|The type of the Custom Entity is different than the type provided in the definition.|  | | <a name=\"752\">752</a>|Luminesce process returned an error.|  | | <a name=\"753\">753</a>|File name or content incompatible with operation.|  | | <a name=\"755\">755</a>|Schema of response from Drive is not as expected.|  | | <a name=\"757\">757</a>|Schema of response from Luminesce is not as expected.|  | | <a name=\"758\">758</a>|Luminesce timed out.|  | | <a name=\"763\">763</a>|Invalid Lusid Entity Identifier Unit|  | | <a name=\"768\">768</a>|Fee rule not found.|  | | <a name=\"769\">769</a>|Cannot update the base currency of a portfolio with transactions loaded|  | | <a name=\"771\">771</a>|Transaction configuration source not found|  | | <a name=\"774\">774</a>|Compliance rule not found.|  | | <a name=\"775\">775</a>|Fund accounting document cannot be processed.|  | | <a name=\"778\">778</a>|Unable to look up FX rate from trade ccy to portfolio ccy for some of the trades.|  | | <a name=\"782\">782</a>|The Property definition dataType is not matching the derivation formula dataType|  | | <a name=\"783\">783</a>|The Property definition domain is not supported for derived properties|  | | <a name=\"788\">788</a>|Compliance run not found failure.|  | | <a name=\"790\">790</a>|Custom Entity has missing or invalid identifiers|  | | <a name=\"791\">791</a>|Custom Entity definition already exists|  | | <a name=\"792\">792</a>|Compliance PropertyKey is missing.|  | | <a name=\"793\">793</a>|Compliance Criteria Value for matching is missing.|  | | <a name=\"795\">795</a>|Cannot delete identifier definition|  | | <a name=\"796\">796</a>|Tax rule set not found.|  | | <a name=\"797\">797</a>|A tax rule set with this id already exists.|  | | <a name=\"798\">798</a>|Multiple rule sets for the same property key are applicable.|  | | <a name=\"800\">800</a>|Can not upsert an instrument event of this type.|  | | <a name=\"801\">801</a>|The instrument event does not exist.|  | | <a name=\"802\">802</a>|The Instrument event is missing salient information.|  | | <a name=\"803\">803</a>|The Instrument event could not be processed.|  | | <a name=\"804\">804</a>|Some data requested does not follow the order graph assumptions.|  | | <a name=\"811\">811</a>|A price could not be found for an order.|  | | <a name=\"812\">812</a>|A price could not be found for an allocation.|  | | <a name=\"813\">813</a>|Chart of Accounts not found.|  | | <a name=\"814\">814</a>|Account not found.|  | | <a name=\"815\">815</a>|Abor not found.|  | | <a name=\"816\">816</a>|Abor Configuration not found.|  | | <a name=\"817\">817</a>|Reconciliation mapping not found|  | | <a name=\"818\">818</a>|Attribute type could not be deleted because it doesn't exist.|  | | <a name=\"819\">819</a>|Reconciliation not found.|  | | <a name=\"820\">820</a>|Custodian Account not found.|  | 
 *
 * The version of the OpenAPI document: 0.11.5222
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
    public interface IPersonsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EARLY ACCESS] DeletePerson: Delete person
        /// </summary>
        /// <remarks>
        /// Delete a person. Deletion will be valid from the person&#39;s creation datetime.  This means that the person will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">The scope of the person identifier type.</param>
        /// <param name="idTypeCode">The code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type scope and code. This together with defined              identifier type uniquely identifies the person to delete.</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePerson(string idTypeScope, string idTypeCode, string code);

        /// <summary>
        /// [EARLY ACCESS] DeletePerson: Delete person
        /// </summary>
        /// <remarks>
        /// Delete a person. Deletion will be valid from the person&#39;s creation datetime.  This means that the person will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">The scope of the person identifier type.</param>
        /// <param name="idTypeCode">The code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type scope and code. This together with defined              identifier type uniquely identifies the person to delete.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePersonWithHttpInfo(string idTypeScope, string idTypeCode, string code);
        /// <summary>
        /// [EARLY ACCESS] DeletePersonAccessMetadata: Delete a Person Access Metadata entry
        /// </summary>
        /// <remarks>
        /// Deletes the Person Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePersonAccessMetadata(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] DeletePersonAccessMetadata: Delete a Person Access Metadata entry
        /// </summary>
        /// <remarks>
        /// Deletes the Person Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePersonAccessMetadataWithHttpInfo(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] DeletePersonIdentifiers: Delete Person Identifiers
        /// </summary>
        /// <remarks>
        /// Delete identifiers that belong to the given property keys of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the identifiers to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Identifiers or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the identifiers. Defaults to the current LUSID system datetime if not specified.              Must not include an effective datetime if identifiers are perpetual. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePersonIdentifiers(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));

        /// <summary>
        /// [EARLY ACCESS] DeletePersonIdentifiers: Delete Person Identifiers
        /// </summary>
        /// <remarks>
        /// Delete identifiers that belong to the given property keys of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the identifiers to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Identifiers or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the identifiers. Defaults to the current LUSID system datetime if not specified.              Must not include an effective datetime if identifiers are perpetual. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePersonIdentifiersWithHttpInfo(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));
        /// <summary>
        /// [EARLY ACCESS] DeletePersonProperties: Delete Person Properties
        /// </summary>
        /// <remarks>
        /// Delete all properties that belong to the given property keys of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the person&#39;s properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Properties or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeletePersonProperties(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));

        /// <summary>
        /// [EARLY ACCESS] DeletePersonProperties: Delete Person Properties
        /// </summary>
        /// <remarks>
        /// Delete all properties that belong to the given property keys of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the person&#39;s properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Properties or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeletePersonPropertiesWithHttpInfo(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel));
        /// <summary>
        /// [EARLY ACCESS] GetAllPersonAccessMetadata: Get Access Metadata rules for a Person
        /// </summary>
        /// <remarks>
        /// Pass the Scope and Code of the Person identifier along with the person code parameter to retrieve the associated Access Metadata
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <returns>Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        Dictionary<string, List<AccessMetadataValue>> GetAllPersonAccessMetadata(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] GetAllPersonAccessMetadata: Get Access Metadata rules for a Person
        /// </summary>
        /// <remarks>
        /// Pass the Scope and Code of the Person identifier along with the person code parameter to retrieve the associated Access Metadata
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        ApiResponse<Dictionary<string, List<AccessMetadataValue>>> GetAllPersonAccessMetadataWithHttpInfo(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] GetPerson: Get Person
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto the person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the person. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person. Defaults to return the latest version of the person if not specified. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the person in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>Person</returns>
        Person GetPerson(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys = default(List<string>), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> relationshipDefinitionIds = default(List<string>));

        /// <summary>
        /// [EARLY ACCESS] GetPerson: Get Person
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto the person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the person. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person. Defaults to return the latest version of the person if not specified. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the person in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>ApiResponse of Person</returns>
        ApiResponse<Person> GetPersonWithHttpInfo(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys = default(List<string>), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> relationshipDefinitionIds = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] GetPersonAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Person
        /// </summary>
        /// <remarks>
        /// Get a specific Person Access Metadata by specifying the corresponding identifier parts and Person code                No matching will be performed through this endpoint. To retrieve an entry, it is necessary to specify, exactly, the identifier of the entry
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <returns>ICollection&lt;AccessMetadataValue&gt;</returns>
        ICollection<AccessMetadataValue> GetPersonAccessMetadataByKey(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] GetPersonAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Person
        /// </summary>
        /// <remarks>
        /// Get a specific Person Access Metadata by specifying the corresponding identifier parts and Person code                No matching will be performed through this endpoint. To retrieve an entry, it is necessary to specify, exactly, the identifier of the entry
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;AccessMetadataValue&gt;</returns>
        ApiResponse<ICollection<AccessMetadataValue>> GetPersonAccessMetadataByKeyWithHttpInfo(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] GetPersonPropertyTimeSeries: Get Person Property Time Series
        /// </summary>
        /// <remarks>
        /// List the complete time series of a person property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely identifies the person.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;.              Each property must be from the \&quot;Person\&quot; domain.</param>
        /// <param name="asAt">The asAt datetime at which to list the person&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>ResourceListOfPropertyInterval</returns>
        ResourceListOfPropertyInterval GetPersonPropertyTimeSeries(string idTypeScope, string idTypeCode, string code, string propertyKey, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?));

        /// <summary>
        /// [EARLY ACCESS] GetPersonPropertyTimeSeries: Get Person Property Time Series
        /// </summary>
        /// <remarks>
        /// List the complete time series of a person property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely identifies the person.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;.              Each property must be from the \&quot;Person\&quot; domain.</param>
        /// <param name="asAt">The asAt datetime at which to list the person&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPropertyInterval</returns>
        ApiResponse<ResourceListOfPropertyInterval> GetPersonPropertyTimeSeriesWithHttpInfo(string idTypeScope, string idTypeCode, string code, string propertyKey, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?));
        /// <summary>
        /// [EARLY ACCESS] GetPersonRelations: Get Relations for Person
        /// </summary>
        /// <remarks>
        /// Get relations for the specified person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relations. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person&#39;s relations. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relations. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relations. If not applicable, provide an empty array. (optional)</param>
        /// <returns>ResourceListOfRelation</returns>
        ResourceListOfRelation GetPersonRelations(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>));

        /// <summary>
        /// [EARLY ACCESS] GetPersonRelations: Get Relations for Person
        /// </summary>
        /// <remarks>
        /// Get relations for the specified person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relations. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person&#39;s relations. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relations. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relations. If not applicable, provide an empty array. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfRelation</returns>
        ApiResponse<ResourceListOfRelation> GetPersonRelationsWithHttpInfo(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] GetPersonRelationships: Get Relationships for Person
        /// </summary>
        /// <remarks>
        /// Get relationships for the specified person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person&#39;s identifier type.</param>
        /// <param name="idTypeCode">Code of the person&#39;s identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <returns>ResourceListOfRelationship</returns>
        ResourceListOfRelationship GetPersonRelationships(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>));

        /// <summary>
        /// [EARLY ACCESS] GetPersonRelationships: Get Relationships for Person
        /// </summary>
        /// <remarks>
        /// Get relationships for the specified person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person&#39;s identifier type.</param>
        /// <param name="idTypeCode">Code of the person&#39;s identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfRelationship</returns>
        ApiResponse<ResourceListOfRelationship> GetPersonRelationshipsWithHttpInfo(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] ListAllPersons: List All Persons
        /// </summary>
        /// <remarks>
        /// List all persons which the user is entitled to see.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the display name, use \&quot;displayName eq &#39;John&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>ResourceListOfPerson</returns>
        ResourceListOfPerson ListAllPersons(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>));

        /// <summary>
        /// [EARLY ACCESS] ListAllPersons: List All Persons
        /// </summary>
        /// <remarks>
        /// List all persons which the user is entitled to see.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the display name, use \&quot;displayName eq &#39;John&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPerson</returns>
        ApiResponse<ResourceListOfPerson> ListAllPersonsWithHttpInfo(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] ListPersons: List Persons
        /// </summary>
        /// <remarks>
        /// List persons which have identifiers of a specific identifier type&#39;s scope and code, and satisfies filter criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the LUPID, use \&quot;lusidPersonId eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>PagedResourceListOfPerson</returns>
        PagedResourceListOfPerson ListPersons(string idTypeScope, string idTypeCode, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>));

        /// <summary>
        /// [EARLY ACCESS] ListPersons: List Persons
        /// </summary>
        /// <remarks>
        /// List persons which have identifiers of a specific identifier type&#39;s scope and code, and satisfies filter criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the LUPID, use \&quot;lusidPersonId eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>ApiResponse of PagedResourceListOfPerson</returns>
        ApiResponse<PagedResourceListOfPerson> ListPersonsWithHttpInfo(string idTypeScope, string idTypeCode, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] PatchPersonAccessMetadata: Patch Access Metadata rules for a Person.
        /// </summary>
        /// <remarks>
        /// Patch Person Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document.    Currently only valid metadata keys are supported paths on the patch document.                The response will return any affected Person Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        Dictionary<string, List<AccessMetadataValue>> PatchPersonAccessMetadata(string idTypeScope, string idTypeCode, string code, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] PatchPersonAccessMetadata: Patch Access Metadata rules for a Person.
        /// </summary>
        /// <remarks>
        /// Patch Person Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document.    Currently only valid metadata keys are supported paths on the patch document.                The response will return any affected Person Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        ApiResponse<Dictionary<string, List<AccessMetadataValue>>> PatchPersonAccessMetadataWithHttpInfo(string idTypeScope, string idTypeCode, string code, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] SetPersonIdentifiers: Set Person Identifiers
        /// </summary>
        /// <remarks>
        /// Set identifiers of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonIdentifiersRequest">Request containing identifiers to set for the person. Identifiers not specified in request will not be changed.</param>
        /// <returns>Person</returns>
        Person SetPersonIdentifiers(string idTypeScope, string idTypeCode, string code, SetPersonIdentifiersRequest setPersonIdentifiersRequest);

        /// <summary>
        /// [EARLY ACCESS] SetPersonIdentifiers: Set Person Identifiers
        /// </summary>
        /// <remarks>
        /// Set identifiers of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonIdentifiersRequest">Request containing identifiers to set for the person. Identifiers not specified in request will not be changed.</param>
        /// <returns>ApiResponse of Person</returns>
        ApiResponse<Person> SetPersonIdentifiersWithHttpInfo(string idTypeScope, string idTypeCode, string code, SetPersonIdentifiersRequest setPersonIdentifiersRequest);
        /// <summary>
        /// [EARLY ACCESS] SetPersonProperties: Set Person Properties
        /// </summary>
        /// <remarks>
        /// Set properties of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonPropertiesRequest">Request containing properties to set for the person. Properties not specified in request will not be changed.</param>
        /// <returns>Person</returns>
        Person SetPersonProperties(string idTypeScope, string idTypeCode, string code, SetPersonPropertiesRequest setPersonPropertiesRequest);

        /// <summary>
        /// [EARLY ACCESS] SetPersonProperties: Set Person Properties
        /// </summary>
        /// <remarks>
        /// Set properties of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonPropertiesRequest">Request containing properties to set for the person. Properties not specified in request will not be changed.</param>
        /// <returns>ApiResponse of Person</returns>
        ApiResponse<Person> SetPersonPropertiesWithHttpInfo(string idTypeScope, string idTypeCode, string code, SetPersonPropertiesRequest setPersonPropertiesRequest);
        /// <summary>
        /// [EARLY ACCESS] UpsertPerson: Upsert Person
        /// </summary>
        /// <remarks>
        /// Create or update a new person under the specified scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertPersonRequest">Request to create or update a person.</param>
        /// <returns>Person</returns>
        Person UpsertPerson(UpsertPersonRequest upsertPersonRequest);

        /// <summary>
        /// [EARLY ACCESS] UpsertPerson: Upsert Person
        /// </summary>
        /// <remarks>
        /// Create or update a new person under the specified scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertPersonRequest">Request to create or update a person.</param>
        /// <returns>ApiResponse of Person</returns>
        ApiResponse<Person> UpsertPersonWithHttpInfo(UpsertPersonRequest upsertPersonRequest);
        /// <summary>
        /// [EARLY ACCESS] UpsertPersonAccessMetadata: Upsert a Person Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Person Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Person Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="upsertPersonAccessMetadataRequest">The Person Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>ResourceListOfAccessMetadataValueOf</returns>
        ResourceListOfAccessMetadataValueOf UpsertPersonAccessMetadata(string idTypeScope, string idTypeCode, string code, string metadataKey, UpsertPersonAccessMetadataRequest upsertPersonAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] UpsertPersonAccessMetadata: Upsert a Person Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Person Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Person Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="upsertPersonAccessMetadataRequest">The Person Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of ResourceListOfAccessMetadataValueOf</returns>
        ApiResponse<ResourceListOfAccessMetadataValueOf> UpsertPersonAccessMetadataWithHttpInfo(string idTypeScope, string idTypeCode, string code, string metadataKey, UpsertPersonAccessMetadataRequest upsertPersonAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPersonsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] DeletePerson: Delete person
        /// </summary>
        /// <remarks>
        /// Delete a person. Deletion will be valid from the person&#39;s creation datetime.  This means that the person will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">The scope of the person identifier type.</param>
        /// <param name="idTypeCode">The code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type scope and code. This together with defined              identifier type uniquely identifies the person to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePersonAsync(string idTypeScope, string idTypeCode, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeletePerson: Delete person
        /// </summary>
        /// <remarks>
        /// Delete a person. Deletion will be valid from the person&#39;s creation datetime.  This means that the person will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">The scope of the person identifier type.</param>
        /// <param name="idTypeCode">The code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type scope and code. This together with defined              identifier type uniquely identifies the person to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePersonWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] DeletePersonAccessMetadata: Delete a Person Access Metadata entry
        /// </summary>
        /// <remarks>
        /// Deletes the Person Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePersonAccessMetadataAsync(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeletePersonAccessMetadata: Delete a Person Access Metadata entry
        /// </summary>
        /// <remarks>
        /// Deletes the Person Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePersonAccessMetadataWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] DeletePersonIdentifiers: Delete Person Identifiers
        /// </summary>
        /// <remarks>
        /// Delete identifiers that belong to the given property keys of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the identifiers to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Identifiers or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the identifiers. Defaults to the current LUSID system datetime if not specified.              Must not include an effective datetime if identifiers are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePersonIdentifiersAsync(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeletePersonIdentifiers: Delete Person Identifiers
        /// </summary>
        /// <remarks>
        /// Delete identifiers that belong to the given property keys of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the identifiers to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Identifiers or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the identifiers. Defaults to the current LUSID system datetime if not specified.              Must not include an effective datetime if identifiers are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePersonIdentifiersWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] DeletePersonProperties: Delete Person Properties
        /// </summary>
        /// <remarks>
        /// Delete all properties that belong to the given property keys of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the person&#39;s properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Properties or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeletePersonPropertiesAsync(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeletePersonProperties: Delete Person Properties
        /// </summary>
        /// <remarks>
        /// Delete all properties that belong to the given property keys of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the person&#39;s properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Properties or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeletePersonPropertiesWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetAllPersonAccessMetadata: Get Access Metadata rules for a Person
        /// </summary>
        /// <remarks>
        /// Pass the Scope and Code of the Person identifier along with the person code parameter to retrieve the associated Access Metadata
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, List<AccessMetadataValue>>> GetAllPersonAccessMetadataAsync(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetAllPersonAccessMetadata: Get Access Metadata rules for a Person
        /// </summary>
        /// <remarks>
        /// Pass the Scope and Code of the Person identifier along with the person code parameter to retrieve the associated Access Metadata
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, List<AccessMetadataValue>>>> GetAllPersonAccessMetadataWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetPerson: Get Person
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto the person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the person. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person. Defaults to return the latest version of the person if not specified. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the person in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Person</returns>
        System.Threading.Tasks.Task<Person> GetPersonAsync(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys = default(List<string>), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetPerson: Get Person
        /// </summary>
        /// <remarks>
        /// Retrieve the definition of a person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto the person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the person. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person. Defaults to return the latest version of the person if not specified. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the person in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Person)</returns>
        System.Threading.Tasks.Task<ApiResponse<Person>> GetPersonWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys = default(List<string>), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetPersonAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Person
        /// </summary>
        /// <remarks>
        /// Get a specific Person Access Metadata by specifying the corresponding identifier parts and Person code                No matching will be performed through this endpoint. To retrieve an entry, it is necessary to specify, exactly, the identifier of the entry
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;AccessMetadataValue&gt;</returns>
        System.Threading.Tasks.Task<ICollection<AccessMetadataValue>> GetPersonAccessMetadataByKeyAsync(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetPersonAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Person
        /// </summary>
        /// <remarks>
        /// Get a specific Person Access Metadata by specifying the corresponding identifier parts and Person code                No matching will be performed through this endpoint. To retrieve an entry, it is necessary to specify, exactly, the identifier of the entry
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;AccessMetadataValue&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<AccessMetadataValue>>> GetPersonAccessMetadataByKeyWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetPersonPropertyTimeSeries: Get Person Property Time Series
        /// </summary>
        /// <remarks>
        /// List the complete time series of a person property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely identifies the person.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;.              Each property must be from the \&quot;Person\&quot; domain.</param>
        /// <param name="asAt">The asAt datetime at which to list the person&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPropertyInterval</returns>
        System.Threading.Tasks.Task<ResourceListOfPropertyInterval> GetPersonPropertyTimeSeriesAsync(string idTypeScope, string idTypeCode, string code, string propertyKey, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetPersonPropertyTimeSeries: Get Person Property Time Series
        /// </summary>
        /// <remarks>
        /// List the complete time series of a person property.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely identifies the person.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;.              Each property must be from the \&quot;Person\&quot; domain.</param>
        /// <param name="asAt">The asAt datetime at which to list the person&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPropertyInterval)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPropertyInterval>> GetPersonPropertyTimeSeriesWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, string propertyKey, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetPersonRelations: Get Relations for Person
        /// </summary>
        /// <remarks>
        /// Get relations for the specified person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relations. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person&#39;s relations. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relations. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relations. If not applicable, provide an empty array. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfRelation</returns>
        System.Threading.Tasks.Task<ResourceListOfRelation> GetPersonRelationsAsync(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetPersonRelations: Get Relations for Person
        /// </summary>
        /// <remarks>
        /// Get relations for the specified person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relations. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person&#39;s relations. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relations. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relations. If not applicable, provide an empty array. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfRelation)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfRelation>> GetPersonRelationsWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetPersonRelationships: Get Relationships for Person
        /// </summary>
        /// <remarks>
        /// Get relationships for the specified person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person&#39;s identifier type.</param>
        /// <param name="idTypeCode">Code of the person&#39;s identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfRelationship</returns>
        System.Threading.Tasks.Task<ResourceListOfRelationship> GetPersonRelationshipsAsync(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetPersonRelationships: Get Relationships for Person
        /// </summary>
        /// <remarks>
        /// Get relationships for the specified person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person&#39;s identifier type.</param>
        /// <param name="idTypeCode">Code of the person&#39;s identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfRelationship)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfRelationship>> GetPersonRelationshipsWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] ListAllPersons: List All Persons
        /// </summary>
        /// <remarks>
        /// List all persons which the user is entitled to see.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the display name, use \&quot;displayName eq &#39;John&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPerson</returns>
        System.Threading.Tasks.Task<ResourceListOfPerson> ListAllPersonsAsync(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] ListAllPersons: List All Persons
        /// </summary>
        /// <remarks>
        /// List all persons which the user is entitled to see.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the display name, use \&quot;displayName eq &#39;John&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPerson)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfPerson>> ListAllPersonsWithHttpInfoAsync(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] ListPersons: List Persons
        /// </summary>
        /// <remarks>
        /// List persons which have identifiers of a specific identifier type&#39;s scope and code, and satisfies filter criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the LUPID, use \&quot;lusidPersonId eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PagedResourceListOfPerson</returns>
        System.Threading.Tasks.Task<PagedResourceListOfPerson> ListPersonsAsync(string idTypeScope, string idTypeCode, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] ListPersons: List Persons
        /// </summary>
        /// <remarks>
        /// List persons which have identifiers of a specific identifier type&#39;s scope and code, and satisfies filter criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the LUPID, use \&quot;lusidPersonId eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PagedResourceListOfPerson)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagedResourceListOfPerson>> ListPersonsWithHttpInfoAsync(string idTypeScope, string idTypeCode, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] PatchPersonAccessMetadata: Patch Access Metadata rules for a Person.
        /// </summary>
        /// <remarks>
        /// Patch Person Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document.    Currently only valid metadata keys are supported paths on the patch document.                The response will return any affected Person Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, List<AccessMetadataValue>>> PatchPersonAccessMetadataAsync(string idTypeScope, string idTypeCode, string code, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] PatchPersonAccessMetadata: Patch Access Metadata rules for a Person.
        /// </summary>
        /// <remarks>
        /// Patch Person Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document.    Currently only valid metadata keys are supported paths on the patch document.                The response will return any affected Person Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, List<AccessMetadataValue>>>> PatchPersonAccessMetadataWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] SetPersonIdentifiers: Set Person Identifiers
        /// </summary>
        /// <remarks>
        /// Set identifiers of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonIdentifiersRequest">Request containing identifiers to set for the person. Identifiers not specified in request will not be changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Person</returns>
        System.Threading.Tasks.Task<Person> SetPersonIdentifiersAsync(string idTypeScope, string idTypeCode, string code, SetPersonIdentifiersRequest setPersonIdentifiersRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] SetPersonIdentifiers: Set Person Identifiers
        /// </summary>
        /// <remarks>
        /// Set identifiers of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonIdentifiersRequest">Request containing identifiers to set for the person. Identifiers not specified in request will not be changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Person)</returns>
        System.Threading.Tasks.Task<ApiResponse<Person>> SetPersonIdentifiersWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, SetPersonIdentifiersRequest setPersonIdentifiersRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] SetPersonProperties: Set Person Properties
        /// </summary>
        /// <remarks>
        /// Set properties of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonPropertiesRequest">Request containing properties to set for the person. Properties not specified in request will not be changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Person</returns>
        System.Threading.Tasks.Task<Person> SetPersonPropertiesAsync(string idTypeScope, string idTypeCode, string code, SetPersonPropertiesRequest setPersonPropertiesRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] SetPersonProperties: Set Person Properties
        /// </summary>
        /// <remarks>
        /// Set properties of the person.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonPropertiesRequest">Request containing properties to set for the person. Properties not specified in request will not be changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Person)</returns>
        System.Threading.Tasks.Task<ApiResponse<Person>> SetPersonPropertiesWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, SetPersonPropertiesRequest setPersonPropertiesRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] UpsertPerson: Upsert Person
        /// </summary>
        /// <remarks>
        /// Create or update a new person under the specified scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertPersonRequest">Request to create or update a person.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Person</returns>
        System.Threading.Tasks.Task<Person> UpsertPersonAsync(UpsertPersonRequest upsertPersonRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] UpsertPerson: Upsert Person
        /// </summary>
        /// <remarks>
        /// Create or update a new person under the specified scope.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertPersonRequest">Request to create or update a person.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Person)</returns>
        System.Threading.Tasks.Task<ApiResponse<Person>> UpsertPersonWithHttpInfoAsync(UpsertPersonRequest upsertPersonRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] UpsertPersonAccessMetadata: Upsert a Person Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Person Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Person Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="upsertPersonAccessMetadataRequest">The Person Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfAccessMetadataValueOf</returns>
        System.Threading.Tasks.Task<ResourceListOfAccessMetadataValueOf> UpsertPersonAccessMetadataAsync(string idTypeScope, string idTypeCode, string code, string metadataKey, UpsertPersonAccessMetadataRequest upsertPersonAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] UpsertPersonAccessMetadata: Upsert a Person Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Person Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Person Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="upsertPersonAccessMetadataRequest">The Person Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfAccessMetadataValueOf)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfAccessMetadataValueOf>> UpsertPersonAccessMetadataWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, string metadataKey, UpsertPersonAccessMetadataRequest upsertPersonAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPersonsApi : IPersonsApiSync, IPersonsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PersonsApi : IPersonsApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PersonsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PersonsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="PersonsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PersonsApi(Lusid.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PersonsApi(Lusid.Sdk.Client.ISynchronousClient client, Lusid.Sdk.Client.IAsynchronousClient asyncClient, Lusid.Sdk.Client.IReadableConfiguration configuration)
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
        /// [EARLY ACCESS] DeletePerson: Delete person Delete a person. Deletion will be valid from the person&#39;s creation datetime.  This means that the person will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">The scope of the person identifier type.</param>
        /// <param name="idTypeCode">The code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type scope and code. This together with defined              identifier type uniquely identifies the person to delete.</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePerson(string idTypeScope, string idTypeCode, string code)
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeletePersonWithHttpInfo(idTypeScope, idTypeCode, code);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePerson: Delete person Delete a person. Deletion will be valid from the person&#39;s creation datetime.  This means that the person will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">The scope of the person identifier type.</param>
        /// <param name="idTypeCode">The code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type scope and code. This together with defined              identifier type uniquely identifies the person to delete.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> DeletePersonWithHttpInfo(string idTypeScope, string idTypeCode, string code)
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->DeletePerson");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->DeletePerson");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->DeletePerson");

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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeletedEntityResponse>("/api/persons/{idTypeScope}/{idTypeCode}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePerson", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePerson: Delete person Delete a person. Deletion will be valid from the person&#39;s creation datetime.  This means that the person will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">The scope of the person identifier type.</param>
        /// <param name="idTypeCode">The code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type scope and code. This together with defined              identifier type uniquely identifies the person to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePersonAsync(string idTypeScope, string idTypeCode, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePersonWithHttpInfoAsync(idTypeScope, idTypeCode, code, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePerson: Delete person Delete a person. Deletion will be valid from the person&#39;s creation datetime.  This means that the person will no longer exist at any effective datetime from the asAt datetime of deletion.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">The scope of the person identifier type.</param>
        /// <param name="idTypeCode">The code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type scope and code. This together with defined              identifier type uniquely identifies the person to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeletePersonWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->DeletePerson");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->DeletePerson");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->DeletePerson");


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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/persons/{idTypeScope}/{idTypeCode}/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePerson", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePersonAccessMetadata: Delete a Person Access Metadata entry Deletes the Person Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePersonAccessMetadata(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeletePersonAccessMetadataWithHttpInfo(idTypeScope, idTypeCode, code, metadataKey, effectiveAt, effectiveUntil);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePersonAccessMetadata: Delete a Person Access Metadata entry Deletes the Person Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> DeletePersonAccessMetadataWithHttpInfo(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->DeletePersonAccessMetadata");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->DeletePersonAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->DeletePersonAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PersonsApi->DeletePersonAccessMetadata");

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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeletedEntityResponse>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePersonAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePersonAccessMetadata: Delete a Person Access Metadata entry Deletes the Person Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePersonAccessMetadataAsync(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePersonAccessMetadataWithHttpInfoAsync(idTypeScope, idTypeCode, code, metadataKey, effectiveAt, effectiveUntil, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePersonAccessMetadata: Delete a Person Access Metadata entry Deletes the Person Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effective date to delete at, if this is not supplied, it will delete all data found (optional)</param>
        /// <param name="effectiveUntil">The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeletePersonAccessMetadataWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->DeletePersonAccessMetadata");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->DeletePersonAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->DeletePersonAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PersonsApi->DeletePersonAccessMetadata");


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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePersonAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePersonIdentifiers: Delete Person Identifiers Delete identifiers that belong to the given property keys of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the identifiers to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Identifiers or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the identifiers. Defaults to the current LUSID system datetime if not specified.              Must not include an effective datetime if identifiers are perpetual. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePersonIdentifiers(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeletePersonIdentifiersWithHttpInfo(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePersonIdentifiers: Delete Person Identifiers Delete identifiers that belong to the given property keys of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the identifiers to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Identifiers or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the identifiers. Defaults to the current LUSID system datetime if not specified.              Must not include an effective datetime if identifiers are perpetual. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> DeletePersonIdentifiersWithHttpInfo(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->DeletePersonIdentifiers");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->DeletePersonIdentifiers");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->DeletePersonIdentifiers");

            // verify the required parameter 'propertyKeys' is set
            if (propertyKeys == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKeys' when calling PersonsApi->DeletePersonIdentifiers");

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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeletedEntityResponse>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/identifiers", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePersonIdentifiers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePersonIdentifiers: Delete Person Identifiers Delete identifiers that belong to the given property keys of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the identifiers to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Identifiers or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the identifiers. Defaults to the current LUSID system datetime if not specified.              Must not include an effective datetime if identifiers are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePersonIdentifiersAsync(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePersonIdentifiersWithHttpInfoAsync(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePersonIdentifiers: Delete Person Identifiers Delete identifiers that belong to the given property keys of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the identifiers to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Identifiers or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete the identifiers. Defaults to the current LUSID system datetime if not specified.              Must not include an effective datetime if identifiers are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeletePersonIdentifiersWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->DeletePersonIdentifiers");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->DeletePersonIdentifiers");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->DeletePersonIdentifiers");

            // verify the required parameter 'propertyKeys' is set
            if (propertyKeys == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKeys' when calling PersonsApi->DeletePersonIdentifiers");


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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/identifiers", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePersonIdentifiers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePersonProperties: Delete Person Properties Delete all properties that belong to the given property keys of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the person&#39;s properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Properties or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeletePersonProperties(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeletePersonPropertiesWithHttpInfo(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePersonProperties: Delete Person Properties Delete all properties that belong to the given property keys of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the person&#39;s properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Properties or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> DeletePersonPropertiesWithHttpInfo(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->DeletePersonProperties");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->DeletePersonProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->DeletePersonProperties");

            // verify the required parameter 'propertyKeys' is set
            if (propertyKeys == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKeys' when calling PersonsApi->DeletePersonProperties");

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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeletedEntityResponse>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/properties", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePersonProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePersonProperties: Delete Person Properties Delete all properties that belong to the given property keys of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the person&#39;s properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Properties or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeletePersonPropertiesAsync(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeletePersonPropertiesWithHttpInfoAsync(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeletePersonProperties: Delete Person Properties Delete all properties that belong to the given property keys of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">The property keys of the person&#39;s properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Properties or identifiers not specified in request will not be changed.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeletePersonPropertiesWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->DeletePersonProperties");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->DeletePersonProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->DeletePersonProperties");

            // verify the required parameter 'propertyKeys' is set
            if (propertyKeys == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKeys' when calling PersonsApi->DeletePersonProperties");


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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/properties", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePersonProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetAllPersonAccessMetadata: Get Access Metadata rules for a Person Pass the Scope and Code of the Person identifier along with the person code parameter to retrieve the associated Access Metadata
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <returns>Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public Dictionary<string, List<AccessMetadataValue>> GetAllPersonAccessMetadata(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> localVarResponse = GetAllPersonAccessMetadataWithHttpInfo(idTypeScope, idTypeCode, code, effectiveAt, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetAllPersonAccessMetadata: Get Access Metadata rules for a Person Pass the Scope and Code of the Person identifier along with the person code parameter to retrieve the associated Access Metadata
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> GetAllPersonAccessMetadataWithHttpInfo(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->GetAllPersonAccessMetadata");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->GetAllPersonAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->GetAllPersonAccessMetadata");

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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Get<Dictionary<string, List<AccessMetadataValue>>>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllPersonAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetAllPersonAccessMetadata: Get Access Metadata rules for a Person Pass the Scope and Code of the Person identifier along with the person code parameter to retrieve the associated Access Metadata
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, List<AccessMetadataValue>>> GetAllPersonAccessMetadataAsync(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> localVarResponse = await GetAllPersonAccessMetadataWithHttpInfoAsync(idTypeScope, idTypeCode, code, effectiveAt, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetAllPersonAccessMetadata: Get Access Metadata rules for a Person Pass the Scope and Code of the Person identifier along with the person code parameter to retrieve the associated Access Metadata
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>>> GetAllPersonAccessMetadataWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->GetAllPersonAccessMetadata");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->GetAllPersonAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->GetAllPersonAccessMetadata");


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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Dictionary<string, List<AccessMetadataValue>>>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllPersonAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPerson: Get Person Retrieve the definition of a person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto the person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the person. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person. Defaults to return the latest version of the person if not specified. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the person in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>Person</returns>
        public Person GetPerson(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys = default(List<string>), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> relationshipDefinitionIds = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<Person> localVarResponse = GetPersonWithHttpInfo(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPerson: Get Person Retrieve the definition of a person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto the person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the person. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person. Defaults to return the latest version of the person if not specified. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the person in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>ApiResponse of Person</returns>
        public Lusid.Sdk.Client.ApiResponse<Person> GetPersonWithHttpInfo(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys = default(List<string>), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> relationshipDefinitionIds = default(List<string>))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->GetPerson");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->GetPerson");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->GetPerson");

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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (relationshipDefinitionIds != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "relationshipDefinitionIds", relationshipDefinitionIds));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Get<Person>("/api/persons/{idTypeScope}/{idTypeCode}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPerson", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPerson: Get Person Retrieve the definition of a person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto the person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the person. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person. Defaults to return the latest version of the person if not specified. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the person in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Person</returns>
        public async System.Threading.Tasks.Task<Person> GetPersonAsync(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys = default(List<string>), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Person> localVarResponse = await GetPersonWithHttpInfoAsync(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPerson: Get Person Retrieve the definition of a person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto the person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to retrieve the person. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person. Defaults to return the latest version of the person if not specified. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the person in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Person)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Person>> GetPersonWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, List<string> propertyKeys = default(List<string>), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->GetPerson");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->GetPerson");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->GetPerson");


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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (propertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "propertyKeys", propertyKeys));
            }
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (relationshipDefinitionIds != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "relationshipDefinitionIds", relationshipDefinitionIds));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Person>("/api/persons/{idTypeScope}/{idTypeCode}/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPerson", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Person Get a specific Person Access Metadata by specifying the corresponding identifier parts and Person code                No matching will be performed through this endpoint. To retrieve an entry, it is necessary to specify, exactly, the identifier of the entry
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <returns>ICollection&lt;AccessMetadataValue&gt;</returns>
        public ICollection<AccessMetadataValue> GetPersonAccessMetadataByKey(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>> localVarResponse = GetPersonAccessMetadataByKeyWithHttpInfo(idTypeScope, idTypeCode, code, metadataKey, effectiveAt, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Person Get a specific Person Access Metadata by specifying the corresponding identifier parts and Person code                No matching will be performed through this endpoint. To retrieve an entry, it is necessary to specify, exactly, the identifier of the entry
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;AccessMetadataValue&gt;</returns>
        public Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>> GetPersonAccessMetadataByKeyWithHttpInfo(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->GetPersonAccessMetadataByKey");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->GetPersonAccessMetadataByKey");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->GetPersonAccessMetadataByKey");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PersonsApi->GetPersonAccessMetadataByKey");

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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ICollection<AccessMetadataValue>>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPersonAccessMetadataByKey", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Person Get a specific Person Access Metadata by specifying the corresponding identifier parts and Person code                No matching will be performed through this endpoint. To retrieve an entry, it is necessary to specify, exactly, the identifier of the entry
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;AccessMetadataValue&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<AccessMetadataValue>> GetPersonAccessMetadataByKeyAsync(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>> localVarResponse = await GetPersonAccessMetadataByKeyWithHttpInfoAsync(idTypeScope, idTypeCode, code, metadataKey, effectiveAt, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Person Get a specific Person Access Metadata by specifying the corresponding identifier parts and Person code                No matching will be performed through this endpoint. To retrieve an entry, it is necessary to specify, exactly, the identifier of the entry
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;AccessMetadataValue&gt;)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>>> GetPersonAccessMetadataByKeyWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->GetPersonAccessMetadataByKey");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->GetPersonAccessMetadataByKey");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->GetPersonAccessMetadataByKey");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PersonsApi->GetPersonAccessMetadataByKey");


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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ICollection<AccessMetadataValue>>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPersonAccessMetadataByKey", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonPropertyTimeSeries: Get Person Property Time Series List the complete time series of a person property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely identifies the person.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;.              Each property must be from the \&quot;Person\&quot; domain.</param>
        /// <param name="asAt">The asAt datetime at which to list the person&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>ResourceListOfPropertyInterval</returns>
        public ResourceListOfPropertyInterval GetPersonPropertyTimeSeries(string idTypeScope, string idTypeCode, string code, string propertyKey, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPropertyInterval> localVarResponse = GetPersonPropertyTimeSeriesWithHttpInfo(idTypeScope, idTypeCode, code, propertyKey, asAt, filter, page, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonPropertyTimeSeries: Get Person Property Time Series List the complete time series of a person property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely identifies the person.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;.              Each property must be from the \&quot;Person\&quot; domain.</param>
        /// <param name="asAt">The asAt datetime at which to list the person&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPropertyInterval</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfPropertyInterval> GetPersonPropertyTimeSeriesWithHttpInfo(string idTypeScope, string idTypeCode, string code, string propertyKey, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->GetPersonPropertyTimeSeries");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->GetPersonPropertyTimeSeries");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->GetPersonPropertyTimeSeries");

            // verify the required parameter 'propertyKey' is set
            if (propertyKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKey' when calling PersonsApi->GetPersonPropertyTimeSeries");

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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "propertyKey", propertyKey));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfPropertyInterval>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/properties/time-series", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPersonPropertyTimeSeries", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonPropertyTimeSeries: Get Person Property Time Series List the complete time series of a person property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely identifies the person.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;.              Each property must be from the \&quot;Person\&quot; domain.</param>
        /// <param name="asAt">The asAt datetime at which to list the person&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPropertyInterval</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPropertyInterval> GetPersonPropertyTimeSeriesAsync(string idTypeScope, string idTypeCode, string code, string propertyKey, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPropertyInterval> localVarResponse = await GetPersonPropertyTimeSeriesWithHttpInfoAsync(idTypeScope, idTypeCode, code, propertyKey, asAt, filter, page, limit, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonPropertyTimeSeries: Get Person Property Time Series List the complete time series of a person property.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely identifies the person.</param>
        /// <param name="propertyKey">The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;.              Each property must be from the \&quot;Person\&quot; domain.</param>
        /// <param name="asAt">The asAt datetime at which to list the person&#39;s property history. Defaults to return the current datetime if not supplied. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter and asAt fields              must not have changed since the original request. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPropertyInterval)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfPropertyInterval>> GetPersonPropertyTimeSeriesWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, string propertyKey, DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), string page = default(string), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->GetPersonPropertyTimeSeries");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->GetPersonPropertyTimeSeries");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->GetPersonPropertyTimeSeries");

            // verify the required parameter 'propertyKey' is set
            if (propertyKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'propertyKey' when calling PersonsApi->GetPersonPropertyTimeSeries");


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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "propertyKey", propertyKey));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfPropertyInterval>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/properties/time-series", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPersonPropertyTimeSeries", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonRelations: Get Relations for Person Get relations for the specified person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relations. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person&#39;s relations. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relations. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relations. If not applicable, provide an empty array. (optional)</param>
        /// <returns>ResourceListOfRelation</returns>
        public ResourceListOfRelation GetPersonRelations(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfRelation> localVarResponse = GetPersonRelationsWithHttpInfo(idTypeScope, idTypeCode, code, effectiveAt, asAt, filter, identifierTypes);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonRelations: Get Relations for Person Get relations for the specified person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relations. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person&#39;s relations. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relations. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relations. If not applicable, provide an empty array. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfRelation</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfRelation> GetPersonRelationsWithHttpInfo(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->GetPersonRelations");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->GetPersonRelations");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->GetPersonRelations");

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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfRelation>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/relations", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPersonRelations", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonRelations: Get Relations for Person Get relations for the specified person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relations. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person&#39;s relations. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relations. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relations. If not applicable, provide an empty array. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfRelation</returns>
        public async System.Threading.Tasks.Task<ResourceListOfRelation> GetPersonRelationsAsync(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfRelation> localVarResponse = await GetPersonRelationsWithHttpInfoAsync(idTypeScope, idTypeCode, code, effectiveAt, asAt, filter, identifierTypes, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonRelations: Get Relations for Person Get relations for the specified person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relations. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the person&#39;s relations. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the relations. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relations. If not applicable, provide an empty array. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfRelation)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfRelation>> GetPersonRelationsWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->GetPersonRelations");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->GetPersonRelations");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->GetPersonRelations");


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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfRelation>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/relations", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPersonRelations", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonRelationships: Get Relationships for Person Get relationships for the specified person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person&#39;s identifier type.</param>
        /// <param name="idTypeCode">Code of the person&#39;s identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <returns>ResourceListOfRelationship</returns>
        public ResourceListOfRelationship GetPersonRelationships(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfRelationship> localVarResponse = GetPersonRelationshipsWithHttpInfo(idTypeScope, idTypeCode, code, effectiveAt, asAt, filter, identifierTypes);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonRelationships: Get Relationships for Person Get relationships for the specified person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person&#39;s identifier type.</param>
        /// <param name="idTypeCode">Code of the person&#39;s identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfRelationship</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfRelationship> GetPersonRelationshipsWithHttpInfo(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->GetPersonRelationships");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->GetPersonRelationships");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->GetPersonRelationships");

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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfRelationship>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/relationships", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPersonRelationships", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonRelationships: Get Relationships for Person Get relationships for the specified person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person&#39;s identifier type.</param>
        /// <param name="idTypeCode">Code of the person&#39;s identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfRelationship</returns>
        public async System.Threading.Tasks.Task<ResourceListOfRelationship> GetPersonRelationshipsAsync(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfRelationship> localVarResponse = await GetPersonRelationshipsWithHttpInfoAsync(idTypeScope, idTypeCode, code, effectiveAt, asAt, filter, identifierTypes, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetPersonRelationships: Get Relationships for Person Get relationships for the specified person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person&#39;s identifier type.</param>
        /// <param name="idTypeCode">Code of the person&#39;s identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfRelationship)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfRelationship>> GetPersonRelationshipsWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->GetPersonRelationships");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->GetPersonRelationships");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->GetPersonRelationships");


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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfRelationship>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/relationships", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPersonRelationships", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListAllPersons: List All Persons List all persons which the user is entitled to see.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the display name, use \&quot;displayName eq &#39;John&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>ResourceListOfPerson</returns>
        public ResourceListOfPerson ListAllPersons(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPerson> localVarResponse = ListAllPersonsWithHttpInfo(effectiveAt, asAt, page, limit, filter, propertyKeys, relationshipDefinitionIds);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListAllPersons: List All Persons List all persons which the user is entitled to see.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the display name, use \&quot;displayName eq &#39;John&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfPerson</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfPerson> ListAllPersonsWithHttpInfo(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>))
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
            if (relationshipDefinitionIds != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "relationshipDefinitionIds", relationshipDefinitionIds));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfPerson>("/api/persons", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListAllPersons", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListAllPersons: List All Persons List all persons which the user is entitled to see.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the display name, use \&quot;displayName eq &#39;John&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfPerson</returns>
        public async System.Threading.Tasks.Task<ResourceListOfPerson> ListAllPersonsAsync(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfPerson> localVarResponse = await ListAllPersonsWithHttpInfoAsync(effectiveAt, asAt, page, limit, filter, propertyKeys, relationshipDefinitionIds, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListAllPersons: List All Persons List all persons which the user is entitled to see.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the display name, use \&quot;displayName eq &#39;John&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfPerson)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfPerson>> ListAllPersonsWithHttpInfoAsync(DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            if (relationshipDefinitionIds != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "relationshipDefinitionIds", relationshipDefinitionIds));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfPerson>("/api/persons", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListAllPersons", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListPersons: List Persons List persons which have identifiers of a specific identifier type&#39;s scope and code, and satisfies filter criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the LUPID, use \&quot;lusidPersonId eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>PagedResourceListOfPerson</returns>
        public PagedResourceListOfPerson ListPersons(string idTypeScope, string idTypeCode, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<PagedResourceListOfPerson> localVarResponse = ListPersonsWithHttpInfo(idTypeScope, idTypeCode, effectiveAt, asAt, page, start, limit, filter, propertyKeys, relationshipDefinitionIds);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListPersons: List Persons List persons which have identifiers of a specific identifier type&#39;s scope and code, and satisfies filter criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the LUPID, use \&quot;lusidPersonId eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>ApiResponse of PagedResourceListOfPerson</returns>
        public Lusid.Sdk.Client.ApiResponse<PagedResourceListOfPerson> ListPersonsWithHttpInfo(string idTypeScope, string idTypeCode, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->ListPersons");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->ListPersons");

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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
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
            if (relationshipDefinitionIds != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "relationshipDefinitionIds", relationshipDefinitionIds));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Get<PagedResourceListOfPerson>("/api/persons/{idTypeScope}/{idTypeCode}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPersons", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListPersons: List Persons List persons which have identifiers of a specific identifier type&#39;s scope and code, and satisfies filter criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the LUPID, use \&quot;lusidPersonId eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PagedResourceListOfPerson</returns>
        public async System.Threading.Tasks.Task<PagedResourceListOfPerson> ListPersonsAsync(string idTypeScope, string idTypeCode, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PagedResourceListOfPerson> localVarResponse = await ListPersonsWithHttpInfoAsync(idTypeScope, idTypeCode, effectiveAt, asAt, page, start, limit, filter, propertyKeys, relationshipDefinitionIds, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListPersons: List Persons List persons which have identifiers of a specific identifier type&#39;s scope and code, and satisfies filter criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the result set.               For example, to filter on the LUPID, use \&quot;lusidPersonId eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="propertyKeys">A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PagedResourceListOfPerson)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PagedResourceListOfPerson>> ListPersonsWithHttpInfoAsync(string idTypeScope, string idTypeCode, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), List<string> propertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->ListPersons");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->ListPersons");


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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
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
            if (relationshipDefinitionIds != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "relationshipDefinitionIds", relationshipDefinitionIds));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PagedResourceListOfPerson>("/api/persons/{idTypeScope}/{idTypeCode}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPersons", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] PatchPersonAccessMetadata: Patch Access Metadata rules for a Person. Patch Person Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document.    Currently only valid metadata keys are supported paths on the patch document.                The response will return any affected Person Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public Dictionary<string, List<AccessMetadataValue>> PatchPersonAccessMetadata(string idTypeScope, string idTypeCode, string code, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> localVarResponse = PatchPersonAccessMetadataWithHttpInfo(idTypeScope, idTypeCode, code, accessMetadataOperation, effectiveAt, effectiveUntil);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] PatchPersonAccessMetadata: Patch Access Metadata rules for a Person. Patch Person Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document.    Currently only valid metadata keys are supported paths on the patch document.                The response will return any affected Person Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> PatchPersonAccessMetadataWithHttpInfo(string idTypeScope, string idTypeCode, string code, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->PatchPersonAccessMetadata");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->PatchPersonAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->PatchPersonAccessMetadata");

            // verify the required parameter 'accessMetadataOperation' is set
            if (accessMetadataOperation == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'accessMetadataOperation' when calling PersonsApi->PatchPersonAccessMetadata");

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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (effectiveUntil != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveUntil", effectiveUntil));
            }
            localVarRequestOptions.Data = accessMetadataOperation;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Patch<Dictionary<string, List<AccessMetadataValue>>>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchPersonAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] PatchPersonAccessMetadata: Patch Access Metadata rules for a Person. Patch Person Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document.    Currently only valid metadata keys are supported paths on the patch document.                The response will return any affected Person Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, List<AccessMetadataValue>>> PatchPersonAccessMetadataAsync(string idTypeScope, string idTypeCode, string code, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> localVarResponse = await PatchPersonAccessMetadataWithHttpInfoAsync(idTypeScope, idTypeCode, code, accessMetadataOperation, effectiveAt, effectiveUntil, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] PatchPersonAccessMetadata: Patch Access Metadata rules for a Person. Patch Person Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document.    Currently only valid metadata keys are supported paths on the patch document.                The response will return any affected Person Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>>> PatchPersonAccessMetadataWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->PatchPersonAccessMetadata");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->PatchPersonAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->PatchPersonAccessMetadata");

            // verify the required parameter 'accessMetadataOperation' is set
            if (accessMetadataOperation == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'accessMetadataOperation' when calling PersonsApi->PatchPersonAccessMetadata");


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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (effectiveUntil != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveUntil", effectiveUntil));
            }
            localVarRequestOptions.Data = accessMetadataOperation;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PatchAsync<Dictionary<string, List<AccessMetadataValue>>>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchPersonAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] SetPersonIdentifiers: Set Person Identifiers Set identifiers of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonIdentifiersRequest">Request containing identifiers to set for the person. Identifiers not specified in request will not be changed.</param>
        /// <returns>Person</returns>
        public Person SetPersonIdentifiers(string idTypeScope, string idTypeCode, string code, SetPersonIdentifiersRequest setPersonIdentifiersRequest)
        {
            Lusid.Sdk.Client.ApiResponse<Person> localVarResponse = SetPersonIdentifiersWithHttpInfo(idTypeScope, idTypeCode, code, setPersonIdentifiersRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] SetPersonIdentifiers: Set Person Identifiers Set identifiers of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonIdentifiersRequest">Request containing identifiers to set for the person. Identifiers not specified in request will not be changed.</param>
        /// <returns>ApiResponse of Person</returns>
        public Lusid.Sdk.Client.ApiResponse<Person> SetPersonIdentifiersWithHttpInfo(string idTypeScope, string idTypeCode, string code, SetPersonIdentifiersRequest setPersonIdentifiersRequest)
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->SetPersonIdentifiers");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->SetPersonIdentifiers");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->SetPersonIdentifiers");

            // verify the required parameter 'setPersonIdentifiersRequest' is set
            if (setPersonIdentifiersRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'setPersonIdentifiersRequest' when calling PersonsApi->SetPersonIdentifiers");

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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.Data = setPersonIdentifiersRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Post<Person>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/identifiers", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetPersonIdentifiers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] SetPersonIdentifiers: Set Person Identifiers Set identifiers of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonIdentifiersRequest">Request containing identifiers to set for the person. Identifiers not specified in request will not be changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Person</returns>
        public async System.Threading.Tasks.Task<Person> SetPersonIdentifiersAsync(string idTypeScope, string idTypeCode, string code, SetPersonIdentifiersRequest setPersonIdentifiersRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Person> localVarResponse = await SetPersonIdentifiersWithHttpInfoAsync(idTypeScope, idTypeCode, code, setPersonIdentifiersRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] SetPersonIdentifiers: Set Person Identifiers Set identifiers of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonIdentifiersRequest">Request containing identifiers to set for the person. Identifiers not specified in request will not be changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Person)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Person>> SetPersonIdentifiersWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, SetPersonIdentifiersRequest setPersonIdentifiersRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->SetPersonIdentifiers");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->SetPersonIdentifiers");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->SetPersonIdentifiers");

            // verify the required parameter 'setPersonIdentifiersRequest' is set
            if (setPersonIdentifiersRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'setPersonIdentifiersRequest' when calling PersonsApi->SetPersonIdentifiers");


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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.Data = setPersonIdentifiersRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Person>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/identifiers", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetPersonIdentifiers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] SetPersonProperties: Set Person Properties Set properties of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonPropertiesRequest">Request containing properties to set for the person. Properties not specified in request will not be changed.</param>
        /// <returns>Person</returns>
        public Person SetPersonProperties(string idTypeScope, string idTypeCode, string code, SetPersonPropertiesRequest setPersonPropertiesRequest)
        {
            Lusid.Sdk.Client.ApiResponse<Person> localVarResponse = SetPersonPropertiesWithHttpInfo(idTypeScope, idTypeCode, code, setPersonPropertiesRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] SetPersonProperties: Set Person Properties Set properties of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonPropertiesRequest">Request containing properties to set for the person. Properties not specified in request will not be changed.</param>
        /// <returns>ApiResponse of Person</returns>
        public Lusid.Sdk.Client.ApiResponse<Person> SetPersonPropertiesWithHttpInfo(string idTypeScope, string idTypeCode, string code, SetPersonPropertiesRequest setPersonPropertiesRequest)
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->SetPersonProperties");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->SetPersonProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->SetPersonProperties");

            // verify the required parameter 'setPersonPropertiesRequest' is set
            if (setPersonPropertiesRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'setPersonPropertiesRequest' when calling PersonsApi->SetPersonProperties");

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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.Data = setPersonPropertiesRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Post<Person>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/properties", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetPersonProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] SetPersonProperties: Set Person Properties Set properties of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonPropertiesRequest">Request containing properties to set for the person. Properties not specified in request will not be changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Person</returns>
        public async System.Threading.Tasks.Task<Person> SetPersonPropertiesAsync(string idTypeScope, string idTypeCode, string code, SetPersonPropertiesRequest setPersonPropertiesRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Person> localVarResponse = await SetPersonPropertiesWithHttpInfoAsync(idTypeScope, idTypeCode, code, setPersonPropertiesRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] SetPersonProperties: Set Person Properties Set properties of the person.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier type.</param>
        /// <param name="idTypeCode">Code of the person identifier type.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person.</param>
        /// <param name="setPersonPropertiesRequest">Request containing properties to set for the person. Properties not specified in request will not be changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Person)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Person>> SetPersonPropertiesWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, SetPersonPropertiesRequest setPersonPropertiesRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->SetPersonProperties");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->SetPersonProperties");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->SetPersonProperties");

            // verify the required parameter 'setPersonPropertiesRequest' is set
            if (setPersonPropertiesRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'setPersonPropertiesRequest' when calling PersonsApi->SetPersonProperties");


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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Lusid.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            localVarRequestOptions.Data = setPersonPropertiesRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Person>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/properties", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetPersonProperties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPerson: Upsert Person Create or update a new person under the specified scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertPersonRequest">Request to create or update a person.</param>
        /// <returns>Person</returns>
        public Person UpsertPerson(UpsertPersonRequest upsertPersonRequest)
        {
            Lusid.Sdk.Client.ApiResponse<Person> localVarResponse = UpsertPersonWithHttpInfo(upsertPersonRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPerson: Upsert Person Create or update a new person under the specified scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertPersonRequest">Request to create or update a person.</param>
        /// <returns>ApiResponse of Person</returns>
        public Lusid.Sdk.Client.ApiResponse<Person> UpsertPersonWithHttpInfo(UpsertPersonRequest upsertPersonRequest)
        {
            // verify the required parameter 'upsertPersonRequest' is set
            if (upsertPersonRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'upsertPersonRequest' when calling PersonsApi->UpsertPerson");

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

            localVarRequestOptions.Data = upsertPersonRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Post<Person>("/api/persons", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertPerson", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPerson: Upsert Person Create or update a new person under the specified scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertPersonRequest">Request to create or update a person.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Person</returns>
        public async System.Threading.Tasks.Task<Person> UpsertPersonAsync(UpsertPersonRequest upsertPersonRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Person> localVarResponse = await UpsertPersonWithHttpInfoAsync(upsertPersonRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPerson: Upsert Person Create or update a new person under the specified scope.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="upsertPersonRequest">Request to create or update a person.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Person)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Person>> UpsertPersonWithHttpInfoAsync(UpsertPersonRequest upsertPersonRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'upsertPersonRequest' is set
            if (upsertPersonRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'upsertPersonRequest' when calling PersonsApi->UpsertPerson");


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

            localVarRequestOptions.Data = upsertPersonRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Person>("/api/persons", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertPerson", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPersonAccessMetadata: Upsert a Person Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID. Update or insert one Person Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Person Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="upsertPersonAccessMetadataRequest">The Person Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>ResourceListOfAccessMetadataValueOf</returns>
        public ResourceListOfAccessMetadataValueOf UpsertPersonAccessMetadata(string idTypeScope, string idTypeCode, string code, string metadataKey, UpsertPersonAccessMetadataRequest upsertPersonAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfAccessMetadataValueOf> localVarResponse = UpsertPersonAccessMetadataWithHttpInfo(idTypeScope, idTypeCode, code, metadataKey, upsertPersonAccessMetadataRequest, effectiveAt, effectiveUntil);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPersonAccessMetadata: Upsert a Person Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID. Update or insert one Person Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Person Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="upsertPersonAccessMetadataRequest">The Person Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of ResourceListOfAccessMetadataValueOf</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfAccessMetadataValueOf> UpsertPersonAccessMetadataWithHttpInfo(string idTypeScope, string idTypeCode, string code, string metadataKey, UpsertPersonAccessMetadataRequest upsertPersonAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->UpsertPersonAccessMetadata");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->UpsertPersonAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->UpsertPersonAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PersonsApi->UpsertPersonAccessMetadata");

            // verify the required parameter 'upsertPersonAccessMetadataRequest' is set
            if (upsertPersonAccessMetadataRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'upsertPersonAccessMetadataRequest' when calling PersonsApi->UpsertPersonAccessMetadata");

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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
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
            localVarRequestOptions.Data = upsertPersonAccessMetadataRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request
            var localVarResponse = this.Client.Put<ResourceListOfAccessMetadataValueOf>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertPersonAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPersonAccessMetadata: Upsert a Person Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID. Update or insert one Person Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Person Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="upsertPersonAccessMetadataRequest">The Person Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfAccessMetadataValueOf</returns>
        public async System.Threading.Tasks.Task<ResourceListOfAccessMetadataValueOf> UpsertPersonAccessMetadataAsync(string idTypeScope, string idTypeCode, string code, string metadataKey, UpsertPersonAccessMetadataRequest upsertPersonAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfAccessMetadataValueOf> localVarResponse = await UpsertPersonAccessMetadataWithHttpInfoAsync(idTypeScope, idTypeCode, code, metadataKey, upsertPersonAccessMetadataRequest, effectiveAt, effectiveUntil, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertPersonAccessMetadata: Upsert a Person Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID. Update or insert one Person Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Person Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTypeScope">Scope of the person identifier.</param>
        /// <param name="idTypeCode">Code of the person identifier.</param>
        /// <param name="code">Code of the person under specified identifier type&#39;s scope and code.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="upsertPersonAccessMetadataRequest">The Person Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to upsert the Access Metadata (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfAccessMetadataValueOf)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfAccessMetadataValueOf>> UpsertPersonAccessMetadataWithHttpInfoAsync(string idTypeScope, string idTypeCode, string code, string metadataKey, UpsertPersonAccessMetadataRequest upsertPersonAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'idTypeScope' is set
            if (idTypeScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeScope' when calling PersonsApi->UpsertPersonAccessMetadata");

            // verify the required parameter 'idTypeCode' is set
            if (idTypeCode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'idTypeCode' when calling PersonsApi->UpsertPersonAccessMetadata");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling PersonsApi->UpsertPersonAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling PersonsApi->UpsertPersonAccessMetadata");

            // verify the required parameter 'upsertPersonAccessMetadataRequest' is set
            if (upsertPersonAccessMetadataRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'upsertPersonAccessMetadataRequest' when calling PersonsApi->UpsertPersonAccessMetadata");


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

            localVarRequestOptions.PathParameters.Add("idTypeScope", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeScope)); // path parameter
            localVarRequestOptions.PathParameters.Add("idTypeCode", Lusid.Sdk.Client.ClientUtils.ParameterToString(idTypeCode)); // path parameter
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
            localVarRequestOptions.Data = upsertPersonAccessMetadataRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5222");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<ResourceListOfAccessMetadataValueOf>("/api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertPersonAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}