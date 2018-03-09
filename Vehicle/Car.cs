using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Car
    {
        public string Marka { get; set; }
        public double Capacity { get; set; }
        public double UseLitr { get; set; }
        private double Reallitr { get; set; }
        private double Global { get; set; }
      
        public Car (string Marka, double Capacity, double UseLitr, double Reallitr, double Global)
        {
            this.Marka = Marka;
            this.Capacity = Capacity;
            this.UseLitr = UseLitr;
            this.Reallitr = Reallitr;
            this.Global = Global;

        }
        double calcyol = 0;
        public void Drive (double yol)
        {
            double btnyol = this.UseLitr * this.Reallitr;
            if(yol<=btnyol)
            {
                double gedebilmesa = btnyol - yol;
                double qalanbenzin = (btnyol - yol) / this.UseLitr;
                this.calcyol += yol;
                this.Global += yol;
                this.Reallitr = qalanbenzin;
                Console.WriteLine("You can go this distance with the fuel in the tank." );
                Console.WriteLine("gasoline remain : "+ qalanbenzin +" litr");
                Console.WriteLine("Distance you can go " + gedebilmesa + " km" );

            }
            else
            {
                Console.WriteLine("You can not go this distance with fuel in your own." );
                Console.WriteLine("Maxsimum distance you can go " + btnyol + " km");
            }
        }

        public void Tank(double fill)
        {
            double ferq = this.Capacity - this.Reallitr;
            if(fill <ferq)
            {
                double plusgas = this.Reallitr + fill;
                this.Reallitr = plusgas;
                Console.WriteLine("Uploaded Capacity: " + plusgas + " litr" +  " Capacity of car:"+ this.Capacity+"litr");
            }
            else
            {
                Console.WriteLine("This is bigger than the capacity of tank car.");
                Console.WriteLine("The current level "+ this.Reallitr + "litr");
                Console.WriteLine("At the moment can be entered "+ ferq +"litr");
            }
        } public void Calcyol()
        {
            Console.WriteLine("all driving distance" + this.calcyol+" km");
        }
        public void Delete()
        {
            this.calcyol = 0;
            Console.WriteLine("Trip reseted:" + this.calcyol + "km");
        }
        public void Calcodometr()
        {
            Console.WriteLine("At the moment:"+ this.Global +" km");
        }


    }
}
