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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociatePersonasFromEntities operation.
    /// Removes the specific permissions of users or groups in your Amazon Web Services SSO
    /// identity source with access to your Amazon Kendra experience. You can create an Amazon
    /// Kendra experience such as a search application. For more information on creating a
    /// search application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
    /// a search experience with no code</a>.
    /// </summary>
    public partial class DisassociatePersonasFromEntitiesRequest : AmazonKendraRequest
    {
        private List<string> _entityIds = new List<string>();
        private string _id;
        private string _indexId;

        /// <summary>
        /// Gets and sets the property EntityIds. 
        /// <para>
        /// The identifiers of users or groups in your Amazon Web Services SSO identity source.
        /// For example, user IDs could be user emails.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<string> EntityIds
        {
            get { return this._entityIds; }
            set { this._entityIds = value; }
        }

        // Check to see if EntityIds property is set
        internal bool IsSetEntityIds()
        {
            return this._entityIds != null && this._entityIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of your Amazon Kendra experience.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index for your Amazon Kendra experience.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

    }
}