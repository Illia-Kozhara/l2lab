using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Lab.Messages.Dto
{
    internal class MessageDTO : EntityDto<long>
    {
        public long Id { get; set; }
        public string Message { get; set; }
    }
}
