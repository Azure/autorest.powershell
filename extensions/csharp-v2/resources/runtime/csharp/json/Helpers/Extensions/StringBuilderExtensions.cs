using System.Text;

namespace Carbon.Internal.Extensions
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
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