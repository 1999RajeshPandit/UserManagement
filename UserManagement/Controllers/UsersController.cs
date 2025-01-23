using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using UserManagement.Dtos;
using UserManagement.Models;
using UserManagement.Repositories;

namespace UserManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //private readonly IUserRepository _userRepository;
        private readonly ILogger<UsersController> _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        public UsersController(
            ILogger<UsersController> _logger,
            IMapper _mapper,
            UserManager<AppUser> userManager
            )
        {
            //this._userRepository = _userRepository;
            this._logger = _logger;
            this._mapper = _mapper;
            this._userManager = userManager;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(CreateUserDto userDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                AppUser user = _mapper.Map<AppUser>(userDto);

                var res = await _userManager.CreateAsync(user, userDto.Password);
                if (res == null)
                {
                    return BadRequest("Failed to register user!!!!!");
                }
                return Ok(res);
            }
            catch (Exception ex) {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        
    }
}
