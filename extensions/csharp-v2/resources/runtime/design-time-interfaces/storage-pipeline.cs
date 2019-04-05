// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// This file contains design-time interfaces that are present in storage projects
// but these are not emitted into the ouptut project from here.
namespace Microsoft.Azure.HttpPipeline
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public interface IPipelinePolicy
    {
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public enum PipelinePolicyOptions
    {

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public interface IPipelinePolicyFactory
    {

    }
}