using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMVC.Models;

namespace WebMVC.Areas.Admin.Controllers;
[Area("admin")]
[Route("admin/product")]
public class ProductController : Controller
{
    private readonly DatabaseContext databaseContext;

    public ProductController(DatabaseContext databaseContext)
    {
        this.databaseContext = databaseContext;
    }

    [Route("index")]
    [Route("")]
    public async Task<IActionResult> Index()
    {
        var products = await databaseContext.Products.ToListAsync();
        ViewBag.products = products;
        return View("index");
    }

}
