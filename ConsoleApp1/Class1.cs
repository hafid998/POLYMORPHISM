using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Printer
    {
        public string name { get; set; }
        public virtual void show()
        {
            Console.WriteLine("Epson display dimension : 10*11 ");
        }
        public virtual void print()
        {
            Console.WriteLine("Epson printer printing......");
        }
    }
    public class Epson : Printer
    {
        public virtual void show()
        {
            Console.WriteLine("Epson display dimension : 10*11 ");
        }
        public virtual void print()
        {
            Console.WriteLine("Epson printer printing......");
        }

    }
    public class Canon : Printer
    {
        public virtual void show()
        {
            Console.WriteLine("Canon display dimension : 9,5*12 ");
        }
        public virtual void print()
        {
            Console.WriteLine("Canon printer printing......");
        }

    }
    public class LaserJet : Printer
    {
        public virtual void show()
        {
            Console.WriteLine(" display dimension : 9,5*12 ");
        }
        public virtual void print()
        {
            Console.WriteLine("LaserJet printer printing......");
        }

    }
}