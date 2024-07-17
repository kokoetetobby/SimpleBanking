using Microsoft.AspNetCore.Mvc;
using SimpleBanking.DTOs;

namespace SimpleBanking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccount _accountService;
        public AccountController(IAccount account)
        {
            _accountService = account;
        }

        /// <summary>
        /// This endpoint is used to create a user account
        /// </summary>
        /// <param name="newAcct"></param>
        /// <returns>status of the account creation</returns>
        /// <exception cref="Exception"></exception>
        [HttpPost(nameof(CreateAccount))]
        public IActionResult CreateAccount([FromBody] AccountCreationDTO newAcct)
        {
            var response = _accountService.CreateAccount(newAcct);
            return Ok(response);
        }

        /// <summary>
        /// Retrieve accounts created
        /// </summary>
        /// <returns>total accounts created</returns>
        [HttpGet(nameof(RetrieveAccounts))]
        public IActionResult RetrieveAccounts()
        {
            var response = _accountService.GetAccounts();
            return Ok(response);
        }
    }
}