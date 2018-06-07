using PG.Api.Domains.Base;
using System.Data.Spatial;

namespace PG.Api.Domains.Facility
{
    public class EditFacilityDto : BaseDto<Model.Facility>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Images { get; set; }
        public DbGeography Location { get; set; }
    }
}