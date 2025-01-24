// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>Defines the SAP Central Services Instance properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(SapCentralServerPropertiesTypeConverter))]
    public partial class SapCentralServerProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapCentralServerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SapCentralServerProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapCentralServerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SapCentralServerProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SapCentralServerProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SapCentralServerProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapCentralServerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SapCentralServerProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MessageServerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerProperty = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerProperties) content.GetValueForProperty("MessageServerProperty",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerProperty, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.MessageServerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("EnqueueServerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerProperty = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerProperties) content.GetValueForProperty("EnqueueServerProperty",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerProperty, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.EnqueueServerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("GatewayServerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).GatewayServerProperty = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IGatewayServerProperties) content.GetValueForProperty("GatewayServerProperty",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).GatewayServerProperty, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.GatewayServerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("EnqueueReplicationServerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerProperty = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerProperties) content.GetValueForProperty("EnqueueReplicationServerProperty",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerProperty, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.EnqueueReplicationServerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LoadBalancerDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).LoadBalancerDetail = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails) content.GetValueForProperty("LoadBalancerDetail",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).LoadBalancerDetail, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("InstanceNo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).InstanceNo = (string) content.GetValueForProperty("InstanceNo",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).InstanceNo, global::System.Convert.ToString);
            }
            if (content.Contains("Subnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Subnet = (string) content.GetValueForProperty("Subnet",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Subnet, global::System.Convert.ToString);
            }
            if (content.Contains("KernelVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).KernelVersion = (string) content.GetValueForProperty("KernelVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).KernelVersion, global::System.Convert.ToString);
            }
            if (content.Contains("KernelPatch"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).KernelPatch = (string) content.GetValueForProperty("KernelPatch",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).KernelPatch, global::System.Convert.ToString);
            }
            if (content.Contains("VMDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).VMDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerVMDetails>) content.GetValueForProperty("VMDetail",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).VMDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerVMDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.CentralServerVMDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Health"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Health = (string) content.GetValueForProperty("Health",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Health, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MessageServerPropertyMSPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyMSPort = (long?) content.GetValueForProperty("MessageServerPropertyMSPort",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyMSPort, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MessageServerPropertyInternalMSPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyInternalMSPort = (long?) content.GetValueForProperty("MessageServerPropertyInternalMSPort",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyInternalMSPort, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MessageServerPropertyHttpPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHttpPort = (long?) content.GetValueForProperty("MessageServerPropertyHttpPort",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHttpPort, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MessageServerPropertyHttpsPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHttpsPort = (long?) content.GetValueForProperty("MessageServerPropertyHttpsPort",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHttpsPort, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MessageServerPropertyHostname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHostname = (string) content.GetValueForProperty("MessageServerPropertyHostname",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHostname, global::System.Convert.ToString);
            }
            if (content.Contains("MessageServerPropertyIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyIPAddress = (string) content.GetValueForProperty("MessageServerPropertyIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("MessageServerPropertyHealth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHealth = (string) content.GetValueForProperty("MessageServerPropertyHealth",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHealth, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueServerPropertyHostname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyHostname = (string) content.GetValueForProperty("EnqueueServerPropertyHostname",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyHostname, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueServerPropertyIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyIPAddress = (string) content.GetValueForProperty("EnqueueServerPropertyIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueServerPropertyPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyPort = (long?) content.GetValueForProperty("EnqueueServerPropertyPort",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyPort, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("EnqueueServerPropertyHealth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyHealth = (string) content.GetValueForProperty("EnqueueServerPropertyHealth",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyHealth, global::System.Convert.ToString);
            }
            if (content.Contains("GatewayServerPropertyPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).GatewayServerPropertyPort = (long?) content.GetValueForProperty("GatewayServerPropertyPort",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).GatewayServerPropertyPort, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("GatewayServerPropertyHealth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).GatewayServerPropertyHealth = (string) content.GetValueForProperty("GatewayServerPropertyHealth",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).GatewayServerPropertyHealth, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueReplicationServerPropertyErsVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyErsVersion = (string) content.GetValueForProperty("EnqueueReplicationServerPropertyErsVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyErsVersion, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueReplicationServerPropertyInstanceNo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyInstanceNo = (string) content.GetValueForProperty("EnqueueReplicationServerPropertyInstanceNo",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyInstanceNo, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueReplicationServerPropertyHostname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyHostname = (string) content.GetValueForProperty("EnqueueReplicationServerPropertyHostname",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyHostname, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueReplicationServerPropertyKernelVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyKernelVersion = (string) content.GetValueForProperty("EnqueueReplicationServerPropertyKernelVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyKernelVersion, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueReplicationServerPropertyKernelPatch"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyKernelPatch = (string) content.GetValueForProperty("EnqueueReplicationServerPropertyKernelPatch",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyKernelPatch, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueReplicationServerPropertyIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyIPAddress = (string) content.GetValueForProperty("EnqueueReplicationServerPropertyIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueReplicationServerPropertyHealth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyHealth = (string) content.GetValueForProperty("EnqueueReplicationServerPropertyHealth",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyHealth, global::System.Convert.ToString);
            }
            if (content.Contains("LoadBalancerDetailId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).LoadBalancerDetailId = (string) content.GetValueForProperty("LoadBalancerDetailId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).LoadBalancerDetailId, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).ErrorProperty = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition) content.GetValueForProperty("ErrorProperty",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).ErrorProperty, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ErrorDefinitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ErrorDefinitionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Message, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapCentralServerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SapCentralServerProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MessageServerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerProperty = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerProperties) content.GetValueForProperty("MessageServerProperty",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerProperty, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.MessageServerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("EnqueueServerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerProperty = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerProperties) content.GetValueForProperty("EnqueueServerProperty",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerProperty, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.EnqueueServerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("GatewayServerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).GatewayServerProperty = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IGatewayServerProperties) content.GetValueForProperty("GatewayServerProperty",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).GatewayServerProperty, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.GatewayServerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("EnqueueReplicationServerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerProperty = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerProperties) content.GetValueForProperty("EnqueueReplicationServerProperty",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerProperty, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.EnqueueReplicationServerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LoadBalancerDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).LoadBalancerDetail = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails) content.GetValueForProperty("LoadBalancerDetail",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).LoadBalancerDetail, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("InstanceNo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).InstanceNo = (string) content.GetValueForProperty("InstanceNo",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).InstanceNo, global::System.Convert.ToString);
            }
            if (content.Contains("Subnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Subnet = (string) content.GetValueForProperty("Subnet",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Subnet, global::System.Convert.ToString);
            }
            if (content.Contains("KernelVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).KernelVersion = (string) content.GetValueForProperty("KernelVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).KernelVersion, global::System.Convert.ToString);
            }
            if (content.Contains("KernelPatch"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).KernelPatch = (string) content.GetValueForProperty("KernelPatch",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).KernelPatch, global::System.Convert.ToString);
            }
            if (content.Contains("VMDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).VMDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerVMDetails>) content.GetValueForProperty("VMDetail",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).VMDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerVMDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.CentralServerVMDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Health"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Health = (string) content.GetValueForProperty("Health",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Health, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MessageServerPropertyMSPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyMSPort = (long?) content.GetValueForProperty("MessageServerPropertyMSPort",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyMSPort, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MessageServerPropertyInternalMSPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyInternalMSPort = (long?) content.GetValueForProperty("MessageServerPropertyInternalMSPort",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyInternalMSPort, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MessageServerPropertyHttpPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHttpPort = (long?) content.GetValueForProperty("MessageServerPropertyHttpPort",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHttpPort, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MessageServerPropertyHttpsPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHttpsPort = (long?) content.GetValueForProperty("MessageServerPropertyHttpsPort",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHttpsPort, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MessageServerPropertyHostname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHostname = (string) content.GetValueForProperty("MessageServerPropertyHostname",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHostname, global::System.Convert.ToString);
            }
            if (content.Contains("MessageServerPropertyIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyIPAddress = (string) content.GetValueForProperty("MessageServerPropertyIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("MessageServerPropertyHealth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHealth = (string) content.GetValueForProperty("MessageServerPropertyHealth",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).MessageServerPropertyHealth, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueServerPropertyHostname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyHostname = (string) content.GetValueForProperty("EnqueueServerPropertyHostname",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyHostname, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueServerPropertyIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyIPAddress = (string) content.GetValueForProperty("EnqueueServerPropertyIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueServerPropertyPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyPort = (long?) content.GetValueForProperty("EnqueueServerPropertyPort",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyPort, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("EnqueueServerPropertyHealth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyHealth = (string) content.GetValueForProperty("EnqueueServerPropertyHealth",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueServerPropertyHealth, global::System.Convert.ToString);
            }
            if (content.Contains("GatewayServerPropertyPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).GatewayServerPropertyPort = (long?) content.GetValueForProperty("GatewayServerPropertyPort",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).GatewayServerPropertyPort, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("GatewayServerPropertyHealth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).GatewayServerPropertyHealth = (string) content.GetValueForProperty("GatewayServerPropertyHealth",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).GatewayServerPropertyHealth, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueReplicationServerPropertyErsVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyErsVersion = (string) content.GetValueForProperty("EnqueueReplicationServerPropertyErsVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyErsVersion, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueReplicationServerPropertyInstanceNo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyInstanceNo = (string) content.GetValueForProperty("EnqueueReplicationServerPropertyInstanceNo",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyInstanceNo, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueReplicationServerPropertyHostname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyHostname = (string) content.GetValueForProperty("EnqueueReplicationServerPropertyHostname",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyHostname, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueReplicationServerPropertyKernelVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyKernelVersion = (string) content.GetValueForProperty("EnqueueReplicationServerPropertyKernelVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyKernelVersion, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueReplicationServerPropertyKernelPatch"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyKernelPatch = (string) content.GetValueForProperty("EnqueueReplicationServerPropertyKernelPatch",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyKernelPatch, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueReplicationServerPropertyIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyIPAddress = (string) content.GetValueForProperty("EnqueueReplicationServerPropertyIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("EnqueueReplicationServerPropertyHealth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyHealth = (string) content.GetValueForProperty("EnqueueReplicationServerPropertyHealth",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).EnqueueReplicationServerPropertyHealth, global::System.Convert.ToString);
            }
            if (content.Contains("LoadBalancerDetailId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).LoadBalancerDetailId = (string) content.GetValueForProperty("LoadBalancerDetailId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).LoadBalancerDetailId, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).ErrorProperty = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition) content.GetValueForProperty("ErrorProperty",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).ErrorProperty, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ErrorDefinitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ErrorDefinitionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)this).Message, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Defines the SAP Central Services Instance properties.
    [System.ComponentModel.TypeConverter(typeof(SapCentralServerPropertiesTypeConverter))]
    public partial interface ISapCentralServerProperties

    {

    }
}