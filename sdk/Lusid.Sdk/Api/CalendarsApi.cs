/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-10\">-10</a>|Server Configuration Error|  | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"102\">102</a>|Version Not Found|  | | <a name=\"103\">103</a>|Api Rate Limit Violation|  | | <a name=\"104\">104</a>|Instrument Not Found|  | | <a name=\"105\">105</a>|Property Not Found|  | | <a name=\"106\">106</a>|Portfolio Recursion Depth|  | | <a name=\"108\">108</a>|Group Not Found|  | | <a name=\"109\">109</a>|Portfolio Not Found|  | | <a name=\"110\">110</a>|Property Schema Not Found|  | | <a name=\"111\">111</a>|Portfolio Ancestry Not Found|  | | <a name=\"112\">112</a>|Portfolio With Id Already Exists|  | | <a name=\"113\">113</a>|Orphaned Portfolio|  | | <a name=\"119\">119</a>|Missing Base Claims|  | | <a name=\"121\">121</a>|Property Not Defined|  | | <a name=\"122\">122</a>|Cannot Delete System Property|  | | <a name=\"123\">123</a>|Cannot Modify Immutable Property Field|  | | <a name=\"124\">124</a>|Property Already Exists|  | | <a name=\"125\">125</a>|Invalid Property Life Time|  | | <a name=\"126\">126</a>|Property Constraint Style Excludes Properties|  | | <a name=\"127\">127</a>|Cannot Modify Default Data Type|  | | <a name=\"128\">128</a>|Group Already Exists|  | | <a name=\"129\">129</a>|No Such Data Type|  | | <a name=\"130\">130</a>|Undefined Value For Data Type|  | | <a name=\"131\">131</a>|Unsupported Value Type Defined On Data Type|  | | <a name=\"132\">132</a>|Validation Error|  | | <a name=\"133\">133</a>|Loop Detected In Group Hierarchy|  | | <a name=\"134\">134</a>|Undefined Acceptable Values|  | | <a name=\"135\">135</a>|Sub Group Already Exists|  | | <a name=\"138\">138</a>|Price Source Not Found|  | | <a name=\"139\">139</a>|Analytic Store Not Found|  | | <a name=\"141\">141</a>|Analytic Store Already Exists|  | | <a name=\"143\">143</a>|Client Instrument Already Exists|  | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"147\">147</a>|Results Not Found|  | | <a name=\"148\">148</a>|Order Field Not In Result Set|  | | <a name=\"149\">149</a>|Operation Failed|  | | <a name=\"150\">150</a>|Elastic Search Error|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"153\">153</a>|Command Processing Failure|  | | <a name=\"154\">154</a>|Entity State Construction Failure|  | | <a name=\"155\">155</a>|Entity Timeline Does Not Exist|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"158\">158</a>|Event Publish Unknown|  | | <a name=\"159\">159</a>|Event Query Failure|  | | <a name=\"160\">160</a>|Blob Did Not Exist|  | | <a name=\"162\">162</a>|Sub System Request Failure|  | | <a name=\"163\">163</a>|Sub System Configuration Failure|  | | <a name=\"165\">165</a>|Failed To Delete|  | | <a name=\"166\">166</a>|Upsert Client Instrument Failure|  | | <a name=\"167\">167</a>|Illegal As At Interval|  | | <a name=\"168\">168</a>|Illegal Bitemporal Query|  | | <a name=\"169\">169</a>|Invalid Alternate Id|  | | <a name=\"170\">170</a>|Cannot Add Source Portfolio Property Explicitly|  | | <a name=\"171\">171</a>|Entity Already Exists In Group|  | | <a name=\"173\">173</a>|Entity With Id Already Exists|  | | <a name=\"174\">174</a>|Derived Portfolio Details Do Not Exist|  | | <a name=\"175\">175</a>|Entity Not In Group|  | | <a name=\"176\">176</a>|Portfolio With Name Already Exists|  | | <a name=\"177\">177</a>|Invalid Transactions|  | | <a name=\"178\">178</a>|Reference Portfolio Not Found|  | | <a name=\"179\">179</a>|Duplicate Id|  | | <a name=\"180\">180</a>|Command Retrieval Failure|  | | <a name=\"181\">181</a>|Data Filter Application Failure|  | | <a name=\"182\">182</a>|Search Failed|  | | <a name=\"183\">183</a>|Movements Engine Configuration Key Failure|  | | <a name=\"184\">184</a>|Fx Rate Source Not Found|  | | <a name=\"185\">185</a>|Accrual Source Not Found|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"188\">188</a>|Invalid Request Headers|  | | <a name=\"189\">189</a>|Price Not Found|  | | <a name=\"190\">190</a>|Invalid Sub Holding Keys Provided|  | | <a name=\"191\">191</a>|Duplicate Sub Holding Keys Provided|  | | <a name=\"192\">192</a>|Cut Definition Not Found|  | | <a name=\"193\">193</a>|Cut Definition Invalid|  | | <a name=\"194\">194</a>|Time Variant Property Deletion Date Unspecified|  | | <a name=\"195\">195</a>|Perpetual Property Deletion Date Specified|  | | <a name=\"196\">196</a>|Time Variant Property Upsert Date Unspecified|  | | <a name=\"197\">197</a>|Perpetual Property Upsert Date Specified|  | | <a name=\"200\">200</a>|Invalid Unit For Data Type|  | | <a name=\"201\">201</a>|Invalid Type For Data Type|  | | <a name=\"202\">202</a>|Invalid Value For Data Type|  | | <a name=\"203\">203</a>|Unit Not Defined For Data Type|  | | <a name=\"204\">204</a>|Units Not Supported On Data Type|  | | <a name=\"205\">205</a>|Cannot Specify Units On Data Type|  | | <a name=\"206\">206</a>|Unit Schema Inconsistent With Data Type|  | | <a name=\"207\">207</a>|Unit Definition Not Specified|  | | <a name=\"208\">208</a>|Duplicate Unit Definitions Specified|  | | <a name=\"209\">209</a>|Invalid Units Definition|  | | <a name=\"210\">210</a>|Invalid Instrument Identifier Unit|  | | <a name=\"211\">211</a>|Holdings Adjustment Does Not Exist|  | | <a name=\"212\">212</a>|Could Not Build Excel Url|  | | <a name=\"213\">213</a>|Could Not Get Excel Version|  | | <a name=\"214\">214</a>|Instrument By Code Not Found|  | | <a name=\"215\">215</a>|Entity Schema Does Not Exist|  | | <a name=\"216\">216</a>|Feature Not Supported On Portfolio Type|  | | <a name=\"217\">217</a>|Quote Not Found|  | | <a name=\"218\">218</a>|Invalid Quote Identifier|  | | <a name=\"219\">219</a>|Invalid Metric For Data Type|  | | <a name=\"220\">220</a>|Invalid Instrument Definition|  | | <a name=\"221\">221</a>|Instrument Upsert Failure|  | | <a name=\"222\">222</a>|Reference Portfolio Request Not Supported|  | | <a name=\"223\">223</a>|Transaction Portfolio Request Not Supported|  | | <a name=\"224\">224</a>|Invalid Property Value Assignment|  | | <a name=\"230\">230</a>|Transaction Type Not Found|  | | <a name=\"231\">231</a>|Transaction Type Duplication|  | | <a name=\"232\">232</a>|Portfolio Does Not Exist At Given Date|  | | <a name=\"233\">233</a>|Query Parser Failure|  | | <a name=\"234\">234</a>|Duplicate Constituent|  | | <a name=\"235\">235</a>|Unresolved Instrument Constituent|  | | <a name=\"236\">236</a>|Unresolved Instrument In Transition|  | | <a name=\"237\">237</a>|Missing Side Definitions|  | | <a name=\"299\">299</a>|Invalid Recipe|  | | <a name=\"300\">300</a>|Missing Recipe|  | | <a name=\"301\">301</a>|Dependencies|  | | <a name=\"304\">304</a>|Portfolio Preprocess Failure|  | | <a name=\"310\">310</a>|Valuation Engine Failure|  | | <a name=\"311\">311</a>|Task Factory Failure|  | | <a name=\"312\">312</a>|Task Evaluation Failure|  | | <a name=\"313\">313</a>|Task Generation Failure|  | | <a name=\"314\">314</a>|Engine Configuration Failure|  | | <a name=\"315\">315</a>|Model Specification Failure|  | | <a name=\"320\">320</a>|Market Data Key Failure|  | | <a name=\"321\">321</a>|Market Resolver Failure|  | | <a name=\"322\">322</a>|Market Data Failure|  | | <a name=\"330\">330</a>|Curve Failure|  | | <a name=\"331\">331</a>|Volatility Surface Failure|  | | <a name=\"332\">332</a>|Volatility Cube Failure|  | | <a name=\"350\">350</a>|Instrument Failure|  | | <a name=\"351\">351</a>|Cash Flows Failure|  | | <a name=\"352\">352</a>|Reference Data Failure|  | | <a name=\"360\">360</a>|Aggregation Failure|  | | <a name=\"361\">361</a>|Aggregation Measure Failure|  | | <a name=\"370\">370</a>|Result Retrieval Failure|  | | <a name=\"371\">371</a>|Result Processing Failure|  | | <a name=\"372\">372</a>|Vendor Result Processing Failure|  | | <a name=\"373\">373</a>|Vendor Result Mapping Failure|  | | <a name=\"374\">374</a>|Vendor Library Unauthorised|  | | <a name=\"375\">375</a>|Vendor Connectivity Error|  | | <a name=\"376\">376</a>|Vendor Interface Error|  | | <a name=\"377\">377</a>|Vendor Pricing Failure|  | | <a name=\"378\">378</a>|Vendor Translation Failure|  | | <a name=\"379\">379</a>|Vendor Key Mapping Failure|  | | <a name=\"380\">380</a>|Vendor Reflection Failure|  | | <a name=\"381\">381</a>|Vendor Process Failure|  | | <a name=\"382\">382</a>|Vendor System Failure|  | | <a name=\"390\">390</a>|Attempt To Upsert Duplicate Quotes|  | | <a name=\"391\">391</a>|Corporate Action Source Does Not Exist|  | | <a name=\"392\">392</a>|Corporate Action Source Already Exists|  | | <a name=\"393\">393</a>|Instrument Identifier Already In Use|  | | <a name=\"394\">394</a>|Properties Not Found|  | | <a name=\"395\">395</a>|Batch Operation Aborted|  | | <a name=\"400\">400</a>|Invalid Iso4217 Currency Code|  | | <a name=\"401\">401</a>|Cannot Assign Instrument Identifier To Currency|  | | <a name=\"402\">402</a>|Cannot Assign Currency Identifier To Non Currency|  | | <a name=\"403\">403</a>|Currency Instrument Cannot Be Deleted|  | | <a name=\"404\">404</a>|Currency Instrument Cannot Have Economic Definition|  | | <a name=\"405\">405</a>|Currency Instrument Cannot Have Lookthrough Portfolio|  | | <a name=\"406\">406</a>|Cannot Create Currency Instrument With Multiple Identifiers|  | | <a name=\"407\">407</a>|Specified Currency Is Undefined|  | | <a name=\"410\">410</a>|Index Does Not Exist|  | | <a name=\"411\">411</a>|Sort Field Does Not Exist|  | | <a name=\"413\">413</a>|Negative Pagination Parameters|  | | <a name=\"414\">414</a>|Invalid Search Syntax|  | | <a name=\"415\">415</a>|Filter Execution Timeout|  | | <a name=\"420\">420</a>|Side Definition Inconsistent|  | | <a name=\"450\">450</a>|Invalid Quote Access Metadata Rule|  | | <a name=\"451\">451</a>|Access Metadata Not Found|  | | <a name=\"452\">452</a>|Invalid Access Metadata Identifier|  | | <a name=\"460\">460</a>|Standard Resource Not Found|  | | <a name=\"461\">461</a>|Standard Resource Conflict|  | | <a name=\"462\">462</a>|Calendar Not Found|  | | <a name=\"463\">463</a>|Date In A Calendar Not Found|  | | <a name=\"464\">464</a>|Invalid Date Source Data|  | | <a name=\"465\">465</a>|Invalid Timezone|  | | <a name=\"601\">601</a>|Person Identifier Already In Use|  | | <a name=\"602\">602</a>|Person Not Found|  | | <a name=\"603\">603</a>|Cannot Set Identifier|  | | <a name=\"617\">617</a>|Invalid Recipe Specification In Request|  | | <a name=\"618\">618</a>|Inline Recipe Deserialisation Failure|  | | <a name=\"619\">619</a>|Identifier Types Not Set For Entity|  | | <a name=\"620\">620</a>|Cannot Delete All Client Defined Identifiers|  | | <a name=\"650\">650</a>|The Order requested was not found.|  | | <a name=\"654\">654</a>|The Allocation requested was not found.|  | | <a name=\"655\">655</a>|Cannot build the fx forward target with the given holdings.|  | | <a name=\"656\">656</a>|Group does not contain expected entities.|  | | <a name=\"665\">665</a>|Destination directory not found|  | | <a name=\"667\">667</a>|Relation definition already exists|  | | <a name=\"672\">672</a>|Could not retrieve file contents|  | | <a name=\"673\">673</a>|Missing entitlements for entities in Group|  | | <a name=\"674\">674</a>|Next Best Action not found|  | | <a name=\"676\">676</a>|Relation definition not defined|  | | <a name=\"677\">677</a>|Invalid entity identifier for relation|  | | <a name=\"681\">681</a>|Sorting by specified field not supported|One or more of the provided fields to order by were either invalid or not supported. | | <a name=\"682\">682</a>|Too many fields to sort by|The number of fields to sort the data by exceeds the number allowed by the endpoint | | <a name=\"684\">684</a>|Sequence Not Found|  | | <a name=\"685\">685</a>|Sequence Already Exists|  | | <a name=\"686\">686</a>|Non-cycling sequence has been exhausted|  | | <a name=\"687\">687</a>|Legal Entity Identifier Already In Use|  | | <a name=\"688\">688</a>|Legal Entity Not Found|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"690\">690</a>|Property Type Is Not Supported|  | | <a name=\"691\">691</a>|Multiple Tax-lots For Currency Type Is Not Supported|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"693\">693</a>|Entity type is not supported for Relationship|  | | <a name=\"694\">694</a>|Relationship Validation Failure|  | | <a name=\"695\">695</a>|Relationship Not Found|  | | <a name=\"697\">697</a>|Derived Property Formula No Longer Valid|  | | <a name=\"698\">698</a>|Story is not available|  | | <a name=\"703\">703</a>|Corporate Action Does Not Exist|  | | <a name=\"720\">720</a>|The provided sort and filter combination is not valid|  | | <a name=\"721\">721</a>|A2B generation failed|  | | <a name=\"722\">722</a>|Aggregated Return Calculation Failure|  | | <a name=\"723\">723</a>|Custom Entity Definition Identifier Already In Use|  | | <a name=\"724\">724</a>|Custom Entity Definition Not Found|  | | <a name=\"725\">725</a>|The Placement requested was not found.|  | | <a name=\"726\">726</a>|The Execution requested was not found.|  | | <a name=\"727\">727</a>|The Block requested was not found.|  | | <a name=\"728\">728</a>|The Participation requested was not found.|  | | <a name=\"729\">729</a>|The Package requested was not found.|  | | <a name=\"730\">730</a>|The OrderInstruction requested was not found.|  | | <a name=\"732\">732</a>|Custom Entity not found.|  | | <a name=\"733\">733</a>|Custom Entity Identifier already in use.|  | | <a name=\"735\">735</a>|Calculation Failed.|  | | <a name=\"736\">736</a>|An expected key on HttpResponse is missing.|  | | <a name=\"737\">737</a>|A required fee detail is missing.|  | | <a name=\"738\">738</a>|Zero rows were returned from Luminesce|  | | <a name=\"739\">739</a>|Provided Weekend Mask was invalid|  | | <a name=\"742\">742</a>|Custom Entity fields do not match the definition|  | | <a name=\"746\">746</a>|The provided sequence is not valid.|  | | <a name=\"751\">751</a>|The type of the Custom Entity is different than the type provided in the definition.|  | | <a name=\"752\">752</a>|Luminesce process returned an error.|  | | <a name=\"753\">753</a>|File name or content incompatible with operation.|  | | <a name=\"755\">755</a>|Schema of response from Drive is not as expected.|  | | <a name=\"757\">757</a>|Schema of response from Luminesce is not as expected.|  | | <a name=\"758\">758</a>|Luminesce timed out.|  | | <a name=\"763\">763</a>|Invalid Lusid Entity Identifier Unit|  | | <a name=\"768\">768</a>|Fee rule not found.|  | | <a name=\"769\">769</a>|Cannot update the base currency of a portfolio with transactions loaded|  | | <a name=\"771\">771</a>|Transaction configuration source not found|  | | <a name=\"774\">774</a>|Compliance rule not found.|  | | <a name=\"775\">775</a>|Fund accounting document cannot be processed.|  | | <a name=\"778\">778</a>|Unable to look up FX rate from trade ccy to portfolio ccy for some of the trades.|  | | <a name=\"782\">782</a>|The Property definition dataType is not matching the derivation formula dataType|  | | <a name=\"783\">783</a>|The Property definition domain is not supported for derived properties|  | | <a name=\"788\">788</a>|Compliance run not found failure.|  | | <a name=\"790\">790</a>|Custom Entity has missing or invalid identifiers|  | | <a name=\"791\">791</a>|Custom Entity definition already exists|  | | <a name=\"792\">792</a>|Compliance PropertyKey is missing.|  | | <a name=\"793\">793</a>|Compliance Criteria Value for matching is missing.|  | | <a name=\"795\">795</a>|Cannot delete identifier definition|  | | <a name=\"796\">796</a>|Tax rule set not found.|  | | <a name=\"797\">797</a>|A tax rule set with this id already exists.|  | | <a name=\"798\">798</a>|Multiple rule sets for the same property key are applicable.|  | | <a name=\"800\">800</a>|Can not upsert an instrument event of this type.|  | | <a name=\"801\">801</a>|The instrument event does not exist.|  | | <a name=\"802\">802</a>|The Instrument event is missing salient information.|  | | <a name=\"803\">803</a>|The Instrument event could not be processed.|  | | <a name=\"804\">804</a>|Some data requested does not follow the order graph assumptions.|  | | <a name=\"811\">811</a>|A price could not be found for an order.|  | | <a name=\"812\">812</a>|A price could not be found for an allocation.|  | | <a name=\"813\">813</a>|Chart of Accounts not found.|  | | <a name=\"814\">814</a>|Account not found.|  | 
 *
 * The version of the OpenAPI document: 0.11.5010
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
    public interface ICalendarsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EARLY ACCESS] AddBusinessDaysToDate: Adds the requested number of Business Days to the provided date.
        /// </summary>
        /// <remarks>
        /// A Business day is defined as a point in time that:      * Does not represent a day in the calendar&#39;s weekend      * Does not represent a day in the calendar&#39;s list of holidays (e.g. Christmas Day in the UK)                 All dates specified must be UTC and the upper bound of a calendar is not inclusive                 e.g. From: 2020-12-24-00-00-00:       Adding 3 business days returns 2020-12-30, assuming Saturday and Sunday are weekends, and the 25th and 28th are holidays.       Adding -2 business days returns 2020-12-22 under the same assumptions.                If the provided number of days to add is zero, returns a failure.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope within which to search for the calendars</param>
        /// <param name="addBusinessDaysToDateRequest">Request Details: start date, number of days to add (which can be negative, but not zero), calendar codes and optionally an AsAt date for searching the calendar store</param>
        /// <returns>AddBusinessDaysToDateResponse</returns>
        AddBusinessDaysToDateResponse AddBusinessDaysToDate(string scope, AddBusinessDaysToDateRequest addBusinessDaysToDateRequest);

        /// <summary>
        /// [EARLY ACCESS] AddBusinessDaysToDate: Adds the requested number of Business Days to the provided date.
        /// </summary>
        /// <remarks>
        /// A Business day is defined as a point in time that:      * Does not represent a day in the calendar&#39;s weekend      * Does not represent a day in the calendar&#39;s list of holidays (e.g. Christmas Day in the UK)                 All dates specified must be UTC and the upper bound of a calendar is not inclusive                 e.g. From: 2020-12-24-00-00-00:       Adding 3 business days returns 2020-12-30, assuming Saturday and Sunday are weekends, and the 25th and 28th are holidays.       Adding -2 business days returns 2020-12-22 under the same assumptions.                If the provided number of days to add is zero, returns a failure.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope within which to search for the calendars</param>
        /// <param name="addBusinessDaysToDateRequest">Request Details: start date, number of days to add (which can be negative, but not zero), calendar codes and optionally an AsAt date for searching the calendar store</param>
        /// <returns>ApiResponse of AddBusinessDaysToDateResponse</returns>
        ApiResponse<AddBusinessDaysToDateResponse> AddBusinessDaysToDateWithHttpInfo(string scope, AddBusinessDaysToDateRequest addBusinessDaysToDateRequest);
        /// <summary>
        /// [EARLY ACCESS] AddDateToCalendar: Add a date to a calendar
        /// </summary>
        /// <remarks>
        /// Add an event to the calendar. These Events can be a maximum of 24 hours and must be specified in UTC.  A local date will be calculated by the system and applied to the calendar before processing.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="createDateRequest">Add date to calendar request</param>
        /// <returns>CalendarDate</returns>
        CalendarDate AddDateToCalendar(string scope, string code, CreateDateRequest createDateRequest);

        /// <summary>
        /// [EARLY ACCESS] AddDateToCalendar: Add a date to a calendar
        /// </summary>
        /// <remarks>
        /// Add an event to the calendar. These Events can be a maximum of 24 hours and must be specified in UTC.  A local date will be calculated by the system and applied to the calendar before processing.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="createDateRequest">Add date to calendar request</param>
        /// <returns>ApiResponse of CalendarDate</returns>
        ApiResponse<CalendarDate> AddDateToCalendarWithHttpInfo(string scope, string code, CreateDateRequest createDateRequest);
        /// <summary>
        /// [EARLY ACCESS] CreateCalendar: Create a calendar in its generic form
        /// </summary>
        /// <remarks>
        /// Create a calendar in a generic form which can be used to store date events.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCalendarRequest">A request to create the calendar</param>
        /// <returns>Calendar</returns>
        Calendar CreateCalendar(CreateCalendarRequest createCalendarRequest);

        /// <summary>
        /// [EARLY ACCESS] CreateCalendar: Create a calendar in its generic form
        /// </summary>
        /// <remarks>
        /// Create a calendar in a generic form which can be used to store date events.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCalendarRequest">A request to create the calendar</param>
        /// <returns>ApiResponse of Calendar</returns>
        ApiResponse<Calendar> CreateCalendarWithHttpInfo(CreateCalendarRequest createCalendarRequest);
        /// <summary>
        /// [EARLY ACCESS] DeleteCalendar: Delete a calendar
        /// </summary>
        /// <remarks>
        /// Delete a calendar and all of its respective dates
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <returns>Calendar</returns>
        Calendar DeleteCalendar(string scope, string code);

        /// <summary>
        /// [EARLY ACCESS] DeleteCalendar: Delete a calendar
        /// </summary>
        /// <remarks>
        /// Delete a calendar and all of its respective dates
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <returns>ApiResponse of Calendar</returns>
        ApiResponse<Calendar> DeleteCalendarWithHttpInfo(string scope, string code);
        /// <summary>
        /// [EARLY ACCESS] DeleteDateFromCalendar: Remove a date from a calendar
        /// </summary>
        /// <remarks>
        /// Remove a date from a calendar.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="dateId">Identifier of the date to be removed</param>
        /// <returns>CalendarDate</returns>
        CalendarDate DeleteDateFromCalendar(string scope, string code, string dateId);

        /// <summary>
        /// [EARLY ACCESS] DeleteDateFromCalendar: Remove a date from a calendar
        /// </summary>
        /// <remarks>
        /// Remove a date from a calendar.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="dateId">Identifier of the date to be removed</param>
        /// <returns>ApiResponse of CalendarDate</returns>
        ApiResponse<CalendarDate> DeleteDateFromCalendarWithHttpInfo(string scope, string code, string dateId);
        /// <summary>
        /// [EARLY ACCESS] GenerateSchedule: Generate an ordered schedule of dates.
        /// </summary>
        /// <remarks>
        /// Returns an ordered array of dates. The dates will only fall on business  days as defined by the scope and calendar codes in the valuation schedule.                Valuations are made at a frequency defined by the valuation schedule&#39;s tenor, e.g. every day (\&quot;1D\&quot;),  every other week (\&quot;2W\&quot;) etc. These dates will be adjusted onto business days as defined by the schedule&#39;s  rollConvention.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars to use</param>
        /// <param name="valuationSchedule">The ValuationSchedule to generate schedule dates from</param>
        /// <param name="asAt">Optional AsAt for searching the calendar store. Defaults to Latest. (optional)</param>
        /// <returns>ICollection&lt;DateTimeOffset&gt;</returns>
        ICollection<DateTimeOffset> GenerateSchedule(string scope, ValuationSchedule valuationSchedule, DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] GenerateSchedule: Generate an ordered schedule of dates.
        /// </summary>
        /// <remarks>
        /// Returns an ordered array of dates. The dates will only fall on business  days as defined by the scope and calendar codes in the valuation schedule.                Valuations are made at a frequency defined by the valuation schedule&#39;s tenor, e.g. every day (\&quot;1D\&quot;),  every other week (\&quot;2W\&quot;) etc. These dates will be adjusted onto business days as defined by the schedule&#39;s  rollConvention.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars to use</param>
        /// <param name="valuationSchedule">The ValuationSchedule to generate schedule dates from</param>
        /// <param name="asAt">Optional AsAt for searching the calendar store. Defaults to Latest. (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;DateTimeOffset&gt;</returns>
        ApiResponse<ICollection<DateTimeOffset>> GenerateScheduleWithHttpInfo(string scope, ValuationSchedule valuationSchedule, DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] GetCalendar: Get a calendar in its generic form
        /// </summary>
        /// <remarks>
        /// Retrieve a generic calendar by a specific ID at a point in AsAt time
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar identifier</param>
        /// <param name="code">Code of the calendar identifier</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendar (optional)</param>
        /// <returns>Calendar</returns>
        Calendar GetCalendar(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] GetCalendar: Get a calendar in its generic form
        /// </summary>
        /// <remarks>
        /// Retrieve a generic calendar by a specific ID at a point in AsAt time
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar identifier</param>
        /// <param name="code">Code of the calendar identifier</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendar (optional)</param>
        /// <returns>ApiResponse of Calendar</returns>
        ApiResponse<Calendar> GetCalendarWithHttpInfo(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] GetDates: Get dates for a specific calendar
        /// </summary>
        /// <remarks>
        /// Get dates from a specific calendar within a specific window of effective time, at a point in AsAt time.  Providing an id filter can further refine the results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="fromEffectiveAt">Where the effective window of dates should begin from (optional)</param>
        /// <param name="toEffectiveAt">Where the effective window of dates should end (optional)</param>
        /// <param name="asAt">AsAt the dates should be retrieved at (optional)</param>
        /// <param name="idFilter">An additional filter that will filter dates based on their identifer (optional)</param>
        /// <returns>ResourceListOfCalendarDate</returns>
        ResourceListOfCalendarDate GetDates(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> idFilter = default(List<string>));

        /// <summary>
        /// [EARLY ACCESS] GetDates: Get dates for a specific calendar
        /// </summary>
        /// <remarks>
        /// Get dates from a specific calendar within a specific window of effective time, at a point in AsAt time.  Providing an id filter can further refine the results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="fromEffectiveAt">Where the effective window of dates should begin from (optional)</param>
        /// <param name="toEffectiveAt">Where the effective window of dates should end (optional)</param>
        /// <param name="asAt">AsAt the dates should be retrieved at (optional)</param>
        /// <param name="idFilter">An additional filter that will filter dates based on their identifer (optional)</param>
        /// <returns>ApiResponse of ResourceListOfCalendarDate</returns>
        ApiResponse<ResourceListOfCalendarDate> GetDatesWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> idFilter = default(List<string>));
        /// <summary>
        /// [EARLY ACCESS] IsBusinessDateTime: Check whether a DateTime is a \&quot;Business DateTime\&quot;
        /// </summary>
        /// <remarks>
        /// A Business DateTime is defined as a point in time that:      * Does not represent a day that overlaps with the calendars WeekendMask      * If the calendar is a \&quot;Holiday Calendar\&quot; Does not overlap with any dates in the calendar      * If the calendar is a \&quot;TradingHours Calendar\&quot; Does overlap with a date in the calendar                All dates specified must be UTC and the upper bound of a calendar is not inclusive   e.g. From: 2020-12-25-00-00-00        To: 2020-12-26-00-00-00  IsBusinessDay(2020-12-26-00-00-00) &#x3D;&#x3D; false
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateTime">DateTime to check - This DateTime must be UTC</param>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="asAt">AsAt for the request (optional)</param>
        /// <returns>IsBusinessDayResponse</returns>
        IsBusinessDayResponse IsBusinessDateTime(DateTimeOffset dateTime, string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EARLY ACCESS] IsBusinessDateTime: Check whether a DateTime is a \&quot;Business DateTime\&quot;
        /// </summary>
        /// <remarks>
        /// A Business DateTime is defined as a point in time that:      * Does not represent a day that overlaps with the calendars WeekendMask      * If the calendar is a \&quot;Holiday Calendar\&quot; Does not overlap with any dates in the calendar      * If the calendar is a \&quot;TradingHours Calendar\&quot; Does overlap with a date in the calendar                All dates specified must be UTC and the upper bound of a calendar is not inclusive   e.g. From: 2020-12-25-00-00-00        To: 2020-12-26-00-00-00  IsBusinessDay(2020-12-26-00-00-00) &#x3D;&#x3D; false
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateTime">DateTime to check - This DateTime must be UTC</param>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="asAt">AsAt for the request (optional)</param>
        /// <returns>ApiResponse of IsBusinessDayResponse</returns>
        ApiResponse<IsBusinessDayResponse> IsBusinessDateTimeWithHttpInfo(DateTimeOffset dateTime, string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?));
        /// <summary>
        /// [EARLY ACCESS] ListCalendars: List Calendars
        /// </summary>
        /// <remarks>
        /// List calendars at a point in AsAt time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>PagedResourceListOfCalendar</returns>
        PagedResourceListOfCalendar ListCalendars(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string));

        /// <summary>
        /// [EARLY ACCESS] ListCalendars: List Calendars
        /// </summary>
        /// <remarks>
        /// List calendars at a point in AsAt time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of PagedResourceListOfCalendar</returns>
        ApiResponse<PagedResourceListOfCalendar> ListCalendarsWithHttpInfo(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string));
        /// <summary>
        /// [EARLY ACCESS] ListCalendarsInScope: List all calenders in a specified scope
        /// </summary>
        /// <remarks>
        /// List calendars at a point in AsAt time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>PagedResourceListOfCalendar</returns>
        PagedResourceListOfCalendar ListCalendarsInScope(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string));

        /// <summary>
        /// [EARLY ACCESS] ListCalendarsInScope: List all calenders in a specified scope
        /// </summary>
        /// <remarks>
        /// List calendars at a point in AsAt time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of PagedResourceListOfCalendar</returns>
        ApiResponse<PagedResourceListOfCalendar> ListCalendarsInScopeWithHttpInfo(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string));
        /// <summary>
        /// [EARLY ACCESS] UpdateCalendar: Update a calendar
        /// </summary>
        /// <remarks>
        /// Update the calendars WeekendMask, SourceProvider or Properties
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the request</param>
        /// <param name="code">Code of the request</param>
        /// <param name="updateCalendarRequest">The new state of the calendar</param>
        /// <returns>Calendar</returns>
        Calendar UpdateCalendar(string scope, string code, UpdateCalendarRequest updateCalendarRequest);

        /// <summary>
        /// [EARLY ACCESS] UpdateCalendar: Update a calendar
        /// </summary>
        /// <remarks>
        /// Update the calendars WeekendMask, SourceProvider or Properties
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the request</param>
        /// <param name="code">Code of the request</param>
        /// <param name="updateCalendarRequest">The new state of the calendar</param>
        /// <returns>ApiResponse of Calendar</returns>
        ApiResponse<Calendar> UpdateCalendarWithHttpInfo(string scope, string code, UpdateCalendarRequest updateCalendarRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICalendarsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] AddBusinessDaysToDate: Adds the requested number of Business Days to the provided date.
        /// </summary>
        /// <remarks>
        /// A Business day is defined as a point in time that:      * Does not represent a day in the calendar&#39;s weekend      * Does not represent a day in the calendar&#39;s list of holidays (e.g. Christmas Day in the UK)                 All dates specified must be UTC and the upper bound of a calendar is not inclusive                 e.g. From: 2020-12-24-00-00-00:       Adding 3 business days returns 2020-12-30, assuming Saturday and Sunday are weekends, and the 25th and 28th are holidays.       Adding -2 business days returns 2020-12-22 under the same assumptions.                If the provided number of days to add is zero, returns a failure.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope within which to search for the calendars</param>
        /// <param name="addBusinessDaysToDateRequest">Request Details: start date, number of days to add (which can be negative, but not zero), calendar codes and optionally an AsAt date for searching the calendar store</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddBusinessDaysToDateResponse</returns>
        System.Threading.Tasks.Task<AddBusinessDaysToDateResponse> AddBusinessDaysToDateAsync(string scope, AddBusinessDaysToDateRequest addBusinessDaysToDateRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] AddBusinessDaysToDate: Adds the requested number of Business Days to the provided date.
        /// </summary>
        /// <remarks>
        /// A Business day is defined as a point in time that:      * Does not represent a day in the calendar&#39;s weekend      * Does not represent a day in the calendar&#39;s list of holidays (e.g. Christmas Day in the UK)                 All dates specified must be UTC and the upper bound of a calendar is not inclusive                 e.g. From: 2020-12-24-00-00-00:       Adding 3 business days returns 2020-12-30, assuming Saturday and Sunday are weekends, and the 25th and 28th are holidays.       Adding -2 business days returns 2020-12-22 under the same assumptions.                If the provided number of days to add is zero, returns a failure.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope within which to search for the calendars</param>
        /// <param name="addBusinessDaysToDateRequest">Request Details: start date, number of days to add (which can be negative, but not zero), calendar codes and optionally an AsAt date for searching the calendar store</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddBusinessDaysToDateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddBusinessDaysToDateResponse>> AddBusinessDaysToDateWithHttpInfoAsync(string scope, AddBusinessDaysToDateRequest addBusinessDaysToDateRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] AddDateToCalendar: Add a date to a calendar
        /// </summary>
        /// <remarks>
        /// Add an event to the calendar. These Events can be a maximum of 24 hours and must be specified in UTC.  A local date will be calculated by the system and applied to the calendar before processing.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="createDateRequest">Add date to calendar request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CalendarDate</returns>
        System.Threading.Tasks.Task<CalendarDate> AddDateToCalendarAsync(string scope, string code, CreateDateRequest createDateRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] AddDateToCalendar: Add a date to a calendar
        /// </summary>
        /// <remarks>
        /// Add an event to the calendar. These Events can be a maximum of 24 hours and must be specified in UTC.  A local date will be calculated by the system and applied to the calendar before processing.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="createDateRequest">Add date to calendar request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CalendarDate)</returns>
        System.Threading.Tasks.Task<ApiResponse<CalendarDate>> AddDateToCalendarWithHttpInfoAsync(string scope, string code, CreateDateRequest createDateRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] CreateCalendar: Create a calendar in its generic form
        /// </summary>
        /// <remarks>
        /// Create a calendar in a generic form which can be used to store date events.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCalendarRequest">A request to create the calendar</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Calendar</returns>
        System.Threading.Tasks.Task<Calendar> CreateCalendarAsync(CreateCalendarRequest createCalendarRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] CreateCalendar: Create a calendar in its generic form
        /// </summary>
        /// <remarks>
        /// Create a calendar in a generic form which can be used to store date events.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCalendarRequest">A request to create the calendar</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Calendar)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calendar>> CreateCalendarWithHttpInfoAsync(CreateCalendarRequest createCalendarRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] DeleteCalendar: Delete a calendar
        /// </summary>
        /// <remarks>
        /// Delete a calendar and all of its respective dates
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Calendar</returns>
        System.Threading.Tasks.Task<Calendar> DeleteCalendarAsync(string scope, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeleteCalendar: Delete a calendar
        /// </summary>
        /// <remarks>
        /// Delete a calendar and all of its respective dates
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Calendar)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calendar>> DeleteCalendarWithHttpInfoAsync(string scope, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] DeleteDateFromCalendar: Remove a date from a calendar
        /// </summary>
        /// <remarks>
        /// Remove a date from a calendar.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="dateId">Identifier of the date to be removed</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CalendarDate</returns>
        System.Threading.Tasks.Task<CalendarDate> DeleteDateFromCalendarAsync(string scope, string code, string dateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeleteDateFromCalendar: Remove a date from a calendar
        /// </summary>
        /// <remarks>
        /// Remove a date from a calendar.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="dateId">Identifier of the date to be removed</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CalendarDate)</returns>
        System.Threading.Tasks.Task<ApiResponse<CalendarDate>> DeleteDateFromCalendarWithHttpInfoAsync(string scope, string code, string dateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GenerateSchedule: Generate an ordered schedule of dates.
        /// </summary>
        /// <remarks>
        /// Returns an ordered array of dates. The dates will only fall on business  days as defined by the scope and calendar codes in the valuation schedule.                Valuations are made at a frequency defined by the valuation schedule&#39;s tenor, e.g. every day (\&quot;1D\&quot;),  every other week (\&quot;2W\&quot;) etc. These dates will be adjusted onto business days as defined by the schedule&#39;s  rollConvention.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars to use</param>
        /// <param name="valuationSchedule">The ValuationSchedule to generate schedule dates from</param>
        /// <param name="asAt">Optional AsAt for searching the calendar store. Defaults to Latest. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;DateTimeOffset&gt;</returns>
        System.Threading.Tasks.Task<ICollection<DateTimeOffset>> GenerateScheduleAsync(string scope, ValuationSchedule valuationSchedule, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GenerateSchedule: Generate an ordered schedule of dates.
        /// </summary>
        /// <remarks>
        /// Returns an ordered array of dates. The dates will only fall on business  days as defined by the scope and calendar codes in the valuation schedule.                Valuations are made at a frequency defined by the valuation schedule&#39;s tenor, e.g. every day (\&quot;1D\&quot;),  every other week (\&quot;2W\&quot;) etc. These dates will be adjusted onto business days as defined by the schedule&#39;s  rollConvention.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars to use</param>
        /// <param name="valuationSchedule">The ValuationSchedule to generate schedule dates from</param>
        /// <param name="asAt">Optional AsAt for searching the calendar store. Defaults to Latest. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;DateTimeOffset&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<DateTimeOffset>>> GenerateScheduleWithHttpInfoAsync(string scope, ValuationSchedule valuationSchedule, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetCalendar: Get a calendar in its generic form
        /// </summary>
        /// <remarks>
        /// Retrieve a generic calendar by a specific ID at a point in AsAt time
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar identifier</param>
        /// <param name="code">Code of the calendar identifier</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendar (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Calendar</returns>
        System.Threading.Tasks.Task<Calendar> GetCalendarAsync(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetCalendar: Get a calendar in its generic form
        /// </summary>
        /// <remarks>
        /// Retrieve a generic calendar by a specific ID at a point in AsAt time
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar identifier</param>
        /// <param name="code">Code of the calendar identifier</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendar (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Calendar)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calendar>> GetCalendarWithHttpInfoAsync(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetDates: Get dates for a specific calendar
        /// </summary>
        /// <remarks>
        /// Get dates from a specific calendar within a specific window of effective time, at a point in AsAt time.  Providing an id filter can further refine the results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="fromEffectiveAt">Where the effective window of dates should begin from (optional)</param>
        /// <param name="toEffectiveAt">Where the effective window of dates should end (optional)</param>
        /// <param name="asAt">AsAt the dates should be retrieved at (optional)</param>
        /// <param name="idFilter">An additional filter that will filter dates based on their identifer (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfCalendarDate</returns>
        System.Threading.Tasks.Task<ResourceListOfCalendarDate> GetDatesAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> idFilter = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetDates: Get dates for a specific calendar
        /// </summary>
        /// <remarks>
        /// Get dates from a specific calendar within a specific window of effective time, at a point in AsAt time.  Providing an id filter can further refine the results.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="fromEffectiveAt">Where the effective window of dates should begin from (optional)</param>
        /// <param name="toEffectiveAt">Where the effective window of dates should end (optional)</param>
        /// <param name="asAt">AsAt the dates should be retrieved at (optional)</param>
        /// <param name="idFilter">An additional filter that will filter dates based on their identifer (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfCalendarDate)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfCalendarDate>> GetDatesWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> idFilter = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] IsBusinessDateTime: Check whether a DateTime is a \&quot;Business DateTime\&quot;
        /// </summary>
        /// <remarks>
        /// A Business DateTime is defined as a point in time that:      * Does not represent a day that overlaps with the calendars WeekendMask      * If the calendar is a \&quot;Holiday Calendar\&quot; Does not overlap with any dates in the calendar      * If the calendar is a \&quot;TradingHours Calendar\&quot; Does overlap with a date in the calendar                All dates specified must be UTC and the upper bound of a calendar is not inclusive   e.g. From: 2020-12-25-00-00-00        To: 2020-12-26-00-00-00  IsBusinessDay(2020-12-26-00-00-00) &#x3D;&#x3D; false
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateTime">DateTime to check - This DateTime must be UTC</param>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="asAt">AsAt for the request (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IsBusinessDayResponse</returns>
        System.Threading.Tasks.Task<IsBusinessDayResponse> IsBusinessDateTimeAsync(DateTimeOffset dateTime, string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] IsBusinessDateTime: Check whether a DateTime is a \&quot;Business DateTime\&quot;
        /// </summary>
        /// <remarks>
        /// A Business DateTime is defined as a point in time that:      * Does not represent a day that overlaps with the calendars WeekendMask      * If the calendar is a \&quot;Holiday Calendar\&quot; Does not overlap with any dates in the calendar      * If the calendar is a \&quot;TradingHours Calendar\&quot; Does overlap with a date in the calendar                All dates specified must be UTC and the upper bound of a calendar is not inclusive   e.g. From: 2020-12-25-00-00-00        To: 2020-12-26-00-00-00  IsBusinessDay(2020-12-26-00-00-00) &#x3D;&#x3D; false
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateTime">DateTime to check - This DateTime must be UTC</param>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="asAt">AsAt for the request (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IsBusinessDayResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IsBusinessDayResponse>> IsBusinessDateTimeWithHttpInfoAsync(DateTimeOffset dateTime, string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] ListCalendars: List Calendars
        /// </summary>
        /// <remarks>
        /// List calendars at a point in AsAt time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PagedResourceListOfCalendar</returns>
        System.Threading.Tasks.Task<PagedResourceListOfCalendar> ListCalendarsAsync(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] ListCalendars: List Calendars
        /// </summary>
        /// <remarks>
        /// List calendars at a point in AsAt time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PagedResourceListOfCalendar)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagedResourceListOfCalendar>> ListCalendarsWithHttpInfoAsync(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] ListCalendarsInScope: List all calenders in a specified scope
        /// </summary>
        /// <remarks>
        /// List calendars at a point in AsAt time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PagedResourceListOfCalendar</returns>
        System.Threading.Tasks.Task<PagedResourceListOfCalendar> ListCalendarsInScopeAsync(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] ListCalendarsInScope: List all calenders in a specified scope
        /// </summary>
        /// <remarks>
        /// List calendars at a point in AsAt time.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PagedResourceListOfCalendar)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagedResourceListOfCalendar>> ListCalendarsInScopeWithHttpInfoAsync(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] UpdateCalendar: Update a calendar
        /// </summary>
        /// <remarks>
        /// Update the calendars WeekendMask, SourceProvider or Properties
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the request</param>
        /// <param name="code">Code of the request</param>
        /// <param name="updateCalendarRequest">The new state of the calendar</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Calendar</returns>
        System.Threading.Tasks.Task<Calendar> UpdateCalendarAsync(string scope, string code, UpdateCalendarRequest updateCalendarRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] UpdateCalendar: Update a calendar
        /// </summary>
        /// <remarks>
        /// Update the calendars WeekendMask, SourceProvider or Properties
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the request</param>
        /// <param name="code">Code of the request</param>
        /// <param name="updateCalendarRequest">The new state of the calendar</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Calendar)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calendar>> UpdateCalendarWithHttpInfoAsync(string scope, string code, UpdateCalendarRequest updateCalendarRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICalendarsApi : ICalendarsApiSync, ICalendarsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CalendarsApi : ICalendarsApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CalendarsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CalendarsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="CalendarsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CalendarsApi(Lusid.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CalendarsApi(Lusid.Sdk.Client.ISynchronousClient client, Lusid.Sdk.Client.IAsynchronousClient asyncClient, Lusid.Sdk.Client.IReadableConfiguration configuration)
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
        /// [EARLY ACCESS] AddBusinessDaysToDate: Adds the requested number of Business Days to the provided date. A Business day is defined as a point in time that:      * Does not represent a day in the calendar&#39;s weekend      * Does not represent a day in the calendar&#39;s list of holidays (e.g. Christmas Day in the UK)                 All dates specified must be UTC and the upper bound of a calendar is not inclusive                 e.g. From: 2020-12-24-00-00-00:       Adding 3 business days returns 2020-12-30, assuming Saturday and Sunday are weekends, and the 25th and 28th are holidays.       Adding -2 business days returns 2020-12-22 under the same assumptions.                If the provided number of days to add is zero, returns a failure.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope within which to search for the calendars</param>
        /// <param name="addBusinessDaysToDateRequest">Request Details: start date, number of days to add (which can be negative, but not zero), calendar codes and optionally an AsAt date for searching the calendar store</param>
        /// <returns>AddBusinessDaysToDateResponse</returns>
        public AddBusinessDaysToDateResponse AddBusinessDaysToDate(string scope, AddBusinessDaysToDateRequest addBusinessDaysToDateRequest)
        {
            Lusid.Sdk.Client.ApiResponse<AddBusinessDaysToDateResponse> localVarResponse = AddBusinessDaysToDateWithHttpInfo(scope, addBusinessDaysToDateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] AddBusinessDaysToDate: Adds the requested number of Business Days to the provided date. A Business day is defined as a point in time that:      * Does not represent a day in the calendar&#39;s weekend      * Does not represent a day in the calendar&#39;s list of holidays (e.g. Christmas Day in the UK)                 All dates specified must be UTC and the upper bound of a calendar is not inclusive                 e.g. From: 2020-12-24-00-00-00:       Adding 3 business days returns 2020-12-30, assuming Saturday and Sunday are weekends, and the 25th and 28th are holidays.       Adding -2 business days returns 2020-12-22 under the same assumptions.                If the provided number of days to add is zero, returns a failure.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope within which to search for the calendars</param>
        /// <param name="addBusinessDaysToDateRequest">Request Details: start date, number of days to add (which can be negative, but not zero), calendar codes and optionally an AsAt date for searching the calendar store</param>
        /// <returns>ApiResponse of AddBusinessDaysToDateResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<AddBusinessDaysToDateResponse> AddBusinessDaysToDateWithHttpInfo(string scope, AddBusinessDaysToDateRequest addBusinessDaysToDateRequest)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->AddBusinessDaysToDate");

            // verify the required parameter 'addBusinessDaysToDateRequest' is set
            if (addBusinessDaysToDateRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'addBusinessDaysToDateRequest' when calling CalendarsApi->AddBusinessDaysToDate");

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
            localVarRequestOptions.Data = addBusinessDaysToDateRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request
            var localVarResponse = this.Client.Post<AddBusinessDaysToDateResponse>("/api/calendars/businessday/{scope}/add", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddBusinessDaysToDate", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] AddBusinessDaysToDate: Adds the requested number of Business Days to the provided date. A Business day is defined as a point in time that:      * Does not represent a day in the calendar&#39;s weekend      * Does not represent a day in the calendar&#39;s list of holidays (e.g. Christmas Day in the UK)                 All dates specified must be UTC and the upper bound of a calendar is not inclusive                 e.g. From: 2020-12-24-00-00-00:       Adding 3 business days returns 2020-12-30, assuming Saturday and Sunday are weekends, and the 25th and 28th are holidays.       Adding -2 business days returns 2020-12-22 under the same assumptions.                If the provided number of days to add is zero, returns a failure.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope within which to search for the calendars</param>
        /// <param name="addBusinessDaysToDateRequest">Request Details: start date, number of days to add (which can be negative, but not zero), calendar codes and optionally an AsAt date for searching the calendar store</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddBusinessDaysToDateResponse</returns>
        public async System.Threading.Tasks.Task<AddBusinessDaysToDateResponse> AddBusinessDaysToDateAsync(string scope, AddBusinessDaysToDateRequest addBusinessDaysToDateRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<AddBusinessDaysToDateResponse> localVarResponse = await AddBusinessDaysToDateWithHttpInfoAsync(scope, addBusinessDaysToDateRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] AddBusinessDaysToDate: Adds the requested number of Business Days to the provided date. A Business day is defined as a point in time that:      * Does not represent a day in the calendar&#39;s weekend      * Does not represent a day in the calendar&#39;s list of holidays (e.g. Christmas Day in the UK)                 All dates specified must be UTC and the upper bound of a calendar is not inclusive                 e.g. From: 2020-12-24-00-00-00:       Adding 3 business days returns 2020-12-30, assuming Saturday and Sunday are weekends, and the 25th and 28th are holidays.       Adding -2 business days returns 2020-12-22 under the same assumptions.                If the provided number of days to add is zero, returns a failure.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope within which to search for the calendars</param>
        /// <param name="addBusinessDaysToDateRequest">Request Details: start date, number of days to add (which can be negative, but not zero), calendar codes and optionally an AsAt date for searching the calendar store</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddBusinessDaysToDateResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<AddBusinessDaysToDateResponse>> AddBusinessDaysToDateWithHttpInfoAsync(string scope, AddBusinessDaysToDateRequest addBusinessDaysToDateRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->AddBusinessDaysToDate");

            // verify the required parameter 'addBusinessDaysToDateRequest' is set
            if (addBusinessDaysToDateRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'addBusinessDaysToDateRequest' when calling CalendarsApi->AddBusinessDaysToDate");


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
            localVarRequestOptions.Data = addBusinessDaysToDateRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AddBusinessDaysToDateResponse>("/api/calendars/businessday/{scope}/add", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddBusinessDaysToDate", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] AddDateToCalendar: Add a date to a calendar Add an event to the calendar. These Events can be a maximum of 24 hours and must be specified in UTC.  A local date will be calculated by the system and applied to the calendar before processing.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="createDateRequest">Add date to calendar request</param>
        /// <returns>CalendarDate</returns>
        public CalendarDate AddDateToCalendar(string scope, string code, CreateDateRequest createDateRequest)
        {
            Lusid.Sdk.Client.ApiResponse<CalendarDate> localVarResponse = AddDateToCalendarWithHttpInfo(scope, code, createDateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] AddDateToCalendar: Add a date to a calendar Add an event to the calendar. These Events can be a maximum of 24 hours and must be specified in UTC.  A local date will be calculated by the system and applied to the calendar before processing.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="createDateRequest">Add date to calendar request</param>
        /// <returns>ApiResponse of CalendarDate</returns>
        public Lusid.Sdk.Client.ApiResponse<CalendarDate> AddDateToCalendarWithHttpInfo(string scope, string code, CreateDateRequest createDateRequest)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->AddDateToCalendar");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling CalendarsApi->AddDateToCalendar");

            // verify the required parameter 'createDateRequest' is set
            if (createDateRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'createDateRequest' when calling CalendarsApi->AddDateToCalendar");

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
            localVarRequestOptions.Data = createDateRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request
            var localVarResponse = this.Client.Put<CalendarDate>("/api/calendars/generic/{scope}/{code}/dates", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddDateToCalendar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] AddDateToCalendar: Add a date to a calendar Add an event to the calendar. These Events can be a maximum of 24 hours and must be specified in UTC.  A local date will be calculated by the system and applied to the calendar before processing.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="createDateRequest">Add date to calendar request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CalendarDate</returns>
        public async System.Threading.Tasks.Task<CalendarDate> AddDateToCalendarAsync(string scope, string code, CreateDateRequest createDateRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<CalendarDate> localVarResponse = await AddDateToCalendarWithHttpInfoAsync(scope, code, createDateRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] AddDateToCalendar: Add a date to a calendar Add an event to the calendar. These Events can be a maximum of 24 hours and must be specified in UTC.  A local date will be calculated by the system and applied to the calendar before processing.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="createDateRequest">Add date to calendar request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CalendarDate)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<CalendarDate>> AddDateToCalendarWithHttpInfoAsync(string scope, string code, CreateDateRequest createDateRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->AddDateToCalendar");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling CalendarsApi->AddDateToCalendar");

            // verify the required parameter 'createDateRequest' is set
            if (createDateRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'createDateRequest' when calling CalendarsApi->AddDateToCalendar");


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
            localVarRequestOptions.Data = createDateRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<CalendarDate>("/api/calendars/generic/{scope}/{code}/dates", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddDateToCalendar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] CreateCalendar: Create a calendar in its generic form Create a calendar in a generic form which can be used to store date events.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCalendarRequest">A request to create the calendar</param>
        /// <returns>Calendar</returns>
        public Calendar CreateCalendar(CreateCalendarRequest createCalendarRequest)
        {
            Lusid.Sdk.Client.ApiResponse<Calendar> localVarResponse = CreateCalendarWithHttpInfo(createCalendarRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] CreateCalendar: Create a calendar in its generic form Create a calendar in a generic form which can be used to store date events.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCalendarRequest">A request to create the calendar</param>
        /// <returns>ApiResponse of Calendar</returns>
        public Lusid.Sdk.Client.ApiResponse<Calendar> CreateCalendarWithHttpInfo(CreateCalendarRequest createCalendarRequest)
        {
            // verify the required parameter 'createCalendarRequest' is set
            if (createCalendarRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'createCalendarRequest' when calling CalendarsApi->CreateCalendar");

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

            localVarRequestOptions.Data = createCalendarRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request
            var localVarResponse = this.Client.Post<Calendar>("/api/calendars/generic", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateCalendar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] CreateCalendar: Create a calendar in its generic form Create a calendar in a generic form which can be used to store date events.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCalendarRequest">A request to create the calendar</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Calendar</returns>
        public async System.Threading.Tasks.Task<Calendar> CreateCalendarAsync(CreateCalendarRequest createCalendarRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Calendar> localVarResponse = await CreateCalendarWithHttpInfoAsync(createCalendarRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] CreateCalendar: Create a calendar in its generic form Create a calendar in a generic form which can be used to store date events.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCalendarRequest">A request to create the calendar</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Calendar)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Calendar>> CreateCalendarWithHttpInfoAsync(CreateCalendarRequest createCalendarRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'createCalendarRequest' is set
            if (createCalendarRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'createCalendarRequest' when calling CalendarsApi->CreateCalendar");


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

            localVarRequestOptions.Data = createCalendarRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Calendar>("/api/calendars/generic", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateCalendar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteCalendar: Delete a calendar Delete a calendar and all of its respective dates
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <returns>Calendar</returns>
        public Calendar DeleteCalendar(string scope, string code)
        {
            Lusid.Sdk.Client.ApiResponse<Calendar> localVarResponse = DeleteCalendarWithHttpInfo(scope, code);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteCalendar: Delete a calendar Delete a calendar and all of its respective dates
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <returns>ApiResponse of Calendar</returns>
        public Lusid.Sdk.Client.ApiResponse<Calendar> DeleteCalendarWithHttpInfo(string scope, string code)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->DeleteCalendar");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling CalendarsApi->DeleteCalendar");

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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Calendar>("/api/calendars/generic/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteCalendar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteCalendar: Delete a calendar Delete a calendar and all of its respective dates
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Calendar</returns>
        public async System.Threading.Tasks.Task<Calendar> DeleteCalendarAsync(string scope, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Calendar> localVarResponse = await DeleteCalendarWithHttpInfoAsync(scope, code, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteCalendar: Delete a calendar Delete a calendar and all of its respective dates
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Calendar)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Calendar>> DeleteCalendarWithHttpInfoAsync(string scope, string code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->DeleteCalendar");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling CalendarsApi->DeleteCalendar");


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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Calendar>("/api/calendars/generic/{scope}/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteCalendar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteDateFromCalendar: Remove a date from a calendar Remove a date from a calendar.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="dateId">Identifier of the date to be removed</param>
        /// <returns>CalendarDate</returns>
        public CalendarDate DeleteDateFromCalendar(string scope, string code, string dateId)
        {
            Lusid.Sdk.Client.ApiResponse<CalendarDate> localVarResponse = DeleteDateFromCalendarWithHttpInfo(scope, code, dateId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteDateFromCalendar: Remove a date from a calendar Remove a date from a calendar.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="dateId">Identifier of the date to be removed</param>
        /// <returns>ApiResponse of CalendarDate</returns>
        public Lusid.Sdk.Client.ApiResponse<CalendarDate> DeleteDateFromCalendarWithHttpInfo(string scope, string code, string dateId)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->DeleteDateFromCalendar");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling CalendarsApi->DeleteDateFromCalendar");

            // verify the required parameter 'dateId' is set
            if (dateId == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'dateId' when calling CalendarsApi->DeleteDateFromCalendar");

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
            localVarRequestOptions.PathParameters.Add("dateId", Lusid.Sdk.Client.ClientUtils.ParameterToString(dateId)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<CalendarDate>("/api/calendars/generic/{scope}/{code}/dates/{dateId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteDateFromCalendar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteDateFromCalendar: Remove a date from a calendar Remove a date from a calendar.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="dateId">Identifier of the date to be removed</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CalendarDate</returns>
        public async System.Threading.Tasks.Task<CalendarDate> DeleteDateFromCalendarAsync(string scope, string code, string dateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<CalendarDate> localVarResponse = await DeleteDateFromCalendarWithHttpInfoAsync(scope, code, dateId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteDateFromCalendar: Remove a date from a calendar Remove a date from a calendar.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="dateId">Identifier of the date to be removed</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CalendarDate)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<CalendarDate>> DeleteDateFromCalendarWithHttpInfoAsync(string scope, string code, string dateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->DeleteDateFromCalendar");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling CalendarsApi->DeleteDateFromCalendar");

            // verify the required parameter 'dateId' is set
            if (dateId == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'dateId' when calling CalendarsApi->DeleteDateFromCalendar");


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
            localVarRequestOptions.PathParameters.Add("dateId", Lusid.Sdk.Client.ClientUtils.ParameterToString(dateId)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<CalendarDate>("/api/calendars/generic/{scope}/{code}/dates/{dateId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteDateFromCalendar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GenerateSchedule: Generate an ordered schedule of dates. Returns an ordered array of dates. The dates will only fall on business  days as defined by the scope and calendar codes in the valuation schedule.                Valuations are made at a frequency defined by the valuation schedule&#39;s tenor, e.g. every day (\&quot;1D\&quot;),  every other week (\&quot;2W\&quot;) etc. These dates will be adjusted onto business days as defined by the schedule&#39;s  rollConvention.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars to use</param>
        /// <param name="valuationSchedule">The ValuationSchedule to generate schedule dates from</param>
        /// <param name="asAt">Optional AsAt for searching the calendar store. Defaults to Latest. (optional)</param>
        /// <returns>ICollection&lt;DateTimeOffset&gt;</returns>
        public ICollection<DateTimeOffset> GenerateSchedule(string scope, ValuationSchedule valuationSchedule, DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<ICollection<DateTimeOffset>> localVarResponse = GenerateScheduleWithHttpInfo(scope, valuationSchedule, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GenerateSchedule: Generate an ordered schedule of dates. Returns an ordered array of dates. The dates will only fall on business  days as defined by the scope and calendar codes in the valuation schedule.                Valuations are made at a frequency defined by the valuation schedule&#39;s tenor, e.g. every day (\&quot;1D\&quot;),  every other week (\&quot;2W\&quot;) etc. These dates will be adjusted onto business days as defined by the schedule&#39;s  rollConvention.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars to use</param>
        /// <param name="valuationSchedule">The ValuationSchedule to generate schedule dates from</param>
        /// <param name="asAt">Optional AsAt for searching the calendar store. Defaults to Latest. (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;DateTimeOffset&gt;</returns>
        public Lusid.Sdk.Client.ApiResponse<ICollection<DateTimeOffset>> GenerateScheduleWithHttpInfo(string scope, ValuationSchedule valuationSchedule, DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->GenerateSchedule");

            // verify the required parameter 'valuationSchedule' is set
            if (valuationSchedule == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'valuationSchedule' when calling CalendarsApi->GenerateSchedule");

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
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            localVarRequestOptions.Data = valuationSchedule;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request
            var localVarResponse = this.Client.Post<ICollection<DateTimeOffset>>("/api/calendars/schedule/{scope}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GenerateSchedule", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GenerateSchedule: Generate an ordered schedule of dates. Returns an ordered array of dates. The dates will only fall on business  days as defined by the scope and calendar codes in the valuation schedule.                Valuations are made at a frequency defined by the valuation schedule&#39;s tenor, e.g. every day (\&quot;1D\&quot;),  every other week (\&quot;2W\&quot;) etc. These dates will be adjusted onto business days as defined by the schedule&#39;s  rollConvention.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars to use</param>
        /// <param name="valuationSchedule">The ValuationSchedule to generate schedule dates from</param>
        /// <param name="asAt">Optional AsAt for searching the calendar store. Defaults to Latest. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;DateTimeOffset&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<DateTimeOffset>> GenerateScheduleAsync(string scope, ValuationSchedule valuationSchedule, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ICollection<DateTimeOffset>> localVarResponse = await GenerateScheduleWithHttpInfoAsync(scope, valuationSchedule, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GenerateSchedule: Generate an ordered schedule of dates. Returns an ordered array of dates. The dates will only fall on business  days as defined by the scope and calendar codes in the valuation schedule.                Valuations are made at a frequency defined by the valuation schedule&#39;s tenor, e.g. every day (\&quot;1D\&quot;),  every other week (\&quot;2W\&quot;) etc. These dates will be adjusted onto business days as defined by the schedule&#39;s  rollConvention.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars to use</param>
        /// <param name="valuationSchedule">The ValuationSchedule to generate schedule dates from</param>
        /// <param name="asAt">Optional AsAt for searching the calendar store. Defaults to Latest. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;DateTimeOffset&gt;)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ICollection<DateTimeOffset>>> GenerateScheduleWithHttpInfoAsync(string scope, ValuationSchedule valuationSchedule, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->GenerateSchedule");

            // verify the required parameter 'valuationSchedule' is set
            if (valuationSchedule == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'valuationSchedule' when calling CalendarsApi->GenerateSchedule");


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
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            localVarRequestOptions.Data = valuationSchedule;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<ICollection<DateTimeOffset>>("/api/calendars/schedule/{scope}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GenerateSchedule", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCalendar: Get a calendar in its generic form Retrieve a generic calendar by a specific ID at a point in AsAt time
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar identifier</param>
        /// <param name="code">Code of the calendar identifier</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendar (optional)</param>
        /// <returns>Calendar</returns>
        public Calendar GetCalendar(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<Calendar> localVarResponse = GetCalendarWithHttpInfo(scope, code, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCalendar: Get a calendar in its generic form Retrieve a generic calendar by a specific ID at a point in AsAt time
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar identifier</param>
        /// <param name="code">Code of the calendar identifier</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendar (optional)</param>
        /// <returns>ApiResponse of Calendar</returns>
        public Lusid.Sdk.Client.ApiResponse<Calendar> GetCalendarWithHttpInfo(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->GetCalendar");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling CalendarsApi->GetCalendar");

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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request
            var localVarResponse = this.Client.Get<Calendar>("/api/calendars/generic/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCalendar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCalendar: Get a calendar in its generic form Retrieve a generic calendar by a specific ID at a point in AsAt time
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar identifier</param>
        /// <param name="code">Code of the calendar identifier</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendar (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Calendar</returns>
        public async System.Threading.Tasks.Task<Calendar> GetCalendarAsync(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Calendar> localVarResponse = await GetCalendarWithHttpInfoAsync(scope, code, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetCalendar: Get a calendar in its generic form Retrieve a generic calendar by a specific ID at a point in AsAt time
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar identifier</param>
        /// <param name="code">Code of the calendar identifier</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendar (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Calendar)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Calendar>> GetCalendarWithHttpInfoAsync(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->GetCalendar");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling CalendarsApi->GetCalendar");


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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Calendar>("/api/calendars/generic/{scope}/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCalendar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetDates: Get dates for a specific calendar Get dates from a specific calendar within a specific window of effective time, at a point in AsAt time.  Providing an id filter can further refine the results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="fromEffectiveAt">Where the effective window of dates should begin from (optional)</param>
        /// <param name="toEffectiveAt">Where the effective window of dates should end (optional)</param>
        /// <param name="asAt">AsAt the dates should be retrieved at (optional)</param>
        /// <param name="idFilter">An additional filter that will filter dates based on their identifer (optional)</param>
        /// <returns>ResourceListOfCalendarDate</returns>
        public ResourceListOfCalendarDate GetDates(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> idFilter = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfCalendarDate> localVarResponse = GetDatesWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt, idFilter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetDates: Get dates for a specific calendar Get dates from a specific calendar within a specific window of effective time, at a point in AsAt time.  Providing an id filter can further refine the results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="fromEffectiveAt">Where the effective window of dates should begin from (optional)</param>
        /// <param name="toEffectiveAt">Where the effective window of dates should end (optional)</param>
        /// <param name="asAt">AsAt the dates should be retrieved at (optional)</param>
        /// <param name="idFilter">An additional filter that will filter dates based on their identifer (optional)</param>
        /// <returns>ApiResponse of ResourceListOfCalendarDate</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfCalendarDate> GetDatesWithHttpInfo(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> idFilter = default(List<string>))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->GetDates");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling CalendarsApi->GetDates");

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
            if (idFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "idFilter", idFilter));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfCalendarDate>("/api/calendars/generic/{scope}/{code}/dates", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDates", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetDates: Get dates for a specific calendar Get dates from a specific calendar within a specific window of effective time, at a point in AsAt time.  Providing an id filter can further refine the results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="fromEffectiveAt">Where the effective window of dates should begin from (optional)</param>
        /// <param name="toEffectiveAt">Where the effective window of dates should end (optional)</param>
        /// <param name="asAt">AsAt the dates should be retrieved at (optional)</param>
        /// <param name="idFilter">An additional filter that will filter dates based on their identifer (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfCalendarDate</returns>
        public async System.Threading.Tasks.Task<ResourceListOfCalendarDate> GetDatesAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> idFilter = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfCalendarDate> localVarResponse = await GetDatesWithHttpInfoAsync(scope, code, fromEffectiveAt, toEffectiveAt, asAt, idFilter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetDates: Get dates for a specific calendar Get dates from a specific calendar within a specific window of effective time, at a point in AsAt time.  Providing an id filter can further refine the results.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="fromEffectiveAt">Where the effective window of dates should begin from (optional)</param>
        /// <param name="toEffectiveAt">Where the effective window of dates should end (optional)</param>
        /// <param name="asAt">AsAt the dates should be retrieved at (optional)</param>
        /// <param name="idFilter">An additional filter that will filter dates based on their identifer (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfCalendarDate)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfCalendarDate>> GetDatesWithHttpInfoAsync(string scope, string code, DateTimeOrCutLabel fromEffectiveAt = default(DateTimeOrCutLabel), DateTimeOrCutLabel toEffectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?), List<string> idFilter = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->GetDates");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling CalendarsApi->GetDates");


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
            if (idFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "idFilter", idFilter));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfCalendarDate>("/api/calendars/generic/{scope}/{code}/dates", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDates", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] IsBusinessDateTime: Check whether a DateTime is a \&quot;Business DateTime\&quot; A Business DateTime is defined as a point in time that:      * Does not represent a day that overlaps with the calendars WeekendMask      * If the calendar is a \&quot;Holiday Calendar\&quot; Does not overlap with any dates in the calendar      * If the calendar is a \&quot;TradingHours Calendar\&quot; Does overlap with a date in the calendar                All dates specified must be UTC and the upper bound of a calendar is not inclusive   e.g. From: 2020-12-25-00-00-00        To: 2020-12-26-00-00-00  IsBusinessDay(2020-12-26-00-00-00) &#x3D;&#x3D; false
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateTime">DateTime to check - This DateTime must be UTC</param>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="asAt">AsAt for the request (optional)</param>
        /// <returns>IsBusinessDayResponse</returns>
        public IsBusinessDayResponse IsBusinessDateTime(DateTimeOffset dateTime, string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Lusid.Sdk.Client.ApiResponse<IsBusinessDayResponse> localVarResponse = IsBusinessDateTimeWithHttpInfo(dateTime, scope, code, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] IsBusinessDateTime: Check whether a DateTime is a \&quot;Business DateTime\&quot; A Business DateTime is defined as a point in time that:      * Does not represent a day that overlaps with the calendars WeekendMask      * If the calendar is a \&quot;Holiday Calendar\&quot; Does not overlap with any dates in the calendar      * If the calendar is a \&quot;TradingHours Calendar\&quot; Does overlap with a date in the calendar                All dates specified must be UTC and the upper bound of a calendar is not inclusive   e.g. From: 2020-12-25-00-00-00        To: 2020-12-26-00-00-00  IsBusinessDay(2020-12-26-00-00-00) &#x3D;&#x3D; false
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateTime">DateTime to check - This DateTime must be UTC</param>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="asAt">AsAt for the request (optional)</param>
        /// <returns>ApiResponse of IsBusinessDayResponse</returns>
        public Lusid.Sdk.Client.ApiResponse<IsBusinessDayResponse> IsBusinessDateTimeWithHttpInfo(DateTimeOffset dateTime, string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->IsBusinessDateTime");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling CalendarsApi->IsBusinessDateTime");

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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "dateTime", dateTime));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request
            var localVarResponse = this.Client.Get<IsBusinessDayResponse>("/api/calendars/businessday/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsBusinessDateTime", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] IsBusinessDateTime: Check whether a DateTime is a \&quot;Business DateTime\&quot; A Business DateTime is defined as a point in time that:      * Does not represent a day that overlaps with the calendars WeekendMask      * If the calendar is a \&quot;Holiday Calendar\&quot; Does not overlap with any dates in the calendar      * If the calendar is a \&quot;TradingHours Calendar\&quot; Does overlap with a date in the calendar                All dates specified must be UTC and the upper bound of a calendar is not inclusive   e.g. From: 2020-12-25-00-00-00        To: 2020-12-26-00-00-00  IsBusinessDay(2020-12-26-00-00-00) &#x3D;&#x3D; false
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateTime">DateTime to check - This DateTime must be UTC</param>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="asAt">AsAt for the request (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IsBusinessDayResponse</returns>
        public async System.Threading.Tasks.Task<IsBusinessDayResponse> IsBusinessDateTimeAsync(DateTimeOffset dateTime, string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<IsBusinessDayResponse> localVarResponse = await IsBusinessDateTimeWithHttpInfoAsync(dateTime, scope, code, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] IsBusinessDateTime: Check whether a DateTime is a \&quot;Business DateTime\&quot; A Business DateTime is defined as a point in time that:      * Does not represent a day that overlaps with the calendars WeekendMask      * If the calendar is a \&quot;Holiday Calendar\&quot; Does not overlap with any dates in the calendar      * If the calendar is a \&quot;TradingHours Calendar\&quot; Does overlap with a date in the calendar                All dates specified must be UTC and the upper bound of a calendar is not inclusive   e.g. From: 2020-12-25-00-00-00        To: 2020-12-26-00-00-00  IsBusinessDay(2020-12-26-00-00-00) &#x3D;&#x3D; false
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateTime">DateTime to check - This DateTime must be UTC</param>
        /// <param name="scope">Scope of the calendar</param>
        /// <param name="code">Code of the calendar</param>
        /// <param name="asAt">AsAt for the request (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IsBusinessDayResponse)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<IsBusinessDayResponse>> IsBusinessDateTimeWithHttpInfoAsync(DateTimeOffset dateTime, string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->IsBusinessDateTime");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling CalendarsApi->IsBusinessDateTime");


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
            localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "dateTime", dateTime));
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<IsBusinessDayResponse>("/api/calendars/businessday/{scope}/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsBusinessDateTime", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListCalendars: List Calendars List calendars at a point in AsAt time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>PagedResourceListOfCalendar</returns>
        public PagedResourceListOfCalendar ListCalendars(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<PagedResourceListOfCalendar> localVarResponse = ListCalendarsWithHttpInfo(asAt, page, limit, filter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListCalendars: List Calendars List calendars at a point in AsAt time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of PagedResourceListOfCalendar</returns>
        public Lusid.Sdk.Client.ApiResponse<PagedResourceListOfCalendar> ListCalendarsWithHttpInfo(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string))
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request
            var localVarResponse = this.Client.Get<PagedResourceListOfCalendar>("/api/calendars/generic", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListCalendars", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListCalendars: List Calendars List calendars at a point in AsAt time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PagedResourceListOfCalendar</returns>
        public async System.Threading.Tasks.Task<PagedResourceListOfCalendar> ListCalendarsAsync(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PagedResourceListOfCalendar> localVarResponse = await ListCalendarsWithHttpInfoAsync(asAt, page, limit, filter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListCalendars: List Calendars List calendars at a point in AsAt time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PagedResourceListOfCalendar)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PagedResourceListOfCalendar>> ListCalendarsWithHttpInfoAsync(DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? limit = default(int?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PagedResourceListOfCalendar>("/api/calendars/generic", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListCalendars", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListCalendarsInScope: List all calenders in a specified scope List calendars at a point in AsAt time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>PagedResourceListOfCalendar</returns>
        public PagedResourceListOfCalendar ListCalendarsInScope(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string))
        {
            Lusid.Sdk.Client.ApiResponse<PagedResourceListOfCalendar> localVarResponse = ListCalendarsInScopeWithHttpInfo(scope, asAt, page, start, limit, filter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListCalendarsInScope: List all calenders in a specified scope List calendars at a point in AsAt time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of PagedResourceListOfCalendar</returns>
        public Lusid.Sdk.Client.ApiResponse<PagedResourceListOfCalendar> ListCalendarsInScopeWithHttpInfo(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->ListCalendarsInScope");

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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request
            var localVarResponse = this.Client.Get<PagedResourceListOfCalendar>("/api/calendars/generic/{scope}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListCalendarsInScope", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListCalendarsInScope: List all calenders in a specified scope List calendars at a point in AsAt time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PagedResourceListOfCalendar</returns>
        public async System.Threading.Tasks.Task<PagedResourceListOfCalendar> ListCalendarsInScopeAsync(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<PagedResourceListOfCalendar> localVarResponse = await ListCalendarsInScopeWithHttpInfoAsync(scope, asAt, page, start, limit, filter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListCalendarsInScope: List all calenders in a specified scope List calendars at a point in AsAt time.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the calendars</param>
        /// <param name="asAt">The AsAt datetime at which to retrieve the calendars (optional)</param>
        /// <param name="page">The pagination token to use to continue listing calendars from a previous call to list calendars.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional)</param>
        /// <param name="start">When paginating, skip this number of results. (optional)</param>
        /// <param name="limit">When paginating, limit the number of returned results to this many. (optional)</param>
        /// <param name="filter">Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PagedResourceListOfCalendar)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<PagedResourceListOfCalendar>> ListCalendarsInScopeWithHttpInfoAsync(string scope, DateTimeOffset? asAt = default(DateTimeOffset?), string page = default(string), int? start = default(int?), int? limit = default(int?), string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->ListCalendarsInScope");


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

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PagedResourceListOfCalendar>("/api/calendars/generic/{scope}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListCalendarsInScope", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateCalendar: Update a calendar Update the calendars WeekendMask, SourceProvider or Properties
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the request</param>
        /// <param name="code">Code of the request</param>
        /// <param name="updateCalendarRequest">The new state of the calendar</param>
        /// <returns>Calendar</returns>
        public Calendar UpdateCalendar(string scope, string code, UpdateCalendarRequest updateCalendarRequest)
        {
            Lusid.Sdk.Client.ApiResponse<Calendar> localVarResponse = UpdateCalendarWithHttpInfo(scope, code, updateCalendarRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateCalendar: Update a calendar Update the calendars WeekendMask, SourceProvider or Properties
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the request</param>
        /// <param name="code">Code of the request</param>
        /// <param name="updateCalendarRequest">The new state of the calendar</param>
        /// <returns>ApiResponse of Calendar</returns>
        public Lusid.Sdk.Client.ApiResponse<Calendar> UpdateCalendarWithHttpInfo(string scope, string code, UpdateCalendarRequest updateCalendarRequest)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->UpdateCalendar");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling CalendarsApi->UpdateCalendar");

            // verify the required parameter 'updateCalendarRequest' is set
            if (updateCalendarRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'updateCalendarRequest' when calling CalendarsApi->UpdateCalendar");

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
            localVarRequestOptions.Data = updateCalendarRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request
            var localVarResponse = this.Client.Post<Calendar>("/api/calendars/generic/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateCalendar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateCalendar: Update a calendar Update the calendars WeekendMask, SourceProvider or Properties
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the request</param>
        /// <param name="code">Code of the request</param>
        /// <param name="updateCalendarRequest">The new state of the calendar</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Calendar</returns>
        public async System.Threading.Tasks.Task<Calendar> UpdateCalendarAsync(string scope, string code, UpdateCalendarRequest updateCalendarRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<Calendar> localVarResponse = await UpdateCalendarWithHttpInfoAsync(scope, code, updateCalendarRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] UpdateCalendar: Update a calendar Update the calendars WeekendMask, SourceProvider or Properties
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the request</param>
        /// <param name="code">Code of the request</param>
        /// <param name="updateCalendarRequest">The new state of the calendar</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Calendar)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<Calendar>> UpdateCalendarWithHttpInfoAsync(string scope, string code, UpdateCalendarRequest updateCalendarRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling CalendarsApi->UpdateCalendar");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling CalendarsApi->UpdateCalendar");

            // verify the required parameter 'updateCalendarRequest' is set
            if (updateCalendarRequest == null)
                throw new Lusid.Sdk.Client.ApiException(400, "Missing required parameter 'updateCalendarRequest' when calling CalendarsApi->UpdateCalendar");


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
            localVarRequestOptions.Data = updateCalendarRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.5010");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Calendar>("/api/calendars/generic/{scope}/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateCalendar", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}