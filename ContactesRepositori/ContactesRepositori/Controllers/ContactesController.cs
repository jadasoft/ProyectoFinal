using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ContactesRepositori.Controllers
{
    public class ContactesController : ApiController
    {
        // GET: api/contactes
        [Route("api/contactes")]
        public HttpResponseMessage Get()
        {
            var contactes = ContactesRepository.GetAllContactes();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, contactes);
            return response;
        }

        [Route("api/contactes/{name:alpha}")]
        public HttpResponseMessage Get(string name)
        {
            var contactes = ContactesRepositori.SearchContactesByName(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, contactes);
            return response;
        }

        // GET: api/contacte/5
        [Route("api/contacte/{id?}")]
        public HttpResponseMessage GetContacte(int id)
        {
            var contacte = ContactesRepositori.GetContacte(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, contacte);
            return response;
        }

        // PUT: api/contactes/5
        public HttpResponseMessage Put(int id, [FromBody]contacte val)
        {
            var contacte = ContactesRepositori.UpdateContacte(id, val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, contacte);
            return response;
        }
    }