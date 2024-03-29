namespace StackAndQueue_2;

internal class Program
{
	static void Main(string[] args)
	{
		Stack<string> myStack = new();
		myStack.Push("first in line");
		myStack.Push("second in line");
		myStack.Push("third in line");
		myStack.Push("last in line");

		Queue<string> myQueue = new(myStack);
		List<string> myList = new(myQueue);
		Stack<string> anotherStack = new(myList);

		Console.WriteLine($@"myQueue has {myQueue.Count} items
myList has {myList.Count} items
anotherStack has {anotherStack.Count} items");
	}
}
