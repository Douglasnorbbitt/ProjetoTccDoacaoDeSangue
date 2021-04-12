using ProjetoTccDoacaoDeSangue.Dao;
using ProjetoTccDoacaoDeSangue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTccDoacaoDeSangue.Controllers
{
    public class TipoSanguineoController: Controller
    {

        public ActionResult Index()
        {
            var tipoSanguineos = new TipoSanguineoDao().Buscar();
            return View(tipoSanguineos);
        }

        public ActionResult Novo()
        {
            return View();
        }


        [HttpPost]
            public ActionResult Novo(TipoSanguineo ObjTipoSanguineo)
            {
                new TipoSanguineoDao().Gravar(ObjTipoSanguineo);
                return RedirectToAction("Index", "TipoSanguineo");
            }

            public ActionResult Detalhe(int id)
            {
                TipoSanguineo tipoSanguineo = new TipoSanguineoDao().Buscar(id);
                return View(tipoSanguineo);
            }
            public ActionResult Editar(int id)
            {
                var tipoSanguineo = new TipoSanguineoDao().Buscar(id);
                return View(tipoSanguineo);
            }
            [HttpPost]
            public ActionResult Editar(TipoSanguineo ObjTipoSanguineo)
            {
                new TipoSanguineoDao().Alterar(ObjTipoSanguineo);
                return RedirectToAction("Index", "TipoSanguineo");
            }

            public ActionResult Excluir(int id)
            {
                new TipoSanguineoDao().Excluir(id);
                return RedirectToAction("Index");

            }
        }
    }