using System;

/* Jace Hamblin
 * IT112
 * NOTES:
 * BEHAVIORS NOT IMPLEMENTED AND WHY: 
*/
namespace Hamblin_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            HomePhone test = new HomePhone("test", "aaaaa", "test again");
            Phone[] PhoneArray = new Phone[10];
            PhoneArray[0] = test;
            for (int i = 0; i <= 0; i++)
            {
                Console.WriteLine(PhoneArray[i].Dial());
            }
        }
    }
}
