namespace LinearDataStructures.CustomLinkedList
{
    /** 
        This class stores an individual element
        it holds the data 
        and a reference to the next node
    **/
    public class CustomNode
    {
        public int Data; //Stores an individual element
        public CustomNode Next; //Refers to the next node

        public CustomNode(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
