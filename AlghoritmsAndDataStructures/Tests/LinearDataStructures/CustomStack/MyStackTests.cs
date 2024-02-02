using LinearDataStructures.CustomStack;

namespace Tests.LinearDataStructures.CustomStack
{
    public class MyStackTests
    {
        [Fact]
        public void Push_AddNewElementToEmptyStack()
        {
            //Arrange
            var stack = new MyStack<int>(3);
            int elementToAdd = 5;
            
            //Act
            stack.Push(elementToAdd);

            //Assert
            Assert.NotNull(stack);
            Assert.Equal(elementToAdd, stack.Peek());
        }

        [Fact]
        public void PopAndIsEmpty_AddNewElementToEmptyStackRemoveElementAndCheckThis()
        {
            //Arrange
            var stack = new MyStack<int>(3);
            int elementToAdd = 5;

            //Act
            stack.Push(elementToAdd);
            //Assert
            Assert.NotNull(stack);
            Assert.Equal(elementToAdd, stack.Peek());

            stack.Pop();
            Assert.True(stack.IsEmpty());
        }
    }
}
