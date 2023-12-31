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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie.Model
{
    /// <summary>
    /// (Discontinued) Includes details about the failed S3 resources.
    /// </summary>
    public partial class FailedS3Resource
    {
        private string _errorCode;
        private string _errorMessage;
        private S3Resource _failedItem;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// (Discontinued) The status code of a failed item.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// (Discontinued) The error message of a failed item.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property FailedItem. 
        /// <para>
        /// (Discontinued) The failed S3 resources.
        /// </para>
        /// </summary>
        public S3Resource FailedItem
        {
            get { return this._failedItem; }
            set { this._failedItem = value; }
        }

        // Check to see if FailedItem property is set
        internal bool IsSetFailedItem()
        {
            return this._failedItem != null;
        }

    }
}