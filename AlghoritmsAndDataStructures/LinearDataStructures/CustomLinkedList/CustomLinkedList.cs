namespace LinearDataStructures.CustomLinkedList
{
    public class CustomLinkedList
    {
        private CustomNode head; //Start of the node
        public CustomLinkedList()
        {
            head = null;
        }

        //Method for adding a new node at the beginning of the list
        public void AddFirst(int data)
        {
            CustomNode newNode = new CustomNode(data);
            newNode.Next = head;
            head = newNode;
        }

        //Method for displaying all elements of the list
        public void PrintAllNodes()
        {
            CustomNode current = head;
            while(current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
