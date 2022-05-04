using L2Lab.Authorization.Users;
using System;

namespace L2Lab.EntityFrameworkCore
{
    public class L2LabMessage {
        
        public int Id { get; set; }
        public string MSGText { get; set; }
        public DateTime MsgCreationTime { get; set; }
        //public User MSGSender { get; set; }



    }
}