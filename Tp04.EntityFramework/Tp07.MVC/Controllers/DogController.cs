using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Tp04.EntityFramework.Entities;
using Tp04.EntityFramework.Logic;
using Tp07.MVC.Models;

namespace Tp07.MVC.Controllers
{
    public class DogController : Controller
    {
        // GET: Dog
        readonly DogApiLogic logic = new DogApiLogic();
        public async Task<ActionResult> Index()
        {
            Dog dog = await logic.Get();
            DogView dogView = new DogView()
            {
                Picture = dog.Message
            };

            return View(dogView);
        }
    }
}