using CourseCreator.Core.Services.Interfaces;
using CourseCreator.Datalayer.Context;
using CourseCreator.Datalayer.Entities.Course;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CourseCreator.Core.Services;

public class CourseService : ICourseService
{
    private readonly CourseCreatorContext _context;

    public CourseService(CourseCreatorContext context)
    {
        _context = context;
    }

    public List<CourseGroup> GetAllGroup()
    {
        return _context.CourseGroups.ToList();
    }

    public List<SelectListItem> GetGroupForManageCourse()
    {
        return _context.CourseGroups.Where(g => g.ParentId == null)
            .Select(g => new SelectListItem()
            {
                Text = g.GroupTitle,
                Value = g.GroupId.ToString()
            }).ToList();
    }

    public IEnumerable<SelectListItem> GetSubGroupForManageCourse(int groupId)
    {
        return _context.CourseGroups.Where(g => g.ParentId == groupId)
            .Select(g => new SelectListItem()
            {
                Text = g.GroupTitle,
                Value = g.GroupId.ToString()
            }).ToList();
    }

    public List<SelectListItem> GetTeachers()
    {
       return _context.userRoles.Where(r => r.RoleId == 2).Include(r => r.User)
            .Select(u => new SelectListItem()
            {
                Value = u.UserId.ToString(),
                Text = u.User.Username
            }).ToList();
    }
}