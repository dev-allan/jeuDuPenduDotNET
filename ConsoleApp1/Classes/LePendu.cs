using System;
using System.Collections.Generic;
using System.Text;

namespace LePendu.Classes
{
    class LePendu
    {
        private int numberOfTest = 10;
        private string masque;
        private string wordFind;

        public int NumberOfTest { get => numberOfTest; set => numberOfTest = value; }
        public string Masque { get => masque; set => masque = value; }
        public string WordFind { get => wordFind; set => wordFind = value; }

        public LePendu(string word)
        {
            wordFind = word.ToUpper();
            GenerateMasque();
        }

        public bool TestWin()
        {
            return !masque.Contains("*");
        }



        public bool TestChar(char c)
        {
            c = Char.ToUpper(c);
            numberOfTest--;
            if (wordFind.Contains(c))
            {
                StringBuilder ch = new StringBuilder(masque);
                for (int i = 0; i < wordFind.Length; i++)
                {
                    if (wordFind[i] == c)
                    {
                        ch[i] = c;
                    }
                }
                masque = ch.ToString();
                numberOfTest++;
                return true;
            }
            return false;
        }

        public void GenerateMasque()
        {
            masque = new string('*', wordFind.Length);
        }
    }
}
