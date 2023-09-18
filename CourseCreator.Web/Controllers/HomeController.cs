using CourseCreator.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CourseCreator.Web.Controllers;

public class HomeController : Controller
{
    private readonly ICourseService _courseService;

    public HomeController(ICourseService courseService)
    {
        _courseService = courseService;
    }
    
    public IActionResult Index()
    {
        return View();
    }

    
    public IActionResult GetSubGroups(int id)
    {
        List<SelectListItem> list = new List<SelectListItem>()
        {
            new SelectListItem(){Text = "Please choose one", Value = ""}
        };
        list.AddRange(_courseService.GetSubGroupForManageCourse(id));
       
        return Json(new SelectList(list, "Value", "Text"));
    }
}