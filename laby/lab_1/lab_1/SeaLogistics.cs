using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1
{
    public class SeaLogistics : Logistics
    {
        protected override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
