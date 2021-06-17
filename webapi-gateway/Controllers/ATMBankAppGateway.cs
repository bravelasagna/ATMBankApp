using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

using GalimbertiDave.ATMBankApp.WebApiGateway.BusinessLogic;
using GalimbertiDave.ATMBankApp.WebApiGateway.BusinessLogic.AppSettingsModels;

using RestSharp;



namespace GalimbertiDave.ATMBankApp.WebApiGateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ATMBankAppController : ControllerBase
    {

        [HttpPost("DoAction")]
        public ActionResult<String> DoAction(DoActionInputParams doActionParams)
        {
            Validator validator = new Validator();
            Settings settings = new Settings();
            
            // checks that the params are valid
            if (doActionParams == null || string.IsNullOrEmpty(doActionParams.ServiceKey) || string.IsNullOrEmpty(doActionParams.ActionKey)) {
                return "ERR No valid params";
            }

            // check that the microservice key is valid in the passed params
            if (!validator.ValidateMicroServiceKey(doActionParams.ServiceKey)) {
                return "ERR No valid service key";
            }

            // according to the microservice requested, retrieve the server base url
            AvailableMicroservice microserviceDetails = settings.ReturnAvailableMicroServiceByKey(doActionParams.ServiceKey.ToLower());

            // according to the function, will call the designated microservice
            switch(doActionParams.ActionKey.ToLower()) {

                case "get_balance":
                    RestClient clientAPI = new RestClient(microserviceDetails.BaseUrl);
                    RestRequest request = new RestRequest("balance/getbalance/accountid/123", Method.GET);
                    IRestResponse response = clientAPI.Execute<object>(request);           

                    return response.Content;

                default:
                    return "ERR No valid action key";

            }
 



        }
    }
}
            