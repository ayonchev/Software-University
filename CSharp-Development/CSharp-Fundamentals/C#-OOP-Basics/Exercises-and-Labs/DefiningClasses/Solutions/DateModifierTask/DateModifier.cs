using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class DateModifier
{
    private DateTime firstDate;
    private DateTime secondDate;
    private int difference;
    public DateModifier(string firstDate, string secondDate)
    {
        int[] firstDateCharacteristics = firstDate
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int[] secondDateCharacteristics = secondDate
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        this.firstDate = new DateTime(firstDateCharacteristics[0], firstDateCharacteristics[1], firstDateCharacteristics[2]);
        this.secondDate = new DateTime(secondDateCharacteristics[0], secondDateCharacteristics[1], secondDateCharacteristics[2]);
        this.difference = Math.Abs((this.firstDate - this.secondDate).Days);
    }

    public int Difference
    {
        get { return this.difference; }
    }
}
