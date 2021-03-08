using BusinessLogic.Dtos;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic.User
{
    public class UserService : IUserService
    {
        private readonly BenefitsContext _benefitsContext;

        public UserService(BenefitsContext benefitsContext)
        {
            _benefitsContext = benefitsContext;
        }

        public async Task<IEnumerable<UserDto>> GetUsers()
        {
            return await _benefitsContext.Users.Select(user => new UserDto()
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname
            }).ToListAsync();
        }
    }
}
