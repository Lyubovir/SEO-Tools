using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeoTools.Web.ViewModels.CheckPosition
{
    public class CheckInputModel
    {
        [Required]
        [MinLength(4)]
        public string Domain { get; set; }

        [Required]
        [MinLength(2)]
        public string Keyword { get; set; }

        public int CountryId { get; set; }

        public IEnumerable<KeyValuePair<int, string>> GoogleCategories { get; set; }
    }
}
