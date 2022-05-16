using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Repositories;
using L2Lab.Authorization.Users;
using System;

namespace L2Lab.EntityFrameworkCore
{
    public class L2LabMessage : Entity<int> , IHasCreationTime, IRepository
    {
        public string MSGText { get; set; }
        public DateTime CreationTime { get; set; }

        public L2LabMessage()
        {
            CreationTime = DateTime.Now;  
        }
    }
}