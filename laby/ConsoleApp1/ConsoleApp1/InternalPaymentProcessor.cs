using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class InternalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(string user, double amount)
        {
            Console.WriteLine($"[System Wewnętrzny] Przetwarzanie płatności w kwocie {amount} PLN dla użytkownika: {user}.");
        }
    }
}
