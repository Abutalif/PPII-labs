using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_finder
{
    class Program
    {
        //create a static function that finds if a given number is prime
        /*it is chosen to be static because otherwise the error appears in working
         with a main function
         */

        //returns true if the number is prime and false if otherwise
        static bool IsPrime(int a)
        {
            //math function is invoked to find out the square root of given number
            //this is done to occupy less memmory since less iterrations are made
            double root = Math.Sqrt(a);
            for (int i = 2; i <= root; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }
        

        static void Main(string[] args)
        {
            int a=0; //integer a is created

            if(args.Length>0) // check for the args to be a non-empty array
            {
                for(int i=0; i<args.Length; i++)
                {
                    a = int.Parse(args[i]);
                    if(IsPrime(a) && a!=1 && a!=0)//each numver in args[] is checked to be a prime
                    {
                        break;
                    }
                }
            }

            //if a prime in args[] is found it is printed
            //if there are no numbers in args[] or none of the existing numbers are prime
            //0 is printed on the screen
            Console.WriteLine(a);

            Console.ReadKey();
        }

    } 
}
