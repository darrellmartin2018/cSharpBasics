using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasics
{
    class MainClass
    {
        public const byte sample1 = 0x3A;
        public byte sample2 = 58;
        public int heartRate = 85;
        public double deposit = 135002796;
        public float acceleration = 9.8f;
        public float mass = 14.6f;
        public double distance = 129.763001;
        public bool lost = true;
        public bool expensive = true;
        public int choice = 2;
        public const char integral = '\u222B';
        public const string greeting = "Hello";
        public string name = "Karen";
        public MainClass()
        {
            if (sample2.Equals(sample1)){
                Console.WriteLine("The samples are equal.");
            }
            else{
                Console.WriteLine("The samples are not equal.");
            }

            if (heartRate >= 40 && heartRate <= 80){
                Console.WriteLine("Heart rate is normal.");
            }
            else{
                Console.WriteLine("Heart rate is not normal.");
            }

            if (deposit >= 100000000){
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else{
                Console.WriteLine("Sorry you are so poor.");
            }

            float force = 0.0f;
            force = mass * acceleration;
            Console.WriteLine("Force = " + force);
            Console.WriteLine(distance + " is the distance");

            if (lost && expensive){
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if (lost && (!expensive)){
                Console.WriteLine("Here is coupon for 10% off.");
            }

            switch (choice){
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }

            Console.WriteLine(integral);

            for (int i = 5; i <= 11; i++){
                Console.WriteLine("i = " + i);
            }

            int age = 0;
            while (age < 6){
                Console.WriteLine("Age = " + age);
                age++;
            }

            Console.WriteLine(greeting + " " + name);
        }

        static void Main(string[] args){
            MainClass mainClass = new MainClass();
            Console.ReadKey();
        }
    }
}
