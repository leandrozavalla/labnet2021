using LabNet2021.TP4.Entities;
using LabNet2021.TP4.Logic;
using LabNet2021.TP7.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabNet2021.TP7.MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic shippersLogic = new ShippersLogic();

        // GET: Shippers
        public ActionResult Index()
        {
            List<Shippers> shippers = shippersLogic.GetAll();

            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                ID = s.ShipperID,
                Company = s.CompanyName,
                Phone = s.Phone
            }).ToList();

            return View(shippersView);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ShippersView shippersView)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                Shippers shipperEntity = new Shippers
                {
                    CompanyName = shippersView.Company,
                    Phone = shippersView.Phone
                };

                shippersLogic.Add(shipperEntity);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult Update(int id, string company, string phone)
        {
            ViewBag.ID = id;
            ViewBag.Company = company;
            ViewBag.Phone = phone;

            return View("~/Views/Shippers/Insert.cshtml");
        }

        [HttpPost]
        public ActionResult Update(ShippersView shippersView)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                Shippers shipperEntity = new Shippers
                {
                    ShipperID = shippersView.ID,
                    CompanyName = shippersView.Company,
                    Phone = shippersView.Phone
                };

                shippersLogic.Update(shipperEntity);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult Delete(int id)
        {
            shippersLogic.Delete(id);

            return RedirectToAction("Index");
        }
    }
}