namespace OrderedCountofCharacters;

public class OrderedCountofCharacters
{
    public static List<Tuple<char, int>> OrderedCount(string input) {
        var list = new List<Tuple<char, int>>();
        while (input.Length != 0)
        {
            var firstChar = input[0];
            var counter = 0;
            foreach (var item in input)
            {
                if (item == firstChar)
                    counter++;
            }
            list.Add(Tuple.Create(firstChar, counter));
            input = input.Replace(firstChar.ToString(), "");
        }
        return list;
    }
}