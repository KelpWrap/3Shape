using System;


namespace myapp
{
    class ThreeShapeTest
    {
        SocialDistance socialDistance = new SocialDistance();
        WordCount wordCount = new WordCount();
        Fibonacci fibonacci = new Fibonacci();
        Prime prime = new Prime();

        public void displayStartMessage()
        {
            Console.WriteLine("Welcome to my solution!");
            Console.WriteLine("The available commands are:");
            Console.WriteLine("FibonacciRequisition(n), where n is the n'th fibonaccinumber");
            Console.WriteLine("FindNPrimeNumber(n), where n is the n'th primenumber");
            Console.WriteLine("CountWords(path), where path is the absolute path to the input file");
            Console.WriteLine("SocialDistance(s, k), where s is the binary string and k is the table distance");
            Console.WriteLine("Quit()");
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            ThreeShapeTest threeShapeTest = new ThreeShapeTest();
            threeShapeTest.displayStartMessage();
            while (true)
            {
                var input = Console.ReadLine();
                threeShapeTest.Evaluate(input);
                Console.WriteLine("");
            }
        }

        private void Evaluate(string input)
        {
            string function;
            string arguments;
            //Seperate input command into what function is being called and what the input to that function will be.
            try
            {
                int argumentStart = input.IndexOf('(') + 1;
                function = input.Substring(0,  argumentStart - 1);
                arguments = input.Substring(argumentStart, input.IndexOf(')') - argumentStart);
            }
            catch
            {
                arguments = "";
                function = "";
            }
            //Compare function name
            switch (function.ToLower())
            {
                case "fibonaccirequisition":
                    if (Int32.TryParse(arguments, out int fibArg1))
                    {
                        Console.WriteLine(fibonacci.CalculateFib(fibArg1));
                    } else {
                        Console.WriteLine("The number you entered is not valid");
                    }
                    break;
                case "findnprimenumber":
                    if (Int32.TryParse(arguments, out int primeArg1))
                    {
                        Console.WriteLine(primeArg1);
                        Console.WriteLine(prime.Calculate(primeArg1));
                    } else {
                        Console.WriteLine("The number you entered is not valid");
                    }
                    break;
                case "countwords":
                    wordCount.Count(arguments);
                    break;
                case "socialdistance":
                    int delimiterPos = arguments.IndexOf(',');
                    string sdArg1 = arguments.Substring(0,delimiterPos);
                    string sdArg2S = arguments.Substring(delimiterPos+1, arguments.Length-delimiterPos-1);
                    if (Int32.TryParse(sdArg2S, out int sdArg2))
                    {
                        Console.WriteLine(socialDistance.MaxChanges(sdArg1, sdArg2));
                    } else {
                        Console.WriteLine("The number you entered is not valid");
                    }
                    break;
                case "quit":
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("The command you entered is not valid");
                    break;
            }
        }
    }

}
