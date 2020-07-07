using AutoMapper;
using CrudPessoas.DAL;
using CrudPessoas.Models;
using CrudPessoas.Repositories;
using CrudPessoas.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace CrudPessoas.Controllers
{
    public class PessoaController : Controller
    {
        PessoaRepositories pessoaRepositories = new PessoaRepositories();
        // GET: Pessoa
        public ActionResult Index()
        {
            var pessoaViewModel = Mapper.Map<IEnumerable<PessoaModel>, IEnumerable<PessoaViewModel>>(pessoaRepositories.GetAll());
            return View(pessoaViewModel);
        }

        // GET: Pessoa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pessoa/Create
        
        public ActionResult Create()
        {                       
            return View(new PessoaViewModel());
        }
              
        // POST: Pessoa/Create
        [HttpPost]
        public ActionResult Create(PessoaViewModel pessoa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var pessoaModel = Mapper.Map<PessoaViewModel, PessoaModel>(pessoa);
                    pessoaRepositories.Add(pessoaModel);
                }

                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: Pessoa/Edit/5
        
        public ActionResult Edit(PessoaViewModel pessoa)
        {
           
            return View(pessoa);
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        public ActionResult EditMethod(PessoaViewModel pessoa)
        {
            try
            {
                var pessoaModel =Mapper.Map<PessoaViewModel, PessoaModel>(pessoa);
                pessoaRepositories.Update(pessoaModel);
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                ViewBag.ErrorMessage = "Erro ao alterar Pessoa.";
                return RedirectToAction("Index");
            }
        }

        // GET: Pessoa/Delete/5
        public ActionResult Delete(PessoaViewModel pessoa)
        {
            try
            {
                var pessoaModel = Mapper.Map<PessoaViewModel, PessoaModel>(pessoa);
                pessoaRepositories.Remove(pessoaModel);
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                ViewBag.ErrorMessage = "Erro ao excluir Pessoa.";
                return RedirectToAction("Index");                
            }
        }

        
    }
}
