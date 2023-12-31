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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateScheduledAudit operation.
    /// Creates a scheduled audit that is run at a specified time interval.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateScheduledAudit</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class CreateScheduledAuditRequest : AmazonIoTRequest
    {
        private string _dayOfMonth;
        private DayOfWeek _dayOfWeek;
        private AuditFrequency _frequency;
        private string _scheduledAuditName;
        private List<Tag> _tags = new List<Tag>();
        private List<string> _targetCheckNames = new List<string>();

        /// <summary>
        /// Gets and sets the property DayOfMonth. 
        /// <para>
        /// The day of the month on which the scheduled audit takes place. This can be "1" through
        /// "31" or "LAST". This field is required if the "frequency" parameter is set to <code>MONTHLY</code>.
        /// If days 29 to 31 are specified, and the month doesn't have that many days, the audit
        /// takes place on the <code>LAST</code> day of the month.
        /// </para>
        /// </summary>
        public string DayOfMonth
        {
            get { return this._dayOfMonth; }
            set { this._dayOfMonth = value; }
        }

        // Check to see if DayOfMonth property is set
        internal bool IsSetDayOfMonth()
        {
            return this._dayOfMonth != null;
        }

        /// <summary>
        /// Gets and sets the property DayOfWeek. 
        /// <para>
        /// The day of the week on which the scheduled audit takes place, either <code>SUN</code>,
        /// <code>MON</code>, <code>TUE</code>, <code>WED</code>, <code>THU</code>, <code>FRI</code>,
        /// or <code>SAT</code>. This field is required if the <code>frequency</code> parameter
        /// is set to <code>WEEKLY</code> or <code>BIWEEKLY</code>.
        /// </para>
        /// </summary>
        public DayOfWeek DayOfWeek
        {
            get { return this._dayOfWeek; }
            set { this._dayOfWeek = value; }
        }

        // Check to see if DayOfWeek property is set
        internal bool IsSetDayOfWeek()
        {
            return this._dayOfWeek != null;
        }

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// How often the scheduled audit takes place, either <code>DAILY</code>, <code>WEEKLY</code>,
        /// <code>BIWEEKLY</code> or <code>MONTHLY</code>. The start time of each audit is determined
        /// by the system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuditFrequency Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledAuditName. 
        /// <para>
        /// The name you want to give to the scheduled audit. (Max. 128 chars)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ScheduledAuditName
        {
            get { return this._scheduledAuditName; }
            set { this._scheduledAuditName = value; }
        }

        // Check to see if ScheduledAuditName property is set
        internal bool IsSetScheduledAuditName()
        {
            return this._scheduledAuditName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that can be used to manage the scheduled audit.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetCheckNames. 
        /// <para>
        /// Which checks are performed during the scheduled audit. Checks must be enabled for
        /// your account. (Use <code>DescribeAccountAuditConfiguration</code> to see the list
        /// of all checks, including those that are enabled or use <code>UpdateAccountAuditConfiguration</code>
        /// to select which checks are enabled.)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TargetCheckNames
        {
            get { return this._targetCheckNames; }
            set { this._targetCheckNames = value; }
        }

        // Check to see if TargetCheckNames property is set
        internal bool IsSetTargetCheckNames()
        {
            return this._targetCheckNames != null && this._targetCheckNames.Count > 0; 
        }

    }
}