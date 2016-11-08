using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using System;

[Route("/")]
public class HomeController : Controller
{
    public DB db;
    public HomeController(DB db){
        this.db = db;
    }

    [HttpGet]
    public IActionResult Root()
    {
        IEnumerable<Models.BandB> bbs = db.BBs.ToList();
        return View("Index", bbs);
        // Console.WriteLine(HttpContext);
        // ViewData["Message"] = "Some extra info can be sent to the view";
        // ViewData["Username"] = username;
        // return View("Index"); // View(new Student) method takes an optional object as a "model", typically called a ViewModel
    }
}