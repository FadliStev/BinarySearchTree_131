using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_A
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Constructor for the Node Class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }
    /*A node class consists of three things, the information, refenrences to the right child, and references to the left child*/

    class Program
    {
        public Node ROOT;
        public Program()
        {
            ROOT = null; /* Intializing ROOT to null*/
        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {

        }

        static void Main(string[] args)
        {
        }
    }
}
