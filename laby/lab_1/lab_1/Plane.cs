using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1
{
    public class Plane : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Dostarczono ladunek droga powietrzna");
        }
    }
}
