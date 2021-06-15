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
    public class ATMBankAppController : ControllerBase
    {

        [HttpGet()]
        public string DoAction()
        {

            //AvailableMicroservices
            List<BusinessLogic.AppSettingsModels.AvailableMicroservice> availableMicroservices = 
                new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ATMBankGatewaySettings:AvailableMicroservices").Get<List<BusinessLogic.AppSettingsModels.AvailableMicroservice>>();


            RestClient clientAPI = new RestClient("http://localhost:5000/api");
            RestRequest request = new RestRequest("balance/getbalance/accountid/123", Method.GET);
            Object response = clientAPI.Execute<object>(request);

            return "Gateway reached";

        }
    }
}
            