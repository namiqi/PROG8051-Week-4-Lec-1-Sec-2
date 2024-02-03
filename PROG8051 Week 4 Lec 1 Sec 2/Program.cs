using System;
using System.Data;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loops

            // break and continue


            // while loop
            Random rnd = new Random();
            int num = rnd.Next(1, 100);
             
            bool found = true;
            int countmyguess = 0;

            while (found)
            {
               //user input
               Console.WriteLine("Please enter your guess: ");
               int myguess = Convert.ToInt32(Console.ReadLine());
               countmyguess++;
                
               if(myguess == num)
                {
                    //found = false;
                    continue;
                    Console.WriteLine("Yay!!!");
                    
                }
               else if (myguess > num)
                {
                    Console.WriteLine("go down");
                }
                else if (myguess < num)
                {
                    Console.WriteLine("go up");
                }

            }
            
            Console.WriteLine(countmyguess);






            // For Loop
            // Counting
           /* int count = 0;

            // Totalling
            int sum = 0;
            
            for (int x = 0; x <= 10; x = x + 1)
            {
                if(x%2 == 0)
                {
                    sum = sum + x;
                    count = count + 1;
                    Console.WriteLine(x);
                }

                
            }
            Console.WriteLine("even numbers:" + count + " and the total value is : " + sum);

*/


            //  Console.WriteLine(5);
        }
    }
}