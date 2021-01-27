using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Peach.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peach.Service.WebAPİ.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserBLL userBLL;
        public UserController(IUserBLL bll)
        {
            userBLL = bll;
        }
        public IActionResult Counter()
        {
            return Ok(userBLL.CounterUser());
        }
    }
}
