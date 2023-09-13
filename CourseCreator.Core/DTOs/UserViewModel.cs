using CourseCreator.Datalayer.Entities.User;

namespace CourseCreator.Core.DTOs;

public class UserForAdminViewModel
{
    public List<User> Users { get; set; }
    public int CurrentPage { get; set; }
    public int PageCount { get; set; }
}