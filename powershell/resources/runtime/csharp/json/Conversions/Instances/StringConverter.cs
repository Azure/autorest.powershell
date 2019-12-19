/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Carbon.Json.Converters
{
    internal sealed class StringConverter : JsonConverter<string>
    {
        public override JsonNode ToJson(string value) => new JsonString(value);

        public override string FromJson(JsonNode node) => node.ToString();
    }
}