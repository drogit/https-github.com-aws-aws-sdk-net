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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutforVision.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LookoutforVision.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListModelPackagingJobs Request Marshaller
    /// </summary>       
    public class ListModelPackagingJobsRequestMarshaller : IMarshaller<IRequest, ListModelPackagingJobsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListModelPackagingJobsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListModelPackagingJobsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LookoutforVision");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-20";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetProjectName())
                throw new AmazonLookoutforVisionException("Request object does not have required field ProjectName set");
            request.AddPathResource("{projectName}", StringUtils.FromString(publicRequest.ProjectName));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/2020-11-20/projects/{projectName}/modelpackagingjobs";
            request.UseQueryString = true;

            return request;
        }
        private static ListModelPackagingJobsRequestMarshaller _instance = new ListModelPackagingJobsRequestMarshaller();        

        internal static ListModelPackagingJobsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListModelPackagingJobsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}