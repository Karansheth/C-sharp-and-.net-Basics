using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_training_Exercise
{
    public class ElectricityBill
    {
       public void electricity_bill_calculator(double unit)
        {
            double amount = 0;
            double surcharge_amount = 0;

            if(unit < 0)
            {
                Console.WriteLine("Invalid. Units cannot be less than 0.");
                Environment.Exit(0);
            }
            else if(unit<200)
            {
                amount = unit * 1.20;
                if (amount < 100)
                    amount = 100;
                Console.WriteLine("Amount Charges @Rs. 1.20 per unit or minimum amount of Rs. 100: {0}", amount);
            }
            else if (unit>=200 && unit<400)
            {
                amount = unit * 1.50;
                Console.WriteLine("Amount Charges @Rs. 1.50 per unit: {0}", amount);
            }
            else if (unit >= 400 && unit < 600)
            {
                amount = unit * 1.80;
                Console.WriteLine("Amount Charges @Rs. 1.80 per unit: {0}", amount);
            }
            else
            {
                amount = unit * 2;
                Console.WriteLine("Amount Charges @Rs. 2.00 per unit: {0}", amount);
            }
            if (amount > 400)
            {
                surcharge_amount = amount * 15 / 100;
            }
            Console.WriteLine("Surcharge Amount: {0}", surcharge_amount);
            Console.WriteLine("Net Amount Paid by the Customer: {0}",amount + surcharge_amount);
        }
    }
}
