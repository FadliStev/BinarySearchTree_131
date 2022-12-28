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
            /* This function search the currentNode of the specifiedd Node as well as the current Node of its parents*/
            currentNode = ROOT;
            parent = null;
            while((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if(string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }

        public void insert(string element)/* Insert a node in teh binary search tree*/
        {
            Node tmp, parent = null, currenNode = null;
                search(element, ref parent, ref currenNode);
            if(currenNode != null)/* Check if teh node to be inserted already insered or not*/
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else/* If the specified node is not present*/
            {
                tmp = new Node(element, null, null);/* Creates a node*/
                if(parent == null)/* if the trees is empty*/
                {
                    ROOT = tmp;
                }
                else if(string.Compare(element, parent.info) < 0)
                {
                    parent.leftchild = tmp;
                }
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
