using PG.Api.Domains.Base;

namespace PG.Api.Domains.Site
{
    public class NewSiteDto : BaseNewDto<Model.Site>
    {
        public string Name { get; set; }
    }
}