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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// A union of schema types.
    /// </summary>
    public partial class SchemaUnion
    {
        private SchemaDefinition _tabularSchemaConfig;

        /// <summary>
        /// Gets and sets the property TabularSchemaConfig. 
        /// <para>
        /// The configuration for a schema on a tabular Dataset.
        /// </para>
        /// </summary>
        public SchemaDefinition TabularSchemaConfig
        {
            get { return this._tabularSchemaConfig; }
            set { this._tabularSchemaConfig = value; }
        }

        // Check to see if TabularSchemaConfig property is set
        internal bool IsSetTabularSchemaConfig()
        {
            return this._tabularSchemaConfig != null;
        }

    }
}