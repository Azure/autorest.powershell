// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Sample
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for BoolModelOperations.
    /// </summary>
    public static partial class BoolModelOperationsExtensions
    {
            /// <summary>
            /// Get true Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static bool? GetTrue(this IBoolModelOperations operations)
            {
                return ((IBoolModelOperations)operations).GetTrueAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get true Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<bool?> GetTrueAsync(this IBoolModelOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetTrueWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Set Boolean value true
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void PutTrue(this IBoolModelOperations operations)
            {
                ((IBoolModelOperations)operations).PutTrueAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Set Boolean value true
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PutTrueAsync(this IBoolModelOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.PutTrueWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get false Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static bool? GetFalse(this IBoolModelOperations operations)
            {
                return ((IBoolModelOperations)operations).GetFalseAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get false Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<bool?> GetFalseAsync(this IBoolModelOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetFalseWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Set Boolean value false
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void PutFalse(this IBoolModelOperations operations)
            {
                ((IBoolModelOperations)operations).PutFalseAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Set Boolean value false
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PutFalseAsync(this IBoolModelOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.PutFalseWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get null Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static bool? GetNull(this IBoolModelOperations operations)
            {
                return ((IBoolModelOperations)operations).GetNullAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<bool?> GetNullAsync(this IBoolModelOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetNullWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get invalid Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static bool? GetInvalid(this IBoolModelOperations operations)
            {
                return ((IBoolModelOperations)operations).GetInvalidAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get invalid Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<bool?> GetInvalidAsync(this IBoolModelOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetInvalidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
