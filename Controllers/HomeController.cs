using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using jaiz.Models;

namespace jaiz.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Card card = new Card
            {
                Type = "Debit",
                Issuer = "Mastercard",
                Number = 5399418765673369,
                Platform = "369/GLOBAL ACCELEREX",
                AuthorizationCode = 0,
                AuthorizationMessage = "OFFLINE CVM",
                ExpiryDate = new DateTime(24, 11, 30)
            };
        Merchant merchant = new Merchant
            {
                Name = "LIZPEE GLOBAL RESOURCES",
                Location = "NO. 174 NTA/MBUORA RD, PORTHARCOURT",
                TerminalId = 23011845
            };
        TransactionViewModel model = new TransactionViewModel
            {
                Type = "PURCHASE",
                STAN = 003862,
                Merchant = merchant,
                Card = card,
                Time = new DateTime(2022, 08, 30, 17, 32, 58),
                Amount = 0.01,
                Currency = "NGN",
                Status = false,
                ResponseCode = 91,
                ResponseMessage = "Issuer or switch inoperative",
                AID = "A000000041010",
                RRN = 000210002450,
                Device = "Accelerex 2.0.0-090921-LINT",
                PTAD = "Global Accelerex",
                GeneratedFor = "MERCHANT"

            };   
        return View(model);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
