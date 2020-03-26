using System;
using System.Collections.Generic;
using System.Text;

public class Box
{
    private const string ERROR_MSG = " cannot be zero or negative.";
    private decimal length;
    private decimal width;
    private decimal height;

    private decimal Length
    {
        get { return this.length; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length" + ERROR_MSG);
            }
            this.length = value;
        }
    }

    private decimal Width
    {
        get { return this.width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width" + ERROR_MSG);
            }
            this.width = value;
        }
    }

    private decimal Height
    {
        get { return this.height; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height" + ERROR_MSG);
            }
            this.height = value;
        }
    }

    public Box(decimal length, decimal width, decimal height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    private decimal GetBoxSurfaceArea()
    {
        return 2 * (length * width + width * height + length * height);
    }

    private decimal GetBoxLateralSurfaceArea()
    {
        return 2 * (length * height + width * height);
    }

    private decimal GetBoxVolume()
    {
        return length * width * height;
    }

    public override string ToString()
    {
        decimal surfaceArea = GetBoxSurfaceArea();
        decimal lateralSurfaceArea = GetBoxLateralSurfaceArea();
        decimal volume = GetBoxVolume();

        string result = $"Surface Area - {surfaceArea:F2}\r\n" +
                        $"Lateral Surface Area - {lateralSurfaceArea:F2}\r\n" +
                        $"Volume - {volume:F2}";
        return result;
    }
}

