namespace data_structure
{
    class BinaryNode
    {
        public BinaryNode lChild { get; set; }
        public BinaryNode RChild { get; set; }
        public int Info { get; set; }
        public BinaryNode(int info)
        {
            Info = info;
            RChild = null;
            lChild = null;
        }
    }

}