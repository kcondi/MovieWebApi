using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieWebApp.Domain.Repositories;
using MovieWebApp.DTO.DirectorDetails;

namespace MovieWebApp.Controllers
{
    [RoutePrefix("directors")]
    public class DirectorsController : ApiController
    {
        public DirectorsController()
        {
            _directorRepository = new DirectorRepository();
        }
        private readonly DirectorRepository _directorRepository;

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetDirector(int id)
        {
            var directorDetails = _directorRepository.GetDirector(id);
            var director = DirectorDto.FromDirector(directorDetails);
            return Ok(director);
        }
    }
}
