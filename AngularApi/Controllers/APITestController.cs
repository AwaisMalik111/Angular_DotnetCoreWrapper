using CoreModels.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APITestController : ControllerBase
    {
        private readonly ITest _test;

        public APITestController(ITest test) {
            _test = test;
        }
        [HttpPost("TestMethod")]
        public void test([FromBody] Test obj) {
            _test.TestInfra(obj);
        }
        [HttpGet("TestGet")]
        public bool TestGet() {
            return true;
        }
    }
}
