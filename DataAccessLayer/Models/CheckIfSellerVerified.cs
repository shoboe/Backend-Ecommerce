
namespace DataAccessLayer.Models
{
    public class CheckIfSellerVerified
    {
       public static bool VerifySeller(int sellerId)
        {
            using(var db = new sdirecttestdbEntities1())
            {
                var result = db.spCheckSellerStatus_Sk(sellerId);
                if (result == 1)
                    return true;
                else
                    return false;
            }
        }
    }
    
}