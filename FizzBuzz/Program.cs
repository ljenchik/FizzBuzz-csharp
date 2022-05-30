using System;

namespace FizzBuzz {
    public class Program {
        public static void Main(string[] args) 
        {
            int maxNumber;
            if (args.Length == 0) 
            {
                maxNumber = 100;
            }
            else 
            {
                maxNumber=int.Parse(args[0]);
            }

            FizzBuzz fizzBuzz = new FizzBuzz();
            fizzBuzz.DoFizzBuzz(maxNumber);
            
        }
    }
}