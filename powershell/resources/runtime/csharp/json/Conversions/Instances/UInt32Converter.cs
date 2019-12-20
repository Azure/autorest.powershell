/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Carbon.Json.Converters
{
    internal sealed class UInt32Converter : JsonConverter<uint>
    {
        public override JsonNode ToJson(uint value) => new JsonNumber(value);

        public override uint FromJson(JsonNode node) => (uint)node;
    }
}