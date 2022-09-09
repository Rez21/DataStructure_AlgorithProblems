using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataStructureAndAlgorithms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Data Structure & Algorithms");
            Console.WriteLine("Select an option to proceed");
            Console.WriteLine("1. String Permutation");

            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    StringPermutation stringPermutation = new StringPermutation();
                    string str = "abc";
                    int Output = str.Length;
                    StringPermutation.Permute(str, 0, Output - 1);
                    Console.ReadKey();
                    break;
            }
        }
    }
}