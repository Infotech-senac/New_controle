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
    public class produtos_enviadoController : Controller
    {
        private APPcontroleContainer db = new APPcontroleContainer();

        // GET: produtos_enviado
        public async Task<ActionResult> Index()
        {
            return View(await db.produtos_enviadoSet.ToListAsync());
        }

        // GET: produtos_enviado/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produtos_enviado produtos_enviado = await db.produtos_enviadoSet.FindAsync(id);
            if (produtos_enviado == null)
            {
                return HttpNotFound();
            }
            return View(produtos_enviado);
        }

        // GET: produtos_enviado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: produtos_enviado/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Shampoo,Condicionador,Sabonete")] produtos_enviado produtos_enviado)
        {
            if (ModelState.IsValid)
            {
                db.produtos_enviadoSet.Add(produtos_enviado);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(produtos_enviado);
        }

        // GET: produtos_enviado/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produtos_enviado produtos_enviado = await db.produtos_enviadoSet.FindAsync(id);
            if (produtos_enviado == null)
            {
                return HttpNotFound();
            }
            return View(produtos_enviado);
        }

        // POST: produtos_enviado/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Shampoo,Condicionador,Sabonete")] produtos_enviado produtos_enviado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produtos_enviado).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(produtos_enviado);
        }

        // GET: produtos_enviado/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produtos_enviado produtos_enviado = await db.produtos_enviadoSet.FindAsync(id);
            if (produtos_enviado == null)
            {
                return HttpNotFound();
            }
            return View(produtos_enviado);
        }

        // POST: produtos_enviado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            produtos_enviado produtos_enviado = await db.produtos_enviadoSet.FindAsync(id);
            db.produtos_enviadoSet.Remove(produtos_enviado);
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
