﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class POMASTERsController : ApiController
    {
        private PODbEntities db = new PODbEntities();

        // GET: api/POMASTERs
        public IQueryable<POMASTER> GetPOMASTERs()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.POMASTERs;
        }

        // GET: api/POMASTERs/5
        [ResponseType(typeof(POMASTER))]
        public IHttpActionResult GetPOMASTER(string id)
        {
            POMASTER pOMASTER = db.POMASTERs.Find(id);
            if (pOMASTER == null)
            {
                return NotFound();
            }

            return Ok(pOMASTER);
        }

        // PUT: api/POMASTERs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPOMASTER(string id, POMASTER pOMASTER)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pOMASTER.PONO.Trim())
            {
                return BadRequest();
            }

            db.Entry(pOMASTER).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!POMASTERExists(id))
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

        // POST: api/POMASTERs
        [ResponseType(typeof(POMASTER))]
        public IHttpActionResult PostPOMASTER(POMASTER pOMASTER)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.POMASTERs.Add(pOMASTER);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (POMASTERExists(pOMASTER.PONO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = pOMASTER.PONO }, pOMASTER);
        }

        // DELETE: api/POMASTERs/5
        [ResponseType(typeof(POMASTER))]
        public IHttpActionResult DeletePOMASTER(string id)
        {
            POMASTER pOMASTER = db.POMASTERs.Find(id);
            if (pOMASTER == null)
            {
                return NotFound();
            }

            db.POMASTERs.Remove(pOMASTER);
            db.SaveChanges();

            return Ok(pOMASTER);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool POMASTERExists(string id)
        {
            return db.POMASTERs.Count(e => e.PONO == id) > 0;
        }
    }
}