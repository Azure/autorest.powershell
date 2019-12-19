/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Carbon.Json.Converters
{
    internal sealed class JsonObjectConverter : JsonConverter<JsonObject>
    {
        public override JsonNode ToJson(JsonObject value) => value;

        public override JsonObject FromJson(JsonNode node) => (JsonObject)node;
    }
}