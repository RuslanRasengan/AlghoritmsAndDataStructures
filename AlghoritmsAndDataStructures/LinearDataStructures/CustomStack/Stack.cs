namespace LinearDataStructures.CustomStack
{
    public class Stack<T>
    {
        private T[] stackArray;
        private int maxSize;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new T(maxSize);
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

        }

        public T Peek()
        {

        }

        public bool isEmpty()
        {
            return top == -1;
        }

        public int Count()
        {
            return top + 1;
        }
    }
}
