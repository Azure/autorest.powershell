/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Carbon.Json.Converters
{
    internal sealed class Int64Converter : JsonConverter<long>
    {
        public override JsonNode ToJson(long value) => new JsonNumber(value);

        public override long FromJson(JsonNode node) => (long)node;
    }
}