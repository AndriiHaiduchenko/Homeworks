using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону Console Application . Создайте класс MyClass < T >, содержащий статический фабричный метод 
//T FacrotyMethod (), который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т).


namespace ConsoleApplication2
{

    internal class Myclass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return  new T();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int instance1 = Myclass<int>.FactoryMethod();
            Console.WriteLine(instance1.GetType().Name);
            object instance2 = Myclass<object>.FactoryMethod();
            Console.WriteLine(instance2.GetType().Name);

        }
    }
}
