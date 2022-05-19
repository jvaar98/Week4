using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul konsoolis kovastakse "Vale kasutajatunnus või salasõna. Proovi uuesti."
            //kasutajal on kolm katset

            int i = 0;

            while (i < 3) //while- loop >> i = 1; 1 < 3 --> true; 2 < 3 --> true; 3 < 3 --> false
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    //(i = i + 1) == i++
                    i++;
                    Console.WriteLine($"Vale kasutajatunnus või salasõna.{3 - i} katset on jäänud.");
                }
            }
            Console.WriteLine("Head päeva!");

        }
    }
}