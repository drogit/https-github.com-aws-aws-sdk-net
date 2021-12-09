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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Details the status of Amazon Inspector for each resource type Amazon Inspector scans.
    /// </summary>
    public partial class ResourceStatus
    {
        private Status _ec2;
        private Status _ecr;

        /// <summary>
        /// Gets and sets the property Ec2. 
        /// <para>
        /// The status of Amazon Inspector scanning for Amazon EC2 resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Status Ec2
        {
            get { return this._ec2; }
            set { this._ec2 = value; }
        }

        // Check to see if Ec2 property is set
        internal bool IsSetEc2()
        {
            return this._ec2 != null;
        }

        /// <summary>
        /// Gets and sets the property Ecr. 
        /// <para>
        /// The status of Amazon Inspector scanning for Amazon ECR resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Status Ecr
        {
            get { return this._ecr; }
            set { this._ecr = value; }
        }

        // Check to see if Ecr property is set
        internal bool IsSetEcr()
        {
            return this._ecr != null;
        }

    }
}