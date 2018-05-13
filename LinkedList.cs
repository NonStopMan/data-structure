using System;

namespace data_structure
{
    public class LinkedList
    {
        public Node Start { get; set; }
        // public Node Next { get; set; }

        override public string ToString() => String.Format("The LinkedList Is {0} ", Start?.ToString());
        // public void AddNewNodeAtTheEnd(int info)
        // {
        //     var p = this;
        //     while (p.Next != null)
        //     {
        //         p = p.Next;
        //     }
        //     p.Next = new Node(info);
        //     Console.WriteLine(this.ToString());
        // }
        public LinkedList(int info, int priority)
        {
            var p = new Node(info, priority);
            Start = p;
            Console.WriteLine("Node Inserted");
        }
        public void Insert(int info, int priority)
        {

            Node p;
            var newNode = new Node(info, priority);
            if (Start == null || Start.priority > priority)
            {
                newNode.Next = Start;
                Start = newNode;
            }
            else
            {
                p = Start;
                while (p.Next != null && p.Next?.priority <= priority)
                {
                    p = p.Next;
                }
                newNode.Next = p.Next;
                p.Next = newNode;
            }

            Console.WriteLine("Node Inserted");
        }
        public void delete(int index)
        {
            var _index = 1;
            var p = Start;
            while (p.Next != null && _index != index - 1)
            {
                p = p.Next;
                _index++;
            }
            if (_index == index - 1)
            {
                p.Next = p.Next.Next;
            }
        }
        public void Reverse()
        {
            Node p, prev = null, next = null;
            p = Start;
            while (p != null)
            {
                next = p.Next;
                p.Next = prev;
                prev = p;
                p = next;
            }
            Start = prev;
        }
        public void BubbleSortExData()
        {
            Node end, p, q;
            for (end = null; end != Start.Next; end = p)
            {
                for (p = Start; p.Next != end; p = p.Next)
                {
                    q = p.Next;
                    if (p.Info > q.Info)
                    {
                        int temp = p.Info;
                        p.Info = q.Info;
                        q.Info = temp;
                    }
                }
            }
        }
        public void BubbleSortExLink()
        {
            Node end, p, q, r;
            for (end = null; end != Start.Next; end = p)
            {
                for (r = p = Start; p.Next != end; r = p, p = p.Next)
                {
                    q = p.Next;
                    Console.WriteLine(p);
                    Console.WriteLine(q);
                    if (p.Info <= q.Info)
                    {
                        p.Next = q.Next;
                        q.Next = p;
                        if (p != Start)
                        {
                            r.Next = q;
                        }
                        else
                        {
                            Start = q;
                        }
                        Console.WriteLine(p);
                        Console.WriteLine(q);
                        p = q;
                    }
                }
            }
        }
    }
}