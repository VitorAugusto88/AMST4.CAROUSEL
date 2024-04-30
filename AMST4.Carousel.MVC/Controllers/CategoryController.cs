using AMST4.Carousel.MVC.Context;
using Microsoft.AspNetCore.Mvc;

namespace AMST4.Carousel.MVC.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDataContext _applicationDataContext;
        public CategoryController(ApplicationDataContext applicationDataContext) { _applicationDataContext = applicationDataContext; }

            
        public IActionResult Categorylist()
        {
            var categories = _applicationDataContext.Category.ToList();

            return View(categories);
        }
    }
}
