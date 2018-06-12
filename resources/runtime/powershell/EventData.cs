
namespace Microsoft.Rest.ClientRuntime
{
    using System;

    [System.ComponentModel.TypeConverter(typeof(EventDataConverter))]
    ///	<remarks>
    /// In PowerShell, we add on the EventDataConverter to support sending events between modules.
    /// Obviously, this code would need to be duplcated on both modules.
    /// This is preferable to sharing a common library, as versioning makes that problematic.
    /// </remarks>
    public partial class EventData : EventArgs
    {
    }

    /// <summary>
    /// A PowerShell PSTypeConverter to adapt an <c>EventData</c> object that has been passed.
    /// Usually used between modules.
    /// </summary>
    public class EventDataConverter : System.Management.Automation.PSTypeConverter
    {
        public override bool CanConvertTo(object sourceValue, Type destinationType) => false;
        public override object ConvertTo(object sourceValue, Type destinationType, IFormatProvider formatProvider, bool ignoreCase) => null;
        public override bool CanConvertFrom(dynamic sourceValue, Type destinationType) => destinationType == typeof(EventData) && CanConvertFrom(sourceValue);
        public override object ConvertFrom(dynamic sourceValue, Type destinationType, IFormatProvider formatProvider, bool ignoreCase) => ConvertFrom(sourceValue);

        public static bool CanConvertFrom(dynamic sv)
        {
            var result = true;
            try
            {
                // check if this has required parameters...
                sv?.Id?.GetType();
                sv?.Message?.GetType();
                sv?.Parameter?.GetType();
                sv?.Value?.GetType();
                sv?.RequestMessage?.GetType();
                sv?.ResponseMessage?.GetType();
                sv?.Cancel?.GetType();
            }
            catch
            {
                return false;
            }
            return result;
        }

        public static object ConvertFrom(dynamic sv)
        {
            try
            {
                return new EventData
                {
                    Id = sv.Id,
                    Message = sv.Message,
                    Parameter = sv.Parameter,
                    Value = sv.Value,
                    RequestMessage = sv.RequestMessage,
                    ResponseMessage = sv.ResponseMessage,
                    Cancel = sv.Cancel
                };
            }
            catch
            {
            }
            return null;
        }
    }
}