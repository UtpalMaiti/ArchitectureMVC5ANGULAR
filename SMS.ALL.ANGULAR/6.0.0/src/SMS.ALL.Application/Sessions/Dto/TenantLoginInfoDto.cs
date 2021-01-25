using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SMS.ALL.MultiTenancy;

namespace SMS.ALL.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
