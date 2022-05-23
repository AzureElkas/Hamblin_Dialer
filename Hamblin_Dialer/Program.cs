using System;

/* Jace Hamblin
 * IT112
 * NOTES: I was tempted to put in a piece into the for loop that'd display what type the number dialed was, but decided it was
 * wiser to leave it as it is for the sake of this project at least. I feel like the overridden logic in CellPhone could be implemented better,
 * it feels unclean to write basically exactly the same code but with a 1 put into it. Maybe it'd be possible to split it up using a substring, but 
 * with exact lengths being variable due to the way the output is made I don't feel confident playing around with it in time, something to think about going forward
 * BEHAVIORS NOT IMPLEMENTED AND WHY: None, to my knowledge
*/
namespace Hamblin_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone[] PhoneArray = new Phone[10];
            PhoneArray[0] = new HomePhone("CompuTest", "(303) 985-5060", "1");
            PhoneArray[1] = new CellPhone("Curtis Manufacturing", "(603) 532-4123", "2");
            PhoneArray[2] = new HomePhone("Data Functions", "(800) 876-2524", "1");
            PhoneArray[3] = new HomePhone("Donnay Repair", "(708) 397-3330", "1");
            PhoneArray[4] = new HomePhone("ErgoNomic Inc", "(360) 969-4394", "1");
            PhoneArray[5] = new HomePhone("ErgoSource", "(800) 969-4374", "1");
            PhoneArray[6] = new CellPhone("Fox Bay Industries", "(800) 874-8527", "2");
            PhoneArray[7] = new CellPhone("Glare-Guard", "(800) 545-6254", "2");
            PhoneArray[8] = new CellPhone("Hazard Comm Specialists", "(407) 783-6641", "2");
            PhoneArray[9] = new CellPhone("Komfort Support", "(714) 472-4409", "2");
            for (int i = 0; i <= PhoneArray.Length - 1; i++)
            {
                Console.WriteLine(PhoneArray[i].Dial().Trim());
            }
        }
    }
}
