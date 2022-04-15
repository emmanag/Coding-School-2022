using Gas_Station.EF.Context;
using Gas_Station.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gas_Station.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController
    {
        private GasStationContext _context;
        public LoginController(GasStationContext context)
        {
            _context = context;
        }

        [HttpGet("{username}/{password}")]
        public async Task<LoginViewModel> Get(string username, string password)
        {
            LoginViewModel user = new();
            var found = await _context.Logins.FirstOrDefaultAsync(user => user.Username == username && user.Password == password);
            if (found == null)
                return user;
            user.Username = found.Username;
            user.EmployeeType = found.EmployeeType;
            user.IsLogin = true;
            return user;
        }
    }
}
