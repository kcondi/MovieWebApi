using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieWebApp.Data.Models.Entities;
using MovieWebApp.Domain.Repositories;
using MovieWebApp.DTO;
using MovieWebApp.DTO.ActorDetails;

namespace MovieWebApp.Controllers
{
    [RoutePrefix("actors")]
    public class ActorsController : ApiController
    {
        public ActorsController()
        {
            _actorRepository=new ActorRepository();
        }
        private readonly ActorRepository _actorRepository;

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetActor(int id)
        {
            var actorDetails = _actorRepository.GetActor(id);
            var actor = ActorDto.FromActor(actorDetails);
            return Ok(actor);
        }
    }
}
