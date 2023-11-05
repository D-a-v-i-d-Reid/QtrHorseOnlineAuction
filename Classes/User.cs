using System.Text.RegularExpressions;

namespace Quarter_Horse_Online_Auction.Classes
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        private string? _userEmail;

        public string? UserEmail
        {
            get => _userEmail;
            set
            {
                if (IsValidEmail(value ))
                {
                    _userEmail = value;
                }
                else
                {
                    throw new ArgumentException("Invalid email format");
                }


            }



        }
        private bool IsValidEmail(string? email)
        {
            if (email == null)
            {
                return false;
            }
            string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}