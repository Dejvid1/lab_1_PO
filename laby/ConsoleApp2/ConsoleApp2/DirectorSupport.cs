using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class DirectorSupport : SupportHandler
    {
        public override void HandleTicket(Ticket ticket)
        {
            Console.WriteLine($"[Dyrektor IT Level 3] Ostatecznie zatwierdził/rozwiązał zgłoszenie #{ticket.Id}: {ticket.Description} (Priorytet: {ticket.Severity}, Koszt: {ticket.Cost} PLN)");
        }
    }
}
