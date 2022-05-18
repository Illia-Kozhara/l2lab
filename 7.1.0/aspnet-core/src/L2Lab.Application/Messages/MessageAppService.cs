using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using L2Lab.EntityFrameworkCore;
using L2Lab.EntityFrameworkCore.Repositories;
using L2Lab.Messages.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Lab.Messages
{
    public class MessageAppService : AsyncCrudAppService<L2LabMessage, L2LabMessageDto>, IMessageAppService
    {
        private readonly IRepository<L2LabMessage> _l2LabRepository;
        


        public MessageAppService(IRepository<L2LabMessage> l2LabRepository)
            : base(l2LabRepository)
        {
            this._l2LabRepository = l2LabRepository;
            //_l2LabRepository = l2LabRepository;
    }

        public void AddMessage(CreateMessageInput input)
        {
            //just example
            //var msg = ObjectMapper.Map<L2LabMessage>(input);
            var message = new L2LabMessage { MSGText = input.MsgText };
            _l2LabRepository.Insert(message);
        }

        public Task <List<L2LabMessage>> GetMessages()
        {
            var messages = _l2LabRepository.GetAllListAsync();
            return messages;
            //throw new NotImplementedException();
        }
    }
}
