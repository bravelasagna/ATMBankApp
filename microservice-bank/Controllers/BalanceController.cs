using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using GalimbertiDave.ATMBankApp.Microservices.Bank.ApiModels;

namespace GalimbertiDave.ATMBankApp.Microservices.Bank.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BalanceController : ControllerBase
    {

        //api/balance/getbalance/accountid/123
        [HttpGet("getbalance/accountId/{accountId}")]
        public BalanceDetailsDTO GetBalanceByAccountId(string accountId)
        {
            
            BalanceDetailsDTO balanceDTO = new BalanceDetailsDTO();
            
            balanceDTO.CurrentBalance = 125.80;

            return balanceDTO;

        }
    }
}
