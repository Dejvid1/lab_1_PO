using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(string user,double amount);
    }
}
