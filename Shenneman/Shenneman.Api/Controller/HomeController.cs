//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use Comfrom and Peace
//==================================================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Shenneman.Api.Controller
{
    [ApiController]
    [Route("api/Controller")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() =>
            Ok("Hello World");  
      
    }
}
