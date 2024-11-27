using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using SalesTransaction.Models;

namespace SalesTransaction.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AccountController : Controller
{
    
  
    [HttpPost]
    public IActionResult Login(){
        return Ok();
    }
}






