using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// Anonymous method 

namespace Homeworks
{
    class Program
    {

        private delegate double MeanDelegate(int a, int b, int c);

        static void Main(string[] args)
        {
            int d = 3;
            int e = 4;
            int f = 10;

            MeanDelegate mydelegate = (a, b, c) => (double) (a + b + c)/3;//Arithmetic mean of three numbers;
            Console.WriteLine(mydelegate(d,e,f));
        }
    }
}
