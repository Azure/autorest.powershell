namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>Anything</summary>
    public partial class Any :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IAny,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IAnyInternal
    {

        /// <summary>Creates an new <see cref="Any" /> instance.</summary>
        public Any()
        {

        }
    }
    /// Anything
    public partial interface IAny :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {

    }
    /// Anything
    internal partial interface IAnyInternal

    {

    }
}