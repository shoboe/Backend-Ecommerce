
namespace DataAccessLayer
{
    public class AddBankAccountView
    {
        public int BankId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long Mobile { get; set; }
        public int Balance { get; set; }
        public string AccountNumber { get; set; }
        public string Email { get; set; }
    }
}