using LinearDataStructures.CustomLinkedList;
using LinearDataStructures.CustomStack;

class Program
{
    static void Main(string[] args)
    {
        LinkedListInvoker listInvoker = new LinkedListInvoker();
        listInvoker.InvokeLinkedList();

        StackInvoker stackInvoker = new StackInvoker();
        stackInvoker.InvokeMyStack();
        stackInvoker.InvokeMyStackTests();

        Console.ReadLine();

    }
}