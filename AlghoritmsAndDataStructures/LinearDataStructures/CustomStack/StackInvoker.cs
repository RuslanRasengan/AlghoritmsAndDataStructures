using LinearDataStructures.Tests.CustomStackTests;

namespace LinearDataStructures.CustomStack
{
    public class StackInvoker
    {
        MyStack<int> stack = new MyStack<int>(3);

        public void InvokeMyStack()
        {
            stack.Push(10);
            stack.Push(2);
            stack.Count();
            stack.Push(1);
            stack.Count();
            stack.Pop();
            stack.Pop();
            stack.Peek();
            stack.Pop();
            stack.Count();
            stack.IsEmpty();
        }

        public void InvokeMyStackTests()
        {
            StackTests stackTests = new StackTests();
            stackTests.TestPushAndPop();
            stackTests.TestIsEmpty();
        }
    }
}
