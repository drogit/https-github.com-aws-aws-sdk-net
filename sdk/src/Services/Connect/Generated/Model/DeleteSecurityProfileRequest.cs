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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSecurityProfile operation.
    /// This API is in preview release for Amazon Connect and is subject to change.
    /// 
    ///  
    /// <para>
    /// Deletes a security profile.
    /// </para>
    /// </summary>
    public partial class DeleteSecurityProfileRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private string _securityProfileId;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can find the instanceId in the
        /// ARN of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileId. 
        /// <para>
        /// The identifier for the security profle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecurityProfileId
        {
            get { return this._securityProfileId; }
            set { this._securityProfileId = value; }
        }

        // Check to see if SecurityProfileId property is set
        internal bool IsSetSecurityProfileId()
        {
            return this._securityProfileId != null;
        }

    }
}