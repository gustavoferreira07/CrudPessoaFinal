using CrudPessoas.Repositories;
using CrudPessoas.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudPessoas.Controllers
{
    public class DashboardController : Controller
    {
        GraficoRepositories GraficoRepositories = new GraficoRepositories();
        DashboardRepositories dashboardRepositories = new DashboardRepositories();
        // GET: Dashboard
        public ActionResult Index()
        {
            var dashModel = dashboardRepositories.Get();
            return View(dashModel);
        }

        // GET: Dashboard/Details/5
        [HttpGet]
        public ActionResult GraficoPessoa()
        {
            var graficoModel = GraficoRepositories.GetAll();
            return Json(graficoModel, JsonRequestBehavior.AllowGet);
        }

        // GET: Dashboard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dashboard/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
