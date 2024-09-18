using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string operater = "";
            bool running=false;

            while (running != true)
            {
                Console.WriteLine("Din smarte lommeregner");
                Console.WriteLine("tast 1 for plus");
                Console.WriteLine("tast 2 for minus");
                Console.WriteLine("tast 3 for gange");
                Console.WriteLine("tast 4 for divideret");
                Console.WriteLine("tast q for at quit");

                operater = (Console.ReadLine());
                double x = 0;
                double y = 0;
                
                Calculator myCalulator = new Calculator();

                switch (operater)

                    {
                    case "1":
                        InputHandling(out x, out y);
                        Console.WriteLine("Svaret er: " + myCalulator.Add(x, y));
                        PrintLastText();
                        break;
                

                    case "2":
                        
                        InputHandling(out x, out y);
                        Console.WriteLine("svaret er "+myCalulator.Sub(x,y));
                        PrintLastText();
                        break ;

                    case "3":
                        InputHandling(out x, out y);
                        Console.WriteLine("svaret er " + myCalulator.Mul(x, y));
                        PrintLastText();
                        break;

                    case "4":
                        InputHandling(out x, out y);
                        Console.WriteLine("svaret er " + myCalulator.Div(x, y));
                        PrintLastText();
                        break;


                    case "q":
                        Console.Clear();
                        Console.WriteLine("you quit");
                        running = true;
                        break;

                    default:
                        PrintLastText();
                        Console.Write("error you entered an invalid charektor\n");
                        break;  
                
                
                }

               



            }
        }
        private static void InputHandling(out double x, out double y)
        {
            Console.Clear();
            Console.Write("Indtast første tal: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Indtast andet tal: ");
            y = double.Parse(Console.ReadLine());
           Console.Clear();
        }

        static void PrintLastText()
        {
            Console.WriteLine("\n -----------------------------\n press q to quit or any other key to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
    public class Calculator
    {
        public double Add (double x, double y)
        { 
           Console.WriteLine("Your result");
            return x + y;
        }
        public double Sub(double x, double y)
        {
            Console.WriteLine("You chose subtraktion");
            return x - y;
        }
        public double Mul(double x, double y)
        {
            Console.WriteLine("You chose to multiply");
            return x * y;
        }
        public double Div(double x, double y)
        {
            Console.WriteLine("You chose divission");
            return x / y;
        }
        

    }

}
