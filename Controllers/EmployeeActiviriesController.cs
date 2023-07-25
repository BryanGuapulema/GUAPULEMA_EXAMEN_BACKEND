using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GUAPULEMA_EXAMEN;

namespace GUAPULEMA_EXAMEN.Controllers
{
    public class EmployeeActiviriesController : ApiController
    {
        private Guapulema_Examen_CrudMvcAPIEntities db = new Guapulema_Examen_CrudMvcAPIEntities();

        // GET: api/EmployeeActiviries
        public IQueryable<EmployeeActiviry> GetEmployeeActiviry()
        {
            return db.EmployeeActiviry;
        }

        // GET: api/EmployeeActiviries/5
        [ResponseType(typeof(EmployeeActiviry))]
        public IHttpActionResult GetEmployeeActiviry(int id)
        {
            EmployeeActiviry employeeActiviry = db.EmployeeActiviry.Find(id);
            if (employeeActiviry == null)
            {
                return NotFound();
            }

            return Ok(employeeActiviry);
        }

        // PUT: api/EmployeeActiviries/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployeeActiviry(int id, EmployeeActiviry employeeActiviry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employeeActiviry.idEmpAct)
            {
                return BadRequest();
            }

            db.Entry(employeeActiviry).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeActiviryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/EmployeeActiviries
        [ResponseType(typeof(EmployeeActiviry))]
        public IHttpActionResult PostEmployeeActiviry(EmployeeActiviry employeeActiviry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EmployeeActiviry.Add(employeeActiviry);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employeeActiviry.idEmpAct }, employeeActiviry);
        }

        // DELETE: api/EmployeeActiviries/5
        [ResponseType(typeof(EmployeeActiviry))]
        public IHttpActionResult DeleteEmployeeActiviry(int id)
        {
            EmployeeActiviry employeeActiviry = db.EmployeeActiviry.Find(id);
            if (employeeActiviry == null)
            {
                return NotFound();
            }

            db.EmployeeActiviry.Remove(employeeActiviry);
            db.SaveChanges();

            return Ok(employeeActiviry);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeActiviryExists(int id)
        {
            return db.EmployeeActiviry.Count(e => e.idEmpAct == id) > 0;
        }
    }
}