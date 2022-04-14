// See https://aka.ms/new-console-template for more information

// Instantiate
using DataStructureSpeedTest;

#region Init
List<int> list = new List<int>();
HashSet<int> hash = new HashSet<int>();
Queue<int> queue = new Queue<int>();
Stack<int> stack = new Stack<int>();
Dictionary<int, int> dict = new Dictionary<int, int>();
int[] arr = new int[3];
int max = 50000;

Init instance = new Init(max); 
#endregion

Console.WriteLine("\n Inserting Records");
#region Insert Records
Console.WriteLine("=================================== \n");

Task.WaitAll(
	//Add values to IEnumerable collection
	instance.AddItemsAsync(list),
	instance.AddItemsAsync(hash),
	instance.AddItemsAsync(queue),
	instance.AddItemsAsync(stack),
	instance.AddItemsAsync(arr),
	instance.AddItemsAsync(dict)
);

arr = instance.AddItemsAsync(arr).Result; 
#endregion

Console.WriteLine("\n Checking if values are contained");
#region Check Contained
Console.WriteLine("=================================== \n");

Task.WaitAll(
	// Contain speed test
	list.TimeMethod(list.Contains, 567),
	hash.TimeMethod(hash.Contains, 567),
	queue.TimeMethod(queue.Contains, 567),
	stack.TimeMethod(stack.Contains, 567),
	arr.TimeMethod(arr.Contains, 567),
	dict.TimeMethod(dict.ContainsKey, 567)
); 
#endregion

Console.WriteLine("\n Finding values");
#region FindValue
Console.WriteLine("=================================== \n");

Task.WaitAll(
	list.TimeMethod(list.ElementAt, 888),
	hash.TimeMethod(hash.ElementAt, 888),
	queue.TimeMethod(queue.ElementAt, 888),
	stack.TimeMethod(stack.ElementAt, 888),
	arr.TimeMethod(arr.ElementAt, 888),
	dict.TimeMethod(dict.ElementAt, 888)
); 
#endregion

Console.WriteLine("\n Removing values");
#region Remove
Console.WriteLine("=================================== \n");

Task.WaitAll(
	list.TimeMethod(list.Remove, 888),
	hash.TimeMethod(hash.Remove, 888),
	queue.TimeMethod(queue.Dequeue),
	stack.TimeMethod(stack.Pop),
	//arr.TimeMethod((from n in arr where n != 888 select n)),
	dict.TimeMethod(dict.Remove, 888)
); 
#endregion

Console.WriteLine("\n Converting to Hashset");
#region ConvertToHashset
Console.WriteLine("=================================== \n");

Task.WaitAll(
	list.TimeMethod(list.ToHashSet),
	hash.TimeMethod(hash.ToHashSet),
	queue.TimeMethod(queue.ToHashSet),
	stack.TimeMethod(stack.ToHashSet),
	arr.TimeMethod(arr.ToHashSet),
	dict.TimeMethod(dict.ToHashSet)
); 
#endregion

Console.WriteLine("\n Converting to List");
#region ConvertToList
Console.WriteLine("=================================== \n");

Task.WaitAll(
	list.TimeMethod(list.ToList),
	hash.TimeMethod(hash.ToList),
	queue.TimeMethod(queue.ToList),
	stack.TimeMethod(stack.ToList),
	arr.TimeMethod(arr.ToList),
	dict.TimeMethod(dict.ToList)
); 
#endregion

Console.WriteLine("\n Converting to Array");
#region ConvertToArray
Console.WriteLine("=================================== \n");

Task.WaitAll(
	list.TimeMethod(list.ToArray),
	hash.TimeMethod(hash.ToArray),
	queue.TimeMethod(queue.ToArray),
	stack.TimeMethod(stack.ToArray),
	arr.TimeMethod(arr.ToArray),
	dict.TimeMethod(dict.ToArray)
); 
#endregion

Console.WriteLine("Finished!");



