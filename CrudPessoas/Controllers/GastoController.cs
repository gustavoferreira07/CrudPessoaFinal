using AutoMapper;
using CrudPessoas.Models;
using CrudPessoas.Repositories;
using CrudPessoas.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudPessoas.Controllers
{
    public class GastoController : Controller
    {
        GastoRepositories gastoRepositories = new GastoRepositories();
        // GET: Gasto
        public ActionResult Index()
        {
            var gastoViewmodel = Mapper.Map<IEnumerable<GastoModel>, IEnumerable<GastoViewModel>>(gastoRepositories.GetAll());

            return View(gastoViewmodel);
        }

        // GET: Gasto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Gasto/Create
        public ActionResult Create(PessoaViewModel pessoa)
        {
            return View(pessoa);
        }

        // POST: Gasto/Create
        [HttpPost]
        public ActionResult CreateGasto(PessoaViewModel pessoa,   HttpPostedFileBase gastos)
        {            
            try
            {
                ///Salva o arquivo no servidor da aplicação
                var diretorioServer = Path.GetFullPath(gastos.FileName);                
                gastos.SaveAs(diretorioServer);                

                ///Converte os dados do excel para o objeto GastosModel e sala no banco de dados
                Infra.ExcelInfra.ExcelService excelService = new Infra.ExcelInfra.ExcelService();
                var pessoaModel = Mapper.Map<PessoaViewModel, PessoaModel>(pessoa);                
                var todosOsGastos = excelService.RetornaGastos(diretorioServer, pessoaModel);
                gastoRepositories.AddRange(todosOsGastos);

                return RedirectToAction("Index");
            }
            catch(Exception exception)
            {
                ViewBag.ErrorMessage = "Insira um documento no padrão correto!";
                return RedirectToAction("Index");                
            }
        }
        // GET: Gasto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Gasto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gasto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gasto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
