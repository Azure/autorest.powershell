/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Carbon.Json.Converters
{
    internal sealed class DecimalConverter : JsonConverter<decimal>
    {
        public override JsonNode ToJson(decimal value) => new JsonNumber(value.ToString());

        public override decimal FromJson(JsonNode node)
        {
            return (decimal)node;
        }
    }
}