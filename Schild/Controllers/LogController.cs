using Schild.Services;
using Schild.Models;
using Microsoft.AspNetCore.Mvc;
namespace Schild.Controllers;



[ApiController]
[Route("[controller]")]
public class LogController : ControllerBase
{
    
    
    // POST action
    [HttpPost]
    public IActionResult Speichern(Log log)
    {
        // This code will save the pizza and return a result
        LogService.Add(log);
        return Ok("DONE");
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Anfrage Erhalten");
        
        
    }
  
    
}