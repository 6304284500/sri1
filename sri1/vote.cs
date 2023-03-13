using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sri1
{
    internal class vote
    {
        public void two()
        {
            Console.WriteLine("Are you willing to vote please enter your age-");
            int age= Convert.ToInt32(Console.ReadLine());

            if (age >= 18 && age <= 60)
            {
                Console.WriteLine("Your are ELibile to cast your vote");
            }
            else if (age < 18)
            {
                Console.WriteLine("Please Study untill you make 18 to cast your vote");
            }
            else if (age > 60)
            {
                Console.WriteLine("You are too old to cast your vote best remain at home");
            }
            else 
            {
                Console.WriteLine("Please enter your in numericals ");
            }
            
        }
    }
}
