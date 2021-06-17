using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

using GalimbertiDave.ATMBankApp.WebApiGateway.BusinessLogic.AppSettingsModels;

using RestSharp;



namespace GalimbertiDave.ATMBankApp.WebApiGateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {

        // simple test api to ensure connection is working
        [HttpGet()]
        public string Ping()
        {
            return "\"Pong from web api gateway! :)\"";
        }
    }
}
            
            