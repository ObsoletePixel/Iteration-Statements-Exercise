namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature:
        static void PrintNumbers()
        {
            int i = -1000;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 1000);
        }
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        static void PrintEveryThirdNumber()
        {
            for(int i=3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        static bool AreNumbersEqual(int num1, int num2)
        {
            return (num1 == num2 ?  true : false);
        }
        //    - Returns true if the numbers are equal, false otherwise.
        
        // 4. Write a method that checks if a given number is even or odd.
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        //    - Returns true if the number is even, false if odd.
        
        // 5. Write a method that checks if a given number is positive or negative.
        static bool IsPositive(int number)
        {
            return number > 0;
        }
        //    - Returns true if the number is positive, false if negative.
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        static bool CanVote(int age)
        {
            return age >= 18;
        }
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        
        static bool IsInRange(int number)
        {
            return number is >= -10 and <= 10;
        }
        //    - Returns true if the number is within the range, false otherwise.
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        static void DisplayMultiplicationTable(int number)
        {
            int i = 0;
            do
            {
                Console.WriteLine($"{i} * {number} =  {i * number}");
                i++;
            } while (i <= number);
        }
        //    - Should print each line in the format: "1 * number = result"

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            PrintNumbers();
            
            PrintEveryThirdNumber();
            
            Console.WriteLine("Enter the first of two numbers for which you want to see if they are equal");
            var number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second of two numbers for which you want to see if they are equal");
            var number2 = int.Parse(Console.ReadLine());
            var equalNumberCheck = AreNumbersEqual(number1, number2);
            if (equalNumberCheck == true)
            {
                Console.WriteLine($"{number1} and {number2} are equal.");
            }
            else
            {
            Console.WriteLine($"{number1} and {number2} are not equal.");
            }
            
            Console.WriteLine("Enter a number you wish to check is even");
            var evenCandidate = int.Parse(Console.ReadLine());
            var evenNumberCheck = IsEven(evenCandidate);
            if (evenNumberCheck == true)
            {
                Console.WriteLine($"{evenCandidate} is even.");
            }
            else
            {
                Console.WriteLine($"{evenCandidate} is not even.");
            }

            Console.WriteLine("Enter a number you wish to check is positive");
            var positiveCandidate = int.Parse(Console.ReadLine());
            var positiveCheck = IsPositive(positiveCandidate);
            if (positiveCheck == true)
            {
                Console.WriteLine($"{positiveCandidate} is positive.");
            }
            else
            {
                Console.WriteLine($"{positiveCandidate} is not positive.");
            }
            
            Console.WriteLine("Enter an age to check and see if they can vote");
            var ageCandidate = int.Parse(Console.ReadLine());
            var voteAgeCheck = CanVote(ageCandidate);
            if(voteAgeCheck == true)
            {
                Console.WriteLine($"{ageCandidate} can vote.");
            } else
            {
                Console.WriteLine($"{ageCandidate} can not vote.");
            }
            
            Console.WriteLine("Enter a number to check and see if it lies within the range");
            var rangeCandidate = int.Parse(Console.ReadLine());
            var rangeCheck = IsInRange(rangeCandidate);
            if (rangeCheck == true)
            {
                Console.WriteLine($"{rangeCandidate} is within the range.");
            }
            else
            {
                Console.WriteLine($"{rangeCandidate} is not within the range.");
            }
            
            Console.WriteLine("Enter a number to print its Multiplication Table");
            var intTable = int.Parse(Console.ReadLine());
            if (intTable > 0)
            {
                DisplayMultiplicationTable(intTable);
            }
            else
            {
                Console.WriteLine("Number is invalid and has no multiplication table.");
            }
        }
    }
}
