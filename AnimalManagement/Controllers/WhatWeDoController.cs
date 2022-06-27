using Microsoft.AspNetCore.Mvc;

namespace AnimalManagement.Controllers
{
    public class WhatWeDoController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
