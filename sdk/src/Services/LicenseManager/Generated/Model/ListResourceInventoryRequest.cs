/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the ListResourceInventory operation.
    /// Lists resources managed using Systems Manager inventory.
    /// </summary>
    public partial class ListResourceInventoryRequest : AmazonLicenseManagerRequest
    {
        private List<InventoryFilter> _filters = new List<InventoryFilter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters to scope the results. The following filters and logical operators are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>account_id</code> - The ID of the Amazon Web Services account that owns the
        /// resource. Logical operators are <code>EQUALS</code> | <code>NOT_EQUALS</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>application_name</code> - The name of the application. Logical operators are
        /// <code>EQUALS</code> | <code>BEGINS_WITH</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>license_included</code> - The type of license included. Logical operators are
        /// <code>EQUALS</code> | <code>NOT_EQUALS</code>. Possible values are <code>sql-server-enterprise</code>
        /// | <code>sql-server-standard</code> | <code>sql-server-web</code> | <code>windows-server-datacenter</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>platform</code> - The platform of the resource. Logical operators are <code>EQUALS</code>
        /// | <code>BEGINS_WITH</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>resource_id</code> - The ID of the resource. Logical operators are <code>EQUALS</code>
        /// | <code>NOT_EQUALS</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag:&lt;key&gt;</code> - The key/value combination of a tag assigned to the
        /// resource. Logical operators are <code>EQUALS</code> (single account) or <code>EQUALS</code>
        /// | <code>NOT_EQUALS</code> (cross account).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<InventoryFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token for the next set of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}