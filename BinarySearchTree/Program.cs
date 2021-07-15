using System;

namespace BinarySearchTree
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SearchTree<int> search = new SearchTree<int>(56);
            search.InsertNode(30);
            search.InsertNode(70);
            search.Display();
            search.GetSize();
            Console.ReadLine();
        }
    }
}
