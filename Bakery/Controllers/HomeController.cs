using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Bakery.Controllers
{
    public class HomeController : Controller
    {
      private readonly BakeryContext _db;
      private readonly UserManager<ApplicationUser> _userManager;

      public HomeController(UserManager<ApplicationUser> userManager, BakeryContext db)
      {
        _userManager = userManager;
        _db = db;
      }

      [HttpGet("/")]
      public async Task<ActionResult> Index()
      {
        // Flavor logic
        
        Dictionary<string,object[]> model = new Dictionary<string, object[]>();
        
        // Treat logic
        string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
        if (currentUser != null)
        {
          Treat[] treats = _db.Treats
                      .Where(entry => entry.User.Id == currentUser.Id)
                      .ToArray();
          model.Add("treats", treats);

          Flavor[] flavors = _db.Flavors
                      .Where(entry => entry.User.Id == currentUser.Id)
                      .ToArray();
          model.Add("flavors", flavors);
        } else {
          Treat[] treats = _db.Treats.ToArray();
          Flavor[] flavors = _db.Flavors.ToArray();
          model.Add("treats", treats);
          model.Add("flavors", flavors);
        }
        return View(model);
      }

      public ActionResult Search(string query)
      {
        Dictionary<string,object[]> model = new Dictionary<string, object[]>();
        Treat[] treats = _db.Treats.Where(treat => treat.Name.Contains(query)).ToArray();
        model.Add("treats", treats);
        Flavor[] flavors = _db.Flavors.Where(flavor => flavor.Name.Contains(query)).ToArray();
        model.Add("flavors", flavors);
        return View(model);
      }
    }
}