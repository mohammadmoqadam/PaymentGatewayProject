using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaymentGateway.Core.Models;
using PaymentGateway.Core.Contract;

namespace PaymentGateway.Website.Controllers
{
    [Route("/default/[action]")]
    public class DefaultController : Controller
    {
        private IJsonConvert jsonConvert;
        private IGateway gateway;
        private IHttpClient httpClient;
        public DefaultController(IJsonConvert jsonConvert, IGateway gateway, IHttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.gateway = gateway;
            this.jsonConvert = jsonConvert;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var payment = new Payment(gateway, httpClient, jsonConvert);
            
            var date =await payment.RequestToGateway(new GatewayInformation(2000, "10ed5baa-48bc-11e6-8f69-005056a205be", "https://localhost:44323/default/verify", "nadare"));

            return View();
        }

        [HttpGet]
        public IActionResult Verify(string Authority,int Status,int Amount)
        {
            var payment = new Payment(gateway, httpClient, jsonConvert);

            var date = payment.RequestToGateway(new GatewayInformation(2000, "10ed5baa-48bc-11e6-8f69-005056a205be", "http://phonimo.ir", "nadare"));

            return View();
        }



    }
}