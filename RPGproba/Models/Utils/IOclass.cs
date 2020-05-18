using System;

namespace Adventurer.Models.Utils
{
    class IOclass
    {
        //public int Min { get; set; }
        //public int Max { get; set; }

        public static int ReadNumber()
        {
            int num;
            while(Int32.TryParse(Console.ReadLine(), out num) == false)
            {
                Console.WriteLine("Error - please try again.");
            }
            return num;
        }

        public static string ReadText()
        {
            string text = "";
            while(text == null || text.Equals(""))
            {
                text = Console.ReadLine();
            }
            return text;
        }

        public static int ChooseNumber()
        {
           
                int num;
                Console.WriteLine("Pocetak: Please input number between 1 to 6");
           
                bool IsConversionSuccessful = Int32.TryParse(Console.ReadLine(), out num);

                if (IsConversionSuccessful)
                {
                    if (num >= 1 && num <= 6)
                    {
                        return num;
                    }
                    else
                    {
                        Console.WriteLine("Trazeni broj: Please input number between 1 to 6");
                        return 0;
                    }
                }
                else
                {
                    Console.WriteLine("Nije unesen int: Please input number between 1 to 6");
                    return 0;
                } 
                  

        }
           

    }


}
