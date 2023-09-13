using CourseCreator.Core.DTOs;
using CourseCreator.Datalayer.Entities.User;

namespace CourseCreator.Core.Services.Interfaces;

public interface IUserService
{
    #region Admin Panel

    UserForAdminViewModel GetAllUser(int pageId = 1, string filterUsername = "", string filterEmail = "");

    #endregion
}