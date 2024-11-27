using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using SalesTransaction.Models;
using SalesTransaction.Repositories;
using SalesTransaction.UserModels;

namespace SalesTransaction.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AccountController : Controller
{
    private readonly IRepository _repo;

    public AccountController(IRepository repo){
        _repo = repo;
    }
  
    [HttpPost]
    public IActionResult Login([FromBody] LoginRequestDTO request){

        var result = _repo.login(request);

        return Ok();
    }
}






