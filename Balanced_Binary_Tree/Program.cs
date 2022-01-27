using System;
using System.Collections.Generic;
using System.Collections;

namespace Balanced_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int> { 1, 11, 3, 9, 11, 7 };
            
            AVLTree<int> abc = new AVLTree<int>();

            foreach (int item in l1)
            {
                abc.Add(item);

            }

            var depth = abc.;
            var tempo = abc.GetInOrderEnumerator();

            Console.WriteLine(tempo.ToString());
            

        }
    }
}
