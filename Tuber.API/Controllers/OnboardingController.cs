using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tuber.API.Controllers
{
    [Route("api/[controller]")]
    public class OnboardingController : Controller
    {


        // POST api/values
        [HttpPost]
        [Route("SignUp")]

        public void SignUp([FromBody] string username, string password, string confirmPassword)
        {
        }

        // POST api/values
        [HttpPost]
        [Route("SignIn")]
        public void SignIn([FromBody] string username, string password)
        {
        }

    }
}

