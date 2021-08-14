namespace SeoTools.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using SeoTools.Data.Common.Models;

    public class Keyword : BaseDeletableModel<int>
    {
        public Keyword()
        {
            this.Positions = new HashSet<KeywordPosition>();
        }

        [Required]
        public string Text { get; set; }

        public int GoogleServerId { get; set; }

        public virtual GoogleServer GoogleServer { get; set; }

        public int SiteId { get; set; }

        public virtual Site Site { get; set; }

        public virtual ICollection<KeywordPosition> Positions { get; set; }
    }
}
