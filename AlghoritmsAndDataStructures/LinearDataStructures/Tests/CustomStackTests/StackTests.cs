using LinearDataStructures.CustomStack;

namespace LinearDataStructures.Tests.CustomStackTests
{
    public class StackTests
    {
        public void TestPushAndPop()
        {
            var stack = new MyStack<int>(3);
            stack.Push(1);
            stack.Push(2);

            bool result = true;

            if (stack.Pop() != 2 || stack.Pop() != 1) result = false;

            Console.WriteLine("TestPushAndPop: " + (result ? "Passed" : "Failed"));
        }

        public void TestIsEmpty() 
        {
            var stack = new MyStack<int>(3);            
            bool result = true;

            stack.Push(1);
            bool notEmptyAfterPush = !stack.IsEmpty();

            stack.Pop();
            bool emptyAfterPop = stack.IsEmpty();

            result = result && notEmptyAfterPush && emptyAfterPop;
            Console.WriteLine("TestIsEmpty" + (result ? "Passed" : "Failed"));
        }
    }
}
