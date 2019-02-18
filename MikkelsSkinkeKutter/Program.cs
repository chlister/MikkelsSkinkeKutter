using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikkelsSkinkeKutter
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;

            Console.WriteLine("Start date: " + start);
            Console.WriteLine("6 hours passed? : " + start.AddMinutes(6*60));
            Console.ReadLine();
        }
    }
}
