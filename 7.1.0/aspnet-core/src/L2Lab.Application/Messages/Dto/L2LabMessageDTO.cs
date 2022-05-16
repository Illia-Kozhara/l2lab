using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using AutoMapper;
using L2Lab.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Lab.Messages.Dto
{
    [AutoMap(typeof(L2LabMessage))]
    public class L2LabMessageDto : EntityDto<int>, IHasCreationTime
    {
        [Required]
        public string MSGText { get; set; }
        public DateTime CreationTime { get; set; }

    }
}
