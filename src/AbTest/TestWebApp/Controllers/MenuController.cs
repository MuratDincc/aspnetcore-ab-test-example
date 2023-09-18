using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using TestWebApp.Constants;

namespace TestWebApp.Controllers;

public class MenuController : Controller
{
    #region Fields
    
    private readonly IFeatureManager _featureManager;

    #endregion

    #region Ctor
    
    public MenuController(IFeatureManager featureManager)
    {
        _featureManager = featureManager;
    }

    #endregion

    #region Methods

    [HttpGet]
    public async Task<PartialViewResult> Load()
    {
        if (await _featureManager.IsEnabledAsync(FeatureKeyConstants.MenuView))
            return PartialView("_Menu_2");
        else
            return PartialView("_Menu_1");
    }

    #endregion
}