using LayoutMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LayoutMVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            Mountains = new List<Mountain>()
            {
                new Mountain()
                {
                    Id = 1,
                    Name = "Bazarduzu",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d2/Bazarduzu_detail.JPG/800px-Bazarduzu_detail.JPG",
                    Height = 4466,
                    Location = "Russian – Gusar border"
                },
                new Mountain()
                {
                    Id = 2,
                    Name = "Shahdagh",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4d/Shakhdag.jpg/800px-Shakhdag.jpg",
                    Height = 4243,
                    Location = "Gusar"
                },
                new Mountain()
                {
                    Id = 3,
                    Name = "Khinalig",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Khinaliqmountain.JPG/800px-Khinaliqmountain.JPG",
                    Height = 3713,
                    Location = "Guba"
                },
                new Mountain()
                {
                    Id = 4,
                    Name = "Tufandag",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/63/Tufanda%C4%9F_1.jpg/800px-Tufanda%C4%9F_1.jpg",
                    Height = 4191,
                    Location = "Gusar"
                },
                new Mountain()
                {
                    Id = 5,
                    Name = "Kapaz",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/24/Murov_mountain_in_Azerbaijan-Caucasus3.jpg",
                    Height = 3066,
                    Location = "Murovdag ridge"
                }
            };
        }

        public List<Mountain> Mountains { get; set; }

        public IActionResult Index()
        {
            ViewData["pageName"] = "Mountains";
            return View(Mountains);
        }

        public IActionResult CardDetails(int id)
        {
            ViewData["pageName"] = "Mountain Details";
            Mountain mountain = Mountains.Find(mountain => mountain.Id == id);
            return View(mountain);
        }
    }
}
