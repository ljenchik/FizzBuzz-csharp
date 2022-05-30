namespace FizzBuzz
{
    public class FizzBuzz
    {
        public int indexOfB(List<String> arr)
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
        public static List<String> Splice(List<String> result, int index)
        {
            List<String> firstPart = result.GetRange(0, index);
            firstPart.Add("Fezz");
            List<String> secondPart = result.GetRange(index, result.Count - index);
            firstPart.AddRange(secondPart);
            return firstPart;
        }

        public void DoFizzBuzz(int maxNumber)
        {
            for (int i = 1; i <= maxNumber; i++)
            {
                List<string> result = new List<string>();
                if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                if (i % 7 == 0)
                {
                    result.Add("Bang");
                }
                if (i % 11 == 0)
                {
                    result = new List<string>
                    {
                        "Bong"
                    };
                }
                if (i % 13 == 0)
                {
                    if (indexOfB(result) == -1)
                    {
                        result.Add("Fezz");
                    }
                    else
                    {
                        result = Splice(result, indexOfB(result));
                    }
                }
                if (i % 17 == 0)
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



