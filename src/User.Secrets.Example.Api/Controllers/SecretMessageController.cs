using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace User.Secrets.Example.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretMessageController : ControllerBase
    {
        private readonly string _secretMessage;

        public SecretMessageController(IConfiguration configuration)
        {
            _secretMessage = configuration["SECRET_MESSAGE"];
        }

        [HttpGet]
        public IActionResult GetSecretMessage()
        {
            return new OkObjectResult(new
            {
                SecretMessage = _secretMessage
            });
        }
    }
}
