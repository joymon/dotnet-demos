using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AnotherControllersAssembly
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnotherAPIController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "AnotherAPI - value1", "AnotherAPI - value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}