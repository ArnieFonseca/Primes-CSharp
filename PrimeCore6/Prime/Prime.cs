 
namespace Prime ;
 
public static class Calculator
{
    #region Constant
    const int ZERO = 0; 
    #endregion

    #region Functions
    /// <summary>
    /// Obtain the List of Primes Numbers
    /// </summary>
    public static List<int> GetPrimes(List<int> numbers)
    {
        List<int> rst = new();
        return GetPrimesHelper(numbers, rst);
    }

    /// <summary>
    /// Tail Recursive Helper function to get all the Primes Number fro the Original Sequence
    /// </summary>
    private static List<int> GetPrimesHelper(List<int> numbers, List<int> rst)
    {
        return (numbers.Count == ZERO)
            ? rst
            : GetPrimesHelper(RemoveFactor(numbers), AddPrime(numbers, rst))
            ;
    }

    /// <summary>
    /// Filter the List/Array deleting all factors of the List Head
    /// </summary>
    private static List<int> RemoveFactor(List<int> numbers)
    {
        return numbers.Where(n => n % numbers.First() != ZERO).ToList();
    }

    /// <summary>
    /// The Head of the List/Array is added to the resulting List
    /// </summary>
    private static List<int> AddPrime(List<int> numbers, List<int> rst)
    {
        return rst.Append(numbers.First()).ToList();
    }
    #endregion
}
