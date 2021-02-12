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
    public class Quantidade_em_estoqueController : Controller
    {
        private APPcontroleContainer db = new APPcontroleContainer();

        // GET: Quantidade_em_estoque
        public async Task<ActionResult> Index()
        {
            return View(await db.Quantidade_em_estoqueSet.ToListAsync());
        }

        // GET: Quantidade_em_estoque/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quantidade_em_estoque quantidade_em_estoque = await db.Quantidade_em_estoqueSet.FindAsync(id);
            if (quantidade_em_estoque == null)
            {
                return HttpNotFound();
            }
            return View(quantidade_em_estoque);
        }

        // GET: Quantidade_em_estoque/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quantidade_em_estoque/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Shampoo,Condicionador,Sabonete")] Quantidade_em_estoque quantidade_em_estoque)
        {
            if (ModelState.IsValid)
            {
                db.Quantidade_em_estoqueSet.Add(quantidade_em_estoque);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(quantidade_em_estoque);
        }

        // GET: Quantidade_em_estoque/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quantidade_em_estoque quantidade_em_estoque = await db.Quantidade_em_estoqueSet.FindAsync(id);
            if (quantidade_em_estoque == null)
            {
                return HttpNotFound();
            }
            return View(quantidade_em_estoque);
        }

        // POST: Quantidade_em_estoque/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Shampoo,Condicionador,Sabonete")] Quantidade_em_estoque quantidade_em_estoque)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quantidade_em_estoque).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(quantidade_em_estoque);
        }

        // GET: Quantidade_em_estoque/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quantidade_em_estoque quantidade_em_estoque = await db.Quantidade_em_estoqueSet.FindAsync(id);
            if (quantidade_em_estoque == null)
            {
                return HttpNotFound();
            }
            return View(quantidade_em_estoque);
        }

        // POST: Quantidade_em_estoque/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Quantidade_em_estoque quantidade_em_estoque = await db.Quantidade_em_estoqueSet.FindAsync(id);
            db.Quantidade_em_estoqueSet.Remove(quantidade_em_estoque);
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
