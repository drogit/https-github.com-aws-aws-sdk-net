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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SQS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ListMessageMoveTasksResultEntry Object
    /// </summary>  
    public class ListMessageMoveTasksResultEntryUnmarshaller : IUnmarshaller<ListMessageMoveTasksResultEntry, XmlUnmarshallerContext>, IUnmarshaller<ListMessageMoveTasksResultEntry, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ListMessageMoveTasksResultEntry Unmarshall(XmlUnmarshallerContext context)
        {
            ListMessageMoveTasksResultEntry unmarshalledObject = new ListMessageMoveTasksResultEntry();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ApproximateNumberOfMessagesMoved", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        unmarshalledObject.ApproximateNumberOfMessagesMoved = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ApproximateNumberOfMessagesToMove", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        unmarshalledObject.ApproximateNumberOfMessagesToMove = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DestinationArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DestinationArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("FailureReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxNumberOfMessagesPerSecond", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.MaxNumberOfMessagesPerSecond = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SourceArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SourceArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StartedTimestamp", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        unmarshalledObject.StartedTimestamp = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TaskHandle", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TaskHandle = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ListMessageMoveTasksResultEntry Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ListMessageMoveTasksResultEntryUnmarshaller _instance = new ListMessageMoveTasksResultEntryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListMessageMoveTasksResultEntryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}