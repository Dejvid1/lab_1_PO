using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1
{
    public abstract class Logistics
    {
        protected abstract ITransport CreateTransport();
        public void PlanDelivery()
        {
           ITransport transport = CreateTransport();
           transport.Deliver();  
        }
    }
}
