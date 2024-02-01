using LinearDataStructures.CustomLinkedList;

class Program
{
    static void Main(string[] args)
    {
        CustomLinkedList myList = new CustomLinkedList();

        myList.AddFirst(1);
        myList.AddFirst(2);
        myList.AddFirst(3);

        myList.PrintAllNodes();

        Console.ReadLine();

    }
}