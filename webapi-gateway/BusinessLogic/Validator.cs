using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace GalimbertiDave.ATMBankApp.WebApiGateway.BusinessLogic
{

    public class Validator
    {

        public bool ValidateMicroServiceKey(string microServiceKey)
        {

            // reads the available services from the appsettings.json file
            List<BusinessLogic.AppSettingsModels.AvailableMicroservice> availableMicroservices =
                new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ATMBankGatewaySettings:AvailableMicroservices").Get<List<BusinessLogic.AppSettingsModels.AvailableMicroservice>>();

            // checks that the passed microserviceKey exists in the list from the appsettings.json
            return availableMicroservices.Where(service => service.ServiceKey == microServiceKey).Count() > 0;

        }
    }

}