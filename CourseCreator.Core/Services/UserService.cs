using CourseCreator.Core.DTOs;
using CourseCreator.Core.Services.Interfaces;
using CourseCreator.Datalayer.Context;
using CourseCreator.Datalayer.Entities.User;

namespace CourseCreator.Core.Services;

public class UserService : IUserService
{
    private readonly CourseCreatorContext _context;

    public UserService(CourseCreatorContext context)
    {
        _context = context;
    }


    public UserForAdminViewModel GetAllUser(int pageId = 1, string filterUsername = "", string filterEmail = "")
    {
        IQueryable<User> result = _context.Users;

        if (!string.IsNullOrEmpty(filterEmail))
            result = result.Where(u => u.Email.Contains(filterEmail));

        if (!string.IsNullOrEmpty(filterUsername))
            result = result.Where(u => u.Username.Contains(filterUsername));

        
        //pagination
        int take = 1;
        int skip = (pageId - 1) * take;

        UserForAdminViewModel list = new UserForAdminViewModel();
        list.CurrentPage = pageId;
        list.CurrentPage = result.Count() / take;
        list.Users = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList();

        return list;
    }
}