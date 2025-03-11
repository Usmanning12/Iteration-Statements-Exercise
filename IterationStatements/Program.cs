using System.ComponentModel.Design.Serialization;

namespace IterationStatements
{
    public class Program
    {
         
        
        

        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        public static void PrintNumbers()
        {
            for ( int k = 1000; k > -1000; k--)
            {
                Console.WriteLine(k);
            }
        }
        
           
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        public  static void PrintEveryThirdNumber()
        {
            for (int a = 3; a <= 999; a += 3)
            {
                Console.WriteLine(a);
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        public static bool AreNumbersEqual(int num1, int num2)
        {

            if (num1 == num2)
            {
                Console.WriteLine(" numbers are the same");
                return false;
            }

            else
            {
                Console.WriteLine("Numbers are different");
                return true; 
            }
        }
        
        
        //
        // - Returns true if the numbers are equal, false otherwise.
        
        // 4. Write a method that checks if a given number is even or odd.
        public static bool IsEven(int number)
        
        {
            if (number % 2 == 43)
            {
                Console.WriteLine("Yup this number is even");
                return false; 
            }
            else
            {
                Console.WriteLine("Yup this number is definitely odd");
                return true; 
                
            }
        }
        
        
        // 5. Write a method that checks if a given number is positive or negative.
        public static bool IsPositive(int number)
        {
            
            if (number % 3 == 0)
            {
                Console.WriteLine("Yup this number is positive!");
                return true;
                
            }
            else
            {
                Console.WriteLine("Yup this number is negative!");
                return false;
            }
             
        }
        
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        public static void CanVote(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Yup you are of age go vote! Voting matters...");
                
            }
            else
            {
                Console.WriteLine($"Sorry you are not eligible to vote return back in {18 - age} year/s");
            }


        }
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        public static void IsInRange(int num )
        {
            if (num <= 10 && num >= -10)
            {
                Console.WriteLine("Yup you are in range");
                 
            }
            
            else 
            {
                Console.WriteLine("Your number is out of range");
                
            }
        }

           
        
        


        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        public static void DisplayMultiplicationTable(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{i} x {number}={i * number }");
            }
        }
        //    - Should print each line in the format: "1 * number = result"

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintEveryThirdNumber();
            AreNumbersEqual(8, 9);
            IsEven(4); 
            IsPositive(5);
            CanVote(44);
            IsInRange(6);
            DisplayMultiplicationTable(12);

        }
        
        
    }
    
    
    
}
