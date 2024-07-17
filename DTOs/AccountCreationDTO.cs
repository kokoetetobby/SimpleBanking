using System.ComponentModel.DataAnnotations;

namespace SimpleBanking.DTOs
{
    public class AccountCreationDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string AccountNumber { get; set; }
        public double AccountBalance { get; set; } = 0;
    }
}
