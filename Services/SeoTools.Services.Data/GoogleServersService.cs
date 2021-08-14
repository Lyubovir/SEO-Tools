using SeoTools.Data.Common.Repositories;
using SeoTools.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeoTools.Services.Data
{
    public class GoogleServersService : IGoogleCategoriesService
    {
        private readonly IRepository<GoogleServer> googleServersRepository;

        public GoogleServersService(IRepository<GoogleServer> googleServersRepository)
        {
            this.googleServersRepository = googleServersRepository;
        }

        public IEnumerable<KeyValuePair<int, string>> GetAllGoogleCategories()
        {
            return this.googleServersRepository.All().Select(x => new
            {
                x.Id,
                x.Country,
                x.Tld,
            }).ToList().Select(x => new KeyValuePair<int, string>(x.Id, $"{x.Country} - google.{x.Tld}"));
        }
    }
}
