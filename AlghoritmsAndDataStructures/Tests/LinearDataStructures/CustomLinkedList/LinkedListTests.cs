using LinearDataStructures.CustomLinkedList;

namespace Tests.LinearDataStructures.CustomLinkedList
{
    public class LinkedListTests
    {
        [Fact]
        public void AddFirst_AddsElementToEmptyList_SetsHeadToElement()
        {
            //Arrange
            var list = new LinkedList();
            int elementToAdd = 1;

            //Act
            list.AddFirst(elementToAdd);

            //Assert
            Assert.NotNull(list.Head);
            Assert.Equal(elementToAdd, list.Head.Data);
        }
        [Fact]
        public void PrintAllNodes_AddElementsToEmptyList_PrintAllElementsFromList()
        {
            var list = new LinkedList();

            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);

            var output = new StringWriter();
            Console.SetOut(output);

            //Act

            list.PrintAllNodes();

            //Assert
            var exceptedOutput = 
                "3" + Environment.NewLine + 
                "2" + Environment.NewLine + 
                "1" + Environment.NewLine;

            Assert.NotNull (list.Head);
            Assert.Equal (exceptedOutput, output.ToString());
        }
    }
}
