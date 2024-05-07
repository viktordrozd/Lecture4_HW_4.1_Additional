using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4_HW_4._1_Additional
{
    public class PseudoGraphicsAlphabet
    {
        private Dictionary<string, string> _alphabet = new Dictionary<string, string>()
        {
            {"A", " *** \n*   *\n*****\n*   *\n*   *\n*   *\n"},
            {"C", " *** \n*   *\n*    \n*    \n*   *\n *** \n"},
            {"T", "*****\n  *  \n  *  \n  *  \n  *  \n  *  \n"}
            //etc.
        };

        public  void PrintStringInPseudo(string str)
        {
            foreach (char letter in str)
            {
                //Lookup in dictionary

                string a = letter.ToString().ToUpper();

                if (_alphabet.ContainsKey(a))
                {
                    Console.WriteLine(_alphabet[a]);
                }
                else 
                {
                    Console.WriteLine($"No letter {letter} defined in the dictionary. You can add it yourself!");
                }
            }
        }
    }
}
