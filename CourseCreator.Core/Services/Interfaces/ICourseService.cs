using CourseCreator.Datalayer.Entities.Course;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace CourseCreator.Core.Services.Interfaces;

public interface ICourseService
{
    #region Group

    List<CourseGroup> GetAllGroup();
    List<SelectListItem> GetGroupForManageCourse();
    IEnumerable<SelectListItem> GetSubGroupForManageCourse(int groupId);

    #endregion
}