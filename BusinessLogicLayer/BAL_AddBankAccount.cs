using E_Commerce_ShoebApi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_ShoebApi.BAL
{
    public class BAL_AddBankAccount : BAL_IAddBankAccount
    {
        DAL_IAddBankAccount DAL_iAddBankAccount;
        public BAL_AddBankAccount(DAL_IAddBankAccount DAL_iAddBankAccount)
        {
            this.DAL_iAddBankAccount = DAL_iAddBankAccount;
        }
        public void CreateAccount(AddBankAccountView user)
        {
            DAL_iAddBankAccount.CreateAccount(user);
        }
    }
}