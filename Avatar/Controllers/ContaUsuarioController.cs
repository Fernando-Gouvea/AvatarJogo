using Avatar.Dao;
using Avatar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avatar.Controllers
{
    public class ContaUsuarioController : Controller
    {
        private ContaUsuarioContext db = new ContaUsuarioContext();
        // GET: ContaUsuario
        public ActionResult Index()
        {
            return View(db.ContasUsuarios.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContaUsuario contaUsuario)
        {
            if (ModelState.IsValid)
            {
                db.ContasUsuarios.Add(contaUsuario);
                db.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(contaUsuario);

        }

        public ActionResult Edit(int id)
        {
            return View(db.ContasUsuarios.First(p => p.Id == id));

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ContaUsuario contaUsuario)
        {
            if (ModelState.IsValid)
            {
                ContaUsuario contaUpdate = db.ContasUsuarios.First(p => p.Id == contaUsuario.Id);
                contaUpdate.NomeUsuario = contaUsuario.NomeUsuario;
                contaUpdate.Email = contaUsuario.Email;
                contaUpdate.Senha = contaUsuario.Senha;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contaUsuario);

        }


        public ActionResult Details(int id)
        {
            return View(db.ContasUsuarios.First(p => p.Id == id));

        }

        public ActionResult Delete(int id)
        {
            return View(db.ContasUsuarios.First(p => p.Id == id));

        }

        [HttpPost , ActionName("Delete") ]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {

            var conta = db.ContasUsuarios.First(c => c.Id == id);
            db.ContasUsuarios.Remove(conta);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}