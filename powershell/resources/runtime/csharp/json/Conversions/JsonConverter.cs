/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Carbon.Json.Converters
{
    public abstract class JsonConverter<T> : IJsonConverter
    {
        public abstract T FromJson(JsonNode node);

        public abstract JsonNode ToJson(T value);

        #region IConverter

        object IJsonConverter.FromJson(JsonNode node) => FromJson(node);

        JsonNode IJsonConverter.ToJson(object value) => ToJson((T)value);

        #endregion
    }
}