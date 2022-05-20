using Abp.Application.Services;
using Abp.Application.Services.Dto;
using L2Lab.EntityFrameworkCore;
using L2Lab.Messages.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Lab.Messages
{
    public interface IMessageAppService : IAsyncCrudAppService<L2LabMessageDto>, IApplicationService
    {
        void AddMessage(CreateMessageInput input);
        Task<ListResultDto<MMessageDto>> GetMessageHistory();
        Task <List<L2LabMessage>> GetMessages();
    }
}