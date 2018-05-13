using System;

namespace data_structure
{
    public static class GFG
    {
        // An optimized version of Bubble Sort
        public static void bubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap arr[j] and arr[j+1]
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were 
                // swapped by inner loop, then break
                if (swapped == false)
                    break;
            }
        }

        // Function to print an array 
        public static void printArray(int[] arr, int size)
        {
            int i;
            for (i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        // public static Node MergeTwoLinkedList(LinkedList v1, LinkedList v2)
        // {
        //     Node startNode, p1 = null, p2 = null;
        //     LinkedList linkedList;

        //     p1 = v1.Start;
        //     p2 = v2.Start;
        //     if (v1.Start.Info < v2.Start.Info)
        //     {
        //         startNode = new Node(v1.Start.Info);
        //         p1 = p1.Next;
        //     }
        //     else
        //     {
        //         startNode = new Node(v2.Start.Info);
        //         p2 = p2.Next;
        //     }
        //     linkedList = new LinkedList(startNode.Info);
        //     Node startm = startNode;
        //     while (p1 != null && p2 != null)
        //     {
        //         if (p1.Info > p2.Info)
        //         {
        //             startm.Next = new Node(p2.Info);
        //             p2 = p2.Next;
        //         }
        //         else
        //         {
        //             startm.Next = new Node(p1.Info);
        //             p1 = p1.Next;
        //         }
        //         startm = startm.Next;
        //     }
        //     while (p1 != null)
        //     {
        //         startm.Next = new Node(p1.Info);
        //         p1 = p1.Next;
        //     }
        //     while (p2 != null)
        //     {
        //         startm.Next = new Node(p2.Info);
        //         p2 = p2.Next;
        //     }
        //     return startNode;
        // }
    }
}