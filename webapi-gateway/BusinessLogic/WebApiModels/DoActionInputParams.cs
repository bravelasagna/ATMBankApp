using System;

namespace GalimbertiDave.ATMBankApp.WebApiGateway.BusinessLogic.AppSettingsModels
{

    public class DoActionInputParams
    {
        public string ServiceKey { get; set; }
        public string ActionKey { get; set; }
        public string ActionData { get; set; }
    }

}