using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ShowRooms.Data;
using System.Text.Encodings.Web;

namespace  ShowRooms.Controllers;

public class TemplateController : Controller
{
    private ShowRoomsContext _vinh;

    public TemplateController(ShowRoomsContext vinh)
    {
        _vinh = vinh;
    }
    // 
    // GET: /HelloWorld/
    //public async Task<IActionResult> Projects(string searchstring)
    //{
    //    ViewData["searchstring"] = searchstring;
//
    //    var carname = from s in _vinh.Car select s;
    //    
    //    if (String.IsNullOrEmpty(searchstring)) 
     //   {
    //         carname = carname.Where(s => s.Fullname!.Contains(searchstring)
    //      
    //    }
     //   return View(await carname.AsNoTracking().ToListAsync());
       
     

   // }
    public async Task<IActionResult> Projects(string searchString)
    {
        if (_vinh.Car == null)
        {
            return Problem("Entity set 'MvcMovieContext.Car'  is null.");
        }

        var movies = from m in _vinh.Car
                     select m;

        if (!String.IsNullOrEmpty(searchString))
        {
            movies = movies.Where(s => s.Fullname!.Contains(searchString));
        }

        return View(await movies.ToListAsync());
    }
    public IActionResult Project_details()
    {
        return View();
    }
    public IActionResult Project_details_C200()
    {
        return View();
    }
    public IActionResult Project_details_GTR()
    {
        return View();
    }
    public IActionResult Project_details_V250()
    {
        return View();
    }
    public IActionResult About()
    {
        return View();
    }
    public IActionResult Blog_details()
    {
        return View();
    }
    public IActionResult Blog()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Sample_inner_page()
    {
        return View();
    }
    public IActionResult Service_details()
    {
        return View();
    }
    public IActionResult Services() {
        return View();   
    }
    // 
    // GET: /HelloWorld/Welcome/ 

}