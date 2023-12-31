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
 * Do not modify this file. This file is generated from the cur-2017-01-06.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CostAndUsageReport.Model;

namespace Amazon.CostAndUsageReport
{
    /// <summary>
    /// Interface for accessing CostAndUsageReport
    ///
    /// The AWS Cost and Usage Report API enables you to programmatically create, query, and
    /// delete AWS Cost and Usage report definitions.
    /// 
    ///  
    /// <para>
    /// AWS Cost and Usage reports track the monthly AWS costs and usage associated with your
    /// AWS account. The report contains line items for each unique combination of AWS product,
    /// usage type, and operation that your AWS account uses. You can configure the AWS Cost
    /// and Usage report to show only the data that you want, using the AWS Cost and Usage
    /// API.
    /// </para>
    ///  
    /// <para>
    /// Service Endpoint
    /// </para>
    ///  
    /// <para>
    /// The AWS Cost and Usage Report API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// cur.us-east-1.amazonaws.com
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonCostAndUsageReport : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICostAndUsageReportPaginatorFactory Paginators { get; }
#endif
                
        #region  DeleteReportDefinition



        /// <summary>
        /// Deletes the specified report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReportDefinition service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/DeleteReportDefinition">REST API Reference for DeleteReportDefinition Operation</seealso>
        Task<DeleteReportDefinitionResponse> DeleteReportDefinitionAsync(DeleteReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReportDefinitions



        /// <summary>
        /// Lists the AWS Cost and Usage reports available to this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReportDefinitions service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/DescribeReportDefinitions">REST API Reference for DescribeReportDefinitions Operation</seealso>
        Task<DescribeReportDefinitionsResponse> DescribeReportDefinitionsAsync(DescribeReportDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyReportDefinition



        /// <summary>
        /// Allows you to programatically update your report preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyReportDefinition service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/ModifyReportDefinition">REST API Reference for ModifyReportDefinition Operation</seealso>
        Task<ModifyReportDefinitionResponse> ModifyReportDefinitionAsync(ModifyReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutReportDefinition



        /// <summary>
        /// Creates a new report using the description that you provide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutReportDefinition service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.DuplicateReportNameException">
        /// A report with the specified name already exists in the account. Specify a different
        /// report name.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ReportLimitReachedException">
        /// This account already has five reports defined. To define a new report, you must delete
        /// an existing report.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/PutReportDefinition">REST API Reference for PutReportDefinition Operation</seealso>
        Task<PutReportDefinitionResponse> PutReportDefinitionAsync(PutReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}