using System;

namespace Adventurer.Models.Utils
{
    class IOclass
    {     
        public static int ReadNumber()
        {
            int num;
            while(Int32.TryParse(Console.ReadLine(), out num) == false)
            {
                Console.WriteLine("Error - please enter number.");
            }
            return num;
        }

        public static int ChooseWeaponNumber()
        {           
             int num;
             bool IsConversionSuccessful = Int32.TryParse(Console.ReadLine(), out num);

             if (IsConversionSuccessful)
             {
                 if (num >= 1 && num <= 6)
                 {
                    return num;
                 }
                 else
                 {
                    Console.WriteLine("Please input number between 1 to 6");
                 return 0;
                 }
             }
             else
             {
                 Console.WriteLine("Please input number between 1 to 6");
                 return 0;
             }                  
        }        
    }
}
