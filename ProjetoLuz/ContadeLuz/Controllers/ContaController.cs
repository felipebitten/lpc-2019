using ContadeLuz.Models;
using ContaRepository.Repository;
using ContaRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ContaDomain.Entities;

namespace ContadeLuz.Controllers
{
    public class ContaController : Controller
    {
        
        private IContaRepository repository;

        public ContaController(IContaRepository repository) 
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