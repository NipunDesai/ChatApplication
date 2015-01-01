using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ChatApplication.Models
{
    public class ChatGroupUser
    {
        public int Id { get; set; }
        [Display(Name="User Name")]
        public int UserId { get; set; }
        [Display(Name="Group Name")]
        public int GroupId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
       
       
    }
}