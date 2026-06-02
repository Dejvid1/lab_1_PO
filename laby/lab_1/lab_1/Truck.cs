using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1
{
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Dostarczono ladunek droga ladowa");
        }
    }
}
