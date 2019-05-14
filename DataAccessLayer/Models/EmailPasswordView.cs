using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAccessLayer.Models
{
    public class EmailPasswordView
    {
        [Required]
        public string Email { get; set; }

    }
}