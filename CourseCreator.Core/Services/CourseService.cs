using CourseCreator.Core.Services.Interfaces;
using CourseCreator.Datalayer.Context;
using CourseCreator.Datalayer.Entities.Course;

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
}