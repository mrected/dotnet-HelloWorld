using System;

namespace HelloWorld
{
    class Program
    {

        // functions w/params
        static int Sum(int a, int b){
            return a + b;
        }

        static bool IsNumberHigherThan5(int num){
            return num > 5;
        }

        static void Main(string[] args)
        {
            // variables
            var score = 5;
            score = 12;
            score++;
            score += 6;

            Console.WriteLine(score);

            // if statements

            if(score < 23){
                System.Console.WriteLine("Team 1 wins");
            } else if (score > 35) {
                System.Console.WriteLine("Team 2 wins");
            } else {
                System.Console.WriteLine("tie");
            }


            // loops

            var isRunning = true;

            while(score<22){
                score++;
            }
            Console.WriteLine(score);

            for (var i = 0; i < 10; i++){
                Console.WriteLine(i);
            }

            // functions 

            var rand = new Random().Next(0,10);
            System.Console.WriteLine($"Your random number is {rand}");
            System.Console.WriteLine(IsNumberHigherThan5(rand));

            Console.WriteLine("Hello World, welcome to .net!");
        }
    }
}
