public class Program
{
    public static void Main(string[] args)
    {
        ArrayList<int> list = new ArrayList<int>();
        for (int i = 0; i < 10; i++)
        {
            list.Add(i);
        }

        for (int i = 7; i >= 0; i--)
        {
            list.RemoveAt(i);
        }
    }
}
