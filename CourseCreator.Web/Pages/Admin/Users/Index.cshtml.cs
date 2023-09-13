using CourseCreator.Core.DTOs;
using CourseCreator.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseCreator.Web.Pages.Admin.Users;

public class Index : PageModel
{
    private readonly IUserService _userService;

    public Index(IUserService userService)
    {
        _userService = userService;
    }
    public UserForAdminViewModel UserForAdminViewModel { get; set; }  
    public void OnGet(int pageId = 1, string filterUsername = "", string filterEmail = "")
    {
        UserForAdminViewModel = _userService.GetAllUser(pageId, filterUsername, filterEmail);
    }
}