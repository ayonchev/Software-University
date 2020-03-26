using System;
using System.Collections.Generic;
using System.Text;

public class Room
{
    public Room()
    {
        this.TreatedPet = null;
        this.IsEmpty = true;
    }

    public Pet TreatedPet { get; private set; }
    public bool IsEmpty { get; private set; }

    public void Add(Pet currentPet)
    {
        this.TreatedPet = currentPet;
        this.IsEmpty = false;
    }

    public void Release()
    {
        this.TreatedPet = null;
        IsEmpty = true;
    }

    public override string ToString()
    {
        if (IsEmpty)
        {
            return "Room empty";
        }

        return $"{this.TreatedPet}";
    }
}