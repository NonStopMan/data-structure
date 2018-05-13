using System;

namespace data_structure
{
    public class BinaryTree
    {
        private BinaryNode root { get; set; }
        public BinaryTree()
        {
            root = null;
        }
        public void Display()
        {
            Display(root, 0);
            Console.WriteLine();
        }
        private void Display(BinaryNode p, int level)
        {
            Console.WriteLine(String.Format("the level is {0} and the Info is {1}", level, p?.Info));
            //Console.Write(p?.Info);

            int i;
            if (p == null) return;
            Display(p.RChild, level + 1);
            Console.WriteLine();
            for (i = 0; i <= level; i++)
                //Console.Write("    ");
                //Console.Write(level);
                Display(p.lChild, level + 1);
            Console.WriteLine();
        }

        public void CreateTree()
        {
            root = new BinaryNode(1);
            root.lChild = new BinaryNode(2);
            root.RChild = new BinaryNode(3);
            root.lChild.lChild = new BinaryNode(4);
            root.lChild.RChild = new BinaryNode(5);
            root.RChild.lChild = new BinaryNode(6);
            root.RChild.RChild = new BinaryNode(7);
        }
    }
}