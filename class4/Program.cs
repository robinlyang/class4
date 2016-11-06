using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class4
{
    public static class stuff //do not need to use NEW keyword to get memory for it
    {
        public static double amount;
    }
    class payroll
    {
        public static double total = 0;
        public string name;
        public double salary;
    }
    class worker
    {
        public string name;
        public long phone { get; set; } // does nothing
        private double _rate = 0;
        public const double commision = 0.05; //use of a constant to lock in the value
        public double commisionTwo  //another to way to lock in the value
        {
            get { return 0.05; }
        }
        public readonly double commisionThree = 0.05; //a third way to lock in the value
        public double rate
        {
            get { return _rate; }
            set
            {
                if (value >= 10 && value <= 80)
                    _rate = value;
                else Console.WriteLine(value + " is not allowed");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            worker w = new worker();
            w.rate = 10;
            w.rate = 1000;
            Console.WriteLine(w.rate);

            payroll p1 = new payroll();
            payroll p2 = new payroll();
            p1.salary = 30000;
            p2.salary = 40000;
            payroll.total = payroll.total + p1.salary;
            payroll.total = payroll.total + p2.salary;
            Console.WriteLine(payroll.total);

            stuff.amount = 100;

            Console.ReadLine();
        }
    }
}
