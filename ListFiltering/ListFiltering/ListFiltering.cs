namespace ListFiltering;

public class ListFiltering
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        return listOfItems.Where(x=> x is int).Select(x => (int)x);
    }
}