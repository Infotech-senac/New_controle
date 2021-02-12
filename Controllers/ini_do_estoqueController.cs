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
    public class ini_do_estoqueController : Controller
    {
        private APPcontroleContainer db = new APPcontroleContainer();

        // GET: ini_do_estoque
        public async Task<ActionResult> Index()
        {
            return View(await db.ini_do_estoqueSet.ToListAsync());
        }

        // GET: ini_do_estoque/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ini_do_estoque ini_do_estoque = await db.ini_do_estoqueSet.FindAsync(id);
            if (ini_do_estoque == null)
            {
                return HttpNotFound();
            }
            return View(ini_do_estoque);
        }

        // GET: ini_do_estoque/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ini_do_estoque/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Shampoo,Condicionador,Sabonete")] ini_do_estoque ini_do_estoque)
        {
            if (ModelState.IsValid)
            {
                db.ini_do_estoqueSet.Add(ini_do_estoque);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ini_do_estoque);
        }

        // GET: ini_do_estoque/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ini_do_estoque ini_do_estoque = await db.ini_do_estoqueSet.FindAsync(id);
            if (ini_do_estoque == null)
            {
                return HttpNotFound();
            }
            return View(ini_do_estoque);
        }

        // POST: ini_do_estoque/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Shampoo,Condicionador,Sabonete")] ini_do_estoque ini_do_estoque)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ini_do_estoque).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ini_do_estoque);
        }

        // GET: ini_do_estoque/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ini_do_estoque ini_do_estoque = await db.ini_do_estoqueSet.FindAsync(id);
            if (ini_do_estoque == null)
            {
                return HttpNotFound();
            }
            return View(ini_do_estoque);
        }

        // POST: ini_do_estoque/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ini_do_estoque ini_do_estoque = await db.ini_do_estoqueSet.FindAsync(id);
            db.ini_do_estoqueSet.Remove(ini_do_estoque);
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
