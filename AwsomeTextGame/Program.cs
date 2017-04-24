using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsomeTextGame{
    using Units;

    class Program
    {
        static void Main(string[] args)
        {
           
            Character newChar = new Character();
            
            int char_id = 3;            
            string name;
            
            //skapar ett random värde mellan 1 - 31 och lägger det i char_id
            //Random id = new Random();
            //char_id = id.Next(1,31);
            
            Console.WriteLine("Hej!");
            Console.WriteLine(" ");               
                                   
            Console.WriteLine("Fyll i karaktärens namn: ");
            name = Console.ReadLine();




            Console.WriteLine(" ");    
            Console.WriteLine("Karaktärens id är: " + char_id);
            Console.WriteLine("Karaktärens namn är: " + name);
            newChar.move();

            

            // Keep the console window open in debug mode.   
            Console.WriteLine(" ");    
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();




        }
    }
}



