﻿using Microsoft.AspNetCore.Mvc;

namespace CalculaJuros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {   
        // GET: api/ShowMeTheCode/5
        [HttpGet()]
        public ActionResult<string> Get()
        {
            return @"https://cdcunha.visualstudio.com/DefaultCollection/CalculaJuros/_git/CalculaJuros";
        }
    }
}
