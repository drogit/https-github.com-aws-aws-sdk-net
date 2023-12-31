﻿/*
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the GetBucketOwnershipControls response and response metadata.
    /// </summary>
    public partial class GetBucketOwnershipControlsResponse : AmazonWebServiceResponse
    {
        private OwnershipControls ownershipControls;

        /// <summary>
        /// Gets and sets the property OwnershipControls. 
        /// <para>
        /// The <code>OwnershipControls</code> (BucketOwnerEnforced, BucketOwnerPreferred, or
        /// ObjectWriter) currently in effect for this Amazon S3 bucket.
        /// </para>
        /// </summary>
        public OwnershipControls OwnershipControls
        {
            get
            {
                if (this.ownershipControls == null)
                    this.ownershipControls = new OwnershipControls();

                return this.ownershipControls;
            }
            set { this.ownershipControls = value; }
        }
    }
}
