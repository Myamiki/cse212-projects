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
    // Step 1: Create an array with enough spaces to hold the requested number of multiples.
double[] multiples = new double[length];

    // Step 2: Use a for loop starting at index 0 and repeat until all array positions have been visited.
    for (int i = 0; i < length; i++)
    {
        // Step 3: Multiply the starting number by the loop position plus one.
        // Step 4: Store each calculated multiple in its correct array position.
        multiples[i] = number * (i + 1);
    }

    // Step 5: Return the completed array.

    return multiples;
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
    // Step 1: Find the position where the last 'amount' numbers begin.
    int start = data.Count - amount;

    // Step 2: Copy the last 'amount' numbers into a temporary list.
    List<int> lastNumbers = data.GetRange(start, amount);

    // Step 3: Remove those numbers from the original list.
    data.RemoveRange(start, amount);

    // Step 4: Add the temporary list to the beginning of the original list.
    data.InsertRange(0, lastNumbers);
}
}
