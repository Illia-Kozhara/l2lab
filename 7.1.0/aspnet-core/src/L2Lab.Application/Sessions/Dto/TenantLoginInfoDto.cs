using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using L2Lab.MultiTenancy;

namespace L2Lab.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
