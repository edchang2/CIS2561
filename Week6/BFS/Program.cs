using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    class Program
    {
        static void Main(string[] args)
        {
            //initalizing nodes
            Queue<Node> q = new Queue<Node>();
            Node n1 = new Node(2);
            Node n2 = new Node(7);
            Node n3 = new Node(5);
            Node n4 = new Node(2);
            Node n5 = new Node(6);
            Node n6 = new Node(9);
            Node n7 = new Node(5);
            Node n8 = new Node(11);
            Node n9 = new Node(4);

            //making node tree
            n1.Left = n2;
            n1.Right = n3;
            n2.Left = n4;
            n2.Right = n5;
            n5.Left = n7;
            n5.Right = n8;
            n3.Right = n6;
            n6.Right = n9;

            //put 1st node in the queue
            q.Enqueue(n1);

            do
            {
                Node n = q.Dequeue();
                Console.Write(n.Value + ",");

                if (n.Left != null)
                {
                    q.Enqueue(n.Left);
                }
                if (n.Right != null)
                {
                    q.Enqueue(n.Right);
                }

            } while (q.Count != 0);

            Console.ReadKey();


        }

    }

    class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int x)
        {
            Value = x;
        }
    }
}
