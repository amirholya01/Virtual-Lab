using CourseCreator.Core.Services.Interfaces;
using CourseCreator.Datalayer.Entities.Course;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CourseCreator.Web.Pages.Admin.Courses;

public class CreateCourse : PageModel
{
    private readonly ICourseService _courseService;

    public CreateCourse(ICourseService courseService)
    {
        _courseService = courseService;
    }
    
    [BindProperty]
    public Course Course { get; set; }
    
 
    public void OnGet()
    {
        var groups = _courseService.GetGroupForManageCourse();
        ViewData["Groups"] = new SelectList(groups, "Value", "Text");

        var subGroups = _courseService.GetSubGroupForManageCourse(int.Parse(groups.First().Value));
        ViewData["SubGroups"] = new SelectList(subGroups, "Value", "Text");

        var teachers = _courseService.GetTeachers();
        ViewData["Teachers"] = new SelectList(teachers, "Value", "Text");

        var levels = _courseService.GetLevels();
        ViewData["Levels"] = new SelectList(levels, "Value", "Text");

        var statuses = _courseService.GetStatus();
        ViewData["Statuses"] = new SelectList(statuses, "Value", "Text");
    }

    public IActionResult OnPost(IFormFile imgCourseUp, IFormFile demoUp)
    {
        return Page();
    }

  
}