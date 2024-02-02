namespace LinearDataStructures.CustomStack
{
    public class MyStack<T>
    {
        private T[] stackArray;
        private int maxSize;
        private int top;

        public MyStack(int size)
        {
            maxSize = size;
            stackArray = new T[maxSize];
            top = -1;
        }

        public void Push(T item)
        {
            if (top < maxSize - 1 )
            {
                stackArray[++top] = item;
            }
            else
            {
                throw new InvalidOperationException("Stack overflow");
            }
        }

        public T Pop()
        {
            if (top >= 0) 
            {
                return stackArray[top--];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public T Peek()
        {
            if(top >= 0)
            {
                return stackArray[top];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public int Count()
        {
            return top + 1;
        }
    }
}
