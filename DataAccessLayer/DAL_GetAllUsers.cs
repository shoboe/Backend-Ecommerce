using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class DAL_GetAllUsers : ImageFormat, DAL_IGetAllUsers
    {
        public List<GetAllUsersModel> GetAllUsers()
        {
            using (var db = new sdirecttestdbEntities1())
            {
                List<GetAllUsersModel> users = new List<GetAllUsersModel>();
                var result = db.spGetAllUsers_Sk().ToList();
                foreach (var j in result)
                {
                    users.Add(new GetAllUsersModel()
                    {
                        RoleId = j.RoleId,
                        UserId = j.UserId,
                        FirstName = j.FirstName,
                        MiddleName = j.MiddleName,
                        LastName = j.LastName,
                        Email = j.Email,
                        Mobile = j.Mobile,
                        Image = this.ByteArrayToString(j.Image),
                        Password = j.Password,
                        IsActive = j.IsActive,
                        IsDeleted = j.IsDeleted,
                        IsCreatedOn = j.IsCreatedOn,
                        IsUpdatedOn = j.IsUpdatedOn,
                        IsDeletedBy = j.IsDeletedBy,
                        IsCreatedBy = j.IsCreatedBy,
                        IsUpdatedBy = j.IsUpdatedBy,

                    }
                 );
                }
                return users;
            }
            
        }
    }
}