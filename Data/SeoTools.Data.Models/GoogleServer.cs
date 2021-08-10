namespace SeoTools.Data.Models
{
    using System.Collections.Generic;

    public class GoogleServer
    {
        public GoogleServer()
        {
            this.Keywords = new HashSet<Keyword>();
        }

        public int Id { get; set; }

        public string Country { get; set; }

        public string Tld { get; set; }

        public string Lang { get; set; }

        public virtual ICollection<Keyword> Keywords { get; set; }
    }
}
