﻿using System.Web.Mvc;
using System.Linq;
using EPiServer.Web;
using EPiServer.Web.Routing;
using AlloyTraining.Models.NorthwindEntities;
using AlloyTraining.Models.ViewModels;
using EPiServer.ServiceLocation;
using AlloyTraining.Models.Pages;
using EPiServer.Core;
using EPiServer;

namespace AlloyTraining.Controllers
{
    // by implementing IRenderTemplate<Category>, this becomes
    // the "page template" for a Category entity
    public class CategoryController : Controller, IRenderTemplate<Category>
    {
        public ActionResult Index()
        {
            // Note: the GetRoutedData extension method uses the partial router to 
            // convert a URL segment into a Category instance. 
            var category = Request.RequestContext.GetRoutedData<Category>();

            var northwindPages = ServiceLocator.Current.GetInstance<IContentLoader>()
                .GetChildren<NorthwindPage>(ContentReference.StartPage);

            NorthwindPage currentPage = null;
            if (northwindPages.Any())
            {
                currentPage = northwindPages.First();
            }

            var model = new NorthwindPageViewModel(currentPage);
            model.Category = category;

            return View(model);
        }
    }
}