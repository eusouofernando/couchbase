using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fernando.TesteCouchBase.Domain;
using Fernando.TesteCouchBase.Domain.Entities;
using Fernando.TesteCouchBase.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fernando.TesteCouchBase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        protected readonly IUserRepository _userRepository;

        public ValuesController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        //[Route("api/doSomething")]
        public IActionResult DoSomething()
        {
            var user = new User();
            user.Id = "user::" + Guid.NewGuid().ToString();
            user.CountryCode = "DE";
            user.Password = "letmein";
            user.UserName = "Rudolph ".ToLower().Trim();

            _userRepository.Save(user);

            // read after write
            var savedUser = _userRepository.FindById(user.Id);
            return Ok(savedUser);
        }        
    }
}
