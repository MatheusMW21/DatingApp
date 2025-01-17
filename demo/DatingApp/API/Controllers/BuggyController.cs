using System;
using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class BuggyController(DataContext context)  : BaseApiController 
{
    [HttpGet("auth")]
    public ActionResult <string> GetAuth()
    {
        return "secret text";
    }
}
