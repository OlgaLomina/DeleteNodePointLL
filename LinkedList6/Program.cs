using LinkedList6;
using System;
/* Implement an algorithm to delete a node a singly linked list, given only access to that node.
 * */
namespace LinkedList6
{
    public class Node<T>
    {
        public Node<T> next;
        public T data;

        public Node()
        {
            next = null;
        }
        public Node(T value)
        {
            data = value;
            next = null;
        }
    }

    public class MyLL<T>
    {
        Node<T> head;

        public MyLL()
        {
            head = null;
        }

        public Node<T> AddHead(T value)
        {
            Node<T> node = new Node<T>(value);
            node.next = head;
            head = node;
            return node;
        }

        public void PrintAllNodes()
        {
            Node<T> cur = head;
            while (cur.next != null)
            {
                Console.WriteLine(cur.data);
                cur = cur.next;
            }
            Console.WriteLine(cur.data);
            Console.WriteLine();
        }

        public void DeleteNodePoint(Node<T> node)
        {
            if (node != null && node.next != null)
            {
                //Node<T> temp = node.next;
                node.data = node.next.data;
                node.next = node.next.next;
            }
            else
                Console.WriteLine("It is not possible to delete from the end");
        }
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            MyLL<char> list = new MyLL<char>();
            Node<char> node = new Node<char>();
            list.AddHead('3');
            node = list.AddHead('1');
            list.AddHead('4');
            list.AddHead('3');
            list.AddHead('2');
            list.AddHead('2');
            list.AddHead('8');

            list.PrintAllNodes();
            
            list.DeleteNodePoint(node);
            list.PrintAllNodes();


        }
    }

