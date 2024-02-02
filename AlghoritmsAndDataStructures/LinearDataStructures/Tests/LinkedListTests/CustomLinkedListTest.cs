using LinearDataStructures.CustomLinkedList;

namespace LinearDataStructures.Tests.LinkedListTests
{
    public class CustomLinkedListTest
    {
        public void AddFirstTest()
        {
            var list = new LinkedList();

            list.AddFirst(1);

            if (list.Head.Data != 1)
            {
                Console.WriteLine("Add first failed: the first element is missing!");
            }
            else
            {
                Console.WriteLine("AddFirstTest Passed.");
            }
        }

        public void PrintAllNodesTest()
        {
            var list = new LinkedList();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            Console.WriteLine("Expected output: 3 2 1");
            Console.Write("Actual output: ");
            list.PrintAllNodes();;
        }
    }
}
