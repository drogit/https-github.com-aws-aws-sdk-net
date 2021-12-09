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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// This is the response object from the GetConnectPeer operation.
    /// </summary>
    public partial class GetConnectPeerResponse : AmazonWebServiceResponse
    {
        private ConnectPeer _connectPeer;

        /// <summary>
        /// Gets and sets the property ConnectPeer. 
        /// <para>
        /// Returns information about a core network Connect peer.
        /// </para>
        /// </summary>
        public ConnectPeer ConnectPeer
        {
            get { return this._connectPeer; }
            set { this._connectPeer = value; }
        }

        // Check to see if ConnectPeer property is set
        internal bool IsSetConnectPeer()
        {
            return this._connectPeer != null;
        }

    }
}