using ConsoleApp2;
using System;

public class FirstProgram
{
    public static void Main(string[] args)
    {

        var consultant = new Level1Support();
        var engineer = new Level2Support();
        var director = new DirectorSupport();

        consultant.SetNext(engineer).SetNext(director);

        var tickets = new List<Ticket>
            {
              
                new Ticket(101, "Reset hasła w systemie ERP", Severity.Low, 0m),
                new Ticket(102, "Instalacja pakietu biurowego", Severity.Medium, 400m),
                new Ticket(103, "Odzyskiwanie danych z zalanego dysku w serwisie", Severity.High, 800m),
                new Ticket(104, "Zakup 5 nowych stacji roboczych z GPU", Severity.High, 35000m),
                new Ticket(105, "Awaria macierzy dyskowej serwera głównego", Severity.High, 15000m)
            };

        foreach (var ticket in tickets)
        {
            Console.WriteLine($"\n--- Przetwarzanie Zgłoszenia #{ticket.Id} ---");
            consultant.HandleTicket(ticket);
        }
    }
}

