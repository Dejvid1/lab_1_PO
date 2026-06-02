using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Level1Support : SupportHandler
    {
        public override void HandleTicket(Ticket ticket)
        {
            if (ticket.Severity == Severity.Low)
            {
                Console.WriteLine($"[Konsultant Level 1] Rozwiązał zgłoszenie #{ticket.Id}: {ticket.Description}");
            }
            else
            {
                Console.WriteLine($"[Konsultant Level 1] Brak uprawnień. Przekazuję zgłoszenie #{ticket.Id} wyżej...");
                base.HandleTicket(ticket);
            }
        }
    }
}