using Microsoft.Identity.Client;
using SimpleBanking.DTOs;
using SimpleBanking.Models;
using SimpleBanking.Persistence;

namespace SimpleBanking.Repository
{
    public class AccountRepository : IAccount
    {
        private readonly SimpleBankingDbContext _context;
        
        public AccountRepository(SimpleBankingDbContext context)
        {
            _context = context;
        }

        public string CreateAccount(AccountCreationDTO newAccount)
        {
            try
            {
                var new_Account = new Account()
                {
                    Id = new Guid(),
                    AccountName = newAccount.Name,
                    Email = newAccount.Email,
                    AccountNumber = newAccount.AccountNumber,
                    AccountBalance = newAccount.AccountBalance
                };

                return "Account created successfully";
            }
            catch (Exception) 
            {
                //throw new Exception(ex.Message);
                return "An error occured while creating account, contact support";
            }
        }

        public List<Account> GetAccounts()
        {
            var account = new Account
            {
                AccountBalance = 1200000,
                AccountName = "tobby umoh",
                AccountNumber = "2093330091",
                Email = "tobby@gmail.com",
                Id = Guid.NewGuid(),
            };
            var accounts = new List<Account> { account};

            return accounts;
        }
    }
}