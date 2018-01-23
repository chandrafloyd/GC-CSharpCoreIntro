using System;

namespace CSharpCoreIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            double Input;

            // input 
            Console.WriteLine("Please enter a number");
            Input = float.Parse(Console.ReadLine());

            // processing
            //Input = Input + 1; //canalso write Inpt+=1; Input++; to get the same effect
            Input = Math.Sqrt(Input); //math returns double

            //output
            Console.WriteLine($"Output is equal to: {Input}");
            Console.Read();
        }
    }
}
