using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChatApplication.Models
{
   
    public class UserDetail
    {
       
        public int Id { get; set; }
        [Display(Name="User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Field can't Empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "EmailIs is not Valid")]
        [Display(Name = "Email")]
        public string EmailId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")] 
        public string Password { get; set; }
      
        [Display(Name = "Birth Date")]
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        [Display(Name = "Contact Number")]
        public int? Contactno { get; set; }
        public bool IsDeleted { get; set; }     
    }
   
}