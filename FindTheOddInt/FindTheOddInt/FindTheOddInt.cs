namespace FindTheOddInt;

public class FindTheOddInt
{

        public static int find_it(int[] seq)
        {
            var groupByList = seq.ToList().GroupBy(i => i);
            var dictionary =
                groupByList
                    .Select(i => new { i.Key, count = i.Count() });
            var key = dictionary.FirstOrDefault(x => x.count % 2 == 1)!.Key;
            return key;
        }
       
    
}