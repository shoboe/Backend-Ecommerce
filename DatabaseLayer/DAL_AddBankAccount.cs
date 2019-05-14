using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi.DAL
{
    public class DAL_AddBankAccount : DAL_IAddBankAccount
    {
        public void CreateAccount(AddBankAccountView user)
        {
           using(var db = new sdirecttestdbEntities1())
            {
                db.tblBankNameUser_Sk.Add(new tblBankNameUser_Sk() {
                    BankId = user.BankId,
                    Username = user.Username,
                    Password = user.Password,
                    Email = user.Email,
                    Balance = user.Balance,
                    AccountNumber = user.AccountNumber,
                    IsActive = true,
                    IsCreatedOn = System.DateTime.Now,
                    IsCreatedBy = "BankAdmin",
                    IsUpdatedOn = System.DateTime.Now,
                    IsUpdatedBy = "BankAdmin",
                    IsDeleted = false
                 });
            }
        }
    }
}