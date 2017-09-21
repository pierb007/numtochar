using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numtochar
{
    class Program
    {
        static void Main(string[] args)
        {}
        public string WriteNumToChar(string str)
        {
            string returnStr = "";
            foreach (char c in str)
            {
                returnStr = returnStr + (int)c + "";                
            }
            return returnStr;
            Console.ReadLine();
        }       
    }
}
