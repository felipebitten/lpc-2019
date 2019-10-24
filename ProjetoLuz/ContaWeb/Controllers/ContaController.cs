using ContaDomain.Entities;
using ContaRepository.Interfaces;
using ContaRepository.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ContaWeb.Controllers
{
  public class ContaController : Controller
    {
        
        private IContaRepository repository;

        private IImovelRepository repositoryImovel;

        public ContaController(IContaRepository repository, IImovelRepository repositoryImovel) 
        {
            this.repository = repository;
            this.repositoryImovel = repositoryImovel;
        }

        public IActionResult Index()
        {
            var listContas = repository.Getall();
            ViewBag.Maximo = repository.Maior();
            ViewBag.Minimo = repository.Menor();
            return View(listContas);
        }

        public IActionResult Create()
        {
            ViewBag.ImoveisConta = repositoryImovel.Getall();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Conta conta)
        {
            conta.imovel = repositoryImovel.GetById(conta.imovel.id);
            repository.Create(conta);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            ViewBag.ImoveisConta = repositoryImovel.Getall();
            var conta = repository.GetById(id);
            return View(conta);
        }

        [HttpPost]
        public IActionResult Edit(Conta conta)
        {
            conta.imovel = repositoryImovel.GetById(conta.imovel.id);
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