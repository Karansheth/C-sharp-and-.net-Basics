using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_training_Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "C# Exercise";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Hello, Enter Your preference from below options");
            Console.WriteLine("1) Electricity Bill Calculator");
            Console.WriteLine("2) Working of Generics in C#");
            Console.WriteLine("3) Working of Linq in C#");
            Console.WriteLine("4) Working of Extension Method");

            var input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    ElectricityBill bill = new ElectricityBill();
                    Console.WriteLine("Welcome to the Electricity Bill Calculator");
                    Console.WriteLine("Hello, you can know amount to be paid as electricity bill from here");
                    
                    Console.WriteLine("Enter your Customer ID");
                    var Customer_ID = Console.ReadLine();
                    Console.WriteLine("Enter your Name");
                    String Customer_name = Console.ReadLine();
                    Console.WriteLine("Enter the units of electricity consumed");
                    double unit_consumed = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Customer IDNO: {0}", Customer_ID);
                    Console.WriteLine("Customer Name: {0}", Customer_name);
                    Console.WriteLine("Unit Consumed: {0}", unit_consumed);
                    bill.electricity_bill_calculator(unit_consumed);
                    break;

                case 2:
                    // Add function : for int it will add two number and for string it will return combined string.

                    Console.WriteLine("Use Case of Generics");
                    Console.WriteLine("Enter 1 to add two numbers ");
                    Console.WriteLine("Enter 2 to concatenate two strings ");
                    int input1 = int.Parse(Console.ReadLine());
                    
                    if(input1 == 1)
                    {
                        Generics<int> addorconcat = new Generics<int>();
                        int first = int.Parse(Console.ReadLine());
                        int second = int.Parse(Console.ReadLine());
                        Console.Write(addorconcat.add_or_concatenate(first, second));
                    }
                    else if(input1==2)
                    {
                        Generics<string> addorconcat = new Generics<string>();
                        String first = Console.ReadLine();
                        String second = Console.ReadLine();
                        Console.Write(addorconcat.add_or_concatenate(first, second));
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                        Environment.Exit(0);
                    }
                    break;

                case 3:
                    //Arrange the distinct elements in the list in ascending order using linq.
                    
                    Console.WriteLine("Use Case of Linq");
                    Console.WriteLine("How many strings you want to sort in ascending order? ");
                    int n = int.Parse(Console.ReadLine());
                    List<String> list = new List<String>(n);
                    Console.WriteLine("Enter {0} numbers to sort them in ascending", n);

                    for(int i=0; i<n;i++)
                    {
                        list.Add(Console.ReadLine());
                    }

                    var final_list = from element in list
                                  orderby element
                                  select element;

                    foreach (string value in final_list)
                    {
                        Console.WriteLine(value);
                    }
                    
                    break;

                case 4:
                    // Added extension method on nullable Boolean type called "GetValueOrDefault" which accept default value as an argument.

                    bool? b = null;
                    bool ans;
                    Console.WriteLine("Here, initially value b is null so the answer would be default parameter");
                    ans = b.GetValueOrDefault(true);
                    Console.WriteLine(ans);
                    ans = b.GetValueOrDefault(false); 
                    Console.WriteLine(ans);
                    b = true;
                    Console.WriteLine("Now, b is assigned with value of true so answer would be true and not the default value passed");
                    ans = b.GetValueOrDefault(false); 
                    Console.WriteLine(ans);

                    break;
            }
         }
    }
}
