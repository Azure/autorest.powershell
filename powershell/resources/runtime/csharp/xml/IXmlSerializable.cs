/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Microsoft.Rest.ClientRuntime
{
    public interface IXmlSerializable
    {
        System.Xml.Linq.XElement ToXml(System.Xml.Linq.XElement container = null, SerializationMode serializationMode = SerializationMode.None);
    }

}