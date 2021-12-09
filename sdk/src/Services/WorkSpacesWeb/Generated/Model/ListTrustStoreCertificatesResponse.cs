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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// This is the response object from the ListTrustStoreCertificates operation.
    /// </summary>
    public partial class ListTrustStoreCertificatesResponse : AmazonWebServiceResponse
    {
        private List<CertificateSummary> _certificateList = new List<CertificateSummary>();
        private string _nextToken;
        private string _trustStoreArn;

        /// <summary>
        /// Gets and sets the property CertificateList. 
        /// <para>
        /// The certificate list.
        /// </para>
        /// </summary>
        public List<CertificateSummary> CertificateList
        {
            get { return this._certificateList; }
            set { this._certificateList = value; }
        }

        // Check to see if CertificateList property is set
        internal bool IsSetCertificateList()
        {
            return this._certificateList != null && this._certificateList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token used to retrieve the next page of results for this operation.&gt;
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property TrustStoreArn. 
        /// <para>
        /// The ARN of the trust store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string TrustStoreArn
        {
            get { return this._trustStoreArn; }
            set { this._trustStoreArn = value; }
        }

        // Check to see if TrustStoreArn property is set
        internal bool IsSetTrustStoreArn()
        {
            return this._trustStoreArn != null;
        }

    }
}