using Abp.Application.Services.Dto;

namespace SMS.ALL.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

