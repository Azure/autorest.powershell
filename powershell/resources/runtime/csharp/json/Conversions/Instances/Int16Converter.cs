/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Carbon.Json.Converters
{
    internal sealed class Int16Converter : JsonConverter<short>
    {
        public override JsonNode ToJson(short value) => new JsonNumber(value);

        public override short FromJson(JsonNode node) => (short)node;
    }
}