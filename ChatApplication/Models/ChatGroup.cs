using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChatApplication.Models
{
    public class ChatGroup
    {
        
        public int Id { get; set; }
        [Display(Name="Group Name")]
        public string GroupName { get; set; }
        //[Display(Name="User Name")]
        //public int UserId { get; set; }
        //public DateTime CreateDate { get; set; }
        //public bool IsDeleted { get; set; }

        
    }
}