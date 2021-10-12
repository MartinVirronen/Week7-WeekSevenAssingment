using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int counter = 0;

            while (i < 3)
            {
                string Kasutajanimi;
                string Password;
                Console.WriteLine("PIN-kood: ");
                string PINcode = Console.ReadLine();
                Console.WriteLine("Kasutajanimi: ");
                Kasutajanimi = Console.ReadLine();
                Console.WriteLine("Password: ");
                Password = Console.ReadLine();


                if (PINcode == "1532")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }

                else if ((Kasutajanimi == "user1") && (Password == "pass1234") && (PINcode == "1532"))
                {
                    Console.WriteLine("Tere tulemast!");
                }
                else if ((Kasutajanimi != "user1") && (Password == "password1"))
                {
                    Console.WriteLine("Midagi läks valesti. Proovi uuesti.");
                }
                else if ((Kasutajanimi == "user1") && (Password != "password1"))
                {
                    Console.WriteLine("Midagi läks valesti. Proovi uuesti.");
                }
                else
                {
                    i++; //i = i + 1
                    Console.WriteLine($"Proovi uuesti! {3 - i} katset on jäänud.");
                }

            }



        }
    }
}