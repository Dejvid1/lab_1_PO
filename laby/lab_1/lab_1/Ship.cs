using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Dostarczono ladunek droga wodna");
        }
    }
}
