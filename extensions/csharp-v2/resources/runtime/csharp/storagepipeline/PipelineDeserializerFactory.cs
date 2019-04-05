// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Storage.Shared
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.HttpPipeline;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public sealed class DeserializerPolicyFactory : Microsoft.Azure.HttpPipeline.IPipelinePolicyFactory
    {
        Func<HttpResponseMessage, Task> deserializer;

        public DeserializerPolicyFactory(Func<HttpResponseMessage, Task> deserializer)
        {
            this.deserializer = deserializer;
        }

        public IPipelinePolicy Create(IPipelinePolicy nextPolicy, PipelinePolicyOptions options)
        {
            return new DeserializerPolicy(nextPolicy, options, deserializer);
        }

        private class DeserializerPolicy : Microsoft.Azure.HttpPipeline.IPipelinePolicy
        {
            IPipelinePolicy pipelinePolicy;
            Func<HttpResponseMessage, Task> deserializer;

            public DeserializerPolicy(IPipelinePolicy policy, PipelinePolicyOptions options, Func<HttpResponseMessage, Task> deserializer)
            {
                this.pipelinePolicy = policy;
                this.deserializer = deserializer;
            }

            public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var response = await pipelinePolicy.SendAsync(request, cancellationToken);
                await deserializer(response);
                // TODO: clone response

                return response;
            }
        }
    }
}
