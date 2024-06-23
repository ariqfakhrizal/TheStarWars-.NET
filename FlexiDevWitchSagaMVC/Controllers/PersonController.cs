using FlexiDevWitchSagaMVC.Models;
using FlexiDevWitchSagaMVC.Services.Interfaces;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FlexiDevWitchSagaMVC.Controllers
{
    public class PersonController : Controller
    {
        private readonly IVillagerService _villagerService;


        // Parameterless constructor required by ASP.NET MVC and Use the UNITY, UNITY.MVC to Regiester due to Dependency Injection
        public PersonController()
        {
        }

        // Constructor with dependency injection
        public PersonController(IVillagerService villagerService)
        {
            _villagerService = villagerService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            // Initialize the view with one empty person model
            var people = new List<Person> { new Person() };
            return View(people);
        }

        [HttpPost]
        public ActionResult Index(List<Person> people)
        {
            double averageKills = _villagerService.CalculateAverageKills(people);
            ViewBag.AverageKills = averageKills;
            return View(people);
        }
    }
}