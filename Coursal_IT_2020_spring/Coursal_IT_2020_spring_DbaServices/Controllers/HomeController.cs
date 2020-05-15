using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Coursal_IT_2020_spring_DbaServices.Models;
using Coursal_IT_2020_spring_DbaServices.Infrastructures;
using MongoDB.Driver;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Coursal_IT_2020_spring_DbaServices.Controllers
{
    public class HomeController : Controller
    {
        private readonly PostRepository db;
        public HomeController(PostRepository context)
        {
            db = context;
        }


        public async Task<IActionResult> Index()
        {
            var posts = await db.GetList();
            var model=new IndexViewModel { Posts=posts };
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Post p)
        {
            if (ModelState.IsValid)
            {
                await db.Create(p);
                return RedirectToAction("Index");
            }
            return View(p);
        }

    }
}
