namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            var result = new List<string>();

            for (var i = 1; i <= count; i++)
            {
                if (IsMultipleOf(3, i) && IsMultipleOf(5, i))
                    result.Add("FizzBuzz");
                else if (IsMultipleOf(3, i))
                    result.Add("Fizz");
                else if (IsMultipleOf(5, i))
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());
            }

            return result;
        }


        private static bool IsMultipleOf(int multiple, int dividend) => dividend % multiple == 0;
    }
}