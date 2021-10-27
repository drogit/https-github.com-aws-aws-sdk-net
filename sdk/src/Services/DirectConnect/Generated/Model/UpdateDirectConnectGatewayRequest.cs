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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDirectConnectGateway operation.
    /// Updates the name of a current Direct Connect gateway.
    /// </summary>
    public partial class UpdateDirectConnectGatewayRequest : AmazonDirectConnectRequest
    {
        private string _directConnectGatewayId;
        private string _newDirectConnectGatewayName;

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayId. 
        /// <para>
        /// The ID of the Direct Connect gateway to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectConnectGatewayId
        {
            get { return this._directConnectGatewayId; }
            set { this._directConnectGatewayId = value; }
        }

        // Check to see if DirectConnectGatewayId property is set
        internal bool IsSetDirectConnectGatewayId()
        {
            return this._directConnectGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property NewDirectConnectGatewayName. 
        /// <para>
        /// The new name for the Direct Connect gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NewDirectConnectGatewayName
        {
            get { return this._newDirectConnectGatewayName; }
            set { this._newDirectConnectGatewayName = value; }
        }

        // Check to see if NewDirectConnectGatewayName property is set
        internal bool IsSetNewDirectConnectGatewayName()
        {
            return this._newDirectConnectGatewayName != null;
        }

    }
}