/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Carbon.Json
{
    public sealed class XNull : JsonNode
    {
        public static readonly XNull Instance = new XNull();

        private XNull() { }

        public override JsonType Type => JsonType.Null;
    }
}