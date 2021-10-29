using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            string particpentDetails;
            Console.WriteLine("ENTER PARTICIPENT DETAILS");
           particpentDetails = Console.ReadLine();
          string [] s=  particpentDetails.Split(',');

            foreach(string k in s)
            {
                Console.WriteLine(k);
            }




           
        }
    }
}
