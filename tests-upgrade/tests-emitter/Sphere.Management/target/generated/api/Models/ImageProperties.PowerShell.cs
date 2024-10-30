namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.PowerShell;

    /// <summary>The properties of image</summary>
    [System.ComponentModel.TypeConverter(typeof(ImagePropertiesTypeConverter))]
    public partial class ImageProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ImageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ImageProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ImageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ImageProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ImageProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ImageProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ImageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ImageProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Image"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).Image = (string) content.GetValueForProperty("Image",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).Image, global::System.Convert.ToString);
            }
            if (content.Contains("ImageId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ImageId = (string) content.GetValueForProperty("ImageId",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ImageId, global::System.Convert.ToString);
            }
            if (content.Contains("ImageName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ImageName = (string) content.GetValueForProperty("ImageName",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ImageName, global::System.Convert.ToString);
            }
            if (content.Contains("RegionalDataBoundary"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).RegionalDataBoundary = (string) content.GetValueForProperty("RegionalDataBoundary",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).RegionalDataBoundary, global::System.Convert.ToString);
            }
            if (content.Contains("Uri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).Uri, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("ComponentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ComponentId = (string) content.GetValueForProperty("ComponentId",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ComponentId, global::System.Convert.ToString);
            }
            if (content.Contains("ImageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ImageType = (string) content.GetValueForProperty("ImageType",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ImageType, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ImageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ImageProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Image"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).Image = (string) content.GetValueForProperty("Image",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).Image, global::System.Convert.ToString);
            }
            if (content.Contains("ImageId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ImageId = (string) content.GetValueForProperty("ImageId",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ImageId, global::System.Convert.ToString);
            }
            if (content.Contains("ImageName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ImageName = (string) content.GetValueForProperty("ImageName",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ImageName, global::System.Convert.ToString);
            }
            if (content.Contains("RegionalDataBoundary"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).RegionalDataBoundary = (string) content.GetValueForProperty("RegionalDataBoundary",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).RegionalDataBoundary, global::System.Convert.ToString);
            }
            if (content.Contains("Uri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).Uri, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("ComponentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ComponentId = (string) content.GetValueForProperty("ComponentId",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ComponentId, global::System.Convert.ToString);
            }
            if (content.Contains("ImageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ImageType = (string) content.GetValueForProperty("ImageType",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ImageType, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The properties of image
    [System.ComponentModel.TypeConverter(typeof(ImagePropertiesTypeConverter))]
    public partial interface IImageProperties

    {

    }
}