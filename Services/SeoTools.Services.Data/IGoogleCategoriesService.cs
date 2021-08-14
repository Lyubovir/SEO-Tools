using System;
using System.Collections.Generic;
using System.Text;

namespace SeoTools.Services.Data
{
    public interface IGoogleCategoriesService
    {
        IEnumerable<KeyValuePair<int, string>> GetAllGoogleCategories();
    }
}
