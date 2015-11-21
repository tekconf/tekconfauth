using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using AutoMapper.QueryableExtensions;
using Tekconf.Data;
using Tekconf.Data.Entities;

namespace Tekconf.API.Controllers
{
    public class ConferencesController : ApiController
    {
        readonly IConferenceRepository _repository;

        public ConferencesController()
        {
            _repository = new ConferenceEfRepository(new ConferenceContext());
        }

        public ConferencesController(IConferenceRepository repository)
        {
            _repository = repository;
        }    


        public async Task<IHttpActionResult> Get()
        {
            try
            {
                var conferences = await _repository
                    .GetConferences()
                    .ProjectTo<DTO.Conference>()
                    .ToListAsync();

                return Ok(conferences);

            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        public async Task<IHttpActionResult> Get(string slug)
        {
            try
            {
                var conference = await _repository
                    .GetConferences()
                    .Where(c => c.Slug == slug)
                    .ProjectTo<DTO.Conference>()
                    .SingleOrDefaultAsync();

                if (conference == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(conference);
                }
            }
            catch (Exception e)
            {
                return InternalServerError();
            }
        }
    }
}
