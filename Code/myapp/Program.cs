using System;


namespace myapp
{
    class ThreeShapeTest
    {
         SocialDistance socialDistance = new SocialDistance();
         WordCount wordCount = new WordCount();
         Fibonacci fibonacci = new Fibonacci();
        Prime prime = new Prime();

        public void displayStartMessage(){
            Console.WriteLine("Welcome to my solution!");
            Console.WriteLine("The available commands are:");
            Console.WriteLine("FibonacciRequisition(n), where n is the n'th fibonaccinumber");
            Console.WriteLine("FindNPrimeNumber(n), where n is the n'th primenumber");
            Console.WriteLine("CountWords(path), where path is the absolute path to the input file");
            Console.WriteLine("SocialDistance(s, k), where s is the binary string and k is the table distance");
        }
        static void Main(string[] args)
        {
            ThreeShapeTest threeShapeTest = new ThreeShapeTest();
            threeShapeTest.displayStartMessage();
            var input = Console.ReadLine();
            threeShapeTest.Evaluate(input);
        }

        private void Evaluate(string input)
        {
            switch (input){
                case: 
            }
        }
    }

}
