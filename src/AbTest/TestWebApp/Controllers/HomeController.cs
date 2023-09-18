using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;

namespace TestWebApp.Controllers;

public class HomeController : Controller
{
    #region Methods

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return View();
    } 

    #endregion
}