using ConsoleApp1;
using System;

    public class FirstProgram
    {
        public static void Main(string[] args)
        {

        IPaymentProcessor oldSystem = new InternalPaymentProcessor();

        ExternalStripeService stripeApi = new ExternalStripeService();
        IPaymentProcessor newStripeSystem = new StripeAdapter(stripeApi);

        List<IPaymentProcessor> availableProcessors = new List<IPaymentProcessor>
            {
                oldSystem,
                newStripeSystem
            };
        string testUser = "JanKowalski_99";
        double testAmount = 149.99;

        foreach (var processor in availableProcessors)
        {
            Console.WriteLine($"--- Użycie procesora: {processor.GetType().Name} ---");
            processor.ProcessPayment(testUser, testAmount);
            Console.WriteLine();
        }
    }
    }

