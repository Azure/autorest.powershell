/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿using System;

namespace Carbon.Json.Converters
{
    public sealed class JsonConverterAttribute : Attribute
    {
        public JsonConverterAttribute(Type type)
        {
            Converter = (IJsonConverter)Activator.CreateInstance(type);
        }

        public IJsonConverter Converter { get; }
    }
}