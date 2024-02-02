namespace LinearDataStructures.CustomLinkedList
{
    /** 
        This class stores an individual element
        it holds the data 
        and a reference to the next node
    **/
    public class Node
    {
        public int Data; //Stores an individual element
        public Node Next; //Refers to the next node

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
