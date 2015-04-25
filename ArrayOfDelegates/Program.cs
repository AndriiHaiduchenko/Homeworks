using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfDelegates
{
    class Program
    {

        static Random rnd = new Random();

        private delegate int SmallDelegate();

        private delegate double BigDelegate(SmallDelegate[] arg);

        static int GetRandom()
        {
            return rnd.Next(100);
        }
       

        static void Main(string[] args)
        {

            int elements = 100;
            var array = new SmallDelegate[elements];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new SmallDelegate(GetRandom).Invoke();
            }

            BigDelegate big = delegate(SmallDelegate[] custom)
            {
                double sum = 0;
                for (int i = 0; i < custom.Length; i++)
                {
                    sum += custom[i].Invoke();
                }
                return sum/array.Length;
            };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].Invoke()+" ");

            }
            
            Console.WriteLine("\n Arithmetic mean of this numbers is {0:##.###}",big(array));

        }
    }
}
