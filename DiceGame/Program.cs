using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, ongi mängu võitja;
            //*täringuid visatakse kolm korda;
            //programm kuulutab võitja.

            int i = 0;

            while (i < 3)
            {
                Random rnd = new Random();

                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);

                int cpuScore = 0;
                int userScore = 0;


                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    i++;
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    userScore = userScore + 1;

                }
                else if (cpuRandom > userRandom)
                {
                    i++;
                    Console.WriteLine("Arvuti on mängu võitnud.");
                    cpuScore = cpuScore + 1;

                }
                else
                {
                    i++;
                    Console.WriteLine("Viik!");
                }

            }
            
            Console.WriteLine($"Arvuti lõpptulemus {cpuScore}. Kasutaja lõpptulemus {userScore}");
        }
    }
}
