using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58.Length_of_Last_Word
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string input = "Hello Worldddd   ";

            Console.WriteLine(input);
            Console.WriteLine(Convert.ToInt32(LengthOfLastWord(input)));
            Console.Read();


            int LengthOfLastWord(string s)
            {
                int temp = 0;
                for(int i = s.Length-1; i > -1; i--)
                {
                    if (s[i] == ' ' && temp == 0)  continue;
                    else if (s[i] == ' ' && temp > 0) return temp;
                    temp += 1;

                }
                return temp;
            }



        }
    }
}
