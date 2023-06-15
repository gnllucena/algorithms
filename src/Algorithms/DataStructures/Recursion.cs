using Algorithms.DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Recursion
{
    internal class Recursion
    {
        public static void Green()
        {
            Console.WriteLine("NthFibonacci");

            //var result = NthFibonacci.Problem(6);

            Console.WriteLine("ProductSum");
            var arr = new List<object>(){
                5,
                2,
                new List<object>(){
                    7, -1
                },
                3,
                new List<object>(){
                    6,
                    new List<object>(){
                        -13, 8
                    },
                    4,
                },
            };

            var result = ProductSum.Problem(arr);

            Console.WriteLine(result);
        }
    }
}
