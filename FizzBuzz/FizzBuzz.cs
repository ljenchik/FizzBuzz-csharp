namespace FizzBuzz
{
    public class FizzBuzz
    {

        private bool IsDivisible(int number, int divisor)
        {
            return number % divisor == 0;
        }

        private int indexOfB(List<String> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].StartsWith("B"))
                {
                    return i;
                }
            }
            return -1;
        }
        public void DoFizzBuzz(int maxNumber)
        {
            for (int i = 1; i <= maxNumber; i++)
            {
                List<string> result = new List<string>();
                if (IsDivisible(i, 3))
                {
                    result.Add("Fizz");
                }
                if (IsDivisible(i, 5))
                {
                    result.Add("Buzz");
                }
                if (IsDivisible(i, 7))
                {
                    result.Add("Bang");
                }
                if (IsDivisible(i, 11))
                {
                    result = new List<string>
                    {
                        "Bong"
                    };
                }
                if (IsDivisible(i, 13))
                {
                    if (indexOfB(result) == -1)
                    {
                        result.Add("Fezz");
                    }
                    else
                    {
                        result.Insert(indexOfB(result), "Fezz");
                    }
                }
                if (IsDivisible(i, 17))
                {
                    result.Reverse();
                }
                if (result.Count == 0)
                {
                    result.Add(i.ToString());
                }
                Console.WriteLine(string.Join("", result));
            }
        }
    }
}



