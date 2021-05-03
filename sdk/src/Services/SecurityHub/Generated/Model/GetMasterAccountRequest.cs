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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the GetMasterAccount operation.
    /// This method is deprecated. Instead, use <code>GetAdministratorAccount</code>.
    /// 
    ///  
    /// <para>
    /// The Security Hub console continues to use <code>GetMasterAccount</code>. It will eventually
    /// change to use <code>GetAdministratorAccount</code>. Any IAM policies that specifically
    /// control access to this function must continue to use <code>GetMasterAccount</code>.
    /// You should also add <code>GetAdministratorAccount</code> to your policies to ensure
    /// that the correct permissions are in place after the console begins to use <code>GetAdministratorAccount</code>.
    /// </para>
    ///  
    /// <para>
    /// Provides the details for the Security Hub administrator account for the current member
    /// account.
    /// </para>
    ///  
    /// <para>
    /// Can be used by both member accounts that are managed using Organizations and accounts
    /// that were invited manually.
    /// </para>
    /// </summary>
    public partial class GetMasterAccountRequest : AmazonSecurityHubRequest
    {

    }
}