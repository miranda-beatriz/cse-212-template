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
        // 1. Create an array of doubles with the size of 'length'.
        // 2. Use a for loop to iterate from 0 to length - 1
        // 3. In each iteration, calculate the multiple of 'number' by multiplying it with (i + 1).
        // 4. Store the result in the array at index 'i'.

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // 1. Check if the data list is empty or if amount is 0, in which case we can return immediately.
        // 2. Calculate the effective rotation amount by taking the modulus of amount with the count    
        //    of the data list to handle cases where amount is greater than the list size.
        // 3. If the effective rotation amount is 0, return immediately as no rotation is needed.
        // 4. Split the list into two parts: the last 'amount' elements and the rest of the list.
        // 5. Concatenate the two parts in reverse order to achieve the right rotation.
        if (data.Count == 0 || amount <= 0)
        {
            return;
        }
        int effectiveAmount = amount % data.Count;
        if (effectiveAmount == 0)
        {
            return;
        }
        List<int> lastPart = data.GetRange(data.Count - effectiveAmount, effectiveAmount);
        List<int> firstPart = data.GetRange(0, data.Count - effectiveAmount);
        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(firstPart);


    }
}
