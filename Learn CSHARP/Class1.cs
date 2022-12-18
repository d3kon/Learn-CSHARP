using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSHARP
{
    public static class LearnCSHARP
    {
        public static void Sum()
        {
            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum = {0}", x+z);
        }
        public static void Subtraction()
        {
            float x = float.Parse(Console.ReadLine());
            float z = float.Parse(Console.ReadLine());
            Console.WriteLine("Sum = {0}", x-z);
        }
        public static void Multiplication()
        {
            float x = float.Parse(Console.ReadLine());
            float z = float.Parse(Console.ReadLine());
            Console.WriteLine("Sum = {0}", x*z);
        }
        public static void Division()
        {
            float x = float.Parse(Console.ReadLine());
            float z = float.Parse(Console.ReadLine());
            Console.WriteLine("Sum = {0}", x/z);
        }

    }
    
}
