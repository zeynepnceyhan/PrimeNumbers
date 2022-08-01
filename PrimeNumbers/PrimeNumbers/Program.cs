namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrimeNumber(int number)
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }

                }
                return true;
            }


            Console.WriteLine("Please, give me a number...");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (isPrimeNumber(number))
                {
                    Console.WriteLine("This number is a prime number.");
                }
                else
                {
                    Console.WriteLine("This number is not a prime number.");
                }
            }
            else
            {
                Console.WriteLine("your input is not a number!");
            }
            Console.ReadLine();

        }
        
    }
}