using System;

namespace Functional
{
    class Program
    {
        static int playerHealth = 100;
        static int monsterDamage = 30;
        static void MonsterEncounter()
        {
            Console.WriteLine("A vicious TURD appears!");
            Console.ReadKey();
        }
        static void MonsterAttacks(int damage)
        {
            int combo = 0;
            combo++;
            playerHealth -= damage;
            Console.WriteLine($"The poop monster attacks you for {damage} points of damage. You have {playerHealth} helath left");
        }

        static int numberOne = 10;
        static int numberTwo = 200;
        static void Start()
        {
            Console.WriteLine("Type in first integer");
        One:
            string inputOne = Console.ReadLine();
            bool isParsableOne = Int32.TryParse(inputOne, out numberOne);
            if (isParsableOne)
            {

            }
            else
            {
                Console.WriteLine("A whole number please");
                goto One;
            }
            Console.WriteLine("Type in second integer");
        Two:
            string inputTwo = Console.ReadLine();
            bool isParsableTwo = Int32.TryParse(inputTwo, out numberTwo);
            if (isParsableTwo)
            {

            }
            else
            {
                Console.WriteLine("A whole number please");
                goto Two;
            }

            int biggestNumber = ReturnBiggestNumber(numberOne, numberTwo);

            Console.WriteLine($"Of {numberOne} and {numberTwo} the biggest number is {biggestNumber}");
            Console.ReadKey();
        }
  
        static int ReturnBiggestNumber(int first, int second)
        {
            if (first > second)
            {
                return first;
            } 
            else
            {
                return second; 
            }
        }
        static void Main()
        {
            Start();
        }
    }
}
