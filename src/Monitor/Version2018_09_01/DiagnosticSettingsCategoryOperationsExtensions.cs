// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Version2018_09_01
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DiagnosticSettingsCategoryOperations.
    /// </summary>
    public static partial class DiagnosticSettingsCategoryOperationsExtensions
    {
            /// <summary>
            /// Gets the diagnostic settings category for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='name'>
            /// The name of the diagnostic setting.
            /// </param>
            public static DiagnosticSettingsCategoryResource Get(this IDiagnosticSettingsCategoryOperations operations, string resourceUri, string name)
            {
                return operations.GetAsync(resourceUri, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the diagnostic settings category for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='name'>
            /// The name of the diagnostic setting.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiagnosticSettingsCategoryResource> GetAsync(this IDiagnosticSettingsCategoryOperations operations, string resourceUri, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceUri, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the diagnostic settings categories for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            public static DiagnosticSettingsCategoryResourceCollection List(this IDiagnosticSettingsCategoryOperations operations, string resourceUri)
            {
                return operations.ListAsync(resourceUri).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the diagnostic settings categories for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiagnosticSettingsCategoryResourceCollection> ListAsync(this IDiagnosticSettingsCategoryOperations operations, string resourceUri, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceUri, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
