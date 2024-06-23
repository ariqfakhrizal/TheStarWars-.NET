using FlexiDevWitchSagaMVC.Services.Interfaces;
using System.Web.Mvc;

namespace FlexiDevWitchSagaMVC.Controllers
{
    public class WitcherController : Controller
    {
        private readonly IVillagerService _villagerService;

        public WitcherController(IVillagerService villagerService)
        {
            _villagerService = villagerService;
        }
    }
}