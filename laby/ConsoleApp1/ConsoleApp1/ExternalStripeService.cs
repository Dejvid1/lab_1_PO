using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ExternalStripeService
    {
        public void MakeTransaction(float totalCurrency,string accountId, bool forceSca)
        {
            Console.WriteLine($"[Stripe API] Wykonywanie transakcji: {totalCurrency} na koncie ID: {accountId}. Wymuszenie SCA: {forceSca}.");
        }
    }
}
