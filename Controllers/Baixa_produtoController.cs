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
    public class Baixa_produtoController : Controller
    {
        private APPcontroleContainer db = new APPcontroleContainer();

        // GET: Baixa_produto
        public async Task<ActionResult> Index()
        {
            return View(await db.Baixa_produtoSet.ToListAsync());
        }

        // GET: Baixa_produto/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Baixa_produto baixa_produto = await db.Baixa_produtoSet.FindAsync(id);
            if (baixa_produto == null)
            {
                return HttpNotFound();
            }
            return View(baixa_produto);
        }

        // GET: Baixa_produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Baixa_produto/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Shampoo,Condicionador,Sabonete")] Baixa_produto baixa_produto)
        {
            if (ModelState.IsValid)
            {
                db.Baixa_produtoSet.Add(baixa_produto);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(baixa_produto);
        }

        // GET: Baixa_produto/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Baixa_produto baixa_produto = await db.Baixa_produtoSet.FindAsync(id);
            if (baixa_produto == null)
            {
                return HttpNotFound();
            }
            return View(baixa_produto);
        }

        // POST: Baixa_produto/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Shampoo,Condicionador,Sabonete")] Baixa_produto baixa_produto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(baixa_produto).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(baixa_produto);
        }

        // GET: Baixa_produto/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Baixa_produto baixa_produto = await db.Baixa_produtoSet.FindAsync(id);
            if (baixa_produto == null)
            {
                return HttpNotFound();
            }
            return View(baixa_produto);
        }

        // POST: Baixa_produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Baixa_produto baixa_produto = await db.Baixa_produtoSet.FindAsync(id);
            db.Baixa_produtoSet.Remove(baixa_produto);
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
