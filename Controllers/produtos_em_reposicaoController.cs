using System;
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
    public class produtos_em_reposicaoController : Controller
    {
        private APPcontroleContainer db = new APPcontroleContainer();

        // GET: produtos_em_reposicao
        public async Task<ActionResult> Index()
        {
            return View(await db.produtos_em_reposicaoSet.ToListAsync());
        }

        // GET: produtos_em_reposicao/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produtos_em_reposicao produtos_em_reposicao = await db.produtos_em_reposicaoSet.FindAsync(id);
            if (produtos_em_reposicao == null)
            {
                return HttpNotFound();
            }
            return View(produtos_em_reposicao);
        }

        // GET: produtos_em_reposicao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: produtos_em_reposicao/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Shampoo,Condicionador,Sabonete")] produtos_em_reposicao produtos_em_reposicao)
        {
            if (ModelState.IsValid)
            {
                db.produtos_em_reposicaoSet.Add(produtos_em_reposicao);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(produtos_em_reposicao);
        }

        // GET: produtos_em_reposicao/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produtos_em_reposicao produtos_em_reposicao = await db.produtos_em_reposicaoSet.FindAsync(id);
            if (produtos_em_reposicao == null)
            {
                return HttpNotFound();
            }
            return View(produtos_em_reposicao);
        }

        // POST: produtos_em_reposicao/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Shampoo,Condicionador,Sabonete")] produtos_em_reposicao produtos_em_reposicao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produtos_em_reposicao).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(produtos_em_reposicao);
        }

        // GET: produtos_em_reposicao/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produtos_em_reposicao produtos_em_reposicao = await db.produtos_em_reposicaoSet.FindAsync(id);
            if (produtos_em_reposicao == null)
            {
                return HttpNotFound();
            }
            return View(produtos_em_reposicao);
        }

        // POST: produtos_em_reposicao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            produtos_em_reposicao produtos_em_reposicao = await db.produtos_em_reposicaoSet.FindAsync(id);
            db.produtos_em_reposicaoSet.Remove(produtos_em_reposicao);
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
