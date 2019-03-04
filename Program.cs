using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // int score = 5;
            // // float fl = 5.5f;
            // // decimal dec;
            // // double dou;

            // score = 5.5;

            var score = 5;
            score = 12;
            score++;
            score += 6;

            Console.WriteLine(score);

            // loops
            // if 
            var isRunning = true;

            while(score<22){
                score++;
            }
            Console.WriteLine(score);

            for (var i = 0; i < 10; i++){
                Console.WriteLine(i);
            }

            Console.WriteLine("Hello World, welcome to .net!");
        }
    }
}
