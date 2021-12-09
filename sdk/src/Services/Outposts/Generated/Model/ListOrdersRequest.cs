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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the ListOrders operation.
    /// Create a list of the Outpost orders for your Amazon Web Services account. You can
    /// filter your request by Outpost to return a more specific list of results.
    /// </summary>
    public partial class ListOrdersRequest : AmazonOutpostsRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _outpostIdentifierFilter;

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// </summary>
        [AWSProperty(Min=1, Max=1005)]
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

        /// <summary>
        /// Gets and sets the property OutpostIdentifierFilter. 
        /// <para>
        ///  The ID or the Amazon Resource Name (ARN) of the Outpost. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=180)]
        public string OutpostIdentifierFilter
        {
            get { return this._outpostIdentifierFilter; }
            set { this._outpostIdentifierFilter = value; }
        }

        // Check to see if OutpostIdentifierFilter property is set
        internal bool IsSetOutpostIdentifierFilter()
        {
            return this._outpostIdentifierFilter != null;
        }

    }
}