using CourseCreator.Datalayer.Entities.Course;

namespace CourseCreator.Core.Services.Interfaces;

public interface ICourseService
{
    #region Group

    List<CourseGroup> GetAllGroup();

    #endregion
}