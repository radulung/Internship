using BusinessLogic.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.User
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetUsers();
    }
}
