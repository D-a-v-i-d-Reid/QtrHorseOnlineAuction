using Microsoft.AspNetCore.Identity;

namespace Quarter_Horse_Online_Auction.Classes
{
    public class Buyer : User
    {
        public int BuyerId { get; set; }

    }
}
