using DataAccessLayer.Models;

namespace DataAccessLayer
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