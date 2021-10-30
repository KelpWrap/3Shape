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
            Console.WriteLine("Quit");
        }
        static void Main(string[] args)
        {
            ThreeShapeTest threeShapeTest = new ThreeShapeTest();
            threeShapeTest.displayStartMessage();
            while(true){
                var input = Console.ReadLine();
                threeShapeTest.Evaluate(input);
            }
        }

        private void Evaluate(string input)
        {
            string function;
            try{
                function = input.Substring(0, input.IndexOf('('));
            } catch {
                function = input;
            }
            switch (function.ToLower())
            {
                case "fibonaccirequisition":
                    break;
                case "findnprimenumber":
                    break;
                case "countwords":
                    break;
                case "socialdistance":
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
