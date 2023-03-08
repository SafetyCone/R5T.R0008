using System;

using Microsoft.AspNetCore.Components;

using R5T.R0008.T000;

using Instances = R5T.R0008.Instances;


namespace System
{
    public static class LinkExtensions
    {
        public static RenderFragment ShowUrl(this Link link)
        {
            var output = Instances.LinkOperator.ShowUrl(link);
            return output;
        }

        public static RenderFragment WithDisplayText(this Link link,
            string displayText)
        {
            var output = Instances.LinkOperator.WithDisplayText(
                link,
                displayText);

            return output;
        }
    }
}
