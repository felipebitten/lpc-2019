using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ContadeLuz.Models;

namespace ContadeLuz.Controllers
{
    public class ContasController: Controller
    {

        private IContaRepository repository;

        public ContasController(IContaRepository repository) 
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            var listContas = repository.GetAll();
            ViewBag.Maximo = repository.Maior();
            ViewBag.Minimo = repository.Menor();
            return View(listContas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Conta conta)
        {
            repository.Create(conta);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var conta = repository.GetByID(id);
            return View(conta);
        }

        [HttpPost]
        public IActionResult Edit(Conta conta)
        {
            repository.Update(conta);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("Index");
        }

    

    }
}