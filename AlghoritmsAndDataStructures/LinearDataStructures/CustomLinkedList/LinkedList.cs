namespace LinearDataStructures.CustomLinkedList
{
    public class LinkedList
    {
        private Node head; //Start of the node
        public Node Head => head; //Return Head
        public LinkedList()
        {
            head = null;
        }

        //Method for adding a new node at the beginning of the list
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        //Method for displaying all elements of the list
        public void PrintAllNodes()
        {
            Node current = head;
            while(current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
