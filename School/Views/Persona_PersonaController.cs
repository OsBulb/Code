using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using School;

namespace School.Views
{
    public class Persona_PersonaController : Controller
    {
        private SchoolEntities db = new SchoolEntities();

        // GET: Persona_Persona
        public async Task<ActionResult> Index()
        {
            var persona_Persona = db.Persona_Persona.Include(p => p.Persona_TipoPersona);
            return View(await persona_Persona.ToListAsync());
        }

        // GET: Persona_Persona/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona_Persona persona_Persona = await db.Persona_Persona.FindAsync(id);
            if (persona_Persona == null)
            {
                return HttpNotFound();
            }
            return View(persona_Persona);
        }

        // GET: Persona_Persona/Create
        public ActionResult Create()
        {
            ViewBag.FK_TipoPersona = new SelectList(db.Persona_TipoPersona, "IdTipoPersona", "Descripcion");
            return View();
        }

        // POST: Persona_Persona/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IdPersona,RUT,Nombre,ApellidoPaterno,ApellidoMaterno,Edad,FechaNacimiento,Sexo,Direccion,Telefono,Email,FechaModificacion,FK_TipoPersona,FK_Seccion")] Persona_Persona persona_Persona)
        {
            if (ModelState.IsValid)
            {
                db.Persona_Persona.Add(persona_Persona);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FK_TipoPersona = new SelectList(db.Persona_TipoPersona, "IdTipoPersona", "Descripcion", persona_Persona.FK_TipoPersona);
            return View(persona_Persona);
        }

        // GET: Persona_Persona/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona_Persona persona_Persona = await db.Persona_Persona.FindAsync(id);
            if (persona_Persona == null)
            {
                return HttpNotFound();
            }
            ViewBag.FK_TipoPersona = new SelectList(db.Persona_TipoPersona, "IdTipoPersona", "Descripcion", persona_Persona.FK_TipoPersona);
            return View(persona_Persona);
        }

        // POST: Persona_Persona/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IdPersona,RUT,Nombre,ApellidoPaterno,ApellidoMaterno,Edad,FechaNacimiento,Sexo,Direccion,Telefono,Email,FechaModificacion,FK_TipoPersona,FK_Seccion")] Persona_Persona persona_Persona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(persona_Persona).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FK_TipoPersona = new SelectList(db.Persona_TipoPersona, "IdTipoPersona", "Descripcion", persona_Persona.FK_TipoPersona);
            return View(persona_Persona);
        }

        // GET: Persona_Persona/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona_Persona persona_Persona = await db.Persona_Persona.FindAsync(id);
            if (persona_Persona == null)
            {
                return HttpNotFound();
            }
            return View(persona_Persona);
        }

        // POST: Persona_Persona/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Persona_Persona persona_Persona = await db.Persona_Persona.FindAsync(id);
            db.Persona_Persona.Remove(persona_Persona);
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
