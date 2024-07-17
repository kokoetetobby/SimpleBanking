using SimpleBanking.DTOs;
using SimpleBanking.Models;

public interface IAccount
{
    public string CreateAccount(AccountCreationDTO newAccount);
    public List<Account> GetAccounts();
}