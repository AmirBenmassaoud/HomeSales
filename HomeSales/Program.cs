using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HomeSales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Char Nameint = '\0';

            Char Highsale ='\0';

            int DTot = 0;

            int ETot = 0;

            int FTot = 0;

            int FinalTot = 0;

            int CurrentSale = 0;
            do
            {

                do
                {
                    Console.WriteLine("Enter a initial D, E, or F. Press Z to see a grand toatal of all sales.");

                    Nameint = Console.ReadKey().KeyChar;

                    Nameint = Char.ToUpper(Nameint);

                    if (Nameint != 'D' && Nameint != 'E' && Nameint != 'F' && Nameint != 'Z')
                    {
                        Console.WriteLine("\n");

                        Console.WriteLine("You entered and invalid character, try again.");

                    }


                } while (Nameint != 'D' && Nameint != 'E' && Nameint != 'F' && Nameint != 'Z');

                Console.WriteLine("\n");

                if (Nameint != 'Z')
                {
                    Console.WriteLine("Enter Sale amount");

                    CurrentSale = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n");

                    switch (Nameint)
                    {
                        case 'D':
                            DTot = DTot + CurrentSale;
                            break;

                        case 'E':
                            ETot = ETot + CurrentSale;
                            break;

                        case 'F':
                            FTot = FTot + CurrentSale;
                            break;

                    }

                    FinalTot = FinalTot + CurrentSale;


                    if (CurrentSale > Highsale)
                    {

                        Highsale = Nameint;

                    }
                }
            } while (Nameint != 'Z');

            Console.WriteLine("Total sales for Danielle is " + DTot);

            Console.WriteLine("Total sales for Edward is " + ETot);

            Console.WriteLine("Total sales for Francis is " + FTot);

            Console.WriteLine("The grand total is " + FinalTot);

            Console.WriteLine("Person with highest sale is " + Highsale);


            Console.ReadKey();


        }
    }
}
