using LinearDataStructures.Tests.LinkedListTests;

namespace LinearDataStructures.CustomLinkedList
{
    public class LinkedListInvoker
    {
        public void InvokeLinkedList()
        {
            LinkedList myList = new LinkedList();

            myList.AddFirst(1);
            myList.AddFirst(2);
            myList.AddFirst(3);

            myList.PrintAllNodes();

            CustomLinkedListTest linkedListTest = new CustomLinkedListTest();
            linkedListTest.AddFirstTest();
            linkedListTest.PrintAllNodesTest();
        }
    }
}
