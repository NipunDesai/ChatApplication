using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatApplication.Models
{
    public class ChatGroupDetail
    {
       
        public int Id { get; set; }
        public int Chatgroupid { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }  
        public bool IsDeleted { get; set; }


       
    }
}