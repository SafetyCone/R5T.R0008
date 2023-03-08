using System;

using R5T.T0150;


namespace R5T.R0008.T000
{
    [StrongTypeMarker]
    public class Link
    {
        #region Static

        public static Link From(string value)
        {
            var output = new Link(value);
            return output;
        }

        #endregion


        public string Value { get; set; }


        public Link()
        {
        }

        public Link(string value)
        {
            this.Value = value;
        }
    }
}
