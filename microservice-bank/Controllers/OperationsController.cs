using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

using GalimbertiDave.ATMBankApp.Microservices.Bank.ApiModels;

namespace GalimbertiDave.ATMBankApp.Microservices.Bank.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("[controller]")]
    public class OperationsController : ControllerBase
    {

        [HttpPost("Deposit")]
        public ActionResult<String> Deposit(string accountNumber)
        {
            return "ok";
        }
    }
}
