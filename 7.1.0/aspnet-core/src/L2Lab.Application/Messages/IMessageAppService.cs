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
        //Non async
        void AddMessage(CreateMessageInput input);
        List<L2LabMessage> GetMessages();
        public L2LabMessage GetMessageById(int id);
        public void DeleteMessage(int id);
        public L2LabMessage UpdateMessage(L2LabMessage m);
        //async
        Task<ListResultDto<MMessageDto>> GetMessagesAsync();
        Task<L2LabMessage> AddMessageAsync(CreateMessageInput input);
        Task<L2LabMessage> GetMessageByIdAsync(int id);
        Task DeleteMessageAsync(int id);
        Task<L2LabMessage> UpdateMessageAsync(L2LabMessage m);


    }
}