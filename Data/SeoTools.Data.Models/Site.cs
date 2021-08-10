namespace SeoTools.Data.Models
{
    using System.Collections.Generic;

    using SeoTools.Data.Common.Models;

    public class Site : BaseDeletableModel<int>
    {
        public Site()
        {
            this.Keywords = new HashSet<Keyword>();
        }

        public string Domain { get; set; }

        public int UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Keyword> Keywords { get; set; }
    }
}
