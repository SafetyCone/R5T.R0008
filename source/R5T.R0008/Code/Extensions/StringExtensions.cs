using System;

using R5T.R0008.T000;


namespace R5T.R0008.Extensions
{
    public static class StringExtensions
    {
        public static Link ToLink(this string value)
        {
            var output = Link.From(value);
            return output;
        }
    }
}
