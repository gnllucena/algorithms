using Algorithms.Auxiliar.Sorting;
using Algorithms.DynamicProgramming;
using Algorithms.Hashtable;
using Algorithms.LinkedList;
using Algorithms.Trees;
using static Algorithms.LinkedList.AddTwoNumber;

// var node = Tree.Fill(new List<int>() { 1, 2, 5, 3, 4, 6 });
// var height = HeightOfABinaryTree.Height(node);
// var order = LevelOrderTraversal.LevelTraverse(node);
// var balanced = BalancedBrackets.IsBalanced("}][}}(}][))]");


// var matrix = new List<List<int>>();
// matrix.Add(new List<int> { 2, 3 });
// matrix.Add(new List<int> { 4, -1 });
// matrix.Add(new List<int> { 5, -1 });
// matrix.Add(new List<int> { 6, -1 });
// matrix.Add(new List<int> { 7, 8 });
// matrix.Add(new List<int> { -1, 9 });
// matrix.Add(new List<int> { -1, -1 });
// matrix.Add(new List<int> { 10, 11 });
// matrix.Add(new List<int> { -1, -1 });
// matrix.Add(new List<int> { -1, -1 });
// matrix.Add(new List<int> { -1, -1 });
// var queries = new List<int>() { 2, 4 };
// var swaped = SwapNodes.Swap(matrix, queries);


// var nums = new List<int> { 2, 7, 11, 15 };
// var indexes = TwoSum.Find(nums, 9);


//var isPalindrome = PalindromeNumber.Check(121);


//var number = RomanToInteger.Convert("MCMXCIV");


// var strings = new string[] { "10", "0001", "111001", "1", "0" };
// var maximum = OnesAndZeroes.Find(strings, 5, 3);


//var first = new int[] { 2, 4, 3 };
//var second = new int[] { 5, 6, 4 };
//ListNode Create(ListNode node, int index, int[] array)
//{
//    if (index > array.Length - 1)
//    {
//        return node;
//    }

//    node = new ListNode(array[index], Create(node, index + 1, array));

//    return node;
//}
//var node1 = Create(null, 0, first);
//var node2 = Create(null, 0, second);
//var result = AddTwoNumber.Add(node1, node2);


var i = 0;

//var start = new List<int>() { 1, 1 };
//var end = new List<int>() { 5, 6 };


//var response = numberOfItems("|**|*|*", start, end);

//var i = 90;


//List<int> numberOfItems(string s, List<int> startIndices, List<int> endIndices)
//{
//    var stringona = "Murillo";

//    var teste = stringona.Substring(1, 1);

//    var sum = new List<int>();

//    for (int i = 0; i <= startIndices.Count() - 1; i++)
//    {
//        var start = startIndices[i] - 1;
//        var end = endIndices[i];

//        var stack = new Stack<char>();
//        var aux = 0;


//        var test = s.Substring(start, end);


//        for (int j = start; j < end; j++)
//        {
//            var current = s[j];

//            if (current == '|')
//            {
//                if (stack.Count() == 0)
//                {
//                    stack.Push(current);
//                }
//                else
//                {
//                    stack.Pop();
//                }
//            }
//            else if (current == '*')
//            {
//                if (stack.Count() > 0)
//                {
//                    aux++;
//                }
//            }
//        }

//        if (aux > 0)
//        {
//            sum.Add(aux);
//        }
//    }

//    if (sum.Count() == 0)
//    {
//        sum.Add(0);
//    }

//    return sum;
//}

//List<string> processLogs(List<string> logs, int threshold)
//{
//    var hashtable = new Dictionary<int, int>();
//    var response = new List<int>();

//    for (var i = 0; i <= logs.Count() - 1; i++)
//    {
//        var current = logs[i];

//        var operations = current.Split(' ');
//        var userId = Convert.ToInt32(operations[0]);
//        var senderId = Convert.ToInt32(operations[1]);

//        CheckExistence(hashtable, userId);
//        CheckExistence(hashtable, senderId);
//    }

//    foreach (var item in hashtable)
//    {
//        if (item.Value >= threshold)
//        {
//            response.Add(item.Key);
//        }
//    }

//    return response.OrderBy(x => x).Select(x => x.ToString()).ToList();
//}

//void CheckExistence(Dictionary<int, int> hashtable, int id)
//{
//    if (hashtable.ContainsKey(id))
//    {
//        hashtable[id] = hashtable[id] + 1;
//    }
//    else
//    {
//        hashtable.Add(id, 1);
//    }
//}