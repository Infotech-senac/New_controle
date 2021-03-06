﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using New_controle.Models.EF;

namespace New_controle.Controllers
{
    [Authorize]
    public class Reposicao_estoqueController : Controller
    {
        private APPcontroleContainer db = new APPcontroleContainer();

        // GET: Reposicao_estoque
        public async Task<ActionResult> Index()
        {
            return View(await db.Reposicao_estoqueSet.ToListAsync());
        }

        // GET: Reposicao_estoque/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reposicao_estoque reposicao_estoque = await db.Reposicao_estoqueSet.FindAsync(id);
            if (reposicao_estoque == null)
            {
                return HttpNotFound();
            }
            return View(reposicao_estoque);
        }

        // GET: Reposicao_estoque/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reposicao_estoque/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Shampoo,Condicionador,Sabonete")] Reposicao_estoque reposicao_estoque)
        {
            if (ModelState.IsValid)
            {
                db.Reposicao_estoqueSet.Add(reposicao_estoque);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(reposicao_estoque);
        }

        // GET: Reposicao_estoque/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reposicao_estoque reposicao_estoque = await db.Reposicao_estoqueSet.FindAsync(id);
            if (reposicao_estoque == null)
            {
                return HttpNotFound();
            }
            return View(reposicao_estoque);
        }

        // POST: Reposicao_estoque/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Shampoo,Condicionador,Sabonete")] Reposicao_estoque reposicao_estoque)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reposicao_estoque).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(reposicao_estoque);
        }

        // GET: Reposicao_estoque/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reposicao_estoque reposicao_estoque = await db.Reposicao_estoqueSet.FindAsync(id);
            if (reposicao_estoque == null)
            {
                return HttpNotFound();
            }
            return View(reposicao_estoque);
        }

        // POST: Reposicao_estoque/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Reposicao_estoque reposicao_estoque = await db.Reposicao_estoqueSet.FindAsync(id);
            db.Reposicao_estoqueSet.Remove(reposicao_estoque);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
