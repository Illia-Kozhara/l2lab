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
    }

        public void AddMessage(CreateMessageInput input)
        {
            var message = new L2LabMessage { MSGText = input.MsgText };
            _l2LabRepository.Insert(message);
        }
        public List<L2LabMessage> GetMessages()
        {
            var messages = _l2LabRepository.GetAllList();
            return messages;
            //throw new NotImplementedException();
        }
        public L2LabMessage GetMessageById(int id) { 
            var message = _l2LabRepository.Get(id);
            return message;
        }
        public void DeleteMessage(int id)
        {
            _l2LabRepository.Delete(id);
        }
        public L2LabMessage UpdateMessage(L2LabMessage m)
        {
            var message = _l2LabRepository.Get(m.Id);
            message.MSGText = m.MSGText;
            message.CreationTime = DateTime.Now;
            return _l2LabRepository.Update(message);
        }
        public async Task<ListResultDto<MMessageDto>> GetMessageHistory()
        {
            var messages = await _l2LabRepository.GetAllListAsync();
            return new ListResultDto<MMessageDto>(ObjectMapper.Map<List<MMessageDto>>(messages));
        }
        public async Task<L2LabMessage> AddMessageAsync(CreateMessageInput input)
        {
            var message = new L2LabMessage { MSGText = input.MsgText };
            return await _l2LabRepository.InsertAsync(message);
            
        }

        public Task<ListResultDto<MMessageDto>> GetMessagesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<L2LabMessage> GetMessageByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteMessageAsync(int id)
        {
            await _l2LabRepository.DeleteAsync(id);
        }

        public async Task<L2LabMessage> UpdateMessageAsync(L2LabMessage m)
        {
            var message = await _l2LabRepository.GetAsync(m.Id);
            message.MSGText = m.MSGText;
            message.CreationTime = DateTime.Now;
            return (await _l2LabRepository.UpdateAsync(message));
        }
    }
}
