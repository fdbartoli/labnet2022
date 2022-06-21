using System.Collections.Generic;
using System.Web.Mvc;
using Tp04.EntityFramework.Entities;
using Tp04.EntityFramework.Logic;
using Tp07.MVC.Models;
using System.Linq;
using System;

namespace Tp07.MVC.Controllers
{
    public class SuppliersController : Controller
    {
        SuppliersLogic logic = new SuppliersLogic();
        // GET: Suppliers
        public ActionResult Index()
        {
            List<Suppliers> suppliers = logic.GetAll();
            List<SuppliersView> suppliersView = suppliers.Select(s => new SuppliersView
            {
                Id = s.SupplierID,
                CompanyName = s.CompanyName,
                ContactName = s.ContactName,
                Phone = s.Phone
            }).ToList();
            return View(suppliersView);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                logic.Remove(id);
                return RedirectToAction("Index");
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)

            {
                return RedirectToAction("ErrorFK", "Error");
            }
        }


        public ActionResult InsertUpdate(int id)
        {
            if (id == 0)
            {
                return View(new SuppliersView { });
            }

            else
            {
                try
                {
                    Suppliers supplier = logic.GetAll().FirstOrDefault(s => s.SupplierID == id);
                    SuppliersView suppliersView = new SuppliersView
                    {
                        Id = supplier.SupplierID,
                        CompanyName = supplier.CompanyName,
                        ContactName = supplier.ContactName,
                        Phone = supplier.Phone
                    };
                    return View(suppliersView);
                }
                catch (Exception ex)
                {
                    return RedirectToAction("Index", "Error");
                }
            }

        }

        [HttpPost]
        public ActionResult InsertUpdate(SuppliersView supplier)
        {
            if (!ModelState.IsValid)
            {
                return View(supplier);
            }
            try
            {
                Suppliers supplierEntity = new Suppliers
                {
                    SupplierID = supplier.Id,
                    CompanyName = supplier.CompanyName,
                    ContactName = supplier.ContactName,
                    Phone = supplier.Phone,
                };
                if (supplier.Id == 0)
                {
                    logic.Add(supplierEntity);
                }
                else
                {
                    logic.Update(supplierEntity);
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }
    }
}

















