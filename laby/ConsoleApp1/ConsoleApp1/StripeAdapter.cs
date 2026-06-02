using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class StripeAdapter : IPaymentProcessor
    {
    
        private readonly ExternalStripeService _stripeService;

        public StripeAdapter(ExternalStripeService stripeService)
        {
            _stripeService = stripeService;
        }

        // Tłumaczenie wywołania na format zrozumiały dla zewnętrznej biblioteki
        public void ProcessPayment(string user, double amount)
        {
            float totalCurrency = (float)amount;
            string accountId = user;
            bool forceSca = true;
            _stripeService.MakeTransaction(totalCurrency, accountId, forceSca);
        }
    }
}
