using System;
using System.Collections.Generic;
using System.Text;

namespace LePendu.Classes
{
    class GenerateurdeMots
    {

        public static string GenerateWord()
        {
            string[] wordFind = { "cuisine", "four", "philosophie", "pomme" };
            Random r = new Random();
            return wordFind[r.Next(wordFind.Length)];
        }
    }
}
