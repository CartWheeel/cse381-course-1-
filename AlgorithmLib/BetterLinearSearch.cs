namespace AlgorithmLib;

public static class BetterLinearSearch
{
    public static int Search(List<IComparable> data, IComparable target)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        //Procedure BETTER-LINEAR-SEARCH(A,n,x)
        // Inputs:
        //  - A: an array.
        //  - n: the number of elements in A to search through.
        //  - x: the value being searched for.
        //
        // Outputs: Either an index i for which A[i] = x, or the special value NOT-FOUND,
        // which could be any invalid index into the array, such as 0 or any negative integer.
        
        var answer = -1;                         // set -1 answer to NOT-FOUND
        for (var i = 0; i < data.Count; i++)        // 1. For i = 1 to n:
        {
            if (data[i]. Equals(target))            //     A. If A[i] = x,
            {
                return i;                           //        then return the value of i as the output.    
            }
        }
        return answer;                              // 2. Return NOT-FOUND as the output.
        
        
        // Procedure LINEAR-SEARCH(A,n,x)
        // Inputs:
        //  - A: an array.
        //  - n: the number of elements in A to search through.
        //  - x: the value being searched for.
        //
        // Outputs: Either an index i for which A[i] = x, or the special value NOT-FOUND,
        // which could be any invalid index into the array, such as 0 or any negative integer.
        //
        //
        // var answer = -1;                         //1. Set answer to NOT-FOUND.
        // for (var i = 0; i < data.Count; i++)     //2. For each index i, going from 1 to n, in order:
        // {
        //     if (data[i]. Equals(target))         //   A. If A[i] = x,
        //     {
        //         answer = i;                      //       then set answer to the value of i.
        //     }
        // }
        // return answer;                           //3. Return the value of answer as the output.
    }
}