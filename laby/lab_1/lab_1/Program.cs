using System;

namespace lab_1
{
    public class FirstProgram
    {
        public static void Main(string[] args)
        {
            List<Logistics> logisticsNetwork = new List<Logistics>
            {
                new RoadLogistics(),
                new SeaLogistics(),
                new AirLogistics()
            };

            foreach (var logistics in logisticsNetwork)
            {
                Console.WriteLine($"[Testowanie: {logistics.GetType().Name}]");

                logistics.PlanDelivery();
                Console.WriteLine();
            }
        }
    }
}
