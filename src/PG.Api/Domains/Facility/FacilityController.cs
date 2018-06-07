using System.Web.Http;
using PG.Api.Domains.Base;
using PG.BLL;

namespace PG.Api.Domains.Facility
{
    [RoutePrefix("Facility")]
    public class FacilityController : BaseController<NewFacilityDto, EditFacilityDto, FacilityDto, Model.Facility, IFacilityService>
    {
        public FacilityController(IFacilityService service) : base(service)
        {
        }

        [Route("{id}", Name = "GetFacilityById")]
        public override IHttpActionResult Get(int id)
        {
            return base.Get(id);
        }

        [Authorize]
        [Route("")]
        public IHttpActionResult Post([FromBody] NewFacilityDto value)
        {
            return base.Post(value, "GetFacilityById");
        }

        [Authorize]
        [Route("{id}")]
        public override IHttpActionResult Put(int id, [FromBody] EditFacilityDto value)
        {
            return base.Put(id, value);
        }

        [Authorize]
        [Route("{id}")]
        public override IHttpActionResult Delete(int id)
        {
            return base.Delete(id);
        }
    }
}