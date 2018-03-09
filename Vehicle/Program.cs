using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cr = new Car("BMW", 60, 10, 20, 7777);
          
            string select;
            do
            {

                Console.WriteLine("1. Drive");
                Console.WriteLine("2.Filling the tank");
                Console.WriteLine("3. All yours  local distance");
                Console.WriteLine("4. Global odometr");
                Console.WriteLine("5. Reset yours local distance");
                Console.WriteLine("0. Exit");
                select = Console.ReadLine();
                switch (Convert.ToInt32(select))
                {

                    case 1:
                        Console.WriteLine("\n");
                        Console.WriteLine("Please write your going distance:");
                    
                        string mesafe = Console.ReadLine();
                        double Mesafe = 0;
                        while (!double.TryParse(mesafe, out Mesafe))
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("you cannot write such");
                            mesafe = Console.ReadLine();
                        }
                        Console.WriteLine("\n");
                        cr.Drive(Mesafe);
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.WriteLine("\n");
                        Console.WriteLine("how many litr do you want add?:");
                        string miqdar = Console.ReadLine();
                        double Miqdar = 0;
                        while (!double.TryParse(miqdar, out Miqdar))
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("you cannot write such");
                            miqdar = Console.ReadLine();
                        }
                        Console.WriteLine("\n");
                        cr.Tank(Miqdar);
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine("\n");
                        cr.Calcyol();
                        Console.WriteLine("\n");
                        break;
                   
                    case 4:
                        Console.WriteLine("\n");
                        cr.Calcodometr();
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        Console.WriteLine("\n");
                        cr.Delete();
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        Console.WriteLine("\n");
                      
                        Console.WriteLine("\n");
                        break;
                    case 7:
                        Console.WriteLine("\n");

                        Console.WriteLine("\n");
                        break;
                    case 8:
                        Console.WriteLine("\n");

                        Console.WriteLine("\n");
                        break;
                    default:
                        break;
                }
            } while (Convert.ToInt32(select) != 0);
        }
    }
}
