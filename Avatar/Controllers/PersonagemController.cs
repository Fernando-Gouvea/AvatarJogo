using Avatar.Dao;
using Avatar.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avatar.Controllers
{
    public class PersonagemController : Controller
    {
        private PersonagemContext db = new PersonagemContext();
        // GET: Personagem
        public ActionResult Index()
        {
            return View(db.Personagens.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Personagem personagem)
        {
            if (ModelState.IsValid)
            {
                db.Personagens.Add(personagem);
                db.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(personagem);

        }

            public ActionResult Edit(int id)
        {
            return View(db.Personagens.First(p => p.Id == id));

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Personagem personagem)
        {
            if (ModelState.IsValid)
            {
                Personagem personagemUpdate = db.Personagens.First(p => p.Id == personagem.Id);
                personagemUpdate.Nome = personagem.Nome;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personagem);

        }

       
        public ActionResult Details(int id)
        {
            return View(db.Personagens.First(p => p.Id == id));
        }

    }
}