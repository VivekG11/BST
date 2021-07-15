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
            search.InsertNode(22);
            search.InsertNode(29);
            search.InsertNode(13);
            search.InsertNode(11);
            search.InsertNode(7);
            search.InsertNode(28);
            search.InsertNode(67);
            search.InsertNode(72);
            search.InsertNode(57);
            search.Display();
            search.GetSize();
            int element = 29;
            if(search.Exist(element,search))
            {
                Console.WriteLine("Entered element is exist in tree.");
            }
            else
            {
                Console.WriteLine("Does not exist.");
            }
            Console.ReadLine();
        }
    }
}
