using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Level2Support : SupportHandler
    {
        public override void HandleTicket(Ticket ticket)
        {
            if (ticket.Severity == Severity.Medium || ticket.Cost < 1000m)
            {
                Console.WriteLine($"[Inżynier Level 2] Rozwiązał zgłoszenie #{ticket.Id}: {ticket.Description} (Koszt: {ticket.Cost} PLN)");
            }
            else
            {
                Console.WriteLine($"[Inżynier Level 2] Zbyt skomplikowane/drogie. Przekazuję zgłoszenie #{ticket.Id} do dyrekcji...");
                base.HandleTicket(ticket);
            }
        }
    }
}
