using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Tp04.EntityFramework.Logic;
using Tp08.WebApi.Data;
using Tp08.WebApi.Models;

namespace Tp08.WebApi.Controllers
{
    public class SuppliersController : ApiController
    {
        SuppliersLogic logic = new SuppliersLogic();

        // GET
        public IHttpActionResult GetSupplier()

    }
}