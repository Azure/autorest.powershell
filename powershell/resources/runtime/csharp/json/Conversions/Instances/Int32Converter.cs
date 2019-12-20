/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Carbon.Json.Converters
{
    internal sealed class Int32Converter : JsonConverter<int>
    {
        public override JsonNode ToJson(int value) => new JsonNumber(value);

        public override int FromJson(JsonNode node) => (int)node;
    }
}