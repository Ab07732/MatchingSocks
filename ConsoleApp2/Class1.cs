using System;

class GFG
{

    // Function to count the minimum
    // number of socks to be picked
    public static int findMin(int[] arr, int N, int k)
    {
        // Stores the total count
        // of pairs of socks
        int pairs = 0;

        // Find the total count of pairs
        for (int i = 0; i < N; i++)
        {
            pairs += arr[i] / 2;
        }

        // If K is greater than pairs
        if (k > pairs)
            return -1;

        // Otherwise
        else
            return 2 * k + N - 1;
    }

    // Driver Code
    public static void Main(string[] args)
    {
        int[] arr = { 4, 5, 6 };
        int K = 1;
        int N = arr.Length;
        Console.WriteLine(findMin(arr, N, K));
    }
}

