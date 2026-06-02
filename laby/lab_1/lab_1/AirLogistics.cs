using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1
{
    public class AirLogistics : Logistics
    {
        protected override ITransport CreateTransport()
        {
            return new Plane();
        }
    }
}
