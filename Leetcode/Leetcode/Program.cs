using Leetcode.Algo;
using Leetcode.Graph;
using LeetCode.Algo;
using LeetCode.Contest.Contest26;
using LeetCode.Contest.Contest37;
using LeetCode.Curated75;
using LeetCode.December;
using LeetCode.Easy;
using LeetCode.HackerCup;
using LeetCode.Hard;
using LeetCode.July;
using LeetCode.June;
using LeetCode.May;
using LeetCode.November;
using LeetCode.October;
using LeetCode.Randoms;
using LeetCode.Rony;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode
{
	class Program
	{
		static void Main(string[] args)
		{

			#region Methods
			//new TestCode().Test();
			Others();
			//Graph();
			//Easy();
			//Hard();
			//Call_Curated75();
			//Rony();
			//Monthly();
			//Random();
			//TravelRestrictions.Main2();
			//Context();
			//Other();
			#endregion

			Console.ReadKey();
		}


		//public static string WildcardToRegex(string pattern)
		//{
		//	return "^" + Regex.Escape(pattern)
		//					  .Replace(@"\*", ".*")
		//					  .Replace(@"\?", ".")
		//			   + "$";
		//}

		private static void PrintWeek(DateTime _now)
		{
			//var currentWeekStartDate = _now.Date.AddDays(-(int)_now.DayOfWeek + 1);
			//var currentWeekEndDate = _now.Date.AddDays(-(int)_now.DayOfWeek + 7);
			var currentWeekStartDate = _now.Date.AddDays(-((7 + ((int)_now.DayOfWeek - 1)) % 7));
			var currentWeekEndDate = currentWeekStartDate.AddDays(6);
			Console.WriteLine($"today: {_now.Date} : {_now.DayOfWeek} => {currentWeekStartDate}   -   {currentWeekEndDate}");
		}

		public void StartWeekDateTest()
		{

			for (int i = 0; i < 9; i++)
			{
				var _now = DateTime.UtcNow.AddDays(i);
				PrintWeek(_now);
			}
		}

		public static void Others()
		{
			//new MedianFinder().Test();

			//int _counter = 1;
			//var heap = new SortedSet<(double, int)>();
			//heap.Add((5, _counter++));
			//heap.Add((10, _counter++));
			//heap.Add((5, _counter++));

			//foreach (var item in heap)
			//{
			//	Console.WriteLine(item.Item1 + " " + item.Item2);
			//}
		}

		public static void Graph()
		{
			//dfs
			new _547_NumberOfProvinces().Test();

		}
		public static void Easy()
		{
			//Console.WriteLine(new CountPrimes_().CountPrimes(15));
			//////
			//Console.WriteLine(string.Join(',', new FizzBuzz_().FizzBuzz(15)));
			//////
			//Console.WriteLine(new RomanToInteger().RomanToInt("LVIII"));
			//Console.WriteLine(new RomanToInteger().RomanToInt("MCMXCIV"));
			//////
			//Console.WriteLine(new _326_PowerOfThree().IsPowerOfThree(27));
		}

		public static void Hard()
		{
			/*********hard start*********/
			//Console.WriteLine(new LargestNumber_().LargestNumber(new int[] { 0, 0 }));
			//Console.WriteLine(new LargestNumber_().LargestNumber(new int[] { 10, 2 }));
			//Console.WriteLine(new LargestNumber_().LargestNumber(new int[] { 3, 30, 34, 5, 9 }));
			/*********hard end*********/
		}

		public static void Algo()
		{
			//new LinkedList().Test();
			/******************/
			//new BinaryTree().Test();
			/******************/
		}

		public static void Rony()
		{

			////DP:LIC
			////674. Longest Continuous Increasing Subsequence
			////673. Number of Longest Increasing Subsequence
			//new _300_LongestIncreasingSubsequence().Test(); //tricky, imp, solve more problems related to it
			new _909_SnakesAndLadders().Test();

			////tree
			////99.Recover Binary Search Tree
			//new _99_RecoverBinarySearchTree().Test();
		}

		public static void Call_Curated75()
		{

			//var indices = new _1_TwoSum().TwoSum(new int[] { 3, 2, 4 }, 6);
			//Console.WriteLine(string.Join(',', indices));

			//Console.WriteLine(new _121_Best_TimeToBuyAndSellStock().MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));

			//Console.WriteLine(new _217_ContainsDuplicate().ContainsDuplicate(new int[] { 1, 2, 3, 1 }));
			//Console.WriteLine(new _53_MaximumSubarray().MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
			////Console.WriteLine(new _152_MaximumProductSubarray().MaxProduct(new int[] { 2, 3, -2, 4 }));
			////Console.WriteLine(new _152_MaximumProductSubarray().MaxProduct(new int[] { -2, 3, -4 }));
			////Console.WriteLine(new _152_MaximumProductSubarray().MaxProduct(new int[] { -1, 1, -85, 1, -1, 2 }));
			////Console.WriteLine(new _152_MaximumProductSubarray().MaxProduct(new int[] { -1, -2, -9, -6 })); //108

			//Console.WriteLine(new _371_SumOfTwoIntegers().GetSum(2,4));
			//Console.WriteLine(new _191_NumberOf1Bits().HammingWeight(16));
			//new _190_ReverseBits().Test();

			////Linked List
			//new _206_ReverseLinkedList().Test();
			//new _141_LinkedListCycle().Test();

			//Matrix
			//new _73_SetMatrixZeroes().Test();

			//others
			//new _41_FirstMissingPositive().Test();

		}
		public static void Monthly()
		{
			#region December
			//new _1492_TheKthFactorOfn().Test();
			new _80_RemoveDuplicatesFromSortedArrayII().Test();
			#endregion

			#region November
			/*********Start of November *********/
			//new _1283_FindTheSmallestDivisorGivenAThreshold().Test(); //tricky;again; custom binary search; 
			//new _56_MergeIntervals().Test();
			//new _394_DecodeString().Test();
			//new _239_SlidingWindowMaximum().Test(); //tricky: again
			//new _1306_JumpGameIII().Test(); //tricky: again
			/*********End of November *********/
			#endregion

			#region October
			/*********Start of October *********/
			//Console.WriteLine(new BuddyStrings_().BuddyStrings("aaaaaaabc", "aaaaaaacb"));
			//Console.WriteLine(new BuddyStrings_().BuddyStrings("ab", "ba"));
			//Console.WriteLine(new RemoveDuplicateLetters_().RemoveDuplicateLetters("bcabc"));
			//new _189_RotateArray().Test();
			//new _74_SearchA2DMatrix().Test();
			//new _187_RepeatedDNASequences().Test();
			//new _1007_MinimumDominoRotationsForEqualRow().Test();
			//new _133_CloneGraph().Test();
			//new _735_AsteroidCollision().Test();
			//new _456_132Pattern().Test(); //tricky & important
			//new _948_BagOfTokens().Test(); //gready, retry
			//Console.WriteLine(new _1510_StoneGameIV().WinnerSquareGame(17)); //DP
			//Console.WriteLine(new _799_ChampagneTower().ChampagneTower(1, 1, 1));
			//Console.WriteLine(new _799_ChampagneTower().ChampagneTower(2, 1, 1));
			//Console.WriteLine(new _799_ChampagneTower().ChampagneTower(100000009, 33, 17));
			//Console.WriteLine(new _799_ChampagneTower().ChampagneTower(25, 6, 1));//tricky, seams easy math problem but it's kind of DP or gready
			//new _142_LinkedListCycleII(node) //tricky, LinkList
			//new _228_SummaryRanges().Test();
			//new _849_MaximizeDistanceToClosestPerson().Test();
			/*********End of October *********/
			#endregion

			#region July
			/*********Start of July *********/
			//Console.WriteLine(new AngleBetweenHandsOfAClock().AngleClock(3, 15));
			/*********End of July *********/
			#endregion

			#region June
			//Console.WriteLine(new H_IndexII().HIndex(new int[] { 0, 1, 3, 5, 6 }));
			//new SurroundedRegions().Test();
			//new CheapestFlightsWithinKStops().Test();
			//new InsertDeleteGetRandomO_1__DuplicatesAllowed().Test();
			//new TwoCityScheduling().Test();
			//new SortColors_().Test();
			//Console.WriteLine(new IsSubsequence_().IsSubsequence("abc", "ahbgdc"));
			//Console.WriteLine(new IsSubsequence_().IsSubsequence("abcd", "ahbgdc"));
			/******************/
			//Console.WriteLine(new SearchInsertPosition().SearchInsert(new int[] { 1, 3, 5, 6 }, 5));
			//Console.WriteLine(new SearchInsertPosition().SearchInsert(new int[] { 1, 3, 5, 6 }, 2));
			//Console.WriteLine(new SearchInsertPosition().SearchInsert(new int[] { 1, 3, 5, 6 }, 7));
			//Console.WriteLine(new SearchInsertPosition().SearchInsert(new int[] { 1, 3, 5, 6 }, 0));
			//Console.WriteLine(new SearchInsertPosition().SearchInsert(new int[] { 1, 3 }, 2));
			/******************/
			#endregion

		}

		public static void Random()
		{
			#region two pointers
			/*
			53 Maximum Subarray
			121 Best Time to Buy and Sell Stock
			152 Maximum Product Subarray
			238 Product of Array Except Self
			739 Daily Temperatures
			769 Max Chunks to Make Sorted
			770(768) Max Chunks to Make Sorted II
			821 Shortest Distance to a Character
			845 Longest Mountain in Array
			896 Monotonic Array

			3-pass: 42. Trapping Rain Water
			 */
			//new _845_LongestMountainInArray().Test(); //tricky;again; 

			#endregion

			#region interval or scheduling 
			/*
			 * https://leetcode.com/problems/insert-interval/
			 * https://leetcode.com/problems/teemo-attacking/
			 * https://leetcode.com/problems/partition-labels/
			 * https://leetcode.com/problems/range-module/
			 */
			//new _56_MergeIntervals().Test();

			#endregion


			#region Rotated Array
			//[solved] 153. Find Minimum in Rotated Sorted Array 
			//new _33_SearchInRotatedSortedArray().Test();
			new _81_SearchInRotatedSortedArrayII().Test();
			#endregion

			#region Digit DP
			/*
			 https://leetcode.com/problems/numbers-at-most-n-given-digit-set/discuss/168279/Python-O(logN)

			https://leetcode.com/problems/number-of-digit-one/
			https://leetcode.com/problems/digit-count-in-range/
			https://leetcode.com/problems/prime-number-of-set-bits-in-binary-representation/
			https://leetcode.com/problems/non-negative-integers-without-consecutive-ones/
			https://leetcode.com/problems/numbers-at-most-n-given-digit-set/
			https://leetcode.com/problems/count-numbers-with-unique-digits/
			https://leetcode.com/problems/numbers-with-repeated-digits/
			https://leetcode.com/problems/find-all-good-strings/

			https://www.youtube.com/watch?v=Hsnbaixm1A4
			Digit DP Basics video (part 1 of the above vide) :
			https://www.youtube.com/watch?v=5CLtoXus7O4
			 */

			#endregion

		}

		public static void Tree()
		{
			//two pointers
			/*
			 * Intention of this post is one place where you can easily do revision of tree before your upcoming interviews:
			https://leetcode.com/discuss/general-discussion/937307/iterative-recursive-dfs-bfs-tree-traversal-inorder-preorder-postorder-levelorder

			 */
		}

		public static void Context()
		{
			//new _5122_MeanOfArrayAfterRemovingSomeElements().Test();
			//new _5528_CoordinateWithMaximumNetworkQuality().Test();
		}

		public static void Other()
		{
			//var prerequisites = new int[][] {
			//	new int[] { 1,0 },
			//	new int[] { 0,1 }
			//};
			//Console.WriteLine(new CourseSchedule().CanFinish(2, prerequisites));
			/******************/
			//var list = new CountingBits().CountBits(2);
			//Console.WriteLine(string.Join(',', list));
			/******************/
			////var a = new int[] { 1, 3, 7, 1, 7, 5 };
			////var b = new int[] { 1, 9, 2, 5, 1 };
			//var a = new int[] { 2, 5, 1, 2, 5 };
			//var b = new int[] { 10, 5, 2, 1, 5, 2 };
			//Console.WriteLine(new UncrossedLines().MaxUncrossedLines(a, b));
			/******************/
			//new KthSmallestElementInaBST().Test();
			/******************/
			//new OnlineStockSpan().Test();
			/******************/
			//Console.WriteLine(new PermutationInString().CheckInclusion("ab", "eidbaooo"));
			/******************/
			//var list = new FindAllAnagramsInaString().FindAnagrams("", "abc");
			//Console.WriteLine(string.Join(',', list));
			/******************/
			//Console.WriteLine(new FormLargestIntegerWithDigitsThatAdduptoTarget().LargestNumber(new int[] { 4, 3, 2, 5, 6, 7, 2, 5, 5 }, 9));
			/******************/
			//var list = new SimplifiedFractions_().SimplifiedFractions(6);
			//Console.WriteLine(string.Join(',', list));
			/******************/
			//Console.WriteLine(new ConsecutiveCharacters().MaxPower("leetcode"));
			/******************/
			//Console.WriteLine(new RemoveKDigits().RemoveKdigits("22221432219", 3));
			//Console.WriteLine(new RemoveKDigits().RemoveKdigits("1432219", 3));
			//Console.WriteLine(new RemoveKDigits().RemoveKdigits("10200", 1));
			//Console.WriteLine(new RemoveKDigits().RemoveKdigits("10", 2));
			//Console.WriteLine(new RemoveKDigits().RemoveKdigits("100009", 3));
			/******************/
			//Console.WriteLine(new MaximumSumCircularSubarray().MaxSubarraySumCircular(new int[] { 5, -3, 5 }));
			//Console.WriteLine(new MaximumSumCircularSubarray().MaxSubarraySumCircular(new int[] { 3, -1, 2, -1 }));
			//Console.WriteLine(new MaximumSumCircularSubarray().MaxSubarraySumCircular(new int[] { -2, -3, -1 }));
			//Console.WriteLine(new MaximumSumCircularSubarray().MaxSubarraySumCircular(new int[] { 2, 3, 1 }));
			/******************/
			//new ImplementTrie_PrefixTree().Test();
			/******************/
			//var grid = new int[][] {
			//	new int[] { 1,1,1 },
			//	new int[] { 1,1,0 },
			//	new int[] { 1,0,1 }
			//};
			//var grid = new int[][] {
			//	new int[] { 0,0,0 },
			//	new int[] { 0,1,1 }
			//};
			//var image = new FloodFill_().FloodFill(grid, 1, 1, 1);
			//for (int i = 0; i < image.Length; i++)
			//{
			//	Console.WriteLine(string.Join(" ", image[i]));
			//}
			/******************/
			//Console.WriteLine(new FirstUniqueCharacterInString_5().FirstUniqChar("loveleetcode"));
			/******************/
			//Console.WriteLine(new RansomNote_3().CanConstruct("aa", "ab"));
			///******************/
			//ExtraLongFactorials.extraLongFactorials(30);
			/******************/
			//new FirstUniqueNumber().Test();
			/******************/
			//var matrix = new char[][] {
			//	new char[] { '1','1','1','1','0' },
			//	new char[] { '1','1','0','1','0' },
			//	new char[] { '1','1','0','0','0' },
			//	new char[] { '0','0','0','0','0' },
			//};
			//var matrix = new char[][] {
			//	new char[] { '0','1' },
			//	new char[] { '1','0' }
			//};
			//Console.WriteLine(new MaximalSquare_().MaximalSquare(matrix));
			/******************/
			//Console.WriteLine(new LongestCommonSubsequence_().LongestCommonSubsequence("abcde", "ace"));
			//Console.WriteLine(new LongestCommonSubsequence_().LongestCommonSubsequence("abc", "abc"));
			//Console.WriteLine(new LongestCommonSubsequence_().LongestCommonSubsequence("", ""));
			/******************/
			//Console.WriteLine(new JumpGame().CanJump(new int[] { 2, 3, 1, 1, 4 }));
			//Console.WriteLine(new JumpGame().CanJump(new int[] { 3, 2, 1, 0, 4 }));
			/******************/
			//new LRUCacheTest().Test();
			/******************/
			//Console.WriteLine(new BitwiseANDofNumbersRange().RangeBitwiseAnd(5,7));
			/******************/
			//Console.WriteLine(new SubarraySumEqualsK().SubarraySum(new int[] { 1, 2, 1, 2, 1 }, 3)); //4
			//Console.WriteLine(new SubarraySumEqualsK().SubarraySum(new int[] { -1, -1, 1 }, 0)); //1
			//Console.WriteLine(new SubarraySumEqualsK().SubarraySum(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 0)); //55
			/******************/
			//var root = new ConstructBinarySearchTreeFromPreorderTraversal().BstFromPreorder(new int[] { 8, 5, 1, 7, 10, 12 });
			//new ConstructBinarySearchTreeFromPreorderTraversal().DisplayTree(root);
			//Console.WriteLine();
			//Console.WriteLine(string.Join(',',new ConstructBinarySearchTreeFromPreorderTraversal().InorderTraversal(root)));
			/******************/
			////[1,3,1],
			////[1,5,1],
			////[4,2,1]
			//var grid = new int[][] {
			//	new int[] { 1,3,1 },
			//	new int[] { 1,5,1 },
			//	new int[] { 4,2,1 }
			//};
			//Console.WriteLine(new MinimumPathSum().MinPathSum(grid));
			/******************/
			////11110
			////11010
			////11000
			////00000
			//var grid = new char[][] { 
			//	new char[] { '1','1','1','1','0' }, 
			//	new char[] { '1','1','0','1','0' },
			//	new char[] { '1','1','0','0','0' },
			//	new char[] { '0','0','0','0','0' },
			//};
			//Console.WriteLine(new NumberOfIslands().NumIslands(grid));
			////11000
			////11000
			////00100
			////00011
			//grid = new char[][] {
			//	new char[] { '1','1','0','0','0' },
			//	new char[] { '1','1','0','0','0' },
			//	new char[] { '0','0','1','0','0' },
			//	new char[] { '0','0','0','1','1' },
			//};
			//Console.WriteLine(new NumberOfIslands().NumIslands(grid));
			/******************/
			//Console.WriteLine(new ValidParenthesisString().CheckValidString("(())**"));
			/******************/
			//var result = new ProductOfArrayExceptSelf().ProductExceptSelf(new int[] { 1, 2, 3, 4 });
			//Console.WriteLine(string.Join(',', result));
			/******************/
			//var direction = new int[][] { new int[] { 0, 1 }, new int[] { 1, 2 } };
			//Console.WriteLine(new PerformStringShifts().StringShift("abc", direction));
			////[[1,1],[1,1],[0,2],[1,3]]
			//direction = new int[][] { new int[] { 1, 1 }, new int[] { 1, 1 }, new int[] { 0, 2 }, new int[] { 1, 3 } };
			//Console.WriteLine(new PerformStringShifts().StringShift("abcdefg", direction));
			/******************/
			//Console.WriteLine(new ContiguousArray().FindMaxLength(new int[] { 1,0,0,1,1,0 }));
			/******************/
			//TreeNode root = new TreeNode(1);
			//root.left = new TreeNode(2);
			//root.right = new TreeNode(3);
			//root.left.left = new TreeNode(4);
			//root.left.right = new TreeNode(5);
			//var diameterOfBinaryTree = new DiameterOfBinaryTree_().DiameterOfBinaryTree(root);
			//Console.WriteLine(diameterOfBinaryTree);
			/******************/
			//Console.WriteLine(new LastStoneWeight().LastStoneWeight1(new int[] { 2, 7, 4, 1, 8, 1 }));
			/******************/
			//MinStack obj = new MinStack();
			//obj.Push(5);
			//obj.Push(1);
			//obj.Push(2);
			//obj.Push(3);
			//obj.Pop();
			//int param_3 = obj.Top();
			//int param_4 = obj.GetMin();
			//Console.WriteLine(param_4);
			/******************/
			//var listNode = new ListNode(1);
			//listNode.next = new ListNode(2);
			//listNode.next.next = new ListNode(3);
			//listNode.next.next.next = new ListNode(4);
			//listNode.next.next.next.next = new ListNode(5);
			//var middleNode = new MiddleOfTheLinkedList().MiddleNode_1Loop(listNode);
			//Console.WriteLine();
			/******************/
			//Console.WriteLine(new BackspaceStringCompare().BackspaceCompare("ab#c", "ad#c"));
			/******************/
			//var outputList = new CountfSmallerNumbersAfterSelf_315().CountSmaller(new int[] { 5, 2, 6, 1 });
			//Console.WriteLine(string.Join(',', outputList));
			/******************/
			//Console.WriteLine(new CountingElements().CountElements(new int[] { 1, 2, 3,1000 }));
			/******************/
			//var anagramsList = new GroupAnagrams().GroupAnagrams_(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
			//foreach (var list in anagramsList)
			//{
			//    Console.WriteLine(string.Join(',', list));
			//}
			/******************/
			//var maxProfit = BestTimeToBuyAndSellStock2.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
			//Console.WriteLine(maxProfit);
			/******************/
			//MoveZeroes.MoveZeroesFunc(new int[] { 0, 1, 0, 3, 12 });
			/******************/
			//int[] input = { -2, -1,-5,-3 };
			//var maxSum = MaximumSubarray.MaxSubArray(input);
			////var maxSum = MaximumSubarray.MaxSubArray(new int[]{ -2, 1, -3, 4, -1, 2, 1, -5, 4 });
			//Console.WriteLine(maxSum);
			/******************/
			//var isHappy = HappyNumber.IsHappy(19);
			//Console.WriteLine(isHappy);
			/*************/
			//Stopwatch timePerParse;
			//timePerParse = Stopwatch.StartNew();
			////var result = MyPow(0.00001, 2147483647);
			////var result = _50_Pow1.MyPow(2.00000, 10);
			//var result = _50_Pow1.MyPow(2.00000, -2147483648);
			//timePerParse.Stop();
			//long ticksThisTime = timePerParse.ElapsedTicks;
			//long msThisTime = timePerParse.ElapsedMilliseconds;
			//Console.WriteLine("time: " + ticksThisTime +" ticks, " + msThisTime + "ms. Result: " + result);

		}

	}
}
