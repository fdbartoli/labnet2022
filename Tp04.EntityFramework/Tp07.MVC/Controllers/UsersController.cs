using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using Newtonsoft.Json;
using Tp07.MVC.Models;

namespace Tp07.MVC.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            var url = "https://randomuser.me/api/?results=10";
            WebClient webClient = new WebClient();   
            var data = webClient.DownloadString(url);
            var rs = JsonConvert.DeserializeObject<Results>(data);
            return View(rs);
        }
    }
}