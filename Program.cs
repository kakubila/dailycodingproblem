﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{
	class Program
	{
		static void Main(string[] args)
		{
			DailyCodingProblem02232019 dcp = new DailyCodingProblem02232019();
			dcp.MinUniquePrefix();

			/*
			DailyCodingProblem02172019 dcp = new DailyCodingProblem02172019();
			dcp.MinimumPowerSum(Int32.Parse(args[0]), Int32.Parse(args[1]), true);
			*/

			/*
			DailyCodingProblem01142019 dcp = new DailyCodingProblem01142019();

			int[,] matrix = { 
								{0, 3, 1, 1 },
								{2, 0, 0, 4 },
								{1, 5, 3, 1 }
							};
			Console.WriteLine(dcp.MaxNumberCoins(matrix));
			*/

			/*
			Tree tree = new Tree(1);
			tree.left = new Tree(2);
			tree.right = new Tree(3);
			tree.right.left = new Tree(4);
			tree.right.right = new Tree(5);

			DailyCodingProblem01022019 dcp = new DailyCodingProblem01022019();
			IList<List<int>> paths = dcp.AllPaths(tree);

			foreach (List<int> path in paths)
			{
				foreach (int n in path)
				{
					Console.Write("{0} ", n);
				}
				Console.WriteLine();
			}
			*/

			/*
			DailyCodingProblem12262018 dcp = new DailyCodingProblem12262018();
			Console.WriteLine(dcp.MinCoveringSubstring(args[0], args[1]));
			*/

			/*
			DailyCodingProblem12252018 dcp = new DailyCodingProblem12252018();
			int[] input = new int[args.Length];
			for (int i = 0; i < args.Length - 1; i++)
			{
				input[i] = Int32.Parse(args[i]);
			}
			int k = Int32.Parse(args[args.Length - 1]);
			dcp.ContiguousElementsSum(input, k);
			*/

			/*
			DailyCodingProblem12242018 dcp = new DailyCodingProblem12242018();
			dcp.MinGoldbachNumbers(Int64.Parse(args[0]));
			*/

			/*
			DailyCodingProblem12222018 dcp = new DailyCodingProblem12222018();
			int[] numbers = { 100, 4, 200, 1, 3, 2 };
			Console.WriteLine(dcp.LongestConsecutiveElementSequence(numbers));
			*/

			/*
			DailyCodingProblem12162018 dcp = new DailyCodingProblem12162018();
			Tree tree = dcp.BuildTree();
			Console.WriteLine(dcp.LargestBST(tree));
			*/

			/*
			DailyCodingProblem12092018 dcp = new DailyCodingProblem12092018();
			Console.WriteLine(dcp.BracketsMistakes(args[0]));
			*/

			/*
			Tree tree = new Tree(10);
			tree.left = new Tree(5);
			tree.right = new Tree(15);
			tree.left.left = new Tree(2);
			tree.right.right = new Tree(20);
			tree.right.right.right = new Tree(23);

			DailyCodingProblem12032018 dcp = new DailyCodingProblem12032018();
			Console.WriteLine(dcp.DeepestNodeValue(tree));
			*/

			/*
			DailyCodingProblem11222018 dcp = new DailyCodingProblem11222018();

			int[] input = new int[args.Length];
			for (int i = 0; i < args.Length; i++)
			{
				input[i] = Int32.Parse(args[i]);
			}

			Console.WriteLine(dcp.Max3(input));
			*/

			/*
			DailyCodingProblem11182018 dcp = new DailyCodingProblem11182018();

			int n = 3;
			int m = 5;
			int[,] matrix = new int[n, m];

			int index = 0;
			for (int r = 0; r < n; r++)
				for (int c = 0; c < m; c++)
					matrix[r, c] = ++index;

			dcp.PrintSpiral(matrix, n, m);
			*/

			/*
			DailyCodingProblem11152018 dcp = new DailyCodingProblem11152018();
			Console.WriteLine(dcp.NumberWaysDown(Int32.Parse(args[0]), Int32.Parse(args[1])));
			*/

			/*
			DailyCodingProblem11142018 dcp = new DailyCodingProblem11142018();
			long x = Int64.Parse(args[0]);
			long y = Int64.Parse(args[1]);
			Console.WriteLine(dcp.Exponentiation(x, y));
			*/

			/*
			DailyCodingProblem11112018 dcp = new DailyCodingProblem11112018();
			int[] input = new int[args.Length];
			for (int i = 0; i < args.Length; i++)
			{
				input[i] = Int32.Parse(args[i]);
			}
			Console.WriteLine(dcp.PartitionTwoSubsets(input));
			*/

			/*
			DailyCodingProblem11082018 dcp = new DailyCodingProblem11082018();
			dcp.GenerateTokens(args[0]);
			Random rd = new Random();
			for (int i = 0; i < 1000; i++)
			{
				string token = rd.Next(0, 1000).ToString();
				Console.WriteLine("Long {0} => Short {1}", token, dcp.ShortenURL(token));

				if (rd.Next(0, 10) == 7)
				{
					Console.WriteLine("Short {0} => Long {1}", dcp.ShortenURL(token), dcp.RestoreURL(dcp.ShortenURL(token)));
				}
				Console.ReadLine();
			}
			*/

			/*
			DailyCodingProblem11062018 dcp = new DailyCodingProblem11062018();
			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine("Enqueue: {0}", i);
				dcp.Enqueue(i.ToString());

				if ((new Random()).Next(0, 10) == 7)
				{
					Console.WriteLine("Dequeue: {0}", dcp.Dequeue());
				}
				Console.ReadLine();
			}
			*/

			/*
			DailyCodingProblem11052018 dcp = new DailyCodingProblem11052018(5);

			for (; ; )
			{
				Random rd = new Random();

				string key = "";
				if (rd.Next(0, 10) == 7)
				{
					key = rd.Next(0, 10).ToString();
					string value = dcp.Get(key);
					if (String.IsNullOrEmpty(value))
					{
						Console.WriteLine("GetKey({0}) = null", key);
					}
					else
					{
						Console.WriteLine("GetKey({0}) = {1}", key, value);
					}
				}
				else
				{
					key = rd.Next(0, 10).ToString();
					string value = rd.Next(11, 100).ToString();
					dcp.Set(key, value);
				}

				Console.ReadLine();
			}
			*/

			/*
			TreeChar expression = new TreeChar('*');
			expression.left = new TreeChar('+');
			expression.right = new TreeChar('+');
			expression.left.left = new TreeChar('3');
			expression.left.right = new TreeChar('2');
			expression.right.left = new TreeChar('4');
			expression.right.right = new TreeChar('5');

			DailyCodingProblem11032018 dcp = new DailyCodingProblem11032018();
			Console.WriteLine(dcp.EvaluateTreeExpression(expression));
			*/

			/*
			DailyCodingProblem11022018 dcp = new DailyCodingProblem11022018();

			int[] input = new int[args.Length];
			for (int i = 0; i < args.Length; i++)
			{
				input[i] = Int32.Parse(args[i]);
			}

			Console.WriteLine(dcp.MaximunSum(input));
			*/

			/*
			DailyCodingProblem11012018 dcp = new DailyCodingProblem11012018();
			TreeChar tree = dcp.BuildTree("abdecfg", "dbeafcg");
			Console.WriteLine();
			*/

			/*
			DailyCodingProblem10312018 dcp = new DailyCodingProblem10312018();

			int[] input = new int[args.Length];
			for (int i = 0; i < args.Length; i++)
			{
				input[i] = Int32.Parse(args[i]);
			}
			Console.WriteLine(dcp.MaxProfit(input));
			*/

			/*
			DailyCodingProblem10302018 dcp = new DailyCodingProblem10302018();
			Console.WriteLine(dcp.LongestPalindrome(args[0]));
			*/

			/*
			DailyCodingProblem10292018 dcp = new DailyCodingProblem10292018();
			dcp.RndMGivenN(Int32.Parse(args[0]), Int32.Parse(args[1]));
			*/

			/*
			DailyCodingProblem10262018 dcp = new DailyCodingProblem10262018();

			int[] input = new int[args.Length - 1];
			for (int i = 0; i < args.Length - 1; i++)
			{
				input[i] = Int32.Parse(args[i]);
			}
			int target = Int32.Parse(args[args.Length - 1]);

			int[] retVal = dcp.FindSubsetAddsToTarget(input, target);
			if (retVal != null)
			{
				Console.Write("Solution:");
				for (int i = 0; i < retVal.Length; i++)
				{
					Console.Write(" {0}", retVal[i]);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("No Solution");
			}
			*/

			/*
			int[] numbers = { 3, 3, 3, 4, 4, 4, 6 };
			DailyCodingProblem10242018 dcp = new DailyCodingProblem10242018();
			Console.WriteLine(dcp.FindUnique(numbers));
			*/

			/*
			DailyCodingProblem10222018 dcp = new DailyCodingProblem10222018();
			int max = Int32.Parse(args[0]);
			for (int i = 1; i <= max; i++)
			{
				dcp.QueensOnChessBoard(i);
			}
			*/

			/*
			DailyCodingProblem10212018 dcp = new DailyCodingProblem10212018();
			dcp.PrintSubsets(args[0]);
			*/

			/*
			DailyCodingProblem10202018 dcp = new DailyCodingProblem10202018();
			Console.WriteLine(dcp.SecondLargest(dcp.CreateBST()));
			*/

			/*
			StringBuilder input = new StringBuilder(args[0]);
			DailyCodingProblem10192018 dcp = new DailyCodingProblem10192018();
			Console.WriteLine(dcp.SortRGB(input));
			*/

			/*
			DailyCodingProblem10152018 dcp = new DailyCodingProblem10152018();
			Console.WriteLine(dcp.EditDistance(args[0], args[1]));
			*/

			/*
			DailyCodingProblem10132018 dcp = new DailyCodingProblem10132018();
			Console.WriteLine(dcp.RunLengthEncode(args[0]));
			*/

			/*
			DailyCodingProblem10112018 dcp = new DailyCodingProblem10112018();
			Console.WriteLine(dcp.BracketsBalanced(args[0]));
			*/

			/*
			DailyCodingProblem10082018 dcp = new DailyCodingProblem10082018();
			LockTree tree = dcp.BuildTree();
			dcp.LockUnlock(22, true, tree);
			dcp.LockUnlock(10, true, tree);
			dcp.LockUnlock(10, false, tree);
			dcp.LockUnlock(22, false, tree);
			dcp.LockUnlock(10, true, tree);
			dcp.LockUnlock(10, false, tree);
			*/

			/*
			DailyCodingProblem10092018 dcp = new DailyCodingProblem10092018();
			string regex = args[0];
			string input = args[1];
			Console.WriteLine(dcp.RegEx(regex, input));
			*/

			/*
			DailyCodingProblem10102018 dcp = new DailyCodingProblem10102018(Int32.Parse(args[0]));
			dcp.DeleteK(Int32.Parse(args[1]));
			*/
		}
	}
}
