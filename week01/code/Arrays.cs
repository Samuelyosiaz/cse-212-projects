public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Here I am creating the array that will hold the multiples of the number. The size of the array is determined by the length parameter.
        var multiples = new double[length];

        //Here I am using a for loop to populate the multiples array. The loop runs from 0 to length - 1, and in each iteration, it calculates the multiple of the number by multiplying it with (i + 1) and assigns it to the corresponding index in the multiples array.
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static List<int> RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Here I am creating a new list called rotatedList that will hold the values that have been rotated to the right. The size of the list is determined by the amount parameter, which indicates how many elements from the end of the original list will be moved to the front of the rotated list.
        var rotatedList = new List<int>(amount);
        //Here I am getting the values from the original list that need to be rotated to the right.
        rotatedList = data.GetRange(data.Count - amount, amount);
        //Here I am removing the values from the original list that have been moved to the front of the rotated list.
        data.RemoveRange(data.Count - amount, amount);
        //Here I am inserting the rotated values at the beginning of the original list.
        data.InsertRange(0, rotatedList);

        return data;
    }
}
