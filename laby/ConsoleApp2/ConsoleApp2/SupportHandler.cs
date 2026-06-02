using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class SupportHandler
    {
        private SupportHandler _nextHandler;
        public SupportHandler SetNext(SupportHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
        public virtual void HandleTicket(Ticket ticket)
        {
            if (_nextHandler != null)
            {
                _nextHandler.HandleTicket(ticket);
            }
            else
            {
                Console.WriteLine($"[BŁĄD] Zgłoszenie #{ticket.Id} nie mogło zostać obsłużone przez żaden poziom wsparcia.");
            }
        }
    }
}
