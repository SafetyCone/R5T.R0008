using System;

using Microsoft.AspNetCore.Components;

using R5T.T0132;

using R5T.R0008.T000;


namespace R5T.R0008
{
    [FunctionalityMarker]
    public partial interface ILinkOperator : IFunctionalityMarker
    {
        public RenderFragment ShowUrl(Link link)
        {
            return this.WithDisplayText(
                link,
                link.Value);
        }

        public RenderFragment WithDisplayText(
            Link link,
            string displayText)
        {
            return Utility.GetAnchor(
                link,
                displayText);
        }
    }
}
