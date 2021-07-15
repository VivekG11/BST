using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class INode
    {
        public int data;
        public INode left = null;
        public INode right = null;
        public INode(int data)
        {
            this.data = data;
        }
    }
}
