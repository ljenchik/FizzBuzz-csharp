namespace FizzBuzz
{
    public class FizzBuzz
    {


        public int indexOfB(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
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
                if (result.Count == 0)
                {
                    result.Add(i.ToString());
                }
                Console.WriteLine(string.Join("", result));
            }
        }
    }
}



