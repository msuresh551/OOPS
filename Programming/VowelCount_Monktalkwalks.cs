using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
   public class VowelCount_Monktalkwalks
    {

        public static void Main()
        {

            //This Program will counts the Number of Vowels in a given string
            Console.WriteLine("Enter string to This Program will counts the Number of Vowels in a given string");
            string Input =Convert.ToString(Console.ReadLine()).ToLower();
            int Count=0;
            for (int i = 0; i < Input.Count(); i++)
            {
                if(Input[i]=='a' || Input[i] == 'e' || Input[i] == 'o' || Input[i] =='u' || Input[i] == 'i')
                {
                    Count++;
                }
            }
            Console.WriteLine("Number of vowels are "+Count);

            // Toggle String Case
            Console.WriteLine("Enter string to Toggle string Case");

            string result = string.Empty;
            string input = Convert.ToString(Console.ReadLine());
            char[] inputArray = input.ToCharArray();
            foreach (char c in inputArray)
            {
                if (char.IsLower(c))
                    result += Char.ToUpper(c);
                else
                    result += Char.ToLower(c);
            }
            Console.WriteLine("After converting upper to lower and lower to upper "+ result);

            //Check given Number is Prime or not
            bool isprime = false;
            Console.WriteLine("Enter integer to Check given Number is Prime or not ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
                Console.WriteLine("Given Number is not a prime ");
            if (number == 2)
                Console.WriteLine("Given Number is a prime ");

            for (int i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    isprime = false;
                }
            }

            if (!isprime)
                Console.WriteLine("Given Number is not a prime ");
            else
                Console.WriteLine("Given Number is a prime ");

            //Find Product of given number
            Console.WriteLine("Enter integer to Find Product of given number");
            number = Convert.ToInt32(Console.ReadLine());
            int results =1;
            for (int i = 1; i <= number; i++)
            {
                results = results * i;
            }
            Console.WriteLine("Results is "+results);


            Console.ReadKey();
            
        }
    }
}
