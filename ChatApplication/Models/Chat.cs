using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatApplication.Models
{
    public class Chat
    {
        public int Id { get; set; }

        public int To { get; set; }
        public int From { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}