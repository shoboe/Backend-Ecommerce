using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Commerce_ShoebApi.Models
{
    public class EmailPasswordView
    {
        [Required]
        public string Email { get; set; }

    }
}