using Fiddler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadByToolbox
{
    internal class Proxy
    {
        public delegate void BhvrSessionChangedEventHandler(string session);
        public event BhvrSessionChangedEventHandler? BhvrSessionChanged;

        private const string API_INVENTORY = "/api/v1/inventories";
        private const string API_CONFIG = "/api/v1/config";
        private const string API_CURRENCIES = "/api/v1/wallet/currencies";

        private string bhvrSession = "";

        public string ResponseInventory { get; set; } = "";
        public string ResponseCurrencies { get; set; } = "";

        public bool InventoryOverride { get; set; } = false;
        public bool CurrencySpoofer { get; set; } = false;

        public bool IsRunning { get; private set; } = false;

        public string BhvrSession
        {
            get { return bhvrSession; }
            private set
            {
                if (value != bhvrSession)
                {
                    bhvrSession = value;
                    BhvrSessionChanged?.Invoke(value);
                }
            }
        }
        public Proxy()
        {
        }

        public void InstallCerts()
        {
            CertMaker.createRootCert();
            CertMaker.trustRootCert();
        }
      
        public void Start()
        {
            var fiddlerStartupSettings = new FiddlerCoreStartupSettingsBuilder().ListenOnPort(1337).RegisterAsSystemProxy().DecryptSSL().Build();
            FiddlerApplication.Startup(fiddlerStartupSettings);
            FiddlerApplication.BeforeRequest += new SessionStateHandler(Fiddler_BeforeRequest);
            FiddlerApplication.BeforeResponse += new SessionStateHandler(Fiddler_BeforeResponse);

            IsRunning = true;
        }

        public void Stop()
        {
            FiddlerApplication.Shutdown();
            IsRunning = false;
        }


        public void UninstallCerts()
        {
            CertMaker.removeFiddlerGeneratedCerts();
        }

 
        public void Fiddler_BeforeRequest(Session oSession)
        {
            oSession.bBufferResponse = true;
        }

        public void Fiddler_BeforeResponse(Session oSession)
        {
            //Override Inventory
            if (InventoryOverride && oSession.fullUrl.Contains(API_INVENTORY))
            {
                if (ResponseInventory != null)
                {
                    oSession.utilDecodeResponse();
                    oSession.utilSetResponseBody(ResponseInventory);
                }
            }
            //Currencies Spoofer
            else if (CurrencySpoofer && oSession.fullUrl.Contains(API_CURRENCIES))
            {
                if (ResponseCurrencies != null)
                {
                    oSession.utilDecodeResponse();
                    oSession.utilSetResponseBody(ResponseCurrencies);
                }
            }
            //Cookie Grabber
            else if (oSession.fullUrl.Contains(API_CONFIG))
            {
                BhvrSession = oSession.RequestHeaders.GetTokenValue("Cookie", "bhvrSession");

            }
        }
    }
}
