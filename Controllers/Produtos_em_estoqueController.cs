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
    public class Produtos_em_estoqueController : Controller
    {
        private APPcontroleContainer db = new APPcontroleContainer();

        // GET: Produtos_em_estoque
        public async Task<ActionResult> Index()
        {
            return View(await db.Produtos_em_estoqueSet.ToListAsync());
        }

        // GET: Produtos_em_estoque/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produtos_em_estoque produtos_em_estoque = await db.Produtos_em_estoqueSet.FindAsync(id);
            if (produtos_em_estoque == null)
            {
                return HttpNotFound();
            }
            return View(produtos_em_estoque);
        }

        // GET: Produtos_em_estoque/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produtos_em_estoque/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Shampoo,Condicionador,Sabonete")] Produtos_em_estoque produtos_em_estoque)
        {
            if (ModelState.IsValid)
            {
                db.Produtos_em_estoqueSet.Add(produtos_em_estoque);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(produtos_em_estoque);
        }

        // GET: Produtos_em_estoque/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produtos_em_estoque produtos_em_estoque = await db.Produtos_em_estoqueSet.FindAsync(id);
            if (produtos_em_estoque == null)
            {
                return HttpNotFound();
            }
            return View(produtos_em_estoque);
        }

        // POST: Produtos_em_estoque/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Shampoo,Condicionador,Sabonete")] Produtos_em_estoque produtos_em_estoque)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produtos_em_estoque).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(produtos_em_estoque);
        }

        // GET: Produtos_em_estoque/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produtos_em_estoque produtos_em_estoque = await db.Produtos_em_estoqueSet.FindAsync(id);
            if (produtos_em_estoque == null)
            {
                return HttpNotFound();
            }
            return View(produtos_em_estoque);
        }

        // POST: Produtos_em_estoque/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Produtos_em_estoque produtos_em_estoque = await db.Produtos_em_estoqueSet.FindAsync(id);
            db.Produtos_em_estoqueSet.Remove(produtos_em_estoque);
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
