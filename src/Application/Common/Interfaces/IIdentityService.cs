using gis_photo_sharing_app.Application.Common.Models;
using System.Threading.Tasks;

namespace gis_photo_sharing_app.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(string userId);

        Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password);

        Task<Result> DeleteUserAsync(string userId);
    }
}
