using ProjetoTccDoacaoDeSangue.Dao;
using ProjetoTccDoacaoDeSangue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTccDoacaoDeSangue.Controllers
{
    public class ClienteController: Controller
    {
        public ActionResult Index()
        {
            var clientes = new ClienteDao().Buscar();
            return View(clientes);
        }

        public ActionResult Novo()
        {
            ViewBag.TipoSanguineos = new SelectList(new TipoSanguineoDao().Buscar().ToDictionary(x => x.SangueID, x => x.TipoDeSangue), "Key", "Value");
            return View();
        }

        [HttpPost]
        public ActionResult Novo(Cliente ObjCliente)
        {
            new ClienteDao().Gravar(ObjCliente);
            return RedirectToAction("Index", "Cliente");
        }

        public ActionResult Detalhe(int id)
        {
            Cliente cliente = new ClienteDao().Buscar(id);
            return View(cliente);
        }
        public ActionResult Editar(int id)
        {
            var cliente = new ClienteDao().Buscar(id);
            return View(cliente);
        }
        [HttpPost]
        public ActionResult Editar(Cliente ObjCliente)
        {
            new ClienteDao().Alterar(ObjCliente);
            return RedirectToAction("Index", "Cliente");
        }

        public ActionResult Excluir(int id)
        {
            new ClienteDao().Excluir(id);
            return RedirectToAction("Index");

        }
    }
}