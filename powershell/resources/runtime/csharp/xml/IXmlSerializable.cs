namespace Microsoft.Rest.ClientRuntime
{
    public interface IXmlSerializable
    {
        System.Xml.Linq.XElement ToXml(System.Xml.Linq.XElement container = null, SerializationMode serializationMode = SerializationMode.None);
    }

}