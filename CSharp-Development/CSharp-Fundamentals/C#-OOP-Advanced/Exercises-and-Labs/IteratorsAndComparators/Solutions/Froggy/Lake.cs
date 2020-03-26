using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Lake : IEnumerable<int>
{
    private List<int> stones;

    public Lake(List<int> stones)
    {
        this.stones = stones;
    }


    public string PrintStones()
    {
        string result = String.Empty;

        foreach (var stone in this)
        {
            result += stone + ", ";
        }

        return result.TrimEnd(new char[] {',', ' '});
    }
    public IEnumerator<int> GetEnumerator()
    {
        for (int index = 0; index < stones.Count; index += 2)
        {
            yield return stones[index];
        }

        int lastIndex = stones.Count - 1;

        if (stones.Count % 2 != 0)
        {
            lastIndex--;
        }

        for (int index = lastIndex; index >= 0; index -= 2)
        {
            yield return stones[index];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
