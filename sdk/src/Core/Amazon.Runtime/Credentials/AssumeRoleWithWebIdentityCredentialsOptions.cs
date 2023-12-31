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
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using System;
using System.Collections.Generic;
using System.Net;

namespace Amazon.Runtime
{
    /// <summary>
    /// Options for using a credentials object to make AssumeRoleWithWebIdentity calls.
    /// </summary>
    public class AssumeRoleWithWebIdentityCredentialsOptions
    {
        /// <summary>
        /// Gets and sets the property DurationSeconds.
        /// <para>
        /// The duration, in seconds, of the role session. The value can range from 900 seconds
        /// (15 minutes) up to the maximum session duration setting for the role. This setting
        /// can have a value from 1 hour to 12 hours. If you specify a value higher than this
        /// setting, the operation fails. For example, if you specify a session duration of 12
        /// hours, but your administrator set the maximum session duration to 6 hours, your operation
        /// fails. To learn how to view the maximum value for your role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
        /// the Maximum Session Duration Setting for a Role</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///
        /// <para>
        /// By default, the value is set to <code>3600</code> seconds.
        /// </para>
        ///  <note>
        /// <para>
        /// The <code>DurationSeconds</code> parameter is separate from the duration of a console
        /// session that you might request using the returned credentials. The request to the
        /// federation endpoint for a console sign-in token takes a <code>SessionDuration</code>
        /// parameter that specifies the maximum length of the console session. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_enable-console-custom-url.html">Creating
        /// a URL that Enables Federated Users to Access the AWS Management Console</a> in the
        /// <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// Gets and sets the property ProviderId.
        /// <para>
        /// The fully qualified host component of the domain name of the identity provider.
        /// </para>
        ///
        /// <para>
        /// Specify this value only for OAuth 2.0 access tokens. Currently <code>www.amazon.com</code>
        /// and <code>graph.facebook.com</code> are the only supported identity providers for
        /// OAuth 2.0 access tokens. Do not include URL schemes and port numbers.
        /// </para>
        ///
        /// <para>
        /// Do not specify this value for OpenID Connect ID tokens.
        /// </para>
        /// </summary>
        public string ProviderId { get; set; }

        /// <summary>
        /// Gets and sets the property Policy.
        /// <para>
        /// An IAM policy in JSON format that you want to use as an inline session policy.
        /// </para>
        ///
        /// <para>
        /// This parameter is optional. Passing policies to this operation returns new temporary
        /// credentials. The resulting session's permissions are the intersection of the role's
        /// identity-based policy and the session policies. You can use the role's temporary credentials
        /// in subsequent AWS API calls to access resources in the account that owns the role.
        /// You cannot use session policies to grant more permissions than those allowed by the
        /// identity-based policy of the role that is being assumed. For more information, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///
        /// <para>
        /// The plain text that you use for both inline and managed session policies shouldn't
        /// exceed 2048 characters. The JSON policy characters can be any ASCII character from
        /// the space character to the end of the valid character list (\u0020 through \u00FF).
        /// It can also include the tab (\u0009), linefeed (\u000A), and carriage return (\u000D)
        /// characters.
        /// </para>
        ///  <note>
        /// <para>
        /// The characters in this parameter count towards the 2048 character session policy guideline.
        /// However, an AWS conversion compresses the session policies into a packed binary format
        /// that has a separate limit. This is the enforced limit. The <code>PackedPolicySize</code>
        /// response element indicates by percentage how close the policy is to the upper size
        /// limit.
        /// </para>
        ///  </note>
        /// </summary>
        public string Policy { get; set; }

        /// <summary>
        /// Gets and sets the property PolicyArns.
        /// <para>
        /// The Amazon Resource Names (ARNs) of the IAM managed policies that you want to use
        /// as managed session policies. The policies must exist in the same account as the role.
        /// </para>
        ///
        /// <para>
        /// This parameter is optional. You can provide up to 10 managed policy ARNs. However,
        /// the plain text that you use for both inline and managed session policies shouldn't
        /// exceed 2048 characters. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a> in the AWS General Reference.
        /// </para>
        ///  <note>
        /// <para>
        /// The characters in this parameter count towards the 2048 character session policy guideline.
        /// However, an AWS conversion compresses the session policies into a packed binary format
        /// that has a separate limit. This is the enforced limit. The <code>PackedPolicySize</code>
        /// response element indicates by percentage how close the policy is to the upper size
        /// limit.
        /// </para>
        ///  </note>
        /// <para>
        /// Passing policies to this operation returns new temporary credentials. The resulting
        /// session's permissions are the intersection of the role's identity-based policy and
        /// the session policies. You can use the role's temporary credentials in subsequent AWS
        /// API calls to access resources in the account that owns the role. You cannot use session
        /// policies to grant more permissions than those allowed by the identity-based policy
        /// of the role that is being assumed. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        public List<string> PolicyArns { get; set; }

        /// <summary>
        /// The proxy settings to use when calling AssumeRoleWithWebIdentity.
        /// <para>
        /// This parameter is optional.
        /// </para>
        /// </summary>
#if BCL
        public WebProxy ProxySettings { get; set; }
#elif NETSTANDARD
        public IWebProxy ProxySettings { get; set; }
#endif
    }
}