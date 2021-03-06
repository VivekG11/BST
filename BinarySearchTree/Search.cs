using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class SearchTree<T> where T : IComparable<T>
    {
       public T NodeData { get; set; }
        public SearchTree<T> left { get; set; }
        public SearchTree<T> right { get; set; }
        public SearchTree(T nodedata)
        {
            this.NodeData = nodedata;
            this.left = null;
            this.right = null;
        }
        int leftCount = 0, rightCount = 0;
        public void InsertNode(T item)
        {
            T current = this.NodeData;
            if ((current.CompareTo(item)) > 0)
            {
                if(this.left == null)
                {
                    this.left = new SearchTree<T>(item);
                }
                else
                {
                    this.left.InsertNode(item);
                }
            }
            else
            {
                if(this.right == null)
                {
                    this.right = new SearchTree<T>(item);
                }
                else
                {
                    this.right.InsertNode(item);
                }
            }
        }
        public void Display()
        {
            if(this.left!=null)
            {
                this.leftCount++;
                this.left.Display();
            }
            if(this.right!= null)
            {
                this.rightCount++;
                this.right.Display();
            }
        }
    }
}
