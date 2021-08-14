namespace SeoTools.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using SeoTools.Data;
    using SeoTools.Data.Common.Repositories;
    using SeoTools.Data.Models;
    using SeoTools.Services.Data;
    using SeoTools.Web.ViewModels.CheckPosition;

    public class CheckPositionController : Controller
    {
        private readonly IGoogleCategoriesService googleCategoriesService;

        public CheckPositionController(IGoogleCategoriesService googleCategoriesService)
        {
            this.googleCategoriesService = googleCategoriesService;
        }

        public IActionResult CheckKeyword(string domain, string keyword, string countryId, string shit)
        {
            this.ViewBag.Site = domain;

            return this.View();
        }

        public IActionResult Check()
        {
            var inputModel = new CheckInputModel
            {
                GoogleCategories = this.googleCategoriesService.GetAllGoogleCategories(),
            };

            return this.View(inputModel);
        }

        [HttpPost]
        public IActionResult Check(CheckInputModel input)
        {
            if (this.ModelState.IsValid == false)
            {
                input.GoogleCategories = this.googleCategoriesService.GetAllGoogleCategories();
                return this.View(input);
            }

            return this.RedirectToAction("CheckKeyword", new
            {
                domain = input.Domain,
                keyword = input.Keyword,
                countryId = input.CountryId,
            });

        }
    }
}
