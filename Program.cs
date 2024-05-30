using System.Formats.Asn1;

namespace Week4Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string customerName;
            int customerId;
            int unitsConsumed;
            double surcharge = .3;
            double totalAmount;

            Console.WriteLine("Enter Customer ID");
            customerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Name");
            customerName = Console.ReadLine();

            Console.WriteLine("Enter the amount of units consumed");
            unitsConsumed = Convert.ToInt32(Console.ReadLine());

            if (unitsConsumed < 199)
            {
                Console.WriteLine($"Customer IDNO: {customerId}");
                Console.WriteLine($"Customer Name: {customerName}");
                Console.WriteLine($"Unit Consumed: {unitsConsumed}");
                Console.WriteLine($"Amount Charges @$1.20 per unit:{unitsConsumed * 1.20}");
                Console.WriteLine($"Surcharge Amount: {Math.Ceiling(unitsConsumed * surcharge)}");
                Console.WriteLine($"Net Amount Paid By the Customer: {(unitsConsumed * 1.20) + (Math.Ceiling(unitsConsumed * surcharge))}");
            }
            else if (200 <= unitsConsumed && unitsConsumed < 400) 
            {
                Console.WriteLine($"Customer IDNO: {customerId}");
                Console.WriteLine($"Customer Name: {customerName}");
                Console.WriteLine($"Unit Consumed: {unitsConsumed}");
                Console.WriteLine($"Amount Charges @$1.50 per unit:{unitsConsumed * 1.50}");
                Console.WriteLine($"Surcharge Amount: {Math.Ceiling(unitsConsumed * surcharge)}");
                Console.WriteLine($"Net Amount Paid By the Customer: {(unitsConsumed * 1.50) + (Math.Ceiling(unitsConsumed * surcharge))}");
            }
            else if (400 <= unitsConsumed && unitsConsumed < 600)
            {
                Console.WriteLine($"Customer IDNO: {customerId}");
                Console.WriteLine($"Customer Name: {customerName}");
                Console.WriteLine($"Unit Consumed: {unitsConsumed}");
                Console.WriteLine($"Amount Charges @$1.80 per unit:{unitsConsumed * 1.80}");
                Console.WriteLine($"Surcharge Amount: {Math.Ceiling(unitsConsumed * surcharge)}");
                Console.WriteLine($"Net Amount Paid By the Customer: {(unitsConsumed * 1.80) + (Math.Ceiling(unitsConsumed * surcharge))}");
            }
            else if (600 < unitsConsumed)
            {
                Console.WriteLine($"Customer IDNO: {customerId}");
                Console.WriteLine($"Customer Name: {customerName}");
                Console.WriteLine($"Unit Consumed: {unitsConsumed}");
                Console.WriteLine($"Amount Charges @$2.00 per unit:{unitsConsumed * 2.00}");
                Console.WriteLine($"Surcharge Amount: {Math.Ceiling(unitsConsumed * surcharge)}");
                Console.WriteLine($"Net Amount Paid By the Customer: {(unitsConsumed * 2.00) + (Math.Ceiling(unitsConsumed * surcharge))}");
            }



        }



    }

            

           
}
        
        
    
    

