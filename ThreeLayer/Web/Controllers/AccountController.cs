using BUS.IServices;
using DAL.Entities;
using DAL.IDALServices;
using Microsoft.AspNetCore.Mvc;


namespace Web.Controllers;
[Route("[controller]")]
[ApiController]
public class AccountController : Controller
{
    private readonly IQLAccountService _QLAccountService;
    public AccountController(IQLAccountService accountService)
    {
        _QLAccountService = accountService;
    }
    [HttpGet]
    public List<Account> GetAllAccount()
    {
        return _QLAccountService.GetAllAccount();
    }

    [HttpPost]
    public IActionResult CreateAccount(Account newAccount)
    {
        try
        {
            _QLAccountService.CreateAccount(newAccount);
            return Ok();
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
        
    }
}

