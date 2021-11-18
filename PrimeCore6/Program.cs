
#region Constants
const int ONE = 1;
const int TWO = 2;
const int LIMIT = 20;
#endregion

#region Main Logic
// Create consequent integers starting with two until Limit 
var numbers = Enumerable.Range(TWO, LIMIT - ONE).ToList();

// Generate Primes Numbers from sequence
var result = Prime.Calculator.GetPrimes(numbers);

// Display the Original List
numbers.ForEach(n => Write($"{n} "));

WriteLine();

//Display the Prime Numbers
result.ForEach(p => Write($"{p} "));
#endregion
