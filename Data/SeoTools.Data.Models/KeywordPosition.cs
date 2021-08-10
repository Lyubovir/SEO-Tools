namespace SeoTools.Data.Models
{
    using System;

    using SeoTools.Data.Common.Models;

    public class KeywordPosition : BaseDeletableModel<int>
    {
        public int Position { get; set; }

        public DateTime DateChecked { get; set; }

        public int KeywordId { get; set; }

        public virtual Keyword Keyword { get; set; }
    }
}
