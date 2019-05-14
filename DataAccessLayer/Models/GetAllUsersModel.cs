using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer.Models
{
    public class GetAllUsersModel
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime IsCreatedOn { get; set; }
        public string IsCreatedBy { get; set; }
        public System.DateTime IsUpdatedOn { get; set; }
        public string IsUpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string IsDeletedBy { get; set; }
        public string Image { get; set; }
        public string Mobile { get; set; }
    }
}