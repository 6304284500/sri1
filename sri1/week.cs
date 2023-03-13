using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sri1
{
    public class week
    {
        public void one ()
       {
        Console.WriteLine("Enter a Number for the week");
        int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 0:
                    Console.WriteLine("Its Sunday");
                    break;
                case 1:
                    Console.WriteLine("Its Monday");
                    break;
                case 3:
                    Console.WriteLine("Its Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Its Tuesday");
                    break;
                case 5:
                    Console.WriteLine("Its Tuesday");
                    break;
                case 6:
                    Console.WriteLine("Its Tuesday");
                    break;
                default :
                    Console.WriteLine("Please enter the range between 1-7");
                    break;
            }   
        }
    }

}
