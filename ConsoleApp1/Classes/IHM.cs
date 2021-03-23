using System;
using System.Collections.Generic;
using System.Text;

namespace LePendu.Classes
{
    class IHM
    {
        public static void LePendu()
        {
            string choice;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bienvenue au jeu du pendu ! \n" +
                                "Dès que vous êtes prêt, \n" +
                                "appuyez sur la touche 1");
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                char c;
                bool win;
                choice = Console.ReadLine();
                LePendu wordFind = new LePendu(GenerateurdeMots.GenerateWord());

                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("===================================\n" +
                                        "          LE JEU DU PENDU\n" +
                                        "===================================\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Le mot à trouver : {0}", wordFind.Masque);
                    Console.WriteLine("Il vous reste {0} essais", wordFind.NumberOfTest);
                    Console.Write("Veuillez saisir une lettre : ");

                    c = Console.ReadLine()[0];
                    wordFind.TestChar(c);
                    win = wordFind.TestWin();
                } while (!win && wordFind.NumberOfTest > 0);

                if (win)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nBravo! Vous avez gagné !");
                    Console.WriteLine("Le mot à trouver était : {0}\n", wordFind.Masque);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDommage ! Vous avez perdu !");
                    Console.WriteLine("Le mot à trouver était : {0}\n", wordFind.WordFind);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (choice != "1");
            
            Console.Read();
           
        }
    }
}
