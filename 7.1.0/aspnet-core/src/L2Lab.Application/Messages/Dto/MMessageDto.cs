using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Lab.Messages.Dto
{
    public class MMessageDto : EntityDto<int>
    {
        
        [Required]
        public string MSGText { get; set; }

        [Required]
        public string DateTime { get; set; }

    }
}
