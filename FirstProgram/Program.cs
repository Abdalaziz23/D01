namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cost;
            double tax = 0.06;
            double totalEstimate;
            Console.WriteLine("Islam's Carpet Cleaning Service\n" +
                "Charges:\n$25 per small\n$35 per large\nSales tax rate is 6%\n" +
                "Estimates are valid for 30 days");
            Console.WriteLine("========================================");
            Console.Write("Number of small carpets:");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of large carpets:");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());

            smallCarpets *= 25;
            largeCarpets *= 35;
            cost = smallCarpets + largeCarpets;
            Console.WriteLine($"Cost: ${cost}");
            tax *= cost; 
            Console.WriteLine($"Tax: ${tax}");
            Console.WriteLine("========================================");
            totalEstimate = cost+tax;
            Console.WriteLine($"Total Estimate: ${totalEstimate}");

        }
    }
}
