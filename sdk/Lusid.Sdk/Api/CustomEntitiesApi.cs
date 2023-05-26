/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](../../../api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application   | Description                                                                       | API / Swagger Documentation                          | |- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | LUSID         | Open, API-first, developer-friendly investment data platform.                     | [Swagger](../../../api/swagger/index.html)           | | Web app       | User-facing front end for LUSID.                                                  | [Swagger](../../../app/swagger/index.html)           | | Scheduler     | Automated job scheduler.                                                          | [Swagger](../../../scheduler2/swagger/index.html)    | | Insights      | Monitoring and troubleshooting service.                                           | [Swagger](../../../insights/swagger/index.html)      | | Identity      | Identity management for LUSID (in conjunction with Access)                        | [Swagger](../../../identity/swagger/index.html)      | | Access        | Access control for LUSID (in conjunction with Identity)                           | [Swagger](../../../access/swagger/index.html)        | | Drive         | Secure file repository and manager for collaboration.                             | [Swagger](../../../drive/swagger/index.html)         | | Luminesce     | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](../../../honeycomb/swagger/index.html)     | | Notification  | Notification service.                                                             | [Swagger](../../../notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information.                           | [Swagger](../../../configuration/swagger/index.html) |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-10\">-10</a>|Server Configuration Error|  | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"102\">102</a>|Version Not Found|  | | <a name=\"103\">103</a>|Api Rate Limit Violation|  | | <a name=\"104\">104</a>|Instrument Not Found|  | | <a name=\"105\">105</a>|Property Not Found|  | | <a name=\"106\">106</a>|Portfolio Recursion Depth|  | | <a name=\"108\">108</a>|Group Not Found|  | | <a name=\"109\">109</a>|Portfolio Not Found|  | | <a name=\"110\">110</a>|Property Schema Not Found|  | | <a name=\"111\">111</a>|Portfolio Ancestry Not Found|  | | <a name=\"112\">112</a>|Portfolio With Id Already Exists|  | | <a name=\"113\">113</a>|Orphaned Portfolio|  | | <a name=\"119\">119</a>|Missing Base Claims|  | | <a name=\"121\">121</a>|Property Not Defined|  | | <a name=\"122\">122</a>|Cannot Delete System Property|  | | <a name=\"123\">123</a>|Cannot Modify Immutable Property Field|  | | <a name=\"124\">124</a>|Property Already Exists|  | | <a name=\"125\">125</a>|Invalid Property Life Time|  | | <a name=\"126\">126</a>|Property Constraint Style Excludes Properties|  | | <a name=\"127\">127</a>|Cannot Modify Default Data Type|  | | <a name=\"128\">128</a>|Group Already Exists|  | | <a name=\"129\">129</a>|No Such Data Type|  | | <a name=\"130\">130</a>|Undefined Value For Data Type|  | | <a name=\"131\">131</a>|Unsupported Value Type Defined On Data Type|  | | <a name=\"132\">132</a>|Validation Error|  | | <a name=\"133\">133</a>|Loop Detected In Group Hierarchy|  | | <a name=\"134\">134</a>|Undefined Acceptable Values|  | | <a name=\"135\">135</a>|Sub Group Already Exists|  | | <a name=\"138\">138</a>|Price Source Not Found|  | | <a name=\"139\">139</a>|Analytic Store Not Found|  | | <a name=\"141\">141</a>|Analytic Store Already Exists|  | | <a name=\"143\">143</a>|Client Instrument Already Exists|  | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"147\">147</a>|Results Not Found|  | | <a name=\"148\">148</a>|Order Field Not In Result Set|  | | <a name=\"149\">149</a>|Operation Failed|  | | <a name=\"150\">150</a>|Elastic Search Error|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"153\">153</a>|Command Processing Failure|  | | <a name=\"154\">154</a>|Entity State Construction Failure|  | | <a name=\"155\">155</a>|Entity Timeline Does Not Exist|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"158\">158</a>|Event Publish Unknown|  | | <a name=\"159\">159</a>|Event Query Failure|  | | <a name=\"160\">160</a>|Blob Did Not Exist|  | | <a name=\"162\">162</a>|Sub System Request Failure|  | | <a name=\"163\">163</a>|Sub System Configuration Failure|  | | <a name=\"165\">165</a>|Failed To Delete|  | | <a name=\"166\">166</a>|Upsert Client Instrument Failure|  | | <a name=\"167\">167</a>|Illegal As At Interval|  | | <a name=\"168\">168</a>|Illegal Bitemporal Query|  | | <a name=\"169\">169</a>|Invalid Alternate Id|  | | <a name=\"170\">170</a>|Cannot Add Source Portfolio Property Explicitly|  | | <a name=\"171\">171</a>|Entity Already Exists In Group|  | | <a name=\"173\">173</a>|Entity With Id Already Exists|  | | <a name=\"174\">174</a>|Derived Portfolio Details Do Not Exist|  | | <a name=\"175\">175</a>|Entity Not In Group|  | | <a name=\"176\">176</a>|Portfolio With Name Already Exists|  | | <a name=\"177\">177</a>|Invalid Transactions|  | | <a name=\"178\">178</a>|Reference Portfolio Not Found|  | | <a name=\"179\">179</a>|Duplicate Id|  | | <a name=\"180\">180</a>|Command Retrieval Failure|  | | <a name=\"181\">181</a>|Data Filter Application Failure|  | | <a name=\"182\">182</a>|Search Failed|  | | <a name=\"183\">183</a>|Movements Engine Configuration Key Failure|  | | <a name=\"184\">184</a>|Fx Rate Source Not Found|  | | <a name=\"185\">185</a>|Accrual Source Not Found|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"188\">188</a>|Invalid Request Headers|  | | <a name=\"189\">189</a>|Price Not Found|  | | <a name=\"190\">190</a>|Invalid Sub Holding Keys Provided|  | | <a name=\"191\">191</a>|Duplicate Sub Holding Keys Provided|  | | <a name=\"192\">192</a>|Cut Definition Not Found|  | | <a name=\"193\">193</a>|Cut Definition Invalid|  | | <a name=\"194\">194</a>|Time Variant Property Deletion Date Unspecified|  | | <a name=\"195\">195</a>|Perpetual Property Deletion Date Specified|  | | <a name=\"196\">196</a>|Time Variant Property Upsert Date Unspecified|  | | <a name=\"197\">197</a>|Perpetual Property Upsert Date Specified|  | | <a name=\"200\">200</a>|Invalid Unit For Data Type|  | | <a name=\"201\">201</a>|Invalid Type For Data Type|  | | <a name=\"202\">202</a>|Invalid Value For Data Type|  | | <a name=\"203\">203</a>|Unit Not Defined For Data Type|  | | <a name=\"204\">204</a>|Units Not Supported On Data Type|  | | <a name=\"205\">205</a>|Cannot Specify Units On Data Type|  | | <a name=\"206\">206</a>|Unit Schema Inconsistent With Data Type|  | | <a name=\"207\">207</a>|Unit Definition Not Specified|  | | <a name=\"208\">208</a>|Duplicate Unit Definitions Specified|  | | <a name=\"209\">209</a>|Invalid Units Definition|  | | <a name=\"210\">210</a>|Invalid Instrument Identifier Unit|  | | <a name=\"211\">211</a>|Holdings Adjustment Does Not Exist|  | | <a name=\"212\">212</a>|Could Not Build Excel Url|  | | <a name=\"213\">213</a>|Could Not Get Excel Version|  | | <a name=\"214\">214</a>|Instrument By Code Not Found|  | | <a name=\"215\">215</a>|Entity Schema Does Not Exist|  | | <a name=\"216\">216</a>|Feature Not Supported On Portfolio Type|  | | <a name=\"217\">217</a>|Quote Not Found|  | | <a name=\"218\">218</a>|Invalid Quote Identifier|  | | <a name=\"219\">219</a>|Invalid Metric For Data Type|  | | <a name=\"220\">220</a>|Invalid Instrument Definition|  | | <a name=\"221\">221</a>|Instrument Upsert Failure|  | | <a name=\"222\">222</a>|Reference Portfolio Request Not Supported|  | | <a name=\"223\">223</a>|Transaction Portfolio Request Not Supported|  | | <a name=\"224\">224</a>|Invalid Property Value Assignment|  | | <a name=\"230\">230</a>|Transaction Type Not Found|  | | <a name=\"231\">231</a>|Transaction Type Duplication|  | | <a name=\"232\">232</a>|Portfolio Does Not Exist At Given Date|  | | <a name=\"233\">233</a>|Query Parser Failure|  | | <a name=\"234\">234</a>|Duplicate Constituent|  | | <a name=\"235\">235</a>|Unresolved Instrument Constituent|  | | <a name=\"236\">236</a>|Unresolved Instrument In Transition|  | | <a name=\"237\">237</a>|Missing Side Definitions|  | | <a name=\"299\">299</a>|Invalid Recipe|  | | <a name=\"300\">300</a>|Missing Recipe|  | | <a name=\"301\">301</a>|Dependencies|  | | <a name=\"304\">304</a>|Portfolio Preprocess Failure|  | | <a name=\"310\">310</a>|Valuation Engine Failure|  | | <a name=\"311\">311</a>|Task Factory Failure|  | | <a name=\"312\">312</a>|Task Evaluation Failure|  | | <a name=\"313\">313</a>|Task Generation Failure|  | | <a name=\"314\">314</a>|Engine Configuration Failure|  | | <a name=\"315\">315</a>|Model Specification Failure|  | | <a name=\"320\">320</a>|Market Data Key Failure|  | | <a name=\"321\">321</a>|Market Resolver Failure|  | | <a name=\"322\">322</a>|Market Data Failure|  | | <a name=\"330\">330</a>|Curve Failure|  | | <a name=\"331\">331</a>|Volatility Surface Failure|  | | <a name=\"332\">332</a>|Volatility Cube Failure|  | | <a name=\"350\">350</a>|Instrument Failure|  | | <a name=\"351\">351</a>|Cash Flows Failure|  | | <a name=\"352\">352</a>|Reference Data Failure|  | | <a name=\"360\">360</a>|Aggregation Failure|  | | <a name=\"361\">361</a>|Aggregation Measure Failure|  | | <a name=\"370\">370</a>|Result Retrieval Failure|  | | <a name=\"371\">371</a>|Result Processing Failure|  | | <a name=\"372\">372</a>|Vendor Result Processing Failure|  | | <a name=\"373\">373</a>|Vendor Result Mapping Failure|  | | <a name=\"374\">374</a>|Vendor Library Unauthorised|  | | <a name=\"375\">375</a>|Vendor Connectivity Error|  | | <a name=\"376\">376</a>|Vendor Interface Error|  | | <a name=\"377\">377</a>|Vendor Pricing Failure|  | | <a name=\"378\">378</a>|Vendor Translation Failure|  | | <a name=\"379\">379</a>|Vendor Key Mapping Failure|  | | <a name=\"380\">380</a>|Vendor Reflection Failure|  | | <a name=\"381\">381</a>|Vendor Process Failure|  | | <a name=\"382\">382</a>|Vendor System Failure|  | | <a name=\"390\">390</a>|Attempt To Upsert Duplicate Quotes|  | | <a name=\"391\">391</a>|Corporate Action Source Does Not Exist|  | | <a name=\"392\">392</a>|Corporate Action Source Already Exists|  | | <a name=\"393\">393</a>|Instrument Identifier Already In Use|  | | <a name=\"394\">394</a>|Properties Not Found|  | | <a name=\"395\">395</a>|Batch Operation Aborted|  | | <a name=\"400\">400</a>|Invalid Iso4217 Currency Code|  | | <a name=\"401\">401</a>|Cannot Assign Instrument Identifier To Currency|  | | <a name=\"402\">402</a>|Cannot Assign Currency Identifier To Non Currency|  | | <a name=\"403\">403</a>|Currency Instrument Cannot Be Deleted|  | | <a name=\"404\">404</a>|Currency Instrument Cannot Have Economic Definition|  | | <a name=\"405\">405</a>|Currency Instrument Cannot Have Lookthrough Portfolio|  | | <a name=\"406\">406</a>|Cannot Create Currency Instrument With Multiple Identifiers|  | | <a name=\"407\">407</a>|Specified Currency Is Undefined|  | | <a name=\"410\">410</a>|Index Does Not Exist|  | | <a name=\"411\">411</a>|Sort Field Does Not Exist|  | | <a name=\"413\">413</a>|Negative Pagination Parameters|  | | <a name=\"414\">414</a>|Invalid Search Syntax|  | | <a name=\"415\">415</a>|Filter Execution Timeout|  | | <a name=\"420\">420</a>|Side Definition Inconsistent|  | | <a name=\"450\">450</a>|Invalid Quote Access Metadata Rule|  | | <a name=\"451\">451</a>|Access Metadata Not Found|  | | <a name=\"452\">452</a>|Invalid Access Metadata Identifier|  | | <a name=\"460\">460</a>|Standard Resource Not Found|  | | <a name=\"461\">461</a>|Standard Resource Conflict|  | | <a name=\"462\">462</a>|Calendar Not Found|  | | <a name=\"463\">463</a>|Date In A Calendar Not Found|  | | <a name=\"464\">464</a>|Invalid Date Source Data|  | | <a name=\"465\">465</a>|Invalid Timezone|  | | <a name=\"601\">601</a>|Person Identifier Already In Use|  | | <a name=\"602\">602</a>|Person Not Found|  | | <a name=\"603\">603</a>|Cannot Set Identifier|  | | <a name=\"617\">617</a>|Invalid Recipe Specification In Request|  | | <a name=\"618\">618</a>|Inline Recipe Deserialisation Failure|  | | <a name=\"619\">619</a>|Identifier Types Not Set For Entity|  | | <a name=\"620\">620</a>|Cannot Delete All Client Defined Identifiers|  | | <a name=\"650\">650</a>|The Order requested was not found.|  | | <a name=\"654\">654</a>|The Allocation requested was not found.|  | | <a name=\"655\">655</a>|Cannot build the fx forward target with the given holdings.|  | | <a name=\"656\">656</a>|Group does not contain expected entities.|  | | <a name=\"665\">665</a>|Destination directory not found|  | | <a name=\"667\">667</a>|Relation definition already exists|  | | <a name=\"672\">672</a>|Could not retrieve file contents|  | | <a name=\"673\">673</a>|Missing entitlements for entities in Group|  | | <a name=\"674\">674</a>|Next Best Action not found|  | | <a name=\"676\">676</a>|Relation definition not defined|  | | <a name=\"677\">677</a>|Invalid entity identifier for relation|  | | <a name=\"681\">681</a>|Sorting by specified field not supported|One or more of the provided fields to order by were either invalid or not supported. | | <a name=\"682\">682</a>|Too many fields to sort by|The number of fields to sort the data by exceeds the number allowed by the endpoint | | <a name=\"684\">684</a>|Sequence Not Found|  | | <a name=\"685\">685</a>|Sequence Already Exists|  | | <a name=\"686\">686</a>|Non-cycling sequence has been exhausted|  | | <a name=\"687\">687</a>|Legal Entity Identifier Already In Use|  | | <a name=\"688\">688</a>|Legal Entity Not Found|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"690\">690</a>|Property Type Is Not Supported|  | | <a name=\"691\">691</a>|Multiple Tax-lots For Currency Type Is Not Supported|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"693\">693</a>|Entity type is not supported for Relationship|  | | <a name=\"694\">694</a>|Relationship Validation Failure|  | | <a name=\"695\">695</a>|Relationship Not Found|  | | <a name=\"697\">697</a>|Derived Property Formula No Longer Valid|  | | <a name=\"698\">698</a>|Story is not available|  | | <a name=\"703\">703</a>|Corporate Action Does Not Exist|  | | <a name=\"720\">720</a>|The provided sort and filter combination is not valid|  | | <a name=\"721\">721</a>|A2B generation failed|  | | <a name=\"722\">722</a>|Aggregated Return Calculation Failure|  | | <a name=\"723\">723</a>|Custom Entity Definition Identifier Already In Use|  | | <a name=\"724\">724</a>|Custom Entity Definition Not Found|  | | <a name=\"725\">725</a>|The Placement requested was not found.|  | | <a name=\"726\">726</a>|The Execution requested was not found.|  | | <a name=\"727\">727</a>|The Block requested was not found.|  | | <a name=\"728\">728</a>|The Participation requested was not found.|  | | <a name=\"729\">729</a>|The Package requested was not found.|  | | <a name=\"730\">730</a>|The OrderInstruction requested was not found.|  | | <a name=\"732\">732</a>|Custom Entity not found.|  | | <a name=\"733\">733</a>|Custom Entity Identifier already in use.|  | | <a name=\"735\">735</a>|Calculation Failed.|  | | <a name=\"736\">736</a>|An expected key on HttpResponse is missing.|  | | <a name=\"737\">737</a>|A required fee detail is missing.|  | | <a name=\"738\">738</a>|Zero rows were returned from Luminesce|  | | <a name=\"739\">739</a>|Provided Weekend Mask was invalid|  | | <a name=\"742\">742</a>|Custom Entity fields do not match the definition|  | | <a name=\"746\">746</a>|The provided sequence is not valid.|  | | <a name=\"751\">751</a>|The type of the Custom Entity is different than the type provided in the definition.|  | | <a name=\"752\">752</a>|Luminesce process returned an error.|  | | <a name=\"753\">753</a>|File name or content incompatible with operation.|  | | <a name=\"755\">755</a>|Schema of response from Drive is not as expected.|  | | <a name=\"757\">757</a>|Schema of response from Luminesce is not as expected.|  | | <a name=\"758\">758</a>|Luminesce timed out.|  | | <a name=\"763\">763</a>|Invalid Lusid Entity Identifier Unit|  | | <a name=\"768\">768</a>|Fee rule not found.|  | | <a name=\"769\">769</a>|Cannot update the base currency of a portfolio with transactions loaded|  | | <a name=\"771\">771</a>|Transaction configuration source not found|  | | <a name=\"774\">774</a>|Compliance rule not found.|  | | <a name=\"775\">775</a>|Fund accounting document cannot be processed.|  | | <a name=\"778\">778</a>|Unable to look up FX rate from trade ccy to portfolio ccy for some of the trades.|  | | <a name=\"782\">782</a>|The Property definition dataType is not matching the derivation formula dataType|  | | <a name=\"783\">783</a>|The Property definition domain is not supported for derived properties|  | | <a name=\"788\">788</a>|Compliance run not found failure.|  | | <a name=\"790\">790</a>|Custom Entity has missing or invalid identifiers|  | | <a name=\"791\">791</a>|Custom Entity definition already exists|  | | <a name=\"792\">792</a>|Compliance PropertyKey is missing.|  | | <a name=\"793\">793</a>|Compliance Criteria Value for matching is missing.|  | | <a name=\"795\">795</a>|Cannot delete identifier definition|  | | <a name=\"796\">796</a>|Tax rule set not found.|  | | <a name=\"797\">797</a>|A tax rule set with this id already exists.|  | | <a name=\"798\">798</a>|Multiple rule sets for the same property key are applicable.|  | | <a name=\"800\">800</a>|Can not upsert an instrument event of this type.|  | | <a name=\"801\">801</a>|The instrument event does not exist.|  | | <a name=\"802\">802</a>|The Instrument event is missing salient information.|  | | <a name=\"803\">803</a>|The Instrument event could not be processed.|  | | <a name=\"804\">804</a>|Some data requested does not follow the order graph assumptions.|  | | <a name=\"811\">811</a>|A price could not be found for an order.|  | | <a name=\"812\">812</a>|A price could not be found for an allocation.|  | | <a name=\"813\">813</a>|Chart of Accounts not found.|  | | <a name=\"814\">814</a>|Account not found.|  | | <a name=\"815\">815</a>|Abor not found.|  | | <a name=\"816\">816</a>|Abor Configuration not found.|  | | <a name=\"817\">817</a>|Reconciliation mapping not found|  | | <a name=\"818\">818</a>|Attribute type could not be deleted because it doesn't exist.|  | | <a name=\"819\">819</a>|Reconciliation not found.|  | | <a name=\"820\">820</a>|Custodian Account not found.|  | | <a name=\"821\">821</a>|Allocation Failure|  | | <a name=\"822\">822</a>|Reconciliation run not found|  | | <a name=\"823\">823</a>|Reconciliation break not found|  | | <a name=\"824\">824</a>|Entity link type could not be deleted because it doesn't exist.|  | | <a name=\"828\">828</a>|Address key definition not found.|  | | <a name=\"829\">829</a>|Compliance template not found.|  | | <a name=\"830\">830</a>|Action not supported|  | | <a name=\"831\">831</a>|Reference list not found.|  | | <a name=\"832\">832</a>|Posting Module not found.|  | 
 *
 * The version of the OpenAPI document: 1.0.206
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
    public interface ICustomEntitiesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EARLY ACCESS] DeleteCustomEntity: Delete a Custom Entity instance.
        /// </summary>
        /// <remarks>
        /// Delete a Custom Entity instance by a specific entity type.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to remove.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeleteCustomEntity(string entityType, string identifierType, string identifierValue, string identifierScope);

        /// <summary>
        /// [EARLY ACCESS] DeleteCustomEntity: Delete a Custom Entity instance.
        /// </summary>
        /// <remarks>
        /// Delete a Custom Entity instance by a specific entity type.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to remove.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeleteCustomEntityWithHttpInfo(string entityType, string identifierType, string identifierValue, string identifierScope);
        /// <summary>
        /// [EARLY ACCESS] DeleteCustomEntityAccessMetadata: Delete a Custom Entity Access Metadata entry
        /// </summary>
        /// <remarks>
        /// Deletes the Custom Entity Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to delete.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata. (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeleteCustomEntityAccessMetadata(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] DeleteCustomEntityAccessMetadata: Delete a Custom Entity Access Metadata entry
        /// </summary>
        /// <remarks>
        /// Deletes the Custom Entity Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to delete.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata. (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeleteCustomEntityAccessMetadataWithHttpInfo(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] GetAllCustomEntityAccessMetadata: Get all the Access Metadata rules for a Custom Entity
        /// </summary>
        /// <remarks>
        /// Get all the Custom Entity access metadata for the specified identifier scope, code and value
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <returns>Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        Dictionary<string, List<AccessMetadataValue>> GetAllCustomEntityAccessMetadata(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] GetAllCustomEntityAccessMetadata: Get all the Access Metadata rules for a Custom Entity
        /// </summary>
        /// <remarks>
        /// Get all the Custom Entity access metadata for the specified identifier scope, code and value
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        ApiResponse<Dictionary<string, List<AccessMetadataValue>>> GetAllCustomEntityAccessMetadataWithHttpInfo(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] GetCustomEntity: Get a Custom Entity instance.
        /// </summary>
        /// <remarks>
        /// Retrieve a Custom Entity instance by a specific entity type at a point in AsAt time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to retrieve. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the Custom Entity instance. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the Custom Entity instance. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entity in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>CustomEntityResponse</returns>
        CustomEntityResponse GetCustomEntity(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>));

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntity: Get a Custom Entity instance.
        /// </summary>
        /// <remarks>
        /// Retrieve a Custom Entity instance by a specific entity type at a point in AsAt time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to retrieve. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the Custom Entity instance. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the Custom Entity instance. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entity in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>ApiResponse of CustomEntityResponse</returns>
        ApiResponse<CustomEntityResponse> GetCustomEntityWithHttpInfo(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Custom Entity
        /// </summary>
        /// <remarks>
        /// Get Custom Entity access metadata for the specified metadata key
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <returns>ICollection&lt;AccessMetadataValue&gt;</returns>
        ICollection<AccessMetadataValue> GetCustomEntityAccessMetadataByKey(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Custom Entity
        /// </summary>
        /// <remarks>
        /// Get Custom Entity access metadata for the specified metadata key
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;AccessMetadataValue&gt;</returns>
        ApiResponse<ICollection<AccessMetadataValue>> GetCustomEntityAccessMetadataByKeyWithHttpInfo(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityRelationships: Get Relationships for Custom Entity
        /// </summary>
        /// <remarks>
        /// Get relationships for the specified Custom Entity.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of entity get relationships for.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relationships. If not applicable, provide an empty array. (optional)</param>
        /// <returns>ResourceListOfRelationship</returns>
        ResourceListOfRelationship GetCustomEntityRelationships(string entityType, string identifierScope, string identifierType, string identifierValue, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>));

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityRelationships: Get Relationships for Custom Entity
        /// </summary>
        /// <remarks>
        /// Get relationships for the specified Custom Entity.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of entity get relationships for.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relationships. If not applicable, provide an empty array. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfRelationship</returns>
        ApiResponse<ResourceListOfRelationship> GetCustomEntityRelationshipsWithHttpInfo(string entityType, string identifierScope, string identifierType, string identifierValue, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] ListCustomEntities: List Custom Entities of the specified entityType.
        /// </summary>
        /// <remarks>
        /// List all the Custom Entities matching particular criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the entities. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the entities. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing entities; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entities in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>PagedResourceListOfCustomEntityResponse</returns>
        PagedResourceListOfCustomEntityResponse ListCustomEntities(string entityType, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), int? limit = default(int?), string filter = default(string), string page = default(string), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>));

        /// <summary>
        /// [EARLY ACCESS] ListCustomEntities: List Custom Entities of the specified entityType.
        /// </summary>
        /// <remarks>
        /// List all the Custom Entities matching particular criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the entities. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the entities. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing entities; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entities in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>ApiResponse of PagedResourceListOfCustomEntityResponse</returns>
        ApiResponse<PagedResourceListOfCustomEntityResponse> ListCustomEntitiesWithHttpInfo(string entityType, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), int? limit = default(int?), string filter = default(string), string page = default(string), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] PatchCustomEntityAccessMetadata: Patch Access Metadata rules for a Custom Entity.
        /// </summary>
        /// <remarks>
        /// Patch Custom Entity Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document    Currently only valid metadata keys are supported paths on the patch document                The response will return any affected Custom Entity Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        Dictionary<string, List<AccessMetadataValue>> PatchCustomEntityAccessMetadata(string entityType, string identifierType, string identifierValue, string identifierScope, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] PatchCustomEntityAccessMetadata: Patch Access Metadata rules for a Custom Entity.
        /// </summary>
        /// <remarks>
        /// Patch Custom Entity Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document    Currently only valid metadata keys are supported paths on the patch document                The response will return any affected Custom Entity Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        ApiResponse<Dictionary<string, List<AccessMetadataValue>>> PatchCustomEntityAccessMetadataWithHttpInfo(string entityType, string identifierType, string identifierValue, string identifierScope, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntities: Batch upsert instances of Custom Entities
        /// </summary>
        /// <remarks>
        /// Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The payload describing the Custom Entity instances</param>
        /// <returns>UpsertCustomEntitiesResponse</returns>
        UpsertCustomEntitiesResponse UpsertCustomEntities(string entityType, string successMode, Dictionary<string, CustomEntityRequest> requestBody);

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntities: Batch upsert instances of Custom Entities
        /// </summary>
        /// <remarks>
        /// Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The payload describing the Custom Entity instances</param>
        /// <returns>ApiResponse of UpsertCustomEntitiesResponse</returns>
        ApiResponse<UpsertCustomEntitiesResponse> UpsertCustomEntitiesWithHttpInfo(string entityType, string successMode, Dictionary<string, CustomEntityRequest> requestBody);
        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntity: Upsert a Custom Entity instance
        /// </summary>
        /// <remarks>
        /// Insert the Custom Entity if it does not exist or update the Custom Entity with the supplied state if it does exist.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="customEntityRequest">The payload describing the Custom Entity instance.</param>
        /// <returns>CustomEntityResponse</returns>
        CustomEntityResponse UpsertCustomEntity(string entityType, CustomEntityRequest customEntityRequest);

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntity: Upsert a Custom Entity instance
        /// </summary>
        /// <remarks>
        /// Insert the Custom Entity if it does not exist or update the Custom Entity with the supplied state if it does exist.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="customEntityRequest">The payload describing the Custom Entity instance.</param>
        /// <returns>ApiResponse of CustomEntityResponse</returns>
        ApiResponse<CustomEntityResponse> UpsertCustomEntityWithHttpInfo(string entityType, CustomEntityRequest customEntityRequest);
        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntityAccessMetadata: Upsert a Custom Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Custom Entity Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Custom Entity Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="upsertCustomEntityAccessMetadataRequest">The Custom Entity Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>ICollection&lt;AccessMetadataValue&gt;</returns>
        ICollection<AccessMetadataValue> UpsertCustomEntityAccessMetadata(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, UpsertCustomEntityAccessMetadataRequest upsertCustomEntityAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntityAccessMetadata: Upsert a Custom Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Custom Entity Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Custom Entity Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="upsertCustomEntityAccessMetadataRequest">The Custom Entity Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;AccessMetadataValue&gt;</returns>
        ApiResponse<ICollection<AccessMetadataValue>> UpsertCustomEntityAccessMetadataWithHttpInfo(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, UpsertCustomEntityAccessMetadataRequest upsertCustomEntityAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICustomEntitiesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] DeleteCustomEntity: Delete a Custom Entity instance.
        /// </summary>
        /// <remarks>
        /// Delete a Custom Entity instance by a specific entity type.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to remove.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeleteCustomEntityAsync(string entityType, string identifierType, string identifierValue, string identifierScope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeleteCustomEntity: Delete a Custom Entity instance.
        /// </summary>
        /// <remarks>
        /// Delete a Custom Entity instance by a specific entity type.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to remove.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeleteCustomEntityWithHttpInfoAsync(string entityType, string identifierType, string identifierValue, string identifierScope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] DeleteCustomEntityAccessMetadata: Delete a Custom Entity Access Metadata entry
        /// </summary>
        /// <remarks>
        /// Deletes the Custom Entity Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to delete.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata. (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeleteCustomEntityAccessMetadataAsync(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeleteCustomEntityAccessMetadata: Delete a Custom Entity Access Metadata entry
        /// </summary>
        /// <remarks>
        /// Deletes the Custom Entity Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to delete.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata. (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeleteCustomEntityAccessMetadataWithHttpInfoAsync(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetAllCustomEntityAccessMetadata: Get all the Access Metadata rules for a Custom Entity
        /// </summary>
        /// <remarks>
        /// Get all the Custom Entity access metadata for the specified identifier scope, code and value
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, List<AccessMetadataValue>>> GetAllCustomEntityAccessMetadataAsync(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetAllCustomEntityAccessMetadata: Get all the Access Metadata rules for a Custom Entity
        /// </summary>
        /// <remarks>
        /// Get all the Custom Entity access metadata for the specified identifier scope, code and value
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, List<AccessMetadataValue>>>> GetAllCustomEntityAccessMetadataWithHttpInfoAsync(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetCustomEntity: Get a Custom Entity instance.
        /// </summary>
        /// <remarks>
        /// Retrieve a Custom Entity instance by a specific entity type at a point in AsAt time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to retrieve. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the Custom Entity instance. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the Custom Entity instance. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entity in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CustomEntityResponse</returns>
        System.Threading.Tasks.Task<CustomEntityResponse> GetCustomEntityAsync(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntity: Get a Custom Entity instance.
        /// </summary>
        /// <remarks>
        /// Retrieve a Custom Entity instance by a specific entity type at a point in AsAt time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to retrieve. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the Custom Entity instance. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the Custom Entity instance. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entity in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CustomEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomEntityResponse>> GetCustomEntityWithHttpInfoAsync(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Custom Entity
        /// </summary>
        /// <remarks>
        /// Get Custom Entity access metadata for the specified metadata key
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;AccessMetadataValue&gt;</returns>
        System.Threading.Tasks.Task<ICollection<AccessMetadataValue>> GetCustomEntityAccessMetadataByKeyAsync(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Custom Entity
        /// </summary>
        /// <remarks>
        /// Get Custom Entity access metadata for the specified metadata key
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;AccessMetadataValue&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<AccessMetadataValue>>> GetCustomEntityAccessMetadataByKeyWithHttpInfoAsync(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityRelationships: Get Relationships for Custom Entity
        /// </summary>
        /// <remarks>
        /// Get relationships for the specified Custom Entity.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of entity get relationships for.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relationships. If not applicable, provide an empty array. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfRelationship</returns>
        System.Threading.Tasks.Task<ResourceListOfRelationship> GetCustomEntityRelationshipsAsync(string entityType, string identifierScope, string identifierType, string identifierValue, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityRelationships: Get Relationships for Custom Entity
        /// </summary>
        /// <remarks>
        /// Get relationships for the specified Custom Entity.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of entity get relationships for.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relationships. If not applicable, provide an empty array. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfRelationship)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfRelationship>> GetCustomEntityRelationshipsWithHttpInfoAsync(string entityType, string identifierScope, string identifierType, string identifierValue, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] ListCustomEntities: List Custom Entities of the specified entityType.
        /// </summary>
        /// <remarks>
        /// List all the Custom Entities matching particular criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the entities. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the entities. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing entities; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entities in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PagedResourceListOfCustomEntityResponse</returns>
        System.Threading.Tasks.Task<PagedResourceListOfCustomEntityResponse> ListCustomEntitiesAsync(string entityType, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), int? limit = default(int?), string filter = default(string), string page = default(string), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] ListCustomEntities: List Custom Entities of the specified entityType.
        /// </summary>
        /// <remarks>
        /// List all the Custom Entities matching particular criteria.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the entities. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the entities. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing entities; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entities in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PagedResourceListOfCustomEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagedResourceListOfCustomEntityResponse>> ListCustomEntitiesWithHttpInfoAsync(string entityType, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), int? limit = default(int?), string filter = default(string), string page = default(string), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] PatchCustomEntityAccessMetadata: Patch Access Metadata rules for a Custom Entity.
        /// </summary>
        /// <remarks>
        /// Patch Custom Entity Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document    Currently only valid metadata keys are supported paths on the patch document                The response will return any affected Custom Entity Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, List<AccessMetadataValue>>> PatchCustomEntityAccessMetadataAsync(string entityType, string identifierType, string identifierValue, string identifierScope, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] PatchCustomEntityAccessMetadata: Patch Access Metadata rules for a Custom Entity.
        /// </summary>
        /// <remarks>
        /// Patch Custom Entity Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document    Currently only valid metadata keys are supported paths on the patch document                The response will return any affected Custom Entity Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, List<AccessMetadataValue>>>> PatchCustomEntityAccessMetadataWithHttpInfoAsync(string entityType, string identifierType, string identifierValue, string identifierScope, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntities: Batch upsert instances of Custom Entities
        /// </summary>
        /// <remarks>
        /// Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The payload describing the Custom Entity instances</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpsertCustomEntitiesResponse</returns>
        System.Threading.Tasks.Task<UpsertCustomEntitiesResponse> UpsertCustomEntitiesAsync(string entityType, string successMode, Dictionary<string, CustomEntityRequest> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntities: Batch upsert instances of Custom Entities
        /// </summary>
        /// <remarks>
        /// Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The payload describing the Custom Entity instances</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpsertCustomEntitiesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpsertCustomEntitiesResponse>> UpsertCustomEntitiesWithHttpInfoAsync(string entityType, string successMode, Dictionary<string, CustomEntityRequest> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntity: Upsert a Custom Entity instance
        /// </summary>
        /// <remarks>
        /// Insert the Custom Entity if it does not exist or update the Custom Entity with the supplied state if it does exist.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="customEntityRequest">The payload describing the Custom Entity instance.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CustomEntityResponse</returns>
        System.Threading.Tasks.Task<CustomEntityResponse> UpsertCustomEntityAsync(string entityType, CustomEntityRequest customEntityRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntity: Upsert a Custom Entity instance
        /// </summary>
        /// <remarks>
        /// Insert the Custom Entity if it does not exist or update the Custom Entity with the supplied state if it does exist.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="customEntityRequest">The payload describing the Custom Entity instance.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CustomEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomEntityResponse>> UpsertCustomEntityWithHttpInfoAsync(string entityType, CustomEntityRequest customEntityRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntityAccessMetadata: Upsert a Custom Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Custom Entity Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Custom Entity Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="upsertCustomEntityAccessMetadataRequest">The Custom Entity Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;AccessMetadataValue&gt;</returns>
        System.Threading.Tasks.Task<ICollection<AccessMetadataValue>> UpsertCustomEntityAccessMetadataAsync(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, UpsertCustomEntityAccessMetadataRequest upsertCustomEntityAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntityAccessMetadata: Upsert a Custom Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
        /// </summary>
        /// <remarks>
        /// Update or insert one Custom Entity Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Custom Entity Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="upsertCustomEntityAccessMetadataRequest">The Custom Entity Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;AccessMetadataValue&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<AccessMetadataValue>>> UpsertCustomEntityAccessMetadataWithHttpInfoAsync(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, UpsertCustomEntityAccessMetadataRequest upsertCustomEntityAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICustomEntitiesApi : ICustomEntitiesApiSync, ICustomEntitiesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CustomEntitiesApi : ICustomEntitiesApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEntitiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomEntitiesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEntitiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomEntitiesApi(String basePath)
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
        /// Initializes a new instance of the <see cref="CustomEntitiesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CustomEntitiesApi(Lusid.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEntitiesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CustomEntitiesApi(Lusid.Sdk.Client.ISynchronousClient client, Lusid.Sdk.Client.IAsynchronousClient asyncClient, Lusid.Sdk.Client.IReadableConfiguration configuration)
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
        /// [EARLY ACCESS] DeleteCustomEntity: Delete a Custom Entity instance. Delete a Custom Entity instance by a specific entity type.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to remove.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeleteCustomEntity(string entityType, string identifierType, string identifierValue, string identifierScope)
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeleteCustomEntityWithHttpInfo(entityType, identifierType, identifierValue, identifierScope);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteCustomEntity: Delete a Custom Entity instance. Delete a Custom Entity instance by a specific entity type.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to remove.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> DeleteCustomEntityWithHttpInfo(string entityType, string identifierType, string identifierValue, string identifierScope)
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->DeleteCustomEntity");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->DeleteCustomEntity");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->DeleteCustomEntity");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->DeleteCustomEntity");

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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeletedEntityResponse>("/api/customentities/{entityType}/{identifierType}/{identifierValue}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteCustomEntity", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteCustomEntity: Delete a Custom Entity instance. Delete a Custom Entity instance by a specific entity type.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to remove.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeleteCustomEntityAsync(string entityType, string identifierType, string identifierValue, string identifierScope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeleteCustomEntityWithHttpInfoAsync(entityType, identifierType, identifierValue, identifierScope, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteCustomEntity: Delete a Custom Entity instance. Delete a Custom Entity instance by a specific entity type.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to remove.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeleteCustomEntityWithHttpInfoAsync(string entityType, string identifierType, string identifierValue, string identifierScope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->DeleteCustomEntity");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->DeleteCustomEntity");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->DeleteCustomEntity");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->DeleteCustomEntity");


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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/customentities/{entityType}/{identifierType}/{identifierValue}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteCustomEntity", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteCustomEntityAccessMetadata: Delete a Custom Entity Access Metadata entry Deletes the Custom Entity Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to delete.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata. (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata. (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeleteCustomEntityAccessMetadata(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = DeleteCustomEntityAccessMetadataWithHttpInfo(entityType, identifierType, identifierValue, metadataKey, identifierScope, effectiveAt, effectiveUntil);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteCustomEntityAccessMetadata: Delete a Custom Entity Access Metadata entry Deletes the Custom Entity Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to delete.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata. (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata. (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> DeleteCustomEntityAccessMetadataWithHttpInfo(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->DeleteCustomEntityAccessMetadata");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->DeleteCustomEntityAccessMetadata");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->DeleteCustomEntityAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling CustomEntitiesApi->DeleteCustomEntityAccessMetadata");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->DeleteCustomEntityAccessMetadata");

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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.PathParameters.Add("metadataKey", Lusid.Sdk.Client.ClientUtils.ParameterToString(metadataKey)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeletedEntityResponse>("/api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteCustomEntityAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteCustomEntityAccessMetadata: Delete a Custom Entity Access Metadata entry Deletes the Custom Entity Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to delete.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata. (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeleteCustomEntityAccessMetadataAsync(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse> localVarResponse = await DeleteCustomEntityAccessMetadataWithHttpInfoAsync(entityType, identifierType, identifierValue, metadataKey, identifierScope, effectiveAt, effectiveUntil, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteCustomEntityAccessMetadata: Delete a Custom Entity Access Metadata entry Deletes the Custom Entity Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to delete.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which to retrieve the Access Metadata. (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<DeletedEntityResponse>> DeleteCustomEntityAccessMetadataWithHttpInfoAsync(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->DeleteCustomEntityAccessMetadata");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->DeleteCustomEntityAccessMetadata");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->DeleteCustomEntityAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling CustomEntitiesApi->DeleteCustomEntityAccessMetadata");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->DeleteCustomEntityAccessMetadata");


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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.PathParameters.Add("metadataKey", Lusid.Sdk.Client.ClientUtils.ParameterToString(metadataKey)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeletedEntityResponse>("/api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteCustomEntityAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetAllCustomEntityAccessMetadata: Get all the Access Metadata rules for a Custom Entity Get all the Custom Entity access metadata for the specified identifier scope, code and value
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <returns>Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public Dictionary<string, List<AccessMetadataValue>> GetAllCustomEntityAccessMetadata(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> localVarResponse = GetAllCustomEntityAccessMetadataWithHttpInfo(entityType, identifierType, identifierValue, identifierScope, effectiveAt, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetAllCustomEntityAccessMetadata: Get all the Access Metadata rules for a Custom Entity Get all the Custom Entity access metadata for the specified identifier scope, code and value
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> GetAllCustomEntityAccessMetadataWithHttpInfo(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->GetAllCustomEntityAccessMetadata");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->GetAllCustomEntityAccessMetadata");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->GetAllCustomEntityAccessMetadata");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->GetAllCustomEntityAccessMetadata");

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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request
            var localVarResponse = this.Client.Get<Dictionary<string, List<AccessMetadataValue>>>("/api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllCustomEntityAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetAllCustomEntityAccessMetadata: Get all the Access Metadata rules for a Custom Entity Get all the Custom Entity access metadata for the specified identifier scope, code and value
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, List<AccessMetadataValue>>> GetAllCustomEntityAccessMetadataAsync(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> localVarResponse = await GetAllCustomEntityAccessMetadataWithHttpInfoAsync(entityType, identifierType, identifierValue, identifierScope, effectiveAt, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetAllCustomEntityAccessMetadata: Get all the Access Metadata rules for a Custom Entity Get all the Custom Entity access metadata for the specified identifier scope, code and value
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>>> GetAllCustomEntityAccessMetadataWithHttpInfoAsync(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->GetAllCustomEntityAccessMetadata");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->GetAllCustomEntityAccessMetadata");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->GetAllCustomEntityAccessMetadata");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->GetAllCustomEntityAccessMetadata");


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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Dictionary<string, List<AccessMetadataValue>>>("/api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllCustomEntityAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntity: Get a Custom Entity instance. Retrieve a Custom Entity instance by a specific entity type at a point in AsAt time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to retrieve. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the Custom Entity instance. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the Custom Entity instance. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entity in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>CustomEntityResponse</returns>
        public CustomEntityResponse GetCustomEntity(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<CustomEntityResponse> localVarResponse = GetCustomEntityWithHttpInfo(entityType, identifierType, identifierValue, identifierScope, asAt, effectiveAt, relatedEntityPropertyKeys, relationshipDefinitionIds);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntity: Get a Custom Entity instance. Retrieve a Custom Entity instance by a specific entity type at a point in AsAt time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to retrieve. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the Custom Entity instance. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the Custom Entity instance. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entity in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>ApiResponse of CustomEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<CustomEntityResponse> GetCustomEntityWithHttpInfo(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->GetCustomEntity");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->GetCustomEntity");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->GetCustomEntity");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->GetCustomEntity");

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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (relatedEntityPropertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "relatedEntityPropertyKeys", relatedEntityPropertyKeys));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request
            var localVarResponse = this.Client.Get<CustomEntityResponse>("/api/customentities/{entityType}/{identifierType}/{identifierValue}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCustomEntity", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntity: Get a Custom Entity instance. Retrieve a Custom Entity instance by a specific entity type at a point in AsAt time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to retrieve. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the Custom Entity instance. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the Custom Entity instance. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entity in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CustomEntityResponse</returns>
        public async System.Threading.Tasks.Task<CustomEntityResponse> GetCustomEntityAsync(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<CustomEntityResponse> localVarResponse = await GetCustomEntityWithHttpInfoAsync(entityType, identifierType, identifierValue, identifierScope, asAt, effectiveAt, relatedEntityPropertyKeys, relationshipDefinitionIds, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntity: Get a Custom Entity instance. Retrieve a Custom Entity instance by a specific entity type at a point in AsAt time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to retrieve. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the Custom Entity instance. (optional)</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the Custom Entity instance. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entity in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CustomEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<CustomEntityResponse>> GetCustomEntityWithHttpInfoAsync(string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->GetCustomEntity");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->GetCustomEntity");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->GetCustomEntity");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->GetCustomEntity");


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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (relatedEntityPropertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "relatedEntityPropertyKeys", relatedEntityPropertyKeys));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<CustomEntityResponse>("/api/customentities/{entityType}/{identifierType}/{identifierValue}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCustomEntity", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Custom Entity Get Custom Entity access metadata for the specified metadata key
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <returns>ICollection&lt;AccessMetadataValue&gt;</returns>
        public ICollection<AccessMetadataValue> GetCustomEntityAccessMetadataByKey(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>> localVarResponse = GetCustomEntityAccessMetadataByKeyWithHttpInfo(entityType, identifierType, identifierValue, metadataKey, identifierScope, effectiveAt, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Custom Entity Get Custom Entity access metadata for the specified metadata key
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;AccessMetadataValue&gt;</returns>
        public Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>> GetCustomEntityAccessMetadataByKeyWithHttpInfo(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->GetCustomEntityAccessMetadataByKey");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->GetCustomEntityAccessMetadataByKey");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->GetCustomEntityAccessMetadataByKey");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling CustomEntitiesApi->GetCustomEntityAccessMetadataByKey");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->GetCustomEntityAccessMetadataByKey");

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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.PathParameters.Add("metadataKey", Lusid.Sdk.Client.ClientUtils.ParameterToString(metadataKey)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ICollection<AccessMetadataValue>>("/api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCustomEntityAccessMetadataByKey", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Custom Entity Get Custom Entity access metadata for the specified metadata key
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;AccessMetadataValue&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<AccessMetadataValue>> GetCustomEntityAccessMetadataByKeyAsync(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>> localVarResponse = await GetCustomEntityAccessMetadataByKeyWithHttpInfoAsync(entityType, identifierType, identifierValue, metadataKey, identifierScope, effectiveAt, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Custom Entity Get Custom Entity access metadata for the specified metadata key
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;AccessMetadataValue&gt;)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>>> GetCustomEntityAccessMetadataByKeyWithHttpInfoAsync(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->GetCustomEntityAccessMetadataByKey");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->GetCustomEntityAccessMetadataByKey");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->GetCustomEntityAccessMetadataByKey");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling CustomEntitiesApi->GetCustomEntityAccessMetadataByKey");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->GetCustomEntityAccessMetadataByKey");


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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.PathParameters.Add("metadataKey", Lusid.Sdk.Client.ClientUtils.ParameterToString(metadataKey)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ICollection<AccessMetadataValue>>("/api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCustomEntityAccessMetadataByKey", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityRelationships: Get Relationships for Custom Entity Get relationships for the specified Custom Entity.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of entity get relationships for.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relationships. If not applicable, provide an empty array. (optional)</param>
        /// <returns>ResourceListOfRelationship</returns>
        public ResourceListOfRelationship GetCustomEntityRelationships(string entityType, string identifierScope, string identifierType, string identifierValue, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfRelationship> localVarResponse = GetCustomEntityRelationshipsWithHttpInfo(entityType, identifierScope, identifierType, identifierValue, effectiveAt, asAt, filter, identifierTypes);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityRelationships: Get Relationships for Custom Entity Get relationships for the specified Custom Entity.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of entity get relationships for.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relationships. If not applicable, provide an empty array. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfRelationship</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfRelationship> GetCustomEntityRelationshipsWithHttpInfo(string entityType, string identifierScope, string identifierType, string identifierValue, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->GetCustomEntityRelationships");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->GetCustomEntityRelationships");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->GetCustomEntityRelationships");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->GetCustomEntityRelationships");

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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfRelationship>("/api/customentities/{entityType}/{identifierType}/{identifierValue}/relationships", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCustomEntityRelationships", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityRelationships: Get Relationships for Custom Entity Get relationships for the specified Custom Entity.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of entity get relationships for.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relationships. If not applicable, provide an empty array. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfRelationship</returns>
        public async System.Threading.Tasks.Task<ResourceListOfRelationship> GetCustomEntityRelationshipsAsync(string entityType, string identifierScope, string identifierType, string identifierValue, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfRelationship> localVarResponse = await GetCustomEntityRelationshipsWithHttpInfoAsync(entityType, identifierScope, identifierType, identifierValue, effectiveAt, asAt, filter, identifierTypes, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCustomEntityRelationships: Get Relationships for Custom Entity Get relationships for the specified Custom Entity.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of entity get relationships for.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional)</param>
        /// <param name="filter">Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional)</param>
        /// <param name="identifierTypes">Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relationships. If not applicable, provide an empty array. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfRelationship)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfRelationship>> GetCustomEntityRelationshipsWithHttpInfoAsync(string entityType, string identifierScope, string identifierType, string identifierValue, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), string filter = default(string), List<string> identifierTypes = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->GetCustomEntityRelationships");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->GetCustomEntityRelationships");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->GetCustomEntityRelationships");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->GetCustomEntityRelationships");


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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfRelationship>("/api/customentities/{entityType}/{identifierType}/{identifierValue}/relationships", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCustomEntityRelationships", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListCustomEntities: List Custom Entities of the specified entityType. List all the Custom Entities matching particular criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the entities. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the entities. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing entities; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entities in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>PagedResourceListOfCustomEntityResponse</returns>
        public PagedResourceListOfCustomEntityResponse ListCustomEntities(string entityType, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), int? limit = default(int?), string filter = default(string), string page = default(string), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<PagedResourceListOfCustomEntityResponse> localVarResponse = ListCustomEntitiesWithHttpInfo(entityType, effectiveAt, asAt, limit, filter, page, relatedEntityPropertyKeys, relationshipDefinitionIds);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListCustomEntities: List Custom Entities of the specified entityType. List all the Custom Entities matching particular criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the entities. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the entities. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing entities; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entities in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <returns>ApiResponse of PagedResourceListOfCustomEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<PagedResourceListOfCustomEntityResponse> ListCustomEntitiesWithHttpInfo(string entityType, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), int? limit = default(int?), string filter = default(string), string page = default(string), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->ListCustomEntities");

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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (relatedEntityPropertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "relatedEntityPropertyKeys", relatedEntityPropertyKeys));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request
            var localVarResponse = this.Client.Get<PagedResourceListOfCustomEntityResponse>("/api/customentities/{entityType}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListCustomEntities", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListCustomEntities: List Custom Entities of the specified entityType. List all the Custom Entities matching particular criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the entities. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the entities. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing entities; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entities in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PagedResourceListOfCustomEntityResponse</returns>
        public async System.Threading.Tasks.Task<PagedResourceListOfCustomEntityResponse> ListCustomEntitiesAsync(string entityType, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), int? limit = default(int?), string filter = default(string), string page = default(string), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PagedResourceListOfCustomEntityResponse> localVarResponse = await ListCustomEntitiesWithHttpInfoAsync(entityType, effectiveAt, asAt, limit, filter, page, relatedEntityPropertyKeys, relationshipDefinitionIds, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListCustomEntities: List Custom Entities of the specified entityType. List all the Custom Entities matching particular criteria.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of Custom Entity to list.</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which to list the entities. Defaults to the current LUSID              system datetime if not specified. (optional)</param>
        /// <param name="asAt">The asAt datetime at which to list the entities. Defaults to returning the latest version              of each portfolio if not specified. (optional)</param>
        /// <param name="limit">When paginating, limit the results to this number. Defaults to 100 if not specified. (optional)</param>
        /// <param name="filter">Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)</param>
        /// <param name="page">The pagination token to use to continue listing entities; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional)</param>
        /// <param name="relatedEntityPropertyKeys">A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. (optional)</param>
        /// <param name="relationshipDefinitionIds">A list of relationship definitions that are used to decorate related entities              onto the entities in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PagedResourceListOfCustomEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PagedResourceListOfCustomEntityResponse>> ListCustomEntitiesWithHttpInfoAsync(string entityType, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), int? limit = default(int?), string filter = default(string), string page = default(string), List<string> relatedEntityPropertyKeys = default(List<string>), List<string> relationshipDefinitionIds = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->ListCustomEntities");


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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (relatedEntityPropertyKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "relatedEntityPropertyKeys", relatedEntityPropertyKeys));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PagedResourceListOfCustomEntityResponse>("/api/customentities/{entityType}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListCustomEntities", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] PatchCustomEntityAccessMetadata: Patch Access Metadata rules for a Custom Entity. Patch Custom Entity Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document    Currently only valid metadata keys are supported paths on the patch document                The response will return any affected Custom Entity Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public Dictionary<string, List<AccessMetadataValue>> PatchCustomEntityAccessMetadata(string entityType, string identifierType, string identifierValue, string identifierScope, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> localVarResponse = PatchCustomEntityAccessMetadataWithHttpInfo(entityType, identifierType, identifierValue, identifierScope, accessMetadataOperation, effectiveAt, effectiveUntil);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] PatchCustomEntityAccessMetadata: Patch Access Metadata rules for a Custom Entity. Patch Custom Entity Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document    Currently only valid metadata keys are supported paths on the patch document                The response will return any affected Custom Entity Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> PatchCustomEntityAccessMetadataWithHttpInfo(string entityType, string identifierType, string identifierValue, string identifierScope, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->PatchCustomEntityAccessMetadata");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->PatchCustomEntityAccessMetadata");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->PatchCustomEntityAccessMetadata");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->PatchCustomEntityAccessMetadata");

            // verify the required parameter 'accessMetadataOperation' is set
            if (accessMetadataOperation == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'accessMetadataOperation' when calling CustomEntitiesApi->PatchCustomEntityAccessMetadata");

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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request
            var localVarResponse = this.Client.Patch<Dictionary<string, List<AccessMetadataValue>>>("/api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchCustomEntityAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] PatchCustomEntityAccessMetadata: Patch Access Metadata rules for a Custom Entity. Patch Custom Entity Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document    Currently only valid metadata keys are supported paths on the patch document                The response will return any affected Custom Entity Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, List<AccessMetadataValue>>> PatchCustomEntityAccessMetadataAsync(string entityType, string identifierType, string identifierValue, string identifierScope, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>> localVarResponse = await PatchCustomEntityAccessMetadataWithHttpInfoAsync(entityType, identifierType, identifierValue, identifierScope, accessMetadataOperation, effectiveAt, effectiveUntil, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] PatchCustomEntityAccessMetadata: Patch Access Metadata rules for a Custom Entity. Patch Custom Entity Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only &#39;add&#39; is a supported operation on the patch document    Currently only valid metadata keys are supported paths on the patch document                The response will return any affected Custom Entity Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="accessMetadataOperation">The Json Patch document</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Dictionary<string, List<AccessMetadataValue>>>> PatchCustomEntityAccessMetadataWithHttpInfoAsync(string entityType, string identifierType, string identifierValue, string identifierScope, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->PatchCustomEntityAccessMetadata");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->PatchCustomEntityAccessMetadata");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->PatchCustomEntityAccessMetadata");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->PatchCustomEntityAccessMetadata");

            // verify the required parameter 'accessMetadataOperation' is set
            if (accessMetadataOperation == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'accessMetadataOperation' when calling CustomEntitiesApi->PatchCustomEntityAccessMetadata");


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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PatchAsync<Dictionary<string, List<AccessMetadataValue>>>("/api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchCustomEntityAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntities: Batch upsert instances of Custom Entities Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The payload describing the Custom Entity instances</param>
        /// <returns>UpsertCustomEntitiesResponse</returns>
        public UpsertCustomEntitiesResponse UpsertCustomEntities(string entityType, string successMode, Dictionary<string, CustomEntityRequest> requestBody)
        {
            Lusid.Sdk.Client.ApiResponse<UpsertCustomEntitiesResponse> localVarResponse = UpsertCustomEntitiesWithHttpInfo(entityType, successMode, requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntities: Batch upsert instances of Custom Entities Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The payload describing the Custom Entity instances</param>
        /// <returns>ApiResponse of UpsertCustomEntitiesResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<UpsertCustomEntitiesResponse> UpsertCustomEntitiesWithHttpInfo(string entityType, string successMode, Dictionary<string, CustomEntityRequest> requestBody)
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->UpsertCustomEntities");

            // verify the required parameter 'successMode' is set
            if (successMode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'successMode' when calling CustomEntitiesApi->UpsertCustomEntities");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling CustomEntitiesApi->UpsertCustomEntities");

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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request
            var localVarResponse = this.Client.Post<UpsertCustomEntitiesResponse>("/api/customentities/{entityType}/$batchUpsert", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertCustomEntities", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntities: Batch upsert instances of Custom Entities Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The payload describing the Custom Entity instances</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpsertCustomEntitiesResponse</returns>
        public async System.Threading.Tasks.Task<UpsertCustomEntitiesResponse> UpsertCustomEntitiesAsync(string entityType, string successMode, Dictionary<string, CustomEntityRequest> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<UpsertCustomEntitiesResponse> localVarResponse = await UpsertCustomEntitiesWithHttpInfoAsync(entityType, successMode, requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntities: Batch upsert instances of Custom Entities Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="successMode">Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial</param>
        /// <param name="requestBody">The payload describing the Custom Entity instances</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpsertCustomEntitiesResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<UpsertCustomEntitiesResponse>> UpsertCustomEntitiesWithHttpInfoAsync(string entityType, string successMode, Dictionary<string, CustomEntityRequest> requestBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->UpsertCustomEntities");

            // verify the required parameter 'successMode' is set
            if (successMode == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'successMode' when calling CustomEntitiesApi->UpsertCustomEntities");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'requestBody' when calling CustomEntitiesApi->UpsertCustomEntities");


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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<UpsertCustomEntitiesResponse>("/api/customentities/{entityType}/$batchUpsert", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertCustomEntities", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntity: Upsert a Custom Entity instance Insert the Custom Entity if it does not exist or update the Custom Entity with the supplied state if it does exist.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="customEntityRequest">The payload describing the Custom Entity instance.</param>
        /// <returns>CustomEntityResponse</returns>
        public CustomEntityResponse UpsertCustomEntity(string entityType, CustomEntityRequest customEntityRequest)
        {
            Lusid.Sdk.Client.ApiResponse<CustomEntityResponse> localVarResponse = UpsertCustomEntityWithHttpInfo(entityType, customEntityRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntity: Upsert a Custom Entity instance Insert the Custom Entity if it does not exist or update the Custom Entity with the supplied state if it does exist.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="customEntityRequest">The payload describing the Custom Entity instance.</param>
        /// <returns>ApiResponse of CustomEntityResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<CustomEntityResponse> UpsertCustomEntityWithHttpInfo(string entityType, CustomEntityRequest customEntityRequest)
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->UpsertCustomEntity");

            // verify the required parameter 'customEntityRequest' is set
            if (customEntityRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'customEntityRequest' when calling CustomEntitiesApi->UpsertCustomEntity");

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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.Data = customEntityRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request
            var localVarResponse = this.Client.Post<CustomEntityResponse>("/api/customentities/{entityType}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertCustomEntity", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntity: Upsert a Custom Entity instance Insert the Custom Entity if it does not exist or update the Custom Entity with the supplied state if it does exist.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="customEntityRequest">The payload describing the Custom Entity instance.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CustomEntityResponse</returns>
        public async System.Threading.Tasks.Task<CustomEntityResponse> UpsertCustomEntityAsync(string entityType, CustomEntityRequest customEntityRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<CustomEntityResponse> localVarResponse = await UpsertCustomEntityWithHttpInfoAsync(entityType, customEntityRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntity: Upsert a Custom Entity instance Insert the Custom Entity if it does not exist or update the Custom Entity with the supplied state if it does exist.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions.</param>
        /// <param name="customEntityRequest">The payload describing the Custom Entity instance.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CustomEntityResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<CustomEntityResponse>> UpsertCustomEntityWithHttpInfoAsync(string entityType, CustomEntityRequest customEntityRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->UpsertCustomEntity");

            // verify the required parameter 'customEntityRequest' is set
            if (customEntityRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'customEntityRequest' when calling CustomEntitiesApi->UpsertCustomEntity");


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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.Data = customEntityRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<CustomEntityResponse>("/api/customentities/{entityType}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertCustomEntity", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntityAccessMetadata: Upsert a Custom Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID. Update or insert one Custom Entity Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Custom Entity Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="upsertCustomEntityAccessMetadataRequest">The Custom Entity Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>ICollection&lt;AccessMetadataValue&gt;</returns>
        public ICollection<AccessMetadataValue> UpsertCustomEntityAccessMetadata(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, UpsertCustomEntityAccessMetadataRequest upsertCustomEntityAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>> localVarResponse = UpsertCustomEntityAccessMetadataWithHttpInfo(entityType, identifierType, identifierValue, metadataKey, identifierScope, upsertCustomEntityAccessMetadataRequest, effectiveAt, effectiveUntil);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntityAccessMetadata: Upsert a Custom Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID. Update or insert one Custom Entity Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Custom Entity Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="upsertCustomEntityAccessMetadataRequest">The Custom Entity Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;AccessMetadataValue&gt;</returns>
        public Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>> UpsertCustomEntityAccessMetadataWithHttpInfo(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, UpsertCustomEntityAccessMetadataRequest upsertCustomEntityAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->UpsertCustomEntityAccessMetadata");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->UpsertCustomEntityAccessMetadata");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->UpsertCustomEntityAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling CustomEntitiesApi->UpsertCustomEntityAccessMetadata");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->UpsertCustomEntityAccessMetadata");

            // verify the required parameter 'upsertCustomEntityAccessMetadataRequest' is set
            if (upsertCustomEntityAccessMetadataRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'upsertCustomEntityAccessMetadataRequest' when calling CustomEntitiesApi->UpsertCustomEntityAccessMetadata");

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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.PathParameters.Add("metadataKey", Lusid.Sdk.Client.ClientUtils.ParameterToString(metadataKey)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (effectiveUntil != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveUntil", effectiveUntil));
            }
            localVarRequestOptions.Data = upsertCustomEntityAccessMetadataRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request
            var localVarResponse = this.Client.Put<ICollection<AccessMetadataValue>>("/api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertCustomEntityAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntityAccessMetadata: Upsert a Custom Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID. Update or insert one Custom Entity Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Custom Entity Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="upsertCustomEntityAccessMetadataRequest">The Custom Entity Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;AccessMetadataValue&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<AccessMetadataValue>> UpsertCustomEntityAccessMetadataAsync(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, UpsertCustomEntityAccessMetadataRequest upsertCustomEntityAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>> localVarResponse = await UpsertCustomEntityAccessMetadataWithHttpInfoAsync(entityType, identifierType, identifierValue, metadataKey, identifierScope, upsertCustomEntityAccessMetadataRequest, effectiveAt, effectiveUntil, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpsertCustomEntityAccessMetadata: Upsert a Custom Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID. Update or insert one Custom Entity Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Custom Entity Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">The type of the Custom Entity.</param>
        /// <param name="identifierType">An identifier type attached to the Custom Entity instance.</param>
        /// <param name="identifierValue">The identifier value.</param>
        /// <param name="metadataKey">Key of the metadata entry to retrieve</param>
        /// <param name="identifierScope">The identifier scope.</param>
        /// <param name="upsertCustomEntityAccessMetadataRequest">The Custom Entity Access Metadata entry to upsert</param>
        /// <param name="effectiveAt">The effectiveAt datetime at which the Access Metadata will be effective from (optional)</param>
        /// <param name="effectiveUntil">The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;AccessMetadataValue&gt;)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ICollection<AccessMetadataValue>>> UpsertCustomEntityAccessMetadataWithHttpInfoAsync(string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, UpsertCustomEntityAccessMetadataRequest upsertCustomEntityAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? effectiveUntil = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'entityType' when calling CustomEntitiesApi->UpsertCustomEntityAccessMetadata");

            // verify the required parameter 'identifierType' is set
            if (identifierType == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierType' when calling CustomEntitiesApi->UpsertCustomEntityAccessMetadata");

            // verify the required parameter 'identifierValue' is set
            if (identifierValue == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierValue' when calling CustomEntitiesApi->UpsertCustomEntityAccessMetadata");

            // verify the required parameter 'metadataKey' is set
            if (metadataKey == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'metadataKey' when calling CustomEntitiesApi->UpsertCustomEntityAccessMetadata");

            // verify the required parameter 'identifierScope' is set
            if (identifierScope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'identifierScope' when calling CustomEntitiesApi->UpsertCustomEntityAccessMetadata");

            // verify the required parameter 'upsertCustomEntityAccessMetadataRequest' is set
            if (upsertCustomEntityAccessMetadataRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'upsertCustomEntityAccessMetadataRequest' when calling CustomEntitiesApi->UpsertCustomEntityAccessMetadata");


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

            localVarRequestOptions.PathParameters.Add("entityType", Lusid.Sdk.Client.ClientUtils.ParameterToString(entityType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierType", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierType)); // path parameter
            localVarRequestOptions.PathParameters.Add("identifierValue", Lusid.Sdk.Client.ClientUtils.ParameterToString(identifierValue)); // path parameter
            localVarRequestOptions.PathParameters.Add("metadataKey", Lusid.Sdk.Client.ClientUtils.ParameterToString(metadataKey)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "identifierScope", identifierScope));
            if (effectiveAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveAt", effectiveAt));
            }
            if (effectiveUntil != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "effectiveUntil", effectiveUntil));
            }
            localVarRequestOptions.Data = upsertCustomEntityAccessMetadataRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.0.206");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<ICollection<AccessMetadataValue>>("/api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata/{metadataKey}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpsertCustomEntityAccessMetadata", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}