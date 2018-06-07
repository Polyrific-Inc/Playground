using PG.Api.Domains.Base;

namespace PG.Api.Domains.Site
{
    public class EditSiteDto : BaseDto<Model.Site>
    {
        public string Name { get; set; }
    }
}