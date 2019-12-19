/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿using System.Text;

namespace Carbon.Internal.Extensions
{
    internal static class StringBuilderExtensions
    {
        /// <summary>
        /// Extracts the buffered value and resets the buffer
        /// </summary>
        public static string Extract(this StringBuilder builder)
        {
            var text = builder.ToString();

            builder.Clear();

            return text;
        }
    }
}