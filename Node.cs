using System;

namespace data_structure
{
    public class Node
    {
        public int Info { get; set; }
        public Node Next { get; set; }
        public int priority { get; set; }
        //public Node Start { get; set; }
        

        override public string ToString() => String.Format("The Info Is {0} {1}", Info, Next?.ToString());
        public Node(int info, int _priority)
        {
            Info = info;
            priority = _priority;
        }
        public void AddNewNodeAtTheEnd(int info)
        {
            // var p = this;
            // while (p.Next != null)
            // {
            //     p = p.Next;
            // }
            // p.Next = new Node(info);
            // Console.WriteLine(this.ToString());
        }
        public void AddNewNodeAtTheBegining(int info)
        {
               // var p = new Node(info);
        }
    
    }
}