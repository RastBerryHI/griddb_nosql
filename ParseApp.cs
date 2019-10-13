// FIRST DAY IN C#, PARSE APP

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace ConsoleApp_FOR_STUDY_
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = " 1 sdvkskkfpokf ";

            int a;
            
            bool result = int.TryParse(str, out a);

            if (result)
            {
                Console.WriteLine("SUCCESS");
            }
            else
            {
                Console.WriteLine("unsuccess");
            }
        }
    }
}
