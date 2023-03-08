using System;


namespace R5T.R0008
{
    public class LinkOperator : ILinkOperator
    {
        #region Infrastructure

        public static ILinkOperator Instance { get; } = new LinkOperator();


        private LinkOperator()
        {
        }

        #endregion
    }
}
