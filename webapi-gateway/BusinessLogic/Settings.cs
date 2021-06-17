using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;

using GalimbertiDave.ATMBankApp.WebApiGateway.BusinessLogic.AppSettingsModels;

namespace GalimbertiDave.ATMBankApp.WebApiGateway.BusinessLogic
{
    public class Settings
    {

        // return a microservice details by its key
        public AvailableMicroservice ReturnAvailableMicroServiceByKey(string microServiceKey)
        {

            // reads the available services from the appsettings.json file
            List<BusinessLogic.AppSettingsModels.AvailableMicroservice> availableMicroservices =
                new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ATMBankGatewaySettings:AvailableMicroservices").Get<List<BusinessLogic.AppSettingsModels.AvailableMicroservice>>();

            // returns the microservice found or NULL
            return availableMicroservices.Where(service => service.ServiceKey == microServiceKey).FirstOrDefault();

        }
    }

}