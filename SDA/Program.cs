using SDA.Algorithms;
using System.Diagnostics;

#region Algorithms
// Selection Sort
Console.WriteLine("SELECTION SORT");
int[] selectionSort = { -11, 12, -42, 0, 1, 90, 68, 6, -9, 10, 11, -15, 8 };
var sw = Stopwatch.StartNew();
SelectionSort.Sort(selectionSort);
sw.Stop();
Console.Write(string.Join(" | ", selectionSort));
Console.WriteLine(" TIME: " + sw.Elapsed.TotalMilliseconds);

// Insertion Sort
Console.WriteLine("INSERTION SORT");
int[] insertionSort = { -11, 12, -42, 0, 1, 90, 68, 6, -9, 10, 11, -15, 8 };
sw = Stopwatch.StartNew();
InsertionSort.Sort(insertionSort);
sw.Stop();
Console.Write(string.Join(" | ", insertionSort));
Console.WriteLine(" TIME: " + sw.Elapsed.TotalMilliseconds);

// Bubble Sort
Console.WriteLine("BUBBLE SORT");
int[] bubbleSort = { -11, 12, -42, 0, 1, 90, 68, 6, -9, 10, 11, -15, 8 };
sw = Stopwatch.StartNew();
BubbleSort.Sort(bubbleSort);
sw.Stop();
Console.Write(string.Join(" | ", bubbleSort));
Console.WriteLine(" TIME: " + sw.Elapsed.TotalMilliseconds);

// Quick Sort
Console.WriteLine("QUICK SORT");
int[] quickSort = { -11, 12, -42, 0, 1, 90, 68, 6, -9, 10, 11, -15, 8 };
sw = Stopwatch.StartNew();
BubbleSort.Sort(quickSort);
sw.Stop();
Console.Write(string.Join(" | ", quickSort));
Console.WriteLine(" TIME: " + sw.Elapsed.TotalMilliseconds);
#endregion